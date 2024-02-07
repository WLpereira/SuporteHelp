Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.ComponentModel

Public Class Ferramenta_Cloud
    Private e As Object

    Private Sub ConectarCloudBtn_Click(sender As Object, e As EventArgs) Handles ConectarCloudBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorCloudTxb.Text.Trim()
        Dim usuario As String = NomeConectarCloudTxb.Text
        Dim senha As String = SenhaCloudTxb.Text

        ' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Verifica se o servidor informado não é um dos servidores bloqueados
        If servidor.Contains("dp01.informo.com.br,9797") OrElse servidor.Contains("dp01.informo.com.br,9898") Then
            MessageBox.Show("Por motivos de segurança, esses servidores não podem ser acessados.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha
        ' Cria uma DataTable para armazenar os resultados da consulta fora do bloco Try
        Dim dt As New DataTable()

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                conexaoBD.Open()

                ' Iniciar transação explícita
                Using transacao As SqlTransaction = conexaoBD.BeginTransaction()
                    Try
                        ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                        Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb') order by name", conexaoBD, transacao)
                        Dim leitor As SqlDataReader = comando.ExecuteReader()

                        ' Carrega os dados do leitor para o DataTable
                        dt.Load(leitor)

                        ' Adiciona as colunas 'VERSAOBCODADOS', 'DtBCodados' e 'LOGEVENTO' ao DataTable
                        dt.Columns.Add("VERSAOBCODADOS", GetType(String))
                        dt.Columns.Add("DATA_DO_DBA", GetType(String))
                        dt.Columns.Add("LOGEVENTO", GetType(String)) ' Nova coluna para armazenar o resultado da consulta LOGEVENTO

                        ' Itera sobre as linhas do DataTable
                        For Each row As DataRow In dt.Rows
                            Dim nomeBanco As String = row("Nome").ToString()

                            ' Executa a consulta SQL para obter as informações do Parametro, considerando que a tabela pode não existir
                            Dim queryParametro As String = $"IF OBJECT_ID('{nomeBanco}.dbo.parametro', 'U') IS NOT NULL SELECT TOP 1 VERSAOBCODADOS, dtbcodados as DATA_DO_DBA FROM {nomeBanco}.dbo.parametro"
                            Dim comandoParametro As New SqlCommand(queryParametro, conexaoBD, transacao)
                            Dim leitorParametro As SqlDataReader = comandoParametro.ExecuteReader()

                            ' Verifica se há resultados
                            If leitorParametro.Read() Then
                                ' Preenche os valores nas colunas adicionadas
                                row("VERSAOBCODADOS") = leitorParametro("VERSAOBCODADOS").ToString()
                                row("DATA_DO_DBA") = leitorParametro("DATA_DO_DBA").ToString()
                            Else
                                ' Se não houver resultados, define os valores como vazios
                                row("VERSAOBCODADOS") = String.Empty
                                row("DATA_DO_DBA") = String.Empty
                            End If

                            ' Fecha o leitor de dados da consulta de parâmetros
                            leitorParametro.Close()
                            ' Executa a consulta SQL para verificar a existência da tabela 'logevento'
                            Dim queryVerificarTabela As String = "SELECT COUNT(*) FROM sys.tables WHERE name = 'logevento';"
                            Dim comandoVerificarTabela As New SqlCommand(queryVerificarTabela, conexaoBD, transacao)
                            Dim tabelaExiste As Integer = Convert.ToInt32(comandoVerificarTabela.ExecuteScalar())

                            If tabelaExiste = 0 Then
                                ' A tabela 'logevento' não existe no banco de dados
                                MessageBox.Show("A tabela 'logevento' não existe no banco de dados.")
                            Else
                                ' A tabela 'logevento' existe, então executamos a consulta para obter o tamanho
                                Dim queryLOGEVENTO As String = "SELECT " &
      "CAST(ROUND(((SUM(a.total_pages) * 8) / 1024.00), 2) AS NUMERIC(36, 2)) AS TotalSpaceMB " &
      "FROM " &
      "sys.tables t " &
      "INNER JOIN " &
      "sys.indexes i ON t.OBJECT_ID = i.object_id " &
      "INNER JOIN " &
      "sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id " &
      "INNER JOIN " &
      "sys.allocation_units a ON p.partition_id = a.container_id " &
      "LEFT OUTER JOIN " &
      "sys.schemas s ON t.schema_id = s.schema_id " &
      "WHERE " &
      "t.NAME = 'logevento';"

                                Dim comandoLOGEVENTO As New SqlCommand(queryLOGEVENTO, conexaoBD, transacao)
                                Dim LOGEVENTO As Object = comandoLOGEVENTO.ExecuteScalar()

                                ' Verifica se há resultados
                                If LOGEVENTO IsNot Nothing AndAlso LOGEVENTO IsNot DBNull.Value Then
                                    ' Preenche o valor diretamente na célula 'LOGEVENTO'
                                    row("LOGEVENTO") = $"{Convert.ToDecimal(LOGEVENTO):N2} MB"
                                Else
                                    ' Se a tabela existe, mas não há registros
                                    MessageBox.Show("A tabela 'logevento' existe no banco de dados, mas não há registros.")
                                End If
                            End If
                        Next
                    Catch ex As Exception
                        ' Rollback em caso de erro
                        transacao.Rollback()
                        MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
                    End Try

                    ' Popula o DataGridView com os nomes dos bancos de dados, VERSAO_DO_BANCO, DATA_DO_DBA e LOGEVENTO
                    ListadeServidorCloudDtg.DataSource = dt
                    ListadeServidorCloudDtg.Columns(0).Width = 200

                    ' Commit da transação
                    transacao.Commit()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao estabelecer a conexão: " & ex.Message)
        End Try
    End Sub


    Private Function ExisteConexaoSalva(servidor As String, usuario As String, senha As String) As Boolean
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Verifica se alguma linha possui a mesma combinação de servidor, usuário e senha
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidor AndAlso dados(1) = usuario AndAlso dados(2) = senha Then
                    ' A combinação de servidor, usuário e senha já existe no arquivo de texto
                    Return True
                End If
            Next
        End If

        ' A combinação de servidor, usuário e senha não foi encontrada no arquivo de texto
        Return False
    End Function

    Private Sub SalvarDadosConexao(servidor As String, usuario As String, senha As String)
        ' Cria uma linha com os dados de conexão separados por vírgula
        Dim linha As String = servidor & "," & usuario & "," & senha

        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Adiciona a linha ao arquivo de texto, somente se a conexão for válida
        If ValidarConexao(servidor, usuario, senha) Then
            ' Verifica se a linha já existe no arquivo antes de adicioná-la
            If Not ExisteConexaoSalva(servidor, usuario, senha) Then
                File.AppendAllText(caminhoArquivo, linha & Environment.NewLine)
            End If
        End If
    End Sub

    Private Sub CarregarServidoresSalvos()
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Cria uma lista para armazenar os servidores salvos
            Dim listaServidores As New List(Of String)

            ' Popula a lista com os servidores salvos
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 Then
                    listaServidores.Add(dados(0)) ' Adiciona apenas o servidor à lista
                End If
            Next

            ' Popula o ComboBox com os servidores salvos
            ExibirServidorCloudCbx.DataSource = listaServidores
        End If
    End Sub

    Private Function ValidarConexao(servidor As String, usuario As String, senha As String) As Boolean
        ' Implemente aqui a lógica de validação da conexão
        ' Retorne True se a conexão for válida, ou False caso contrário
        Return True ' Exemplo: sempre retorna True para fins de demonstração
    End Function

    Private Sub SuporteHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub

    Private Sub ExibirServidorCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorCloudCbx.SelectedIndexChanged
        ' Obtém o servidor selecionado no ComboBox
        Dim servidorSelecionado As String = ExibirServidorCloudCbx.SelectedItem.ToString()

        ' Verifica se o arquivo de dados de conexão existe
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Percorre as linhas e procura pelo servidor selecionado
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidorSelecionado Then
                    ' Preenche os campos com os valores correspondentes
                    ServidorCloudTxb.Text = dados(0)
                    NomeConectarCloudTxb.Text = dados(1)
                    SenhaCloudTxb.Text = dados(2)
                    Exit For ' Interrompe o loop após encontrar os dados correspondentes
                End If
            Next
        End If
    End Sub


    Private Sub MostrarTamanhoBtn_Click(sender As Object, e As EventArgs) Handles MostrarTamanhoBtn.Click
        If Not BackgroundWorker1.IsBusy Then
            ' Exibir o ProgressBar
            progressoPb.Visible = True

            ' Iniciar o BackgroundWorker
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Configurar o BackgroundWorker para relatar progresso
        DirectCast(sender, BackgroundWorker).WorkerReportsProgress = True

        ' Verifica se o DataGridView está vazio
        If ListadeServidorCloudDtg.Rows.Count = 0 Then
            MessageBox.Show("Necessário conectar no servidor.")
            Return
        End If

        ' String de conexão com o banco de dados. Substitua pelos seus próprios detalhes de conexão.
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = ServidorCloudTxb.Text
        builder.UserID = NomeConectarCloudTxb.Text
        builder.Password = SenhaCloudTxb.Text
        builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
        Dim connectionString As String = builder.ConnectionString

        ' Crie uma conexão com o banco de dados
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abra a conexão
                connection.Open()

                ' Comando SQL para executar
                Dim sql As String = "
DROP TABLE IF EXISTS #tmp
CREATE TABLE #tmp
(
    [database_name]     VARCHAR(MAX),
    [database_size]     VARCHAR(MAX),
    [unallocated space] VARCHAR(MAX),
    [reserved]          VARCHAR(MAX),
    [data]              VARCHAR(MAX),
    [index_size]        VARCHAR(MAX),
    [unused]            VARCHAR(MAX)
);

EXEC sys.sp_MSforeachdb 'USE [?]
IF DB_NAME() NOT IN (''tempdb'', ''msdb'', ''model'', ''master'')
BEGIN
    INSERT #tmp EXEC sp_spaceused @oneresultset = 1
END'

SELECT *,
       IIF(CAST(CAST(REPLACE(database_size, ' MB', '') AS FLOAT) / 1000 AS DECIMAL(10, 2)) < 1.00
           , CONCAT(CAST(REPLACE(database_size, ' MB', '') AS FLOAT), ' MB')
           , CONCAT(CAST(CAST(REPLACE(database_size, ' MB', '') AS FLOAT) / 1000 AS DECIMAL(10, 2)), ' GB')
           ) AS 'database_size'
FROM #tmp
ORDER BY TRY_CAST(REPLACE(database_size, ' MB', '') AS FLOAT) DESC"

                ' Crie um objeto SqlCommand
                Dim command As New SqlCommand(sql, connection)

                ' Defina o tempo limite da consulta para 0 (ilimitado)
                command.CommandTimeout = 0

                ' Crie um adaptador de dados para preencher um DataSet
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()

                ' Preencha o DataSet com os resultados da consulta
                adapter.Fill(dataSet)

                ' Reporte o progresso para o BackgroundWorker
                ' Aqui o progresso é relativo ao número de linhas retornadas pelo DataSet
                BackgroundWorker1.ReportProgress(dataSet.Tables(0).Rows.Count, dataSet)
            Catch ex As Exception
                MessageBox.Show("Erro ao executar o comando SQL: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Atualize o valor atual do ProgressBar com base no progresso relatado
        progressoPb.Value = e.ProgressPercentage

        ' Não é necessário atualizar o valor máximo do ProgressBar aqui

        ' Vincule o DataSet à sua DataGridView
        ListadeServidorCloudDtg.DataSource = DirectCast(e.UserState, DataSet).Tables(0)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Ocultar o ProgressBar após a conclusão da consulta
        progressoPb.Visible = False
    End Sub
End Class
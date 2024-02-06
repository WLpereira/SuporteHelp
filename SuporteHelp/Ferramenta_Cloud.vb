Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
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

                        ' Cria uma DataTable para armazenar os resultados da consulta
                        Dim dt As New DataTable()
                        dt.Load(leitor)

                        ' Adiciona as colunas 'VersaoBCodados', 'DtBCodados' e 'LOGEVENTO' ao DataTable
                        dt.Columns.Add("VersaoBCodados", GetType(String))
                        dt.Columns.Add("DtBCodados", GetType(String))
                        dt.Columns.Add("LOGEVENTO", GetType(String))

                        ' Itera sobre as linhas do DataTable
                        For Each row As DataRow In dt.Rows
                            Dim nomeBanco As String = row("Nome").ToString()

                            ' Executa a consulta SQL para obter as informações do Parametro, considerando que a tabela pode não existir
                            Dim queryParametro As String = $"IF OBJECT_ID('{nomeBanco}.dbo.parametro', 'U') IS NOT NULL SELECT TOP 1 versaobcodados, dtbcodados FROM {nomeBanco}.dbo.parametro"
                            Dim comandoParametro As New SqlCommand(queryParametro, conexaoBD, transacao)
                            Dim leitorParametro As SqlDataReader = comandoParametro.ExecuteReader()

                            ' Verifica se há resultados
                            If leitorParametro.Read() Then
                                ' Preenche os valores nas colunas adicionadas
                                row("VersaoBCodados") = leitorParametro("versaobcodados").ToString()
                                row("DtBCodados") = leitorParametro("dtbcodados").ToString()
                            Else
                                ' Se não houver resultados, define os valores como vazios
                                row("VersaoBCodados") = String.Empty
                                row("DtBCodados") = String.Empty
                            End If

                            ' Fecha o leitor de dados da consulta de parâmetros
                            leitorParametro.Close()

                            ' Executa a consulta SQL para obter o tamanho da tabela 'logevento'
                            Dim queryLOGEVENTO As String = $"DECLARE @TamanhoGB DECIMAL(18, 2); " &
                                                           $"IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'logevento' AND schema_id = SCHEMA_ID('dbo')) " &
                                                           $"BEGIN " &
                                                           $"    SELECT @TamanhoGB = SUM(reserved_page_count) / 128.0 " &
                                                           $"    FROM sys.dm_db_partition_stats " &
                                                           $"    WHERE object_id = OBJECT_ID('{nomeBanco}.dbo.logevento'); " &
                                                           $"END; " &
                                                           $"SELECT @TamanhoGB AS TamanhoGB;"

                            Dim comandoLOGEVENTO As New SqlCommand(queryLOGEVENTO, conexaoBD, transacao)
                            Dim LOGEVENTO As Object = comandoLOGEVENTO.ExecuteScalar()

                            ' Adiciona a coluna 'LOGEVENTO' se ainda não estiver presente
                            If Not dt.Columns.Contains("LOGEVENTO") Then
                                dt.Columns.Add("LOGEVENTO", GetType(String))
                            End If

                            ' Preenche o valor diretamente na célula 'LOGEVENTO'
                            If LOGEVENTO IsNot Nothing AndAlso LOGEVENTO IsNot DBNull.Value Then
                                row("LOGEVENTO") = $"{Convert.ToDecimal(LOGEVENTO):N2} GB"
                            Else
                                ' Se a tabela não existe, mantém o valor existente
                            End If
                        Next

                        ' Popula o DataGridView com os nomes dos bancos de dados, VersaoBCodados, DtBCodados e LOGEVENTO
                        ListadeServidorCloudDtg.DataSource = dt
                        ListadeServidorCloudDtg.Columns(0).Width = 200

                        ' Commit da transação
                        transacao.Commit()
                    Catch ex As Exception
                        ' Rollback em caso de erro
                        transacao.Rollback()
                        MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
                    End Try
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
    Private Sub LogEventoBtn_Click(sender As Object, e As EventArgs) Handles LogEventoBtn.Click
        ' Limpa o DataGridView
        ListadeServidorCloudDtg.DataSource = Nothing
        ListadeServidorCloudDtg.Rows.Clear()

        ' Verifica se todos os campos foram preenchidos
        Dim servidor As String = ServidorCloudTxb.Text.Trim()
        Dim usuario As String = NomeConectarCloudTxb.Text
        Dim senha As String = SenhaCloudTxb.Text

        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = $"Server={servidor};User Id={usuario};Password={senha}"

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

                        ' Cria uma DataTable para armazenar os resultados da consulta
                        Dim dt As New DataTable()
                        dt.Load(leitor)

                        ' Adiciona as colunas 'VersaoBCodados' e 'DtBCodados' ao DataTable
                        dt.Columns.Add("VersaoBCodados", GetType(String))
                        dt.Columns.Add("DtBCodados", GetType(String))
                        dt.Columns.Add("LOGEVENTO", GetType(String)) ' Nova coluna para o tamanho da tabela logevento

                        ' Itera sobre as linhas do DataTable
                        For Each row As DataRow In dt.Rows
                            Dim nomeBanco As String = row("Nome").ToString()

                            ' Verifica se a tabela 'logevento' existe antes de tentar obter informações relacionadas
                            Dim queryVerificaTabela As String = $"IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logevento' AND TABLE_SCHEMA = 'dbo' AND TABLE_CATALOG = '{nomeBanco}') BEGIN " &
                            $"DECLARE @TamanhoGB DECIMAL(18, 2); " &
                            $"EXEC sp_spaceused 'logevento'; END ELSE BEGIN SET @TamanhoGB = NULL; END"

                            Dim comandoVerificaTabela As New SqlCommand(queryVerificaTabela, conexaoBD, transacao)
                            Dim leitorVerificaTabela As SqlDataReader = comandoVerificaTabela.ExecuteReader()

                            ' Verifica se há resultados (se a tabela 'logevento' existe)
                            If leitorVerificaTabela.Read() Then
                                ' Executa as consultas relacionadas apenas se a tabela 'logevento' existir
                                ' ...

                                ' Executa a consulta SQL para obter as informações do Parametro, considerando que a tabela pode não existir
                                Dim queryParametro As String = $"IF OBJECT_ID('{nomeBanco}.dbo.parametro', 'U') IS NOT NULL SELECT TOP 1 versaobcodados, dtbcodados FROM {nomeBanco}.dbo.parametro"
                                Dim comandoParametro As New SqlCommand(queryParametro, conexaoBD, transacao)
                                Dim leitorParametro As SqlDataReader = comandoParametro.ExecuteReader()

                                ' Verifica se há resultados
                                If leitorParametro.Read() Then
                                    ' Preenche os valores nas colunas adicionadas
                                    row("VersaoBCodados") = leitorParametro("versaobcodados").ToString()
                                    row("DtBCodados") = leitorParametro("dtbcodados").ToString()
                                Else
                                    ' Se não houver resultados, define os valores como vazios
                                    row("VersaoBCodados") = String.Empty
                                    row("DtBCodados") = String.Empty
                                End If

                                ' Fecha o leitor de dados da consulta de parâmetros
                                leitorParametro.Close()

                                ' Executa a consulta SQL para obter o tamanho da tabela 'logevento'
                                Dim queryLOGEVENTO As String = $"EXEC sp_spaceused 'logevento';"
                                Dim comandoLOGEVENTO As New SqlCommand(queryLOGEVENTO, conexaoBD, transacao)
                                Dim leitorLOGEVENTO As SqlDataReader = comandoLOGEVENTO.ExecuteReader()

                                ' Verifica se há resultados
                                If leitorLOGEVENTO.Read() Then
                                    ' Preenche o valor na coluna 'LOGEVENTO'
                                    Dim LOGEVENTO As Object = leitorLOGEVENTO("TamanhoGB")
                                    If LOGEVENTO IsNot Nothing AndAlso LOGEVENTO IsNot DBNull.Value Then
                                        row("LOGEVENTO") = $"{Convert.ToDecimal(LOGEVENTO):N2} GB"
                                    Else
                                        row("LOGEVENTO") = String.Empty
                                    End If
                                Else
                                    ' Se não houver resultados, define o valor como vazio
                                    row("LOGEVENTO") = String.Empty
                                End If

                                ' Fecha o leitor de dados da consulta de tamanho da tabela logevento
                                leitorLOGEVENTO.Close()
                            End If

                            ' Fecha o leitor de dados da consulta de verifica tabela logevento
                            leitorVerificaTabela.Close()
                        Next

                        ' Filtra as linhas para excluir aquelas sem informações sobre a tabela 'logevento'
                        dt.DefaultView.RowFilter = "NOT LOGEVENTO IS NULL AND LOGEVENTO <> ''"
                        dt = dt.DefaultView.ToTable()

                        ' Popula o DataGridView com os nomes dos bancos de dados, VersaoBCodados, DtBCodados e LOGEVENTO
                        ListadeServidorCloudDtg.DataSource = dt
                        ListadeServidorCloudDtg.Columns(0).Width = 200

                        ' Commit da transação
                        transacao.Commit()
                    Catch ex As Exception
                        ' Rollback em caso de erro
                        transacao.Rollback()
                        MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao estabelecer a conexão: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarTamanhoBtn_Click(sender As Object, e As EventArgs) Handles MostrarTamanhoBtn.Click
        ' Verifica se o DataGridView está vazio
        If ListadeServidorCloudDtg.Rows.Count = 0 Then
            MessageBox.Show("Necessario conectar no servidor.")
            Return
        End If
        'Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()'

        ' String de conexão com o banco de dados. Substitua pelos seus próprios detalhes de conexão.
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = ServidorCloudTxb.Text
        builder.UserID = NomeConectarCloudTxb.Text
        builder.Password = SenhaCloudTxb.Text
        'builder.InitialCatalog = selectedDatabase'
        builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
        Dim connectionString As String = builder.ConnectionString

        ' Crie uma conexão com o banco de dados
        Dim connection As New SqlConnection(connectionString)

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
            ORDER BY TRY_CAST(REPLACE(database_size, ' MB', '') AS FLOAT) DESC
        "

            ' Crie um objeto SqlCommand
            Dim command As New SqlCommand(sql, connection)

            ' Defina o tempo limite da consulta para 0 (ilimitado)
            command.CommandTimeout = 0

            ' Crie um adaptador de dados para preencher um DataSet
            Dim adapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet()

            ' Preencha o DataSet com os resultados da consulta
            adapter.Fill(dataSet)

            ' Vincule o DataSet à sua DataGridView
            ListadeServidorCloudDtg.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Erro ao executar o comando SQL: " & ex.Message)
        Finally
            ' Feche a conexão
            connection.Close()
        End Try

    End Sub
End Class
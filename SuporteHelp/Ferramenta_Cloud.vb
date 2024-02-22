Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Text

Public Class Ferramenta_Cloud

    ' Declaração das variáveis no escopo da classe
    Private conexao As String = ""
    Private dtTodosBancos As New DataTable()

    Private Sub ConectarCloudBtn_Click(sender As Object, e As EventArgs) Handles ConectarCloudBtn.Click
        LimparColunaCloudBtn.Enabled = False

        ' Desabilita o botão ConectarCloudBtn 
        ConectarCloudBtn.Enabled = False
        ' Desabilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogEventoBtn.Visible = False
        MediaLogEventoBtn.Visible = False

        ' Desabilitar
        TotalLogAcessoSymBtn.Visible = False
        MediaLogAcessoSymBtn.Visible = False
        SHRINKBtn.Visible = False

        ' Limpar DataTable antes de adicionar novos dados
        dtTodosBancos.Clear()

        ' Conectar ao servidor principal
        ConectarServidor(ServidorCloudTxb.Text.Trim(), NomeConectarCloudTxb.Text, SenhaCloudTxb.Text)

        ' Verificar se o segundo servidor está preenchido
        If Not String.IsNullOrWhiteSpace(ServidorCloud2Txb.Text) Then
            ' Conectar ao servidor secundário
            ConectarServidor(ServidorCloud2Txb.Text.Trim(), NomeConectarCloudTxb.Text, SenhaCloudTxb.Text)
        End If

        ' Verificar se o terceiro servidor está preenchido
        If Not String.IsNullOrWhiteSpace(ServidorCloud3Txb.Text) Then
            ' Conectar ao terceiro servidor
            ConectarServidor(ServidorCloud3Txb.Text.Trim(), NomeConectarCloudTxb.Text, SenhaCloudTxb.Text)
        End If
    End Sub

    Private Sub ConectarServidor(servidor As String, usuario As String, senha As String)
        ' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexaoString As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        ' Atualiza a variável de conexão da classe
        conexao = conexaoString


        ' Cria uma DataTable para armazenar os resultados da consulta
        Dim dt As New DataTable()

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                conexaoBD.Open()

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name as 'Nome', @@SERVERNAME as 'NomeServidor', create_date as 'Data' FROM sys.databases WHERE state_desc <> 'OFFLINE' AND name NOT IN ('master', 'tempdb', 'model', 'msdb') order by name", conexaoBD)

                ' Carrega os dados do leitor para o DataTable
                Dim leitor As SqlDataReader = comando.ExecuteReader()
                dt.Load(leitor)

                ' Adiciona as colunas 'VERSAOBCODADOS' e 'DATA_DO_DBA' ao DataTable
                dt.Columns.Add("VERSAOBCODADOS", GetType(String))
                dt.Columns.Add("Versão do Sistema", GetType(String))
                dt.Columns.Add("DATA_DO_DBA", GetType(String))

                ' Itera sobre as linhas do DataTable
                For Each row As DataRow In dt.Rows
                    ' Executa a consulta SQL para obter as informações do Parâmetro, considerando que a tabela pode não existir
                    Dim queryParametro As String = "IF OBJECT_ID(@NomeBanco + '.dbo.parametro', 'U') IS NOT NULL " &
            "BEGIN " &
            "SELECT TOP 1 VERSAOBCODADOS, dtbcodados as DATA_DO_DBA FROM " &
            "[" & row("Nome") & "].dbo.parametro END"
                    Dim comandoParametro As New SqlCommand(queryParametro, conexaoBD)

                    ' Adiciona o parâmetro para o nome do banco de dados
                    comandoParametro.Parameters.AddWithValue("@NomeBanco", row("Nome"))

                    ' Executa o comando e processa o resultado
                    Dim leitorParametro As SqlDataReader = comandoParametro.ExecuteReader()
                    If leitorParametro.Read() Then
                        ' Preenche os valores nas colunas adicionadas
                        row("VERSAOBCODADOS") = leitorParametro("VERSAOBCODADOS").ToString()
                        row("DATA_DO_DBA") = leitorParametro("DATA_DO_DBA").ToString()

                        ' Extrai os dois dígitos do meio de "VERSAOBCODADOS" e mapeia para o formato de versão do sistema desejado
                        Dim versaoCompleta As String = row("VERSAOBCODADOS").ToString()
                        Dim versao As String = If(versaoCompleta.Length >= 6, versaoCompleta.Substring(3, 2), "")
                        versao = versao.Replace(". ", "") ' Remove o ponto e o espaço
                        Select Case versao
                            Case "40"
                                row("Versão do Sistema") = "2025.R3"
                            Case "39"
                                row("Versão do Sistema") = "2025.R2"
                            Case "38"
                                row("Versão do Sistema") = "2025.R1"
                            Case "37"
                                row("Versão do Sistema") = "2024.R3"
                            Case "36"
                                row("Versão do Sistema") = "2024.R2"
                            Case "35"
                                row("Versão do Sistema") = "2024.R1"
                            Case "34"
                                row("Versão do Sistema") = "2023.R3"
                            Case "33"
                                row("Versão do Sistema") = "2023.R2"
                            Case "32"
                                row("Versão do Sistema") = "2023.R1"
                            Case "31"
                                row("Versão do Sistema") = "2022.R3"
                            Case "30"
                                row("Versão do Sistema") = "2022.R2"
                            Case Else
                                ' Se a versão não estiver mapeada, defina a versão do sistema como "Versão não mapeada"
                                row("Versão do Sistema") = "Versão não mapeada"
                        End Select
                    Else
                        ' Se não houver resultados, define os valores como vazios
                        row("VERSAOBCODADOS") = String.Empty
                        row("DATA_DO_DBA") = String.Empty
                        row("Versão do Sistema") = String.Empty
                    End If

                    ' Fecha o leitor de dados da consulta de parâmetros
                    leitorParametro.Close()
                Next

                ' Adiciona os dados deste servidor ao DataTable geral
                dtTodosBancos.Merge(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao estabelecer a conexão ou carregar os bancos de dados: " & ex.Message)
        End Try

        ' Quando todos os servidores foram carregados, define o DataTable geral como a fonte de dados do DataGridView
        ListadeServidorCloudDtg.DataSource = dtTodosBancos

        ' Define a largura da primeira coluna se houver pelo menos uma coluna
        If ListadeServidorCloudDtg.Columns.Count > 0 Then
            ListadeServidorCloudDtg.Columns(0).Width = 200
        End If

        ' Desabilita o botão ConectarCloudBtn 
        ConectarCloudBtn.Enabled = True
        LimparColunaCloudBtn.Enabled = True
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
        'desabilita
        LimparColunaCloudBtn.Enabled = False
        SHRINKBtn.Visible = False
        ConectarCloudBtn.Enabled = False
        VerificarDBABtn.Enabled = False
        SelecionarPortaBtn.Enabled = False

        ' Desabilitar
        TotalLogAcessoSymBtn.Visible = False
        MediaLogAcessoSymBtn.Visible = False

        ' Desabilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogEventoBtn.Visible = False
        MediaLogEventoBtn.Visible = False


        ' Desabilitar o botão enquanto o BackgroundWorker está ocupado
        MostrarTamanhoBtn.Enabled = False
        ' Desabilitar o botão enquanto o BackgroundWorker está ocupado
        LogEventoBtn.Enabled = False

        If Not BackgroundWorker1.IsBusy Then
            ' Exibir o ProgressBar
            progressoPb.Visible = True

            ' Iniciar o BackgroundWorker
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Definir o progresso inicial para 0
        DirectCast(sender, BackgroundWorker).ReportProgress(0)

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
                BackgroundWorker1.ReportProgress(100, dataSet)
            Catch ex As Exception
                MessageBox.Show("Erro ao executar o comando SQL: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Atualize o valor atual do ProgressBar com base no progresso relatado
        progressoPb.Value = e.ProgressPercentage

        ' Vincule o DataSet à sua DataGridView
        If e.UserState IsNot Nothing Then
            ListadeServidorCloudDtg.DataSource = DirectCast(e.UserState, DataSet).Tables(0)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Ocultar o ProgressBar após a conclusão da consulta
        ' progressoPb.Visible = False

        ' Reabilitar o botão após a conclusão do trabalho
        MostrarTamanhoBtn.Enabled = True

        ' Definir o UserState para o DataSet retornado após a conclusão do trabalho
        If e.Result IsNot Nothing Then
            BackgroundWorker1.ReportProgress(100, e.Result)
        End If
        'Habilita
        SHRINKBtn.Visible = True
        LimparColunaCloudBtn.Enabled = True
    End Sub
    Private Sub LogEventoBtn_Click(sender As Object, e As EventArgs) Handles LogEventoBtn.Click
        LimparColunaCloudBtn.Enabled = False
        ' Desabilita o botão LogEventoBtn 
        LogEventoBtn.Enabled = False
        ConectarCloudBtn.Enabled = False
        VerificarDBABtn.Enabled = False
        SelecionarPortaBtn.Enabled = False
        ' Habilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogEventoBtn.Visible = True
        MediaLogEventoBtn.Visible = True
        ' Habilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogAcessoSymBtn.Visible = True
        MediaLogAcessoSymBtn.Visible = True

        'Desabilitar MostrarTamanhoBtn
        MostrarTamanhoBtn.Enabled = False

        ' Verifica se a conexão foi estabelecida anteriormente
        If String.IsNullOrEmpty(conexao) Then
            MessageBox.Show("Por favor, conecte-se ao servidor antes de consultar o banco de dados.")
            Return
        End If

        ' Verifica se o DataGridView foi inicializado e possui linhas
        If ListadeServidorCloudDtg IsNot Nothing AndAlso ListadeServidorCloudDtg.Rows.Count > 0 Then
            ' Adiciona as colunas para os resultados das consultas SQL
            ListadeServidorCloudDtg.Columns.Add("TotalRows_LogEvento", "Total de Linhas (LogEvento)")
            ListadeServidorCloudDtg.Columns.Add("TotalSizeMB_LogEvento", "Tamanho Total (MB) (LogEvento)")
            ListadeServidorCloudDtg.Columns.Add("TotalRows_LogAcessoSym", "Total de Linhas (LogAcessoSym)")
            ListadeServidorCloudDtg.Columns.Add("TotalSizeMB_LogAcessoSym", "Tamanho Total (MB) (LogAcessoSym)")

            ' Itera sobre as linhas do DataGridView
            For Each row As DataGridViewRow In ListadeServidorCloudDtg.Rows
                ' Verifica se a célula "Nome" existe
                If row.Cells("Nome") IsNot Nothing AndAlso row.Cells("Nome").Value IsNot Nothing Then
                    ' Obtém o nome do banco de dados da linha atual
                    Dim dbName As String = row.Cells("Nome").Value.ToString()

                    ' Executa a consulta SQL para o banco de dados 'LogEvento'
                    Dim queryLogEvento As String = "SELECT 
                                t.NAME AS TableName,
                                CAST(SUM(p.rows) AS INT) AS TotalRows,
                                CAST(SUM(a.total_pages) * 8 / 1024.0 AS DECIMAL(18, 2)) AS TotalSizeMB
                            FROM 
                                [" & dbName & "].sys.tables t
                            INNER JOIN      
                                [" & dbName & "].sys.indexes i ON t.OBJECT_ID = i.object_id
                            INNER JOIN 
                                [" & dbName & "].sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
                            INNER JOIN 
                                [" & dbName & "].sys.allocation_units a ON p.partition_id = a.container_id
                            WHERE 
                                t.NAME = 'LogEvento'
                            GROUP BY 
                                t.NAME;"

                    ' Executa a consulta SQL para o banco de dados 'LogAcessoSym'
                    Dim queryLogAcessoSym As String = "SELECT 
                                    t.NAME AS TableName,
                                    CAST(SUM(p.rows) AS INT) AS TotalRows,
                                    CAST(SUM(a.total_pages) * 8 / 1024.0 AS DECIMAL(18, 2)) AS TotalSizeMB
                                FROM 
                                    [" & dbName & "].sys.tables t
                                INNER JOIN      
                                    [" & dbName & "].sys.indexes i ON t.OBJECT_ID = i.object_id
                                INNER JOIN 
                                    [" & dbName & "].sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
                                INNER JOIN 
                                    [" & dbName & "].sys.allocation_units a ON p.partition_id = a.container_id
                                WHERE 
                                    t.NAME = 'LogAcessoSym'
                                GROUP BY 
                                    t.NAME;"

                    ' Executa as consultas SQL e obtém os resultados
                    Dim totalRowsLogEvento As Integer = 0
                    Dim totalSizeMBLogEvento As Decimal = 0
                    Dim totalRowsLogAcessoSym As Integer = 0
                    Dim totalSizeMBLogAcessoSym As Decimal = 0

                    Using conexaoBD As New SqlConnection(conexao)
                        Try
                            conexaoBD.Open()

                            Dim comandoLogEvento As New SqlCommand(queryLogEvento, conexaoBD)
                            Dim leitorLogEvento As SqlDataReader = comandoLogEvento.ExecuteReader()
                            If leitorLogEvento.Read() Then
                                totalRowsLogEvento = Convert.ToInt32(leitorLogEvento("TotalRows"))
                                totalSizeMBLogEvento = Convert.ToDecimal(leitorLogEvento("TotalSizeMB"))
                            End If
                            leitorLogEvento.Close()

                            Dim comandoLogAcessoSym As New SqlCommand(queryLogAcessoSym, conexaoBD)
                            Dim leitorLogAcessoSym As SqlDataReader = comandoLogAcessoSym.ExecuteReader()
                            If leitorLogAcessoSym.Read() Then
                                totalRowsLogAcessoSym = Convert.ToInt32(leitorLogAcessoSym("TotalRows"))
                                totalSizeMBLogAcessoSym = Convert.ToDecimal(leitorLogAcessoSym("TotalSizeMB"))
                            End If
                            leitorLogAcessoSym.Close()
                        Catch ex As Exception
                            MessageBox.Show("Erro ao consultar o banco de dados '" & dbName & "': " & ex.Message)
                        End Try
                    End Using

                    ' Adiciona os resultados como valores nas colunas adicionadas para esta linha
                    row.Cells("TotalRows_LogEvento").Value = totalRowsLogEvento
                    row.Cells("TotalSizeMB_LogEvento").Value = totalSizeMBLogEvento
                    row.Cells("TotalRows_LogAcessoSym").Value = totalRowsLogAcessoSym
                    row.Cells("TotalSizeMB_LogAcessoSym").Value = totalSizeMBLogAcessoSym
                End If
            Next
        Else
            MessageBox.Show("Não há bancos de dados para consultar.")
        End If

        LimparColunaCloudBtn.Enabled = True
    End Sub

    Private Sub LimparColunaCloudBtn_Click(sender As Object, e As EventArgs) Handles LimparColunaCloudBtn.Click
        'Habilitar
        ConectarCloudBtn.Enabled = True
        VerificarDBABtn.Enabled = True
        ConectarCloudBtn.Enabled = True
        SelecionarPortaBtn.Enabled = True
        ' Desabilitar o botão LimparColunaCloudBtn novamente
        LimparColunaCloudBtn.Enabled = False

        ' Desabilitar
        TotalLogAcessoSymBtn.Visible = False
        MediaLogAcessoSymBtn.Visible = False
        SHRINKBtn.Visible = False
        ' Desabilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogEventoBtn.Visible = False
        MediaLogEventoBtn.Visible = False

        ' Limpar as colunas adicionadas ao DataGridView
        If ListadeServidorCloudDtg.Columns.Contains("TotalRows_LogEvento") Then
            ListadeServidorCloudDtg.Columns.Remove("TotalRows_LogEvento")
        End If
        If ListadeServidorCloudDtg.Columns.Contains("TotalSizeMB_LogEvento") Then
            ListadeServidorCloudDtg.Columns.Remove("TotalSizeMB_LogEvento")
        End If
        If ListadeServidorCloudDtg.Columns.Contains("TotalRows_LogAcessoSym") Then
            ListadeServidorCloudDtg.Columns.Remove("TotalRows_LogAcessoSym")
        End If
        If ListadeServidorCloudDtg.Columns.Contains("TotalSizeMB_LogAcessoSym") Then
            ListadeServidorCloudDtg.Columns.Remove("TotalSizeMB_LogAcessoSym")
        End If

        ' Limpar os campos ServidorCloud2Txb, ServidorCloud3Txb e SelecionarPortaCbx
        ServidorCloud2Txb.Text = String.Empty
        ServidorCloud3Txb.Text = String.Empty
        SelecionarPortaCbx.SelectedItem = Nothing

        ' Desabilitar os checkboxes HabilitarServidor2Cbx e HabilitarServidor3Cbx
        HabilitarServidor2Cbx.Checked = False
        HabilitarServidor3Cbx.Checked = False

        ' Desabilitar o botão LogEventoBtn
        LogEventoBtn.Enabled = True

        ' Habilita o botão MostraTamanho
        MostrarTamanhoBtn.Enabled = True

        ' Ocultar o ProgressBar
        progressoPb.Visible = False

        ' Reconectar no servidor
        ConectarCloudBtn.PerformClick()

        ' Habilitar o botão LimparColunaCloudBtn novamente
        LimparColunaCloudBtn.Enabled = True

        ' Desabilita o botão LogEventoBtn 
        LogEventoBtn.Enabled = True
    End Sub

    Private Sub GerenciadorDePortaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciadorDePortaToolStripMenuItem.Click
        Dim Gerenciador_Porta As New Gerenciador_Porta()
        Gerenciador_Porta.Show()
    End Sub

    Private Sub CarregarListaBtn_Click(sender As Object, e As EventArgs) Handles CarregarListaBtn.Click
        ' Caminho da pasta "Portas"
        Dim portasFolderPath As String = Path.Combine(Application.StartupPath, "Portas")

        ' Verificar se a pasta existe
        If Directory.Exists(portasFolderPath) Then
            ' Limpar o ComboBox
            SelecionarPortaCbx.Items.Clear()

            ' Obter todos os arquivos na pasta "Portas"
            Dim portaFiles As String() = Directory.GetFiles(portasFolderPath)

            ' Adicionar os nomes dos arquivos ao ComboBox
            For Each portaFile As String In portaFiles
                SelecionarPortaCbx.Items.Add(Path.GetFileNameWithoutExtension(portaFile))
            Next

            MessageBox.Show("Lista de portas carregada com sucesso.")
        Else
            MessageBox.Show("A pasta 'Portas' não foi encontrada.")
        End If
    End Sub
    Private Sub CarregarBancos(portaFilePath As String)
        ' Limpar o DataGridView
        ListadeServidorCloudDtg.DataSource = Nothing

        ' Ler todas as linhas do arquivo da porta
        Dim lines() As String = File.ReadAllLines(portaFilePath)

        ' Criar um DataTable para armazenar os dados
        Dim dt As New DataTable()
        dt.Columns.Add("Nome")

        ' Adicionar os bancos ao DataTable
        For Each line As String In lines
            dt.Rows.Add(line)
        Next

        ' Adicionar as colunas extras, se necessário
        If ListadeServidorCloudDtg.Columns.Count > 1 Then
            dt.Columns.Add("VERSAOBCODADOS", GetType(String))
            dt.Columns.Add("Versão do Sistema", GetType(String))
            dt.Columns.Add("DATA_DO_DBA", GetType(String))
        End If

        ' Definir o DataTable como a fonte de dados do DataGridView
        ListadeServidorCloudDtg.DataSource = dt
    End Sub

    Private Sub SelecionarPortaBtn_Click(sender As Object, e As EventArgs) Handles SelecionarPortaBtn.Click
        ' Desabilita o botão SelecionarPortaBtn 
        SelecionarPortaBtn.Enabled = False

        ' Desabilitar
        TotalLogAcessoSymBtn.Visible = False
        MediaLogAcessoSymBtn.Visible = False
        SHRINKBtn.Visible = False
        ' Desabilitar a visualização dos botões TotalLogEventoBtn e MediaLogEventoBtn
        TotalLogEventoBtn.Visible = False
        MediaLogEventoBtn.Visible = False

        ' Verificar se uma porta está selecionada no ComboBox
        If SelecionarPortaCbx.SelectedItem IsNot Nothing Then
            ' Obter o nome da porta selecionada
            Dim selectedPorta As String = SelecionarPortaCbx.SelectedItem.ToString()

            ' Caminho do arquivo da porta selecionada
            Dim portaFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{selectedPorta}.txt")

            ' Verificar se o arquivo da porta existe
            If File.Exists(portaFilePath) Then
                ' Captura os valores digitados nos textboxes de servidor, usuário e senha
                Dim usuario As String = NomeConectarCloudTxb.Text
                Dim senha As String = SenhaCloudTxb.Text

                ' Verifica se todos os campos foram preenchidos
                If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
                    MessageBox.Show("Preencha todos os campos antes de conectar.")
                    Return
                End If

                ' Cria uma DataTable para armazenar os resultados da consulta
                Dim dt As New DataTable()

                ' Adiciona as colunas 'Nome', 'NomeServidor', 'Data', 'VERSAOBCODADOS', 'Versão do Sistema' e 'DATA_DO_DBA' ao DataTable
                dt.Columns.Add("Nome", GetType(String))
                dt.Columns.Add("NomeServidor", GetType(String))
                dt.Columns.Add("Data", GetType(DateTime))
                dt.Columns.Add("VERSAOBCODADOS", GetType(String))
                dt.Columns.Add("Versão do Sistema", GetType(String))
                dt.Columns.Add("DATA_DO_DBA", GetType(String))

                ' Declara a variável conexaoBD fora do loop
                Dim conexaoBD As SqlConnection = Nothing

                Try
                    ' Ler todas as linhas do arquivo da porta
                    Dim lines() As String = File.ReadAllLines(portaFilePath)

                    ' Iterar sobre os servidores
                    Dim servidores As New List(Of String)()
                    If Not String.IsNullOrEmpty(ServidorCloudTxb.Text.Trim()) Then
                        servidores.Add(ServidorCloudTxb.Text.Trim())
                    End If
                    If Not String.IsNullOrEmpty(ServidorCloud2Txb.Text.Trim()) Then
                        servidores.Add(ServidorCloud2Txb.Text.Trim())
                    End If
                    If Not String.IsNullOrEmpty(ServidorCloud3Txb.Text.Trim()) Then
                        servidores.Add(ServidorCloud3Txb.Text.Trim())
                    End If

                    For Each servidor In servidores
                        ' Verifica se o servidor informado não é um dos servidores bloqueados
                        If servidor.Contains("dp01.informo.com.br,9797") OrElse servidor.Contains("dp01.informo.com.br,9898") OrElse servidor.Equals("DP-SYMDB01") OrElse servidor.Equals("DP-SYMDB") Then
                            MessageBox.Show("Por motivos de segurança, esses servidores não podem ser acessados.")
                            Return
                        End If

                        ' Cria uma string de conexão com o servidor de banco de dados
                        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

                        ' Cria uma conexão com o servidor de banco de dados
                        conexaoBD = New SqlConnection(conexao)
                        conexaoBD.Open()

                        ' Iterar sobre os bancos de dados
                        For Each databaseName In lines
                            ' Executa uma consulta SQL para obter as informações do Parâmetro, considerando que a tabela pode não existir
                            Dim queryParametro As String = "IF OBJECT_ID('" & databaseName & ".dbo.parametro', 'U') IS NOT NULL " &
                            "BEGIN " &
                            "SELECT TOP 1 VERSAOBCODADOS, dtbcodados as DATA_DO_DBA FROM [" & databaseName & "].dbo.parametro END"
                            Dim comandoParametro As New SqlCommand(queryParametro, conexaoBD)

                            ' Executa o comando e processa o resultado
                            Dim leitorParametro As SqlDataReader = comandoParametro.ExecuteReader()
                            If leitorParametro.Read() Then
                                ' Adiciona uma nova linha ao DataTable e preenche as colunas
                                Dim newRow As DataRow = dt.NewRow()
                                newRow("Nome") = databaseName
                                newRow("NomeServidor") = servidor
                                newRow("Data") = DateTime.Now ' Você pode modificar essa data de acordo com o que deseja
                                newRow("VERSAOBCODADOS") = leitorParametro("VERSAOBCODADOS").ToString()
                                newRow("DATA_DO_DBA") = leitorParametro("DATA_DO_DBA").ToString()

                                ' Extrai os dois dígitos do meio de "VERSAOBCODADOS" e mapeia para o formato de versão do sistema desejado
                                Dim versaoCompleta As String = newRow("VERSAOBCODADOS").ToString()
                                Dim versao As String = If(versaoCompleta.Length >= 6, versaoCompleta.Substring(3, 2), "")
                                versao = versao.Replace(". ", "") ' Remove o ponto e o espaço
                                Select Case versao
                                    Case "40"
                                        newRow("Versão do Sistema") = "2025.R3"
                                    Case "39"
                                        newRow("Versão do Sistema") = "2025.R2"
                                    Case "38"
                                        newRow("Versão do Sistema") = "2025.R1"
                                    Case "37"
                                        newRow("Versão do Sistema") = "2024.R3"
                                    Case "36"
                                        newRow("Versão do Sistema") = "2024.R2"
                                    Case "35"
                                        newRow("Versão do Sistema") = "2024.R1"
                                    Case "34"
                                        newRow("Versão do Sistema") = "2023.R3"
                                    Case "33"
                                        newRow("Versão do Sistema") = "2023.R2"
                                    Case "32"
                                        newRow("Versão do Sistema") = "2023.R1"
                                    Case "31"
                                        newRow("Versão do Sistema") = "2022.R3"
                                    Case "30"
                                        newRow("Versão do Sistema") = "2022.R2"
                                    Case Else
                                        ' Se a versão não estiver mapeada, defina a versão do sistema como "Versão não mapeada"
                                        newRow("Versão do Sistema") = "Versão não mapeada"
                                End Select

                                ' Adiciona a nova linha ao DataTable
                                dt.Rows.Add(newRow)
                            End If

                            ' Fecha o leitor de dados da consulta de parâmetros
                            leitorParametro.Close()
                        Next

                        ' Fecha a conexão com o servidor de banco de dados
                        conexaoBD.Close()
                    Next

                    ' Popula o DataGridView com os nomes dos bancos de dados, VERSAOBCODADOS, DATA_DO_DBA e a nova coluna "Versão do Sistema"
                    ListadeServidorCloudDtg.DataSource = dt
                    ListadeServidorCloudDtg.Columns(0).Width = 200
                Catch ex As Exception
                    MessageBox.Show("Erro ao estabelecer a conexão ou carregar os bancos de dados: " & ex.Message)
                Finally
                    ' Fecha a conexão com o servidor de banco de dados se estiver aberta
                    If conexaoBD IsNot Nothing AndAlso conexaoBD.State = ConnectionState.Open Then
                        conexaoBD.Close()
                    End If
                End Try
            Else
                MessageBox.Show($"O arquivo da porta '{selectedPorta}' não foi encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, selecione uma porta.")
        End If

        ' Habilita o botão SelecionarPortaBtn 
        SelecionarPortaBtn.Enabled = True

    End Sub

    Private Sub HabilitarServidor2Cbx_CheckedChanged(sender As Object, e As EventArgs) Handles HabilitarServidor2Cbx.CheckedChanged
        ' Define a visibilidade do TextBox e da Label com base no estado do checkbox
        ServidorCloud2Txb.Visible = HabilitarServidor2Cbx.Checked
        Servidor2Lbl.Visible = HabilitarServidor2Cbx.Checked

        ' Limpa o conteúdo do ServidorCloud2Txb quando o checkbox é desmarcado
        If Not HabilitarServidor2Cbx.Checked Then
            ServidorCloud2Txb.Text = ""
        End If

        ' Desabilita o botão LogEventoBtn quando o checkbox é desmarcado
        LogEventoBtn.Enabled = Not HabilitarServidor2Cbx.Checked
        VerificarDBABtn.Enabled = Not HabilitarServidor2Cbx.Checked
        SelecionarPortaBtn.Enabled = Not HabilitarServidor2Cbx.Checked
        ' Desabilita o botão MostrarTamanhoBtn quando o checkbox é desmarcado
        MostrarTamanhoBtn.Enabled = Not HabilitarServidor2Cbx.Checked
    End Sub

    Private Sub HabilitarServidor3Cbx_CheckedChanged(sender As Object, e As EventArgs) Handles HabilitarServidor3Cbx.CheckedChanged
        ' Define a visibilidade do TextBox e da Label com base no estado do checkbox
        ServidorCloud3Txb.Visible = HabilitarServidor3Cbx.Checked
        Servidor3Lbl.Visible = HabilitarServidor3Cbx.Checked

        ' Limpa o conteúdo do ServidorCloud3Txb quando o checkbox é desmarcado
        If Not HabilitarServidor3Cbx.Checked Then
            ServidorCloud3Txb.Text = ""
        End If

        ' Desabilita o botão LogEventoBtn quando o checkbox é desmarcado
        LogEventoBtn.Enabled = Not HabilitarServidor3Cbx.Checked
        VerificarDBABtn.Enabled = Not HabilitarServidor3Cbx.Checked
        SelecionarPortaBtn.Enabled = Not HabilitarServidor3Cbx.Checked
        ' Desabilita o botão MostrarTamanhoBtn quando o checkbox é desmarcado
        MostrarTamanhoBtn.Enabled = Not HabilitarServidor3Cbx.Checked
    End Sub

    Private Sub RARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RARToolStripMenuItem.Click
        ' Obter o diretório do programa
        Dim diretorioPrograma As String = Application.StartupPath

        ' Construir o caminho completo para o arquivo RarExtractor.exe
        Dim caminhoRarExtractor As String = Path.Combine(diretorioPrograma, "#RAR\RarExtractor.exe")

        ' Verificar se o arquivo existe
        If File.Exists(caminhoRarExtractor) Then
            ' Executar o arquivo RarExtractor.exe
            Process.Start(caminhoRarExtractor)
        Else
            MessageBox.Show("O arquivo RarExtractor.exe não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TotalLogEventoBtn_Click(sender As Object, e As EventArgs) Handles TotalLogEventoBtn.Click
        ' Verifica se o DataGridView foi inicializado e possui linhas
        If ListadeServidorCloudDtg IsNot Nothing AndAlso ListadeServidorCloudDtg.Rows.Count > 0 Then
            ' Inicializa a variável para armazenar o total do tamanho dos logs de eventos
            Dim totalSizeLogEvento As Decimal = 0

            ' Itera sobre as linhas do DataGridView
            For Each row As DataGridViewRow In ListadeServidorCloudDtg.Rows
                ' Verifica se a célula "TotalSizeMB_LogEvento" existe
                If row.Cells("TotalSizeMB_LogEvento") IsNot Nothing AndAlso row.Cells("TotalSizeMB_LogEvento").Value IsNot Nothing Then
                    ' Obtém o valor da célula "TotalSizeMB_LogEvento" e adiciona ao total
                    totalSizeLogEvento += Convert.ToDecimal(row.Cells("TotalSizeMB_LogEvento").Value)
                End If
            Next

            ' Exibe o total do tamanho dos logs de eventos em uma mensagem
            MessageBox.Show("Total do Tamanho dos Logs de Eventos: " & totalSizeLogEvento.ToString() & " MB")
        Else
            MessageBox.Show("Não há bancos de dados para calcular o total do tamanho dos logs de eventos.")
        End If
    End Sub

    Private Sub MediaLogEventoBtn_Click(sender As Object, e As EventArgs) Handles MediaLogEventoBtn.Click
        ' Verifica se o DataGridView foi inicializado e possui linhas
        If ListadeServidorCloudDtg IsNot Nothing AndAlso ListadeServidorCloudDtg.Rows.Count > 0 Then
            ' Inicializa as variáveis para armazenar o total do tamanho dos logs de eventos e o número de linhas
            Dim totalSizeLogEvento As Decimal = 0
            Dim totalLinhas As Integer = 0

            ' Itera sobre as linhas do DataGridView
            For Each row As DataGridViewRow In ListadeServidorCloudDtg.Rows
                ' Verifica se a célula "TotalSizeMB_LogEvento" existe e contém um valor
                If row.Cells("TotalSizeMB_LogEvento") IsNot Nothing AndAlso row.Cells("TotalSizeMB_LogEvento").Value IsNot Nothing Then
                    ' Obtém o valor da célula "TotalSizeMB_LogEvento" e adiciona ao total
                    totalSizeLogEvento += Convert.ToDecimal(row.Cells("TotalSizeMB_LogEvento").Value)
                    ' Incrementa o número total de linhas
                    totalLinhas += 1
                End If
            Next

            ' Verifica se há pelo menos uma linha para calcular a média
            If totalLinhas > 0 Then
                ' Calcula a média do tamanho dos logs de eventos
                Dim mediaSizeLogEvento As Decimal = totalSizeLogEvento / totalLinhas

                ' Exibe a média do tamanho dos logs de eventos em uma mensagem
                MessageBox.Show("Média do Tamanho dos Logs de Eventos: " & mediaSizeLogEvento.ToString("0.00") & " MB por banco de dados")
            Else
                MessageBox.Show("Não foi possível calcular a média pois não há dados disponíveis.")
            End If
        Else
            MessageBox.Show("Não há bancos de dados para calcular a média do tamanho dos logs de eventos.")
        End If

    End Sub

    Private Sub TotalLogAcessoSymBtn_Click(sender As Object, e As EventArgs) Handles TotalLogAcessoSymBtn.Click
        ' Verifica se o DataGridView foi inicializado e possui linhas
        If ListadeServidorCloudDtg IsNot Nothing AndAlso ListadeServidorCloudDtg.Rows.Count > 0 Then
            ' Inicializa a variável para armazenar o total do tamanho dos logs de acesso Sym
            Dim totalSizeLogAcessoSym As Decimal = 0

            ' Itera sobre as linhas do DataGridView
            For Each row As DataGridViewRow In ListadeServidorCloudDtg.Rows
                ' Verifica se a célula "TotalSizeMB_LogAcessoSym" existe e contém um valor
                If row.Cells("TotalSizeMB_LogAcessoSym") IsNot Nothing AndAlso row.Cells("TotalSizeMB_LogAcessoSym").Value IsNot Nothing Then
                    ' Obtém o valor da célula "TotalSizeMB_LogAcessoSym" e adiciona ao total
                    totalSizeLogAcessoSym += Convert.ToDecimal(row.Cells("TotalSizeMB_LogAcessoSym").Value)
                End If
            Next

            ' Exibe o total do tamanho dos logs de acesso Sym em uma mensagem
            MessageBox.Show("Total do Tamanho dos Logs de Acesso Sym: " & totalSizeLogAcessoSym.ToString("0.00") & " MB")
        Else
            MessageBox.Show("Não há bancos de dados para calcular o total do tamanho dos logs de acesso Sym.")
        End If
    End Sub

    Private Sub MediaLogAcessoSymBtn_Click(sender As Object, e As EventArgs) Handles MediaLogAcessoSymBtn.Click
        ' Verifica se o DataGridView foi inicializado e possui linhas
        If ListadeServidorCloudDtg IsNot Nothing AndAlso ListadeServidorCloudDtg.Rows.Count > 0 Then
            ' Inicializa as variáveis para calcular a média
            Dim totalSizeLogAcessoSym As Decimal = 0
            Dim numLinhas As Integer = 0

            ' Itera sobre as linhas do DataGridView
            For Each row As DataGridViewRow In ListadeServidorCloudDtg.Rows
                ' Verifica se a célula "TotalSizeMB_LogAcessoSym" existe e contém um valor
                If row.Cells("TotalSizeMB_LogAcessoSym") IsNot Nothing AndAlso row.Cells("TotalSizeMB_LogAcessoSym").Value IsNot Nothing Then
                    ' Obtém o valor da célula "TotalSizeMB_LogAcessoSym" e adiciona ao total
                    totalSizeLogAcessoSym += Convert.ToDecimal(row.Cells("TotalSizeMB_LogAcessoSym").Value)
                    ' Incrementa o número de linhas
                    numLinhas += 1
                End If
            Next

            ' Calcula a média
            Dim mediaLogAcessoSym As Decimal = If(numLinhas > 0, totalSizeLogAcessoSym / numLinhas, 0)

            ' Exibe a média em uma mensagem
            MessageBox.Show("Média do Tamanho dos Logs de Acesso Sym: " & mediaLogAcessoSym.ToString("0.00") & " MB por banco de dados")
        Else
            MessageBox.Show("Não há bancos de dados para calcular a média do tamanho dos logs de acesso Sym.")
        End If
    End Sub

    Private Sub SHRINKBtn_Click(sender As Object, e As EventArgs) Handles SHRINKBtn.Click

        ' Desabilita o botão SHRINKBtn 
        SHRINKBtn.Enabled = False
        ' Verifica se há alguma linha selecionada no DataGridView
        If ListadeServidorCloudDtg.SelectedRows.Count > 0 Then
            ' Obtém o nome do banco de dados da linha selecionada
            Dim dbName As String = ListadeServidorCloudDtg.SelectedRows(0).Cells("database_name").Value.ToString()

            ' Cria uma string de conexão com o banco de dados selecionado
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = ServidorCloudTxb.Text
            builder.UserID = NomeConectarCloudTxb.Text
            builder.Password = SenhaCloudTxb.Text
            builder.InitialCatalog = dbName
            builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
            Dim connectionString As String = builder.ConnectionString

            ' Executa o comando DBCC SHRINKDATABASE no banco de dados selecionado
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim sql As String = "DBCC SHRINKDATABASE(N'" & dbName & "')"
                    Dim command As New SqlCommand(sql, connection)

                    ' Aumenta o tempo limite do comando para 5 minutos (300 segundos)
                    command.CommandTimeout = 800

                    command.ExecuteNonQuery()
                    MessageBox.Show("DBCC SHRINKDATABASE executado com sucesso no banco de dados " & dbName & ".")
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao executar o comando DBCC SHRINKDATABASE: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor, selecione um banco de dados na lista.")
        End If
        ' Desabilita o botão SHRINKBtn 
        SHRINKBtn.Enabled = True
    End Sub

    Private Sub InformaçõesDasEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaçõesDasEmpresasToolStripMenuItem.Click
        ' Esconde o formulário atual
        Me.Hide()

        ' Cria uma instância do formulário Empresas
        Dim formEmpresas As New Empresas()

        ' Exibe o formulário Empresas
        formEmpresas.Show()
    End Sub

    Private Sub VerificarDBABtn_Click(sender As Object, e As EventArgs) Handles VerificarDBABtn.Click



        ' Verificar se há uma linha selecionada no DataGridView
        If ListadeServidorCloudDtg.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione uma linha para executar a consulta.")
            Return
        End If
        ' Desabilita 
        LimparColunaCloudBtn.Enabled = False
        VerificarDBABtn.Enabled = False
        SelecionarPortaBtn.Enabled = False
        LogEventoBtn.Enabled = False
        MostrarTamanhoBtn.Enabled = False
        ConectarCloudBtn.Enabled = False
        ' Obter o nome do banco de dados da linha selecionada
        Dim dbName As String = ListadeServidorCloudDtg.SelectedRows(0).Cells("Nome").Value.ToString()

        ' Verificar se o nome do banco de dados não está vazio
        If Not String.IsNullOrEmpty(dbName) Then
            ' Mensagem de depuração: exibir o nome do banco de dados
            MessageBox.Show("Banco de dados selecionado: " & dbName)

            ' Cria uma string de conexão com o banco de dados selecionado
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = ServidorCloudTxb.Text
            builder.UserID = NomeConectarCloudTxb.Text
            builder.Password = SenhaCloudTxb.Text
            builder.InitialCatalog = dbName
            builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
            Dim connectionString As String = builder.ConnectionString

            ' Montar a consulta SQL
            Dim query As String = "SELECT TOP 10 Usuario As USUARIO, Computador As COMPUTADOR, RIGHT('00' + RTRIM(DATEPART(D, Data)), 2) + '/' + RIGHT('00' + RTRIM(DATEPART(M, Data)), 2) + '/' + RIGHT('00' + RTRIM(DATEPART(yyyy, Data)), 2) As DataF, " &
                              "RIGHT('00' + RTRIM(DATEPART(HH, Data)), 2) + ':' + RIGHT('00' + RTRIM(DATEPART(mi, Data)), 2) + ':' + RIGHT('00' + RTRIM(DATEPART(s, Data)), 2) As HoraF, " &
                              "Descricao, Detalhe FROM LogEvento WHERE Origem = 'pSymDBA_Tools' ORDER BY Data DESC"

            Try
                ' Estabelecer a conexão com o banco de dados
                Using connection As New SqlConnection(connectionString) ' Usar connectionString em vez de conexao
                    connection.Open()

                    ' Criar um adaptador de dados para preencher a tabela com os resultados da consulta
                    Dim adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Definir a fonte de dados do DataGridView como a tabela de resultados
                    ListadeServidorCloudDtg.DataSource = dataTable

                    ' Ajustar o tamanho das colunas para corresponder ao conteúdo
                    ListadeServidorCloudDtg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao executar a consulta: " & ex.Message)
            End Try
        End If

        ' Habilita o botão VerificarDBABt 
        LimparColunaCloudBtn.Enabled = True

    End Sub

End Class
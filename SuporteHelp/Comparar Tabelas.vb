Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
Imports NPOI.SS.Formula.Functions

Public Class Comparar_Tabelas
    Private Sub ConectarCompararBtn_Click(sender As Object, e As EventArgs) Handles ConectarCompararBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTabelaCompararTxb.Text
        Dim usuario As String = NomeConectarTabelaCompararTxb.Text
        Dim senha As String = SenhaTabelaCompararTxb.Text

        ' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                ' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')order by name", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma lista para armazenar os nomes dos bancos de dados
                Dim listaBancos As New List(Of String)

                ' Popula a lista com os nomes dos bancos de dados
                While leitor.Read()
                    listaBancos.Add(leitor("Nome").ToString())
                End While

                ' Fecha o leitor de dados
                leitor.Close()

                ' Popula o combobox com os nomes dos bancos de dados
                SelecionarBancoCompararBbx.DataSource = listaBancos
                ' Desabilita o botão de pesquisa
                'PesquisarTabelaCompararBtn.Enabled = False
                'LimparTabelaCompararBtn.Enabled = False
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Function ExisteConexaoSalva(servidor As String, usuario As String, senha As String) As Boolean
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Verifica se já existe uma conexão salva com os mesmos dados
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidor AndAlso dados(1) = usuario AndAlso dados(2) = senha Then
                    Return True ' Já existe uma conexão salva com os mesmos dados
                End If
            Next
        End If

        Return False ' Não existe uma conexão salva com os mesmos dados
    End Function
    Private Sub SalvarDadosConexao(servidor As String, usuario As String, senha As String)
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Cria uma linha com os dados de conexão
        Dim linha As String = $"{servidor},{usuario},{senha}"

        ' Salva a linha no arquivo de texto
        File.AppendAllText(caminhoArquivo, linha & Environment.NewLine)
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
            ExibirServidorTabelaCompararCbx.DataSource = listaServidores
        End If
    End Sub

    Private Sub ExibirServidorTabelaCompararCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorTabelaCompararCbx.SelectedIndexChanged
        ' Obtém o índice do servidor selecionado no combobox
        Dim indiceServidor As Integer = ExibirServidorTabelaCompararCbx.SelectedIndex

        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Verifica se o índice do servidor selecionado é válido
            If indiceServidor >= 0 AndAlso indiceServidor < linhas.Length Then
                ' Obtém os dados do servidor selecionado
                Dim dadosServidor As String() = linhas(indiceServidor).Split(","c)

                ' Preenche os campos de servidor, usuário e senha com os dados do servidor selecionado
                ServidorTabelaCompararTxb.Text = dadosServidor(0)
                NomeConectarTabelaCompararTxb.Text = dadosServidor(1)
                SenhaTabelaCompararTxb.Text = dadosServidor(2)
            End If
        End If
    End Sub

    Private Sub Tabela_Coluna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub

    Private Sub SelecionarBancoCompararBbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecionarBancoCompararBbx.SelectedIndexChanged

        ' Captura o nome do banco de dados selecionado no combobox
        Dim nomeBanco As String = SelecionarBancoCompararBbx.SelectedItem.ToString()

        Try
            ' Cria uma conexão com o banco de dados selecionado
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaCompararTxb.Text};User Id={NomeConectarTabelaCompararTxb.Text};Password={SenhaTabelaCompararTxb.Text};Database={nomeBanco}")
                ' Abre a conexão com o banco de dados
                conexaoBD.Open()

                ' Executa uma consulta SQL que retorna as tabelas do banco de dados selecionado
                Dim comando As New SqlCommand("SELECT TABLE_NAME as Nome_da_Tabela FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'order by TABLE_NAME", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar os nomes das tabelas do banco de dados selecionado
                Dim dt As New DataTable()
                dt.Load(leitor)
                ' Popula o DataGridView com os nomes das tabelas do banco de dados selecionado
                ListadeTabela1Dtg.DataSource = dt
                ListadeTabela1Dtg.Columns(0).Width = 200

                ListadeTabela2Dtg.DataSource = dt
                ListadeTabela2Dtg.Columns(0).Width = 200

                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar tabelas: " & ex.Message)
        End Try
    End Sub
    Private Sub CompararBtn_Click(sender As Object, e As EventArgs) Handles CompararBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTabelaCompararTxb.Text
        Dim usuario As String = NomeConectarTabelaCompararTxb.Text
        Dim senha As String = SenhaTabelaCompararTxb.Text

        ' Verifica se há uma linha selecionada em ambas as DataGridViews
        If ListadeTabela1Dtg.SelectedRows.Count = 0 OrElse ListadeTabela2Dtg.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione uma linha em ambas as tabelas para comparar.")
            Return
        End If

        ' Captura os nomes das tabelas selecionadas nas linhas das DataGridViews
        Dim tabela1 As String = ListadeTabela1Dtg.SelectedRows(0).Cells("columnName").Value.ToString()
        Dim tabela2 As String = ListadeTabela2Dtg.SelectedRows(0).Cells("columnName").Value.ToString()
        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                ' Obtém as colunas da primeira tabela
                Dim colunasTabela1 As List(Of String) = ObterColunasDaTabela(conexaoBD, tabela1, tabela2)

                ' Limpa as colunas existentes
                ResultadoDgv.Columns.Clear()

                ' Adiciona as colunas ao DataGridView ResultadoDgv
                For Each coluna As String In colunasTabela1
                    ' Verifica se a coluna já existe antes de adicioná-la
                    If Not ResultadoDgv.Columns.Contains(coluna) Then
                        ResultadoDgv.Columns.Add(coluna, coluna)
                    End If
                Next

                ' Executa a comparação entre as tabelas e preenche o DataGridView ResultadoDgv com os resultados
                Dim resultadoConsulta As DataTable = CompararTabelas(conexaoBD, tabela1, tabela2)
                ResultadoDgv.DataSource = resultadoConsulta
            End Using
        Catch ex As ArgumentException
            ' Manipula o erro quando uma coluna não é encontrada
            MessageBox.Show("Erro ao comparar tabelas: " & ex.Message)
        Catch ex As Exception
            ' Manipula outros erros
            MessageBox.Show("Erro ao comparar tabelas: " & ex.Message)
        End Try
    End Sub

    Private Function ObterColunasDaTabela(conexao As SqlConnection, tabela1 As String, tabela2 As String) As List(Of String)
        Dim colunas As New List(Of String)()

        Try
            ' Executa uma consulta SQL que retorna os nomes das colunas da tabela
            Dim comando As New SqlCommand($"SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = '{tabela1}' AND COLUMN_NAME IN (
    SELECT COLUMN_NAME
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = '{tabela2}'
);", conexao)
            Dim leitor As SqlDataReader = comando.ExecuteReader()

            ' Adiciona os nomes das colunas à lista
            While leitor.Read()
                colunas.Add(leitor("COLUMN_NAME").ToString())
            End While

            ' Fecha o leitor de dados
            leitor.Close()
        Catch ex As Exception
            ' Lança uma exceção personalizada se uma coluna não for encontrada
            Throw New ArgumentException($"Coluna não encontrada na tabela {tabela1} ou {tabela2}.")
        End Try

        Return colunas
    End Function

    Private Function CompararTabelas(conexao As SqlConnection, tabela1 As String, tabela2 As String) As DataTable
        Dim resultadoConsulta As New DataTable()

        Try
            ' Executa a consulta para comparar as tabelas
            Dim consulta As String = $"SELECT * FROM {tabela1} EXCEPT SELECT * FROM {tabela2};"
            Dim adapter As New SqlDataAdapter(consulta, conexao)
            adapter.Fill(resultadoConsulta)
        Catch ex As Exception
            ' Lança uma exceção se ocorrer um erro durante a comparação
            Throw New Exception("Erro ao comparar as tabelas: " & ex.Message)
        End Try

        Return resultadoConsulta
    End Function
End Class
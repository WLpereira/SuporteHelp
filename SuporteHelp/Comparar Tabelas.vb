Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
Imports NPOI.SS.Formula.Functions


Public Class Comparar_Tabelas
    Private tabela1 As String = ""
    Private tabela2 As String = ""

    Private Sub ConectarCompararBtn_Click(sender As Object, e As EventArgs) Handles ConectarCompararBtn.Click
        ' Captura os valores dos campos de servidor, usuário e senha
        Dim servidor As String = ServidorTabelaCompararTxb.Text
        Dim usuario As String = NomeConectarTabelaCompararTxb.Text
        Dim senha As String = SenhaTabelaCompararTxb.Text

        ' Verifica se os campos estão preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria a string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            ' Cria a conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                conexaoBD.Open()

                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL para obter os bancos de dados
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')order by name", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                Dim listaBancos As New List(Of String)

                While leitor.Read()
                    listaBancos.Add(leitor("Nome").ToString())
                End While

                leitor.Close()

                ' Preenche o ComboBox com os nomes dos bancos de dados
                SelecionarBancoCompararBbx.DataSource = listaBancos
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
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
    ' Métodos para manipulação dos bancos de dados e conexões (ExisteConexaoSalva, SalvarDadosConexao, CarregarServidoresSalvos)

    ' Evento ao carregar o formulário
    Private Sub Tabela_Coluna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub

    ' Evento ao selecionar um banco de dados no ComboBox
    Private Sub SelecionarBancoCompararBbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecionarBancoCompararBbx.SelectedIndexChanged
        Dim nomeBanco As String = SelecionarBancoCompararBbx.SelectedItem.ToString()

        Try
            ' Cria a conexão com o banco de dados selecionado
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaCompararTxb.Text};User Id={NomeConectarTabelaCompararTxb.Text};Password={SenhaTabelaCompararTxb.Text};Database={nomeBanco}")
                conexaoBD.Open()

                ' Executa uma consulta SQL para obter as tabelas do banco de dados selecionado
                Dim comando As New SqlCommand("SELECT TABLE_NAME as Nome_da_Tabela FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'order by TABLE_NAME", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(leitor)
                ListarTabelasCompararDtg.DataSource = dt
                ListarTabelasCompararDtg.Columns(0).Width = 200

                leitor.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar tabelas: " & ex.Message)
        End Try
    End Sub

    ' Evento ao clicar no botão para pesquisar tabela
    Private Sub PesquisarTabelaCompararBtn_Click(sender As Object, e As EventArgs) Handles PesquisarTabelaCompararBtn.Click
        If SelecionarBancoCompararBbx.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um banco de dados.")
            Return
        End If

        PesquisarTabelaCompararBtn.Enabled = False
        Dim searchTerm As String = PesquisatabelaCompararTxb.Text.Trim()

        Dim dt As DataTable = DirectCast(ListarTabelasCompararDtg.DataSource, DataTable)

        If Not dt.Columns.Contains("Nome_da_Tabela") Then
            dt.Columns.Add("Nome_da_Tabela", GetType(String))
        End If

        dt.DefaultView.RowFilter = $"Nome_da_Tabela LIKE '%{searchTerm}%'"

        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Tabela(s) encontrada.")
            ListarTabelasCompararDtg.DataSource = dt.DefaultView.ToTable()
        Else
            MessageBox.Show("Nenhuma tabela encontrada.")
        End If
    End Sub

    ' Evento ao clicar no botão para limpar tabela
    Private Sub LimparTabelaCompararBtn_Click(sender As Object, e As EventArgs) Handles LimparTabelaCompararBtn.Click
        If SelecionarBancoCompararBbx.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um banco de dados.")
            Return
        End If

        PesquisarTabelaCompararBtn.Enabled = True
        PesquisatabelaCompararTxb.Text = ""

        Dim dt As DataTable = DirectCast(ListarTabelasCompararDtg.DataSource, DataTable)
        dt.DefaultView.RowFilter = ""
        ListarTabelasCompararDtg.DataSource = dt

        ConectarCompararBtn.PerformClick()
    End Sub

    ' Evento ao clicar em uma célula da tabela de listagem de tabelas
    Private Sub ListarTabelasCompararDtg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListarTabelasCompararDtg.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < ListarTabelasCompararDtg.Rows.Count Then
            Dim nomeTabela As String = ListarTabelasCompararDtg.Rows(e.RowIndex).Cells("Nome_da_Tabela").Value.ToString()

            If String.IsNullOrEmpty(tabela1) Then
                tabela1 = nomeTabela
            ElseIf String.IsNullOrEmpty(tabela2) Then
                tabela2 = nomeTabela
                ExibirColunasComuns(tabela1, tabela2)
            Else
                tabela1 = ""
                tabela2 = ""
                ListarTabelasCompararDtg.ClearSelection()
                MessageBox.Show("Limpe a seleção anterior para selecionar novas tabelas.")
            End If
        End If
    End Sub

    ' Método para exibir colunas comuns em ResultadoComprarDtg
    Private Sub ExibirColunasComuns(tabela1 As String, tabela2 As String)
        Try
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaCompararTxb.Text};User Id={NomeConectarTabelaCompararTxb.Text};Password={SenhaTabelaCompararTxb.Text};Database={SelecionarBancoCompararBbx.SelectedItem.ToString()}")
                conexaoBD.Open()

                ' Obter colunas da tabela1
                Dim colunasTabela1 As List(Of String) = ObterColunasDaTabela(conexaoBD, tabela1)

                ' Obter colunas da tabela2
                Dim colunasTabela2 As List(Of String) = ObterColunasDaTabela(conexaoBD, tabela2)

                ' Encontrar colunas comuns
                Dim colunasComuns As List(Of String) = colunasTabela1.Intersect(colunasTabela2).ToList()

                ' Exibir as colunas comuns em ResultadoComprarDtg
                Dim dtResultado As New DataTable()
                For Each coluna As String In colunasComuns
                    dtResultado.Columns.Add(coluna)
                Next

                ResultadoComprarDtg.DataSource = dtResultado

            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao exibir colunas comuns: " & ex.Message)
        End Try
    End Sub
    Private Sub LimparSelecaoBtn_Click(sender As Object, e As EventArgs) Handles LimparSelecaoBtn.Click
        ' Limpar a seleção e resetar as tabelas selecionadas
        tabela1 = ""
        tabela2 = ""
        ListarTabelasCompararDtg.ClearSelection()
        ResultadoComprarDtg.DataSource = Nothing
    End Sub

    ' Método para obter colunas de uma tabela
    Private Function ObterColunasDaTabela(conexao As SqlConnection, tabela As String) As List(Of String)
        Dim colunas As New List(Of String)()

        Dim comando As New SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}'", conexao)
        Dim leitor As SqlDataReader = comando.ExecuteReader()

        While leitor.Read()
            colunas.Add(leitor("COLUMN_NAME").ToString())
        End While

        leitor.Close()

        Return colunas
    End Function

End Class
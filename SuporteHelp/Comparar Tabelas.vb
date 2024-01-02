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
        Dim servidor As String = ServidorTabelaCompararTxb.Text
        Dim usuario As String = NomeConectarTabelaCompararTxb.Text
        Dim senha As String = SenhaTabelaCompararTxb.Text

        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            Using conexaoBD As New SqlConnection(conexao)
                conexaoBD.Open()

                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')order by name", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                Dim listaBancos As New List(Of String)

                While leitor.Read()
                    listaBancos.Add(leitor("Nome").ToString())
                End While

                leitor.Close()

                SelecionarBancoCompararBbx.DataSource = listaBancos
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Function ExisteConexaoSalva(servidor As String, usuario As String, senha As String) As Boolean
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        If File.Exists(caminhoArquivo) Then
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidor AndAlso dados(1) = usuario AndAlso dados(2) = senha Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Sub SalvarDadosConexao(servidor As String, usuario As String, senha As String)
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")
        Dim linha As String = $"{servidor},{usuario},{senha}"
        File.AppendAllText(caminhoArquivo, linha & Environment.NewLine)
    End Sub

    Private Sub CarregarServidoresSalvos()
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        If File.Exists(caminhoArquivo) Then
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)
            Dim listaServidores As New List(Of String)

            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 Then
                    listaServidores.Add(dados(0))
                End If
            Next

            ExibirServidorTabelaCompararCbx.DataSource = listaServidores
        End If
    End Sub

    Private Sub ExibirServidorTabelaCompararCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorTabelaCompararCbx.SelectedIndexChanged
        Dim indiceServidor As Integer = ExibirServidorTabelaCompararCbx.SelectedIndex
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        If File.Exists(caminhoArquivo) Then
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            If indiceServidor >= 0 AndAlso indiceServidor < linhas.Length Then
                Dim dadosServidor As String() = linhas(indiceServidor).Split(","c)
                ServidorTabelaCompararTxb.Text = dadosServidor(0)
                NomeConectarTabelaCompararTxb.Text = dadosServidor(1)
                SenhaTabelaCompararTxb.Text = dadosServidor(2)
            End If
        End If
    End Sub

    Private Sub Tabela_Coluna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarServidoresSalvos()
    End Sub

    Private Sub SelecionarBancoCompararBbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecionarBancoCompararBbx.SelectedIndexChanged
        Dim nomeBanco As String = SelecionarBancoCompararBbx.SelectedItem.ToString()

        Try
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaCompararTxb.Text};User Id={NomeConectarTabelaCompararTxb.Text};Password={SenhaTabelaCompararTxb.Text};Database={nomeBanco}")
                conexaoBD.Open()

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

    ' Adicione os métodos e eventos relacionados à comparação de tabelas conforme necessário
End Class
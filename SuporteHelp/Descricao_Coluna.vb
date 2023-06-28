Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json
Public Class Descricao_Coluna
    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorColunasTxb.Text
        Dim usuario As String = NomeConectarColunasTxb.Text
        Dim senha As String = SenhaColunasTxb.Text

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
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", conexaoBD)
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
                SelecionarBancoColunasTxb.DataSource = listaBancos
                ' Desabilita o botão de pesquisa
                PesquisarColunaBtn.Enabled = False
                LimparColunaBtn.Enabled = False
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
            ExibirServidorDescCbx.DataSource = listaServidores
        End If
    End Sub

    Private Sub ExibirServidorTabelaCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorDescCbx.SelectedIndexChanged
        ' Obtém o índice do servidor selecionado no combobox
        Dim indiceServidor As Integer = ExibirServidorDescCbx.SelectedIndex

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
                ServidorColunasTxb.Text = dadosServidor(0)
                NomeConectarColunasTxb.Text = dadosServidor(1)
                SenhaColunasTxb.Text = dadosServidor(2)
            End If
        End If
    End Sub

    Private Sub Tabela_Coluna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub

    Private Sub SelecionarBancoColunasTxb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecionarBancoColunasTxb.SelectedIndexChanged
        ' Captura o nome do banco de dados selecionado no combobox
        Dim nomeBanco As String = SelecionarBancoColunasTxb.SelectedItem.ToString()

        Try
            ' Cria uma conexão com o banco de dados selecionado
            Using conexaoBD As New SqlConnection($"Server={ServidorColunasTxb.Text};User Id={NomeConectarColunasTxb.Text};Password={SenhaColunasTxb.Text};Database={nomeBanco}")
                ' Abre a conexão com o banco de dados
                conexaoBD.Open()

                ' Executa uma consulta SQL que retorna as colunas da tabela selecionada
                Dim comando As New SqlCommand("SELECT name as Nome_da_Coluna, description as Descricao, comment as Informacao, stnull as Aceita_null, objectid FROM ObjectField", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar as colunas da tabela selecionada
                Dim dt As New DataTable()
                dt.Load(leitor)

                ' Popula o DataGridView com as colunas da tabela selecionada
                MostarDetalheColunaDGV.DataSource = dt
                MostarDetalheColunaDGV.Columns(0).Width = 200
                MostarDetalheColunaDGV.Columns(1).Width = 200
                MostarDetalheColunaDGV.Columns(2).Width = 200
                MostarDetalheColunaDGV.Columns(3).Width = 100
                MostarDetalheColunaDGV.Columns(4).Visible = False

                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar colunas: " & ex.Message)
        End Try
    End Sub

    Private Sub SairTabelaColuna_Click(sender As Object, e As EventArgs) Handles SairTabelaColuna.Click
        Me.Close()
    End Sub

    Private Sub PesquisarColunaBtn_Click(sender As Object, e As EventArgs) Handles PesquisarColunaBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarColunaBtn.Enabled = False
        PesquisarDescricaoBtn.Enabled = False
        LimparDescricaoBtn.Enabled = False
        PesquisarInformacaoBtn.Enabled = False
        LimparInformacaoBtn.Enabled = False

        Dim searchTerm As String = PesquisarcolunaTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Nome_da_Coluna") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Nome_da_Coluna", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Nome_da_Coluna LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Coluna(s) encontrada.")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            MostarDetalheColunaDGV.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhuma Coluna encontrada.")
        End If
    End Sub

    Private Sub LimparColunaBtn_Click(sender As Object, e As EventArgs) Handles LimparColunaBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        PesquisarColunaBtn.Enabled = True
        PesquisarDescricaoBtn.Enabled = True
        LimparDescricaoBtn.Enabled = True
        PesquisarInformacaoBtn.Enabled = True
        LimparInformacaoBtn.Enabled = True
        ' Limpa o campo de pesquisa
        PesquisarcolunaTxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        MostarDetalheColunaDGV.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        ConectarBtn.PerformClick()
    End Sub

    Private Sub PesquisarDescricaoBtn_Click(sender As Object, e As EventArgs) Handles PesquisarDescricaoBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarDescricaoBtn.Enabled = False
        PesquisarColunaBtn.Enabled = False
        LimparColunaBtn.Enabled = False
        PesquisarInformacaoBtn.Enabled = False
        LimparInformacaoBtn.Enabled = False

        Dim searchTerm As String = PesquisarDescricaotxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Descricao") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Descricao", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Descricao LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Descrição não encontrada.")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            MostarDetalheColunaDGV.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhuma Descrição encontrada.")
        End If
    End Sub

    Private Sub LimparDescricaoBtn_Click(sender As Object, e As EventArgs) Handles LimparDescricaoBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        PesquisarDescricaoBtn.Enabled = True
        PesquisarColunaBtn.Enabled = True
        LimparColunaBtn.Enabled = True
        PesquisarInformacaoBtn.Enabled = True
        LimparInformacaoBtn.Enabled = True
        ' Limpa o campo de pesquisa
        PesquisarDescricaotxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        MostarDetalheColunaDGV.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        ConectarBtn.PerformClick()
    End Sub

    Private Sub PesquisarInformacaoBtn_Click(sender As Object, e As EventArgs) Handles PesquisarInformacaoBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarInformacaoBtn.Enabled = False
        PesquisarColunaBtn.Enabled = False
        LimparColunaBtn.Enabled = False
        PesquisarDescricaoBtn.Enabled = False
        LimparDescricaoBtn.Enabled = False

        Dim searchTerm As String = PesquisarInformacaoTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Informacao") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Informacao", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Informacao LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Informação não encontrada.")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            MostarDetalheColunaDGV.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhuma Informação encontrada.")
        End If
    End Sub

    Private Sub LimparInformacaoBtn_Click(sender As Object, e As EventArgs) Handles LimparInformacaoBtn.Click
        If ServidorColunasTxb.Text.Trim() = "" Or NomeConectarColunasTxb.Text.Trim() = "" Or SenhaColunasTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If
        PesquisarInformacaoBtn.Enabled = True
        PesquisarColunaBtn.Enabled = True
        LimparColunaBtn.Enabled = True
        PesquisarDescricaoBtn.Enabled = True
        LimparDescricaoBtn.Enabled = True
        ' Limpa o campo de pesquisa
        PesquisarInformacaoTxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(MostarDetalheColunaDGV.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        MostarDetalheColunaDGV.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        ConectarBtn.PerformClick()
    End Sub
End Class
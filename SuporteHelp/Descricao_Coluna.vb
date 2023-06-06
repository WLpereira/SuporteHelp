Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.Excel
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
                SelecionarBancoColunasTxb.SelectedIndex = -1 ' Define o índice selecionado como -1 para limpar a seleção atual

                ' Habilita o CheckBox para exibir o servidor salvo
                ExibirServidorDescCbx.Enabled = True
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try

        ' Salva as informações de servidor, nome e senha em um arquivo de texto
        Try
            Dim linha As String = servidor & "|" & usuario & "|" & senha
            Dim linhasExistentes As String() = If(File.Exists("dados_conexao.txt"), File.ReadAllLines("dados_conexao.txt"), New String() {})

            ' Verifica se a linha já existe no arquivo antes de adicioná-la
            If Not linhasExistentes.Contains(linha) Then
                Using writer As New StreamWriter("dados_conexao.txt", True)
                    writer.WriteLine(linha)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar as informações do servidor: " & ex.Message)
        End Try

        ' Carrega os servidores salvos no ComboBox
        CarregarServidoresSalvos()
    End Sub

    Private Sub CarregarServidoresSalvos()
        Try
            If File.Exists("dados_conexao.txt") Then
                ' Lê as linhas do arquivo de texto
                Dim linhas As String() = File.ReadAllLines("dados_conexao.txt")

                ' Cria um HashSet para armazenar os servidores salvos sem repetição
                Dim servidoresSalvos As New HashSet(Of String)

                ' Extrai as informações de servidor, nome e senha de cada linha
                For Each linha As String In linhas
                    Dim informacoes As String() = linha.Split("|"c)
                    Dim servidor As String = informacoes(0)
                    servidoresSalvos.Add(servidor)
                Next

                ' Popula o ComboBox com os servidores salvos
                ExibirServidorDescCbx.DataSource = servidoresSalvos.ToList()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os servidores salvos: " & ex.Message)
        End Try
    End Sub

    Private Sub ExibirServidorDescCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorDescCbx.SelectedIndexChanged
        ' Obtém o servidor selecionado no ComboBox
        Dim servidorSelecionado As String = ExibirServidorDescCbx.SelectedItem.ToString()

        ' Carrega as informações do servidor selecionado nos textboxes
        Try
            If File.Exists("dados_conexao.txt") Then
                ' Lê as linhas do arquivo de texto
                Dim linhas As String() = File.ReadAllLines("dados_conexao.txt")

                ' Variáveis para armazenar as informações do servidor selecionado
                Dim servidor As String = ""
                Dim usuario As String = ""
                Dim senha As String = ""

                ' Procura a linha correspondente ao servidor selecionado
                For Each linha As String In linhas
                    Dim informacoes As String() = linha.Split("|"c)

                    ' Verifica se a linha contém todas as informações necessárias
                    If informacoes.Length = 3 Then
                        Dim servidorLido As String = informacoes(0)

                        If servidorLido = servidorSelecionado Then
                            ' Armazena as informações do servidor selecionado
                            servidor = servidorLido
                            usuario = informacoes(1)
                            senha = informacoes(2)
                            Exit For
                        End If
                    End If
                Next

                ' Exibe as informações do servidor nos textboxes
                ServidorColunasTxb.Text = servidor
                NomeConectarColunasTxb.Text = usuario
                SenhaColunasTxb.Text = senha
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar as informações do servidor: " & ex.Message)
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
Imports NPOI.SS.Formula.Functions
Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json

Public Class Informação_do_banco
    Private Sub ConectarInformacaoBtn_Click(sender As Object, e As EventArgs) Handles ConectarInformacaoBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorInformacaoTxb.Text
        Dim usuario As String = NomeInformacaoTxb.Text
        Dim senha As String = SenhaInformacaoTxb.Text

        ' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Verifica se o servidor informado não é um dos servidores bloqueados
        If servidor = "cloud.informo.com.br,9898" OrElse servidor = "cloud.informo.com.br,9586" Then
            MessageBox.Show("Por motivos de segurança, esses servidores não podem ser acessados.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = $"Server={servidor};Database=master;User Id={usuario};Password={senha};"

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                ' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')oreder by name", conexaoBD)
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
                SelecionarBancoInformacaoCbx.DataSource = listaBancos

                ' Verifica se os dados de conexão já foram salvos
                If Not ExisteConexaoSalva(servidor, usuario, senha) Then
                    ' Salva os dados de conexão em um arquivo de texto
                    SalvarDadosConexao(servidor, usuario, senha)
                End If
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
            ExibirServidorIfoCbx.DataSource = listaServidores

            ' Verifica se há servidores salvos
            If listaServidores.Count > 0 Then
                ' Define o valor selecionado no combobox como o primeiro servidor da lista
                ExibirServidorIfoCbx.SelectedIndex = 0

                ' Obtém os dados do servidor selecionado
                Dim dadosServidor As String() = linhas(ExibirServidorIfoCbx.SelectedIndex).Split(","c)

                ' Preenche os campos de servidor, usuário e senha com os dados do servidor selecionado
                ServidorInformacaoTxb.Text = dadosServidor(0)
                NomeInformacaoTxb.Text = dadosServidor(1)
                SenhaInformacaoTxb.Text = dadosServidor(2)
            End If
        End If
    End Sub

    Private Sub ExibirServidorIfoCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorIfoCbx.SelectedIndexChanged
        ' Obtém o índice do servidor selecionado
        Dim indiceServidor As Integer = ExibirServidorIfoCbx.SelectedIndex

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
                ServidorInformacaoTxb.Text = dadosServidor(0)
                NomeInformacaoTxb.Text = dadosServidor(1)
                SenhaInformacaoTxb.Text = dadosServidor(2)
            End If
        End If
    End Sub

    Private Sub Informação_do_banco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub


    Private Sub MostrarCaminhoBtn_Click(sender As Object, e As EventArgs) Handles MostrarCaminhoBtn.Click
        If SelecionarBancoInformacaoCbx.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um banco de dados.")
            Return
        End If

        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorInformacaoTxb.Text
        Dim usuario As String = NomeInformacaoTxb.Text
        Dim senha As String = SenhaInformacaoTxb.Text

        '' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha & ";Database=master"

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                ' Executa a consulta para obter o caminho do arquivo de trace padrão
                Dim comando As New SqlCommand("SELECT path AS [Default Trace File] FROM sys.traces WHERE is_default = 1", conexaoBD)

                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Exibe o resultado no textbox de exibição de caminho
                If leitor.Read() Then
                    MostrarCaminhoTxb.Text = leitor("Default Trace File").ToString()
                Else
                    MostrarCaminhoTxb.Text = "Nenhum arquivo de trace padrão encontrado."
                End If

                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao obter caminho do arquivo de trace: " & ex.Message)
        End Try


    End Sub
    Private Sub MostrarinformacaoBtn_Click(sender As Object, e As EventArgs) Handles MostrarinformacaoBtn.Click
        If SelecionarBancoInformacaoCbx.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um banco de dados.")
            Return
        End If


        Dim servidor As String = ServidorInformacaoTxb.Text
        Dim caminhoTrace As String = MostrarCaminhoTxb.Text
        Dim nomeBanco As String = NomeBancoTxb.Text

        ' Verificar se o campo NomeBancoTxb está preenchido '
        If String.IsNullOrEmpty(nomeBanco) OrElse String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(caminhoTrace) Then
            MessageBox.Show("Por favor, preencha os campos.")
            Return
        End If



        Dim conexao As New SqlConnection($"Data Source={servidor};Initial Catalog=master;User Id=sa;Password=dp;")

        Try
            conexao.Open()

            ' Criar a tabela TraceTable '
            Dim createTableQuery As String = "USE tempdb; " &
                                         "IF OBJECT_ID('dbo.TraceTable', 'U') IS NOT NULL " &
                                         "    DROP TABLE dbo.TraceTable; " &
                                         "SELECT * " &
                                         "INTO TraceTable " &
                                         $"FROM ::fn_trace_gettable('{caminhoTrace}', default);"
            Dim createTableCommand As New SqlCommand(createTableQuery, conexao)
            createTableCommand.ExecuteNonQuery()

            ' Consulta para obter as informações desejadas '
            Dim selectQuery As String = "SELECT DatabaseID, DatabaseName AS Nome_do_Banco, LoginName AS Login, HostName AS Computador, " &
                            "       ApplicationName AS Software, StartTime AS DATA,TextData AS HISTORICO, " &
                            "       CASE " &
                            "           WHEN EventClass = 47 THEN 'Database Dropped' " &
                            "           WHEN EventClass = 115 THEN 'Database Restored' " &
                            "           ELSE 'NONE' " &
                            "       END AS EventType " &
                            "FROM tempdb.dbo.TraceTable " &
                            $"WHERE DatabaseName LIKE '%{nomeBanco}%' AND EventClass IN (47, 115) AND ApplicationName = 'Microsoft SQL Server Management Studio' " &
                            "ORDER BY StartTime DESC;"

            Dim selectCommand As New SqlCommand(selectQuery, conexao)
            Dim adapter As New SqlDataAdapter(selectCommand)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            ResultadoDgv.DataSource = tabela
        Catch ex As Exception
            MessageBox.Show($"Erro ao executar consulta: {ex.Message}")
        Finally
            conexao.Close()
        End Try

        ' Desabilita o botão de pesquisa
        MostrarTodosBtn.Enabled = False
    End Sub

    Private Sub SairInformacaoBancoBtn_Click(sender As Object, e As EventArgs) Handles SairInformacaoBancoBtn.Click
        Me.Close()
    End Sub

    Private Sub MostrarTodosBtn_Click(sender As Object, e As EventArgs) Handles MostrarTodosBtn.Click
        If SelecionarBancoInformacaoCbx.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um banco de dados.")
            Return
        End If


        Dim servidor As String = ServidorInformacaoTxb.Text
        Dim caminhoTrace As String = MostrarCaminhoTxb.Text
        Dim nomeBanco As String = NomeBancoTxb.Text

        ' Verificar se o campo NomeBancoTxb está preenchido '
        If String.IsNullOrEmpty(caminhoTrace) Then
            MessageBox.Show("Por favor, preencha os campos.")
            Return
        End If

        Dim conexao As New SqlConnection($"Data Source={servidor};Initial Catalog=master;User Id=sa;Password=dp;")

        Try
            conexao.Open()

            ' Criar a tabela TraceTable '
            Dim createTableQuery As String = "USE tempdb; " &
                                         "IF OBJECT_ID('dbo.TraceTable', 'U') IS NOT NULL " &
                                         "    DROP TABLE dbo.TraceTable; " &
                                         "SELECT * " &
                                         "INTO TraceTable " &
                                         $"FROM ::fn_trace_gettable('{caminhoTrace}', default);"
            Dim createTableCommand As New SqlCommand(createTableQuery, conexao)
            createTableCommand.ExecuteNonQuery()

            ' Consulta para obter as informações desejadas '
            Dim selectQuery As String = "SELECT DatabaseID, DatabaseName AS Nome_do_Banco, LoginName AS Login, HostName AS Computador, " &
                            "       ApplicationName AS Software, StartTime AS DATA,TextData AS HISTORICO, " &
                            "       CASE " &
                            "           WHEN EventClass = 47 THEN 'Database Dropped' " &
                            "           WHEN EventClass = 115 THEN 'Database Restored' " &
                            "           ELSE 'NONE' " &
                            "       END AS EventType " &
                            "FROM tempdb.dbo.TraceTable " &
                            $"WHERE DatabaseName LIKE '%{nomeBanco}%' AND EventClass IN (47, 115) AND ApplicationName = 'Microsoft SQL Server Management Studio' " &
                            "ORDER BY StartTime DESC;"

            Dim selectCommand As New SqlCommand(selectQuery, conexao)
            Dim adapter As New SqlDataAdapter(selectCommand)
            Dim tabela As New DataTable()
            adapter.Fill(tabela)
            ResultadoDgv.DataSource = tabela
        Catch ex As Exception
            MessageBox.Show($"Erro ao executar consulta: {ex.Message}")
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub LimparInfoBtn_Click(sender As Object, e As EventArgs) Handles LimparInfoBtn.Click
        ' Limpa o campo de pesquisa
        NomeBancoTxb.Text = ""

        ' Limpa o DataSource do DataGridView
        ResultadoDgv.DataSource = Nothing

        ' Chama o evento "Click" do botão "Conectar"
        ConectarInformacaoBtn.PerformClick()

        ' Habilita o botão "Mostrar Todos"
        MostrarTodosBtn.Enabled = True
    End Sub

End Class
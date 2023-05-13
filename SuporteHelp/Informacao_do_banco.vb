Imports NPOI.SS.Formula.Functions

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
                SelecionarBancoInformacaoCbx.DataSource = listaBancos
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarCaminhoBtn_Click(sender As Object, e As EventArgs) Handles MostrarCaminhoBtn.Click
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
        Dim servidor As String = ServidorInformacaoTxb.Text
        Dim caminhoTrace As String = MostrarCaminhoTxb.Text
        Dim nomeBanco As String = NomeBancoTxb.Text

        Dim conexao As New SqlConnection($"Data Source={servidor};Initial Catalog=master;Integrated Security=True;")
        Dim query As String = $"USE tempdb;
                            IF OBJECT_ID('dbo.TraceTable', 'U') IS NOT NULL
                                DROP TABLE dbo.TraceTable;
                            SELECT *
                            INTO TraceTable
                            FROM ::fn_trace_gettable('{caminhoTrace}', default);
                            SELECT DatabaseID, DatabaseName AS Nome_do_Banco, LoginName AS Login, HostName AS Computador, 
                                ApplicationName AS Software, ObjectName AS O_que_foi_Criado, TextData AS Historico, StartTime AS DATA,
                                CASE
                                    
                                    WHEN EventClass = 47 THEN 'Database Dropped'
                                    WHEN EventClass = 115 THEN 'Database Restored'
                                    ELSE 'NONE'
                                END AS Evento
                            FROM tempdb.dbo.TraceTable
                            WHERE DatabaseName like '%{nomeBanco}%'
                                AND (EventClass IN ( 47, 115))
                            ORDER BY StartTime asc;"
        Dim comando As New SqlCommand(query, conexao)
        Dim adapter As New SqlDataAdapter(comando)
        Dim tabela As New DataTable()

        Try
            conexao.Open()
            adapter.Fill(tabela)
            ResultadoDgv.DataSource = tabela
        Catch ex As Exception
            MessageBox.Show($"Erro ao executar consulta: {ex.Message}")
        Finally
            conexao.Close()
        End Try
    End Sub
End Class
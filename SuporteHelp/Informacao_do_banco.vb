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
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha & ";Database=master"

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                '' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso com o banco de dados master!")
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao conectar ao banco de dados master: " & ex.Message)
        End Try

    End Sub
End Class
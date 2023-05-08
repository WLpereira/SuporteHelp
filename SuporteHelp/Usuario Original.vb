Imports System.Data.SqlClient

Public Class Usuario_Original

    Private Sub ConectarUsuarioBtn_Click(sender As Object, e As EventArgs) Handles ConectarUsuarioBtn.Click
        ' Desabilita o botão de pesquisa
        ExecutarTodosUsuariosBtn.Enabled = False
        SelecionarUsuarioCbx.Enabled = False
        ExecutarUsuarioEspecificoBtn.Enabled = False

        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorUsuarioTxb.Text
        Dim usuario As String = NomeusuarioTxb.Text
        Dim senha As String = SenhaUsusarioTxb.Text

        '' Verifica se todos os campos foram preenchidos
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

                '' Exibe uma mensagem de sucesso ao conectar no servidor
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
                SelecionarBancoUsuarioBbx.DataSource = listaBancos
                ' Desabilita o botão de pesquisa
                ' ExecutarTodosUsuariosBtn.Enabled = False
                ' SelecionarUsuarioCbx.Enabled = False
                ' ExecutarUsuarioEspecificoBtn.Enabled = False
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
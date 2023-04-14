Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class BancosCloud

    Private Sub ConectarClodBtn_Click(sender As Object, e As EventArgs) Handles ConectarClodBtn.Click
        Dim servidor As String = ServidorCloudTxb.Text
        Dim usuario As String = UsernameTxb.Text
        Dim senha As String = SenhaTxb.Text

        ' Verifica se os campos estão preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar ao servidor.")
            Return ' Sai do método
        End If

        ' Aqui você deve implementar a lógica para conectar ao servidor com os dados fornecidos '
        ' e trazer o resultado para popular o ComboBox '
        ' Exemplo: '

        Dim connStr As String = $"Server={servidor};Database=master;User Id={usuario};Password={senha};"
        Dim conexao As SqlConnection = New SqlConnection(connStr)
        Try
            conexao.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", conexao)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                MostrarServidorCbx.Items.Add(reader("name"))
            End While
            MessageBox.Show("Conexão realizada com sucesso!")
        Catch ex As Exception
            MessageBox.Show($"Erro ao conectar ao servidor: {ex.Message}")
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub LimparCloudBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparCloudBtn.Click, LimparCloudBtn.Click
        ServidorCloudTxb.Text = ""
        UsernameTxb.Text = ""
        SenhaTxb.Text = ""
        SenhaOriginalTxb.Text = ""
    End Sub

    Private Sub AlterarBtn_Click(sender As Object, e As EventArgs) Handles AlterarBtn.Click
        ' Verifica se um banco de dados foi selecionado '
        If MostrarServidorCbx.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecione um banco de dados para atualizar.")
            Return
        End If

        Dim banco As String = MostrarServidorCbx.SelectedItem.ToString()
        Dim servidor As String = ServidorCloudTxb.Text
        Dim usuario As String = UsernameTxb.Text
        Dim senha As String = SenhaOriginalTxb.Text

        Dim connStr As String = $"Server={servidor};Database={banco};User Id={usuario};Password={senha};"
        Dim conexao As SqlConnection = New SqlConnection(connStr)

        ' Aqui você deve implementar a lógica para executar a consulta UPDATE '
        ' Substitua a consulta abaixo pela consulta real que você deseja executar '
        Dim consulta As String = "ALTER USER [sa] WITH PASSWORD=N'dp'"
        Try
            conexao.Open()
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexao)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Atualização concluída com sucesso!")
        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar o banco de dados: {ex.Message}")
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

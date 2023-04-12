Imports System.Net.Sockets

Public Class Validar_E_Mail
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ValidarEmailBtn_Click(sender As Object, e As EventArgs) Handles ValidarEmailBtn.Click
        Dim smtp As New System.Net.Mail.SmtpClient()
        smtp.Host = SmtpTxb.Text
        smtp.Port = Convert.ToInt32(PortaTxb.Text)
        smtp.Credentials = New System.Net.NetworkCredential(EmailTxb.Text, SenhaEmailTxb.Text)
        smtp.EnableSsl = True ' habilita SSL/TLS
        Try
            smtp.Send(EmailTxb.Text, "washington.pereira@dataplace.com.br", "Teste de conexão SMTP", "Este é um teste de conexão SMTP DATAPLACE.")
            MessageBox.Show("Conexão SMTP bem-sucedida.")
            SmtpTxb.Clear()
            PortaTxb.Clear()
            EmailTxb.Clear()
            SenhaEmailTxb.Clear()
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao SMTP: " + ex.Message)
        End Try
    End Sub

    Private Sub ValidarSmtpBtn_Click(sender As Object, e As EventArgs) Handles ValidarSmtpBtn.Click
        Dim smtp As String = SmtpTxb.Text
        Dim porta As Integer = Convert.ToInt32(PortaTxb.Text)

        Dim cliente As New TcpClient()

        Try
            cliente.Connect(smtp, porta)
            MessageBox.Show("Conexão SMTP válida.")
            SmtpTxb.Clear()
            PortaTxb.Clear()
        Catch ex As Exception
            MessageBox.Show("Não foi possível se conectar ao servidor SMTP: " + ex.Message)
        Finally
            cliente.Close()
        End Try
    End Sub

    Private Sub LimparBtn_Click(sender As Object, e As EventArgs) Handles LimparBtn.Click
        SmtpTxb.Text = ""
        PortaTxb.Text = ""
        SenhaEmailTxb.Text = ""
        EmailTxb.Text = ""
    End Sub
End Class
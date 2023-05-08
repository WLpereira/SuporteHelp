Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Controls
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

Public Class Sugestao
    Private Sub EnviarBtn_Click(sender As Object, e As EventArgs) Handles EnviarBtn.Click
        ' Verifica se o campo de texto está vazio
        If String.IsNullOrEmpty(TextoEmailRtb.Text) Then
            MessageBox.Show("O campo de texto do e-mail está vazio. Preencha antes de enviar.")
            Return
        End If

        ' Cria um objeto de mensagem de e-mail
        Dim mail As New MailMessage()

        ' Define o remetente e o destinatário
        mail.From = New MailAddress("washington.pereira@dataplace.com.br")
        mail.To.Add("wluispereira.dataplace@gmail.com")

        ' Define o assunto e o corpo do e-mail
        mail.Subject = "Sugestão para SuporteHelp"
        mail.Body = TextoEmailRtb.Text

        ' Configura as credenciais de autenticação para o cliente de e-mail
        Dim smtp As New SmtpClient("smtp.office365.com")
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential("wluispereira.dataplace@gmail.com", "Wlpdataplace123")

        ' Envia o e-mail
        Try
            smtp.Send(mail)
            MessageBox.Show("E-mail enviado com sucesso!")
            TextoEmailRtb.Clear()
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar o e-mail: " & ex.Message)
        End Try
    End Sub

    Private Sub LimparTextoBtn_Click(sender As Object, e As EventArgs) Handles LimparTextoBtn.Click
        TextoEmailRtb.Clear()
    End Sub

    Private Sub SairTextoBtn_Click(sender As Object, e As EventArgs) Handles SairTextoBtn.Click
        Me.Close()
    End Sub
End Class
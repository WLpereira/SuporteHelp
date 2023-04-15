﻿Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Controls
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

Public Class Sugestao
    Private Sub EnviarBtn_Click(sender As Object, e As EventArgs) Handles EnviarBtn.Click
        ' Cria um objeto de mensagem de e-mail
        Dim mail As New MailMessage()

        ' Define o remetente e o destinatário
        mail.From = New MailAddress("washington.pereira@dataplace.com.br")
        mail.To.Add("washington.pereira@dataplace.com.br")

        ' Define o assunto e o corpo do e-mail
        mail.Subject = "Sugestão para SuporteHelp"
        mail.Body = TextoEmailRtb.Text

        ' Configura as credenciais de autenticação para o cliente de e-mail
        Dim smtp As New SmtpClient("smtp.office365.com")
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential("washington.pereira@dataplace.com.br", "Wlpdataplace123")

        ' Envia o e-mail
        Try
            smtp.Send(mail)
            MessageBox.Show("E-mail enviado com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar o e-mail: " & ex.Message)
        End Try
    End Sub
End Class
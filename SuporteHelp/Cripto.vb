Imports System.Security.Cryptography
Imports NPOI.POIFS.Crypt

Public Class Cripto
    Private Sub CriptografarBtn_Click(sender As Object, e As EventArgs) Handles CriptografarBtn.Click
        ' Crie uma instância da classe MyEncryptor, que herda da classe Encryptor da biblioteca Library3
        Dim encryptor As New MyEncryptor()

        ' Converta a senha em uma string
        Dim senha As String = SenhaAtualTxb.Text

        ' Criptografe a senha
        Dim senhaCriptografada As String = encryptor.Encrypt(senha)

        ' Exiba a senha criptografada no TextBox2
        SenhaNovaTxb.Text = senhaCriptografada
    End Sub

    Private Sub DescriptografarBtn_Click(sender As Object, e As EventArgs) Handles DescriptografarBtn.Click
        ' Crie uma instância da classe MyEncryptor, que herda da classe Encryptor da biblioteca Library3
        Dim encryptor As New MyEncryptor()

        ' Converta a senha criptografada em uma string
        Dim senhaCriptografada As String = SenhaAtualTxb.Text

        ' Descriptografe a senha
        Try
            Dim senhaDescriptografada As String = encryptor.Decrypt(senhaCriptografada)

            ' Exiba a senha descriptografada no TextBox2
            SenhaNovaTxb.Text = senhaDescriptografada
        Catch ex As CryptographicException
            ' Trate a exceção de descriptografia inválida
            MessageBox.Show("Senha inválida")
        End Try
    End Sub

    Private Sub LimparCriptoBtn_Click(sender As Object, e As EventArgs) Handles LimparCriptoBtn.Click
        SenhaAtualTxb.Text = ""
        SenhaNovaTxb.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' Importe a biblioteca System.Security.Cryptography para usar as classes de criptografia
    ' Importe as bibliotecas necessárias
End Class

' Crie uma classe abstrata para servir como base para a criptografia
Public MustInherit Class Encryptor
    Public MustOverride Function Encrypt(data As String) As String
    Public MustOverride Function Decrypt(data As String) As String
End Class

' Crie uma classe derivada da classe Encryptor da biblioteca Library3 para implementar a lógica de criptografia
Public Class MyEncryptor
    Inherits Encryptor

    Private Shared ReadOnly key As Byte() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
    Private Shared ReadOnly ivSize As Integer = 16
    Private iv As Byte()

    Public Sub New()
        ' Crie um vetor de inicialização aleatório
        Using rng As New RNGCryptoServiceProvider()
            ReDim iv(ivSize - 1)
            rng.GetBytes(iv)
        End Using
    End Sub

    Public Overrides Function Encrypt(data As String) As String
        Dim aes As Aes = Aes.Create()
        aes.Key = key
        aes.IV = iv

        Dim encryptor As ICryptoTransform = aes.CreateEncryptor()

        Dim inputBuffer As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
        Dim outputBuffer As Byte() = encryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length)

        Return Convert.ToBase64String(outputBuffer)
    End Function

    Public Overrides Function Decrypt(data As String) As String
        Dim aes As Aes = Aes.Create()
        aes.Key = key
        aes.IV = iv

        Dim decryptor As ICryptoTransform = aes.CreateDecryptor()

        Try
            Dim inputBuffer As Byte() = Convert.FromBase64String(data)
            Dim outputBuffer As Byte() = decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length)

            Return System.Text.Encoding.UTF8.GetString(outputBuffer)
        Catch ex As FormatException
            ' Trate a exceção de string inválida em Base64
            Throw New CryptographicException("A senha fornecida não está em um formato válido.")
        End Try
    End Function
End Class
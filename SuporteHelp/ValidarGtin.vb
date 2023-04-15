Public Class ValidarGtin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SairGtinbtn.Click
        Me.Close()
    End Sub

    Private Sub LimparGtinBtn_Click(sender As Object, e As EventArgs) Handles LimparGtinBtn.Click
        ValidarGtinTxb.Clear()
    End Sub

    Private Function ValidarGtin(gtin As String) As Boolean
        ' Verifica se o GTIN possui 8, 12, 13 ou 14 dígitos
        If gtin.Length <> 8 AndAlso gtin.Length <> 12 AndAlso gtin.Length <> 13 AndAlso gtin.Length <> 14 Then
            Return False
        End If

        ' Calcula o dígito verificador do GTIN
        Dim soma As Integer = 0
        For i As Integer = gtin.Length - 2 To 0 Step -1
            Dim digito As Integer = Integer.Parse(gtin(i))
            If (gtin.Length - i) Mod 2 = 0 Then
                soma += digito * 3
            Else
                soma += digito
            End If
        Next
        Dim digitoVerificador As Integer = (10 - (soma Mod 10)) Mod 10

        ' Verifica se o dígito verificador informado é igual ao calculado
        Return Integer.Parse(gtin(gtin.Length - 1)) = digitoVerificador
    End Function

    Private Sub ValidarBtn_Click(sender As Object, e As EventArgs) Handles ValidarBtn.Click
        ' Verifica se o campo de texto está vazio
        If String.IsNullOrEmpty(ValidarGtinTxb.Text) Then
            MessageBox.Show("O campo de texto está vazio. Preencha antes de validar.")
            Return
        End If

        ' Obtém o GTIN informado no TextBox
        Dim gtin As String = ValidarGtinTxb.Text.Trim()

        ' Valida o GTIN e exibe o resultado em um MessageBox
        If ValidarGtin(gtin) Then
            MessageBox.Show("GTIN válido!")
            ValidarGtinTxb.Clear()
        Else
            MessageBox.Show("GTIN inválido!")
            ValidarGtinTxb.Clear()
        End If
    End Sub
End Class
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

    Private Sub CodigoImg_Click(sender As Object, e As EventArgs) Handles CodigoImg.Click
        MessageBox.Show("O GTIN (Global Trade Item Number) é um código numérico de barras utilizado para identificar produtos e embalagens
 em transações comerciais. Para ser considerado válido, o GTIN deve seguir um padrão específico
 de numeração e ter um dígito verificador válido, que é calculado a partir dos outros dígitos do código.

O GTIN pode ter 8, 12, 13 ou 14 dígitos, dependendo do tipo de código utilizado. Além disso, cada dígito do GTIN 
possui um peso que é utilizado no cálculo do dígito verificador. Para validar um GTIN, é necessário calcular
 o dígito verificador a partir dos dígitos do código, somando os produtos dos dígitos pelo seu peso e verificando
 se o resultado é um múltiplo de 10. Se o dígito verificador for igual ao dígito do GTIN, o código é considerado válido.")
    End Sub
End Class
Imports System.IO

Public Class Gerenciador_Porta

    Private Sub Gerenciador_Porta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar as portas no ComboBox
        CarregarPortas()
    End Sub

    Private Sub CarregarPortas()
        ' Caminho do arquivo
        Dim filePath As String = Path.Combine(Application.StartupPath, "Portas", "Portas.txt")

        ' Verificar se o arquivo existe
        If File.Exists(filePath) Then
            ' Limpar ComboBox
            PortaCbx.Items.Clear()

            ' Ler todas as linhas do arquivo
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Adicionar as portas ao ComboBox
            PortaCbx.Items.AddRange(lines)
        Else
            MessageBox.Show("O arquivo de portas não foi encontrado.")
        End If
    End Sub

    Private Sub ExcluirPortaBtn_Click(sender As Object, e As EventArgs) Handles ExcluirPortaBtn.Click
        Dim selectedPorta As String = PortaCbx.SelectedItem

        If selectedPorta IsNot Nothing Then
            ' Caminho do arquivo
            Dim filePath As String = Path.Combine(Application.StartupPath, "Portas", "Portas.txt")

            ' Verificar se o arquivo existe
            If File.Exists(filePath) Then
                ' Ler todas as linhas do arquivo
                Dim lines() As String = File.ReadAllLines(filePath)

                ' Criar um novo array de linhas sem a linha a ser excluída
                Dim updatedLines As New List(Of String)(lines)
                updatedLines.Remove(selectedPorta)

                ' Sobrescrever o arquivo com as linhas atualizadas
                File.WriteAllLines(filePath, updatedLines)

                ' Recarregar as portas no ComboBox
                CarregarPortas()

                MessageBox.Show("Porta excluída com sucesso.")
            Else
                MessageBox.Show("O arquivo de portas não foi encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, selecione uma porta para excluir.")
        End If
    End Sub

    Private Sub CadastrarBtn_Click(sender As Object, e As EventArgs) Handles CadastrarBtn.Click
        Dim porta As String = PortaTxt.Text.Trim()

        ' Verificar se o campo está vazio
        If String.IsNullOrEmpty(porta) Then
            MessageBox.Show("Por favor, insira uma porta válida.")
            Return
        End If

        ' Caminho do arquivo
        Dim filePath As String = Path.Combine(Application.StartupPath, "Portas", "Portas.txt")

        ' Verificar se o arquivo existe, senão criar
        If Not File.Exists(filePath) Then
            File.Create(filePath).Close()
        End If

        ' Ler todas as linhas do arquivo
        Dim lines() As String = File.ReadAllLines(filePath)

        ' Verificar se a porta já existe no arquivo
        If Array.Exists(lines, Function(line) line.Trim().Equals(porta)) Then
            MessageBox.Show("Esta porta já está cadastrada.")
            Return
        End If

        ' Adicionar a nova porta ao arquivo
        Using writer As New StreamWriter(filePath, True)
            writer.WriteLine(porta)
        End Using

        MessageBox.Show("Porta cadastrada com sucesso.")

        ' Limpar o campo PortaTxt
        PortaTxt.Clear()
    End Sub


End Class
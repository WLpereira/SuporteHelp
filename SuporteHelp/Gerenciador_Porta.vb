Imports System.IO

Public Class Gerenciador_Porta

    Private Sub Gerenciador_Porta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar as portas no ComboBox
        CarregarPortas()
    End Sub

    Private Sub CarregarPortas()
        ' Caminho do arquivo de portas padrão
        Dim portasFilePath As String = Path.Combine(Application.StartupPath, "Portas.txt")

        ' Verificar se o arquivo de portas existe
        If File.Exists(portasFilePath) Then
            ' Limpar ComboBox
            PortaCbx.Items.Clear()

            ' Ler todas as linhas do arquivo
            Dim lines() As String = File.ReadAllLines(portasFilePath)

            ' Adicionar as portas ao ComboBox
            PortaCbx.Items.AddRange(lines)
        Else
            MessageBox.Show("O arquivo de portas não foi encontrado.")
        End If
    End Sub

    Private Sub ExcluirPortaBtn_Click(sender As Object, e As EventArgs) Handles ExcluirPortaBtn.Click
        Dim selectedPorta As String = PortaCbx.SelectedItem

        If selectedPorta IsNot Nothing Then
            ' Caminho do arquivo de portas
            Dim portasFilePath As String = Path.Combine(Application.StartupPath, "Portas.txt")

            ' Verificar se o arquivo de portas existe
            If File.Exists(portasFilePath) Then
                ' Ler todas as linhas do arquivo
                Dim lines() As String = File.ReadAllLines(portasFilePath)

                ' Criar um novo array de linhas sem a linha a ser excluída
                Dim updatedLines As New List(Of String)(lines)
                updatedLines.Remove(selectedPorta)

                ' Sobrescrever o arquivo com as linhas atualizadas
                File.WriteAllLines(portasFilePath, updatedLines)

                ' Limpar o ComboBox
                PortaCbx.Items.Clear()
                PortaCbx.SelectedItem = Nothing ' Limpar a seleção do ComboBox

                ' Caminho do arquivo específico da porta
                Dim portaFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{selectedPorta}.txt")

                ' Verificar se o arquivo da porta existe e excluí-lo
                If File.Exists(portaFilePath) Then
                    File.Delete(portaFilePath)
                    MessageBox.Show("Arquivo da porta excluído com sucesso.")
                End If

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
            MessageBox.Show("Por favor, insira um nome de arquivo válido.")
            Return
        End If

        ' Caminho completo do novo arquivo
        Dim newFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{porta}.txt")

        ' Verificar se o arquivo já existe
        If File.Exists(newFilePath) Then
            MessageBox.Show("Um arquivo com esse nome já existe.")
            Return
        End If

        ' Criar o novo arquivo
        File.Create(newFilePath).Close()

        ' Adicionar a nova porta ao arquivo de portas padrão
        Dim portasFilePath As String = Path.Combine(Application.StartupPath, "Portas.txt")
        File.AppendAllText(portasFilePath, porta & Environment.NewLine)

        MessageBox.Show("Arquivo criado e porta cadastrada com sucesso.")

        ' Limpar o campo PortaTxt
        PortaTxt.Clear()

        ' Atualizar a lista de portas no ComboBox
        CarregarPortas()
    End Sub

    Private Sub AtualizarListaBtn_Click(sender As Object, e As EventArgs) Handles AtualizarListaBtn.Click
        ' Carregar as portas no ComboBox
        CarregarPortas()
    End Sub

    Private Sub CarregarPortasBtn_Click(sender As Object, e As EventArgs) Handles CarregarPortasBtn.Click
        ' Caminho da pasta "Portas"
        Dim portasFolderPath As String = Path.Combine(Application.StartupPath, "Portas")

        ' Verificar se a pasta existe
        If Directory.Exists(portasFolderPath) Then
            ' Limpar ComboBox
            ListarPortasCbx.Items.Clear()

            ' Obter todos os arquivos na pasta "Portas"
            Dim portaFiles As String() = Directory.GetFiles(portasFolderPath)

            ' Adicionar os nomes dos arquivos ao ComboBox
            For Each portaFile As String In portaFiles
                ListarPortasCbx.Items.Add(Path.GetFileNameWithoutExtension(portaFile))
            Next

            MessageBox.Show("Portas carregadas com sucesso.")
        Else
            MessageBox.Show("A pasta de portas não foi encontrada.")
        End If

    End Sub
    Private Sub CadastrarBancoBtn_Click(sender As Object, e As EventArgs) Handles CadastrarBancoBtn.Click
        Dim banco As String = CadastrarBancosTxt.Text.Trim()

        ' Verificar se o campo está vazio
        If String.IsNullOrEmpty(banco) Then
            MessageBox.Show("Por favor, insira um nome de banco válido.")
            Return
        End If

        Dim selectedPorta As String = ListarPortasCbx.SelectedItem

        ' Verificar se uma porta foi selecionada
        If selectedPorta IsNot Nothing Then
            ' Caminho do arquivo da porta selecionada
            Dim portaFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{selectedPorta}.txt")

            ' Verificar se o arquivo da porta existe
            If File.Exists(portaFilePath) Then
                ' Adicionar o banco ao arquivo da porta
                File.AppendAllText(portaFilePath, banco & Environment.NewLine)

                MessageBox.Show($"Banco '{banco}' adicionado ao arquivo da porta '{selectedPorta}' com sucesso.")
            Else
                MessageBox.Show($"O arquivo da porta '{selectedPorta}' não foi encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, selecione uma porta.")
        End If
    End Sub
    Private Sub ListarPortasCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListarPortasCbx.SelectedIndexChanged
        ' Limpar o ComboBox de conteúdo da porta
        ConteudoPortaCbx.Items.Clear()

        ' Verificar se uma porta está selecionada
        Dim selectedPorta As String = ListarPortasCbx.SelectedItem
        If selectedPorta IsNot Nothing Then
            ' Caminho do arquivo da porta selecionada
            Dim portaFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{selectedPorta}.txt")

            ' Verificar se o arquivo da porta existe
            If File.Exists(portaFilePath) Then
                ' Ler todas as linhas do arquivo da porta e adicionar ao ComboBox de conteúdo da porta
                Dim lines() As String = File.ReadAllLines(portaFilePath)
                ConteudoPortaCbx.Items.AddRange(lines)
            Else
                MessageBox.Show($"O arquivo da porta '{selectedPorta}' não foi encontrado.")
            End If
        End If
    End Sub

    Private Sub ExcluirBancoBtn_Click(sender As Object, e As EventArgs) Handles ExcluirBancoBtn.Click
        ' Verificar se uma linha está selecionada no ComboBox de conteúdo da porta
        If ConteudoPortaCbx.SelectedIndex <> -1 Then
            ' Obter a porta selecionada
            Dim selectedPorta As String = ListarPortasCbx.SelectedItem

            ' Verificar se uma porta está selecionada
            If selectedPorta IsNot Nothing Then
                ' Caminho do arquivo da porta selecionada
                Dim portaFilePath As String = Path.Combine(Application.StartupPath, "Portas", $"{selectedPorta}.txt")

                ' Verificar se o arquivo da porta existe
                If File.Exists(portaFilePath) Then
                    ' Ler todas as linhas do arquivo da porta
                    Dim lines() As String = File.ReadAllLines(portaFilePath)

                    ' Remover a linha selecionada
                    Dim updatedLines As New List(Of String)(lines)
                    updatedLines.RemoveAt(ConteudoPortaCbx.SelectedIndex)

                    ' Reescrever o arquivo sem a linha removida
                    File.WriteAllLines(portaFilePath, updatedLines)

                    ' Atualizar o ComboBox de conteúdo da porta
                    ConteudoPortaCbx.Items.RemoveAt(ConteudoPortaCbx.SelectedIndex)

                    MessageBox.Show("Banco excluído com sucesso.")
                Else
                    MessageBox.Show($"O arquivo da porta '{selectedPorta}' não foi encontrado.")
                End If
            End If
        Else
            MessageBox.Show("Por favor, selecione um banco para excluir.")
        End If
    End Sub
End Class
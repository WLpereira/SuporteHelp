Imports System.IO

Public Class Empresas


    Private Sub CadastrarEmpresaBtn_Click(sender As Object, e As EventArgs) Handles CadastrarEmpresaBtn.Click
        ' Ler as informações dos campos de texto
        Dim nomeEmpresa As String = NomeEmpresaTxb.Text
        Dim servidorEmpresa As String = ServidorEmpresaTxb.Text
        Dim senhaSA As String = SenhaSATxb.Text
        Dim porta As String = PortaEmpresaTxb.Text

        ' Verificar se algum campo está vazio
        If String.IsNullOrWhiteSpace(nomeEmpresa) OrElse String.IsNullOrWhiteSpace(servidorEmpresa) OrElse String.IsNullOrWhiteSpace(senhaSA) OrElse String.IsNullOrWhiteSpace(porta) Then
            MessageBox.Show("Todos os campos devem ser preenchidos.")
            Return
        End If

        ' Escrever as informações no arquivo texto
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "empresa.txt")

        Try
            Using writer As New StreamWriter(caminhoArquivo, True)
                ' Escrever as informações no arquivo texto, separadas por vírgulas
                writer.WriteLine($"{nomeEmpresa},{servidorEmpresa},{senhaSA},{porta}")
            End Using

            ' Adicionar colunas ao DataGridView EmpresasDgv
            AdicionarColunas()

            ' Atualizar o DataGridView com as informações do arquivo texto
            AtualizarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar empresa: " & ex.Message)
        End Try
    End Sub

    Private Sub AtualizarDataGridView()
        ' Limpar o DataGridView antes de atualizar
        EmpresasDgv.Rows.Clear()

        ' Ler as informações do arquivo texto e preencher o DataGridView
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "empresa.txt")

        If File.Exists(caminhoArquivo) Then
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 4 Then
                    EmpresasDgv.Rows.Add(dados)
                End If
            Next
        End If
    End Sub

    ' Adiciona colunas ao DataGridView EmpresasDgv
    Private Sub AdicionarColunas()
        ' Limpa as colunas existentes, se houver
        EmpresasDgv.Columns.Clear()

        ' Adiciona as colunas Nome, Servidor, Senha SA e Porta
        EmpresasDgv.Columns.Add("NomeColumn", "Nome")
        EmpresasDgv.Columns.Add("ServidorColumn", "Servidor")
        EmpresasDgv.Columns.Add("SenhaSAColumn", "Senha SA")
        EmpresasDgv.Columns.Add("PortaColumn", "Porta")
    End Sub

    Private Sub LimparCadastroBtn_Click(sender As Object, e As EventArgs) Handles LimparCadastroBtn.Click
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
    End Sub
End Class
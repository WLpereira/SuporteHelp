Imports System.IO

Public Class Empresas

    ' Variáveis de classe para armazenar os dados da empresa selecionada para exclusão
    Private nomeEmpresaSelecionada As String
    Private servidorEmpresaSelecionado As String
    Private senhaSASelecionada As String
    Private portaSelecionada As String

    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adicionar colunas ao DataGridView EmpresasDgv ao carregar o formulário
        AdicionarColunas()
    End Sub

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

            ' Atualizar o DataGridView com as informações do arquivo texto
            AtualizarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar empresa: " & ex.Message)
        End Try
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
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

    Private Sub AdicionarColunas()
        ' Adicionar colunas apenas se o DataGridView não tiver colunas
        If EmpresasDgv.Columns.Count = 0 Then
            EmpresasDgv.Columns.Add("NomeColumn", "Nome")
            EmpresasDgv.Columns.Add("ServidorColumn", "Servidor")
            EmpresasDgv.Columns.Add("SenhaSAColumn", "Senha SA")
            EmpresasDgv.Columns.Add("PortaColumn", "Porta")

            ' Ajustar o tamanho das colunas
            EmpresasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub LimparCadastroBtn_Click(sender As Object, e As EventArgs) Handles LimparCadastroBtn.Click
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
    End Sub

    Private Sub CarregarBtn_Click(sender As Object, e As EventArgs) Handles CarregarBtn.Click
        ' Limpar o DataGridView antes de carregar
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
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
        FiltrarPortaTxb.Clear()
    End Sub

    Private Sub ExcluirEmpresaBtn_Click(sender As Object, e As EventArgs) Handles ExcluirEmpresaBtn.Click
        ' Verificar se há uma linha selecionada no DataGridView
        If EmpresasDgv.SelectedRows.Count > 0 Then
            ' Obter a linha selecionada
            Dim row As DataGridViewRow = EmpresasDgv.SelectedRows(0)

            ' Obter os dados da linha selecionada
            nomeEmpresaSelecionada = row.Cells("NomeColumn").Value.ToString()
            servidorEmpresaSelecionado = row.Cells("ServidorColumn").Value.ToString()
            senhaSASelecionada = row.Cells("SenhaSAColumn").Value.ToString()
            portaSelecionada = row.Cells("PortaColumn").Value.ToString()

            ' Remover a linha selecionada do DataGridView
            EmpresasDgv.Rows.Remove(row)

            ' Atualizar o arquivo "empresas.txt" sem a linha removida
            AtualizarArquivoEmpresas()

            MessageBox.Show("Empresa excluída com sucesso.")
        Else
            MessageBox.Show("Por favor, selecione uma empresa para excluir.")
        End If
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
        FiltrarPortaTxb.Clear()
    End Sub

    Private Sub AtualizarArquivoEmpresas()
        ' Obter o caminho do arquivo "empresas.txt"
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "empresa.txt")

        ' Criar uma lista para armazenar as linhas atualizadas
        Dim linhasAtualizadas As New List(Of String)

        ' Ler as linhas do arquivo "empresas.txt"
        If File.Exists(caminhoArquivo) Then
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Adicionar todas as linhas, exceto a linha removida, à lista de linhas atualizadas
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 4 AndAlso Not (dados(0) = nomeEmpresaSelecionada AndAlso
                                         dados(1) = servidorEmpresaSelecionado AndAlso
                                         dados(2) = senhaSASelecionada AndAlso
                                         dados(3) = portaSelecionada) Then
                    linhasAtualizadas.Add(linha)
                End If
            Next

            ' Escrever as linhas atualizadas de volta ao arquivo "empresas.txt"
            File.WriteAllLines(caminhoArquivo, linhasAtualizadas.ToArray())
        End If
    End Sub

    Private Sub FiltrarBtn_Click(sender As Object, e As EventArgs) Handles FiltrarBtn.Click
        ' Verificar se o DataGridView EmpresasDgv não está vazio
        If EmpresasDgv.Rows.Count = 0 Then
            MessageBox.Show("Não há empresas para filtrar.")
            Return
        End If

        ' Obter a porta especificada para filtrar
        Dim portaFiltrar As String = FiltrarPortaTxb.Text

        ' Verificar se o campo de texto de porta para filtrar está vazio
        If String.IsNullOrWhiteSpace(portaFiltrar) Then
            MessageBox.Show("Por favor, insira um número de porta para filtrar.")
            Return
        End If

        ' Limpar as seleções existentes no DataGridView
        EmpresasDgv.ClearSelection()

        ' Iterar sobre as linhas do DataGridView e exibir apenas as linhas com a porta correspondente
        For Each row As DataGridViewRow In EmpresasDgv.Rows
            ' Verificar se a célula da porta não é nula antes de acessar o valor
            If row.Cells("PortaColumn").Value IsNot Nothing Then
                Dim portaEmpresa As String = row.Cells("PortaColumn").Value.ToString()

                ' Comparar a porta da empresa com a porta especificada para filtrar
                If portaEmpresa = portaFiltrar Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next

        ' Verificar se pelo menos uma empresa foi encontrada com a porta especificada
        Dim empresasEncontradas As Boolean = False
        For Each row As DataGridViewRow In EmpresasDgv.Rows
            If row.Visible Then
                empresasEncontradas = True
                Exit For
            End If
        Next

        If Not empresasEncontradas Then
            MessageBox.Show("Não há empresas com a porta especificada.")
        End If
    End Sub

    Private Sub LimparEmpresasBtn_Click(sender As Object, e As EventArgs) Handles LimparEmpresasBtn.Click
        ' Chama o método CarregarBtn_Click para carregar as empresas
        CarregarBtn_Click(sender, e)
        NomeEmpresaTxb.Clear()
        ServidorEmpresaTxb.Clear()
        SenhaSATxb.Clear()
        PortaEmpresaTxb.Clear()
        FiltrarPortaTxb.Clear()

    End Sub

    Private Sub VoltarBtn_Click(sender As Object, e As EventArgs) Handles VoltarBtn.Click
        ' Esconde o formulário atual
        Me.Hide()

        ' Cria uma instância do formulário Ferramenta_Cloud
        Dim formFerramentaCloud As New Ferramenta_Cloud()

        ' Exibe o formulário Ferramenta_Cloud
        formFerramentaCloud.Show()
    End Sub
End Class
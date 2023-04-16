﻿Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.Excel

Public Class Tabela_Coluna
    Private Sub SairTabelaColuna_Click(sender As Object, e As EventArgs) Handles SairTabelaColuna.Click
        Me.Close()
    End Sub

    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTabelaTxb.Text
        Dim usuario As String = NomeConectarTabelaTxb.Text
        Dim senha As String = SenhaTabelaTxb.Text

        '' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                '' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma lista para armazenar os nomes dos bancos de dados
                Dim listaBancos As New List(Of String)

                ' Popula a lista com os nomes dos bancos de dados
                While leitor.Read()
                    listaBancos.Add(leitor("Nome").ToString())
                End While

                ' Fecha o leitor de dados
                leitor.Close()

                ' Popula o combobox com os nomes dos bancos de dados
                SelecionarBancoBbx.DataSource = listaBancos
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub SelecionarBancoBbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecionarBancoBbx.SelectedIndexChanged

        ' Captura o nome do banco de dados selecionado no combobox
        Dim nomeBanco As String = SelecionarBancoBbx.SelectedItem.ToString()

        Try
            ' Cria uma conexão com o banco de dados selecionado
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaTxb.Text};User Id={NomeConectarTabelaTxb.Text};Password={SenhaTabelaTxb.Text};Database={nomeBanco}")
                ' Abre a conexão com o banco de dados
                conexaoBD.Open()

                ' Executa uma consulta SQL que retorna as tabelas do banco de dados selecionado
                Dim comando As New SqlCommand("SELECT TABLE_NAME as Nome_da_Tabela FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'order by TABLE_NAME", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar os nomes das tabelas do banco de dados selecionado
                Dim dt As New DataTable()
                dt.Load(leitor)
                ' Popula o DataGridView com os nomes das tabelas do banco de dados selecionado
                ListadeTabelaDtg.DataSource = dt
                ListadeTabelaDtg.Columns(0).Width = 200

                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar tabelas: " & ex.Message)
        End Try
    End Sub

    Private Sub PesquisarTabelaBtn_Click(sender As Object, e As EventArgs) Handles PesquisarTabelaBtn.Click

        If ServidorTabelaTxb.Text.Trim() = "" Or NomeConectarTabelaTxb.Text.Trim() = "" Or SenhaTabelaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarTabelaBtn.Enabled = False

        Dim searchTerm As String = PesquisatabelaTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListadeTabelaDtg.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Nome_da_Tabela") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Nome_da_Tabela", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Nome_da_Tabela LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Tabela(s) encontrada.")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            ListadeTabelaDtg.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhuma tabela encontrada.")
        End If
    End Sub

    Private Sub LimparTabelaBtn_Click(sender As Object, e As EventArgs) Handles LimparTabelaBtn.Click
        If ServidorTabelaTxb.Text.Trim() = "" Or NomeConectarTabelaTxb.Text.Trim() = "" Or SenhaTabelaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        PesquisarTabelaBtn.Enabled = True
        ' Limpa o campo de pesquisa
        PesquisatabelaTxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListadeTabelaDtg.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        ListadeTabelaDtg.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        ConectarBtn.PerformClick()
    End Sub



    Private Sub MostrarColunasBtn_Click(sender As Object, e As EventArgs) Handles MostrarColunasBtn.Click
        If ServidorTabelaTxb.Text.Trim() = "" Or NomeConectarTabelaTxb.Text.Trim() = "" Or SenhaTabelaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If
        ' Captura o nome da tabela selecionada
        Dim nomeTabela As String = ListadeTabelaDtg.CurrentRow.Cells("Nome_da_Tabela").Value.ToString()

        Try
            ' Cria uma conexão com o banco de dados selecionado
            Using conexaoBD As New SqlConnection($"Server={ServidorTabelaTxb.Text};User Id={NomeConectarTabelaTxb.Text};Password={SenhaTabelaTxb.Text};Database={SelecionarBancoBbx.SelectedItem.ToString()}")
                ' Abre a conexão com o banco de dados
                conexaoBD.Open()

                ' Executa uma consulta SQL que retorna os nomes das colunas da tabela selecionada
                Dim comando As New SqlCommand($"SELECT COLUMN_NAME as Nome_da_Coluna FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{nomeTabela}'", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar os nomes das colunas da tabela selecionada
                Dim dt As New DataTable()
                dt.Load(leitor)

                ' Define as colunas apropriadas no DataGridView ListarColunaDvg
                ListarColunaDvg.AutoGenerateColumns = False
                ListarColunaDvg.Columns.Add("Nome_da_Coluna", "Nome da Coluna")
                ListarColunaDvg.Columns("Nome_da_Coluna").DataPropertyName = "Nome_da_Coluna"

                ' Popula o DataGridView com os nomes das colunas da tabela selecionada
                ListarColunaDvg.DataSource = dt
                ListarColunaDvg.Columns(0).Width = 200
                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar colunas: " & ex.Message)
        End Try
    End Sub

    Private Sub PesquisarColunaBtn_Click(sender As Object, e As EventArgs) Handles PesquisarColunaBtn.Click
        If ServidorTabelaTxb.Text.Trim() = "" Or NomeConectarTabelaTxb.Text.Trim() = "" Or SenhaTabelaTxb.Text.Trim() = "" Or ProcurarColunaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarColunaBtn.Enabled = False

        Dim searchTerm As String = ProcurarColunaTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListarColunaDvg.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Nome_da_Coluna") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Nome_da_Coluna", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Nome_da_Coluna LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} Coluna(s) encontrada.")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            ListarColunaDvg.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhuma Coluna encontrada.")
        End If
    End Sub

    Private Sub LimparColunaBtn_Click(sender As Object, e As EventArgs) Handles LimparColunaBtn.Click
        If ServidorTabelaTxb.Text.Trim() = "" Or NomeConectarTabelaTxb.Text.Trim() = "" Or SenhaTabelaTxb.Text.Trim() = "" Or ProcurarColunaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        PesquisarColunaBtn.Enabled = True
        ' Limpa o campo de pesquisa
        ProcurarColunaTxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListarColunaDvg.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        ListarColunaDvg.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        MostrarColunasBtn.PerformClick()
    End Sub

    Private Sub PesquisartodasBtn_Click(sender As Object, e As EventArgs) Handles PesquisartodasBtn.Click

        ' Verifica se o filtro não é vazio
        If Not String.IsNullOrEmpty(PesquisartodasTxb.Text) Then
            Try
                ' Cria uma conexão com o banco de dados selecionado
                Using conexaoBD As New SqlConnection($"Server={ServidorTabelaTxb.Text};User Id={NomeConectarTabelaTxb.Text};Password={SenhaTabelaTxb.Text};Database={SelecionarBancoBbx.SelectedItem.ToString()}")
                    ' Abre a conexão com o banco de dados
                    conexaoBD.Open()

                    ' Executa o comando SQL com o filtro de busca
                    Dim comando As New SqlCommand($"SELECT T.name AS Tabela, C.name AS Coluna FROM sys.sysobjects AS T (NOLOCK) INNER JOIN sys.all_columns AS C (NOLOCK) ON T.id = C.object_id AND T.XTYPE = 'U' WHERE C.NAME LIKE '%{PesquisartodasTxb.Text}%' ORDER BY T.name ASC", conexaoBD)
                    Dim leitor As SqlDataReader = comando.ExecuteReader()

                    ' Cria uma DataTable para armazenar os resultados da consulta
                    Dim dt As New DataTable()
                    dt.Load(leitor)

                    ' Define as colunas apropriadas no DataGridView ResultadoDgv
                    ListarTodasDgv.AutoGenerateColumns = False
                    ListarTodasDgv.Columns.Add("Tabela", "Tabela")
                    ListarTodasDgv.Columns("Tabela").DataPropertyName = "Tabela"
                    ListarTodasDgv.Columns.Add("Coluna", "Coluna")
                    ListarTodasDgv.Columns("Coluna").DataPropertyName = "Coluna"

                    ' Popula o DataGridView com os resultados da consulta
                    ListarTodasDgv.DataSource = dt

                    ' Fecha o leitor de dados
                    leitor.Close()
                End Using
            Catch ex As Exception
                ' Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao executar comando: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub LimparTodasBtn_Click(sender As Object, e As EventArgs) Handles LimparTodasBtn.Click
        ListarTodasDgv.DataSource = Nothing
        ListarTodasDgv.Columns.Clear()
        PesquisartodasTxb.Clear()

    End Sub

    Private Sub Tabela_Coluna_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
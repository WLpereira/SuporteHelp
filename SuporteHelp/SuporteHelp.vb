﻿Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs

Public Class SuporteHelp
    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTxb.Text
        Dim usuario As String = NomeConectarTxb.Text
        Dim senha As String = SenhaTxb.Text

        ' Cria uma string de conexão com o servidor de banco de dados
        Dim conexao As String = "Server=" & servidor & ";User Id=" & usuario & ";Password=" & senha

        Try
            ' Cria uma conexão com o servidor de banco de dados
            Using conexaoBD As New SqlConnection(conexao)
                ' Abre a conexão com o servidor
                conexaoBD.Open()

                ' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name FROM sys.databases", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar os resultados da consulta
                Dim dt As New DataTable()
                dt.Load(leitor)

                ' Popula o DataGridView com os nomes dos bancos de dados
                ListadeServidorDtg.DataSource = dt
                ListadeServidorDtg.Columns(0).Width = 200

                ' Fecha o leitor de dados
                leitor.Close()
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub PesquisarBtn_Click(sender As Object, e As EventArgs) Handles PesquisarBtn.Click
        Dim searchTerm As String = PesquisaTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListadeServidorDtg.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("name") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("name", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"name LIKE '%{searchTerm}%'"

        ' Verifica se foram encontradas linhas correspondentes à pesquisa
        If dt.DefaultView.Count > 0 Then
            MessageBox.Show($"{dt.DefaultView.Count} banco(s) de dados encontrado(s).")

            ' Exibe somente as linhas correspondentes ao filtro de pesquisa
            ListadeServidorDtg.DataSource = dt.DefaultView.ToTable()
        Else
            ' Exibe uma mensagem de erro caso nenhum banco de dados seja encontrado
            MessageBox.Show("Nenhum banco de dados encontrado.")
        End If
    End Sub

    Private Sub LimparBtn_Click(sender As Object, e As EventArgs) Handles LimparBtn.Click
        ' Limpa o campo de pesquisa
        PesquisaTxb.Text = ""

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListadeServidorDtg.DataSource, DataTable)

        ' Remove o filtro de pesquisa
        dt.DefaultView.RowFilter = ""

        ' Define o DataSource do DataGridView com o DataTable atualizado
        ListadeServidorDtg.DataSource = dt

        ' Chama o evento "Click" do botão "conectar"
        ConectarBtn.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ValidarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidarEmailToolStripMenuItem.Click
        Dim Validar_E_mail As New Validar_E_Mail()
        Validar_E_mail.Show()
    End Sub

    Private Sub CriptoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriptoToolStripMenuItem.Click
        Dim Cripto As New Cripto()
        Cripto.Show()
    End Sub



    Private Sub UsuarioSenhaBtn_Click(sender As Object, e As EventArgs) Handles UsuarioSenhaBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Obtenha o nome do banco de dados selecionado
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Crie uma string de conexão com base nas informações fornecidas pelo usuário
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = ServidorTxb.Text
            builder.UserID = NomeConectarTxb.Text
            builder.Password = SenhaTxb.Text
            builder.InitialCatalog = selectedDatabase
            builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
            Dim connectionString As String = builder.ConnectionString

            ' Conecte-se ao banco de dados
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Execute o comando SQL de atualização para o banco de dados selecionado e o nome de usuário da linha selecionada ou com o cursor sobre ela
                Dim commandText As String = $"UPDATE Usuario SET senha = 'UM6qev3j5m7C9asc' WHERE username = 'SA'"
                Dim command As New SqlCommand(commandText, connection)
                command.ExecuteNonQuery()

                ' Feche a conexão
                connection.Close()

                MessageBox.Show("Senha atualizada com sucesso!")
            End Using
        Else
            MessageBox.Show("Por favor, selecione uma linha do DataGridView.")
        End If
    End Sub

    Private Sub CloudBtn_Click(sender As Object, e As EventArgs) Handles CloudBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Chame o UserControl1 para fornecer usuário e senha
            Dim loginForm As New LoginDialog()
            If loginForm.ShowDialog() = DialogResult.OK Then
                ' Obtenha o nome do banco de dados selecionado
                Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

                ' Crie uma string de conexão com base nas informações fornecidas pelo usuário
                Dim builder As New SqlConnectionStringBuilder()
                builder.DataSource = ServidorTxb.Text
                builder.UserID = loginForm.UsernameTxb.Text
                builder.Password = loginForm.SenhaTxb.Text
                builder.InitialCatalog = selectedDatabase
                builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
                Dim connectionString As String = builder.ConnectionString

                ' Conecte-se ao banco de dados
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Execute o comando SQL de atualização para o banco de dados selecionado e o nome de usuário da linha selecionada ou com o cursor sobre ela
                    Dim commandText As String = "ALTER LOGIN [sa] WITH PASSWORD=N'dp'; GO"
                    Dim command As New SqlCommand(commandText, connection)
                    command.ExecuteNonQuery()

                    ' Feche a conexão
                    connection.Close()

                    MessageBox.Show("Senha atualizada com sucesso!")
                End Using
            End If
        Else
            MessageBox.Show("Por favor, selecione uma linha do DataGridView.")
        End If
    End Sub

    Private Sub HomologacaoBtn_Click(sender As Object, e As EventArgs) Handles HomologacaoBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Obtenha o nome do banco de dados selecionado
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Crie uma string de conexão com base nas informações fornecidas pelo usuário
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = ServidorTxb.Text
            builder.UserID = NomeConectarTxb.Text
            builder.Password = SenhaTxb.Text
            builder.InitialCatalog = selectedDatabase
            builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
            Dim connectionString As String = builder.ConnectionString

            ' Conecte-se ao banco de dados
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Execute o comando SQL de atualização para o banco de dados selecionado e o nome de usuário da linha selecionada ou com o cursor sobre ela
                Dim commandText As String = $"UPDATE prmnfe
                SET pathschemas         = 'C:\Symphony\Nfe\Schemas',
                    patherro            = 'C:\Symphony\Nfe\ERRO',
                    pathxml             = 'C:\Symphony\Nfe\XML',
                    pathxml_assinado    = 'C:\Symphony\Nfe\XML_Assinado',
                    pathxml_transmitido = 'C:\Symphony\Nfe\XML_Transmitido',
                    pathxml_processado  = 'C:\Symphony\Nfe\XML_Processado'
                
                
                
                UPDATE prmnfe
                SET wsconsultacadastrocontribuinte = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/cadconsultacadastro4.asmx',
                    wsstatusservico                = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx',
                    wsrecepcao                     = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeautorizacao4.asmx',
                    wsretrecepcao                  = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nferetautorizacao4.asmx',
                    wsconsultanfe                  = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeconsultaprotocolo4.asmx',
                    wsinutilizacaonfe              = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeinutilizacao4.asmx',
                    wsrecepcaoevento               = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nferecepcaoevento4.asmx',
                    wsconsultanfe_nfce             = N'https://homologacao.nfce.fazenda.sp.gov.br/ws/NFeConsultaProtocolo4.asmx';
                
                
                
                
                UPDATE prmnfe
                SET pathschemas                    = N'C:\Symphony\Nfe\Schemas',
                    patherro                       = N'C:\Symphony\Nfe\ERRO',
                    pathxml                        = N'C:\Symphony\Nfe\XML',
                    pathxml_assinado               = N'C:\Symphony\Nfe\XML_Assinado',
                    pathxml_transmitido            = N'C:\Symphony\Nfe\XML_Transmitido',
                    pathxml_processado             = N'C:\Symphony\Nfe\XML_processado',
                    wsconsultacadastrocontribuinte = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/cadconsultacadastro4.asmx',
                    wsstatusservico                = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx',
                    wsrecepcao                     = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeautorizacao4.asmx',
                    wsretrecepcao                  = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nferetautorizacao4.asmx',
                    wsconsultanfe                  = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeconsultaprotocolo4.asmx',
                    wscancelamentonfe              = N'',
                    wsinutilizacaonfe              = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeinutilizacao4.asmx',
                    wsrecepcaoevento               = N'https://homologacao.nfe.fazenda.sp.gov.br/ws/nferecepcaoevento4.asmx',
                    linkconsultanfe                = N'https://nfe.fazenda.sp.gov.br/nfeweb/services/nfeconsulta2.asmx',
                    tpambiente                     = N'2',
                    tpimpressaodanfe               = N'1';"
                Dim command As New SqlCommand(commandText, connection)
                command.ExecuteNonQuery()

                ' Feche a conexão
                connection.Close()

                MessageBox.Show("atualizado para homologação com sucesso!")
            End Using
        Else
            MessageBox.Show("Por favor, selecione uma linha do DataGridView.")
        End If
    End Sub

    Private Sub ModuloCheckBtn_Click(sender As Object, e As EventArgs) Handles ModuloCheckBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Obtenha o nome do banco de dados selecionado
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("name").Value.ToString()

            ' Crie uma string de conexão com base nas informações fornecidas pelo usuário
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = ServidorTxb.Text
            builder.UserID = NomeConectarTxb.Text
            builder.Password = SenhaTxb.Text
            builder.InitialCatalog = selectedDatabase
            builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
            Dim connectionString As String = builder.ConnectionString

            ' Conecte-se ao banco de dados
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Execute o comando SQL de atualização para o banco de dados selecionado e o nome de usuário da linha selecionada ou com o cursor sobre ela
                Dim commandText As String = $"delete Modulo_Check"
                Dim command As New SqlCommand(commandText, connection)
                command.ExecuteNonQuery()

                ' Feche a conexão
                connection.Close()

                MessageBox.Show("Deletado com sucesso!")
            End Using
        Else
            MessageBox.Show("Por favor, selecione uma linha do DataGridView.")
        End If
    End Sub
End Class


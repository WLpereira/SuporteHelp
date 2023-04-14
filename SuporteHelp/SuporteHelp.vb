Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs

Public Class SuporteHelp
    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTxb.Text
        Dim usuario As String = NomeConectarTxb.Text
        Dim senha As String = SenhaTxb.Text

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

                ' Exibe uma mensagem de sucesso ao conectar no servidor
                MessageBox.Show("Conexão estabelecida com sucesso, Selecione o Banco!")

                ' Executa uma consulta SQL que retorna todos os bancos de dados do servidor
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases", conexaoBD)
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

        If ServidorTxb.Text.Trim() = "" Or NomeConectarTxb.Text.Trim() = "" Or SenhaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        ' Desabilita o botão de pesquisa
        PesquisarBtn.Enabled = False

        Dim searchTerm As String = PesquisaTxb.Text.Trim()

        ' Obtém o DataTable associado ao DataGridView
        Dim dt As DataTable = DirectCast(ListadeServidorDtg.DataSource, DataTable)

        ' Verifica se a coluna "NomeBanco" já existe no DataTable
        If Not dt.Columns.Contains("Nome") Then
            ' Cria uma nova coluna "NomeBanco"
            dt.Columns.Add("Nome", GetType(String))

            ' Define o valor da nova coluna para cada linha do DataTable
            For Each row As DataRow In dt.Rows
                ' Aqui você pode definir o valor da coluna "NomeBanco" para cada linha,
                ' dependendo dos valores de outras colunas, por exemplo:
                ' row("NomeBanco") = row("Nome") & " (" & row("CodigoBanco") & ")"
            Next
        End If

        ' Define o filtro de pesquisa
        dt.DefaultView.RowFilter = $"Nome LIKE '%{searchTerm}%'"

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
        If ServidorTxb.Text.Trim() = "" Or NomeConectarTxb.Text.Trim() = "" Or SenhaTxb.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.")
            Return
        End If

        PesquisarBtn.Enabled = True
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
        Dim caminho As String = "\\172.16.1.100\usuario\Marcos Aurelio\Crypto.exe"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub



    Private Sub UsuarioSenhaBtn_Click(sender As Object, e As EventArgs) Handles UsuarioSenhaBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Obtenha o nome do banco de dados selecionado
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

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
        Dim BancosCloud As New BancosCloud()
        BancosCloud.Show()
    End Sub

    Private Sub HomologacaoBtn_Click(sender As Object, e As EventArgs) Handles HomologacaoBtn.Click
        ' Verifique se uma linha foi selecionada no DataGridView ou se o cursor está sobre uma linha
        If ListadeServidorDtg.CurrentRow IsNot Nothing Then
            ' Obtenha o nome do banco de dados selecionado
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

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
            Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

            ' Obtenha o valor da coluna de nome de usuário da linha selecionada ou com o cursor sobre ela
            Dim username As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()

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
                Dim commandText As String = $"TRUNCATE TABLE Modulo_Check;
                IF OBJECT_ID('[dbo].[temp_limpa_modulo_check]') IS NULL
                BEGIN
                EXEC ('CREATE TRIGGER [dbo].[temp_limpa_modulo_check]
                ON [dbo].[Modulo_Check]
                FOR INSERT, UPDATE
                AS
                 DELETE FROM modulo_check');
                END"
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

    Private Sub DDClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DDClientsToolStripMenuItem.Click
        Dim caminho As String = "\\172.16.1.100\usuario\Marcos Aurelio\DDClients.exe"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub

    Private Sub CloudCreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloudCreateUserToolStripMenuItem.Click
        Dim caminho As String = "\\172.16.1.100\usuario\Marcos Aurelio\CloudCreateUser\CreateUserCloud.exe"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub

    Private Sub PainelAvaliacoesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PainelAvaliacoesToolStripMenuItem.Click
        Dim caminho As String = "\\172.16.1.100\usuario\Marcos Aurelio\PainelAvaliacoes.exe"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub

    Private Sub HelpDeskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpDeskToolStripMenuItem.Click
        Dim caminho As String = "\\172.16.1.100\symphony\Install\pDpiHpd.exe"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim Packs As String = "\\172.16.1.100\suporte\SoftInst\dpSistemasWin"
        Process.Start("explorer.exe", Packs)
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click
        Dim caminho As String = "\\172.16.1.100\suporte\Support Services\Tools\Script\VBS\Logoff.vbs"

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
            MessageBox.Show("Desconectado")
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub
End Class


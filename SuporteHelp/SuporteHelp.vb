Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MahApps.Metro.Controls.Dialogs
Imports Newtonsoft.Json

Public Class SuporteHelp
    Public Class DadosConexao
        Public Property Servidor As String
        Public Property Usuario As String
        Public Property Senha As String
    End Class

    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarBtn.Click
        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorTxb.Text
        Dim usuario As String = NomeConectarTxb.Text
        Dim senha As String = SenhaTxb.Text

        ' Verifica se todos os campos foram preenchidos
        If String.IsNullOrEmpty(servidor) OrElse String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(senha) Then
            MessageBox.Show("Preencha todos os campos antes de conectar.")
            Return
        End If

        ' Verifica se o servidor informado não é um dos servidores bloqueados
        If servidor = "cloud.informo.com.br,9898" OrElse servidor = "cloud.informo.com.br,9586" Then
            MessageBox.Show("Por motivos de segurança, esses servidores não podem ser acessados.")
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
                Dim comando As New SqlCommand("SELECT name as 'Nome', create_date as 'Data' FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')order by name", conexaoBD)
                Dim leitor As SqlDataReader = comando.ExecuteReader()

                ' Cria uma DataTable para armazenar os resultados da consulta
                Dim dt As New DataTable()
                dt.Load(leitor)

                ' Popula o DataGridView com os nomes dos bancos de dados
                ListadeServidorDtg.DataSource = dt
                ListadeServidorDtg.Columns(0).Width = 200

                ' Fecha o leitor de dados
                leitor.Close()

                ' Verifica se os dados de conexão já foram salvos
                If Not ExisteConexaoSalva(servidor, usuario, senha) Then
                    ' Salva os dados de conexão em um arquivo de texto
                    SalvarDadosConexao(servidor, usuario, senha)

                    ' Adiciona o servidor ao ComboBox
                    ExibirServidorCbx.Items.Add(servidor)
                End If
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Function ExisteConexaoSalva(servidor As String, usuario As String, senha As String) As Boolean
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Verifica se alguma linha possui a mesma combinação de servidor, usuário e senha
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidor AndAlso dados(1) = usuario AndAlso dados(2) = senha Then
                    ' A combinação de servidor, usuário e senha já existe no arquivo de texto
                    Return True
                End If
            Next
        End If

        ' A combinação de servidor, usuário e senha não foi encontrada no arquivo de texto
        Return False
    End Function

    Private Sub SalvarDadosConexao(servidor As String, usuario As String, senha As String)
        ' Cria uma linha com os dados de conexão separados por vírgula
        Dim linha As String = servidor & "," & usuario & "," & senha

        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Adiciona a linha ao arquivo de texto, somente se a conexão for válida
        If ValidarConexao(servidor, usuario, senha) Then
            ' Verifica se a linha já existe no arquivo antes de adicioná-la
            If Not ExisteConexaoSalva(servidor, usuario, senha) Then
                File.AppendAllText(caminhoArquivo, linha & Environment.NewLine)
            End If
        End If
    End Sub

    Private Sub CarregarServidoresSalvos()
        ' Obtém o caminho completo do arquivo de texto dentro da pasta do programa
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")

        ' Verifica se o arquivo de dados de conexão existe
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Cria uma lista para armazenar os servidores salvos
            Dim listaServidores As New List(Of String)

            ' Popula a lista com os servidores salvos
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 Then
                    listaServidores.Add(dados(0)) ' Adiciona apenas o servidor à lista
                End If
            Next

            ' Popula o ComboBox com os servidores salvos
            ExibirServidorCbx.DataSource = listaServidores
        End If
    End Sub

    Private Function ValidarConexao(servidor As String, usuario As String, senha As String) As Boolean
        ' Implemente aqui a lógica de validação da conexão
        ' Retorne True se a conexão for válida, ou False caso contrário
        Return True ' Exemplo: sempre retorna True para fins de demonstração
    End Function

    Private Sub SuporteHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carrega os servidores salvos ao carregar o formulário
        CarregarServidoresSalvos()
    End Sub

    Private Sub ExibirServidorCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExibirServidorCbx.SelectedIndexChanged
        ' Obtém o servidor selecionado no ComboBox
        Dim servidorSelecionado As String = ExibirServidorCbx.SelectedItem.ToString()

        ' Verifica se o arquivo de dados de conexão existe
        Dim caminhoArquivo As String = Path.Combine(Application.StartupPath, "dados_conexao.txt")
        If File.Exists(caminhoArquivo) Then
            ' Lê todas as linhas do arquivo de texto
            Dim linhas As String() = File.ReadAllLines(caminhoArquivo)

            ' Percorre as linhas e procura pelo servidor selecionado
            For Each linha As String In linhas
                Dim dados As String() = linha.Split(","c)
                If dados.Length = 3 AndAlso dados(0) = servidorSelecionado Then
                    ' Preenche os campos com os valores correspondentes
                    ServidorTxb.Text = dados(0)
                    NomeConectarTxb.Text = dados(1)
                    SenhaTxb.Text = dados(2)
                    Exit For ' Interrompe o loop após encontrar os dados correspondentes
                End If
            Next
        End If
    End Sub

    Private Sub PesquisarBtn_Click(sender As Object, e As EventArgs) Handles PesquisarBtn.Click
        ' Verifica se o DataGridView está vazio
        If ListadeServidorDtg.Rows.Count = 0 Then
            MessageBox.Show("Não há bancos de dados para pesquisar.")
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
        ' Verifica se o DataGridView está vazio
        If ListadeServidorDtg.Rows.Count = 0 Then
            MessageBox.Show("Não há bancos de dados para limpar.")
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

    Private Sub SairHelpBtn_Click(sender As Object, e As EventArgs) Handles SairHelpBtn.Click
        Me.Close()
    End Sub

    Private Sub ValidarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidarEmailToolStripMenuItem.Click
        Dim Validar_E_mail As New Validar_E_Mail()
        Validar_E_mail.Show()
    End Sub

    Private Sub CriptoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriptoToolStripMenuItem.Click
        Dim caminho As String = Path.Combine(Application.StartupPath, "Crypto.exe")

        If System.IO.File.Exists(caminho) Then
            Dim psi As New ProcessStartInfo(caminho)
            psi.UseShellExecute = True
            Process.Start(psi)
        Else
            MessageBox.Show("Não foi possível encontrar o executável no caminho especificado.")
        End If
    End Sub



    Private Sub UsuarioSenhaBtn_Click(sender As Object, e As EventArgs) Handles UsuarioSenhaBtn.Click
        Try
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
        Catch ex As Exception
            ' Se ocorrer uma exceção, exiba uma mensagem de erro
            MessageBox.Show("Erro ao conectar ao banco de dados. Banco de dados do CLOUD, execute a primeira opção.")
        End Try
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

    Private Sub GerarRegbtn_Click(sender As Object, e As EventArgs) Handles GerarRegbtn.Click
        ' Verifica se foi selecionada uma célula na coluna "Nome"
        If ListadeServidorDtg.SelectedCells.Count = 0 OrElse ListadeServidorDtg.SelectedCells(0).OwningColumn.Name <> "Nome" Then
            MessageBox.Show("Selecione um banco na tabela antes de prosseguir.")
            Return
        End If

        ' Obtém o nome do banco selecionado na ListadeServidorDtg
        Dim nomeBanco As String = "SYM_" & ListadeServidorDtg.SelectedCells(0).Value.ToString().Substring(0, Math.Min(ListadeServidorDtg.SelectedCells(0).Value.ToString().Length, 25))

        ' Obtém o conteúdo do campo ServidorTxb
        Dim servidor As String = ServidorTxb.Text

        ' Define o conteúdo do arquivo .reg a ser gerado
        Dim regContent As String = "Windows Registry Editor Version 5.00" & vbCrLf & vbCrLf &
        "[HKEY_CURRENT_USER\Software\ODBC\ODBC.INI]" & vbCrLf & vbCrLf &
        "[HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ODBC Data Sources]" & vbCrLf &
        """" & nomeBanco & """=" & """SQL Server""" & vbCrLf & vbCrLf &
        "[HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ODBC File DSN]" & vbCrLf &
        """DefaultDSNDir""=""C:\\Program Files\\Common Files\\ODBC\\Data Sources""" & vbCrLf & vbCrLf &
        "[HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\" & nomeBanco & "]" & vbCrLf &
        """Driver""=""C:\\WINDOWS\\System32\\SQLSRV32.dll""" & vbCrLf &
        """Server""=""" & servidor & """" & vbCrLf &
        """Database""=""" & ListadeServidorDtg.SelectedCells(0).Value.ToString() & """" & vbCrLf &
        """LastUser""=""sa"""

        ' Define o caminho do arquivo .reg a ser salvo na área de trabalho
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim regFilePath As String = desktopPath & "\" & nomeBanco & ".reg"

        ' Salva o conteúdo do arquivo .reg no caminho definido
        System.IO.File.WriteAllText(regFilePath, regContent)

        ' Exibe mensagem de sucesso e limpa os campos
        MessageBox.Show("Arquivo .reg gerado com sucesso na área de trabalho.")

    End Sub

    Private Sub SugestaoBtn_Click(sender As Object, e As EventArgs) Handles SugestaoBtn.Click
        Dim sugestao As New Sugestao()
        sugestao.Show()
    End Sub

    Private Sub ValidarGtinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidarGtinToolStripMenuItem.Click

        Dim ValidarGtin As New ValidarGtin()
        ValidarGtin.Show()
    End Sub

    Private Sub ProcurarTabelaOuColunaNoBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcurarTabelaOuColunaNoBDToolStripMenuItem.Click
        Dim Tabela_Coluna As New Tabela_Coluna()
        Tabela_Coluna.Show()
    End Sub

    Private Sub SenhaTxb_TextChanged(sender As Object, e As EventArgs) Handles SenhaTxb.TextChanged

    End Sub

    Private Sub NomeConectarTxb_TextChanged(sender As Object, e As EventArgs) Handles NomeConectarTxb.TextChanged
    End Sub

    Private Sub ServidorTxb_TextChanged(sender As Object, e As EventArgs) Handles ServidorTxb.TextChanged
    End Sub

    Private Sub SenhaConectarLbl_Click(sender As Object, e As EventArgs) Handles SenhaConectarLbl.Click
    End Sub

    Private Sub UsuarioConectarLbl_Click(sender As Object, e As EventArgs) Handles UsuarioConectarLbl.Click
    End Sub

    Private Sub ServidorConectarLbl_Click(sender As Object, e As EventArgs) Handles ServidorConectarLbl.Click
    End Sub

    Private Sub DescriçãoDasColunasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescriçãoDasColunasToolStripMenuItem.Click
        Dim Descricao_Coluna As New Descricao_Coluna()
        Descricao_Coluna.Show()
    End Sub

    Private Sub VerificarInformaçõesDoBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarInformaçõesDoBancoToolStripMenuItem.Click
        Dim Informacao_do_banco As New Informação_do_banco()
        Informacao_do_banco.Show()
    End Sub

    Private Sub MostrarTamanhoBtn_Click(sender As Object, e As EventArgs) Handles MostrarTamanhoBtn.Click
        ' Verifica se o DataGridView está vazio
        If ListadeServidorDtg.Rows.Count = 0 Then
            MessageBox.Show("Necessario conectar no servidor.")
            Return
        End If
        'Dim selectedDatabase As String = ListadeServidorDtg.CurrentRow.Cells("Nome").Value.ToString()'

        ' String de conexão com o banco de dados. Substitua pelos seus próprios detalhes de conexão.
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = ServidorTxb.Text
        builder.UserID = NomeConectarTxb.Text
        builder.Password = SenhaTxb.Text
        'builder.InitialCatalog = selectedDatabase'
        builder.IntegratedSecurity = False ' desativa a autenticação integrada do Windows
        Dim connectionString As String = builder.ConnectionString

        ' Crie uma conexão com o banco de dados
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Abra a conexão
            connection.Open()

            ' Comando SQL para executar
            Dim sql As String = "
            DROP TABLE IF EXISTS #tmp
            CREATE TABLE #tmp
            (
                [database_name]     VARCHAR(MAX),
                [database_size]     VARCHAR(MAX),
                [unallocated space] VARCHAR(MAX),
                [reserved]          VARCHAR(MAX),
                [data]              VARCHAR(MAX),
                [index_size]        VARCHAR(MAX),
                [unused]            VARCHAR(MAX)
            );

            EXEC sys.sp_MSforeachdb 'USE [?]
            IF DB_NAME() NOT IN (''tempdb'', ''msdb'', ''model'', ''master'')
            BEGIN
                INSERT #tmp EXEC sp_spaceused @oneresultset = 1
            END'

            SELECT *,
                   IIF(CAST(CAST(REPLACE(database_size, ' MB', '') AS FLOAT) / 1000 AS DECIMAL(10, 2)) < 1.00
                       , CONCAT(CAST(REPLACE(database_size, ' MB', '') AS FLOAT), ' MB')
                       , CONCAT(CAST(CAST(REPLACE(database_size, ' MB', '') AS FLOAT) / 1000 AS DECIMAL(10, 2)), ' GB')
                       ) AS 'database_size'
            FROM #tmp
            ORDER BY TRY_CAST(REPLACE(database_size, ' MB', '') AS FLOAT) DESC
        "

            ' Crie um objeto SqlCommand
            Dim command As New SqlCommand(sql, connection)

            ' Defina o tempo limite da consulta para 0 (ilimitado)
            command.CommandTimeout = 0

            ' Crie um adaptador de dados para preencher um DataSet
            Dim adapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet()

            ' Preencha o DataSet com os resultados da consulta
            adapter.Fill(dataSet)

            ' Vincule o DataSet à sua DataGridView
            ListadeServidorDtg.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Erro ao executar o comando SQL: " & ex.Message)
        Finally
            ' Feche a conexão
            connection.Close()
        End Try

    End Sub
End Class


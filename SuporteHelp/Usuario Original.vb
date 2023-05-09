Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Usuario_Original

    Private Sub ConectarUsuarioBtn_Click(sender As Object, e As EventArgs) Handles ConectarUsuarioBtn.Click
        ' Desabilita o botão de pesquisa
        'ExecutarTodosUsuariosBtn.Enabled = False
        'SelecionarUsuarioCbx.Enabled = False
        'ExecutarUsuarioEspecificoBtn.Enabled = False

        ' Captura os valores digitados nos textboxes de servidor, usuário e senha
        Dim servidor As String = ServidorUsuarioTxb.Text
        Dim usuario As String = NomeusuarioTxb.Text
        Dim senha As String = SenhaUsusarioTxb.Text

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
                SelecionarBancoUsuarioBbx.DataSource = listaBancos
                ' Desabilita o botão de pesquisa
                ' ExecutarTodosUsuariosBtn.Enabled = False
                ' SelecionarUsuarioCbx.Enabled = False
                ' ExecutarUsuarioEspecificoBtn.Enabled = False
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar bancos de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ExecutarTodosUsuariosBtn_Click(sender As Object, e As EventArgs) Handles ExecutarTodosUsuariosBtn.Click

        ' Verifica se um banco de dados foi selecionado '
        If SelecionarBancoUsuarioBbx.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecione um banco de dados para atualizar.")
            Return
        End If

        Dim banco As String = SelecionarBancoUsuarioBbx.SelectedItem.ToString()
        Dim servidor As String = ServidorUsuarioTxb.Text
        Dim usuario As String = NomeusuarioTxb.Text
        Dim senha As String = SenhaUsusarioTxb.Text

        Dim connStr As String = $"Server={servidor};Database={banco};User Id={usuario};Password={senha};"
        Dim conexao As SqlConnection = New SqlConnection(connStr)

        ' Aqui você deve implementar a lógica para executar a consulta UPDATE '
        ' Substitua a consulta abaixo pela consulta real que você deseja executar '
        Dim consulta As String = "declare @usuario as nvarchar(30)
                declare @senha   as nvarchar(30)
                
                declare oCursor cursor
                
                for
                	select	username, 
                			senha 
                	  from	usuario
                
                open oCursor
                
                fetch next from oCursor into @usuario, @senha
                	
                	while @@fetch_status = 0
                		begin
                			print @usuario + ' - ' + @senha
                			exec sp_change_users_login 'Auto_Fix', @usuario, null, @senha
                	
                			fetch next from oCursor into @usuario, @senha
                		end
                close oCursor
                deallocate oCursor"
        Try
            conexao.Open()
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexao)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Atualização concluída com sucesso!")
        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar o banco de dados: {ex.Message}")
        Finally
            conexao.Close()
        End Try
    End Sub

End Class
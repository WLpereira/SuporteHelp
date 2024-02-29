Public Class Monitor_Servidor
    ' Variável de classe para armazenar a string de conexão
    Private connectionString As String = ""

    Private WithEvents timer As New Timer()

    ' Evento Load do formulário
    Private Sub Monitor_Servidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar o temporizador
        timer.Interval = 10000 ' 10000 milissegundos = 10 segundo
        timer.Enabled = False ' Iniciar o temporizador desativado
    End Sub

    ' Evento Click do botão Conectar
    Private Sub ConectarBtn_Click(sender As Object, e As EventArgs) Handles ConectarMonitorBtn.Click
        ' Verificar se o servidor está vazio
        If String.IsNullOrWhiteSpace(ServidorMonitorTxb.Text) Then
            MessageBox.Show("Por favor, insira o nome do servidor.")
            Return
        End If

        ' Verificar se o nome de usuário está vazio
        If String.IsNullOrWhiteSpace(NomeConectarMonitorTxb.Text) Then
            MessageBox.Show("Por favor, insira o nome de usuário.")
            Return
        End If

        ' Verificar se a senha está vazia
        If String.IsNullOrWhiteSpace(SenhaMonitorTxb.Text) Then
            MessageBox.Show("Por favor, insira a senha.")
            Return
        End If

        ' Criar a string de conexão
        connectionString = $"Server={ServidorMonitorTxb.Text};Database=master;User Id={NomeConectarMonitorTxb.Text};Password={SenhaMonitorTxb.Text};"

        Try
            ' Estabelecer a conexão com o servidor
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Executar a consulta inicial
                ExecutarConsulta(connection)

                ' Ativar o temporizador para repetir a consulta
                timer.Enabled = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar e consultar o banco de dados: " & ex.Message)
        End Try

        ' Habilitar ConectadoBtn
        ConectadoBtn.Visible = True

    End Sub

    ' Evento Tick do temporizador
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Verificar se o temporizador está ativado
        If timer.Enabled Then
            Try
                ' Conectar ao servidor e executar a consulta
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    ExecutarConsulta(connection)
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao consultar o banco de dados: " & ex.Message)
            End Try
        End If





    End Sub

    ' Método para executar a consulta
    Private Sub ExecutarConsulta(connection As SqlConnection)
        ' Consulta SQL para obter informações sobre as sessões ativas
        Dim commandText As String = "SELECT B.session_id Sessao, " &
                                "       D.name Banco, " &
                                "       B.login_name Usuario, " &
                                "       B.program_name App, " &
                                "       B.status Status, " &
                                "       B.host_name Maquina, " &
                                "       CASE " &
                                "           WHEN B.session_id = A.blocking_session_id THEN 'Sim' " &
                                "           ELSE 'Nao' " &
                                "       END AS Responsavel, " &
                                "       A.blocking_session_id Responsalvel, " &
                                "       F.transaction_begin_time Inicio, " &
                                "       A.wait_duration_ms Tempo_ms, " &
                                "       C.command Comando, " &
                                "       C.cpu_time CPU, " &
                                "       B.memory_usage MEM " &
                                "FROM sys.dm_exec_sessions B " &
                                "LEFT JOIN sys.dm_exec_requests C ON B.session_id = C.session_id " &
                                "LEFT JOIN sys.databases D ON C.database_id = D.database_id " &
                                "LEFT JOIN sys.dm_os_waiting_tasks A ON A.session_id = B.session_id " &
                                "LEFT JOIN SYS.dm_tran_session_transactions E ON A.session_id = E.session_id " &
                                "LEFT JOIN SYS.dm_tran_active_transactions F ON E.TRANSACTION_ID = F.TRANSACTION_ID " &
                                "WHERE b.session_id > 50 " &
                                "  AND b.session_id <> @@SPID " &
                                "GROUP BY B.session_id, " &
                                "         D.name, " &
                                "         B.login_name, " &
                                "         B.program_name, " &
                                "         B.status, " &
                                "         B.host_name, " &
                                "         F.transaction_begin_time, " &
                                "         CASE " &
                                "             WHEN A.session_id = A.blocking_session_id THEN 'Sim' " &
                                "             ELSE 'Nao' " &
                                "         END, " &
                                "         A.blocking_session_id, " &
                                "         A.wait_duration_ms, " &
                                "         C.command, " &
                                "         C.cpu_time, " &
                                "         B.memory_usage " &
                                "ORDER BY CASE WHEN A.blocking_session_id IS NOT NULL THEN 0 ELSE 1 END, " &
                                "         ISNULL(A.wait_duration_ms, 0) DESC, " &
                                "         CASE WHEN A.session_id = A.blocking_session_id THEN 'Sim' ELSE 'Nao' END DESC, " &
                                "         A.blocking_session_id, " &
                                "         b.session_id, " &
                                "         B.status"

        ' Criar o comando SQL
        Dim command As New SqlCommand(commandText, connection)

        ' Criar o adaptador de dados
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()

        ' Preencher o DataTable com os resultados da consulta
        adapter.Fill(dataTable)

        ' Definir a fonte de dados do DataGridView como o DataTable
        MonitorDtv.DataSource = dataTable
    End Sub

    Private Sub MatarProcessoBtn_Click(sender As Object, e As EventArgs) Handles MatarProcessoBtn.Click
        ' Verificar se há uma linha selecionada no DataGridView
        If MonitorDtv.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione uma sessão para encerrar.")
            Return
        End If

        ' Obter o ID da sessão selecionada
        Dim sessionID As Integer = CInt(MonitorDtv.SelectedRows(0).Cells("Sessao").Value)

        ' Construir o comando KILL
        Dim killCommand As String = $"KILL {sessionID}"

        ' Executar o comando KILL
        ExecutarComando(killCommand)
    End Sub

    '  Private Sub MatarBloqueadaBtn_Click(sender As Object, e As EventArgs) Handles MatarBloqueadaBtn.Click
    '      ' Iterar sobre as linhas do DataGridView para identificar sessões bloqueadas
    '      For Each row As DataGridViewRow In MonitorDtv.Rows
    '          If Not row.IsNewRow Then
    '              Dim responsavel As String = row.Cells("Responsavel").Value.ToString()
    '
    '              ' Se a sessão estiver bloqueada, matá-la
    '              If responsavel <> "" Then
    '                  Dim sessionID As Integer = CInt(row.Cells("Sessao").Value)
    '                  Dim killCommand As String = $"KILL {sessionID}"
    '                  ExecutarComando(killCommand)
    '              End If
    '          End If
    '      Next
    '  End Sub

    Private Sub ExecutarComando(commandText As String)
        Try
            ' Estabelecer a conexão com o servidor
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Criar o comando SQL
                Using command As New SqlCommand(commandText, connection)
                    ' Executar o comando
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Atualizar o DataGridView após matar o processo
            AtualizarMonitor()
        Catch ex As Exception
            MessageBox.Show("Erro ao executar o comando KILL: " & ex.Message)
        End Try
    End Sub

    Private Sub AtualizarMonitor()
        ' Re-executar a consulta para atualizar o DataGridView
        ExecutarConsulta(New SqlConnection(connectionString))
    End Sub

    Private Sub VerificarServidorBtn_Click(sender As Object, e As EventArgs) Handles VerificarServidorBtn.Click
        Dim bloqueioEncontrado As Boolean = False

        ' Verificar se há pelo menos uma linha no DataGridView
        If MonitorDtv.Rows.Count > 0 Then
            ' Verificar se a coluna BlockingSessionID existe
            If MonitorDtv.Columns.Contains("BlockingSessionID") Then
                ' Iterar sobre as linhas do DataGridView
                For Each row As DataGridViewRow In MonitorDtv.Rows
                    ' Verificar se a célula na coluna BlockingSessionID não está vazia e se o valor é diferente de zero
                    If Not row.IsNewRow AndAlso row.Cells("BlockingSessionID").Value IsNot Nothing AndAlso row.Cells("BlockingSessionID").Value.ToString() <> "0" Then
                        ' Se houver um bloqueio, definir a variável bloqueioEncontrado como True e sair do loop
                        bloqueioEncontrado = True
                        Exit For
                    End If
                Next
            End If
        End If

        ' Habilitar ou desabilitar os botões com base no resultado da verificação
        If bloqueioEncontrado Then
            ' Se houver um bloqueio, habilitar o botão ErroBtn e desabilitar o botão ServidorokBtn
            ErroBtn.Enabled = True
            ServidorokBtn.Enabled = False
        Else
            ' Se não houver bloqueio, habilitar o botão ServidorokBtn e desabilitar o botão ErroBtn
            ErroBtn.Enabled = False
            ServidorokBtn.Enabled = True
        End If
    End Sub
End Class
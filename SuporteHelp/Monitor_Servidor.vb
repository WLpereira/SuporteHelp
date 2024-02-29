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

            ' Habilitar 
            ConectadoBtn.Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar e consultar o banco de dados: " & ex.Message)
        End Try

        ' Chamar o método para verificar a coluna blocking_session_id Responsalvel
        VerificarColunaResponsavel()
    End Sub

    ' Método para verificar a coluna blocking_session_id Responsalvel
    Private Sub VerificarColunaResponsavel()
        ' Verificar se há linhas no DataGridView
        If MonitorDtv.Rows.Count > 0 Then
            ' Inicializar contadores para os valores da coluna
            Dim valorZeroCount As Integer = 0
            Dim valorNaoZeroCount As Integer = 0

            ' Percorrer todas as linhas do DataGridView
            For Each row As DataGridViewRow In MonitorDtv.Rows
                ' Verificar se a célula não é nula e se o valor da célula não é nulo
                If row.Cells("Responsalvel") IsNot Nothing AndAlso row.Cells("Responsalvel").Value IsNot Nothing Then
                    ' Obter o valor da coluna blocking_session_id Responsalvel da linha atual
                    Dim responsavelValue As String = row.Cells("Responsalvel").Value.ToString()

                    ' Verificar se o valor é diferente de zero ou vazio
                    If responsavelValue <> "0" AndAlso Not String.IsNullOrWhiteSpace(responsavelValue) Then
                        valorNaoZeroCount += 1
                    Else
                        valorZeroCount += 1
                    End If
                End If
            Next

            ' Habilitar ou desabilitar os botões com base no contador de valores
            If valorNaoZeroCount > 0 Then
                ErroBtn.Visible = True
                ServidorokBtn.Visible = False
            ElseIf valorZeroCount > 0 Then
                ErroBtn.Visible = False
                ServidorokBtn.Visible = True
            End If
        End If
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
        VerificarColunaResponsavel()
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

    Private Sub MatarBloqueadaBtn_Click(sender As Object, e As EventArgs) Handles MatarBloqueadaBtn.Click
        ' Iterar sobre as linhas do DataGridView para identificar sessões bloqueadas
        For Each row As DataGridViewRow In MonitorDtv.Rows
            If Not row.IsNewRow Then
                Dim blockingSessionID As Integer = If(row.Cells("Responsalvel").Value IsNot DBNull.Value, CInt(row.Cells("Responsalvel").Value), 0)

                ' Se o blocking_session_id for diferente de zero, matar o processo
                If blockingSessionID <> 0 Then
                    Dim sessionID As Integer = CInt(row.Cells("Sessao").Value)
                    Dim killCommand As String = $"KILL {sessionID}"
                    ExecutarComando(killCommand)
                End If
            End If
        Next
    End Sub

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

End Class
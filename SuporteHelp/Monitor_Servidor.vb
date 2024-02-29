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

    Private Sub InformacaoPbx_Click(sender As Object, e As EventArgs) Handles InformacaoPbx.Click
        Try
            Dim connectionString As String = "your_connection_string_here"

            ' Consulta SQL para obter as informações do servidor
            Dim commandText As String = "SELECT 'Servidor: ' + convert(nVARCHAR(100), SERVERPROPERTY('SERVERNAME')) + ' (' + " &
                                     "(SELECT top 1 local_net_address FROM sys.dm_exec_connections WHERE local_net_address IS NOT NULL) + ')' AS SERVIDOR , " &
                                     "'SO: ' + right(@@VERSION, len(@@VERSION) - charindex('WINDOWS', @@VERSION) +1) AS SO , " &
                                     "'SGBD: ' + left(@@VERSION, CHARINDEX(convert(nVARCHAR(100), SERVERPROPERTY('productversion')),@@VERSION) + LEN(convert(nVARCHAR(100), SERVERPROPERTY('productversion'))) + 5) AS SGBD , " &
                                     "'Edição: ' + convert(varchar(128), SERVERPROPERTY ('edition')) AS EDICAO , " &
                                     "'Atualização: ' + convert(varchar(128), SERVERPROPERTY ('productlevel')) AS ATT , " &
                                     "'Collation: ' + convert(varchar(128), serverproperty(N'collation')) AS COLLATION , " &
                                     "'Lingua: ' + @@LANGUAGE AS LINGUA , " &
                                     "'Tempo em execução: ' + " &
                                     "(SELECT CONVERT(VARCHAR(10), DATEDIFF(mi, crdate, getdate())/60/24) + ' dias ' + CONVERT(VARCHAR(10), ((DATEDIFF(mi, crdate, getdate())) - (DATEDIFF(mi, crdate, getdate())/60/24)*60*24)/60) + ' horas ' + CONVERT(VARCHAR(10), ((DATEDIFF(mi, crdate, getdate())) - (DATEDIFF(mi, crdate, getdate())/60/24)*60*24) - (((DATEDIFF(mi, crdate, getdate())) - (DATEDIFF(mi, crdate, getdate())/60/24)*60*24)/60)*60) + ' minutos' " &
                                     "FROM sysdatabases WHERE name = 'tempdb' AS TIMESERVICE , " &
                                     "'Local Padrão Arquivos: ' + convert(varchar(200), SERVERPROPERTY('InstanceDefaultDataPath')) AS LOCALPADRAO , " &
                                     "'Arquivo Dados: ' + " &
                                     "(SELECT TOP 1 physical_name FROM sys.database_files WHERE type_desc = 'ROWS') AS FILEDADOS , " &
                                     "'Arquivo LOG: ' + " &
                                     "(SELECT TOP 1 physical_name FROM sys.database_files WHERE type_desc = 'LOG') AS FILELOG , " &
                                     "(SELECT TOP 1 'Disco do Banco: ' + CONVERT (NVARCHAR(20), " &
                                     "CAST(CAST(VS.available_bytes AS DECIMAL(19, 2)) / 1024 / 1024 / 1024 AS DECIMAL(10, 2))) + 'GB livre de ' + CONVERT (NVARCHAR(20), " &
                                     "CAST(CAST(VS.total_bytes AS DECIMAL(19, 2)) / 1024 / 1024 / 1024 AS DECIMAL(10, 2))) + 'GB (' + CONVERT (NVARCHAR(20), " &
                                     "CAST((CAST(VS.available_bytes AS DECIMAL(19, 2)) / CAST(VS.total_bytes AS DECIMAL(19, 2)) * 100) AS DECIMAL(10, 2))) + '%) ' " &
                                     "FROM sys.master_files AS MF CROSS APPLY [sys].[dm_os_volume_stats](MF.database_id, MF.file_id) AS VS " &
                                     "WHERE CAST(VS.available_bytes AS DECIMAL(19, 2)) / CAST(VS.total_bytes AS DECIMAL(19, 2)) * 100 < 100 " &
                                     "AND LEFT(VS.volume_mount_point, 1) = " &
                                     "(SELECT TOP 1 LEFT(physical_name, 1) FROM sys.database_files WHERE type_desc = 'ROWS')) AS DISKMDF , " &
                                     "(SELECT TOP 1 CONVERT (NVARCHAR(20), " &
                                     "CAST((CAST(VS.available_bytes AS DECIMAL(19, 2)) / CAST(VS.total_bytes AS DECIMAL(19, 2)) * 100) AS DECIMAL(10, 2))) " &
                                     "FROM sys.master_files AS MF CROSS APPLY [sys].[dm_os_volume_stats](MF.database_id, MF.file_id) AS VS " &
                                     "WHERE CAST(VS.available_bytes AS DECIMAL(19, 2)) / CAST(VS.total_bytes AS DECIMAL(19, 2)) * 100 < 100 " &
                                     "AND LEFT(VS.volume_mount_point, 1) = " &
                                     "(SELECT TOP 1 LEFT(physical_name, 1) FROM sys.database_files WHERE type_desc = 'ROWS')) AS PERDISKMDF , " &
                                     "'Quantidade CPU: ' + " &
                                     "(SELECT TOP 1 CONVERT(VARCHAR(10), cpu_count) FROM sys.dm_os_sys_info) AS QTDCPU , " &
                                     "(SELECT cntr_Value AS User_Connection FROM sys.dm_os_performance_counters WHERE counter_name = 'User Connections') AS User_Connection , " &
                                     "(SELECT TOP(1) (SQLProcessUtilization + (100 - SystemIdle - SQLProcessUtilization)) AS CPU FROM " &
                                     "(SELECT record.value('(./Record/@id)[1]', 'int') AS record_id, record.value('(./Record/SchedulerMonitorEvent/SystemHealth/SystemIdle)[1]', 'int') AS [SystemIdle], " &
                                     "record.value('(./Record/SchedulerMonitorEvent/SystemHealth/ProcessUtilization)[1]', 'int') AS [SQLProcessUtilization], [timestamp] " &
                                     "FROM (SELECT [timestamp], CONVERT(XML, record) AS [record] FROM sys.dm_os_ring_buffers WHERE ring_buffer_type = N'RING_BUFFER_SCHEDULER_MONITOR' " &
                                     "AND record LIKE '%<SystemHealth>%') AS x) AS y) AS USOCPU , " &
                                     "(SELECT cntr_value FROM sys.dm_os_performance_counters WHERE counter_name = 'Page life expectancy' AND object_name like '%Buffer Manager%') AS PLE , " &
                                     "'Memória Fisica: ' + " &
                                     "(SELECT TOP 1 CONVERT(VARCHAR(100), physical_memory_kb/1024) FROM sys.dm_os_sys_info) + 'Mb' AS MEMFISICA , " &
                                     "'Memória Alocada SQL: ' + " &
                                     "(SELECT CONVERT(VARCHAR(100), committed_target_kb/1024) FROM sys.dm_os_sys_info) + 'Mb' AS MEMSQL , " &
                                     "(M.total_physical_memory_kb/1024) AS Total_OS_Memory_MB , " &
                                     "(M.available_physical_memory_kb/1024) AS Available_OS_Memory_MB , " &
                                     "100*PM.physical_memory_in_use_kb/1024/ " &
                                     "(SELECT TOP 1 physical_memory_kb/1024 FROM sys.dm_os_sys_info) AS PERCMEMSQL , " &
                                     "(PM.physical_memory_in_use_kb/1024) AS Memory_used_by_Sqlserver_MB , " &
                                     "PM.memory_utilization_percentage " &
                                     "FROM sys.dm_os_process_memory PM " &
                                     "CROSS JOIN sys.dm_os_sys_memory M"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim command As New SqlCommand(commandText, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Exibir os resultados em uma nova janela formatada
                    Dim informacoesForm As New InformacoesServidorForm()
                    informacoesForm.ServidorLbl.Text = reader("SERVIDOR").ToString()
                    informacoesForm.SOLbl.Text = reader("SO").ToString()
                    informacoesForm.SGBDLbl.Text = reader("SGBD").ToString()
                    ' Adicione mais linhas conforme necessário

                    informacoesForm.ShowDialog()
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao recuperar informações do servidor: " & ex.Message)
        End Try
    End Sub
End Class
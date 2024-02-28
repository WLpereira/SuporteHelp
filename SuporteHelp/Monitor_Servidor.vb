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
        ' Habilitar ServidorokBtn
        ServidorokBtn.Visible = True
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
        Dim commandText As String = "SELECT " &
                                    "    DB_NAME(r.database_id) AS DatabaseName, " &
                                    "    r.session_id AS SessionID, " &
                                    "    r.blocking_session_id AS BlockingSessionID, " &
                                    "    r.wait_type AS WaitType, " &
                                    "    r.wait_time AS WaitTime_ms, " &
                                    "    r.last_wait_type AS LastWaitType, " &
                                    "    r.command AS Command, " &
                                    "    t.text AS CommandText, " &
                                    "    r.status AS Status, " &
                                    "    r.cpu_time AS CPUTime_ms, " &
                                    "    r.total_elapsed_time AS TotalElapsedTime_ms " &
                                    "FROM " &
                                    "    sys.dm_exec_requests r " &
                                    "CROSS APPLY " &
                                    "    sys.dm_exec_sql_text(r.sql_handle) t " &
                                    "WHERE " &
                                    "    r.database_id > 4 " &
                                    "    AND r.session_id > 50 " &
                                    "    AND DB_NAME(r.database_id) IN (SELECT name FROM sys.databases WHERE state_desc = 'ONLINE');"

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
        Dim sessionID As Integer = CInt(MonitorDtv.SelectedRows(0).Cells("SessionID").Value)

        ' Construir o comando KILL
        Dim killCommand As String = $"KILL {sessionID}"

        ' Executar o comando KILL
        ExecutarComando(killCommand)
    End Sub

    Private Sub MatarBloqueadaBtn_Click(sender As Object, e As EventArgs) Handles MatarBloqueadaBtn.Click
        ' Iterar sobre as linhas do DataGridView para identificar sessões bloqueadas
        For Each row As DataGridViewRow In MonitorDtv.Rows
            If Not row.IsNewRow Then
                Dim blockingSessionID As Integer = If(row.Cells("BlockingSessionID").Value IsNot DBNull.Value, CInt(row.Cells("BlockingSessionID").Value), 0)

                ' Se a sessão estiver bloqueada (ID de sessão de bloqueio diferente de zero), matá-la
                If blockingSessionID <> 0 Then
                    Dim sessionID As Integer = CInt(row.Cells("SessionID").Value)
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
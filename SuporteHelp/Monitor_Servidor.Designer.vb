<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitor_Servidor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitor_Servidor))
        ConectarMonitorBtn = New Button()
        SenhaMonitorTxb = New TextBox()
        NomeConectarMonitorTxb = New TextBox()
        ServidorMonitorTxb = New TextBox()
        SenhaConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        ServidorConectarLbl = New Label()
        MonitorDtv = New DataGridView()
        MatarProcessoBtn = New Button()
        MatarBloqueadaBtn = New Button()
        ServidorokBtn = New Button()
        ErroBtn = New Button()
        ConectadoBtn = New Button()
        VerificarServidorBtn = New Button()
        PictureBox1 = New PictureBox()
        CType(MonitorDtv, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConectarMonitorBtn
        ' 
        ConectarMonitorBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarMonitorBtn.Image = CType(resources.GetObject("ConectarMonitorBtn.Image"), Image)
        ConectarMonitorBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarMonitorBtn.Location = New Point(884, 21)
        ConectarMonitorBtn.Name = "ConectarMonitorBtn"
        ConectarMonitorBtn.Size = New Size(135, 45)
        ConectarMonitorBtn.TabIndex = 38
        ConectarMonitorBtn.Text = "Conectar"
        ConectarMonitorBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarMonitorBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaMonitorTxb
        ' 
        SenhaMonitorTxb.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaMonitorTxb.Location = New Point(666, 38)
        SenhaMonitorTxb.Name = "SenhaMonitorTxb"
        SenhaMonitorTxb.Size = New Size(196, 27)
        SenhaMonitorTxb.TabIndex = 37
        ' 
        ' NomeConectarMonitorTxb
        ' 
        NomeConectarMonitorTxb.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        NomeConectarMonitorTxb.Location = New Point(391, 39)
        NomeConectarMonitorTxb.Name = "NomeConectarMonitorTxb"
        NomeConectarMonitorTxb.Size = New Size(244, 27)
        NomeConectarMonitorTxb.TabIndex = 36
        ' 
        ' ServidorMonitorTxb
        ' 
        ServidorMonitorTxb.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorMonitorTxb.Location = New Point(97, 38)
        ServidorMonitorTxb.Name = "ServidorMonitorTxb"
        ServidorMonitorTxb.Size = New Size(260, 27)
        ServidorMonitorTxb.TabIndex = 35
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.ForeColor = Color.Black
        SenhaConectarLbl.Location = New Point(666, 16)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(57, 21)
        SenhaConectarLbl.TabIndex = 34
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarLbl.ForeColor = Color.Black
        UsuarioConectarLbl.Location = New Point(391, 15)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(69, 21)
        UsuarioConectarLbl.TabIndex = 33
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarLbl.ForeColor = Color.Black
        ServidorConectarLbl.Location = New Point(97, 14)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(154, 21)
        ServidorConectarLbl.TabIndex = 32
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' MonitorDtv
        ' 
        MonitorDtv.BackgroundColor = SystemColors.MenuBar
        MonitorDtv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MonitorDtv.Location = New Point(12, 199)
        MonitorDtv.Name = "MonitorDtv"
        MonitorDtv.RowTemplate.Height = 25
        MonitorDtv.Size = New Size(1038, 481)
        MonitorDtv.TabIndex = 39
        ' 
        ' MatarProcessoBtn
        ' 
        MatarProcessoBtn.BackColor = Color.Yellow
        MatarProcessoBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        MatarProcessoBtn.Location = New Point(243, 124)
        MatarProcessoBtn.Name = "MatarProcessoBtn"
        MatarProcessoBtn.Size = New Size(196, 57)
        MatarProcessoBtn.TabIndex = 40
        MatarProcessoBtn.Text = "KILL Linha Selecionada"
        MatarProcessoBtn.UseVisualStyleBackColor = False
        ' 
        ' MatarBloqueadaBtn
        ' 
        MatarBloqueadaBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        MatarBloqueadaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        MatarBloqueadaBtn.ForeColor = Color.Black
        MatarBloqueadaBtn.Location = New Point(22, 124)
        MatarBloqueadaBtn.Name = "MatarBloqueadaBtn"
        MatarBloqueadaBtn.Size = New Size(196, 57)
        MatarBloqueadaBtn.TabIndex = 41
        MatarBloqueadaBtn.Text = "KILL Sessão Bloqueada"
        MatarBloqueadaBtn.UseVisualStyleBackColor = False
        ' 
        ' ServidorokBtn
        ' 
        ServidorokBtn.BackColor = Color.Lime
        ServidorokBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorokBtn.ForeColor = Color.Black
        ServidorokBtn.Location = New Point(662, 116)
        ServidorokBtn.Name = "ServidorokBtn"
        ServidorokBtn.Size = New Size(181, 77)
        ServidorokBtn.TabIndex = 42
        ServidorokBtn.Text = "            OK            SEM BLOQUEIOS"
        ServidorokBtn.UseVisualStyleBackColor = False
        ServidorokBtn.Visible = False
        ' 
        ' ErroBtn
        ' 
        ErroBtn.BackColor = Color.Red
        ErroBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ErroBtn.ForeColor = Color.White
        ErroBtn.Location = New Point(849, 116)
        ErroBtn.Name = "ErroBtn"
        ErroBtn.Size = New Size(181, 77)
        ErroBtn.TabIndex = 43
        ErroBtn.Text = "          ERRO            COM BLOQUEIOS"
        ErroBtn.UseVisualStyleBackColor = False
        ErroBtn.Visible = False
        ' 
        ' ConectadoBtn
        ' 
        ConectadoBtn.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ConectadoBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ConectadoBtn.ForeColor = Color.White
        ConectadoBtn.Location = New Point(398, 686)
        ConectadoBtn.Name = "ConectadoBtn"
        ConectadoBtn.Size = New Size(269, 51)
        ConectadoBtn.TabIndex = 44
        ConectadoBtn.Text = " CONECTADO"
        ConectadoBtn.UseVisualStyleBackColor = False
        ConectadoBtn.Visible = False
        ' 
        ' VerificarServidorBtn
        ' 
        VerificarServidorBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        VerificarServidorBtn.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        VerificarServidorBtn.Location = New Point(476, 124)
        VerificarServidorBtn.Name = "VerificarServidorBtn"
        VerificarServidorBtn.Size = New Size(163, 57)
        VerificarServidorBtn.TabIndex = 45
        VerificarServidorBtn.Text = "VERIFICAR STATUS"
        VerificarServidorBtn.UseVisualStyleBackColor = True
        VerificarServidorBtn.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 64)
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        ' 
        ' Monitor_Servidor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1062, 749)
        Controls.Add(PictureBox1)
        Controls.Add(VerificarServidorBtn)
        Controls.Add(ConectadoBtn)
        Controls.Add(ErroBtn)
        Controls.Add(ServidorokBtn)
        Controls.Add(MatarBloqueadaBtn)
        Controls.Add(MatarProcessoBtn)
        Controls.Add(MonitorDtv)
        Controls.Add(ConectarMonitorBtn)
        Controls.Add(SenhaMonitorTxb)
        Controls.Add(NomeConectarMonitorTxb)
        Controls.Add(ServidorMonitorTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioConectarLbl)
        Controls.Add(ServidorConectarLbl)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Monitor_Servidor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Monitor_Servidor"
        CType(MonitorDtv, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConectarMonitorBtn As Button
    Friend WithEvents SenhaMonitorTxb As TextBox
    Friend WithEvents NomeConectarMonitorTxb As TextBox
    Friend WithEvents ServidorMonitorTxb As TextBox
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents UsuarioConectarLbl As Label
    Friend WithEvents ServidorConectarLbl As Label
    Friend WithEvents MonitorDtv As DataGridView
    Friend WithEvents MatarProcessoBtn As Button
    Friend WithEvents MatarBloqueadaBtn As Button
    Friend WithEvents ServidorokBtn As Button
    Friend WithEvents ErroBtn As Button
    Friend WithEvents ConectadoBtn As Button
    Friend WithEvents VerificarServidorBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

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
        CType(MonitorDtv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConectarMonitorBtn
        ' 
        ConectarMonitorBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarMonitorBtn.Image = CType(resources.GetObject("ConectarMonitorBtn.Image"), Image)
        ConectarMonitorBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarMonitorBtn.Location = New Point(658, 23)
        ConectarMonitorBtn.Name = "ConectarMonitorBtn"
        ConectarMonitorBtn.Size = New Size(118, 38)
        ConectarMonitorBtn.TabIndex = 38
        ConectarMonitorBtn.Text = "Conectar"
        ConectarMonitorBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarMonitorBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaMonitorTxb
        ' 
        SenhaMonitorTxb.Location = New Point(449, 38)
        SenhaMonitorTxb.Name = "SenhaMonitorTxb"
        SenhaMonitorTxb.Size = New Size(179, 23)
        SenhaMonitorTxb.TabIndex = 37
        ' 
        ' NomeConectarMonitorTxb
        ' 
        NomeConectarMonitorTxb.Location = New Point(230, 38)
        NomeConectarMonitorTxb.Name = "NomeConectarMonitorTxb"
        NomeConectarMonitorTxb.Size = New Size(181, 23)
        NomeConectarMonitorTxb.TabIndex = 36
        ' 
        ' ServidorMonitorTxb
        ' 
        ServidorMonitorTxb.Location = New Point(12, 38)
        ServidorMonitorTxb.Name = "ServidorMonitorTxb"
        ServidorMonitorTxb.Size = New Size(172, 23)
        ServidorMonitorTxb.TabIndex = 35
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Location = New Point(449, 18)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(39, 15)
        SenhaConectarLbl.TabIndex = 34
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Location = New Point(230, 20)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(47, 15)
        UsuarioConectarLbl.TabIndex = 33
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Location = New Point(12, 20)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(105, 15)
        ServidorConectarLbl.TabIndex = 32
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' MonitorDtv
        ' 
        MonitorDtv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MonitorDtv.Location = New Point(64, 199)
        MonitorDtv.Name = "MonitorDtv"
        MonitorDtv.RowTemplate.Height = 25
        MonitorDtv.Size = New Size(941, 451)
        MonitorDtv.TabIndex = 39
        ' 
        ' MatarProcessoBtn
        ' 
        MatarProcessoBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        MatarProcessoBtn.Location = New Point(156, 122)
        MatarProcessoBtn.Name = "MatarProcessoBtn"
        MatarProcessoBtn.Size = New Size(156, 45)
        MatarProcessoBtn.TabIndex = 40
        MatarProcessoBtn.Text = "KILL"
        MatarProcessoBtn.UseVisualStyleBackColor = True
        ' 
        ' MatarBloqueadaBtn
        ' 
        MatarBloqueadaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        MatarBloqueadaBtn.Location = New Point(383, 122)
        MatarBloqueadaBtn.Name = "MatarBloqueadaBtn"
        MatarBloqueadaBtn.Size = New Size(196, 57)
        MatarBloqueadaBtn.TabIndex = 41
        MatarBloqueadaBtn.Text = "KILL Sessão Bloqueada"
        MatarBloqueadaBtn.UseVisualStyleBackColor = True
        ' 
        ' Monitor_Servidor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
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
        MaximizeBox = False
        Name = "Monitor_Servidor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Monitor_Servidor"
        CType(MonitorDtv, ComponentModel.ISupportInitialize).EndInit()
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ferramenta_Cloud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ferramenta_Cloud))
        ServidorCloudTxb = New TextBox()
        ServidorConectarLbl = New Label()
        SelecinarServidorLbl = New Label()
        ExibirServidorCloudCbx = New ComboBox()
        ConectarCloudBtn = New Button()
        SenhaCloudTxb = New TextBox()
        NomeConectarCloudTxb = New TextBox()
        SenhaConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        ListadeServidorCloudDtg = New DataGridView()
        MostrarTamanhoBtn = New Button()
        progressoPb = New ProgressBar()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        LogEventoBtn = New Button()
        LimparColunaCloudBtn = New Button()
        MenuStrip1 = New MenuStrip()
        CadastrosToolStripMenuItem = New ToolStripMenuItem()
        GerenciadorDePortaToolStripMenuItem = New ToolStripMenuItem()
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.Location = New Point(12, 70)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(281, 23)
        ServidorCloudTxb.TabIndex = 6
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarLbl.Location = New Point(12, 50)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(125, 17)
        ServidorConectarLbl.TabIndex = 5
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(12, 98)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(170, 17)
        SelecinarServidorLbl.TabIndex = 38
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorCloudCbx
        ' 
        ExibirServidorCloudCbx.FormattingEnabled = True
        ExibirServidorCloudCbx.Location = New Point(12, 116)
        ExibirServidorCloudCbx.Name = "ExibirServidorCloudCbx"
        ExibirServidorCloudCbx.Size = New Size(210, 23)
        ExibirServidorCloudCbx.TabIndex = 37
        ' 
        ' ConectarCloudBtn
        ' 
        ConectarCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarCloudBtn.Image = CType(resources.GetObject("ConectarCloudBtn.Image"), Image)
        ConectarCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarCloudBtn.Location = New Point(732, 55)
        ConectarCloudBtn.Name = "ConectarCloudBtn"
        ConectarCloudBtn.Size = New Size(118, 38)
        ConectarCloudBtn.TabIndex = 36
        ConectarCloudBtn.Text = "Conectar"
        ConectarCloudBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarCloudBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaCloudTxb
        ' 
        SenhaCloudTxb.Location = New Point(573, 70)
        SenhaCloudTxb.Name = "SenhaCloudTxb"
        SenhaCloudTxb.Size = New Size(146, 23)
        SenhaCloudTxb.TabIndex = 35
        ' 
        ' NomeConectarCloudTxb
        ' 
        NomeConectarCloudTxb.Location = New Point(299, 70)
        NomeConectarCloudTxb.Name = "NomeConectarCloudTxb"
        NomeConectarCloudTxb.Size = New Size(268, 23)
        NomeConectarCloudTxb.TabIndex = 34
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.Location = New Point(573, 50)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(45, 17)
        SenhaConectarLbl.TabIndex = 33
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarLbl.Location = New Point(299, 50)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(55, 17)
        UsuarioConectarLbl.TabIndex = 32
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ListadeServidorCloudDtg
        ' 
        ListadeServidorCloudDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeServidorCloudDtg.Location = New Point(271, 211)
        ListadeServidorCloudDtg.Name = "ListadeServidorCloudDtg"
        ListadeServidorCloudDtg.ReadOnly = True
        ListadeServidorCloudDtg.RowHeadersWidth = 51
        ListadeServidorCloudDtg.RowTemplate.Height = 25
        ListadeServidorCloudDtg.Size = New Size(746, 478)
        ListadeServidorCloudDtg.TabIndex = 39
        ' 
        ' MostrarTamanhoBtn
        ' 
        MostrarTamanhoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarTamanhoBtn.ForeColor = Color.Red
        MostrarTamanhoBtn.Location = New Point(38, 352)
        MostrarTamanhoBtn.Name = "MostrarTamanhoBtn"
        MostrarTamanhoBtn.Size = New Size(184, 48)
        MostrarTamanhoBtn.TabIndex = 42
        MostrarTamanhoBtn.Text = "Tamanho dos Bancos, Consulta Demorada"
        MostrarTamanhoBtn.UseVisualStyleBackColor = True
        ' 
        ' progressoPb
        ' 
        progressoPb.Location = New Point(38, 406)
        progressoPb.Name = "progressoPb"
        progressoPb.Size = New Size(184, 23)
        progressoPb.TabIndex = 43
        progressoPb.Visible = False
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerReportsProgress = True
        ' 
        ' LogEventoBtn
        ' 
        LogEventoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LogEventoBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LogEventoBtn.Location = New Point(38, 263)
        LogEventoBtn.Name = "LogEventoBtn"
        LogEventoBtn.Size = New Size(184, 48)
        LogEventoBtn.TabIndex = 44
        LogEventoBtn.Text = "Verificar Tamanho da LogEvento, LogAcessoSym"
        LogEventoBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparColunaCloudBtn
        ' 
        LimparColunaCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparColunaCloudBtn.Image = CType(resources.GetObject("LimparColunaCloudBtn.Image"), Image)
        LimparColunaCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparColunaCloudBtn.Location = New Point(916, 703)
        LimparColunaCloudBtn.Name = "LimparColunaCloudBtn"
        LimparColunaCloudBtn.Size = New Size(101, 34)
        LimparColunaCloudBtn.TabIndex = 45
        LimparColunaCloudBtn.Text = "Limpar"
        LimparColunaCloudBtn.TextAlign = ContentAlignment.MiddleRight
        LimparColunaCloudBtn.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CadastrosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 24)
        MenuStrip1.TabIndex = 46
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CadastrosToolStripMenuItem
        ' 
        CadastrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GerenciadorDePortaToolStripMenuItem})
        CadastrosToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        CadastrosToolStripMenuItem.Size = New Size(72, 20)
        CadastrosToolStripMenuItem.Text = "Cadastros"
        ' 
        ' GerenciadorDePortaToolStripMenuItem
        ' 
        GerenciadorDePortaToolStripMenuItem.Name = "GerenciadorDePortaToolStripMenuItem"
        GerenciadorDePortaToolStripMenuItem.Size = New Size(193, 22)
        GerenciadorDePortaToolStripMenuItem.Text = "Gerenciador de Porta"
        ' 
        ' Ferramenta_Cloud
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
        Controls.Add(LimparColunaCloudBtn)
        Controls.Add(LogEventoBtn)
        Controls.Add(progressoPb)
        Controls.Add(MostrarTamanhoBtn)
        Controls.Add(ListadeServidorCloudDtg)
        Controls.Add(SelecinarServidorLbl)
        Controls.Add(ExibirServidorCloudCbx)
        Controls.Add(ConectarCloudBtn)
        Controls.Add(SenhaCloudTxb)
        Controls.Add(NomeConectarCloudTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioConectarLbl)
        Controls.Add(ServidorCloudTxb)
        Controls.Add(ServidorConectarLbl)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Ferramenta_Cloud"
        Text = "Ferramenta_Cloud"
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ServidorCloudTxb As TextBox
    Friend WithEvents ServidorConectarLbl As Label
    Friend WithEvents SelecinarServidorLbl As Label
    Friend WithEvents ExibirServidorCloudCbx As ComboBox
    Friend WithEvents ConectarCloudBtn As Button
    Friend WithEvents SenhaCloudTxb As TextBox
    Friend WithEvents NomeConectarCloudTxb As TextBox
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents UsuarioConectarLbl As Label
    Friend WithEvents ListadeServidorCloudDtg As DataGridView
    Friend WithEvents MostrarTamanhoBtn As Button
    Friend WithEvents progressoPb As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LogEventoBtn As Button
    Friend WithEvents LimparColunaCloudBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciadorDePortaToolStripMenuItem As ToolStripMenuItem
End Class

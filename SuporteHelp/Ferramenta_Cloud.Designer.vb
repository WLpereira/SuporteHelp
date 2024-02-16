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
        SelecionarPortaCbx = New ComboBox()
        SelecionePortaLbl = New Label()
        SelecionarPortaBtn = New Button()
        CarregarListaBtn = New Button()
        ServidorCloud2Txb = New TextBox()
        ServidorCloud3Txb = New TextBox()
        Servidor2Lbl = New Label()
        Servidor3Lbl = New Label()
        HabilitarServidor2Cbx = New CheckBox()
        HabilitarServidor3Cbx = New CheckBox()
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.Location = New Point(182, 58)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(281, 23)
        ServidorCloudTxb.TabIndex = 6
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarLbl.Location = New Point(182, 38)
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
        SelecinarServidorLbl.Location = New Point(12, 206)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(170, 17)
        SelecinarServidorLbl.TabIndex = 38
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorCloudCbx
        ' 
        ExibirServidorCloudCbx.FormattingEnabled = True
        ExibirServidorCloudCbx.Location = New Point(12, 224)
        ExibirServidorCloudCbx.Name = "ExibirServidorCloudCbx"
        ExibirServidorCloudCbx.Size = New Size(210, 23)
        ExibirServidorCloudCbx.TabIndex = 37
        ' 
        ' ConectarCloudBtn
        ' 
        ConectarCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarCloudBtn.Image = CType(resources.GetObject("ConectarCloudBtn.Image"), Image)
        ConectarCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarCloudBtn.Location = New Point(902, 43)
        ConectarCloudBtn.Name = "ConectarCloudBtn"
        ConectarCloudBtn.Size = New Size(118, 38)
        ConectarCloudBtn.TabIndex = 36
        ConectarCloudBtn.Text = "Conectar"
        ConectarCloudBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarCloudBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaCloudTxb
        ' 
        SenhaCloudTxb.Location = New Point(743, 58)
        SenhaCloudTxb.Name = "SenhaCloudTxb"
        SenhaCloudTxb.Size = New Size(146, 23)
        SenhaCloudTxb.TabIndex = 35
        ' 
        ' NomeConectarCloudTxb
        ' 
        NomeConectarCloudTxb.Location = New Point(469, 58)
        NomeConectarCloudTxb.Name = "NomeConectarCloudTxb"
        NomeConectarCloudTxb.Size = New Size(268, 23)
        NomeConectarCloudTxb.TabIndex = 34
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.Location = New Point(743, 38)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(45, 17)
        SenhaConectarLbl.TabIndex = 33
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarLbl.Location = New Point(469, 38)
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
        MostrarTamanhoBtn.Location = New Point(38, 610)
        MostrarTamanhoBtn.Name = "MostrarTamanhoBtn"
        MostrarTamanhoBtn.Size = New Size(184, 48)
        MostrarTamanhoBtn.TabIndex = 42
        MostrarTamanhoBtn.Text = "Tamanho dos Bancos, Consulta Demorada"
        MostrarTamanhoBtn.UseVisualStyleBackColor = True
        ' 
        ' progressoPb
        ' 
        progressoPb.Location = New Point(38, 664)
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
        LogEventoBtn.Location = New Point(38, 521)
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
        ' SelecionarPortaCbx
        ' 
        SelecionarPortaCbx.FormattingEnabled = True
        SelecionarPortaCbx.Location = New Point(27, 373)
        SelecionarPortaCbx.Name = "SelecionarPortaCbx"
        SelecionarPortaCbx.Size = New Size(210, 23)
        SelecionarPortaCbx.TabIndex = 47
        ' 
        ' SelecionePortaLbl
        ' 
        SelecionePortaLbl.AutoSize = True
        SelecionePortaLbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionePortaLbl.ForeColor = Color.Red
        SelecionePortaLbl.Location = New Point(71, 346)
        SelecionePortaLbl.Name = "SelecionePortaLbl"
        SelecionePortaLbl.Size = New Size(122, 20)
        SelecionePortaLbl.TabIndex = 48
        SelecionePortaLbl.Text = "Selecionar Porta"
        ' 
        ' SelecionarPortaBtn
        ' 
        SelecionarPortaBtn.BackColor = Color.Gold
        SelecionarPortaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarPortaBtn.Location = New Point(38, 413)
        SelecionarPortaBtn.Name = "SelecionarPortaBtn"
        SelecionarPortaBtn.Size = New Size(184, 48)
        SelecionarPortaBtn.TabIndex = 49
        SelecionarPortaBtn.Text = "Selecionar Portas"
        SelecionarPortaBtn.UseVisualStyleBackColor = False
        ' 
        ' CarregarListaBtn
        ' 
        CarregarListaBtn.BackColor = SystemColors.InfoText
        CarregarListaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarListaBtn.ForeColor = Color.Linen
        CarregarListaBtn.Location = New Point(38, 294)
        CarregarListaBtn.Name = "CarregarListaBtn"
        CarregarListaBtn.Size = New Size(184, 45)
        CarregarListaBtn.TabIndex = 50
        CarregarListaBtn.Text = "Carregar Portas"
        CarregarListaBtn.UseVisualStyleBackColor = False
        ' 
        ' ServidorCloud2Txb
        ' 
        ServidorCloud2Txb.Location = New Point(182, 108)
        ServidorCloud2Txb.Name = "ServidorCloud2Txb"
        ServidorCloud2Txb.Size = New Size(281, 23)
        ServidorCloud2Txb.TabIndex = 51
        ' 
        ' ServidorCloud3Txb
        ' 
        ServidorCloud3Txb.Location = New Point(182, 158)
        ServidorCloud3Txb.Name = "ServidorCloud3Txb"
        ServidorCloud3Txb.Size = New Size(281, 23)
        ServidorCloud3Txb.TabIndex = 52
        ' 
        ' Servidor2Lbl
        ' 
        Servidor2Lbl.AutoSize = True
        Servidor2Lbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Servidor2Lbl.ForeColor = Color.Blue
        Servidor2Lbl.Location = New Point(182, 88)
        Servidor2Lbl.Name = "Servidor2Lbl"
        Servidor2Lbl.Size = New Size(136, 17)
        Servidor2Lbl.TabIndex = 53
        Servidor2Lbl.Text = "Informe o Servidor 2"
        ' 
        ' Servidor3Lbl
        ' 
        Servidor3Lbl.AutoSize = True
        Servidor3Lbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Servidor3Lbl.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Servidor3Lbl.Location = New Point(182, 138)
        Servidor3Lbl.Name = "Servidor3Lbl"
        Servidor3Lbl.Size = New Size(136, 17)
        Servidor3Lbl.TabIndex = 54
        Servidor3Lbl.Text = "Informe o Servidor 3"
        ' 
        ' HabilitarServidor2Cbx
        ' 
        HabilitarServidor2Cbx.AutoSize = True
        HabilitarServidor2Cbx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        HabilitarServidor2Cbx.Location = New Point(487, 110)
        HabilitarServidor2Cbx.Name = "HabilitarServidor2Cbx"
        HabilitarServidor2Cbx.Size = New Size(148, 21)
        HabilitarServidor2Cbx.TabIndex = 55
        HabilitarServidor2Cbx.Text = "Habilitar Servidor 2"
        HabilitarServidor2Cbx.UseVisualStyleBackColor = True
        ' 
        ' HabilitarServidor3Cbx
        ' 
        HabilitarServidor3Cbx.AutoSize = True
        HabilitarServidor3Cbx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        HabilitarServidor3Cbx.Location = New Point(487, 160)
        HabilitarServidor3Cbx.Name = "HabilitarServidor3Cbx"
        HabilitarServidor3Cbx.Size = New Size(148, 21)
        HabilitarServidor3Cbx.TabIndex = 56
        HabilitarServidor3Cbx.Text = "Habilitar Servidor 3"
        HabilitarServidor3Cbx.UseVisualStyleBackColor = True
        ' 
        ' Ferramenta_Cloud
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
        Controls.Add(HabilitarServidor3Cbx)
        Controls.Add(HabilitarServidor2Cbx)
        Controls.Add(Servidor3Lbl)
        Controls.Add(Servidor2Lbl)
        Controls.Add(ServidorCloud3Txb)
        Controls.Add(ServidorCloud2Txb)
        Controls.Add(CarregarListaBtn)
        Controls.Add(SelecionarPortaBtn)
        Controls.Add(SelecionePortaLbl)
        Controls.Add(SelecionarPortaCbx)
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
    Friend WithEvents SelecionarPortaCbx As ComboBox
    Friend WithEvents SelecionePortaLbl As Label
    Friend WithEvents SelecionarPortaBtn As Button
    Friend WithEvents CarregarListaBtn As Button
    Friend WithEvents ServidorCloud2Txb As TextBox
    Friend WithEvents ServidorCloud3Txb As TextBox
    Friend WithEvents Servidor2Lbl As Label
    Friend WithEvents Servidor3Lbl As Label
    Friend WithEvents HabilitarServidor2Cbx As CheckBox
    Friend WithEvents HabilitarServidor3Cbx As CheckBox
End Class

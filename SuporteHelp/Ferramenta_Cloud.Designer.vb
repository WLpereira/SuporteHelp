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
        RARToolStripMenuItem = New ToolStripMenuItem()
        InformaçõesDasEmpresasToolStripMenuItem = New ToolStripMenuItem()
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
        PictureBox1 = New PictureBox()
        TotalLogEventoBtn = New Button()
        MediaLogEventoBtn = New Button()
        MediaLogAcessoSymBtn = New Button()
        TotalLogAcessoSymBtn = New Button()
        SHRINKBtn = New Button()
        VerificarDBABtn = New Button()
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ServidorConectarLbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarLbl.ForeColor = SystemColors.ActiveCaptionText
        ServidorConectarLbl.Location = New Point(179, 36)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(146, 20)
        ServidorConectarLbl.TabIndex = 5
        ServidorConectarLbl.Text = "Informe o Servidor "
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(822, 108)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(212, 21)
        SelecinarServidorLbl.TabIndex = 38
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorCloudCbx
        ' 
        ExibirServidorCloudCbx.FormattingEnabled = True
        ExibirServidorCloudCbx.Location = New Point(822, 132)
        ExibirServidorCloudCbx.Name = "ExibirServidorCloudCbx"
        ExibirServidorCloudCbx.Size = New Size(210, 23)
        ExibirServidorCloudCbx.TabIndex = 37
        ' 
        ' ConectarCloudBtn
        ' 
        ConectarCloudBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarCloudBtn.Image = CType(resources.GetObject("ConectarCloudBtn.Image"), Image)
        ConectarCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarCloudBtn.Location = New Point(895, 38)
        ConectarCloudBtn.Name = "ConectarCloudBtn"
        ConectarCloudBtn.Size = New Size(137, 59)
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
        SenhaConectarLbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.ForeColor = Color.Black
        SenhaConectarLbl.Location = New Point(741, 37)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(51, 20)
        SenhaConectarLbl.TabIndex = 33
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarLbl.ForeColor = Color.Black
        UsuarioConectarLbl.Location = New Point(466, 36)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(63, 20)
        UsuarioConectarLbl.TabIndex = 32
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ListadeServidorCloudDtg
        ' 
        ListadeServidorCloudDtg.BackgroundColor = SystemColors.Control
        ListadeServidorCloudDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeServidorCloudDtg.Location = New Point(222, 211)
        ListadeServidorCloudDtg.Name = "ListadeServidorCloudDtg"
        ListadeServidorCloudDtg.ReadOnly = True
        ListadeServidorCloudDtg.RowHeadersWidth = 51
        ListadeServidorCloudDtg.RowTemplate.Height = 25
        ListadeServidorCloudDtg.Size = New Size(810, 478)
        ListadeServidorCloudDtg.TabIndex = 39
        ' 
        ' MostrarTamanhoBtn
        ' 
        MostrarTamanhoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarTamanhoBtn.ForeColor = Color.Red
        MostrarTamanhoBtn.Location = New Point(17, 656)
        MostrarTamanhoBtn.Name = "MostrarTamanhoBtn"
        MostrarTamanhoBtn.Size = New Size(184, 48)
        MostrarTamanhoBtn.TabIndex = 42
        MostrarTamanhoBtn.Text = "Tamanho dos Bancos, Consulta Demorada"
        MostrarTamanhoBtn.UseVisualStyleBackColor = True
        ' 
        ' progressoPb
        ' 
        progressoPb.Location = New Point(17, 710)
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
        LogEventoBtn.Location = New Point(17, 559)
        LogEventoBtn.Name = "LogEventoBtn"
        LogEventoBtn.Size = New Size(184, 56)
        LogEventoBtn.TabIndex = 44
        LogEventoBtn.Text = "Verificar Tamanho da LogEvento, LogAcessoSym"
        LogEventoBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparColunaCloudBtn
        ' 
        LimparColunaCloudBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LimparColunaCloudBtn.Image = CType(resources.GetObject("LimparColunaCloudBtn.Image"), Image)
        LimparColunaCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparColunaCloudBtn.Location = New Point(929, 695)
        LimparColunaCloudBtn.Name = "LimparColunaCloudBtn"
        LimparColunaCloudBtn.Size = New Size(103, 52)
        LimparColunaCloudBtn.TabIndex = 45
        LimparColunaCloudBtn.Text = "Limpar"
        LimparColunaCloudBtn.TextAlign = ContentAlignment.MiddleRight
        LimparColunaCloudBtn.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CadastrosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 29)
        MenuStrip1.TabIndex = 46
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CadastrosToolStripMenuItem
        ' 
        CadastrosToolStripMenuItem.BackColor = Color.Yellow
        CadastrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GerenciadorDePortaToolStripMenuItem, RARToolStripMenuItem, InformaçõesDasEmpresasToolStripMenuItem})
        CadastrosToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), Image)
        CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        CadastrosToolStripMenuItem.Size = New Size(151, 25)
        CadastrosToolStripMenuItem.Text = "FERRAMENTAS"
        ' 
        ' GerenciadorDePortaToolStripMenuItem
        ' 
        GerenciadorDePortaToolStripMenuItem.Image = CType(resources.GetObject("GerenciadorDePortaToolStripMenuItem.Image"), Image)
        GerenciadorDePortaToolStripMenuItem.Name = "GerenciadorDePortaToolStripMenuItem"
        GerenciadorDePortaToolStripMenuItem.Size = New Size(281, 26)
        GerenciadorDePortaToolStripMenuItem.Text = "Gerenciador de Porta"
        ' 
        ' RARToolStripMenuItem
        ' 
        RARToolStripMenuItem.Image = CType(resources.GetObject("RARToolStripMenuItem.Image"), Image)
        RARToolStripMenuItem.Name = "RARToolStripMenuItem"
        RARToolStripMenuItem.Size = New Size(281, 26)
        RARToolStripMenuItem.Text = "#RAR"
        ' 
        ' InformaçõesDasEmpresasToolStripMenuItem
        ' 
        InformaçõesDasEmpresasToolStripMenuItem.Image = CType(resources.GetObject("InformaçõesDasEmpresasToolStripMenuItem.Image"), Image)
        InformaçõesDasEmpresasToolStripMenuItem.Name = "InformaçõesDasEmpresasToolStripMenuItem"
        InformaçõesDasEmpresasToolStripMenuItem.Size = New Size(281, 26)
        InformaçõesDasEmpresasToolStripMenuItem.Text = "Informações das Empresas"
        ' 
        ' SelecionarPortaCbx
        ' 
        SelecionarPortaCbx.FormattingEnabled = True
        SelecionarPortaCbx.Location = New Point(6, 304)
        SelecionarPortaCbx.Name = "SelecionarPortaCbx"
        SelecionarPortaCbx.Size = New Size(210, 23)
        SelecionarPortaCbx.TabIndex = 47
        ' 
        ' SelecionePortaLbl
        ' 
        SelecionePortaLbl.AutoSize = True
        SelecionePortaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionePortaLbl.ForeColor = Color.Red
        SelecionePortaLbl.Location = New Point(42, 277)
        SelecionePortaLbl.Name = "SelecionePortaLbl"
        SelecionePortaLbl.Size = New Size(135, 21)
        SelecionePortaLbl.TabIndex = 48
        SelecionePortaLbl.Text = "Selecionar Porta"
        ' 
        ' SelecionarPortaBtn
        ' 
        SelecionarPortaBtn.BackColor = Color.Gold
        SelecionarPortaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarPortaBtn.Location = New Point(17, 340)
        SelecionarPortaBtn.Name = "SelecionarPortaBtn"
        SelecionarPortaBtn.Size = New Size(184, 59)
        SelecionarPortaBtn.TabIndex = 49
        SelecionarPortaBtn.Text = "Selecionar Portas"
        SelecionarPortaBtn.UseVisualStyleBackColor = False
        ' 
        ' CarregarListaBtn
        ' 
        CarregarListaBtn.BackColor = SystemColors.InfoText
        CarregarListaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarListaBtn.ForeColor = Color.Linen
        CarregarListaBtn.Location = New Point(17, 211)
        CarregarListaBtn.Name = "CarregarListaBtn"
        CarregarListaBtn.Size = New Size(184, 59)
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
        ServidorCloud2Txb.Visible = False
        ' 
        ' ServidorCloud3Txb
        ' 
        ServidorCloud3Txb.Location = New Point(182, 158)
        ServidorCloud3Txb.Name = "ServidorCloud3Txb"
        ServidorCloud3Txb.Size = New Size(281, 23)
        ServidorCloud3Txb.TabIndex = 52
        ServidorCloud3Txb.Visible = False
        ' 
        ' Servidor2Lbl
        ' 
        Servidor2Lbl.AutoSize = True
        Servidor2Lbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Servidor2Lbl.ForeColor = Color.Navy
        Servidor2Lbl.Location = New Point(178, 87)
        Servidor2Lbl.Name = "Servidor2Lbl"
        Servidor2Lbl.Size = New Size(155, 20)
        Servidor2Lbl.TabIndex = 53
        Servidor2Lbl.Text = "Informe o Servidor 2"
        Servidor2Lbl.Visible = False
        ' 
        ' Servidor3Lbl
        ' 
        Servidor3Lbl.AutoSize = True
        Servidor3Lbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Servidor3Lbl.ForeColor = Color.Blue
        Servidor3Lbl.Location = New Point(178, 137)
        Servidor3Lbl.Name = "Servidor3Lbl"
        Servidor3Lbl.Size = New Size(155, 20)
        Servidor3Lbl.TabIndex = 54
        Servidor3Lbl.Text = "Informe o Servidor 3"
        Servidor3Lbl.Visible = False
        ' 
        ' HabilitarServidor2Cbx
        ' 
        HabilitarServidor2Cbx.AutoSize = True
        HabilitarServidor2Cbx.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        HabilitarServidor2Cbx.ForeColor = Color.Navy
        HabilitarServidor2Cbx.Location = New Point(487, 107)
        HabilitarServidor2Cbx.Name = "HabilitarServidor2Cbx"
        HabilitarServidor2Cbx.Size = New Size(178, 25)
        HabilitarServidor2Cbx.TabIndex = 55
        HabilitarServidor2Cbx.Text = "Habilitar Servidor 2"
        HabilitarServidor2Cbx.UseVisualStyleBackColor = True
        ' 
        ' HabilitarServidor3Cbx
        ' 
        HabilitarServidor3Cbx.AutoSize = True
        HabilitarServidor3Cbx.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        HabilitarServidor3Cbx.ForeColor = Color.Blue
        HabilitarServidor3Cbx.Location = New Point(487, 157)
        HabilitarServidor3Cbx.Name = "HabilitarServidor3Cbx"
        HabilitarServidor3Cbx.Size = New Size(178, 25)
        HabilitarServidor3Cbx.TabIndex = 56
        HabilitarServidor3Cbx.Text = "Habilitar Servidor 3"
        HabilitarServidor3Cbx.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(27, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 57
        PictureBox1.TabStop = False
        ' 
        ' TotalLogEventoBtn
        ' 
        TotalLogEventoBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLogEventoBtn.ForeColor = Color.Navy
        TotalLogEventoBtn.ImageAlign = ContentAlignment.MiddleLeft
        TotalLogEventoBtn.Location = New Point(222, 695)
        TotalLogEventoBtn.Name = "TotalLogEventoBtn"
        TotalLogEventoBtn.Size = New Size(121, 52)
        TotalLogEventoBtn.TabIndex = 58
        TotalLogEventoBtn.Text = "Total da LogEvento"
        TotalLogEventoBtn.TextAlign = ContentAlignment.TopCenter
        TotalLogEventoBtn.UseVisualStyleBackColor = True
        TotalLogEventoBtn.Visible = False
        ' 
        ' MediaLogEventoBtn
        ' 
        MediaLogEventoBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MediaLogEventoBtn.ForeColor = Color.Navy
        MediaLogEventoBtn.ImageAlign = ContentAlignment.MiddleLeft
        MediaLogEventoBtn.Location = New Point(349, 695)
        MediaLogEventoBtn.Name = "MediaLogEventoBtn"
        MediaLogEventoBtn.Size = New Size(121, 52)
        MediaLogEventoBtn.TabIndex = 59
        MediaLogEventoBtn.Text = "Média da LogEvento"
        MediaLogEventoBtn.TextAlign = ContentAlignment.TopCenter
        MediaLogEventoBtn.UseVisualStyleBackColor = True
        MediaLogEventoBtn.Visible = False
        ' 
        ' MediaLogAcessoSymBtn
        ' 
        MediaLogAcessoSymBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MediaLogAcessoSymBtn.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        MediaLogAcessoSymBtn.ImageAlign = ContentAlignment.MiddleLeft
        MediaLogAcessoSymBtn.Location = New Point(615, 695)
        MediaLogAcessoSymBtn.Name = "MediaLogAcessoSymBtn"
        MediaLogAcessoSymBtn.Size = New Size(133, 52)
        MediaLogAcessoSymBtn.TabIndex = 61
        MediaLogAcessoSymBtn.Text = "Média da LogAcessoSym"
        MediaLogAcessoSymBtn.TextAlign = ContentAlignment.TopCenter
        MediaLogAcessoSymBtn.UseVisualStyleBackColor = True
        MediaLogAcessoSymBtn.Visible = False
        ' 
        ' TotalLogAcessoSymBtn
        ' 
        TotalLogAcessoSymBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLogAcessoSymBtn.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        TotalLogAcessoSymBtn.ImageAlign = ContentAlignment.MiddleLeft
        TotalLogAcessoSymBtn.Location = New Point(476, 695)
        TotalLogAcessoSymBtn.Name = "TotalLogAcessoSymBtn"
        TotalLogAcessoSymBtn.Size = New Size(133, 52)
        TotalLogAcessoSymBtn.TabIndex = 60
        TotalLogAcessoSymBtn.Text = "Total da LogAcessoSym"
        TotalLogAcessoSymBtn.TextAlign = ContentAlignment.TopCenter
        TotalLogAcessoSymBtn.UseVisualStyleBackColor = True
        TotalLogAcessoSymBtn.Visible = False
        ' 
        ' SHRINKBtn
        ' 
        SHRINKBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SHRINKBtn.ForeColor = Color.Red
        SHRINKBtn.ImageAlign = ContentAlignment.MiddleLeft
        SHRINKBtn.Location = New Point(779, 695)
        SHRINKBtn.Name = "SHRINKBtn"
        SHRINKBtn.Size = New Size(121, 52)
        SHRINKBtn.TabIndex = 62
        SHRINKBtn.Text = "Executar SHRINK"
        SHRINKBtn.TextAlign = ContentAlignment.TopCenter
        SHRINKBtn.UseVisualStyleBackColor = True
        SHRINKBtn.Visible = False
        ' 
        ' VerificarDBABtn
        ' 
        VerificarDBABtn.BackColor = Color.Cyan
        VerificarDBABtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        VerificarDBABtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        VerificarDBABtn.Location = New Point(17, 456)
        VerificarDBABtn.Name = "VerificarDBABtn"
        VerificarDBABtn.Size = New Size(184, 63)
        VerificarDBABtn.TabIndex = 63
        VerificarDBABtn.Text = "Verificar os últimos processamentos do DBA_Tools"
        VerificarDBABtn.UseVisualStyleBackColor = False
        ' 
        ' Ferramenta_Cloud
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1062, 749)
        Controls.Add(VerificarDBABtn)
        Controls.Add(SHRINKBtn)
        Controls.Add(MediaLogAcessoSymBtn)
        Controls.Add(TotalLogAcessoSymBtn)
        Controls.Add(MediaLogEventoBtn)
        Controls.Add(TotalLogEventoBtn)
        Controls.Add(PictureBox1)
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
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Ferramenta_Cloud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ferramenta_Cloud"
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalLogEventoBtn As Button
    Friend WithEvents MediaLogEventoBtn As Button
    Friend WithEvents MediaLogAcessoSymBtn As Button
    Friend WithEvents TotalLogAcessoSymBtn As Button
    Friend WithEvents SHRINKBtn As Button
    Friend WithEvents InformaçõesDasEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarDBABtn As Button
End Class

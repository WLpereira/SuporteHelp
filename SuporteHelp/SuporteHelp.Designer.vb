<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuporteHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuporteHelp))
        ServidorConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        SenhaConectarLbl = New Label()
        ServidorTxb = New TextBox()
        NomeConectarTxb = New TextBox()
        SenhaTxb = New TextBox()
        MenuStrip1 = New MenuStrip()
        FerramentasToolStripMenuItem = New ToolStripMenuItem()
        ValidarEmailToolStripMenuItem = New ToolStripMenuItem()
        ValidarGtinToolStripMenuItem = New ToolStripMenuItem()
        ProcurarTabelaOuColunaNoBDToolStripMenuItem = New ToolStripMenuItem()
        CompararTabelasToolStripMenuItem = New ToolStripMenuItem()
        DescriçãoDasColunasToolStripMenuItem = New ToolStripMenuItem()
        VerificarInformaçõesDoBancoToolStripMenuItem = New ToolStripMenuItem()
        CriptoToolStripMenuItem = New ToolStripMenuItem()
        DDClientsToolStripMenuItem = New ToolStripMenuItem()
        CloudCreateUserToolStripMenuItem = New ToolStripMenuItem()
        LogoToolStripMenuItem = New ToolStripMenuItem()
        PainelAvaliacoesToolStripMenuItem = New ToolStripMenuItem()
        HelpDeskToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        CloudToolStripMenuItem = New ToolStripMenuItem()
        FerramentaCloudToolStripMenuItem = New ToolStripMenuItem()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BancoCloudLbl = New Label()
        UsuarioSenhaLbl = New Label()
        HomologacaoLbl = New Label()
        MOduloCheckLbl = New Label()
        CloudBtn = New Button()
        UsuarioSenhaBtn = New Button()
        HomologacaoBtn = New Button()
        ModuloCheckBtn = New Button()
        SairHelpBtn = New Button()
        PesquisaTxb = New TextBox()
        PesquisaLbl = New Label()
        PesquisarBtn = New Button()
        LimparBtn = New Button()
        ListadeServidorDtg = New DataGridView()
        ConectarBtn = New Button()
        GerarRegbtn = New Button()
        GerarRegLbl = New Label()
        SugestaoBtn = New Button()
        ExibirServidorCbx = New ComboBox()
        SelecinarServidorLbl = New Label()
        MostrarTamanhoBtn = New Button()
        AtualizarBtn = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ListadeServidorDtg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Location = New Point(115, 35)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(125, 17)
        ServidorConectarLbl.TabIndex = 0
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Location = New Point(402, 35)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(55, 17)
        UsuarioConectarLbl.TabIndex = 1
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Location = New Point(689, 35)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(45, 17)
        SenhaConectarLbl.TabIndex = 2
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' ServidorTxb
        ' 
        ServidorTxb.Location = New Point(115, 55)
        ServidorTxb.Name = "ServidorTxb"
        ServidorTxb.Size = New Size(281, 25)
        ServidorTxb.TabIndex = 4
        ' 
        ' NomeConectarTxb
        ' 
        NomeConectarTxb.Location = New Point(405, 55)
        NomeConectarTxb.Name = "NomeConectarTxb"
        NomeConectarTxb.Size = New Size(268, 25)
        NomeConectarTxb.TabIndex = 5
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.Location = New Point(689, 55)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(233, 25)
        SenhaTxb.TabIndex = 6
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FerramentasToolStripMenuItem, CloudToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 29)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FerramentasToolStripMenuItem
        ' 
        FerramentasToolStripMenuItem.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        FerramentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ValidarEmailToolStripMenuItem, ValidarGtinToolStripMenuItem, ProcurarTabelaOuColunaNoBDToolStripMenuItem, CompararTabelasToolStripMenuItem, DescriçãoDasColunasToolStripMenuItem, VerificarInformaçõesDoBancoToolStripMenuItem, CriptoToolStripMenuItem, DDClientsToolStripMenuItem, CloudCreateUserToolStripMenuItem, LogoToolStripMenuItem, PainelAvaliacoesToolStripMenuItem, HelpDeskToolStripMenuItem, ToolStripMenuItem1})
        FerramentasToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FerramentasToolStripMenuItem.ForeColor = Color.White
        FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        FerramentasToolStripMenuItem.Size = New Size(116, 25)
        FerramentasToolStripMenuItem.Text = "Ferramentas"
        ' 
        ' ValidarEmailToolStripMenuItem
        ' 
        ValidarEmailToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_mensagem_64
        ValidarEmailToolStripMenuItem.Name = "ValidarEmailToolStripMenuItem"
        ValidarEmailToolStripMenuItem.Size = New Size(331, 26)
        ValidarEmailToolStripMenuItem.Text = "Validar E-mail"
        ' 
        ' ValidarGtinToolStripMenuItem
        ' 
        ValidarGtinToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources._3702397_barcode_code_scan_scanner_108737
        ValidarGtinToolStripMenuItem.Name = "ValidarGtinToolStripMenuItem"
        ValidarGtinToolStripMenuItem.Size = New Size(331, 26)
        ValidarGtinToolStripMenuItem.Text = "Validar Gtin"
        ' 
        ' ProcurarTabelaOuColunaNoBDToolStripMenuItem
        ' 
        ProcurarTabelaOuColunaNoBDToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_servidor_64
        ProcurarTabelaOuColunaNoBDToolStripMenuItem.Name = "ProcurarTabelaOuColunaNoBDToolStripMenuItem"
        ProcurarTabelaOuColunaNoBDToolStripMenuItem.Size = New Size(331, 26)
        ProcurarTabelaOuColunaNoBDToolStripMenuItem.Text = "Procurar Tabela ou Coluna no BD"
        ' 
        ' CompararTabelasToolStripMenuItem
        ' 
        CompararTabelasToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.tabela
        CompararTabelasToolStripMenuItem.Name = "CompararTabelasToolStripMenuItem"
        CompararTabelasToolStripMenuItem.Size = New Size(331, 26)
        CompararTabelasToolStripMenuItem.Text = "Comparar Tabelas"
        ' 
        ' DescriçãoDasColunasToolStripMenuItem
        ' 
        DescriçãoDasColunasToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_informações_30
        DescriçãoDasColunasToolStripMenuItem.Name = "DescriçãoDasColunasToolStripMenuItem"
        DescriçãoDasColunasToolStripMenuItem.Size = New Size(331, 26)
        DescriçãoDasColunasToolStripMenuItem.Text = "Descrição das Colunas"
        ' 
        ' VerificarInformaçõesDoBancoToolStripMenuItem
        ' 
        VerificarInformaçõesDoBancoToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_pesquisar_30
        VerificarInformaçõesDoBancoToolStripMenuItem.Name = "VerificarInformaçõesDoBancoToolStripMenuItem"
        VerificarInformaçõesDoBancoToolStripMenuItem.Size = New Size(331, 26)
        VerificarInformaçõesDoBancoToolStripMenuItem.Text = "Verificar informações do Banco"
        ' 
        ' CriptoToolStripMenuItem
        ' 
        CriptoToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_senha_30
        CriptoToolStripMenuItem.Name = "CriptoToolStripMenuItem"
        CriptoToolStripMenuItem.Size = New Size(331, 26)
        CriptoToolStripMenuItem.Text = "Cripto"
        ' 
        ' DDClientsToolStripMenuItem
        ' 
        DDClientsToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_usuário_30
        DDClientsToolStripMenuItem.Name = "DDClientsToolStripMenuItem"
        DDClientsToolStripMenuItem.Size = New Size(331, 26)
        DDClientsToolStripMenuItem.Text = "DDClients"
        ' 
        ' CloudCreateUserToolStripMenuItem
        ' 
        CloudCreateUserToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_nuvem_60
        CloudCreateUserToolStripMenuItem.Name = "CloudCreateUserToolStripMenuItem"
        CloudCreateUserToolStripMenuItem.Size = New Size(331, 26)
        CloudCreateUserToolStripMenuItem.Text = "CloudCreateUser"
        ' 
        ' LogoToolStripMenuItem
        ' 
        LogoToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_saída_de_emergência_30
        LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        LogoToolStripMenuItem.Size = New Size(331, 26)
        LogoToolStripMenuItem.Text = "Logoff-Desconectar do ERP"
        ' 
        ' PainelAvaliacoesToolStripMenuItem
        ' 
        PainelAvaliacoesToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.icons8_sugestão_30
        PainelAvaliacoesToolStripMenuItem.Name = "PainelAvaliacoesToolStripMenuItem"
        PainelAvaliacoesToolStripMenuItem.Size = New Size(331, 26)
        PainelAvaliacoesToolStripMenuItem.Text = "PainelAvaliacoes"
        ' 
        ' HelpDeskToolStripMenuItem
        ' 
        HelpDeskToolStripMenuItem.Image = SuporteHelp.My.Resources.Resources.person_business_call_avatar_support_user_helpdesk_customer_costumer_service_icon_228998
        HelpDeskToolStripMenuItem.Name = "HelpDeskToolStripMenuItem"
        HelpDeskToolStripMenuItem.Size = New Size(331, 26)
        HelpDeskToolStripMenuItem.Text = "HelpDesk"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Image = SuporteHelp.My.Resources.Resources.download_folder_file_icon_219533
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(331, 26)
        ToolStripMenuItem1.Text = "Pasta de Packs "
        ' 
        ' CloudToolStripMenuItem
        ' 
        CloudToolStripMenuItem.BackColor = Color.CornflowerBlue
        CloudToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FerramentaCloudToolStripMenuItem})
        CloudToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CloudToolStripMenuItem.ForeColor = Color.White
        CloudToolStripMenuItem.Name = "CloudToolStripMenuItem"
        CloudToolStripMenuItem.Size = New Size(67, 25)
        CloudToolStripMenuItem.Text = "Cloud"
        ' 
        ' FerramentaCloudToolStripMenuItem
        ' 
        FerramentaCloudToolStripMenuItem.Name = "FerramentaCloudToolStripMenuItem"
        FerramentaCloudToolStripMenuItem.Size = New Size(216, 26)
        FerramentaCloudToolStripMenuItem.Text = "Ferramenta Cloud"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = SuporteHelp.My.Resources.Resources.icons8_servidor_64
        PictureBox2.Location = New Point(396, 138)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(96, 69)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = SuporteHelp.My.Resources.Resources.icons8_grupo_de_servidores_100
        PictureBox1.Location = New Point(9, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 106)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' BancoCloudLbl
        ' 
        BancoCloudLbl.AutoSize = True
        BancoCloudLbl.Location = New Point(41, 221)
        BancoCloudLbl.Name = "BancoCloudLbl"
        BancoCloudLbl.Size = New Size(229, 17)
        BancoCloudLbl.TabIndex = 12
        BancoCloudLbl.Text = "Banco do CLOUD, executar Primeiro"
        ' 
        ' UsuarioSenhaLbl
        ' 
        UsuarioSenhaLbl.AutoSize = True
        UsuarioSenhaLbl.Location = New Point(85, 318)
        UsuarioSenhaLbl.Name = "UsuarioSenhaLbl"
        UsuarioSenhaLbl.Size = New Size(146, 17)
        UsuarioSenhaLbl.TabIndex = 13
        UsuarioSenhaLbl.Text = "Usuario: SA Senha: DP"
        ' 
        ' HomologacaoLbl
        ' 
        HomologacaoLbl.AutoSize = True
        HomologacaoLbl.Location = New Point(73, 422)
        HomologacaoLbl.Name = "HomologacaoLbl"
        HomologacaoLbl.Size = New Size(167, 17)
        HomologacaoLbl.TabIndex = 14
        HomologacaoLbl.Text = "Trocar para Homologação"
        ' 
        ' MOduloCheckLbl
        ' 
        MOduloCheckLbl.AutoSize = True
        MOduloCheckLbl.Location = New Point(31, 527)
        MOduloCheckLbl.Name = "MOduloCheckLbl"
        MOduloCheckLbl.Size = New Size(235, 17)
        MOduloCheckLbl.TabIndex = 15
        MOduloCheckLbl.Text = "Deletar Modulo Check e criar Trigger"
        ' 
        ' CloudBtn
        ' 
        CloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CloudBtn.Image = SuporteHelp.My.Resources.Resources.icons8_restauração_de_backup_em_nuvem_30
        CloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        CloudBtn.Location = New Point(102, 247)
        CloudBtn.Name = "CloudBtn"
        CloudBtn.Size = New Size(150, 38)
        CloudBtn.TabIndex = 16
        CloudBtn.Text = "Alterar"
        CloudBtn.TextAlign = ContentAlignment.MiddleRight
        CloudBtn.UseVisualStyleBackColor = True
        ' 
        ' UsuarioSenhaBtn
        ' 
        UsuarioSenhaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioSenhaBtn.Image = SuporteHelp.My.Resources.Resources.icons8_usuário_30
        UsuarioSenhaBtn.ImageAlign = ContentAlignment.MiddleLeft
        UsuarioSenhaBtn.Location = New Point(102, 356)
        UsuarioSenhaBtn.Name = "UsuarioSenhaBtn"
        UsuarioSenhaBtn.Size = New Size(150, 38)
        UsuarioSenhaBtn.TabIndex = 17
        UsuarioSenhaBtn.Text = "Alterar"
        UsuarioSenhaBtn.TextAlign = ContentAlignment.MiddleRight
        UsuarioSenhaBtn.UseVisualStyleBackColor = True
        ' 
        ' HomologacaoBtn
        ' 
        HomologacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        HomologacaoBtn.Image = SuporteHelp.My.Resources.Resources.icons8_nota_fiscal_electrónica_30
        HomologacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        HomologacaoBtn.Location = New Point(102, 460)
        HomologacaoBtn.Name = "HomologacaoBtn"
        HomologacaoBtn.Size = New Size(150, 38)
        HomologacaoBtn.TabIndex = 18
        HomologacaoBtn.Text = "Alterar"
        HomologacaoBtn.TextAlign = ContentAlignment.MiddleRight
        HomologacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' ModuloCheckBtn
        ' 
        ModuloCheckBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ModuloCheckBtn.Image = SuporteHelp.My.Resources.Resources.icons8_delete_key_30
        ModuloCheckBtn.ImageAlign = ContentAlignment.MiddleLeft
        ModuloCheckBtn.Location = New Point(102, 563)
        ModuloCheckBtn.Name = "ModuloCheckBtn"
        ModuloCheckBtn.Size = New Size(150, 38)
        ModuloCheckBtn.TabIndex = 19
        ModuloCheckBtn.Text = "Alterar"
        ModuloCheckBtn.TextAlign = ContentAlignment.MiddleRight
        ModuloCheckBtn.UseVisualStyleBackColor = True
        ' 
        ' SairHelpBtn
        ' 
        SairHelpBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairHelpBtn.Image = CType(resources.GetObject("SairHelpBtn.Image"), Image)
        SairHelpBtn.ImageAlign = ContentAlignment.MiddleRight
        SairHelpBtn.Location = New Point(916, 703)
        SairHelpBtn.Name = "SairHelpBtn"
        SairHelpBtn.Size = New Size(118, 38)
        SairHelpBtn.TabIndex = 20
        SairHelpBtn.Text = "SAIR"
        SairHelpBtn.TextAlign = ContentAlignment.MiddleLeft
        SairHelpBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisaTxb
        ' 
        PesquisaTxb.Location = New Point(498, 134)
        PesquisaTxb.Name = "PesquisaTxb"
        PesquisaTxb.Size = New Size(507, 25)
        PesquisaTxb.TabIndex = 22
        ' 
        ' PesquisaLbl
        ' 
        PesquisaLbl.AutoSize = True
        PesquisaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisaLbl.Location = New Point(613, 102)
        PesquisaLbl.Name = "PesquisaLbl"
        PesquisaLbl.Size = New Size(203, 21)
        PesquisaLbl.TabIndex = 21
        PesquisaLbl.Text = "Pesquisa Banco de Dados"
        ' 
        ' PesquisarBtn
        ' 
        PesquisarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarBtn.Image = CType(resources.GetObject("PesquisarBtn.Image"), Image)
        PesquisarBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarBtn.Location = New Point(498, 169)
        PesquisarBtn.Name = "PesquisarBtn"
        PesquisarBtn.Size = New Size(118, 38)
        PesquisarBtn.TabIndex = 23
        PesquisarBtn.Text = "Pesquisar"
        PesquisarBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparBtn
        ' 
        LimparBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparBtn.Image = CType(resources.GetObject("LimparBtn.Image"), Image)
        LimparBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparBtn.Location = New Point(887, 169)
        LimparBtn.Name = "LimparBtn"
        LimparBtn.Size = New Size(118, 38)
        LimparBtn.TabIndex = 24
        LimparBtn.Text = "Limpar"
        LimparBtn.TextAlign = ContentAlignment.MiddleRight
        LimparBtn.UseVisualStyleBackColor = True
        ' 
        ' ListadeServidorDtg
        ' 
        ListadeServidorDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeServidorDtg.Location = New Point(384, 227)
        ListadeServidorDtg.Name = "ListadeServidorDtg"
        ListadeServidorDtg.ReadOnly = True
        ListadeServidorDtg.RowHeadersWidth = 51
        ListadeServidorDtg.RowTemplate.Height = 25
        ListadeServidorDtg.Size = New Size(650, 470)
        ListadeServidorDtg.TabIndex = 25
        ' 
        ' ConectarBtn
        ' 
        ConectarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarBtn.Image = CType(resources.GetObject("ConectarBtn.Image"), Image)
        ConectarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarBtn.Location = New Point(932, 49)
        ConectarBtn.Name = "ConectarBtn"
        ConectarBtn.Size = New Size(118, 38)
        ConectarBtn.TabIndex = 26
        ConectarBtn.Text = "Conectar"
        ConectarBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarBtn.UseVisualStyleBackColor = True
        ' 
        ' GerarRegbtn
        ' 
        GerarRegbtn.Image = SuporteHelp.My.Resources.Resources.icons8_dsn_30
        GerarRegbtn.ImageAlign = ContentAlignment.MiddleLeft
        GerarRegbtn.Location = New Point(102, 660)
        GerarRegbtn.Name = "GerarRegbtn"
        GerarRegbtn.Size = New Size(150, 37)
        GerarRegbtn.TabIndex = 27
        GerarRegbtn.Text = "Gerar ODBC"
        GerarRegbtn.TextAlign = ContentAlignment.MiddleRight
        GerarRegbtn.UseVisualStyleBackColor = True
        ' 
        ' GerarRegLbl
        ' 
        GerarRegLbl.AutoSize = True
        GerarRegLbl.Location = New Point(68, 621)
        GerarRegLbl.Name = "GerarRegLbl"
        GerarRegLbl.Size = New Size(169, 17)
        GerarRegLbl.TabIndex = 28
        GerarRegLbl.Text = "Gerar ODBC, Arquivo .Reg"
        ' 
        ' SugestaoBtn
        ' 
        SugestaoBtn.Image = SuporteHelp.My.Resources.Resources.icons8_sugestão_30
        SugestaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        SugestaoBtn.Location = New Point(384, 703)
        SugestaoBtn.Name = "SugestaoBtn"
        SugestaoBtn.Size = New Size(229, 38)
        SugestaoBtn.TabIndex = 29
        SugestaoBtn.Text = "Sugestão de Melhoria"
        SugestaoBtn.TextAlign = ContentAlignment.MiddleRight
        SugestaoBtn.UseVisualStyleBackColor = True
        ' 
        ' ExibirServidorCbx
        ' 
        ExibirServidorCbx.FormattingEnabled = True
        ExibirServidorCbx.Location = New Point(115, 115)
        ExibirServidorCbx.Name = "ExibirServidorCbx"
        ExibirServidorCbx.Size = New Size(210, 25)
        ExibirServidorCbx.TabIndex = 30
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(115, 89)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(170, 17)
        SelecinarServidorLbl.TabIndex = 31
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' MostrarTamanhoBtn
        ' 
        MostrarTamanhoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarTamanhoBtn.ForeColor = Color.Red
        MostrarTamanhoBtn.Location = New Point(649, 169)
        MostrarTamanhoBtn.Name = "MostrarTamanhoBtn"
        MostrarTamanhoBtn.Size = New Size(201, 52)
        MostrarTamanhoBtn.TabIndex = 32
        MostrarTamanhoBtn.Text = "Tamanho dos Bancos Consulta Demorada"
        MostrarTamanhoBtn.UseVisualStyleBackColor = True
        ' 
        ' AtualizarBtn
        ' 
        AtualizarBtn.BackColor = Color.Yellow
        AtualizarBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarBtn.Location = New Point(673, 703)
        AtualizarBtn.Name = "AtualizarBtn"
        AtualizarBtn.Size = New Size(158, 38)
        AtualizarBtn.TabIndex = 33
        AtualizarBtn.Text = "ATUALIZAR"
        AtualizarBtn.UseVisualStyleBackColor = False
        ' 
        ' SuporteHelp
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
        Controls.Add(AtualizarBtn)
        Controls.Add(MostrarTamanhoBtn)
        Controls.Add(SelecinarServidorLbl)
        Controls.Add(ExibirServidorCbx)
        Controls.Add(SugestaoBtn)
        Controls.Add(GerarRegLbl)
        Controls.Add(GerarRegbtn)
        Controls.Add(ConectarBtn)
        Controls.Add(ListadeServidorDtg)
        Controls.Add(LimparBtn)
        Controls.Add(PesquisarBtn)
        Controls.Add(PesquisaTxb)
        Controls.Add(PesquisaLbl)
        Controls.Add(SairHelpBtn)
        Controls.Add(ModuloCheckBtn)
        Controls.Add(HomologacaoBtn)
        Controls.Add(UsuarioSenhaBtn)
        Controls.Add(CloudBtn)
        Controls.Add(MOduloCheckLbl)
        Controls.Add(HomologacaoLbl)
        Controls.Add(UsuarioSenhaLbl)
        Controls.Add(BancoCloudLbl)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(SenhaTxb)
        Controls.Add(NomeConectarTxb)
        Controls.Add(ServidorTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioConectarLbl)
        Controls.Add(ServidorConectarLbl)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "SuporteHelp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SuporteHelp_V_1.1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ListadeServidorDtg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ServidorConectarLbl As Label
    Friend WithEvents UsuarioConectarLbl As Label
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents ServidorTxb As TextBox
    Friend WithEvents NomeConectarTxb As TextBox
    Friend WithEvents SenhaTxb As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidarEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriptoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BancoCloudLbl As Label
    Friend WithEvents UsuarioSenhaLbl As Label
    Friend WithEvents HomologacaoLbl As Label
    Friend WithEvents MOduloCheckLbl As Label
    Friend WithEvents CloudBtn As Button
    Friend WithEvents UsuarioSenhaBtn As Button
    Friend WithEvents HomologacaoBtn As Button
    Friend WithEvents ModuloCheckBtn As Button
    Friend WithEvents SairHelpBtn As Button
    Friend WithEvents PesquisaTxb As TextBox
    Friend WithEvents PesquisaLbl As Label
    Friend WithEvents PesquisarBtn As Button
    Friend WithEvents LimparBtn As Button
    Friend WithEvents ListadeServidorDtg As DataGridView
    Friend WithEvents ConectarBtn As Button
    Friend WithEvents DDClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloudCreateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PainelAvaliacoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpDeskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerarRegbtn As Button
    Friend WithEvents GerarRegLbl As Label
    Friend WithEvents SugestaoBtn As Button
    Friend WithEvents ValidarGtinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcurarTabelaOuColunaNoBDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescriçãoDasColunasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarInformaçõesDoBancoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExibirServidorCbx As ComboBox
    Friend WithEvents SelecinarServidorLbl As Label
    Friend WithEvents MostrarTamanhoBtn As Button
    Friend WithEvents CompararTabelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentaCloudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtualizarBtn As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SuporteHelp))
        ServidorConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        SenhaConectarLbl = New Label()
        ServidorTxb = New TextBox()
        NomeConectarTxb = New TextBox()
        SenhaTxb = New TextBox()
        MenuStrip1 = New MenuStrip()
        FerramentasToolStripMenuItem = New ToolStripMenuItem()
        ValidarEmailToolStripMenuItem = New ToolStripMenuItem()
        CriptoToolStripMenuItem = New ToolStripMenuItem()
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
        Button1 = New Button()
        PesquisaTxb = New TextBox()
        PesquisaLbl = New Label()
        PesquisarBtn = New Button()
        LimparBtn = New Button()
        ListadeServidorDtg = New DataGridView()
        ConectarBtn = New Button()
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
        UsuarioConectarLbl.Location = New Point(316, 35)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(55, 17)
        UsuarioConectarLbl.TabIndex = 1
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Location = New Point(566, 35)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(45, 17)
        SenhaConectarLbl.TabIndex = 2
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' ServidorTxb
        ' 
        ServidorTxb.Location = New Point(115, 55)
        ServidorTxb.Name = "ServidorTxb"
        ServidorTxb.Size = New Size(195, 25)
        ServidorTxb.TabIndex = 4
        ' 
        ' NomeConectarTxb
        ' 
        NomeConectarTxb.Location = New Point(316, 55)
        NomeConectarTxb.Name = "NomeConectarTxb"
        NomeConectarTxb.Size = New Size(244, 25)
        NomeConectarTxb.TabIndex = 5
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.Location = New Point(566, 55)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(177, 25)
        SenhaTxb.TabIndex = 6
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FerramentasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(934, 25)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FerramentasToolStripMenuItem
        ' 
        FerramentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ValidarEmailToolStripMenuItem, CriptoToolStripMenuItem})
        FerramentasToolStripMenuItem.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        FerramentasToolStripMenuItem.Size = New Size(96, 21)
        FerramentasToolStripMenuItem.Text = "Ferramentas"
        ' 
        ' ValidarEmailToolStripMenuItem
        ' 
        ValidarEmailToolStripMenuItem.Name = "ValidarEmailToolStripMenuItem"
        ValidarEmailToolStripMenuItem.Size = New Size(162, 22)
        ValidarEmailToolStripMenuItem.Text = "Validar E-mail"
        ' 
        ' CriptoToolStripMenuItem
        ' 
        CriptoToolStripMenuItem.Name = "CriptoToolStripMenuItem"
        CriptoToolStripMenuItem.Size = New Size(162, 22)
        CriptoToolStripMenuItem.Text = "Cripto"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_servidor_64
        PictureBox2.Location = New Point(405, 129)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(73, 63)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_grupo_de_servidores_100
        PictureBox1.Location = New Point(9, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 106)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' BancoCloudLbl
        ' 
        BancoCloudLbl.AutoSize = True
        BancoCloudLbl.Location = New Point(20, 208)
        BancoCloudLbl.Name = "BancoCloudLbl"
        BancoCloudLbl.Size = New Size(229, 17)
        BancoCloudLbl.TabIndex = 12
        BancoCloudLbl.Text = "Banco do CLOUD, executar Primeiro"
        ' 
        ' UsuarioSenhaLbl
        ' 
        UsuarioSenhaLbl.AutoSize = True
        UsuarioSenhaLbl.Location = New Point(59, 306)
        UsuarioSenhaLbl.Name = "UsuarioSenhaLbl"
        UsuarioSenhaLbl.Size = New Size(146, 17)
        UsuarioSenhaLbl.TabIndex = 13
        UsuarioSenhaLbl.Text = "Usuario: SA Senha: DP"
        ' 
        ' HomologacaoLbl
        ' 
        HomologacaoLbl.AutoSize = True
        HomologacaoLbl.Location = New Point(47, 404)
        HomologacaoLbl.Name = "HomologacaoLbl"
        HomologacaoLbl.Size = New Size(167, 17)
        HomologacaoLbl.TabIndex = 14
        HomologacaoLbl.Text = "Trocar para Homologação"
        ' 
        ' MOduloCheckLbl
        ' 
        MOduloCheckLbl.AutoSize = True
        MOduloCheckLbl.Location = New Point(20, 508)
        MOduloCheckLbl.Name = "MOduloCheckLbl"
        MOduloCheckLbl.Size = New Size(235, 17)
        MOduloCheckLbl.TabIndex = 15
        MOduloCheckLbl.Text = "Deletar Modulo Check e criar Trigger"
        ' 
        ' CloudBtn
        ' 
        CloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CloudBtn.Image = My.Resources.Resources.icons8_restauração_de_backup_em_nuvem_30
        CloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        CloudBtn.Location = New Point(69, 237)
        CloudBtn.Name = "CloudBtn"
        CloudBtn.Size = New Size(118, 38)
        CloudBtn.TabIndex = 16
        CloudBtn.Text = "Alterar"
        CloudBtn.TextAlign = ContentAlignment.MiddleRight
        CloudBtn.UseVisualStyleBackColor = True
        ' 
        ' UsuarioSenhaBtn
        ' 
        UsuarioSenhaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioSenhaBtn.Image = My.Resources.Resources.icons8_usuário_30
        UsuarioSenhaBtn.ImageAlign = ContentAlignment.MiddleLeft
        UsuarioSenhaBtn.Location = New Point(69, 344)
        UsuarioSenhaBtn.Name = "UsuarioSenhaBtn"
        UsuarioSenhaBtn.Size = New Size(118, 38)
        UsuarioSenhaBtn.TabIndex = 17
        UsuarioSenhaBtn.Text = "Alterar"
        UsuarioSenhaBtn.TextAlign = ContentAlignment.MiddleRight
        UsuarioSenhaBtn.UseVisualStyleBackColor = True
        ' 
        ' HomologacaoBtn
        ' 
        HomologacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        HomologacaoBtn.Image = My.Resources.Resources.icons8_nota_fiscal_electrónica_30
        HomologacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        HomologacaoBtn.Location = New Point(69, 438)
        HomologacaoBtn.Name = "HomologacaoBtn"
        HomologacaoBtn.Size = New Size(118, 38)
        HomologacaoBtn.TabIndex = 18
        HomologacaoBtn.Text = "Alterar"
        HomologacaoBtn.TextAlign = ContentAlignment.MiddleRight
        HomologacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' ModuloCheckBtn
        ' 
        ModuloCheckBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ModuloCheckBtn.Image = My.Resources.Resources.icons8_delete_key_30
        ModuloCheckBtn.ImageAlign = ContentAlignment.MiddleLeft
        ModuloCheckBtn.Location = New Point(69, 543)
        ModuloCheckBtn.Name = "ModuloCheckBtn"
        ModuloCheckBtn.Size = New Size(118, 38)
        ModuloCheckBtn.TabIndex = 19
        ModuloCheckBtn.Text = "Alterar"
        ModuloCheckBtn.TextAlign = ContentAlignment.MiddleRight
        ModuloCheckBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(786, 561)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 38)
        Button1.TabIndex = 20
        Button1.Text = "SAIR"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PesquisaTxb
        ' 
        PesquisaTxb.Location = New Point(506, 149)
        PesquisaTxb.Name = "PesquisaTxb"
        PesquisaTxb.Size = New Size(301, 25)
        PesquisaTxb.TabIndex = 22
        ' 
        ' PesquisaLbl
        ' 
        PesquisaLbl.AutoSize = True
        PesquisaLbl.Location = New Point(570, 129)
        PesquisaLbl.Name = "PesquisaLbl"
        PesquisaLbl.Size = New Size(165, 17)
        PesquisaLbl.TabIndex = 21
        PesquisaLbl.Text = "Pesquisa Banco de Dados"
        ' 
        ' PesquisarBtn
        ' 
        PesquisarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarBtn.Image = CType(resources.GetObject("PesquisarBtn.Image"), Image)
        PesquisarBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarBtn.Location = New Point(506, 180)
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
        LimparBtn.Location = New Point(689, 180)
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
        ListadeServidorDtg.Location = New Point(363, 227)
        ListadeServidorDtg.Name = "ListadeServidorDtg"
        ListadeServidorDtg.RowTemplate.Height = 25
        ListadeServidorDtg.Size = New Size(571, 311)
        ListadeServidorDtg.TabIndex = 25
        ' 
        ' ConectarBtn
        ' 
        ConectarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarBtn.Image = CType(resources.GetObject("ConectarBtn.Image"), Image)
        ConectarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarBtn.Location = New Point(786, 42)
        ConectarBtn.Name = "ConectarBtn"
        ConectarBtn.Size = New Size(118, 38)
        ConectarBtn.TabIndex = 26
        ConectarBtn.Text = "Conectar"
        ConectarBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarBtn.UseVisualStyleBackColor = True
        ' 
        ' SuporteHelp
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 611)
        Controls.Add(ConectarBtn)
        Controls.Add(ListadeServidorDtg)
        Controls.Add(LimparBtn)
        Controls.Add(PesquisarBtn)
        Controls.Add(PesquisaTxb)
        Controls.Add(PesquisaLbl)
        Controls.Add(Button1)
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
        MainMenuStrip = MenuStrip1
        Name = "SuporteHelp"
        Text = "SuporteHelp"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents PesquisaTxb As TextBox
    Friend WithEvents PesquisaLbl As Label
    Friend WithEvents PesquisarBtn As Button
    Friend WithEvents LimparBtn As Button
    Friend WithEvents ListadeServidorDtg As DataGridView
    Friend WithEvents ConectarBtn As Button
End Class

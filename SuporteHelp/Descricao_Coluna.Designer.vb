<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descricao_Coluna
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Descricao_Coluna))
        SairTabelaColuna = New Button()
        MostarDetalheColunaDGV = New DataGridView()
        DescricaoColunaLbl = New Label()
        ConectarBtn = New Button()
        SenhaColunasTxb = New TextBox()
        NomeConectarColunasTxb = New TextBox()
        SenhaConectarColunasLbl = New Label()
        UsuarioConectarColunasLbl = New Label()
        ServidorConectarColunasLbl = New Label()
        ServidorColunasTxb = New TextBox()
        SelecionarBancoColunasTxb = New ComboBox()
        SelecionarBancoColunas = New Label()
        PesquisarcolunaTxb = New TextBox()
        LimparColunaBtn = New Button()
        PesquisarColunaBtn = New Button()
        ColunaLbl = New Label()
        Label1 = New Label()
        LimparDescricaoBtn = New Button()
        PesquisarDescricaoBtn = New Button()
        Label2 = New Label()
        LimparInformacaoBtn = New Button()
        PesquisarInformacaoBtn = New Button()
        PesquisarDescricaotxb = New TextBox()
        PesquisarInformacaoTxb = New TextBox()
        SSSALVOSLbl = New Label()
        ExibirServidorDescCbx = New ComboBox()
        CType(MostarDetalheColunaDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SairTabelaColuna
        ' 
        SairTabelaColuna.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairTabelaColuna.Image = CType(resources.GetObject("SairTabelaColuna.Image"), Image)
        SairTabelaColuna.ImageAlign = ContentAlignment.MiddleRight
        SairTabelaColuna.Location = New Point(835, 789)
        SairTabelaColuna.Margin = New Padding(3, 4, 3, 4)
        SairTabelaColuna.Name = "SairTabelaColuna"
        SairTabelaColuna.Size = New Size(135, 51)
        SairTabelaColuna.TabIndex = 22
        SairTabelaColuna.Text = "SAIR"
        SairTabelaColuna.TextAlign = ContentAlignment.MiddleLeft
        SairTabelaColuna.UseVisualStyleBackColor = True
        ' 
        ' MostarDetalheColunaDGV
        ' 
        MostarDetalheColunaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MostarDetalheColunaDGV.Location = New Point(32, 278)
        MostarDetalheColunaDGV.Name = "MostarDetalheColunaDGV"
        MostarDetalheColunaDGV.RowHeadersWidth = 51
        MostarDetalheColunaDGV.RowTemplate.Height = 29
        MostarDetalheColunaDGV.Size = New Size(924, 491)
        MostarDetalheColunaDGV.TabIndex = 23
        ' 
        ' DescricaoColunaLbl
        ' 
        DescricaoColunaLbl.AutoSize = True
        DescricaoColunaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DescricaoColunaLbl.ForeColor = Color.Navy
        DescricaoColunaLbl.Location = New Point(310, 124)
        DescricaoColunaLbl.Name = "DescricaoColunaLbl"
        DescricaoColunaLbl.Size = New Size(338, 28)
        DescricaoColunaLbl.TabIndex = 24
        DescricaoColunaLbl.Text = "Procurar Informações nas colunas "
        ' 
        ' ConectarBtn
        ' 
        ConectarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarBtn.Image = CType(resources.GetObject("ConectarBtn.Image"), Image)
        ConectarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarBtn.Location = New Point(637, 16)
        ConectarBtn.Name = "ConectarBtn"
        ConectarBtn.Size = New Size(118, 38)
        ConectarBtn.TabIndex = 33
        ConectarBtn.Text = "Conectar"
        ConectarBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaColunasTxb
        ' 
        SenhaColunasTxb.Location = New Point(454, 27)
        SenhaColunasTxb.Name = "SenhaColunasTxb"
        SenhaColunasTxb.Size = New Size(177, 27)
        SenhaColunasTxb.TabIndex = 32
        ' 
        ' NomeConectarColunasTxb
        ' 
        NomeConectarColunasTxb.Location = New Point(204, 27)
        NomeConectarColunasTxb.Name = "NomeConectarColunasTxb"
        NomeConectarColunasTxb.Size = New Size(244, 27)
        NomeConectarColunasTxb.TabIndex = 31
        ' 
        ' SenhaConectarColunasLbl
        ' 
        SenhaConectarColunasLbl.AutoSize = True
        SenhaConectarColunasLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarColunasLbl.Location = New Point(454, 7)
        SenhaConectarColunasLbl.Name = "SenhaConectarColunasLbl"
        SenhaConectarColunasLbl.Size = New Size(51, 20)
        SenhaConectarColunasLbl.TabIndex = 29
        SenhaConectarColunasLbl.Text = "Senha"
        ' 
        ' UsuarioConectarColunasLbl
        ' 
        UsuarioConectarColunasLbl.AutoSize = True
        UsuarioConectarColunasLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarColunasLbl.Location = New Point(204, 7)
        UsuarioConectarColunasLbl.Name = "UsuarioConectarColunasLbl"
        UsuarioConectarColunasLbl.Size = New Size(63, 20)
        UsuarioConectarColunasLbl.TabIndex = 28
        UsuarioConectarColunasLbl.Text = "Usuario"
        ' 
        ' ServidorConectarColunasLbl
        ' 
        ServidorConectarColunasLbl.AutoSize = True
        ServidorConectarColunasLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarColunasLbl.Location = New Point(3, 7)
        ServidorConectarColunasLbl.Name = "ServidorConectarColunasLbl"
        ServidorConectarColunasLbl.Size = New Size(142, 20)
        ServidorConectarColunasLbl.TabIndex = 27
        ServidorConectarColunasLbl.Text = "Informe o Servidor"
        ' 
        ' ServidorColunasTxb
        ' 
        ServidorColunasTxb.Location = New Point(3, 27)
        ServidorColunasTxb.Name = "ServidorColunasTxb"
        ServidorColunasTxb.Size = New Size(195, 27)
        ServidorColunasTxb.TabIndex = 30
        ' 
        ' SelecionarBancoColunasTxb
        ' 
        SelecionarBancoColunasTxb.FormattingEnabled = True
        SelecionarBancoColunasTxb.Location = New Point(761, 26)
        SelecionarBancoColunasTxb.Name = "SelecionarBancoColunasTxb"
        SelecionarBancoColunasTxb.Size = New Size(186, 28)
        SelecionarBancoColunasTxb.TabIndex = 34
        ' 
        ' SelecionarBancoColunas
        ' 
        SelecionarBancoColunas.AutoSize = True
        SelecionarBancoColunas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoColunas.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        SelecionarBancoColunas.Location = New Point(761, 3)
        SelecionarBancoColunas.Name = "SelecionarBancoColunas"
        SelecionarBancoColunas.Size = New Size(127, 20)
        SelecionarBancoColunas.TabIndex = 35
        SelecionarBancoColunas.Text = "Selecionar Banco"
        ' 
        ' PesquisarcolunaTxb
        ' 
        PesquisarcolunaTxb.Location = New Point(32, 195)
        PesquisarcolunaTxb.Margin = New Padding(3, 4, 3, 4)
        PesquisarcolunaTxb.Name = "PesquisarcolunaTxb"
        PesquisarcolunaTxb.Size = New Size(235, 27)
        PesquisarcolunaTxb.TabIndex = 37
        ' 
        ' LimparColunaBtn
        ' 
        LimparColunaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparColunaBtn.Image = My.Resources.Resources.icons8_limpar_filtros_30
        LimparColunaBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparColunaBtn.Location = New Point(152, 229)
        LimparColunaBtn.Margin = New Padding(3, 4, 3, 4)
        LimparColunaBtn.Name = "LimparColunaBtn"
        LimparColunaBtn.Size = New Size(115, 45)
        LimparColunaBtn.TabIndex = 39
        LimparColunaBtn.Text = "Limpar"
        LimparColunaBtn.TextAlign = ContentAlignment.MiddleRight
        LimparColunaBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarColunaBtn
        ' 
        PesquisarColunaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarColunaBtn.Image = My.Resources.Resources.icons8_pesquisar_30
        PesquisarColunaBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarColunaBtn.Location = New Point(32, 229)
        PesquisarColunaBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarColunaBtn.Name = "PesquisarColunaBtn"
        PesquisarColunaBtn.Size = New Size(117, 45)
        PesquisarColunaBtn.TabIndex = 38
        PesquisarColunaBtn.Text = "Pesquisar"
        PesquisarColunaBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarColunaBtn.UseVisualStyleBackColor = True
        ' 
        ' ColunaLbl
        ' 
        ColunaLbl.AutoSize = True
        ColunaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ColunaLbl.Location = New Point(109, 163)
        ColunaLbl.Name = "ColunaLbl"
        ColunaLbl.Size = New Size(77, 28)
        ColunaLbl.TabIndex = 40
        ColunaLbl.Text = "Coluna"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(420, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 28)
        Label1.TabIndex = 43
        Label1.Text = "Descrição"
        ' 
        ' LimparDescricaoBtn
        ' 
        LimparDescricaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparDescricaoBtn.Image = My.Resources.Resources.icons8_limpar_filtros_30
        LimparDescricaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparDescricaoBtn.Location = New Point(478, 229)
        LimparDescricaoBtn.Margin = New Padding(3, 4, 3, 4)
        LimparDescricaoBtn.Name = "LimparDescricaoBtn"
        LimparDescricaoBtn.Size = New Size(115, 45)
        LimparDescricaoBtn.TabIndex = 42
        LimparDescricaoBtn.Text = "Limpar"
        LimparDescricaoBtn.TextAlign = ContentAlignment.MiddleRight
        LimparDescricaoBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarDescricaoBtn
        ' 
        PesquisarDescricaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarDescricaoBtn.Image = My.Resources.Resources.icons8_pesquisar_30
        PesquisarDescricaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarDescricaoBtn.Location = New Point(358, 229)
        PesquisarDescricaoBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarDescricaoBtn.Name = "PesquisarDescricaoBtn"
        PesquisarDescricaoBtn.Size = New Size(117, 45)
        PesquisarDescricaoBtn.TabIndex = 41
        PesquisarDescricaoBtn.Text = "Pesquisar"
        PesquisarDescricaoBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarDescricaoBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(784, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 28)
        Label2.TabIndex = 46
        Label2.Text = "Informação"
        ' 
        ' LimparInformacaoBtn
        ' 
        LimparInformacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparInformacaoBtn.Image = My.Resources.Resources.icons8_limpar_filtros_30
        LimparInformacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparInformacaoBtn.Location = New Point(840, 229)
        LimparInformacaoBtn.Margin = New Padding(3, 4, 3, 4)
        LimparInformacaoBtn.Name = "LimparInformacaoBtn"
        LimparInformacaoBtn.Size = New Size(115, 45)
        LimparInformacaoBtn.TabIndex = 45
        LimparInformacaoBtn.Text = "Limpar"
        LimparInformacaoBtn.TextAlign = ContentAlignment.MiddleRight
        LimparInformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarInformacaoBtn
        ' 
        PesquisarInformacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarInformacaoBtn.Image = My.Resources.Resources.icons8_pesquisar_30
        PesquisarInformacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarInformacaoBtn.Location = New Point(720, 229)
        PesquisarInformacaoBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarInformacaoBtn.Name = "PesquisarInformacaoBtn"
        PesquisarInformacaoBtn.Size = New Size(117, 45)
        PesquisarInformacaoBtn.TabIndex = 44
        PesquisarInformacaoBtn.Text = "Pesquisar"
        PesquisarInformacaoBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarInformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarDescricaotxb
        ' 
        PesquisarDescricaotxb.Location = New Point(358, 195)
        PesquisarDescricaotxb.Margin = New Padding(3, 4, 3, 4)
        PesquisarDescricaotxb.Name = "PesquisarDescricaotxb"
        PesquisarDescricaotxb.Size = New Size(235, 27)
        PesquisarDescricaotxb.TabIndex = 47
        ' 
        ' PesquisarInformacaoTxb
        ' 
        PesquisarInformacaoTxb.Location = New Point(720, 195)
        PesquisarInformacaoTxb.Margin = New Padding(3, 4, 3, 4)
        PesquisarInformacaoTxb.Name = "PesquisarInformacaoTxb"
        PesquisarInformacaoTxb.Size = New Size(235, 27)
        PesquisarInformacaoTxb.TabIndex = 48
        ' 
        ' SSSALVOSLbl
        ' 
        SSSALVOSLbl.AutoSize = True
        SSSALVOSLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SSSALVOSLbl.ForeColor = Color.Red
        SSSALVOSLbl.Location = New Point(3, 66)
        SSSALVOSLbl.Name = "SSSALVOSLbl"
        SSSALVOSLbl.Size = New Size(239, 20)
        SSSALVOSLbl.TabIndex = 54
        SSSALVOSLbl.Text = "SELECIONAR SERVIDOR SALVOS "
        ' 
        ' ExibirServidorDescCbx
        ' 
        ExibirServidorDescCbx.FormattingEnabled = True
        ExibirServidorDescCbx.Location = New Point(5, 90)
        ExibirServidorDescCbx.Name = "ExibirServidorDescCbx"
        ExibirServidorDescCbx.Size = New Size(192, 28)
        ExibirServidorDescCbx.TabIndex = 53
        ' 
        ' Descricao_Coluna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 853)
        Controls.Add(SSSALVOSLbl)
        Controls.Add(ExibirServidorDescCbx)
        Controls.Add(PesquisarInformacaoTxb)
        Controls.Add(PesquisarDescricaotxb)
        Controls.Add(Label2)
        Controls.Add(LimparInformacaoBtn)
        Controls.Add(PesquisarInformacaoBtn)
        Controls.Add(Label1)
        Controls.Add(LimparDescricaoBtn)
        Controls.Add(PesquisarDescricaoBtn)
        Controls.Add(ColunaLbl)
        Controls.Add(LimparColunaBtn)
        Controls.Add(PesquisarColunaBtn)
        Controls.Add(PesquisarcolunaTxb)
        Controls.Add(SelecionarBancoColunas)
        Controls.Add(SelecionarBancoColunasTxb)
        Controls.Add(ConectarBtn)
        Controls.Add(SenhaColunasTxb)
        Controls.Add(NomeConectarColunasTxb)
        Controls.Add(ServidorColunasTxb)
        Controls.Add(SenhaConectarColunasLbl)
        Controls.Add(UsuarioConectarColunasLbl)
        Controls.Add(ServidorConectarColunasLbl)
        Controls.Add(DescricaoColunaLbl)
        Controls.Add(MostarDetalheColunaDGV)
        Controls.Add(SairTabelaColuna)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Descricao_Coluna"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Descricao_Coluna"
        CType(MostarDetalheColunaDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SairTabelaColuna As Button
    Friend WithEvents MostarDetalheColunaDGV As DataGridView
    Friend WithEvents DescricaoColunaLbl As Label
    Friend WithEvents ConectarBtn As Button
    Friend WithEvents SenhaColunasTxb As TextBox
    Friend WithEvents NomeConectarColunasTxb As TextBox
    Friend WithEvents SenhaConectarColunasLbl As Label
    Friend WithEvents UsuarioConectarColunasLbl As Label
    Friend WithEvents ServidorConectarColunasLbl As Label
    Friend WithEvents ServidorColunasTxb As TextBox
    Friend WithEvents SelecionarBancoColunasTxb As ComboBox
    Friend WithEvents SelecionarBancoColunas As Label
    Friend WithEvents PesquisarcolunaTxb As TextBox
    Friend WithEvents LimparColunaBtn As Button
    Friend WithEvents PesquisarColunaBtn As Button
    Friend WithEvents ColunaLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LimparDescricaoBtn As Button
    Friend WithEvents PesquisarDescricaoBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LimparInformacaoBtn As Button
    Friend WithEvents PesquisarInformacaoBtn As Button
    Friend WithEvents PesquisarDescricaotxb As TextBox
    Friend WithEvents PesquisarInformacaoTxb As TextBox
    Friend WithEvents SSSALVOSLbl As Label
    Friend WithEvents ExibirServidorDescCbx As ComboBox
End Class

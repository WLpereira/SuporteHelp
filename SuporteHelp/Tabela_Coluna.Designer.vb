<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabela_Coluna
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Tabela_Coluna))
        SairTabelaColuna = New Button()
        ListadeTabelaDtg = New DataGridView()
        LimparTabelaBtn = New Button()
        PesquisarTabelaBtn = New Button()
        PesquisatabelaTxb = New TextBox()
        PesquisarTabelaColunaLbl = New Label()
        ConectarBtn = New Button()
        SenhaTabelaTxb = New TextBox()
        NomeConectarTabelaTxb = New TextBox()
        ServidorTabelaTxb = New TextBox()
        SenhaConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        ServidorConectarLbl = New Label()
        SelecionarBancoBbx = New ComboBox()
        SelecionarBancoLbl = New Label()
        ListarColunaDvg = New DataGridView()
        LimparColunaBtn = New Button()
        PesquisarColunaBtn = New Button()
        ProcurarColunaTxb = New TextBox()
        ProcurarColunaLbl = New Label()
        MostrarColunasBtn = New Button()
        ListarTodasDgv = New DataGridView()
        LimparTodasBtn = New Button()
        PesquisartodasBtn = New Button()
        PesquisartodasTxb = New TextBox()
        PesquisarColunaNobancoLbl = New Label()
        SelecinarServidorLbl = New Label()
        ExibirServidorTabelaCbx = New ComboBox()
        CType(ListadeTabelaDtg, ComponentModel.ISupportInitialize).BeginInit()
        CType(ListarColunaDvg, ComponentModel.ISupportInitialize).BeginInit()
        CType(ListarTodasDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SairTabelaColuna
        ' 
        SairTabelaColuna.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairTabelaColuna.Image = CType(resources.GetObject("SairTabelaColuna.Image"), Image)
        SairTabelaColuna.ImageAlign = ContentAlignment.MiddleRight
        SairTabelaColuna.Location = New Point(966, 747)
        SairTabelaColuna.Margin = New Padding(3, 4, 3, 4)
        SairTabelaColuna.Name = "SairTabelaColuna"
        SairTabelaColuna.Size = New Size(135, 51)
        SairTabelaColuna.TabIndex = 21
        SairTabelaColuna.Text = "SAIR"
        SairTabelaColuna.TextAlign = ContentAlignment.MiddleLeft
        SairTabelaColuna.UseVisualStyleBackColor = True
        ' 
        ' ListadeTabelaDtg
        ' 
        ListadeTabelaDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeTabelaDtg.Location = New Point(28, 275)
        ListadeTabelaDtg.Margin = New Padding(3, 4, 3, 4)
        ListadeTabelaDtg.Name = "ListadeTabelaDtg"
        ListadeTabelaDtg.ReadOnly = True
        ListadeTabelaDtg.RowHeadersWidth = 51
        ListadeTabelaDtg.RowTemplate.Height = 25
        ListadeTabelaDtg.Size = New Size(280, 452)
        ListadeTabelaDtg.TabIndex = 30
        ' 
        ' LimparTabelaBtn
        ' 
        LimparTabelaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTabelaBtn.Image = CType(resources.GetObject("LimparTabelaBtn.Image"), Image)
        LimparTabelaBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTabelaBtn.Location = New Point(193, 222)
        LimparTabelaBtn.Margin = New Padding(3, 4, 3, 4)
        LimparTabelaBtn.Name = "LimparTabelaBtn"
        LimparTabelaBtn.Size = New Size(115, 45)
        LimparTabelaBtn.TabIndex = 29
        LimparTabelaBtn.Text = "Limpar"
        LimparTabelaBtn.TextAlign = ContentAlignment.MiddleRight
        LimparTabelaBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarTabelaBtn
        ' 
        PesquisarTabelaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabelaBtn.Image = CType(resources.GetObject("PesquisarTabelaBtn.Image"), Image)
        PesquisarTabelaBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarTabelaBtn.Location = New Point(27, 218)
        PesquisarTabelaBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarTabelaBtn.Name = "PesquisarTabelaBtn"
        PesquisarTabelaBtn.Size = New Size(117, 45)
        PesquisarTabelaBtn.TabIndex = 28
        PesquisarTabelaBtn.Text = "Pesquisar"
        PesquisarTabelaBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarTabelaBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisatabelaTxb
        ' 
        PesquisatabelaTxb.Location = New Point(28, 183)
        PesquisatabelaTxb.Margin = New Padding(3, 4, 3, 4)
        PesquisatabelaTxb.Name = "PesquisatabelaTxb"
        PesquisatabelaTxb.Size = New Size(279, 27)
        PesquisatabelaTxb.TabIndex = 27
        ' 
        ' PesquisarTabelaColunaLbl
        ' 
        PesquisarTabelaColunaLbl.AutoSize = True
        PesquisarTabelaColunaLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabelaColunaLbl.Location = New Point(112, 159)
        PesquisarTabelaColunaLbl.Name = "PesquisarTabelaColunaLbl"
        PesquisarTabelaColunaLbl.Size = New Size(125, 20)
        PesquisarTabelaColunaLbl.TabIndex = 26
        PesquisarTabelaColunaLbl.Text = "Pesquisar Tabela"
        ' 
        ' ConectarBtn
        ' 
        ConectarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarBtn.Image = CType(resources.GetObject("ConectarBtn.Image"), Image)
        ConectarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarBtn.Location = New Point(747, 24)
        ConectarBtn.Margin = New Padding(3, 4, 3, 4)
        ConectarBtn.Name = "ConectarBtn"
        ConectarBtn.Size = New Size(111, 37)
        ConectarBtn.TabIndex = 37
        ConectarBtn.Text = "Conectar"
        ConectarBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaTabelaTxb
        ' 
        SenhaTabelaTxb.Location = New Point(538, 31)
        SenhaTabelaTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTabelaTxb.Name = "SenhaTabelaTxb"
        SenhaTabelaTxb.Size = New Size(202, 27)
        SenhaTabelaTxb.TabIndex = 36
        ' 
        ' NomeConectarTabelaTxb
        ' 
        NomeConectarTabelaTxb.Location = New Point(253, 31)
        NomeConectarTabelaTxb.Margin = New Padding(3, 4, 3, 4)
        NomeConectarTabelaTxb.Name = "NomeConectarTabelaTxb"
        NomeConectarTabelaTxb.Size = New Size(278, 27)
        NomeConectarTabelaTxb.TabIndex = 35
        ' 
        ' ServidorTabelaTxb
        ' 
        ServidorTabelaTxb.Location = New Point(23, 31)
        ServidorTabelaTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorTabelaTxb.Name = "ServidorTabelaTxb"
        ServidorTabelaTxb.Size = New Size(222, 27)
        ServidorTabelaTxb.TabIndex = 34
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.ForeColor = Color.Blue
        SenhaConectarLbl.Location = New Point(538, 4)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(51, 20)
        SenhaConectarLbl.TabIndex = 33
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarLbl.ForeColor = Color.Blue
        UsuarioConectarLbl.Location = New Point(253, 4)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(63, 20)
        UsuarioConectarLbl.TabIndex = 32
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarLbl.ForeColor = Color.Red
        ServidorConectarLbl.Location = New Point(23, 4)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(142, 20)
        ServidorConectarLbl.TabIndex = 31
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' SelecionarBancoBbx
        ' 
        SelecionarBancoBbx.FormattingEnabled = True
        SelecionarBancoBbx.Location = New Point(865, 31)
        SelecionarBancoBbx.Margin = New Padding(3, 4, 3, 4)
        SelecionarBancoBbx.Name = "SelecionarBancoBbx"
        SelecionarBancoBbx.Size = New Size(225, 28)
        SelecionarBancoBbx.TabIndex = 38
        ' 
        ' SelecionarBancoLbl
        ' 
        SelecionarBancoLbl.AutoSize = True
        SelecionarBancoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoLbl.Location = New Point(865, 7)
        SelecionarBancoLbl.Name = "SelecionarBancoLbl"
        SelecionarBancoLbl.Size = New Size(127, 20)
        SelecionarBancoLbl.TabIndex = 39
        SelecionarBancoLbl.Text = "Selecionar Banco"
        ' 
        ' ListarColunaDvg
        ' 
        ListarColunaDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListarColunaDvg.Location = New Point(455, 275)
        ListarColunaDvg.Margin = New Padding(3, 4, 3, 4)
        ListarColunaDvg.Name = "ListarColunaDvg"
        ListarColunaDvg.ReadOnly = True
        ListarColunaDvg.RowHeadersWidth = 51
        ListarColunaDvg.RowTemplate.Height = 25
        ListarColunaDvg.Size = New Size(287, 452)
        ListarColunaDvg.TabIndex = 43
        ' 
        ' LimparColunaBtn
        ' 
        LimparColunaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparColunaBtn.Image = CType(resources.GetObject("LimparColunaBtn.Image"), Image)
        LimparColunaBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparColunaBtn.Location = New Point(619, 222)
        LimparColunaBtn.Margin = New Padding(3, 4, 3, 4)
        LimparColunaBtn.Name = "LimparColunaBtn"
        LimparColunaBtn.Size = New Size(115, 45)
        LimparColunaBtn.TabIndex = 42
        LimparColunaBtn.Text = "Limpar"
        LimparColunaBtn.TextAlign = ContentAlignment.MiddleRight
        LimparColunaBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarColunaBtn
        ' 
        PesquisarColunaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarColunaBtn.Image = CType(resources.GetObject("PesquisarColunaBtn.Image"), Image)
        PesquisarColunaBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarColunaBtn.Location = New Point(453, 218)
        PesquisarColunaBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarColunaBtn.Name = "PesquisarColunaBtn"
        PesquisarColunaBtn.Size = New Size(117, 45)
        PesquisarColunaBtn.TabIndex = 41
        PesquisarColunaBtn.Text = "Pesquisar"
        PesquisarColunaBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarColunaBtn.UseVisualStyleBackColor = True
        ' 
        ' ProcurarColunaTxb
        ' 
        ProcurarColunaTxb.Location = New Point(455, 183)
        ProcurarColunaTxb.Margin = New Padding(3, 4, 3, 4)
        ProcurarColunaTxb.Name = "ProcurarColunaTxb"
        ProcurarColunaTxb.Size = New Size(279, 27)
        ProcurarColunaTxb.TabIndex = 40
        ' 
        ' ProcurarColunaLbl
        ' 
        ProcurarColunaLbl.AutoSize = True
        ProcurarColunaLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ProcurarColunaLbl.Location = New Point(541, 159)
        ProcurarColunaLbl.Name = "ProcurarColunaLbl"
        ProcurarColunaLbl.Size = New Size(128, 20)
        ProcurarColunaLbl.TabIndex = 44
        ProcurarColunaLbl.Text = "Pesquisar Coluna"
        ' 
        ' MostrarColunasBtn
        ' 
        MostrarColunasBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarColunasBtn.Image = CType(resources.GetObject("MostrarColunasBtn.Image"), Image)
        MostrarColunasBtn.ImageAlign = ContentAlignment.BottomCenter
        MostrarColunasBtn.Location = New Point(312, 350)
        MostrarColunasBtn.Margin = New Padding(3, 4, 3, 4)
        MostrarColunasBtn.Name = "MostrarColunasBtn"
        MostrarColunasBtn.Size = New Size(137, 90)
        MostrarColunasBtn.TabIndex = 45
        MostrarColunasBtn.Text = "Mostrar Colunas"
        MostrarColunasBtn.TextAlign = ContentAlignment.TopCenter
        MostrarColunasBtn.UseVisualStyleBackColor = True
        ' 
        ' ListarTodasDgv
        ' 
        ListarTodasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListarTodasDgv.Location = New Point(776, 275)
        ListarTodasDgv.Margin = New Padding(3, 4, 3, 4)
        ListarTodasDgv.Name = "ListarTodasDgv"
        ListarTodasDgv.ReadOnly = True
        ListarTodasDgv.RowHeadersWidth = 51
        ListarTodasDgv.RowTemplate.Height = 25
        ListarTodasDgv.Size = New Size(316, 452)
        ListarTodasDgv.TabIndex = 49
        ' 
        ' LimparTodasBtn
        ' 
        LimparTodasBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTodasBtn.Image = CType(resources.GetObject("LimparTodasBtn.Image"), Image)
        LimparTodasBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTodasBtn.Location = New Point(977, 222)
        LimparTodasBtn.Margin = New Padding(3, 4, 3, 4)
        LimparTodasBtn.Name = "LimparTodasBtn"
        LimparTodasBtn.Size = New Size(115, 45)
        LimparTodasBtn.TabIndex = 48
        LimparTodasBtn.Text = "Limpar"
        LimparTodasBtn.TextAlign = ContentAlignment.MiddleRight
        LimparTodasBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisartodasBtn
        ' 
        PesquisartodasBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisartodasBtn.Image = CType(resources.GetObject("PesquisartodasBtn.Image"), Image)
        PesquisartodasBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisartodasBtn.Location = New Point(775, 218)
        PesquisartodasBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisartodasBtn.Name = "PesquisartodasBtn"
        PesquisartodasBtn.Size = New Size(117, 45)
        PesquisartodasBtn.TabIndex = 47
        PesquisartodasBtn.Text = "Pesquisar"
        PesquisartodasBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisartodasBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisartodasTxb
        ' 
        PesquisartodasTxb.Location = New Point(776, 183)
        PesquisartodasTxb.Margin = New Padding(3, 4, 3, 4)
        PesquisartodasTxb.Name = "PesquisartodasTxb"
        PesquisartodasTxb.Size = New Size(316, 27)
        PesquisartodasTxb.TabIndex = 46
        ' 
        ' PesquisarColunaNobancoLbl
        ' 
        PesquisarColunaNobancoLbl.AutoSize = True
        PesquisarColunaNobancoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarColunaNobancoLbl.Location = New Point(793, 158)
        PesquisarColunaNobancoLbl.Name = "PesquisarColunaNobancoLbl"
        PesquisarColunaNobancoLbl.Size = New Size(273, 20)
        PesquisarColunaNobancoLbl.TabIndex = 50
        PesquisarColunaNobancoLbl.Text = "Pesquisar coluna em TODAS TABELAS"
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(25, 62)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(221, 23)
        SelecinarServidorLbl.TabIndex = 52
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorTabelaCbx
        ' 
        ExibirServidorTabelaCbx.FormattingEnabled = True
        ExibirServidorTabelaCbx.Location = New Point(25, 88)
        ExibirServidorTabelaCbx.Name = "ExibirServidorTabelaCbx"
        ExibirServidorTabelaCbx.Size = New Size(221, 28)
        ExibirServidorTabelaCbx.TabIndex = 51
        ' 
        ' Tabela_Coluna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1128, 799)
        Controls.Add(SelecinarServidorLbl)
        Controls.Add(ExibirServidorTabelaCbx)
        Controls.Add(PesquisarColunaNobancoLbl)
        Controls.Add(ListarTodasDgv)
        Controls.Add(LimparTodasBtn)
        Controls.Add(PesquisartodasBtn)
        Controls.Add(PesquisartodasTxb)
        Controls.Add(MostrarColunasBtn)
        Controls.Add(ProcurarColunaLbl)
        Controls.Add(ListarColunaDvg)
        Controls.Add(LimparColunaBtn)
        Controls.Add(PesquisarColunaBtn)
        Controls.Add(ProcurarColunaTxb)
        Controls.Add(SelecionarBancoLbl)
        Controls.Add(SelecionarBancoBbx)
        Controls.Add(ConectarBtn)
        Controls.Add(SenhaTabelaTxb)
        Controls.Add(NomeConectarTabelaTxb)
        Controls.Add(ServidorTabelaTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioConectarLbl)
        Controls.Add(ServidorConectarLbl)
        Controls.Add(ListadeTabelaDtg)
        Controls.Add(LimparTabelaBtn)
        Controls.Add(PesquisarTabelaBtn)
        Controls.Add(PesquisatabelaTxb)
        Controls.Add(PesquisarTabelaColunaLbl)
        Controls.Add(SairTabelaColuna)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Tabela_Coluna"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tabela_Coluna"
        CType(ListadeTabelaDtg, ComponentModel.ISupportInitialize).EndInit()
        CType(ListarColunaDvg, ComponentModel.ISupportInitialize).EndInit()
        CType(ListarTodasDgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SairTabelaColuna As Button
    Friend WithEvents ListadeTabelaDtg As DataGridView
    Friend WithEvents LimparTabelaBtn As Button
    Friend WithEvents PesquisarTabelaBtn As Button
    Friend WithEvents PesquisatabelaTxb As TextBox
    Friend WithEvents PesquisarTabelaColunaLbl As Label
    Friend WithEvents ConectarBtn As Button
    Friend WithEvents SenhaTabelaTxb As TextBox
    Friend WithEvents NomeConectarTabelaTxb As TextBox
    Friend WithEvents ServidorTabelaTxb As TextBox
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents UsuarioConectarLbl As Label
    Friend WithEvents ServidorConectarLbl As Label
    Friend WithEvents SelecionarBancoBbx As ComboBox
    Friend WithEvents SelecionarBancoLbl As Label
    Friend WithEvents ListarColunaDvg As DataGridView
    Friend WithEvents LimparColunaBtn As Button
    Friend WithEvents PesquisarColunaBtn As Button
    Friend WithEvents ProcurarColunaTxb As TextBox
    Friend WithEvents ProcurarColunaLbl As Label
    Friend WithEvents MostrarColunasBtn As Button
    Friend WithEvents ListarTodasDgv As DataGridView
    Friend WithEvents LimparTodasBtn As Button
    Friend WithEvents PesquisartodasBtn As Button
    Friend WithEvents PesquisartodasTxb As TextBox
    Friend WithEvents PesquisarColunaNobancoLbl As Label
    Friend WithEvents SelecinarServidorLbl As Label
    Friend WithEvents ExibirServidorTabelaCbx As ComboBox
End Class

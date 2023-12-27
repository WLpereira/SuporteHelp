<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comparar_Tabelas
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Comparar_Tabelas))
        SelecinarServidorCompararLbl = New Label()
        ExibirServidorTabelaCompararCbx = New ComboBox()
        SelecionarBancoCompararLbl = New Label()
        SelecionarBancoCompararBbx = New ComboBox()
        ConectarCompararBtn = New Button()
        SenhaTabelaCompararTxb = New TextBox()
        NomeConectarTabelaCompararTxb = New TextBox()
        ServidorTabelaCompararTxb = New TextBox()
        SenhaConectarCompararLbl = New Label()
        UsuarioConectarCompararLbl = New Label()
        ServidorConectarCompararLbl = New Label()
        ListadeTabela1Dtg = New DataGridView()
        LimparTabela1Btn = New Button()
        PesquisarTabela1Btn = New Button()
        Pesquisatabela1Txb = New TextBox()
        PesquisarTabela1Lbl = New Label()
        ListadeTabela2Dtg = New DataGridView()
        LimparTabela2Btn = New Button()
        PesquisarTabela2Btn = New Button()
        Pesquisatabela2Txb = New TextBox()
        PesquisarTabela2Lbl = New Label()
        CompararBtn = New Button()
        ResultadoDgv = New DataGridView()
        DataGridView1 = New DataGridView()
        CType(ListadeTabela1Dtg, ComponentModel.ISupportInitialize).BeginInit()
        CType(ListadeTabela2Dtg, ComponentModel.ISupportInitialize).BeginInit()
        CType(ResultadoDgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SelecinarServidorCompararLbl
        ' 
        SelecinarServidorCompararLbl.AutoSize = True
        SelecinarServidorCompararLbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        SelecinarServidorCompararLbl.ForeColor = Color.Red
        SelecinarServidorCompararLbl.Location = New Point(20, 77)
        SelecinarServidorCompararLbl.Name = "SelecinarServidorCompararLbl"
        SelecinarServidorCompararLbl.Size = New Size(221, 23)
        SelecinarServidorCompararLbl.TabIndex = 63
        SelecinarServidorCompararLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorTabelaCompararCbx
        ' 
        ExibirServidorTabelaCompararCbx.FormattingEnabled = True
        ExibirServidorTabelaCompararCbx.Location = New Point(20, 103)
        ExibirServidorTabelaCompararCbx.Name = "ExibirServidorTabelaCompararCbx"
        ExibirServidorTabelaCompararCbx.Size = New Size(221, 28)
        ExibirServidorTabelaCompararCbx.TabIndex = 62
        ' 
        ' SelecionarBancoCompararLbl
        ' 
        SelecionarBancoCompararLbl.AutoSize = True
        SelecionarBancoCompararLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoCompararLbl.Location = New Point(860, 22)
        SelecionarBancoCompararLbl.Name = "SelecionarBancoCompararLbl"
        SelecionarBancoCompararLbl.Size = New Size(127, 20)
        SelecionarBancoCompararLbl.TabIndex = 61
        SelecionarBancoCompararLbl.Text = "Selecionar Banco"
        ' 
        ' SelecionarBancoCompararBbx
        ' 
        SelecionarBancoCompararBbx.FormattingEnabled = True
        SelecionarBancoCompararBbx.Location = New Point(860, 46)
        SelecionarBancoCompararBbx.Margin = New Padding(3, 4, 3, 4)
        SelecionarBancoCompararBbx.Name = "SelecionarBancoCompararBbx"
        SelecionarBancoCompararBbx.Size = New Size(225, 28)
        SelecionarBancoCompararBbx.TabIndex = 60
        ' 
        ' ConectarCompararBtn
        ' 
        ConectarCompararBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarCompararBtn.Image = CType(resources.GetObject("ConectarCompararBtn.Image"), Image)
        ConectarCompararBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarCompararBtn.Location = New Point(742, 39)
        ConectarCompararBtn.Margin = New Padding(3, 4, 3, 4)
        ConectarCompararBtn.Name = "ConectarCompararBtn"
        ConectarCompararBtn.Size = New Size(111, 37)
        ConectarCompararBtn.TabIndex = 59
        ConectarCompararBtn.Text = "Conectar"
        ConectarCompararBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarCompararBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaTabelaCompararTxb
        ' 
        SenhaTabelaCompararTxb.Location = New Point(533, 46)
        SenhaTabelaCompararTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTabelaCompararTxb.Name = "SenhaTabelaCompararTxb"
        SenhaTabelaCompararTxb.Size = New Size(202, 27)
        SenhaTabelaCompararTxb.TabIndex = 58
        ' 
        ' NomeConectarTabelaCompararTxb
        ' 
        NomeConectarTabelaCompararTxb.Location = New Point(248, 46)
        NomeConectarTabelaCompararTxb.Margin = New Padding(3, 4, 3, 4)
        NomeConectarTabelaCompararTxb.Name = "NomeConectarTabelaCompararTxb"
        NomeConectarTabelaCompararTxb.Size = New Size(278, 27)
        NomeConectarTabelaCompararTxb.TabIndex = 57
        ' 
        ' ServidorTabelaCompararTxb
        ' 
        ServidorTabelaCompararTxb.Location = New Point(18, 46)
        ServidorTabelaCompararTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorTabelaCompararTxb.Name = "ServidorTabelaCompararTxb"
        ServidorTabelaCompararTxb.Size = New Size(222, 27)
        ServidorTabelaCompararTxb.TabIndex = 56
        ' 
        ' SenhaConectarCompararLbl
        ' 
        SenhaConectarCompararLbl.AutoSize = True
        SenhaConectarCompararLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarCompararLbl.ForeColor = Color.Blue
        SenhaConectarCompararLbl.Location = New Point(533, 19)
        SenhaConectarCompararLbl.Name = "SenhaConectarCompararLbl"
        SenhaConectarCompararLbl.Size = New Size(51, 20)
        SenhaConectarCompararLbl.TabIndex = 55
        SenhaConectarCompararLbl.Text = "Senha"
        ' 
        ' UsuarioConectarCompararLbl
        ' 
        UsuarioConectarCompararLbl.AutoSize = True
        UsuarioConectarCompararLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioConectarCompararLbl.ForeColor = Color.Blue
        UsuarioConectarCompararLbl.Location = New Point(248, 19)
        UsuarioConectarCompararLbl.Name = "UsuarioConectarCompararLbl"
        UsuarioConectarCompararLbl.Size = New Size(63, 20)
        UsuarioConectarCompararLbl.TabIndex = 54
        UsuarioConectarCompararLbl.Text = "Usuario"
        ' 
        ' ServidorConectarCompararLbl
        ' 
        ServidorConectarCompararLbl.AutoSize = True
        ServidorConectarCompararLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorConectarCompararLbl.ForeColor = Color.Red
        ServidorConectarCompararLbl.Location = New Point(18, 19)
        ServidorConectarCompararLbl.Name = "ServidorConectarCompararLbl"
        ServidorConectarCompararLbl.Size = New Size(142, 20)
        ServidorConectarCompararLbl.TabIndex = 53
        ServidorConectarCompararLbl.Text = "Informe o Servidor"
        ' 
        ' ListadeTabela1Dtg
        ' 
        ListadeTabela1Dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeTabela1Dtg.Location = New Point(12, 338)
        ListadeTabela1Dtg.Margin = New Padding(3, 4, 3, 4)
        ListadeTabela1Dtg.Name = "ListadeTabela1Dtg"
        ListadeTabela1Dtg.ReadOnly = True
        ListadeTabela1Dtg.RowHeadersWidth = 51
        ListadeTabela1Dtg.RowTemplate.Height = 25
        ListadeTabela1Dtg.Size = New Size(184, 452)
        ListadeTabela1Dtg.TabIndex = 68
        ' 
        ' LimparTabela1Btn
        ' 
        LimparTabela1Btn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTabela1Btn.Image = CType(resources.GetObject("LimparTabela1Btn.Image"), Image)
        LimparTabela1Btn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTabela1Btn.Location = New Point(40, 291)
        LimparTabela1Btn.Margin = New Padding(3, 4, 3, 4)
        LimparTabela1Btn.Name = "LimparTabela1Btn"
        LimparTabela1Btn.Size = New Size(120, 39)
        LimparTabela1Btn.TabIndex = 67
        LimparTabela1Btn.Text = "Limpar"
        LimparTabela1Btn.TextAlign = ContentAlignment.MiddleRight
        LimparTabela1Btn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarTabela1Btn
        ' 
        PesquisarTabela1Btn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabela1Btn.Image = CType(resources.GetObject("PesquisarTabela1Btn.Image"), Image)
        PesquisarTabela1Btn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarTabela1Btn.Location = New Point(38, 232)
        PesquisarTabela1Btn.Margin = New Padding(3, 4, 3, 4)
        PesquisarTabela1Btn.Name = "PesquisarTabela1Btn"
        PesquisarTabela1Btn.Size = New Size(122, 45)
        PesquisarTabela1Btn.TabIndex = 66
        PesquisarTabela1Btn.Text = "Pesquisar"
        PesquisarTabela1Btn.TextAlign = ContentAlignment.MiddleRight
        PesquisarTabela1Btn.UseVisualStyleBackColor = True
        ' 
        ' Pesquisatabela1Txb
        ' 
        Pesquisatabela1Txb.Location = New Point(12, 193)
        Pesquisatabela1Txb.Margin = New Padding(3, 4, 3, 4)
        Pesquisatabela1Txb.Name = "Pesquisatabela1Txb"
        Pesquisatabela1Txb.Size = New Size(191, 27)
        Pesquisatabela1Txb.TabIndex = 65
        ' 
        ' PesquisarTabela1Lbl
        ' 
        PesquisarTabela1Lbl.AutoSize = True
        PesquisarTabela1Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabela1Lbl.Location = New Point(20, 164)
        PesquisarTabela1Lbl.Name = "PesquisarTabela1Lbl"
        PesquisarTabela1Lbl.Size = New Size(167, 25)
        PesquisarTabela1Lbl.TabIndex = 64
        PesquisarTabela1Lbl.Text = "Pesquisar Tabela 1"
        ' 
        ' ListadeTabela2Dtg
        ' 
        ListadeTabela2Dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeTabela2Dtg.Location = New Point(248, 338)
        ListadeTabela2Dtg.Margin = New Padding(3, 4, 3, 4)
        ListadeTabela2Dtg.Name = "ListadeTabela2Dtg"
        ListadeTabela2Dtg.ReadOnly = True
        ListadeTabela2Dtg.RowHeadersWidth = 51
        ListadeTabela2Dtg.RowTemplate.Height = 25
        ListadeTabela2Dtg.Size = New Size(185, 452)
        ListadeTabela2Dtg.TabIndex = 73
        ' 
        ' LimparTabela2Btn
        ' 
        LimparTabela2Btn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTabela2Btn.Image = CType(resources.GetObject("LimparTabela2Btn.Image"), Image)
        LimparTabela2Btn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTabela2Btn.Location = New Point(280, 285)
        LimparTabela2Btn.Margin = New Padding(3, 4, 3, 4)
        LimparTabela2Btn.Name = "LimparTabela2Btn"
        LimparTabela2Btn.Size = New Size(115, 45)
        LimparTabela2Btn.TabIndex = 72
        LimparTabela2Btn.Text = "Limpar"
        LimparTabela2Btn.TextAlign = ContentAlignment.MiddleRight
        LimparTabela2Btn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarTabela2Btn
        ' 
        PesquisarTabela2Btn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabela2Btn.Image = CType(resources.GetObject("PesquisarTabela2Btn.Image"), Image)
        PesquisarTabela2Btn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarTabela2Btn.Location = New Point(280, 232)
        PesquisarTabela2Btn.Margin = New Padding(3, 4, 3, 4)
        PesquisarTabela2Btn.Name = "PesquisarTabela2Btn"
        PesquisarTabela2Btn.Size = New Size(117, 45)
        PesquisarTabela2Btn.TabIndex = 71
        PesquisarTabela2Btn.Text = "Pesquisar"
        PesquisarTabela2Btn.TextAlign = ContentAlignment.MiddleRight
        PesquisarTabela2Btn.UseVisualStyleBackColor = True
        ' 
        ' Pesquisatabela2Txb
        ' 
        Pesquisatabela2Txb.Location = New Point(248, 193)
        Pesquisatabela2Txb.Margin = New Padding(3, 4, 3, 4)
        Pesquisatabela2Txb.Name = "Pesquisatabela2Txb"
        Pesquisatabela2Txb.Size = New Size(191, 27)
        Pesquisatabela2Txb.TabIndex = 70
        ' 
        ' PesquisarTabela2Lbl
        ' 
        PesquisarTabela2Lbl.AutoSize = True
        PesquisarTabela2Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabela2Lbl.Location = New Point(266, 164)
        PesquisarTabela2Lbl.Name = "PesquisarTabela2Lbl"
        PesquisarTabela2Lbl.Size = New Size(167, 25)
        PesquisarTabela2Lbl.TabIndex = 69
        PesquisarTabela2Lbl.Text = "Pesquisar Tabela 2"
        ' 
        ' CompararBtn
        ' 
        CompararBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CompararBtn.ImageAlign = ContentAlignment.MiddleLeft
        CompararBtn.Location = New Point(439, 490)
        CompararBtn.Margin = New Padding(3, 4, 3, 4)
        CompararBtn.Name = "CompararBtn"
        CompararBtn.Size = New Size(131, 101)
        CompararBtn.TabIndex = 74
        CompararBtn.Text = "Comparar"
        CompararBtn.TextAlign = ContentAlignment.MiddleRight
        CompararBtn.UseVisualStyleBackColor = True
        ' 
        ' ResultadoDgv
        ' 
        ResultadoDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadoDgv.Location = New Point(598, 232)
        ResultadoDgv.Margin = New Padding(3, 4, 3, 4)
        ResultadoDgv.Name = "ResultadoDgv"
        ResultadoDgv.ReadOnly = True
        ResultadoDgv.RowHeadersWidth = 51
        ResultadoDgv.RowTemplate.Height = 25
        ResultadoDgv.Size = New Size(229, 558)
        ResultadoDgv.TabIndex = 75
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(860, 232)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(229, 558)
        DataGridView1.TabIndex = 76
        ' 
        ' Comparar_Tabelas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1132, 803)
        Controls.Add(DataGridView1)
        Controls.Add(ResultadoDgv)
        Controls.Add(CompararBtn)
        Controls.Add(ListadeTabela2Dtg)
        Controls.Add(LimparTabela2Btn)
        Controls.Add(PesquisarTabela2Btn)
        Controls.Add(Pesquisatabela2Txb)
        Controls.Add(PesquisarTabela2Lbl)
        Controls.Add(ListadeTabela1Dtg)
        Controls.Add(LimparTabela1Btn)
        Controls.Add(PesquisarTabela1Btn)
        Controls.Add(Pesquisatabela1Txb)
        Controls.Add(PesquisarTabela1Lbl)
        Controls.Add(SelecinarServidorCompararLbl)
        Controls.Add(ExibirServidorTabelaCompararCbx)
        Controls.Add(SelecionarBancoCompararLbl)
        Controls.Add(SelecionarBancoCompararBbx)
        Controls.Add(ConectarCompararBtn)
        Controls.Add(SenhaTabelaCompararTxb)
        Controls.Add(NomeConectarTabelaCompararTxb)
        Controls.Add(ServidorTabelaCompararTxb)
        Controls.Add(SenhaConectarCompararLbl)
        Controls.Add(UsuarioConectarCompararLbl)
        Controls.Add(ServidorConectarCompararLbl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "Comparar_Tabelas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Comparar_Tabelas"
        CType(ListadeTabela1Dtg, ComponentModel.ISupportInitialize).EndInit()
        CType(ListadeTabela2Dtg, ComponentModel.ISupportInitialize).EndInit()
        CType(ResultadoDgv, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SelecinarServidorCompararLbl As Label
    Friend WithEvents ExibirServidorTabelaCompararCbx As ComboBox
    Friend WithEvents SelecionarBancoCompararLbl As Label
    Friend WithEvents SelecionarBancoCompararBbx As ComboBox
    Friend WithEvents ConectarCompararBtn As Button
    Friend WithEvents SenhaTabelaCompararTxb As TextBox
    Friend WithEvents NomeConectarTabelaCompararTxb As TextBox
    Friend WithEvents ServidorTabelaCompararTxb As TextBox
    Friend WithEvents SenhaConectarCompararLbl As Label
    Friend WithEvents UsuarioConectarCompararLbl As Label
    Friend WithEvents ServidorConectarCompararLbl As Label
    Friend WithEvents ListadeTabela1Dtg As DataGridView
    Friend WithEvents LimparTabela1Btn As Button
    Friend WithEvents PesquisarTabela1Btn As Button
    Friend WithEvents Pesquisatabela1Txb As TextBox
    Friend WithEvents PesquisarTabela1Lbl As Label
    Friend WithEvents ListadeTabela2Dtg As DataGridView
    Friend WithEvents LimparTabela2Btn As Button
    Friend WithEvents PesquisarTabela2Btn As Button
    Friend WithEvents Pesquisatabela2Txb As TextBox
    Friend WithEvents PesquisarTabela2Lbl As Label
    Friend WithEvents CompararBtn As Button
    Friend WithEvents ResultadoDgv As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
End Class

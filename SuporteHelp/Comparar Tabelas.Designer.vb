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
        ListarTabelasCompararDtg = New DataGridView()
        LimparTabelaCompararBtn = New Button()
        PesquisarTabelaCompararBtn = New Button()
        PesquisatabelaCompararTxb = New TextBox()
        PesquisarTabelaColunaLbl = New Label()
        ResultadoComprarDtg = New DataGridView()
        LimparSelecaoBtn = New Button()
        CType(ListarTabelasCompararDtg, ComponentModel.ISupportInitialize).BeginInit()
        CType(ResultadoComprarDtg, ComponentModel.ISupportInitialize).BeginInit()
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
        ' ListarTabelasCompararDtg
        ' 
        ListarTabelasCompararDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListarTabelasCompararDtg.Location = New Point(12, 276)
        ListarTabelasCompararDtg.Margin = New Padding(3, 4, 3, 4)
        ListarTabelasCompararDtg.Name = "ListarTabelasCompararDtg"
        ListarTabelasCompararDtg.ReadOnly = True
        ListarTabelasCompararDtg.RowHeadersWidth = 51
        ListarTabelasCompararDtg.RowTemplate.Height = 25
        ListarTabelasCompararDtg.Size = New Size(280, 452)
        ListarTabelasCompararDtg.TabIndex = 68
        ' 
        ' LimparTabelaCompararBtn
        ' 
        LimparTabelaCompararBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTabelaCompararBtn.Image = CType(resources.GetObject("LimparTabelaCompararBtn.Image"), Image)
        LimparTabelaCompararBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTabelaCompararBtn.Location = New Point(177, 223)
        LimparTabelaCompararBtn.Margin = New Padding(3, 4, 3, 4)
        LimparTabelaCompararBtn.Name = "LimparTabelaCompararBtn"
        LimparTabelaCompararBtn.Size = New Size(115, 45)
        LimparTabelaCompararBtn.TabIndex = 67
        LimparTabelaCompararBtn.Text = "Limpar"
        LimparTabelaCompararBtn.TextAlign = ContentAlignment.MiddleRight
        LimparTabelaCompararBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisarTabelaCompararBtn
        ' 
        PesquisarTabelaCompararBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabelaCompararBtn.Image = CType(resources.GetObject("PesquisarTabelaCompararBtn.Image"), Image)
        PesquisarTabelaCompararBtn.ImageAlign = ContentAlignment.MiddleLeft
        PesquisarTabelaCompararBtn.Location = New Point(11, 219)
        PesquisarTabelaCompararBtn.Margin = New Padding(3, 4, 3, 4)
        PesquisarTabelaCompararBtn.Name = "PesquisarTabelaCompararBtn"
        PesquisarTabelaCompararBtn.Size = New Size(117, 45)
        PesquisarTabelaCompararBtn.TabIndex = 66
        PesquisarTabelaCompararBtn.Text = "Pesquisar"
        PesquisarTabelaCompararBtn.TextAlign = ContentAlignment.MiddleRight
        PesquisarTabelaCompararBtn.UseVisualStyleBackColor = True
        ' 
        ' PesquisatabelaCompararTxb
        ' 
        PesquisatabelaCompararTxb.Location = New Point(12, 184)
        PesquisatabelaCompararTxb.Margin = New Padding(3, 4, 3, 4)
        PesquisatabelaCompararTxb.Name = "PesquisatabelaCompararTxb"
        PesquisatabelaCompararTxb.Size = New Size(279, 27)
        PesquisatabelaCompararTxb.TabIndex = 65
        ' 
        ' PesquisarTabelaColunaLbl
        ' 
        PesquisarTabelaColunaLbl.AutoSize = True
        PesquisarTabelaColunaLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PesquisarTabelaColunaLbl.Location = New Point(85, 160)
        PesquisarTabelaColunaLbl.Name = "PesquisarTabelaColunaLbl"
        PesquisarTabelaColunaLbl.Size = New Size(125, 20)
        PesquisarTabelaColunaLbl.TabIndex = 64
        PesquisarTabelaColunaLbl.Text = "Pesquisar Tabela"
        ' 
        ' ResultadoComprarDtg
        ' 
        ResultadoComprarDtg.AllowUserToOrderColumns = True
        ResultadoComprarDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadoComprarDtg.Location = New Point(573, 276)
        ResultadoComprarDtg.Margin = New Padding(3, 4, 3, 4)
        ResultadoComprarDtg.Name = "ResultadoComprarDtg"
        ResultadoComprarDtg.ReadOnly = True
        ResultadoComprarDtg.RowHeadersWidth = 51
        ResultadoComprarDtg.RowTemplate.Height = 25
        ResultadoComprarDtg.Size = New Size(280, 452)
        ResultadoComprarDtg.TabIndex = 70
        ' 
        ' LimparSelecaoBtn
        ' 
        LimparSelecaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparSelecaoBtn.Image = CType(resources.GetObject("LimparSelecaoBtn.Image"), Image)
        LimparSelecaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparSelecaoBtn.Location = New Point(381, 397)
        LimparSelecaoBtn.Margin = New Padding(3, 4, 3, 4)
        LimparSelecaoBtn.Name = "LimparSelecaoBtn"
        LimparSelecaoBtn.Size = New Size(115, 72)
        LimparSelecaoBtn.TabIndex = 71
        LimparSelecaoBtn.Text = "Limpar"
        LimparSelecaoBtn.TextAlign = ContentAlignment.MiddleRight
        LimparSelecaoBtn.UseVisualStyleBackColor = True
        ' 
        ' Comparar_Tabelas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1132, 803)
        Controls.Add(LimparSelecaoBtn)
        Controls.Add(ResultadoComprarDtg)
        Controls.Add(ListarTabelasCompararDtg)
        Controls.Add(LimparTabelaCompararBtn)
        Controls.Add(PesquisarTabelaCompararBtn)
        Controls.Add(PesquisatabelaCompararTxb)
        Controls.Add(PesquisarTabelaColunaLbl)
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
        CType(ListarTabelasCompararDtg, ComponentModel.ISupportInitialize).EndInit()
        CType(ResultadoComprarDtg, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListarTabelasCompararDtg As DataGridView
    Friend WithEvents LimparTabelaCompararBtn As Button
    Friend WithEvents PesquisarTabelaCompararBtn As Button
    Friend WithEvents PesquisatabelaCompararTxb As TextBox
    Friend WithEvents PesquisarTabelaColunaLbl As Label
    Friend WithEvents ResultadoComprarDtg As DataGridView
    Friend WithEvents LimparSelecaoBtn As Button
End Class

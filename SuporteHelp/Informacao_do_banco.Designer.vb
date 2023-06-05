<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informação_do_banco
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Informação_do_banco))
        ConectarInformacaoBtn = New Button()
        SenhaInformacaoTxb = New TextBox()
        NomeInformacaoTxb = New TextBox()
        ServidorInformacaoTxb = New TextBox()
        SenhaInformacaoLbl = New Label()
        UsuarioInformacaoLbl = New Label()
        ServidorInformacaoLbl = New Label()
        MostrarCaminhoTxb = New TextBox()
        MostrarCaminhoBtn = New Button()
        SelecionarBancoInformacaoCbx = New ComboBox()
        MostrarinformacaoBtn = New Button()
        ResultadoDgv = New DataGridView()
        NomeBancoTxb = New TextBox()
        SairInformacaoBancoBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        MostrarTodosBtn = New Button()
        ExibirServidorIfoCbx = New ComboBox()
        SSSALVOSLbl = New Label()
        CType(ResultadoDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConectarInformacaoBtn
        ' 
        ConectarInformacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarInformacaoBtn.Image = CType(resources.GetObject("ConectarInformacaoBtn.Image"), Image)
        ConectarInformacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarInformacaoBtn.Location = New Point(668, 13)
        ConectarInformacaoBtn.Name = "ConectarInformacaoBtn"
        ConectarInformacaoBtn.Size = New Size(118, 38)
        ConectarInformacaoBtn.TabIndex = 40
        ConectarInformacaoBtn.Text = "Conectar"
        ConectarInformacaoBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarInformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaInformacaoTxb
        ' 
        SenhaInformacaoTxb.Location = New Point(468, 24)
        SenhaInformacaoTxb.Name = "SenhaInformacaoTxb"
        SenhaInformacaoTxb.Size = New Size(177, 27)
        SenhaInformacaoTxb.TabIndex = 39
        ' 
        ' NomeInformacaoTxb
        ' 
        NomeInformacaoTxb.Location = New Point(218, 24)
        NomeInformacaoTxb.Name = "NomeInformacaoTxb"
        NomeInformacaoTxb.Size = New Size(244, 27)
        NomeInformacaoTxb.TabIndex = 38
        ' 
        ' ServidorInformacaoTxb
        ' 
        ServidorInformacaoTxb.Location = New Point(17, 24)
        ServidorInformacaoTxb.Name = "ServidorInformacaoTxb"
        ServidorInformacaoTxb.Size = New Size(195, 27)
        ServidorInformacaoTxb.TabIndex = 37
        ' 
        ' SenhaInformacaoLbl
        ' 
        SenhaInformacaoLbl.AutoSize = True
        SenhaInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaInformacaoLbl.Location = New Point(468, 4)
        SenhaInformacaoLbl.Name = "SenhaInformacaoLbl"
        SenhaInformacaoLbl.Size = New Size(51, 20)
        SenhaInformacaoLbl.TabIndex = 36
        SenhaInformacaoLbl.Text = "Senha"
        ' 
        ' UsuarioInformacaoLbl
        ' 
        UsuarioInformacaoLbl.AutoSize = True
        UsuarioInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioInformacaoLbl.Location = New Point(218, 4)
        UsuarioInformacaoLbl.Name = "UsuarioInformacaoLbl"
        UsuarioInformacaoLbl.Size = New Size(63, 20)
        UsuarioInformacaoLbl.TabIndex = 35
        UsuarioInformacaoLbl.Text = "Usuario"
        ' 
        ' ServidorInformacaoLbl
        ' 
        ServidorInformacaoLbl.AutoSize = True
        ServidorInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorInformacaoLbl.Location = New Point(17, 4)
        ServidorInformacaoLbl.Name = "ServidorInformacaoLbl"
        ServidorInformacaoLbl.Size = New Size(142, 20)
        ServidorInformacaoLbl.TabIndex = 34
        ServidorInformacaoLbl.Text = "Informe o Servidor"
        ' 
        ' MostrarCaminhoTxb
        ' 
        MostrarCaminhoTxb.Location = New Point(132, 162)
        MostrarCaminhoTxb.Name = "MostrarCaminhoTxb"
        MostrarCaminhoTxb.Size = New Size(452, 27)
        MostrarCaminhoTxb.TabIndex = 41
        ' 
        ' MostrarCaminhoBtn
        ' 
        MostrarCaminhoBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarCaminhoBtn.Location = New Point(631, 159)
        MostrarCaminhoBtn.Name = "MostrarCaminhoBtn"
        MostrarCaminhoBtn.Size = New Size(169, 37)
        MostrarCaminhoBtn.TabIndex = 42
        MostrarCaminhoBtn.Text = "Buscar Caminho"
        MostrarCaminhoBtn.UseVisualStyleBackColor = True
        ' 
        ' SelecionarBancoInformacaoCbx
        ' 
        SelecionarBancoInformacaoCbx.FormattingEnabled = True
        SelecionarBancoInformacaoCbx.Location = New Point(812, 20)
        SelecionarBancoInformacaoCbx.Name = "SelecionarBancoInformacaoCbx"
        SelecionarBancoInformacaoCbx.Size = New Size(156, 28)
        SelecionarBancoInformacaoCbx.TabIndex = 43
        ' 
        ' MostrarinformacaoBtn
        ' 
        MostrarinformacaoBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarinformacaoBtn.Location = New Point(287, 235)
        MostrarinformacaoBtn.Name = "MostrarinformacaoBtn"
        MostrarinformacaoBtn.Size = New Size(140, 41)
        MostrarinformacaoBtn.TabIndex = 44
        MostrarinformacaoBtn.Text = "Mostrar"
        MostrarinformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' ResultadoDgv
        ' 
        ResultadoDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadoDgv.Location = New Point(12, 288)
        ResultadoDgv.Name = "ResultadoDgv"
        ResultadoDgv.RowHeadersWidth = 51
        ResultadoDgv.RowTemplate.Height = 29
        ResultadoDgv.Size = New Size(958, 296)
        ResultadoDgv.TabIndex = 45
        ' 
        ' NomeBancoTxb
        ' 
        NomeBancoTxb.Location = New Point(40, 243)
        NomeBancoTxb.Name = "NomeBancoTxb"
        NomeBancoTxb.Size = New Size(207, 27)
        NomeBancoTxb.TabIndex = 46
        ' 
        ' SairInformacaoBancoBtn
        ' 
        SairInformacaoBancoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairInformacaoBancoBtn.Image = CType(resources.GetObject("SairInformacaoBancoBtn.Image"), Image)
        SairInformacaoBancoBtn.ImageAlign = ContentAlignment.MiddleRight
        SairInformacaoBancoBtn.Location = New Point(837, 606)
        SairInformacaoBancoBtn.Name = "SairInformacaoBancoBtn"
        SairInformacaoBancoBtn.Size = New Size(118, 38)
        SairInformacaoBancoBtn.TabIndex = 47
        SairInformacaoBancoBtn.Text = "SAIR"
        SairInformacaoBancoBtn.TextAlign = ContentAlignment.MiddleLeft
        SairInformacaoBancoBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(76, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 20)
        Label1.TabIndex = 48
        Label1.Text = "Buscar por Nome "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(219, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(314, 20)
        Label2.TabIndex = 49
        Label2.Text = "Necessario buscar o caminho que o log está"
        ' 
        ' MostrarTodosBtn
        ' 
        MostrarTodosBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarTodosBtn.Location = New Point(599, 235)
        MostrarTodosBtn.Name = "MostrarTodosBtn"
        MostrarTodosBtn.Size = New Size(283, 41)
        MostrarTodosBtn.TabIndex = 50
        MostrarTodosBtn.Text = "Mostrar Todos "
        MostrarTodosBtn.UseVisualStyleBackColor = True
        ' 
        ' ExibirServidorIfoCbx
        ' 
        ExibirServidorIfoCbx.FormattingEnabled = True
        ExibirServidorIfoCbx.Location = New Point(20, 80)
        ExibirServidorIfoCbx.Name = "ExibirServidorIfoCbx"
        ExibirServidorIfoCbx.Size = New Size(192, 28)
        ExibirServidorIfoCbx.TabIndex = 51
        ' 
        ' SSSALVOSLbl
        ' 
        SSSALVOSLbl.AutoSize = True
        SSSALVOSLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SSSALVOSLbl.Location = New Point(7, 56)
        SSSALVOSLbl.Name = "SSSALVOSLbl"
        SSSALVOSLbl.Size = New Size(239, 20)
        SSSALVOSLbl.TabIndex = 52
        SSSALVOSLbl.Text = "SELECIONAR SERVIDOR SALVOS "
        ' 
        ' Informação_do_banco
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 653)
        Controls.Add(SSSALVOSLbl)
        Controls.Add(ExibirServidorIfoCbx)
        Controls.Add(MostrarTodosBtn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SairInformacaoBancoBtn)
        Controls.Add(NomeBancoTxb)
        Controls.Add(ResultadoDgv)
        Controls.Add(MostrarinformacaoBtn)
        Controls.Add(SelecionarBancoInformacaoCbx)
        Controls.Add(MostrarCaminhoBtn)
        Controls.Add(MostrarCaminhoTxb)
        Controls.Add(ConectarInformacaoBtn)
        Controls.Add(SenhaInformacaoTxb)
        Controls.Add(NomeInformacaoTxb)
        Controls.Add(ServidorInformacaoTxb)
        Controls.Add(SenhaInformacaoLbl)
        Controls.Add(UsuarioInformacaoLbl)
        Controls.Add(ServidorInformacaoLbl)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Informação_do_banco"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Informação_do_banco"
        CType(ResultadoDgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConectarInformacaoBtn As Button
    Friend WithEvents SenhaInformacaoTxb As TextBox
    Friend WithEvents NomeInformacaoTxb As TextBox
    Friend WithEvents ServidorInformacaoTxb As TextBox
    Friend WithEvents SenhaInformacaoLbl As Label
    Friend WithEvents UsuarioInformacaoLbl As Label
    Friend WithEvents ServidorInformacaoLbl As Label
    Friend WithEvents MostrarCaminhoTxb As TextBox
    Friend WithEvents MostrarCaminhoBtn As Button
    Friend WithEvents SelecionarBancoInformacaoCbx As ComboBox
    Friend WithEvents MostrarinformacaoBtn As Button
    Friend WithEvents ResultadoDgv As DataGridView
    Friend WithEvents NomeBancoTxb As TextBox
    Friend WithEvents SairInformacaoBancoBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MostrarTodosBtn As Button
    Friend WithEvents ExibirServidorIfoCbx As ComboBox
    Friend WithEvents SSSALVOSLbl As Label
End Class

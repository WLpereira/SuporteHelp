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
        CType(ResultadoDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConectarInformacaoBtn
        ' 
        ConectarInformacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarInformacaoBtn.Image = CType(resources.GetObject("ConectarInformacaoBtn.Image"), Image)
        ConectarInformacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarInformacaoBtn.Location = New Point(670, 18)
        ConectarInformacaoBtn.Name = "ConectarInformacaoBtn"
        ConectarInformacaoBtn.Size = New Size(118, 38)
        ConectarInformacaoBtn.TabIndex = 40
        ConectarInformacaoBtn.Text = "Conectar"
        ConectarInformacaoBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarInformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaInformacaoTxb
        ' 
        SenhaInformacaoTxb.Location = New Point(470, 29)
        SenhaInformacaoTxb.Name = "SenhaInformacaoTxb"
        SenhaInformacaoTxb.Size = New Size(177, 27)
        SenhaInformacaoTxb.TabIndex = 39
        ' 
        ' NomeInformacaoTxb
        ' 
        NomeInformacaoTxb.Location = New Point(220, 29)
        NomeInformacaoTxb.Name = "NomeInformacaoTxb"
        NomeInformacaoTxb.Size = New Size(244, 27)
        NomeInformacaoTxb.TabIndex = 38
        ' 
        ' ServidorInformacaoTxb
        ' 
        ServidorInformacaoTxb.Location = New Point(19, 29)
        ServidorInformacaoTxb.Name = "ServidorInformacaoTxb"
        ServidorInformacaoTxb.Size = New Size(195, 27)
        ServidorInformacaoTxb.TabIndex = 37
        ' 
        ' SenhaInformacaoLbl
        ' 
        SenhaInformacaoLbl.AutoSize = True
        SenhaInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaInformacaoLbl.Location = New Point(470, 9)
        SenhaInformacaoLbl.Name = "SenhaInformacaoLbl"
        SenhaInformacaoLbl.Size = New Size(51, 20)
        SenhaInformacaoLbl.TabIndex = 36
        SenhaInformacaoLbl.Text = "Senha"
        ' 
        ' UsuarioInformacaoLbl
        ' 
        UsuarioInformacaoLbl.AutoSize = True
        UsuarioInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioInformacaoLbl.Location = New Point(220, 9)
        UsuarioInformacaoLbl.Name = "UsuarioInformacaoLbl"
        UsuarioInformacaoLbl.Size = New Size(63, 20)
        UsuarioInformacaoLbl.TabIndex = 35
        UsuarioInformacaoLbl.Text = "Usuario"
        ' 
        ' ServidorInformacaoLbl
        ' 
        ServidorInformacaoLbl.AutoSize = True
        ServidorInformacaoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorInformacaoLbl.Location = New Point(19, 9)
        ServidorInformacaoLbl.Name = "ServidorInformacaoLbl"
        ServidorInformacaoLbl.Size = New Size(142, 20)
        ServidorInformacaoLbl.TabIndex = 34
        ServidorInformacaoLbl.Text = "Informe o Servidor"
        ' 
        ' MostrarCaminhoTxb
        ' 
        MostrarCaminhoTxb.Location = New Point(192, 97)
        MostrarCaminhoTxb.Name = "MostrarCaminhoTxb"
        MostrarCaminhoTxb.Size = New Size(596, 27)
        MostrarCaminhoTxb.TabIndex = 41
        ' 
        ' MostrarCaminhoBtn
        ' 
        MostrarCaminhoBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarCaminhoBtn.Location = New Point(416, 62)
        MostrarCaminhoBtn.Name = "MostrarCaminhoBtn"
        MostrarCaminhoBtn.Size = New Size(169, 29)
        MostrarCaminhoBtn.TabIndex = 42
        MostrarCaminhoBtn.Text = "Buscar Caminho"
        MostrarCaminhoBtn.UseVisualStyleBackColor = True
        ' 
        ' SelecionarBancoInformacaoCbx
        ' 
        SelecionarBancoInformacaoCbx.FormattingEnabled = True
        SelecionarBancoInformacaoCbx.Location = New Point(814, 25)
        SelecionarBancoInformacaoCbx.Name = "SelecionarBancoInformacaoCbx"
        SelecionarBancoInformacaoCbx.Size = New Size(156, 28)
        SelecionarBancoInformacaoCbx.TabIndex = 43
        ' 
        ' MostrarinformacaoBtn
        ' 
        MostrarinformacaoBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarinformacaoBtn.Location = New Point(453, 143)
        MostrarinformacaoBtn.Name = "MostrarinformacaoBtn"
        MostrarinformacaoBtn.Size = New Size(94, 29)
        MostrarinformacaoBtn.TabIndex = 44
        MostrarinformacaoBtn.Text = "Mostrar"
        MostrarinformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' ResultadoDgv
        ' 
        ResultadoDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadoDgv.Location = New Point(12, 235)
        ResultadoDgv.Name = "ResultadoDgv"
        ResultadoDgv.RowHeadersWidth = 51
        ResultadoDgv.RowTemplate.Height = 29
        ResultadoDgv.Size = New Size(958, 296)
        ResultadoDgv.TabIndex = 45
        ' 
        ' NomeBancoTxb
        ' 
        NomeBancoTxb.Location = New Point(439, 178)
        NomeBancoTxb.Name = "NomeBancoTxb"
        NomeBancoTxb.Size = New Size(125, 27)
        NomeBancoTxb.TabIndex = 46
        ' 
        ' Informação_do_banco
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Informação_do_banco"
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
End Class

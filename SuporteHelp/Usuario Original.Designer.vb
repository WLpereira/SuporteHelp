<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_Original
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Usuario_Original))
        SelecionarBancoLbl = New Label()
        SelecionarBancoBbx = New ComboBox()
        ConectarBtn = New Button()
        SenhaTabelaTxb = New TextBox()
        NomeConectarTabelaTxb = New TextBox()
        ServidorUsuarioTxb = New TextBox()
        SenhaConectarLbl = New Label()
        UsuarioLbl = New Label()
        ServidorUsuarioLbl = New Label()
        SuspendLayout()
        ' 
        ' SelecionarBancoLbl
        ' 
        SelecionarBancoLbl.AutoSize = True
        SelecionarBancoLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoLbl.Location = New Point(563, 12)
        SelecionarBancoLbl.Name = "SelecionarBancoLbl"
        SelecionarBancoLbl.Size = New Size(127, 20)
        SelecionarBancoLbl.TabIndex = 48
        SelecionarBancoLbl.Text = "Selecionar Banco"
        ' 
        ' SelecionarBancoBbx
        ' 
        SelecionarBancoBbx.FormattingEnabled = True
        SelecionarBancoBbx.Location = New Point(563, 36)
        SelecionarBancoBbx.Margin = New Padding(3, 4, 3, 4)
        SelecionarBancoBbx.Name = "SelecionarBancoBbx"
        SelecionarBancoBbx.Size = New Size(225, 28)
        SelecionarBancoBbx.TabIndex = 47
        ' 
        ' ConectarBtn
        ' 
        ConectarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarBtn.Image = CType(resources.GetObject("ConectarBtn.Image"), Image)
        ConectarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarBtn.Location = New Point(428, 27)
        ConectarBtn.Margin = New Padding(3, 4, 3, 4)
        ConectarBtn.Name = "ConectarBtn"
        ConectarBtn.Size = New Size(111, 37)
        ConectarBtn.TabIndex = 46
        ConectarBtn.Text = "Conectar"
        ConectarBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaTabelaTxb
        ' 
        SenhaTabelaTxb.Location = New Point(299, 33)
        SenhaTabelaTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTabelaTxb.Name = "SenhaTabelaTxb"
        SenhaTabelaTxb.Size = New Size(111, 27)
        SenhaTabelaTxb.TabIndex = 45
        ' 
        ' NomeConectarTabelaTxb
        ' 
        NomeConectarTabelaTxb.Location = New Point(160, 33)
        NomeConectarTabelaTxb.Margin = New Padding(3, 4, 3, 4)
        NomeConectarTabelaTxb.Name = "NomeConectarTabelaTxb"
        NomeConectarTabelaTxb.Size = New Size(133, 27)
        NomeConectarTabelaTxb.TabIndex = 44
        ' 
        ' ServidorUsuarioTxb
        ' 
        ServidorUsuarioTxb.Location = New Point(3, 33)
        ServidorUsuarioTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorUsuarioTxb.Name = "ServidorUsuarioTxb"
        ServidorUsuarioTxb.Size = New Size(142, 27)
        ServidorUsuarioTxb.TabIndex = 43
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaConectarLbl.ForeColor = Color.Blue
        SenhaConectarLbl.Location = New Point(299, 9)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(51, 20)
        SenhaConectarLbl.TabIndex = 42
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioLbl
        ' 
        UsuarioLbl.AutoSize = True
        UsuarioLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioLbl.ForeColor = Color.Blue
        UsuarioLbl.Location = New Point(160, 6)
        UsuarioLbl.Name = "UsuarioLbl"
        UsuarioLbl.Size = New Size(63, 20)
        UsuarioLbl.TabIndex = 41
        UsuarioLbl.Text = "Usuario"
        ' 
        ' ServidorUsuarioLbl
        ' 
        ServidorUsuarioLbl.AutoSize = True
        ServidorUsuarioLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorUsuarioLbl.ForeColor = Color.Red
        ServidorUsuarioLbl.Location = New Point(3, 6)
        ServidorUsuarioLbl.Name = "ServidorUsuarioLbl"
        ServidorUsuarioLbl.Size = New Size(142, 20)
        ServidorUsuarioLbl.TabIndex = 40
        ServidorUsuarioLbl.Text = "Informe o Servidor"
        ' 
        ' Usuario_Original
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SelecionarBancoLbl)
        Controls.Add(SelecionarBancoBbx)
        Controls.Add(ConectarBtn)
        Controls.Add(SenhaTabelaTxb)
        Controls.Add(NomeConectarTabelaTxb)
        Controls.Add(ServidorUsuarioTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioLbl)
        Controls.Add(ServidorUsuarioLbl)
        Name = "Usuario_Original"
        Text = "Usuario_Original"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SelecionarBancoLbl As Label
    Friend WithEvents SelecionarBancoBbx As ComboBox
    Friend WithEvents ConectarBtn As Button
    Friend WithEvents SenhaTabelaTxb As TextBox
    Friend WithEvents NomeConectarTabelaTxb As TextBox
    Friend WithEvents ServidorUsuarioTxb As TextBox
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents UsuarioLbl As Label
    Friend WithEvents ServidorUsuarioLbl As Label
End Class

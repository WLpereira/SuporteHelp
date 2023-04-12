<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosCloud
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
        UsernameTxb = New TextBox()
        SenhaTxb = New TextBox()
        LoginUsuarioLbl = New Label()
        SenhaLoginLbl = New Label()
        LimparCloudBtn = New Button()
        ConectarClodBtn = New Button()
        MostrarServidorCbx = New ComboBox()
        AlterarBtn = New Button()
        ServidorLbl = New Label()
        ServidorCloudTxb = New TextBox()
        SelecionarBancoLbl = New Label()
        SuspendLayout()
        ' 
        ' UsernameTxb
        ' 
        UsernameTxb.BorderStyle = BorderStyle.FixedSingle
        UsernameTxb.Location = New Point(23, 93)
        UsernameTxb.Margin = New Padding(3, 4, 3, 4)
        UsernameTxb.Name = "UsernameTxb"
        UsernameTxb.Size = New Size(197, 27)
        UsernameTxb.TabIndex = 1
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.BackColor = Color.White
        SenhaTxb.BorderStyle = BorderStyle.FixedSingle
        SenhaTxb.Location = New Point(23, 149)
        SenhaTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(172, 27)
        SenhaTxb.TabIndex = 2
        ' 
        ' LoginUsuarioLbl
        ' 
        LoginUsuarioLbl.AutoSize = True
        LoginUsuarioLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoginUsuarioLbl.Location = New Point(23, 66)
        LoginUsuarioLbl.Name = "LoginUsuarioLbl"
        LoginUsuarioLbl.Size = New Size(70, 23)
        LoginUsuarioLbl.TabIndex = 3
        LoginUsuarioLbl.Text = "Usuario"
        ' 
        ' SenhaLoginLbl
        ' 
        SenhaLoginLbl.AutoSize = True
        SenhaLoginLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaLoginLbl.ForeColor = Color.Red
        SenhaLoginLbl.Location = New Point(23, 122)
        SenhaLoginLbl.Name = "SenhaLoginLbl"
        SenhaLoginLbl.Size = New Size(307, 23)
        SenhaLoginLbl.TabIndex = 5
        SenhaLoginLbl.Text = "SENHA ""SA"" ORIGINAL DA EMPRESA"
        ' 
        ' LimparCloudBtn
        ' 
        LimparCloudBtn.Anchor = AnchorStyles.None
        LimparCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparCloudBtn.Location = New Point(26, 335)
        LimparCloudBtn.Margin = New Padding(5, 4, 5, 4)
        LimparCloudBtn.Name = "LimparCloudBtn"
        LimparCloudBtn.Size = New Size(87, 36)
        LimparCloudBtn.TabIndex = 1
        LimparCloudBtn.Text = "Limpar"
        ' 
        ' ConectarClodBtn
        ' 
        ConectarClodBtn.Anchor = AnchorStyles.None
        ConectarClodBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarClodBtn.Location = New Point(23, 184)
        ConectarClodBtn.Margin = New Padding(5, 4, 5, 4)
        ConectarClodBtn.Name = "ConectarClodBtn"
        ConectarClodBtn.Size = New Size(139, 36)
        ConectarClodBtn.TabIndex = 0
        ConectarClodBtn.Text = "Conectar "
        ConectarClodBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MostrarServidorCbx
        ' 
        MostrarServidorCbx.FormattingEnabled = True
        MostrarServidorCbx.Location = New Point(285, 192)
        MostrarServidorCbx.Name = "MostrarServidorCbx"
        MostrarServidorCbx.Size = New Size(241, 28)
        MostrarServidorCbx.TabIndex = 6
        ' 
        ' AlterarBtn
        ' 
        AlterarBtn.Anchor = AnchorStyles.None
        AlterarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AlterarBtn.Location = New Point(224, 346)
        AlterarBtn.Margin = New Padding(5, 4, 5, 4)
        AlterarBtn.Name = "AlterarBtn"
        AlterarBtn.Size = New Size(105, 36)
        AlterarBtn.TabIndex = 7
        AlterarBtn.Text = "Alterar"
        ' 
        ' ServidorLbl
        ' 
        ServidorLbl.AutoSize = True
        ServidorLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorLbl.Location = New Point(23, 12)
        ServidorLbl.Name = "ServidorLbl"
        ServidorLbl.Size = New Size(79, 23)
        ServidorLbl.TabIndex = 9
        ServidorLbl.Text = "Servidor"
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.BorderStyle = BorderStyle.FixedSingle
        ServidorCloudTxb.Location = New Point(23, 39)
        ServidorCloudTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(241, 27)
        ServidorCloudTxb.TabIndex = 8
        ' 
        ' SelecionarBancoLbl
        ' 
        SelecionarBancoLbl.AutoSize = True
        SelecionarBancoLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoLbl.Location = New Point(341, 166)
        SelecionarBancoLbl.Name = "SelecionarBancoLbl"
        SelecionarBancoLbl.Size = New Size(145, 23)
        SelecionarBancoLbl.TabIndex = 10
        SelecionarBancoLbl.Text = "Selecionar Banco"
        ' 
        ' BancosCloud
        ' 
        AcceptButton = ConectarClodBtn
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = LimparCloudBtn
        ClientSize = New Size(582, 403)
        Controls.Add(SelecionarBancoLbl)
        Controls.Add(ServidorLbl)
        Controls.Add(ServidorCloudTxb)
        Controls.Add(AlterarBtn)
        Controls.Add(MostrarServidorCbx)
        Controls.Add(ConectarClodBtn)
        Controls.Add(SenhaLoginLbl)
        Controls.Add(LimparCloudBtn)
        Controls.Add(LoginUsuarioLbl)
        Controls.Add(SenhaTxb)
        Controls.Add(UsernameTxb)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BancosCloud"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Bancos Cloud"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UsernameTxb As TextBox
    Friend WithEvents SenhaTxb As TextBox
    Friend WithEvents LoginUsuarioLbl As Label
    Friend WithEvents SenhaLoginLbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents LimparCloudBtn As Button
    Friend WithEvents ConectarClodBtn As Button
    Friend WithEvents MostrarServidorCbx As ComboBox
    Friend WithEvents AlterarBtn As Button
    Friend WithEvents ServidorLbl As Label
    Friend WithEvents ServidorCloudTxb As TextBox
    Friend WithEvents SelecionarBancoLbl As Label
End Class

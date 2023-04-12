<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginDialog
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
        SuspendLayout()
        ' 
        ' UsernameTxb
        ' 
        UsernameTxb.Location = New Point(165, 124)
        UsernameTxb.Margin = New Padding(3, 4, 3, 4)
        UsernameTxb.Name = "UsernameTxb"
        UsernameTxb.Size = New Size(241, 27)
        UsernameTxb.TabIndex = 1
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.Location = New Point(165, 186)
        SenhaTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(241, 27)
        SenhaTxb.TabIndex = 2
        ' 
        ' LoginUsuarioLbl
        ' 
        LoginUsuarioLbl.AutoSize = True
        LoginUsuarioLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoginUsuarioLbl.Location = New Point(165, 97)
        LoginUsuarioLbl.Name = "LoginUsuarioLbl"
        LoginUsuarioLbl.Size = New Size(70, 23)
        LoginUsuarioLbl.TabIndex = 3
        LoginUsuarioLbl.Text = "Usuario"
        ' 
        ' SenhaLoginLbl
        ' 
        SenhaLoginLbl.AutoSize = True
        SenhaLoginLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaLoginLbl.Location = New Point(165, 159)
        SenhaLoginLbl.Name = "SenhaLoginLbl"
        SenhaLoginLbl.Size = New Size(58, 23)
        SenhaLoginLbl.TabIndex = 5
        SenhaLoginLbl.Text = "Senha"
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
        ConectarClodBtn.Location = New Point(224, 240)
        ConectarClodBtn.Margin = New Padding(5, 4, 5, 4)
        ConectarClodBtn.Name = "ConectarClodBtn"
        ConectarClodBtn.Size = New Size(105, 36)
        ConectarClodBtn.TabIndex = 0
        ConectarClodBtn.Text = "Conectar "
        ' 
        ' MostrarServidorCbx
        ' 
        MostrarServidorCbx.FormattingEnabled = True
        MostrarServidorCbx.Location = New Point(165, 295)
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
        ServidorLbl.Location = New Point(250, 24)
        ServidorLbl.Name = "ServidorLbl"
        ServidorLbl.Size = New Size(79, 23)
        ServidorLbl.TabIndex = 9
        ServidorLbl.Text = "Servidor"
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.Location = New Point(165, 51)
        ServidorCloudTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(241, 27)
        ServidorCloudTxb.TabIndex = 8
        ' 
        ' LoginDialog
        ' 
        AcceptButton = ConectarClodBtn
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = LimparCloudBtn
        ClientSize = New Size(582, 403)
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
        Name = "LoginDialog"
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
End Class

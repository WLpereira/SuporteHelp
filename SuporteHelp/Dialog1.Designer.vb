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
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UsernameTxb
        ' 
        UsernameTxb.Location = New Point(81, 40)
        UsernameTxb.Name = "UsernameTxb"
        UsernameTxb.Size = New Size(211, 23)
        UsernameTxb.TabIndex = 1
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.Location = New Point(81, 86)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(211, 23)
        SenhaTxb.TabIndex = 2
        ' 
        ' LoginUsuarioLbl
        ' 
        LoginUsuarioLbl.AutoSize = True
        LoginUsuarioLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoginUsuarioLbl.Location = New Point(81, 22)
        LoginUsuarioLbl.Name = "LoginUsuarioLbl"
        LoginUsuarioLbl.Size = New Size(55, 17)
        LoginUsuarioLbl.TabIndex = 3
        LoginUsuarioLbl.Text = "Usuario"
        ' 
        ' SenhaLoginLbl
        ' 
        SenhaLoginLbl.AutoSize = True
        SenhaLoginLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaLoginLbl.Location = New Point(81, 66)
        SenhaLoginLbl.Name = "SenhaLoginLbl"
        SenhaLoginLbl.Size = New Size(45, 17)
        SenhaLoginLbl.TabIndex = 5
        SenhaLoginLbl.Text = "Senha"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(98, 115)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(170, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        OK_Button.Location = New Point(4, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel_Button.Location = New Point(89, 3)
        Cancel_Button.Margin = New Padding(4, 3, 4, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(77, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancelar"
        ' 
        ' LoginDialog
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(384, 211)
        Controls.Add(SenhaLoginLbl)
        Controls.Add(LoginUsuarioLbl)
        Controls.Add(SenhaTxb)
        Controls.Add(UsernameTxb)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Permissão"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UsernameTxb As TextBox
    Friend WithEvents SenhaTxb As TextBox
    Friend WithEvents LoginUsuarioLbl As Label
    Friend WithEvents SenhaLoginLbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
End Class

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
        SelecionarBancoUsuarioLbl = New Label()
        SelecionarBancoUsuarioBbx = New ComboBox()
        ConectarUsuarioBtn = New Button()
        SenhaUsusarioTxb = New TextBox()
        NomeusuarioTxb = New TextBox()
        ServidorUsuarioTxb = New TextBox()
        SenhaUsuarioLbl = New Label()
        UsuarioLbl = New Label()
        ServidorUsuarioLbl = New Label()
        ExecutarTodosUsuariosBtn = New Button()
        Button1 = New Button()
        SelecionarUsuarioCbx = New ComboBox()
        SelecionarUsuarioLbl = New Label()
        ExecutarUsuarioEspecificoBtn = New Button()
        SenhaSaTxb = New TextBox()
        SenhaSALbl = New Label()
        MostrarUsuarioBtn = New Button()
        SuspendLayout()
        ' 
        ' SelecionarBancoUsuarioLbl
        ' 
        SelecionarBancoUsuarioLbl.AutoSize = True
        SelecionarBancoUsuarioLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoUsuarioLbl.Location = New Point(562, 11)
        SelecionarBancoUsuarioLbl.Name = "SelecionarBancoUsuarioLbl"
        SelecionarBancoUsuarioLbl.Size = New Size(127, 20)
        SelecionarBancoUsuarioLbl.TabIndex = 48
        SelecionarBancoUsuarioLbl.Text = "Selecionar Banco"
        ' 
        ' SelecionarBancoUsuarioBbx
        ' 
        SelecionarBancoUsuarioBbx.FormattingEnabled = True
        SelecionarBancoUsuarioBbx.Location = New Point(562, 35)
        SelecionarBancoUsuarioBbx.Margin = New Padding(3, 4, 3, 4)
        SelecionarBancoUsuarioBbx.Name = "SelecionarBancoUsuarioBbx"
        SelecionarBancoUsuarioBbx.Size = New Size(191, 28)
        SelecionarBancoUsuarioBbx.TabIndex = 47
        ' 
        ' ConectarUsuarioBtn
        ' 
        ConectarUsuarioBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarUsuarioBtn.Image = CType(resources.GetObject("ConectarUsuarioBtn.Image"), Image)
        ConectarUsuarioBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarUsuarioBtn.Location = New Point(445, 29)
        ConectarUsuarioBtn.Margin = New Padding(3, 4, 3, 4)
        ConectarUsuarioBtn.Name = "ConectarUsuarioBtn"
        ConectarUsuarioBtn.Size = New Size(111, 37)
        ConectarUsuarioBtn.TabIndex = 46
        ConectarUsuarioBtn.Text = "Conectar"
        ConectarUsuarioBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarUsuarioBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaUsusarioTxb
        ' 
        SenhaUsusarioTxb.Location = New Point(316, 35)
        SenhaUsusarioTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaUsusarioTxb.Name = "SenhaUsusarioTxb"
        SenhaUsusarioTxb.Size = New Size(111, 27)
        SenhaUsusarioTxb.TabIndex = 45
        ' 
        ' NomeusuarioTxb
        ' 
        NomeusuarioTxb.Location = New Point(177, 35)
        NomeusuarioTxb.Margin = New Padding(3, 4, 3, 4)
        NomeusuarioTxb.Name = "NomeusuarioTxb"
        NomeusuarioTxb.Size = New Size(133, 27)
        NomeusuarioTxb.TabIndex = 44
        ' 
        ' ServidorUsuarioTxb
        ' 
        ServidorUsuarioTxb.Location = New Point(20, 35)
        ServidorUsuarioTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorUsuarioTxb.Name = "ServidorUsuarioTxb"
        ServidorUsuarioTxb.Size = New Size(142, 27)
        ServidorUsuarioTxb.TabIndex = 43
        ' 
        ' SenhaUsuarioLbl
        ' 
        SenhaUsuarioLbl.AutoSize = True
        SenhaUsuarioLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaUsuarioLbl.ForeColor = Color.Blue
        SenhaUsuarioLbl.Location = New Point(316, 11)
        SenhaUsuarioLbl.Name = "SenhaUsuarioLbl"
        SenhaUsuarioLbl.Size = New Size(51, 20)
        SenhaUsuarioLbl.TabIndex = 42
        SenhaUsuarioLbl.Text = "Senha"
        ' 
        ' UsuarioLbl
        ' 
        UsuarioLbl.AutoSize = True
        UsuarioLbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioLbl.ForeColor = Color.Blue
        UsuarioLbl.Location = New Point(177, 8)
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
        ServidorUsuarioLbl.Location = New Point(20, 8)
        ServidorUsuarioLbl.Name = "ServidorUsuarioLbl"
        ServidorUsuarioLbl.Size = New Size(142, 20)
        ServidorUsuarioLbl.TabIndex = 40
        ServidorUsuarioLbl.Text = "Informe o Servidor"
        ' 
        ' ExecutarTodosUsuariosBtn
        ' 
        ExecutarTodosUsuariosBtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ExecutarTodosUsuariosBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ExecutarTodosUsuariosBtn.Location = New Point(378, 231)
        ExecutarTodosUsuariosBtn.Name = "ExecutarTodosUsuariosBtn"
        ExecutarTodosUsuariosBtn.Size = New Size(293, 37)
        ExecutarTodosUsuariosBtn.TabIndex = 49
        ExecutarTodosUsuariosBtn.Text = "Executar Todos os Usuarios Orfãos "
        ExecutarTodosUsuariosBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(653, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 43)
        Button1.TabIndex = 51
        Button1.Text = "SAIR"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SelecionarUsuarioCbx
        ' 
        SelecionarUsuarioCbx.FormattingEnabled = True
        SelecionarUsuarioCbx.Location = New Point(67, 231)
        SelecionarUsuarioCbx.Margin = New Padding(3, 4, 3, 4)
        SelecionarUsuarioCbx.Name = "SelecionarUsuarioCbx"
        SelecionarUsuarioCbx.Size = New Size(225, 28)
        SelecionarUsuarioCbx.TabIndex = 52
        ' 
        ' SelecionarUsuarioLbl
        ' 
        SelecionarUsuarioLbl.AutoSize = True
        SelecionarUsuarioLbl.BackColor = SystemColors.Control
        SelecionarUsuarioLbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarUsuarioLbl.ForeColor = Color.Blue
        SelecionarUsuarioLbl.Location = New Point(99, 191)
        SelecionarUsuarioLbl.Name = "SelecionarUsuarioLbl"
        SelecionarUsuarioLbl.Size = New Size(157, 23)
        SelecionarUsuarioLbl.TabIndex = 53
        SelecionarUsuarioLbl.Text = "Selecionar Usuario"
        ' 
        ' ExecutarUsuarioEspecificoBtn
        ' 
        ExecutarUsuarioEspecificoBtn.BackColor = Color.Blue
        ExecutarUsuarioEspecificoBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ExecutarUsuarioEspecificoBtn.ForeColor = Color.White
        ExecutarUsuarioEspecificoBtn.Location = New Point(26, 279)
        ExecutarUsuarioEspecificoBtn.Name = "ExecutarUsuarioEspecificoBtn"
        ExecutarUsuarioEspecificoBtn.Size = New Size(320, 37)
        ExecutarUsuarioEspecificoBtn.TabIndex = 54
        ExecutarUsuarioEspecificoBtn.Text = "Executar Usuario Selecionado"
        ExecutarUsuarioEspecificoBtn.UseVisualStyleBackColor = False
        ' 
        ' SenhaSaTxb
        ' 
        SenhaSaTxb.BorderStyle = BorderStyle.FixedSingle
        SenhaSaTxb.Location = New Point(326, 104)
        SenhaSaTxb.Name = "SenhaSaTxb"
        SenhaSaTxb.Size = New Size(125, 27)
        SenhaSaTxb.TabIndex = 55
        ' 
        ' SenhaSALbl
        ' 
        SenhaSALbl.AutoSize = True
        SenhaSALbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaSALbl.ForeColor = Color.Red
        SenhaSALbl.Location = New Point(202, 69)
        SenhaSALbl.Name = "SenhaSALbl"
        SenhaSALbl.Size = New Size(400, 23)
        SenhaSALbl.TabIndex = 56
        SenhaSALbl.Text = "Informe a Senha SA para executar  os comandos "
        ' 
        ' MostrarUsuarioBtn
        ' 
        MostrarUsuarioBtn.FlatStyle = FlatStyle.System
        MostrarUsuarioBtn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        MostrarUsuarioBtn.Location = New Point(295, 137)
        MostrarUsuarioBtn.Name = "MostrarUsuarioBtn"
        MostrarUsuarioBtn.Size = New Size(185, 43)
        MostrarUsuarioBtn.TabIndex = 57
        MostrarUsuarioBtn.Text = "Mostrar Usuarios"
        MostrarUsuarioBtn.UseVisualStyleBackColor = True
        ' 
        ' Usuario_Original
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 353)
        Controls.Add(MostrarUsuarioBtn)
        Controls.Add(SenhaSALbl)
        Controls.Add(SenhaSaTxb)
        Controls.Add(ExecutarUsuarioEspecificoBtn)
        Controls.Add(SelecionarUsuarioLbl)
        Controls.Add(SelecionarUsuarioCbx)
        Controls.Add(Button1)
        Controls.Add(ExecutarTodosUsuariosBtn)
        Controls.Add(SelecionarBancoUsuarioLbl)
        Controls.Add(SelecionarBancoUsuarioBbx)
        Controls.Add(ConectarUsuarioBtn)
        Controls.Add(SenhaUsusarioTxb)
        Controls.Add(NomeusuarioTxb)
        Controls.Add(ServidorUsuarioTxb)
        Controls.Add(SenhaUsuarioLbl)
        Controls.Add(UsuarioLbl)
        Controls.Add(ServidorUsuarioLbl)
        Name = "Usuario_Original"
        Text = "Usuario_Original"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SelecionarBancoUsuarioLbl As Label
    Friend WithEvents SelecionarBancoUsuarioBbx As ComboBox
    Friend WithEvents ConectarUsuarioBtn As Button
    Friend WithEvents SenhaUsusarioTxb As TextBox
    Friend WithEvents NomeusuarioTxb As TextBox
    Friend WithEvents ServidorUsuarioTxb As TextBox
    Friend WithEvents SenhaUsuarioLbl As Label
    Friend WithEvents UsuarioLbl As Label
    Friend WithEvents ServidorUsuarioLbl As Label
    Friend WithEvents ExecutarTodosUsuariosBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SelecionarUsuarioCbx As ComboBox
    Friend WithEvents SelecionarUsuarioLbl As Label
    Friend WithEvents ExecutarUsuarioEspecificoBtn As Button
    Friend WithEvents SenhaSaTxb As TextBox
    Friend WithEvents SenhaSALbl As Label
    Friend WithEvents MostrarUsuarioBtn As Button
End Class

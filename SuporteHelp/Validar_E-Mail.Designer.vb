<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validar_E_Mail
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Validar_E_Mail))
        ValidarSmtpBtn = New Button()
        ValidarEmailBtn = New Button()
        Button2 = New Button()
        PortaTxb = New TextBox()
        SmtpTxb = New TextBox()
        SmtpLbl = New Label()
        PortaLbl = New Label()
        SenhaEmailLbl = New Label()
        SenhaEmailTxb = New TextBox()
        EmailTxb = New TextBox()
        EmailLbl = New Label()
        PictureBox1 = New PictureBox()
        LimparBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ValidarSmtpBtn
        ' 
        ValidarSmtpBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarSmtpBtn.Image = CType(resources.GetObject("ValidarSmtpBtn.Image"), Image)
        ValidarSmtpBtn.ImageAlign = ContentAlignment.MiddleLeft
        ValidarSmtpBtn.Location = New Point(41, 265)
        ValidarSmtpBtn.Margin = New Padding(3, 4, 3, 4)
        ValidarSmtpBtn.Name = "ValidarSmtpBtn"
        ValidarSmtpBtn.Size = New Size(168, 51)
        ValidarSmtpBtn.TabIndex = 27
        ValidarSmtpBtn.Text = "Validar SMTP"
        ValidarSmtpBtn.TextAlign = ContentAlignment.MiddleRight
        ValidarSmtpBtn.UseVisualStyleBackColor = True
        ' 
        ' ValidarEmailBtn
        ' 
        ValidarEmailBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarEmailBtn.Image = CType(resources.GetObject("ValidarEmailBtn.Image"), Image)
        ValidarEmailBtn.ImageAlign = ContentAlignment.MiddleLeft
        ValidarEmailBtn.Location = New Point(216, 265)
        ValidarEmailBtn.Margin = New Padding(3, 4, 3, 4)
        ValidarEmailBtn.Name = "ValidarEmailBtn"
        ValidarEmailBtn.Size = New Size(226, 51)
        ValidarEmailBtn.TabIndex = 28
        ValidarEmailBtn.Text = "Validar SMTP e E-mail"
        ValidarEmailBtn.TextAlign = ContentAlignment.MiddleRight
        ValidarEmailBtn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(510, 348)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 51)
        Button2.TabIndex = 29
        Button2.Text = "Sair"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PortaTxb
        ' 
        PortaTxb.Location = New Point(238, 80)
        PortaTxb.Margin = New Padding(3, 4, 3, 4)
        PortaTxb.Name = "PortaTxb"
        PortaTxb.Size = New Size(103, 27)
        PortaTxb.TabIndex = 33
        ' 
        ' SmtpTxb
        ' 
        SmtpTxb.Location = New Point(14, 80)
        SmtpTxb.Margin = New Padding(3, 4, 3, 4)
        SmtpTxb.Name = "SmtpTxb"
        SmtpTxb.Size = New Size(167, 27)
        SmtpTxb.TabIndex = 32
        ' 
        ' SmtpLbl
        ' 
        SmtpLbl.AutoSize = True
        SmtpLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SmtpLbl.Location = New Point(14, 53)
        SmtpLbl.Name = "SmtpLbl"
        SmtpLbl.Size = New Size(56, 23)
        SmtpLbl.TabIndex = 30
        SmtpLbl.Text = "SMTP"
        ' 
        ' PortaLbl
        ' 
        PortaLbl.AutoSize = True
        PortaLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaLbl.Location = New Point(238, 53)
        PortaLbl.Name = "PortaLbl"
        PortaLbl.Size = New Size(65, 23)
        PortaLbl.TabIndex = 34
        PortaLbl.Text = "PORTA"
        ' 
        ' SenhaEmailLbl
        ' 
        SenhaEmailLbl.AutoSize = True
        SenhaEmailLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaEmailLbl.Location = New Point(392, 175)
        SenhaEmailLbl.Name = "SenhaEmailLbl"
        SenhaEmailLbl.Size = New Size(67, 23)
        SenhaEmailLbl.TabIndex = 38
        SenhaEmailLbl.Text = "SENHA"
        ' 
        ' SenhaEmailTxb
        ' 
        SenhaEmailTxb.Location = New Point(392, 201)
        SenhaEmailTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaEmailTxb.Name = "SenhaEmailTxb"
        SenhaEmailTxb.Size = New Size(220, 27)
        SenhaEmailTxb.TabIndex = 37
        ' 
        ' EmailTxb
        ' 
        EmailTxb.Location = New Point(14, 201)
        EmailTxb.Margin = New Padding(3, 4, 3, 4)
        EmailTxb.Name = "EmailTxb"
        EmailTxb.Size = New Size(327, 27)
        EmailTxb.TabIndex = 36
        ' 
        ' EmailLbl
        ' 
        EmailLbl.AutoSize = True
        EmailLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        EmailLbl.Location = New Point(14, 175)
        EmailLbl.Name = "EmailLbl"
        EmailLbl.Size = New Size(68, 23)
        EmailLbl.TabIndex = 35
        EmailLbl.Text = "E-MAIL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_mensagem_64
        PictureBox1.Location = New Point(510, 60)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 88)
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' LimparBtn
        ' 
        LimparBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparBtn.Image = CType(resources.GetObject("LimparBtn.Image"), Image)
        LimparBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparBtn.Location = New Point(449, 265)
        LimparBtn.Margin = New Padding(3, 4, 3, 4)
        LimparBtn.Name = "LimparBtn"
        LimparBtn.Size = New Size(122, 51)
        LimparBtn.TabIndex = 40
        LimparBtn.Text = "Limpar"
        LimparBtn.TextAlign = ContentAlignment.MiddleRight
        LimparBtn.UseVisualStyleBackColor = True
        ' 
        ' Validar_E_Mail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 415)
        Controls.Add(LimparBtn)
        Controls.Add(PictureBox1)
        Controls.Add(SenhaEmailLbl)
        Controls.Add(SenhaEmailTxb)
        Controls.Add(EmailTxb)
        Controls.Add(EmailLbl)
        Controls.Add(PortaLbl)
        Controls.Add(PortaTxb)
        Controls.Add(SmtpTxb)
        Controls.Add(SmtpLbl)
        Controls.Add(Button2)
        Controls.Add(ValidarEmailBtn)
        Controls.Add(ValidarSmtpBtn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Validar_E_Mail"
        Text = "Validar_E-mail"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ValidarSmtpBtn As Button
    Friend WithEvents ValidarEmailBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PortaTxb As TextBox
    Friend WithEvents SmtpTxb As TextBox
    Friend WithEvents SmtpLbl As Label
    Friend WithEvents PortaLbl As Label
    Friend WithEvents SenhaEmailLbl As Label
    Friend WithEvents SenhaEmailTxb As TextBox
    Friend WithEvents EmailTxb As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LimparBtn As Button
End Class

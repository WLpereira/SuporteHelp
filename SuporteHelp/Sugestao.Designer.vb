<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sugestao
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Sugestao))
        TextoEmailRtb = New RichTextBox()
        SugestaoLbl = New Label()
        EnviarBtn = New Button()
        LimparTextoBtn = New Button()
        SairTextoBtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextoEmailRtb
        ' 
        TextoEmailRtb.BackColor = Color.White
        TextoEmailRtb.BorderStyle = BorderStyle.FixedSingle
        TextoEmailRtb.Cursor = Cursors.IBeam
        TextoEmailRtb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextoEmailRtb.Location = New Point(99, 72)
        TextoEmailRtb.Name = "TextoEmailRtb"
        TextoEmailRtb.Size = New Size(385, 309)
        TextoEmailRtb.TabIndex = 0
        TextoEmailRtb.Text = ""
        ' 
        ' SugestaoLbl
        ' 
        SugestaoLbl.AutoSize = True
        SugestaoLbl.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        SugestaoLbl.ForeColor = Color.Black
        SugestaoLbl.Location = New Point(81, 22)
        SugestaoLbl.Name = "SugestaoLbl"
        SugestaoLbl.Size = New Size(443, 30)
        SugestaoLbl.TabIndex = 1
        SugestaoLbl.Text = "Contribua para a melhoria da ferramenta!"
        ' 
        ' EnviarBtn
        ' 
        EnviarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        EnviarBtn.Image = My.Resources.Resources.icons8_mail_30
        EnviarBtn.ImageAlign = ContentAlignment.MiddleLeft
        EnviarBtn.Location = New Point(25, 395)
        EnviarBtn.Name = "EnviarBtn"
        EnviarBtn.Size = New Size(151, 54)
        EnviarBtn.TabIndex = 2
        EnviarBtn.Text = "Enviar Sugestão"
        EnviarBtn.TextAlign = ContentAlignment.MiddleRight
        EnviarBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparTextoBtn
        ' 
        LimparTextoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTextoBtn.Image = My.Resources.Resources.icons8_broom_with_a_lot_of_dust_30
        LimparTextoBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparTextoBtn.Location = New Point(239, 395)
        LimparTextoBtn.Name = "LimparTextoBtn"
        LimparTextoBtn.Size = New Size(98, 54)
        LimparTextoBtn.TabIndex = 3
        LimparTextoBtn.Text = "Limpar"
        LimparTextoBtn.TextAlign = ContentAlignment.MiddleRight
        LimparTextoBtn.UseVisualStyleBackColor = True
        ' 
        ' SairTextoBtn
        ' 
        SairTextoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairTextoBtn.Image = My.Resources.Resources.icons8_saída_de_emergência_30
        SairTextoBtn.ImageAlign = ContentAlignment.MiddleLeft
        SairTextoBtn.Location = New Point(449, 395)
        SairTextoBtn.Name = "SairTextoBtn"
        SairTextoBtn.Size = New Size(96, 54)
        SairTextoBtn.TabIndex = 4
        SairTextoBtn.Text = "Sair"
        SairTextoBtn.TextAlign = ContentAlignment.MiddleRight
        SairTextoBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._4288592bulbideaknowledgelightreadthinking_115764_115749
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 54)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Sugestao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(584, 461)
        Controls.Add(PictureBox1)
        Controls.Add(SairTextoBtn)
        Controls.Add(LimparTextoBtn)
        Controls.Add(EnviarBtn)
        Controls.Add(SugestaoLbl)
        Controls.Add(TextoEmailRtb)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Sugestao"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sugestao"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextoEmailRtb As RichTextBox
    Friend WithEvents SugestaoLbl As Label
    Friend WithEvents EnviarBtn As Button
    Friend WithEvents LimparTextoBtn As Button
    Friend WithEvents SairTextoBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

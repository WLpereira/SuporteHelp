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
        TextoEmailRtb.Size = New Size(385, 317)
        TextoEmailRtb.TabIndex = 0
        TextoEmailRtb.Text = ""
        ' 
        ' SugestaoLbl
        ' 
        SugestaoLbl.AutoSize = True
        SugestaoLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SugestaoLbl.ForeColor = Color.Black
        SugestaoLbl.Location = New Point(128, 35)
        SugestaoLbl.Name = "SugestaoLbl"
        SugestaoLbl.Size = New Size(327, 21)
        SugestaoLbl.TabIndex = 1
        SugestaoLbl.Text = "Contribua para a melhoria da ferramenta!"
        ' 
        ' EnviarBtn
        ' 
        EnviarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        EnviarBtn.Location = New Point(25, 408)
        EnviarBtn.Name = "EnviarBtn"
        EnviarBtn.Size = New Size(151, 41)
        EnviarBtn.TabIndex = 2
        EnviarBtn.Text = "Enviar Sugestão"
        EnviarBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparTextoBtn
        ' 
        LimparTextoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparTextoBtn.Location = New Point(229, 408)
        LimparTextoBtn.Name = "LimparTextoBtn"
        LimparTextoBtn.Size = New Size(116, 41)
        LimparTextoBtn.TabIndex = 3
        LimparTextoBtn.Text = "Limpar"
        LimparTextoBtn.UseVisualStyleBackColor = True
        ' 
        ' SairTextoBtn
        ' 
        SairTextoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairTextoBtn.Location = New Point(430, 408)
        SairTextoBtn.Name = "SairTextoBtn"
        SairTextoBtn.Size = New Size(116, 41)
        SairTextoBtn.TabIndex = 4
        SairTextoBtn.Text = "Sair"
        SairTextoBtn.UseVisualStyleBackColor = True
        ' 
        ' Sugestao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(584, 461)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextoEmailRtb As RichTextBox
    Friend WithEvents SugestaoLbl As Label
    Friend WithEvents EnviarBtn As Button
    Friend WithEvents LimparTextoBtn As Button
    Friend WithEvents SairTextoBtn As Button
End Class

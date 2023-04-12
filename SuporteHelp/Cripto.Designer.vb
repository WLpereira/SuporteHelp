<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cripto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cripto))
        SenhaAtualLbl = New Label()
        SenhaAtualTxb = New TextBox()
        CriptografarBtn = New Button()
        SenhaNovaTxb = New TextBox()
        SenhaNovaLbl = New Label()
        DescriptografarBtn = New Button()
        LimparCriptoBtn = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SenhaAtualLbl
        ' 
        SenhaAtualLbl.AutoSize = True
        SenhaAtualLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaAtualLbl.Location = New Point(253, 63)
        SenhaAtualLbl.Name = "SenhaAtualLbl"
        SenhaAtualLbl.Size = New Size(82, 17)
        SenhaAtualLbl.TabIndex = 0
        SenhaAtualLbl.Text = "Senha Atual"
        ' 
        ' SenhaAtualTxb
        ' 
        SenhaAtualTxb.Location = New Point(136, 83)
        SenhaAtualTxb.Name = "SenhaAtualTxb"
        SenhaAtualTxb.Size = New Size(309, 23)
        SenhaAtualTxb.TabIndex = 1
        ' 
        ' CriptografarBtn
        ' 
        CriptografarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CriptografarBtn.Image = My.Resources.Resources.icons8_senha_30
        CriptografarBtn.ImageAlign = ContentAlignment.MiddleRight
        CriptografarBtn.Location = New Point(61, 184)
        CriptografarBtn.Name = "CriptografarBtn"
        CriptografarBtn.Size = New Size(151, 46)
        CriptografarBtn.TabIndex = 2
        CriptografarBtn.Text = "Criptografar"
        CriptografarBtn.TextAlign = ContentAlignment.MiddleLeft
        CriptografarBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaNovaTxb
        ' 
        SenhaNovaTxb.Location = New Point(136, 139)
        SenhaNovaTxb.Name = "SenhaNovaTxb"
        SenhaNovaTxb.Size = New Size(309, 23)
        SenhaNovaTxb.TabIndex = 3
        ' 
        ' SenhaNovaLbl
        ' 
        SenhaNovaLbl.AutoSize = True
        SenhaNovaLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaNovaLbl.Location = New Point(253, 119)
        SenhaNovaLbl.Name = "SenhaNovaLbl"
        SenhaNovaLbl.Size = New Size(86, 17)
        SenhaNovaLbl.TabIndex = 4
        SenhaNovaLbl.Text = "Senha NOVA"
        ' 
        ' DescriptografarBtn
        ' 
        DescriptografarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DescriptografarBtn.Image = My.Resources.Resources.icons8_open_lock_30
        DescriptografarBtn.ImageAlign = ContentAlignment.MiddleLeft
        DescriptografarBtn.Location = New Point(379, 184)
        DescriptografarBtn.Name = "DescriptografarBtn"
        DescriptografarBtn.Size = New Size(151, 46)
        DescriptografarBtn.TabIndex = 5
        DescriptografarBtn.Text = "Descriptografar"
        DescriptografarBtn.TextAlign = ContentAlignment.MiddleRight
        DescriptografarBtn.UseVisualStyleBackColor = True
        ' 
        ' LimparCriptoBtn
        ' 
        LimparCriptoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparCriptoBtn.Image = My.Resources.Resources.icons8_broom_with_a_lot_of_dust_30
        LimparCriptoBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparCriptoBtn.Location = New Point(237, 184)
        LimparCriptoBtn.Name = "LimparCriptoBtn"
        LimparCriptoBtn.Size = New Size(120, 46)
        LimparCriptoBtn.TabIndex = 6
        LimparCriptoBtn.Text = "Limpar"
        LimparCriptoBtn.TextAlign = ContentAlignment.MiddleRight
        LimparCriptoBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(452, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 33)
        Button1.TabIndex = 7
        Button1.Text = "Sair"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_criptografia_de_dados_100
        PictureBox1.Location = New Point(12, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 113)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Cripto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 311)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(LimparCriptoBtn)
        Controls.Add(DescriptografarBtn)
        Controls.Add(SenhaNovaLbl)
        Controls.Add(SenhaNovaTxb)
        Controls.Add(CriptografarBtn)
        Controls.Add(SenhaAtualTxb)
        Controls.Add(SenhaAtualLbl)
        Name = "Cripto"
        Text = "Cripto"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SenhaAtualLbl As Label
    Friend WithEvents SenhaAtualTxb As TextBox
    Friend WithEvents CriptografarBtn As Button
    Friend WithEvents SenhaNovaTxb As TextBox
    Friend WithEvents SenhaNovaLbl As Label
    Friend WithEvents DescriptografarBtn As Button
    Friend WithEvents LimparCriptoBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidarGtin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ValidarGtin))
        CodigoImg = New PictureBox()
        SairGtinbtn = New Button()
        LimparGtinBtn = New Button()
        ValidarGtinTxb = New TextBox()
        ValidarBtn = New Button()
        Label1 = New Label()
        CType(CodigoImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CodigoImg
        ' 
        CodigoImg.BorderStyle = BorderStyle.FixedSingle
        CodigoImg.Cursor = Cursors.Hand
        CodigoImg.Image = My.Resources.Resources.bar_code_22177
        CodigoImg.Location = New Point(248, 12)
        CodigoImg.Name = "CodigoImg"
        CodigoImg.Size = New Size(243, 246)
        CodigoImg.TabIndex = 1
        CodigoImg.TabStop = False
        ' 
        ' SairGtinbtn
        ' 
        SairGtinbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairGtinbtn.Image = My.Resources.Resources.icons8_saída_de_emergência_30
        SairGtinbtn.ImageAlign = ContentAlignment.MiddleLeft
        SairGtinbtn.Location = New Point(160, 194)
        SairGtinbtn.Name = "SairGtinbtn"
        SairGtinbtn.Size = New Size(82, 39)
        SairGtinbtn.TabIndex = 2
        SairGtinbtn.Text = "Sair"
        SairGtinbtn.TextAlign = ContentAlignment.MiddleRight
        SairGtinbtn.UseVisualStyleBackColor = True
        ' 
        ' LimparGtinBtn
        ' 
        LimparGtinBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparGtinBtn.Image = My.Resources.Resources.icons8_broom_with_a_lot_of_dust_30
        LimparGtinBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparGtinBtn.Location = New Point(7, 194)
        LimparGtinBtn.Name = "LimparGtinBtn"
        LimparGtinBtn.Size = New Size(85, 39)
        LimparGtinBtn.TabIndex = 3
        LimparGtinBtn.Text = "Limpar"
        LimparGtinBtn.TextAlign = ContentAlignment.MiddleRight
        LimparGtinBtn.UseVisualStyleBackColor = True
        ' 
        ' ValidarGtinTxb
        ' 
        ValidarGtinTxb.BorderStyle = BorderStyle.FixedSingle
        ValidarGtinTxb.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarGtinTxb.Location = New Point(7, 64)
        ValidarGtinTxb.Name = "ValidarGtinTxb"
        ValidarGtinTxb.Size = New Size(235, 23)
        ValidarGtinTxb.TabIndex = 4
        ' 
        ' ValidarBtn
        ' 
        ValidarBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarBtn.Image = My.Resources.Resources._3702397_barcode_code_scan_scanner_108737
        ValidarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ValidarBtn.Location = New Point(60, 115)
        ValidarBtn.Name = "ValidarBtn"
        ValidarBtn.Size = New Size(126, 35)
        ValidarBtn.TabIndex = 5
        ValidarBtn.Text = "VALIDAR"
        ValidarBtn.TextAlign = ContentAlignment.MiddleRight
        ValidarBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(44, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 21)
        Label1.TabIndex = 6
        Label1.Text = "VALIDAR GTIN/EAN"
        ' 
        ' ValidarGtin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 261)
        Controls.Add(Label1)
        Controls.Add(ValidarBtn)
        Controls.Add(ValidarGtinTxb)
        Controls.Add(LimparGtinBtn)
        Controls.Add(SairGtinbtn)
        Controls.Add(CodigoImg)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ValidarGtin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ValidarGtin"
        CType(CodigoImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CodigoImg As PictureBox
    Friend WithEvents SairGtinbtn As Button
    Friend WithEvents LimparGtinBtn As Button
    Friend WithEvents ValidarGtinTxb As TextBox
    Friend WithEvents ValidarBtn As Button
    Friend WithEvents Label1 As Label
End Class

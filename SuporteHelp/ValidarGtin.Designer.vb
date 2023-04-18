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
        CodigoImg.Location = New Point(283, 16)
        CodigoImg.Margin = New Padding(3, 4, 3, 4)
        CodigoImg.Name = "CodigoImg"
        CodigoImg.Size = New Size(277, 327)
        CodigoImg.TabIndex = 1
        CodigoImg.TabStop = False
        ' 
        ' SairGtinbtn
        ' 
        SairGtinbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairGtinbtn.Image = My.Resources.Resources.icons8_saída_de_emergência_30
        SairGtinbtn.ImageAlign = ContentAlignment.MiddleLeft
        SairGtinbtn.Location = New Point(183, 259)
        SairGtinbtn.Margin = New Padding(3, 4, 3, 4)
        SairGtinbtn.Name = "SairGtinbtn"
        SairGtinbtn.Size = New Size(94, 52)
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
        LimparGtinBtn.Location = New Point(8, 259)
        LimparGtinBtn.Margin = New Padding(3, 4, 3, 4)
        LimparGtinBtn.Name = "LimparGtinBtn"
        LimparGtinBtn.Size = New Size(97, 52)
        LimparGtinBtn.TabIndex = 3
        LimparGtinBtn.Text = "Limpar"
        LimparGtinBtn.TextAlign = ContentAlignment.MiddleRight
        LimparGtinBtn.UseVisualStyleBackColor = True
        ' 
        ' ValidarGtinTxb
        ' 
        ValidarGtinTxb.BorderStyle = BorderStyle.FixedSingle
        ValidarGtinTxb.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarGtinTxb.Location = New Point(8, 85)
        ValidarGtinTxb.Margin = New Padding(3, 4, 3, 4)
        ValidarGtinTxb.Name = "ValidarGtinTxb"
        ValidarGtinTxb.Size = New Size(268, 27)
        ValidarGtinTxb.TabIndex = 4
        ' 
        ' ValidarBtn
        ' 
        ValidarBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ValidarBtn.Image = My.Resources.Resources._3702397_barcode_code_scan_scanner_108737
        ValidarBtn.ImageAlign = ContentAlignment.MiddleLeft
        ValidarBtn.Location = New Point(69, 153)
        ValidarBtn.Margin = New Padding(3, 4, 3, 4)
        ValidarBtn.Name = "ValidarBtn"
        ValidarBtn.Size = New Size(144, 47)
        ValidarBtn.TabIndex = 5
        ValidarBtn.Text = "VALIDAR"
        ValidarBtn.TextAlign = ContentAlignment.MiddleRight
        ValidarBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 28)
        Label1.TabIndex = 6
        Label1.Text = "VALIDAR GTIN/EAN"
        ' 
        ' ValidarGtin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(565, 348)
        Controls.Add(Label1)
        Controls.Add(ValidarBtn)
        Controls.Add(ValidarGtinTxb)
        Controls.Add(LimparGtinBtn)
        Controls.Add(SairGtinbtn)
        Controls.Add(CodigoImg)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
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

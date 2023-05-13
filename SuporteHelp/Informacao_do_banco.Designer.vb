<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informação_do_banco
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Informação_do_banco))
        ConectarInformacaoBtn = New Button()
        SenhaInformacaoTxb = New TextBox()
        NomeInformacaoTxb = New TextBox()
        ServidorInformacaoTxb = New TextBox()
        SenhaInformacaoLbl = New Label()
        UsuarioInformacaoLbl = New Label()
        ServidorInformacaoLbl = New Label()
        SuspendLayout()
        ' 
        ' ConectarInformacaoBtn
        ' 
        ConectarInformacaoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarInformacaoBtn.Image = CType(resources.GetObject("ConectarInformacaoBtn.Image"), Image)
        ConectarInformacaoBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarInformacaoBtn.Location = New Point(651, 39)
        ConectarInformacaoBtn.Name = "ConectarInformacaoBtn"
        ConectarInformacaoBtn.Size = New Size(118, 38)
        ConectarInformacaoBtn.TabIndex = 40
        ConectarInformacaoBtn.Text = "Conectar"
        ConectarInformacaoBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarInformacaoBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaInformacaoTxb
        ' 
        SenhaInformacaoTxb.Location = New Point(468, 50)
        SenhaInformacaoTxb.Name = "SenhaInformacaoTxb"
        SenhaInformacaoTxb.Size = New Size(177, 27)
        SenhaInformacaoTxb.TabIndex = 39
        ' 
        ' NomeInformacaoTxb
        ' 
        NomeInformacaoTxb.Location = New Point(218, 50)
        NomeInformacaoTxb.Name = "NomeInformacaoTxb"
        NomeInformacaoTxb.Size = New Size(244, 27)
        NomeInformacaoTxb.TabIndex = 38
        ' 
        ' ServidorInformacaoTxb
        ' 
        ServidorInformacaoTxb.Location = New Point(17, 50)
        ServidorInformacaoTxb.Name = "ServidorInformacaoTxb"
        ServidorInformacaoTxb.Size = New Size(195, 27)
        ServidorInformacaoTxb.TabIndex = 37
        ' 
        ' SenhaInformacaoLbl
        ' 
        SenhaInformacaoLbl.AutoSize = True
        SenhaInformacaoLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaInformacaoLbl.Location = New Point(468, 30)
        SenhaInformacaoLbl.Name = "SenhaInformacaoLbl"
        SenhaInformacaoLbl.Size = New Size(51, 20)
        SenhaInformacaoLbl.TabIndex = 36
        SenhaInformacaoLbl.Text = "Senha"
        ' 
        ' UsuarioInformacaoLbl
        ' 
        UsuarioInformacaoLbl.AutoSize = True
        UsuarioInformacaoLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        UsuarioInformacaoLbl.Location = New Point(218, 30)
        UsuarioInformacaoLbl.Name = "UsuarioInformacaoLbl"
        UsuarioInformacaoLbl.Size = New Size(63, 20)
        UsuarioInformacaoLbl.TabIndex = 35
        UsuarioInformacaoLbl.Text = "Usuario"
        ' 
        ' ServidorInformacaoLbl
        ' 
        ServidorInformacaoLbl.AutoSize = True
        ServidorInformacaoLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorInformacaoLbl.Location = New Point(17, 30)
        ServidorInformacaoLbl.Name = "ServidorInformacaoLbl"
        ServidorInformacaoLbl.Size = New Size(142, 20)
        ServidorInformacaoLbl.TabIndex = 34
        ServidorInformacaoLbl.Text = "Informe o Servidor"
        ' 
        ' Informação_do_banco
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ConectarInformacaoBtn)
        Controls.Add(SenhaInformacaoTxb)
        Controls.Add(NomeInformacaoTxb)
        Controls.Add(ServidorInformacaoTxb)
        Controls.Add(SenhaInformacaoLbl)
        Controls.Add(UsuarioInformacaoLbl)
        Controls.Add(ServidorInformacaoLbl)
        Name = "Informação_do_banco"
        Text = "Informação_do_banco"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConectarInformacaoBtn As Button
    Friend WithEvents SenhaInformacaoTxb As TextBox
    Friend WithEvents NomeInformacaoTxb As TextBox
    Friend WithEvents ServidorInformacaoTxb As TextBox
    Friend WithEvents SenhaInformacaoLbl As Label
    Friend WithEvents UsuarioInformacaoLbl As Label
    Friend WithEvents ServidorInformacaoLbl As Label
End Class

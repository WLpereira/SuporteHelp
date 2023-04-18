<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descricao_Coluna
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Descricao_Coluna))
        SairTabelaColuna = New Button()
        SuspendLayout()
        ' 
        ' SairTabelaColuna
        ' 
        SairTabelaColuna.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SairTabelaColuna.Image = CType(resources.GetObject("SairTabelaColuna.Image"), Image)
        SairTabelaColuna.ImageAlign = ContentAlignment.MiddleRight
        SairTabelaColuna.Location = New Point(735, 699)
        SairTabelaColuna.Margin = New Padding(3, 4, 3, 4)
        SairTabelaColuna.Name = "SairTabelaColuna"
        SairTabelaColuna.Size = New Size(135, 51)
        SairTabelaColuna.TabIndex = 22
        SairTabelaColuna.Text = "SAIR"
        SairTabelaColuna.TextAlign = ContentAlignment.MiddleLeft
        SairTabelaColuna.UseVisualStyleBackColor = True
        ' 
        ' Descricao_Coluna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 753)
        Controls.Add(SairTabelaColuna)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Descricao_Coluna"
        Text = "Descricao_Coluna"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SairTabelaColuna As Button
End Class

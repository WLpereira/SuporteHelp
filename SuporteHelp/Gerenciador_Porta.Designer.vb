<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerenciador_Porta
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
        PortaCbx = New ComboBox()
        AdicionarPortaLbl = New Label()
        PortaTxt = New TextBox()
        CadastrarBtn = New Button()
        ExcluirPortaBtn = New Button()
        SuspendLayout()
        ' 
        ' PortaCbx
        ' 
        PortaCbx.FormattingEnabled = True
        PortaCbx.Location = New Point(298, 31)
        PortaCbx.Name = "PortaCbx"
        PortaCbx.Size = New Size(132, 23)
        PortaCbx.TabIndex = 0
        ' 
        ' AdicionarPortaLbl
        ' 
        AdicionarPortaLbl.AutoSize = True
        AdicionarPortaLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AdicionarPortaLbl.Location = New Point(12, 12)
        AdicionarPortaLbl.Name = "AdicionarPortaLbl"
        AdicionarPortaLbl.Size = New Size(107, 17)
        AdicionarPortaLbl.TabIndex = 1
        AdicionarPortaLbl.Text = "Cadastrar  Porta"
        ' 
        ' PortaTxt
        ' 
        PortaTxt.Location = New Point(12, 32)
        PortaTxt.Name = "PortaTxt"
        PortaTxt.Size = New Size(174, 23)
        PortaTxt.TabIndex = 2
        ' 
        ' CadastrarBtn
        ' 
        CadastrarBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBtn.Location = New Point(192, 27)
        CadastrarBtn.Name = "CadastrarBtn"
        CadastrarBtn.Size = New Size(100, 29)
        CadastrarBtn.TabIndex = 3
        CadastrarBtn.Text = "Cadastrar"
        CadastrarBtn.UseVisualStyleBackColor = True
        ' 
        ' ExcluirPortaBtn
        ' 
        ExcluirPortaBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirPortaBtn.Location = New Point(436, 27)
        ExcluirPortaBtn.Name = "ExcluirPortaBtn"
        ExcluirPortaBtn.Size = New Size(100, 29)
        ExcluirPortaBtn.TabIndex = 4
        ExcluirPortaBtn.Text = "Excluir"
        ExcluirPortaBtn.UseVisualStyleBackColor = True
        ' 
        ' Gerenciador_Porta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExcluirPortaBtn)
        Controls.Add(CadastrarBtn)
        Controls.Add(PortaTxt)
        Controls.Add(AdicionarPortaLbl)
        Controls.Add(PortaCbx)
        Name = "Gerenciador_Porta"
        Text = "Gerenciador_de_Porta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PortaCbx As ComboBox
    Friend WithEvents AdicionarPortaLbl As Label
    Friend WithEvents PortaTxt As TextBox
    Friend WithEvents CadastrarBtn As Button
    Friend WithEvents ExcluirPortaBtn As Button
End Class

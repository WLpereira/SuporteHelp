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
        AtualizarListaBtn = New Button()
        ListarPortasCbx = New ComboBox()
        CarregarPortasBtn = New Button()
        CadastrarBancosTxt = New TextBox()
        CadastrarBancosLbl = New Label()
        CadastrarBancoBtn = New Button()
        ConteudoPortaCbx = New ComboBox()
        ExcluirBancoBtn = New Button()
        AtualizarConteudoBtn = New Button()
        SuspendLayout()
        ' 
        ' PortaCbx
        ' 
        PortaCbx.FormattingEnabled = True
        PortaCbx.Location = New Point(358, 36)
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
        ExcluirPortaBtn.Location = New Point(496, 32)
        ExcluirPortaBtn.Name = "ExcluirPortaBtn"
        ExcluirPortaBtn.Size = New Size(100, 29)
        ExcluirPortaBtn.TabIndex = 4
        ExcluirPortaBtn.Text = "Excluir"
        ExcluirPortaBtn.UseVisualStyleBackColor = True
        ' 
        ' AtualizarListaBtn
        ' 
        AtualizarListaBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarListaBtn.Location = New Point(358, 12)
        AtualizarListaBtn.Name = "AtualizarListaBtn"
        AtualizarListaBtn.Size = New Size(132, 24)
        AtualizarListaBtn.TabIndex = 5
        AtualizarListaBtn.Text = "Atualizar Lista"
        AtualizarListaBtn.UseVisualStyleBackColor = True
        ' 
        ' ListarPortasCbx
        ' 
        ListarPortasCbx.FormattingEnabled = True
        ListarPortasCbx.Location = New Point(306, 140)
        ListarPortasCbx.Name = "ListarPortasCbx"
        ListarPortasCbx.Size = New Size(132, 23)
        ListarPortasCbx.TabIndex = 6
        ' 
        ' CarregarPortasBtn
        ' 
        CarregarPortasBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarPortasBtn.Location = New Point(306, 110)
        CarregarPortasBtn.Name = "CarregarPortasBtn"
        CarregarPortasBtn.Size = New Size(132, 24)
        CarregarPortasBtn.TabIndex = 7
        CarregarPortasBtn.Text = "Listar Portas"
        CarregarPortasBtn.UseVisualStyleBackColor = True
        ' 
        ' CadastrarBancosTxt
        ' 
        CadastrarBancosTxt.Location = New Point(12, 247)
        CadastrarBancosTxt.Name = "CadastrarBancosTxt"
        CadastrarBancosTxt.Size = New Size(174, 23)
        CadastrarBancosTxt.TabIndex = 8
        ' 
        ' CadastrarBancosLbl
        ' 
        CadastrarBancosLbl.AutoSize = True
        CadastrarBancosLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancosLbl.Location = New Point(25, 220)
        CadastrarBancosLbl.Name = "CadastrarBancosLbl"
        CadastrarBancosLbl.Size = New Size(113, 17)
        CadastrarBancosLbl.TabIndex = 9
        CadastrarBancosLbl.Text = "Cadastrar Bancos"
        ' 
        ' CadastrarBancoBtn
        ' 
        CadastrarBancoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancoBtn.Location = New Point(192, 241)
        CadastrarBancoBtn.Name = "CadastrarBancoBtn"
        CadastrarBancoBtn.Size = New Size(100, 29)
        CadastrarBancoBtn.TabIndex = 10
        CadastrarBancoBtn.Text = "Cadastrar"
        CadastrarBancoBtn.UseVisualStyleBackColor = True
        ' 
        ' ConteudoPortaCbx
        ' 
        ConteudoPortaCbx.FormattingEnabled = True
        ConteudoPortaCbx.Location = New Point(331, 245)
        ConteudoPortaCbx.Name = "ConteudoPortaCbx"
        ConteudoPortaCbx.Size = New Size(132, 23)
        ConteudoPortaCbx.TabIndex = 11
        ' 
        ' ExcluirBancoBtn
        ' 
        ExcluirBancoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirBancoBtn.Location = New Point(506, 241)
        ExcluirBancoBtn.Name = "ExcluirBancoBtn"
        ExcluirBancoBtn.Size = New Size(100, 29)
        ExcluirBancoBtn.TabIndex = 12
        ExcluirBancoBtn.Text = "Excluir"
        ExcluirBancoBtn.UseVisualStyleBackColor = True
        ' 
        ' AtualizarConteudoBtn
        ' 
        AtualizarConteudoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarConteudoBtn.Location = New Point(331, 213)
        AtualizarConteudoBtn.Name = "AtualizarConteudoBtn"
        AtualizarConteudoBtn.Size = New Size(132, 24)
        AtualizarConteudoBtn.TabIndex = 13
        AtualizarConteudoBtn.Text = "Atualizar"
        AtualizarConteudoBtn.UseVisualStyleBackColor = True
        ' 
        ' Gerenciador_Porta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(AtualizarConteudoBtn)
        Controls.Add(ExcluirBancoBtn)
        Controls.Add(ConteudoPortaCbx)
        Controls.Add(CadastrarBancoBtn)
        Controls.Add(CadastrarBancosLbl)
        Controls.Add(CadastrarBancosTxt)
        Controls.Add(CarregarPortasBtn)
        Controls.Add(ListarPortasCbx)
        Controls.Add(AtualizarListaBtn)
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
    Friend WithEvents AtualizarListaBtn As Button
    Friend WithEvents ListarPortasCbx As ComboBox
    Friend WithEvents CarregarPortasBtn As Button
    Friend WithEvents CadastrarBancosTxt As TextBox
    Friend WithEvents CadastrarBancosLbl As Label
    Friend WithEvents CadastrarBancoBtn As Button
    Friend WithEvents ConteudoPortaCbx As ComboBox
    Friend WithEvents ExcluirBancoBtn As Button
    Friend WithEvents AtualizarConteudoBtn As Button
End Class

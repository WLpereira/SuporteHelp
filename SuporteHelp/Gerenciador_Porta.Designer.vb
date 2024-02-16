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
        PortaTxt = New TextBox()
        CadastrarBtn = New Button()
        ExcluirPortaBtn = New Button()
        AtualizarListaBtn = New Button()
        ListarPortasCbx = New ComboBox()
        CarregarPortasBtn = New Button()
        CadastrarBancosTxt = New TextBox()
        CadastrarBancoBtn = New Button()
        ConteudoPortaCbx = New ComboBox()
        ExcluirBancoBtn = New Button()
        AtualizarConteudoBtn = New Button()
        BancosGbx = New GroupBox()
        CadastrarPertasGbx = New GroupBox()
        BancosGbx.SuspendLayout()
        CadastrarPertasGbx.SuspendLayout()
        SuspendLayout()
        ' 
        ' PortaCbx
        ' 
        PortaCbx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaCbx.FormattingEnabled = True
        PortaCbx.Location = New Point(367, 68)
        PortaCbx.Name = "PortaCbx"
        PortaCbx.Size = New Size(132, 25)
        PortaCbx.TabIndex = 0
        ' 
        ' PortaTxt
        ' 
        PortaTxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaTxt.Location = New Point(22, 68)
        PortaTxt.Name = "PortaTxt"
        PortaTxt.Size = New Size(174, 25)
        PortaTxt.TabIndex = 2
        ' 
        ' CadastrarBtn
        ' 
        CadastrarBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBtn.ForeColor = Color.Black
        CadastrarBtn.Location = New Point(212, 64)
        CadastrarBtn.Name = "CadastrarBtn"
        CadastrarBtn.Size = New Size(100, 29)
        CadastrarBtn.TabIndex = 3
        CadastrarBtn.Text = "Cadastrar"
        CadastrarBtn.UseVisualStyleBackColor = True
        ' 
        ' ExcluirPortaBtn
        ' 
        ExcluirPortaBtn.BackColor = Color.Crimson
        ExcluirPortaBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirPortaBtn.ForeColor = Color.White
        ExcluirPortaBtn.Location = New Point(522, 55)
        ExcluirPortaBtn.Name = "ExcluirPortaBtn"
        ExcluirPortaBtn.Size = New Size(108, 49)
        ExcluirPortaBtn.TabIndex = 4
        ExcluirPortaBtn.Text = "Excluir Portas"
        ExcluirPortaBtn.UseVisualStyleBackColor = False
        ' 
        ' AtualizarListaBtn
        ' 
        AtualizarListaBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarListaBtn.ForeColor = Color.Black
        AtualizarListaBtn.Location = New Point(367, 38)
        AtualizarListaBtn.Name = "AtualizarListaBtn"
        AtualizarListaBtn.Size = New Size(132, 24)
        AtualizarListaBtn.TabIndex = 5
        AtualizarListaBtn.Text = "Atualizar Lista"
        AtualizarListaBtn.UseVisualStyleBackColor = True
        ' 
        ' ListarPortasCbx
        ' 
        ListarPortasCbx.FormattingEnabled = True
        ListarPortasCbx.Location = New Point(315, 224)
        ListarPortasCbx.Name = "ListarPortasCbx"
        ListarPortasCbx.Size = New Size(132, 23)
        ListarPortasCbx.TabIndex = 6
        ' 
        ' CarregarPortasBtn
        ' 
        CarregarPortasBtn.BackColor = Color.Yellow
        CarregarPortasBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarPortasBtn.ForeColor = SystemColors.ActiveCaptionText
        CarregarPortasBtn.Location = New Point(315, 176)
        CarregarPortasBtn.Name = "CarregarPortasBtn"
        CarregarPortasBtn.Size = New Size(132, 42)
        CarregarPortasBtn.TabIndex = 7
        CarregarPortasBtn.Text = "Listar Portas"
        CarregarPortasBtn.UseVisualStyleBackColor = False
        ' 
        ' CadastrarBancosTxt
        ' 
        CadastrarBancosTxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancosTxt.Location = New Point(31, 78)
        CadastrarBancosTxt.Name = "CadastrarBancosTxt"
        CadastrarBancosTxt.Size = New Size(174, 25)
        CadastrarBancosTxt.TabIndex = 8
        ' 
        ' CadastrarBancoBtn
        ' 
        CadastrarBancoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancoBtn.Location = New Point(221, 75)
        CadastrarBancoBtn.Name = "CadastrarBancoBtn"
        CadastrarBancoBtn.Size = New Size(100, 29)
        CadastrarBancoBtn.TabIndex = 10
        CadastrarBancoBtn.Text = "Cadastrar"
        CadastrarBancoBtn.UseVisualStyleBackColor = True
        ' 
        ' ConteudoPortaCbx
        ' 
        ConteudoPortaCbx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConteudoPortaCbx.FormattingEnabled = True
        ConteudoPortaCbx.Location = New Point(376, 79)
        ConteudoPortaCbx.Name = "ConteudoPortaCbx"
        ConteudoPortaCbx.Size = New Size(132, 25)
        ConteudoPortaCbx.TabIndex = 11
        ' 
        ' ExcluirBancoBtn
        ' 
        ExcluirBancoBtn.BackColor = Color.Chartreuse
        ExcluirBancoBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirBancoBtn.Location = New Point(531, 64)
        ExcluirBancoBtn.Name = "ExcluirBancoBtn"
        ExcluirBancoBtn.Size = New Size(108, 48)
        ExcluirBancoBtn.TabIndex = 12
        ExcluirBancoBtn.Text = "Excluir Banco Selecionado"
        ExcluirBancoBtn.UseVisualStyleBackColor = False
        ' 
        ' AtualizarConteudoBtn
        ' 
        AtualizarConteudoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarConteudoBtn.Location = New Point(376, 50)
        AtualizarConteudoBtn.Name = "AtualizarConteudoBtn"
        AtualizarConteudoBtn.Size = New Size(132, 24)
        AtualizarConteudoBtn.TabIndex = 13
        AtualizarConteudoBtn.Text = "Atualizar Lista"
        AtualizarConteudoBtn.UseVisualStyleBackColor = True
        ' 
        ' BancosGbx
        ' 
        BancosGbx.BackColor = Color.CornflowerBlue
        BancosGbx.Controls.Add(AtualizarConteudoBtn)
        BancosGbx.Controls.Add(ExcluirBancoBtn)
        BancosGbx.Controls.Add(ConteudoPortaCbx)
        BancosGbx.Controls.Add(CadastrarBancoBtn)
        BancosGbx.Controls.Add(CadastrarBancosTxt)
        BancosGbx.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BancosGbx.Location = New Point(27, 264)
        BancosGbx.Name = "BancosGbx"
        BancosGbx.Size = New Size(719, 159)
        BancosGbx.TabIndex = 14
        BancosGbx.TabStop = False
        BancosGbx.Text = "CADASTRAR BANCOS"
        ' 
        ' CadastrarPertasGbx
        ' 
        CadastrarPertasGbx.BackColor = SystemColors.ControlDarkDark
        CadastrarPertasGbx.Controls.Add(AtualizarListaBtn)
        CadastrarPertasGbx.Controls.Add(ExcluirPortaBtn)
        CadastrarPertasGbx.Controls.Add(CadastrarBtn)
        CadastrarPertasGbx.Controls.Add(PortaTxt)
        CadastrarPertasGbx.Controls.Add(PortaCbx)
        CadastrarPertasGbx.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarPertasGbx.ForeColor = Color.White
        CadastrarPertasGbx.Location = New Point(36, 12)
        CadastrarPertasGbx.Name = "CadastrarPertasGbx"
        CadastrarPertasGbx.Size = New Size(719, 159)
        CadastrarPertasGbx.TabIndex = 15
        CadastrarPertasGbx.TabStop = False
        CadastrarPertasGbx.Text = "CADASTRAR PORTAS"
        ' 
        ' Gerenciador_Porta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CadastrarPertasGbx)
        Controls.Add(BancosGbx)
        Controls.Add(CarregarPortasBtn)
        Controls.Add(ListarPortasCbx)
        Name = "Gerenciador_Porta"
        Text = "Gerenciador_de_Porta"
        BancosGbx.ResumeLayout(False)
        BancosGbx.PerformLayout()
        CadastrarPertasGbx.ResumeLayout(False)
        CadastrarPertasGbx.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PortaCbx As ComboBox
    Friend WithEvents PortaTxt As TextBox
    Friend WithEvents CadastrarBtn As Button
    Friend WithEvents ExcluirPortaBtn As Button
    Friend WithEvents AtualizarListaBtn As Button
    Friend WithEvents ListarPortasCbx As ComboBox
    Friend WithEvents CarregarPortasBtn As Button
    Friend WithEvents CadastrarBancosTxt As TextBox
    Friend WithEvents CadastrarBancoBtn As Button
    Friend WithEvents ConteudoPortaCbx As ComboBox
    Friend WithEvents ExcluirBancoBtn As Button
    Friend WithEvents AtualizarConteudoBtn As Button
    Friend WithEvents BancosGbx As GroupBox
    Friend WithEvents CadastrarPertasGbx As GroupBox
End Class

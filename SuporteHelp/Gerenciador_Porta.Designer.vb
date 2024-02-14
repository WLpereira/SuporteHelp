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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerenciador_Porta))
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
        GerenciadorPortasGB = New GroupBox()
        GerenciadorbancoGB = New GroupBox()
        GerenciadorPortasGB.SuspendLayout()
        GerenciadorbancoGB.SuspendLayout()
        SuspendLayout()
        ' 
        ' PortaCbx
        ' 
        PortaCbx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaCbx.FormattingEnabled = True
        PortaCbx.Location = New Point(496, 50)
        PortaCbx.Name = "PortaCbx"
        PortaCbx.Size = New Size(132, 25)
        PortaCbx.TabIndex = 0
        ' 
        ' AdicionarPortaLbl
        ' 
        AdicionarPortaLbl.AutoSize = True
        AdicionarPortaLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AdicionarPortaLbl.ForeColor = Color.Black
        AdicionarPortaLbl.Location = New Point(312, 30)
        AdicionarPortaLbl.Name = "AdicionarPortaLbl"
        AdicionarPortaLbl.Size = New Size(107, 17)
        AdicionarPortaLbl.TabIndex = 1
        AdicionarPortaLbl.Text = "Cadastrar  Porta"
        ' 
        ' PortaTxt
        ' 
        PortaTxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaTxt.Location = New Point(281, 50)
        PortaTxt.Name = "PortaTxt"
        PortaTxt.Size = New Size(174, 25)
        PortaTxt.TabIndex = 2
        ' 
        ' CadastrarBtn
        ' 
        CadastrarBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBtn.ForeColor = Color.Black
        CadastrarBtn.Location = New Point(319, 81)
        CadastrarBtn.Name = "CadastrarBtn"
        CadastrarBtn.Size = New Size(100, 29)
        CadastrarBtn.TabIndex = 3
        CadastrarBtn.Text = "Cadastrar"
        CadastrarBtn.UseVisualStyleBackColor = True
        ' 
        ' ExcluirPortaBtn
        ' 
        ExcluirPortaBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExcluirPortaBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirPortaBtn.ForeColor = Color.White
        ExcluirPortaBtn.Location = New Point(501, 81)
        ExcluirPortaBtn.Name = "ExcluirPortaBtn"
        ExcluirPortaBtn.Size = New Size(121, 43)
        ExcluirPortaBtn.TabIndex = 4
        ExcluirPortaBtn.Text = "Excluir Porta Selecionada "
        ExcluirPortaBtn.UseVisualStyleBackColor = False
        ' 
        ' AtualizarListaBtn
        ' 
        AtualizarListaBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarListaBtn.ForeColor = Color.Black
        AtualizarListaBtn.Location = New Point(496, 23)
        AtualizarListaBtn.Name = "AtualizarListaBtn"
        AtualizarListaBtn.Size = New Size(132, 24)
        AtualizarListaBtn.TabIndex = 5
        AtualizarListaBtn.Text = "Atualizar"
        AtualizarListaBtn.UseVisualStyleBackColor = True
        ' 
        ' ListarPortasCbx
        ' 
        ListarPortasCbx.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ListarPortasCbx.FormattingEnabled = True
        ListarPortasCbx.Location = New Point(327, 222)
        ListarPortasCbx.Name = "ListarPortasCbx"
        ListarPortasCbx.Size = New Size(162, 28)
        ListarPortasCbx.TabIndex = 6
        ' 
        ' CarregarPortasBtn
        ' 
        CarregarPortasBtn.BackColor = Color.Yellow
        CarregarPortasBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarPortasBtn.ForeColor = Color.Red
        CarregarPortasBtn.Location = New Point(343, 177)
        CarregarPortasBtn.Name = "CarregarPortasBtn"
        CarregarPortasBtn.Size = New Size(132, 37)
        CarregarPortasBtn.TabIndex = 7
        CarregarPortasBtn.Text = "Listar Portas"
        CarregarPortasBtn.UseVisualStyleBackColor = False
        ' 
        ' CadastrarBancosTxt
        ' 
        CadastrarBancosTxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancosTxt.Location = New Point(226, 57)
        CadastrarBancosTxt.Name = "CadastrarBancosTxt"
        CadastrarBancosTxt.Size = New Size(218, 25)
        CadastrarBancosTxt.TabIndex = 8
        ' 
        ' CadastrarBancosLbl
        ' 
        CadastrarBancosLbl.AutoSize = True
        CadastrarBancosLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancosLbl.ForeColor = Color.Black
        CadastrarBancosLbl.Location = New Point(283, 30)
        CadastrarBancosLbl.Name = "CadastrarBancosLbl"
        CadastrarBancosLbl.Size = New Size(113, 17)
        CadastrarBancosLbl.TabIndex = 9
        CadastrarBancosLbl.Text = "Cadastrar Bancos"
        ' 
        ' CadastrarBancoBtn
        ' 
        CadastrarBancoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarBancoBtn.ForeColor = Color.Black
        CadastrarBancoBtn.Location = New Point(283, 88)
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
        ConteudoPortaCbx.Location = New Point(498, 57)
        ConteudoPortaCbx.Name = "ConteudoPortaCbx"
        ConteudoPortaCbx.Size = New Size(209, 25)
        ConteudoPortaCbx.TabIndex = 11
        ' 
        ' ExcluirBancoBtn
        ' 
        ExcluirBancoBtn.BackColor = Color.Red
        ExcluirBancoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirBancoBtn.ForeColor = Color.White
        ExcluirBancoBtn.Location = New Point(541, 88)
        ExcluirBancoBtn.Name = "ExcluirBancoBtn"
        ExcluirBancoBtn.Size = New Size(121, 43)
        ExcluirBancoBtn.TabIndex = 12
        ExcluirBancoBtn.Text = "Excluir Bancos"
        ExcluirBancoBtn.UseVisualStyleBackColor = False
        ' 
        ' AtualizarConteudoBtn
        ' 
        AtualizarConteudoBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AtualizarConteudoBtn.ForeColor = Color.Black
        AtualizarConteudoBtn.Location = New Point(540, 30)
        AtualizarConteudoBtn.Name = "AtualizarConteudoBtn"
        AtualizarConteudoBtn.Size = New Size(132, 24)
        AtualizarConteudoBtn.TabIndex = 13
        AtualizarConteudoBtn.Text = "Atualizar"
        AtualizarConteudoBtn.UseVisualStyleBackColor = True
        ' 
        ' GerenciadorPortasGB
        ' 
        GerenciadorPortasGB.BackColor = Color.Silver
        GerenciadorPortasGB.Controls.Add(AtualizarListaBtn)
        GerenciadorPortasGB.Controls.Add(ExcluirPortaBtn)
        GerenciadorPortasGB.Controls.Add(CadastrarBtn)
        GerenciadorPortasGB.Controls.Add(PortaTxt)
        GerenciadorPortasGB.Controls.Add(AdicionarPortaLbl)
        GerenciadorPortasGB.Controls.Add(PortaCbx)
        GerenciadorPortasGB.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        GerenciadorPortasGB.ForeColor = Color.Blue
        GerenciadorPortasGB.Location = New Point(31, 8)
        GerenciadorPortasGB.Name = "GerenciadorPortasGB"
        GerenciadorPortasGB.Size = New Size(744, 158)
        GerenciadorPortasGB.TabIndex = 15
        GerenciadorPortasGB.TabStop = False
        GerenciadorPortasGB.Text = "Gerenciador de Portas"
        ' 
        ' GerenciadorbancoGB
        ' 
        GerenciadorbancoGB.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        GerenciadorbancoGB.Controls.Add(AtualizarConteudoBtn)
        GerenciadorbancoGB.Controls.Add(ExcluirBancoBtn)
        GerenciadorbancoGB.Controls.Add(ConteudoPortaCbx)
        GerenciadorbancoGB.Controls.Add(CadastrarBancoBtn)
        GerenciadorbancoGB.Controls.Add(CadastrarBancosLbl)
        GerenciadorbancoGB.Controls.Add(CadastrarBancosTxt)
        GerenciadorbancoGB.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        GerenciadorbancoGB.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        GerenciadorbancoGB.Location = New Point(29, 266)
        GerenciadorbancoGB.Name = "GerenciadorbancoGB"
        GerenciadorbancoGB.Size = New Size(741, 163)
        GerenciadorbancoGB.TabIndex = 16
        GerenciadorbancoGB.TabStop = False
        GerenciadorbancoGB.Text = "Gerenciador de Banco"
        ' 
        ' Gerenciador_Porta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GerenciadorbancoGB)
        Controls.Add(GerenciadorPortasGB)
        Controls.Add(CarregarPortasBtn)
        Controls.Add(ListarPortasCbx)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Gerenciador_Porta"
        Text = "Gerenciador_de_Porta"
        GerenciadorPortasGB.ResumeLayout(False)
        GerenciadorPortasGB.PerformLayout()
        GerenciadorbancoGB.ResumeLayout(False)
        GerenciadorbancoGB.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents GerenciadorPortasGB As GroupBox
    Friend WithEvents GerenciadorbancoGB As GroupBox
End Class

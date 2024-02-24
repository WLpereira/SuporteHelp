<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresas))
        CadastrarEmpresasGbx = New GroupBox()
        LimparCadastroBtn = New Button()
        CadastrarEmpresaBtn = New Button()
        PortaLbl = New Label()
        SenhaSALbl = New Label()
        ServidorEmpresaLbl = New Label()
        NomeEmpresaLbl = New Label()
        PortaEmpresaTxb = New TextBox()
        SenhaSATxb = New TextBox()
        ServidorEmpresaTxb = New TextBox()
        NomeEmpresaTxb = New TextBox()
        EmpresasDgv = New DataGridView()
        LimparEmpresasBtn = New Button()
        VoltarBtn = New Button()
        FiltrarPortaTxb = New TextBox()
        FiltrarBtn = New Button()
        ProcurarPortaLbl = New Label()
        CarregarBtn = New Button()
        ExcluirEmpresaBtn = New Button()
        ExcluirBtn = New Label()
        Label1 = New Label()
        FiltrarNomeBtn = New Button()
        FiltrarNomeTxt = New TextBox()
        CadastrarEmpresasGbx.SuspendLayout()
        CType(EmpresasDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CadastrarEmpresasGbx
        ' 
        CadastrarEmpresasGbx.BackColor = SystemColors.ScrollBar
        CadastrarEmpresasGbx.Controls.Add(LimparCadastroBtn)
        CadastrarEmpresasGbx.Controls.Add(CadastrarEmpresaBtn)
        CadastrarEmpresasGbx.Controls.Add(PortaLbl)
        CadastrarEmpresasGbx.Controls.Add(SenhaSALbl)
        CadastrarEmpresasGbx.Controls.Add(ServidorEmpresaLbl)
        CadastrarEmpresasGbx.Controls.Add(NomeEmpresaLbl)
        CadastrarEmpresasGbx.Controls.Add(PortaEmpresaTxb)
        CadastrarEmpresasGbx.Controls.Add(SenhaSATxb)
        CadastrarEmpresasGbx.Controls.Add(ServidorEmpresaTxb)
        CadastrarEmpresasGbx.Controls.Add(NomeEmpresaTxb)
        CadastrarEmpresasGbx.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarEmpresasGbx.ForeColor = Color.Navy
        CadastrarEmpresasGbx.Location = New Point(42, 12)
        CadastrarEmpresasGbx.Name = "CadastrarEmpresasGbx"
        CadastrarEmpresasGbx.Size = New Size(976, 166)
        CadastrarEmpresasGbx.TabIndex = 0
        CadastrarEmpresasGbx.TabStop = False
        CadastrarEmpresasGbx.Text = "Cadastrar Empresa"
        ' 
        ' LimparCadastroBtn
        ' 
        LimparCadastroBtn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LimparCadastroBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        LimparCadastroBtn.ForeColor = Color.White
        LimparCadastroBtn.Location = New Point(498, 107)
        LimparCadastroBtn.Name = "LimparCadastroBtn"
        LimparCadastroBtn.Size = New Size(118, 43)
        LimparCadastroBtn.TabIndex = 9
        LimparCadastroBtn.Text = "Limpar"
        LimparCadastroBtn.UseVisualStyleBackColor = False
        ' 
        ' CadastrarEmpresaBtn
        ' 
        CadastrarEmpresaBtn.BackColor = Color.Yellow
        CadastrarEmpresaBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CadastrarEmpresaBtn.Location = New Point(337, 107)
        CadastrarEmpresaBtn.Name = "CadastrarEmpresaBtn"
        CadastrarEmpresaBtn.Size = New Size(118, 43)
        CadastrarEmpresaBtn.TabIndex = 8
        CadastrarEmpresaBtn.Text = "Cadastrar"
        CadastrarEmpresaBtn.UseVisualStyleBackColor = False
        ' 
        ' PortaLbl
        ' 
        PortaLbl.AutoSize = True
        PortaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PortaLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PortaLbl.Location = New Point(771, 34)
        PortaLbl.Name = "PortaLbl"
        PortaLbl.Size = New Size(51, 21)
        PortaLbl.TabIndex = 7
        PortaLbl.Text = "Porta"
        ' 
        ' SenhaSALbl
        ' 
        SenhaSALbl.AutoSize = True
        SenhaSALbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaSALbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SenhaSALbl.Location = New Point(535, 34)
        SenhaSALbl.Name = "SenhaSALbl"
        SenhaSALbl.Size = New Size(81, 21)
        SenhaSALbl.TabIndex = 6
        SenhaSALbl.Text = "Senha SA"
        ' 
        ' ServidorEmpresaLbl
        ' 
        ServidorEmpresaLbl.AutoSize = True
        ServidorEmpresaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorEmpresaLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ServidorEmpresaLbl.Location = New Point(283, 34)
        ServidorEmpresaLbl.Name = "ServidorEmpresaLbl"
        ServidorEmpresaLbl.Size = New Size(75, 21)
        ServidorEmpresaLbl.TabIndex = 5
        ServidorEmpresaLbl.Text = "Servidor"
        ' 
        ' NomeEmpresaLbl
        ' 
        NomeEmpresaLbl.AutoSize = True
        NomeEmpresaLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NomeEmpresaLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NomeEmpresaLbl.Location = New Point(6, 34)
        NomeEmpresaLbl.Name = "NomeEmpresaLbl"
        NomeEmpresaLbl.Size = New Size(61, 21)
        NomeEmpresaLbl.TabIndex = 4
        NomeEmpresaLbl.Text = "Nome "
        ' 
        ' PortaEmpresaTxb
        ' 
        PortaEmpresaTxb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        PortaEmpresaTxb.Location = New Point(771, 58)
        PortaEmpresaTxb.Name = "PortaEmpresaTxb"
        PortaEmpresaTxb.Size = New Size(164, 25)
        PortaEmpresaTxb.TabIndex = 3
        ' 
        ' SenhaSATxb
        ' 
        SenhaSATxb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaSATxb.Location = New Point(535, 58)
        SenhaSATxb.Name = "SenhaSATxb"
        SenhaSATxb.Size = New Size(164, 25)
        SenhaSATxb.TabIndex = 2
        ' 
        ' ServidorEmpresaTxb
        ' 
        ServidorEmpresaTxb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorEmpresaTxb.Location = New Point(283, 58)
        ServidorEmpresaTxb.Name = "ServidorEmpresaTxb"
        ServidorEmpresaTxb.Size = New Size(164, 25)
        ServidorEmpresaTxb.TabIndex = 1
        ' 
        ' NomeEmpresaTxb
        ' 
        NomeEmpresaTxb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        NomeEmpresaTxb.Location = New Point(6, 58)
        NomeEmpresaTxb.Name = "NomeEmpresaTxb"
        NomeEmpresaTxb.Size = New Size(228, 25)
        NomeEmpresaTxb.TabIndex = 0
        ' 
        ' EmpresasDgv
        ' 
        EmpresasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmpresasDgv.Location = New Point(42, 284)
        EmpresasDgv.Name = "EmpresasDgv"
        EmpresasDgv.RowTemplate.Height = 25
        EmpresasDgv.Size = New Size(976, 409)
        EmpresasDgv.TabIndex = 1
        ' 
        ' LimparEmpresasBtn
        ' 
        LimparEmpresasBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LimparEmpresasBtn.Location = New Point(897, 699)
        LimparEmpresasBtn.Name = "LimparEmpresasBtn"
        LimparEmpresasBtn.Size = New Size(121, 38)
        LimparEmpresasBtn.TabIndex = 2
        LimparEmpresasBtn.Text = "Limpar"
        LimparEmpresasBtn.UseVisualStyleBackColor = True
        ' 
        ' VoltarBtn
        ' 
        VoltarBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        VoltarBtn.Location = New Point(42, 699)
        VoltarBtn.Name = "VoltarBtn"
        VoltarBtn.Size = New Size(121, 38)
        VoltarBtn.TabIndex = 3
        VoltarBtn.Text = "Voltar"
        VoltarBtn.UseVisualStyleBackColor = True
        ' 
        ' FiltrarPortaTxb
        ' 
        FiltrarPortaTxb.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FiltrarPortaTxb.Location = New Point(42, 209)
        FiltrarPortaTxb.Name = "FiltrarPortaTxb"
        FiltrarPortaTxb.Size = New Size(145, 25)
        FiltrarPortaTxb.TabIndex = 4
        ' 
        ' FiltrarBtn
        ' 
        FiltrarBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FiltrarBtn.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        FiltrarBtn.Location = New Point(51, 240)
        FiltrarBtn.Name = "FiltrarBtn"
        FiltrarBtn.Size = New Size(121, 38)
        FiltrarBtn.TabIndex = 5
        FiltrarBtn.Text = "FILTRAR"
        FiltrarBtn.UseVisualStyleBackColor = True
        ' 
        ' ProcurarPortaLbl
        ' 
        ProcurarPortaLbl.AutoSize = True
        ProcurarPortaLbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ProcurarPortaLbl.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ProcurarPortaLbl.Location = New Point(42, 181)
        ProcurarPortaLbl.Name = "ProcurarPortaLbl"
        ProcurarPortaLbl.Size = New Size(145, 25)
        ProcurarPortaLbl.TabIndex = 6
        ProcurarPortaLbl.Text = "Procurar Porta"
        ' 
        ' CarregarBtn
        ' 
        CarregarBtn.BackColor = SystemColors.ActiveCaptionText
        CarregarBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CarregarBtn.ForeColor = Color.Orange
        CarregarBtn.Location = New Point(426, 227)
        CarregarBtn.Name = "CarregarBtn"
        CarregarBtn.Size = New Size(188, 56)
        CarregarBtn.TabIndex = 7
        CarregarBtn.Text = "CARREGAR"
        CarregarBtn.UseVisualStyleBackColor = False
        ' 
        ' ExcluirEmpresaBtn
        ' 
        ExcluirEmpresaBtn.BackColor = Color.Red
        ExcluirEmpresaBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirEmpresaBtn.ForeColor = Color.White
        ExcluirEmpresaBtn.Location = New Point(855, 231)
        ExcluirEmpresaBtn.Name = "ExcluirEmpresaBtn"
        ExcluirEmpresaBtn.Size = New Size(163, 47)
        ExcluirEmpresaBtn.TabIndex = 8
        ExcluirEmpresaBtn.Text = "EXCLUIR"
        ExcluirEmpresaBtn.UseVisualStyleBackColor = False
        ' 
        ' ExcluirBtn
        ' 
        ExcluirBtn.AutoSize = True
        ExcluirBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExcluirBtn.ForeColor = Color.Red
        ExcluirBtn.Location = New Point(875, 207)
        ExcluirBtn.Name = "ExcluirBtn"
        ExcluirBtn.Size = New Size(131, 21)
        ExcluirBtn.TabIndex = 9
        ExcluirBtn.Text = "Excluir Empresa"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(219, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 25)
        Label1.TabIndex = 12
        Label1.Text = "Procurar Nome"
        ' 
        ' FiltrarNomeBtn
        ' 
        FiltrarNomeBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FiltrarNomeBtn.ForeColor = Color.Blue
        FiltrarNomeBtn.Location = New Point(230, 240)
        FiltrarNomeBtn.Name = "FiltrarNomeBtn"
        FiltrarNomeBtn.Size = New Size(121, 38)
        FiltrarNomeBtn.TabIndex = 11
        FiltrarNomeBtn.Text = "FILTRAR"
        FiltrarNomeBtn.UseVisualStyleBackColor = True
        ' 
        ' FiltrarNomeTxt
        ' 
        FiltrarNomeTxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FiltrarNomeTxt.Location = New Point(219, 209)
        FiltrarNomeTxt.Name = "FiltrarNomeTxt"
        FiltrarNomeTxt.Size = New Size(145, 25)
        FiltrarNomeTxt.TabIndex = 10
        ' 
        ' Empresas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
        Controls.Add(Label1)
        Controls.Add(FiltrarNomeBtn)
        Controls.Add(FiltrarNomeTxt)
        Controls.Add(ExcluirBtn)
        Controls.Add(ExcluirEmpresaBtn)
        Controls.Add(CarregarBtn)
        Controls.Add(ProcurarPortaLbl)
        Controls.Add(FiltrarBtn)
        Controls.Add(FiltrarPortaTxb)
        Controls.Add(VoltarBtn)
        Controls.Add(LimparEmpresasBtn)
        Controls.Add(EmpresasDgv)
        Controls.Add(CadastrarEmpresasGbx)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Empresas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Empresas"
        CadastrarEmpresasGbx.ResumeLayout(False)
        CadastrarEmpresasGbx.PerformLayout()
        CType(EmpresasDgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CadastrarEmpresasGbx As GroupBox
    Friend WithEvents NomeEmpresaTxb As TextBox
    Friend WithEvents NomeEmpresaLbl As Label
    Friend WithEvents PortaEmpresaTxb As TextBox
    Friend WithEvents SenhaSATxb As TextBox
    Friend WithEvents ServidorEmpresaTxb As TextBox
    Friend WithEvents LimparCadastroBtn As Button
    Friend WithEvents CadastrarEmpresaBtn As Button
    Friend WithEvents PortaLbl As Label
    Friend WithEvents SenhaSALbl As Label
    Friend WithEvents ServidorEmpresaLbl As Label
    Friend WithEvents EmpresasDgv As DataGridView
    Friend WithEvents LimparEmpresasBtn As Button
    Friend WithEvents VoltarBtn As Button
    Friend WithEvents FiltrarPortaTxb As TextBox
    Friend WithEvents FiltrarBtn As Button
    Friend WithEvents ProcurarPortaLbl As Label
    Friend WithEvents CarregarBtn As Button
    Friend WithEvents ExcluirEmpresaBtn As Button
    Friend WithEvents ExcluirBtn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FiltrarNomeBtn As Button
    Friend WithEvents FiltrarNomeTxt As TextBox
End Class

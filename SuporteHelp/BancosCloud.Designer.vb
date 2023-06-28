<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosCloud
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BancosCloud))
        UsernameTxb = New TextBox()
        SenhaTxb = New TextBox()
        LoginUsuarioLbl = New Label()
        SenhaLoginLbl = New Label()
        LimparCloudBtn = New Button()
        ConectarClodBtn = New Button()
        MostrarServidorCbx = New ComboBox()
        AlterarBtn = New Button()
        ServidorLbl = New Label()
        ServidorCloudTxb = New TextBox()
        SelecionarBancoLbl = New Label()
        SenhaOriginalTxb = New TextBox()
        SenhadoservidorLbl = New Label()
        Button1 = New Button()
        SelecinarServidorLbl = New Label()
        ExibirServidorCloudCbx = New ComboBox()
        SuspendLayout()
        ' 
        ' UsernameTxb
        ' 
        UsernameTxb.BorderStyle = BorderStyle.FixedSingle
        UsernameTxb.Location = New Point(197, 36)
        UsernameTxb.Margin = New Padding(3, 4, 3, 4)
        UsernameTxb.Name = "UsernameTxb"
        UsernameTxb.Size = New Size(197, 27)
        UsernameTxb.TabIndex = 1
        ' 
        ' SenhaTxb
        ' 
        SenhaTxb.BackColor = Color.White
        SenhaTxb.BorderStyle = BorderStyle.FixedSingle
        SenhaTxb.Location = New Point(400, 36)
        SenhaTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaTxb.Name = "SenhaTxb"
        SenhaTxb.Size = New Size(172, 27)
        SenhaTxb.TabIndex = 2
        ' 
        ' LoginUsuarioLbl
        ' 
        LoginUsuarioLbl.AutoSize = True
        LoginUsuarioLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoginUsuarioLbl.Location = New Point(192, 8)
        LoginUsuarioLbl.Name = "LoginUsuarioLbl"
        LoginUsuarioLbl.Size = New Size(70, 23)
        LoginUsuarioLbl.TabIndex = 3
        LoginUsuarioLbl.Text = "Usuario"
        ' 
        ' SenhaLoginLbl
        ' 
        SenhaLoginLbl.AutoSize = True
        SenhaLoginLbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        SenhaLoginLbl.ForeColor = Color.Red
        SenhaLoginLbl.Location = New Point(137, 330)
        SenhaLoginLbl.Name = "SenhaLoginLbl"
        SenhaLoginLbl.Size = New Size(330, 25)
        SenhaLoginLbl.TabIndex = 5
        SenhaLoginLbl.Text = "SENHA ""SA"" ORIGINAL DA EMPRESA"
        ' 
        ' LimparCloudBtn
        ' 
        LimparCloudBtn.Anchor = AnchorStyles.None
        LimparCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LimparCloudBtn.Image = My.Resources.Resources.icons8_broom_with_a_lot_of_dust_30
        LimparCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        LimparCloudBtn.Location = New Point(23, 498)
        LimparCloudBtn.Margin = New Padding(5, 4, 5, 4)
        LimparCloudBtn.Name = "LimparCloudBtn"
        LimparCloudBtn.Size = New Size(109, 43)
        LimparCloudBtn.TabIndex = 1
        LimparCloudBtn.Text = "Limpar"
        LimparCloudBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ConectarClodBtn
        ' 
        ConectarClodBtn.Anchor = AnchorStyles.None
        ConectarClodBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarClodBtn.Image = My.Resources.Resources.icons8_conectado_24
        ConectarClodBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarClodBtn.Location = New Point(226, 265)
        ConectarClodBtn.Margin = New Padding(5, 4, 5, 4)
        ConectarClodBtn.Name = "ConectarClodBtn"
        ConectarClodBtn.Size = New Size(130, 35)
        ConectarClodBtn.TabIndex = 0
        ConectarClodBtn.Text = "Conectar "
        ConectarClodBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MostrarServidorCbx
        ' 
        MostrarServidorCbx.FormattingEnabled = True
        MostrarServidorCbx.Location = New Point(169, 230)
        MostrarServidorCbx.Name = "MostrarServidorCbx"
        MostrarServidorCbx.Size = New Size(241, 28)
        MostrarServidorCbx.TabIndex = 6
        ' 
        ' AlterarBtn
        ' 
        AlterarBtn.Anchor = AnchorStyles.None
        AlterarBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AlterarBtn.Image = My.Resources.Resources.icons8_sql_server_64
        AlterarBtn.ImageAlign = ContentAlignment.MiddleLeft
        AlterarBtn.Location = New Point(216, 450)
        AlterarBtn.Margin = New Padding(5, 4, 5, 4)
        AlterarBtn.Name = "AlterarBtn"
        AlterarBtn.Size = New Size(162, 67)
        AlterarBtn.TabIndex = 7
        AlterarBtn.Text = "Alterar"
        AlterarBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ServidorLbl
        ' 
        ServidorLbl.AutoSize = True
        ServidorLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServidorLbl.Location = New Point(3, 8)
        ServidorLbl.Name = "ServidorLbl"
        ServidorLbl.Size = New Size(79, 23)
        ServidorLbl.TabIndex = 9
        ServidorLbl.Text = "Servidor"
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.BorderStyle = BorderStyle.FixedSingle
        ServidorCloudTxb.Location = New Point(8, 36)
        ServidorCloudTxb.Margin = New Padding(3, 4, 3, 4)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(183, 27)
        ServidorCloudTxb.TabIndex = 8
        ' 
        ' SelecionarBancoLbl
        ' 
        SelecionarBancoLbl.AutoSize = True
        SelecionarBancoLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SelecionarBancoLbl.Location = New Point(216, 190)
        SelecionarBancoLbl.Name = "SelecionarBancoLbl"
        SelecionarBancoLbl.Size = New Size(145, 23)
        SelecionarBancoLbl.TabIndex = 10
        SelecionarBancoLbl.Text = "Selecionar Banco"
        ' 
        ' SenhaOriginalTxb
        ' 
        SenhaOriginalTxb.BackColor = Color.White
        SenhaOriginalTxb.BorderStyle = BorderStyle.FixedSingle
        SenhaOriginalTxb.Location = New Point(172, 368)
        SenhaOriginalTxb.Margin = New Padding(3, 4, 3, 4)
        SenhaOriginalTxb.Name = "SenhaOriginalTxb"
        SenhaOriginalTxb.Size = New Size(249, 27)
        SenhaOriginalTxb.TabIndex = 11
        ' 
        ' SenhadoservidorLbl
        ' 
        SenhadoservidorLbl.AutoSize = True
        SenhadoservidorLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SenhadoservidorLbl.Location = New Point(405, 11)
        SenhadoservidorLbl.Name = "SenhadoservidorLbl"
        SenhadoservidorLbl.Size = New Size(163, 23)
        SenhadoservidorLbl.TabIndex = 12
        SenhadoservidorLbl.Text = "Senha do Servidor "
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.icons8_saída_de_emergência_30
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(464, 498)
        Button1.Margin = New Padding(5, 4, 5, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 43)
        Button1.TabIndex = 14
        Button1.Text = "Sair"
        Button1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(12, 101)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(221, 23)
        SelecinarServidorLbl.TabIndex = 33
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorCloudCbx
        ' 
        ExibirServidorCloudCbx.FormattingEnabled = True
        ExibirServidorCloudCbx.Location = New Point(12, 138)
        ExibirServidorCloudCbx.Name = "ExibirServidorCloudCbx"
        ExibirServidorCloudCbx.Size = New Size(183, 28)
        ExibirServidorCloudCbx.TabIndex = 32
        ' 
        ' BancosCloud
        ' 
        AcceptButton = ConectarClodBtn
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = LimparCloudBtn
        ClientSize = New Size(582, 553)
        Controls.Add(SelecinarServidorLbl)
        Controls.Add(ExibirServidorCloudCbx)
        Controls.Add(Button1)
        Controls.Add(SenhadoservidorLbl)
        Controls.Add(SenhaOriginalTxb)
        Controls.Add(SelecionarBancoLbl)
        Controls.Add(ServidorLbl)
        Controls.Add(ServidorCloudTxb)
        Controls.Add(AlterarBtn)
        Controls.Add(MostrarServidorCbx)
        Controls.Add(ConectarClodBtn)
        Controls.Add(SenhaLoginLbl)
        Controls.Add(LimparCloudBtn)
        Controls.Add(LoginUsuarioLbl)
        Controls.Add(SenhaTxb)
        Controls.Add(UsernameTxb)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BancosCloud"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bancos Cloud"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UsernameTxb As TextBox
    Friend WithEvents SenhaTxb As TextBox
    Friend WithEvents LoginUsuarioLbl As Label
    Friend WithEvents SenhaLoginLbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents LimparCloudBtn As Button
    Friend WithEvents ConectarClodBtn As Button
    Friend WithEvents MostrarServidorCbx As ComboBox
    Friend WithEvents AlterarBtn As Button
    Friend WithEvents ServidorLbl As Label
    Friend WithEvents ServidorCloudTxb As TextBox
    Friend WithEvents SelecionarBancoLbl As Label
    Friend WithEvents SenhaOriginalTxb As TextBox
    Friend WithEvents SenhadoservidorLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SelecinarServidorLbl As Label
    Friend WithEvents ExibirServidorCloudCbx As ComboBox
End Class

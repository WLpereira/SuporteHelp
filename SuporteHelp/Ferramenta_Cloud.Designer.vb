<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ferramenta_Cloud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ferramenta_Cloud))
        ServidorCloudTxb = New TextBox()
        ServidorConectarLbl = New Label()
        SelecinarServidorLbl = New Label()
        ExibirServidorCloudCbx = New ComboBox()
        ConectarCloudBtn = New Button()
        SenhaCloudTxb = New TextBox()
        NomeConectarCloudTxb = New TextBox()
        SenhaConectarLbl = New Label()
        UsuarioConectarLbl = New Label()
        ListadeServidorCloudDtg = New DataGridView()
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ServidorCloudTxb
        ' 
        ServidorCloudTxb.Location = New Point(12, 47)
        ServidorCloudTxb.Name = "ServidorCloudTxb"
        ServidorCloudTxb.Size = New Size(281, 23)
        ServidorCloudTxb.TabIndex = 6
        ' 
        ' ServidorConectarLbl
        ' 
        ServidorConectarLbl.AutoSize = True
        ServidorConectarLbl.Location = New Point(12, 27)
        ServidorConectarLbl.Name = "ServidorConectarLbl"
        ServidorConectarLbl.Size = New Size(105, 15)
        ServidorConectarLbl.TabIndex = 5
        ServidorConectarLbl.Text = "Informe o Servidor"
        ' 
        ' SelecinarServidorLbl
        ' 
        SelecinarServidorLbl.AutoSize = True
        SelecinarServidorLbl.ForeColor = Color.Red
        SelecinarServidorLbl.Location = New Point(12, 75)
        SelecinarServidorLbl.Name = "SelecinarServidorLbl"
        SelecinarServidorLbl.Size = New Size(143, 15)
        SelecinarServidorLbl.TabIndex = 38
        SelecinarServidorLbl.Text = "Selecionar Servidor Salvos"
        ' 
        ' ExibirServidorCloudCbx
        ' 
        ExibirServidorCloudCbx.FormattingEnabled = True
        ExibirServidorCloudCbx.Location = New Point(12, 101)
        ExibirServidorCloudCbx.Name = "ExibirServidorCloudCbx"
        ExibirServidorCloudCbx.Size = New Size(210, 23)
        ExibirServidorCloudCbx.TabIndex = 37
        ' 
        ' ConectarCloudBtn
        ' 
        ConectarCloudBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ConectarCloudBtn.Image = CType(resources.GetObject("ConectarCloudBtn.Image"), Image)
        ConectarCloudBtn.ImageAlign = ContentAlignment.MiddleLeft
        ConectarCloudBtn.Location = New Point(732, 32)
        ConectarCloudBtn.Name = "ConectarCloudBtn"
        ConectarCloudBtn.Size = New Size(118, 38)
        ConectarCloudBtn.TabIndex = 36
        ConectarCloudBtn.Text = "Conectar"
        ConectarCloudBtn.TextAlign = ContentAlignment.MiddleRight
        ConectarCloudBtn.UseVisualStyleBackColor = True
        ' 
        ' SenhaCloudTxb
        ' 
        SenhaCloudTxb.Location = New Point(573, 47)
        SenhaCloudTxb.Name = "SenhaCloudTxb"
        SenhaCloudTxb.Size = New Size(146, 23)
        SenhaCloudTxb.TabIndex = 35
        ' 
        ' NomeConectarCloudTxb
        ' 
        NomeConectarCloudTxb.Location = New Point(299, 47)
        NomeConectarCloudTxb.Name = "NomeConectarCloudTxb"
        NomeConectarCloudTxb.Size = New Size(268, 23)
        NomeConectarCloudTxb.TabIndex = 34
        ' 
        ' SenhaConectarLbl
        ' 
        SenhaConectarLbl.AutoSize = True
        SenhaConectarLbl.Location = New Point(573, 27)
        SenhaConectarLbl.Name = "SenhaConectarLbl"
        SenhaConectarLbl.Size = New Size(39, 15)
        SenhaConectarLbl.TabIndex = 33
        SenhaConectarLbl.Text = "Senha"
        ' 
        ' UsuarioConectarLbl
        ' 
        UsuarioConectarLbl.AutoSize = True
        UsuarioConectarLbl.Location = New Point(296, 27)
        UsuarioConectarLbl.Name = "UsuarioConectarLbl"
        UsuarioConectarLbl.Size = New Size(47, 15)
        UsuarioConectarLbl.TabIndex = 32
        UsuarioConectarLbl.Text = "Usuario"
        ' 
        ' ListadeServidorCloudDtg
        ' 
        ListadeServidorCloudDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListadeServidorCloudDtg.Location = New Point(275, 101)
        ListadeServidorCloudDtg.Name = "ListadeServidorCloudDtg"
        ListadeServidorCloudDtg.ReadOnly = True
        ListadeServidorCloudDtg.RowHeadersWidth = 51
        ListadeServidorCloudDtg.RowTemplate.Height = 25
        ListadeServidorCloudDtg.Size = New Size(516, 300)
        ListadeServidorCloudDtg.TabIndex = 39
        ' 
        ' Ferramenta_Cloud
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 749)
        Controls.Add(ListadeServidorCloudDtg)
        Controls.Add(SelecinarServidorLbl)
        Controls.Add(ExibirServidorCloudCbx)
        Controls.Add(ConectarCloudBtn)
        Controls.Add(SenhaCloudTxb)
        Controls.Add(NomeConectarCloudTxb)
        Controls.Add(SenhaConectarLbl)
        Controls.Add(UsuarioConectarLbl)
        Controls.Add(ServidorCloudTxb)
        Controls.Add(ServidorConectarLbl)
        Name = "Ferramenta_Cloud"
        Text = "Ferramenta_Cloud"
        CType(ListadeServidorCloudDtg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ServidorCloudTxb As TextBox
    Friend WithEvents ServidorConectarLbl As Label
    Friend WithEvents SelecinarServidorLbl As Label
    Friend WithEvents ExibirServidorCloudCbx As ComboBox
    Friend WithEvents ConectarCloudBtn As Button
    Friend WithEvents SenhaCloudTxb As TextBox
    Friend WithEvents NomeConectarCloudTxb As TextBox
    Friend WithEvents SenhaConectarLbl As Label
    Friend WithEvents UsuarioConectarLbl As Label
    Friend WithEvents ListadeServidorCloudDtg As DataGridView
End Class

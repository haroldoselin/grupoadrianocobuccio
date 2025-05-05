<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadTransacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadTransacao))
        Me.grpTransacao = New System.Windows.Forms.GroupBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtTransacao = New System.Windows.Forms.TextBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumCartao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumTransacao = New System.Windows.Forms.Label()
        Me.lblTransacao = New System.Windows.Forms.Label()
        Me.tobBotoes = New System.Windows.Forms.ToolStrip()
        Me.tbtnNovo = New System.Windows.Forms.ToolStripButton()
        Me.tbtnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.tbtnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnFechar = New System.Windows.Forms.ToolStripButton()
        Me.grpTransacao.SuspendLayout()
        Me.tobBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTransacao
        '
        Me.grpTransacao.Controls.Add(Me.btnPesquisar)
        Me.grpTransacao.Controls.Add(Me.txtTransacao)
        Me.grpTransacao.Controls.Add(Me.dtpData)
        Me.grpTransacao.Controls.Add(Me.Label5)
        Me.grpTransacao.Controls.Add(Me.cmbStatus)
        Me.grpTransacao.Controls.Add(Me.txtDescricao)
        Me.grpTransacao.Controls.Add(Me.Label4)
        Me.grpTransacao.Controls.Add(Me.Label3)
        Me.grpTransacao.Controls.Add(Me.txtValor)
        Me.grpTransacao.Controls.Add(Me.Label2)
        Me.grpTransacao.Controls.Add(Me.txtNumCartao)
        Me.grpTransacao.Controls.Add(Me.Label1)
        Me.grpTransacao.Controls.Add(Me.lblNumTransacao)
        Me.grpTransacao.Controls.Add(Me.lblTransacao)
        Me.grpTransacao.Location = New System.Drawing.Point(13, 53)
        Me.grpTransacao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpTransacao.Name = "grpTransacao"
        Me.grpTransacao.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpTransacao.Size = New System.Drawing.Size(732, 250)
        Me.grpTransacao.TabIndex = 87
        Me.grpTransacao.TabStop = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(264, 20)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(36, 29)
        Me.btnPesquisar.TabIndex = 104
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtTransacao
        '
        Me.txtTransacao.Location = New System.Drawing.Point(165, 20)
        Me.txtTransacao.MaxLength = 20
        Me.txtTransacao.Name = "txtTransacao"
        Me.txtTransacao.Size = New System.Drawing.Size(89, 26)
        Me.txtTransacao.TabIndex = 12
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(558, 119)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(157, 26)
        Me.dtpData.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(488, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(558, 20)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(157, 28)
        Me.cmbStatus.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(165, 167)
        Me.txtDescricao.MaxLength = 255
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(550, 62)
        Me.txtDescricao.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data Transação:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(165, 119)
        Me.txtValor.MaxLength = 20
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(135, 26)
        Me.txtValor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor Transação:"
        '
        'txtNumCartao
        '
        Me.txtNumCartao.Location = New System.Drawing.Point(165, 74)
        Me.txtNumCartao.MaxLength = 16
        Me.txtNumCartao.Name = "txtNumCartao"
        Me.txtNumCartao.Size = New System.Drawing.Size(550, 26)
        Me.txtNumCartao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número do Cartão:"
        '
        'lblNumTransacao
        '
        Me.lblNumTransacao.AutoSize = True
        Me.lblNumTransacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTransacao.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblNumTransacao.Location = New System.Drawing.Point(110, 28)
        Me.lblNumTransacao.Name = "lblNumTransacao"
        Me.lblNumTransacao.Size = New System.Drawing.Size(0, 20)
        Me.lblNumTransacao.TabIndex = 1
        '
        'lblTransacao
        '
        Me.lblTransacao.AutoSize = True
        Me.lblTransacao.Location = New System.Drawing.Point(71, 23)
        Me.lblTransacao.Name = "lblTransacao"
        Me.lblTransacao.Size = New System.Drawing.Size(88, 20)
        Me.lblTransacao.TabIndex = 0
        Me.lblTransacao.Text = "Transação:"
        '
        'tobBotoes
        '
        Me.tobBotoes.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tobBotoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnNovo, Me.tbtnSalvar, Me.tbtnExcluir, Me.ToolStripSeparator1, Me.tbtnPesquisar, Me.ToolStripSeparator3, Me.tbtnFechar})
        Me.tobBotoes.Location = New System.Drawing.Point(0, 0)
        Me.tobBotoes.Name = "tobBotoes"
        Me.tobBotoes.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tobBotoes.Size = New System.Drawing.Size(763, 38)
        Me.tobBotoes.TabIndex = 86
        Me.tobBotoes.Text = "ToolStrip1"
        '
        'tbtnNovo
        '
        Me.tbtnNovo.Image = CType(resources.GetObject("tbtnNovo.Image"), System.Drawing.Image)
        Me.tbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnNovo.Name = "tbtnNovo"
        Me.tbtnNovo.Size = New System.Drawing.Size(115, 33)
        Me.tbtnNovo.Text = "F5 -Novo"
        Me.tbtnNovo.ToolTipText = "F5 - Novo"
        '
        'tbtnSalvar
        '
        Me.tbtnSalvar.Image = CType(resources.GetObject("tbtnSalvar.Image"), System.Drawing.Image)
        Me.tbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnSalvar.Name = "tbtnSalvar"
        Me.tbtnSalvar.Size = New System.Drawing.Size(123, 33)
        Me.tbtnSalvar.Text = "F2 - Salvar"
        '
        'tbtnExcluir
        '
        Me.tbtnExcluir.Image = CType(resources.GetObject("tbtnExcluir.Image"), System.Drawing.Image)
        Me.tbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnExcluir.Name = "tbtnExcluir"
        Me.tbtnExcluir.Size = New System.Drawing.Size(125, 33)
        Me.tbtnExcluir.Text = "F8 - Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tbtnPesquisar
        '
        Me.tbtnPesquisar.Image = CType(resources.GetObject("tbtnPesquisar.Image"), System.Drawing.Image)
        Me.tbtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnPesquisar.Name = "tbtnPesquisar"
        Me.tbtnPesquisar.Size = New System.Drawing.Size(150, 33)
        Me.tbtnPesquisar.Text = "F7 - Pesquisar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'tbtnFechar
        '
        Me.tbtnFechar.Image = CType(resources.GetObject("tbtnFechar.Image"), System.Drawing.Image)
        Me.tbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnFechar.Name = "tbtnFechar"
        Me.tbtnFechar.Size = New System.Drawing.Size(127, 33)
        Me.tbtnFechar.Text = "F4 - Fechar"
        '
        'frmCadTransacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 321)
        Me.Controls.Add(Me.grpTransacao)
        Me.Controls.Add(Me.tobBotoes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCadTransacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Transações"
        Me.grpTransacao.ResumeLayout(False)
        Me.grpTransacao.PerformLayout()
        Me.tobBotoes.ResumeLayout(False)
        Me.tobBotoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTransacao As GroupBox
    Friend WithEvents tobBotoes As ToolStrip
    Friend WithEvents tbtnNovo As ToolStripButton
    Friend WithEvents tbtnSalvar As ToolStripButton
    Friend WithEvents tbtnExcluir As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tbtnFechar As ToolStripButton
    Friend WithEvents lblNumTransacao As Label
    Friend WithEvents lblTransacao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumCartao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents tbtnPesquisar As ToolStripButton
    Friend WithEvents txtTransacao As TextBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class

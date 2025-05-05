<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesqTransacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesqTransacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDataIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumCartao = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDataFim)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDataIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumCartao)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 111)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de Pesquisa:"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(695, 34)
        Me.dtpDataFim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(142, 26)
        Me.dtpDataFim.TabIndex = 105
        Me.dtpDataFim.Value = New Date(2015, 7, 28, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(667, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "à"
        '
        'dtpDataIni
        '
        Me.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataIni.Location = New System.Drawing.Point(513, 33)
        Me.dtpDataIni.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDataIni.Name = "dtpDataIni"
        Me.dtpDataIni.Size = New System.Drawing.Size(142, 26)
        Me.dtpDataIni.TabIndex = 104
        Me.dtpDataIni.Value = New Date(2015, 7, 28, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(433, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Período:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(353, 75)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(157, 28)
        Me.cmbStatus.TabIndex = 102
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(165, 75)
        Me.txtValor.MaxLength = 20
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 26)
        Me.txtValor.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Valor Transação:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Número do Cartão:"
        '
        'txtNumCartao
        '
        Me.txtNumCartao.Location = New System.Drawing.Point(165, 34)
        Me.txtNumCartao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumCartao.Name = "txtNumCartao"
        Me.txtNumCartao.Size = New System.Drawing.Size(230, 26)
        Me.txtNumCartao.TabIndex = 2
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(960, 135)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(119, 37)
        Me.btnFechar.TabIndex = 104
        Me.btnFechar.Text = "&Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(833, 135)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(119, 37)
        Me.btnPesquisar.TabIndex = 103
        Me.btnPesquisar.Text = "&Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1067, 299)
        Me.DataGridView1.TabIndex = 106
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(12, 485)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(96, 31)
        Me.btnAnterior.TabIndex = 107
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.Location = New System.Drawing.Point(114, 485)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(90, 31)
        Me.btnProximo.TabIndex = 108
        Me.btnProximo.Text = "Proximo"
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Location = New System.Drawing.Point(982, 490)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(60, 20)
        Me.lblPagina.TabIndex = 109
        Me.lblPagina.Text = "Status:"
        '
        'frmPesqTransacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 525)
        Me.Controls.Add(Me.lblPagina)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesqTransacao"
        Me.Text = "Pesquisar Transações"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumCartao As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents lblPagina As Label
    Friend WithEvents dtpDataFim As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDataIni As DateTimePicker
    Friend WithEvents Label1 As Label
End Class

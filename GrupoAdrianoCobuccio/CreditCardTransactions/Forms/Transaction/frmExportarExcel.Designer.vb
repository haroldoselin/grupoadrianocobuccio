<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportarExcel))
        Me.tobBotoes = New System.Windows.Forms.ToolStrip()
        Me.tbtnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.tbtnFechar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.fbdExcel = New System.Windows.Forms.FolderBrowserDialog()
        Me.tobBotoes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tobBotoes
        '
        Me.tobBotoes.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tobBotoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnSalvar, Me.tbtnFechar})
        Me.tobBotoes.Location = New System.Drawing.Point(0, 0)
        Me.tobBotoes.Name = "tobBotoes"
        Me.tobBotoes.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tobBotoes.Size = New System.Drawing.Size(897, 34)
        Me.tobBotoes.TabIndex = 87
        Me.tobBotoes.Text = "ToolStrip1"
        '
        'tbtnSalvar
        '
        Me.tbtnSalvar.Image = CType(resources.GetObject("tbtnSalvar.Image"), System.Drawing.Image)
        Me.tbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnSalvar.Name = "tbtnSalvar"
        Me.tbtnSalvar.Size = New System.Drawing.Size(142, 29)
        Me.tbtnSalvar.Text = "F2 - Exportar"
        '
        'tbtnFechar
        '
        Me.tbtnFechar.Image = CType(resources.GetObject("tbtnFechar.Image"), System.Drawing.Image)
        Me.tbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnFechar.Name = "tbtnFechar"
        Me.tbtnFechar.Size = New System.Drawing.Size(127, 29)
        Me.tbtnFechar.Text = "F4 - Fechar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(873, 80)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Local onde o arquivo excel será gravado após a exportação"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 37)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(861, 26)
        Me.txtPath.TabIndex = 10
        '
        'frmExportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 153)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tobBotoes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmExportarExcel"
        Me.Text = "Exportar Excel"
        Me.tobBotoes.ResumeLayout(False)
        Me.tobBotoes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tobBotoes As ToolStrip
    Friend WithEvents tbtnSalvar As ToolStripButton
    Friend WithEvents tbtnFechar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents fbdExcel As FolderBrowserDialog
End Class

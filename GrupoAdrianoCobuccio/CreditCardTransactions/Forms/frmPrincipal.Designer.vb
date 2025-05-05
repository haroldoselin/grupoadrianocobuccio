<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRelatorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.mnuRelatorio, Me.mnuSair})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransacao})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(107, 29)
        Me.mnuCadastro.Text = "&Cadastros"
        '
        'mnuTransacao
        '
        Me.mnuTransacao.Name = "mnuTransacao"
        Me.mnuTransacao.Size = New System.Drawing.Size(270, 34)
        Me.mnuTransacao.Text = "&Transações"
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(57, 29)
        Me.mnuSair.Text = "&Sair"
        '
        'mnuRelatorio
        '
        Me.mnuRelatorio.Name = "mnuRelatorio"
        Me.mnuRelatorio.Size = New System.Drawing.Size(98, 29)
        Me.mnuRelatorio.Text = "&Relatório"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Transações de Cartão de Crédito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuTransacao As ToolStripMenuItem
    Friend WithEvents mnuSair As ToolStripMenuItem
    Friend WithEvents mnuRelatorio As ToolStripMenuItem
End Class

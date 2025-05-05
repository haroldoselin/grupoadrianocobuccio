Public Class frmPrincipal

#Region "Eventos"

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        If MessageBox.Show("Deseja sair do sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub mnuTransacao_Click(sender As Object, e As EventArgs) Handles mnuTransacao.Click
        Dim form = New frmCadTransacao

        Try
            With form
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            form = Nothing
        End Try
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuRelatorio_Click(sender As Object, e As EventArgs) Handles mnuRelatorio.Click
        Dim form = New frmExportarExcel

        Try
            With form
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            form = Nothing
        End Try
    End Sub

#End Region

End Class
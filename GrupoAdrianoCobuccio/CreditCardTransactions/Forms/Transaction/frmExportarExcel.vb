Imports CreditCardTransactions.Helpers
Imports CreditCartTransactions.Services
Imports ClosedXML.Excel

Public Class frmExportarExcel

#Region "Eventos"

    Private Sub tbtnFechar_Click(sender As Object, e As EventArgs) Handles tbtnFechar.Click
        Close()
    End Sub

    Private Sub tbtnSalvar_Click(sender As Object, e As EventArgs) Handles tbtnSalvar.Click
        Dim dt As DataTable
        Dim saveDialog As New SaveFileDialog()

        Try
            Cursor = Cursors.WaitCursor

            dt = New TransacaoService().ResumoTransacoesUltimoMes()
            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Nenhum resultado encontrado!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                saveDialog.Filter = "Arquivo Excel|*.xlsx"
                saveDialog.FileName = "ResumoTransacoes_" & DateTime.Now.ToString("yyyyMMdd HHmmss") & ".xlsx"

                Using workbook As New XLWorkbook()
                    workbook.Worksheets.Add(dt, "Resumo")
                    workbook.SaveAs(saveDialog.FileName)

                    txtPath.Text = Application.StartupPath & " - " & saveDialog.FileName
                End Using

                MessageBox.Show("Dados exportado com sucesso!", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Logger.Registrar("Erro ao exportar dados para excel: " & ex.Message)
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

End Class
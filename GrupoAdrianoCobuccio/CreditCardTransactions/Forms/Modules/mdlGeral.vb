Module mdlGeral

    Public Sub HabilitaBotoes(ByVal Enabled As Boolean, ByVal ParamArray tBotao() As ToolStripButton)
        Dim i As Integer

        Try
            For i = 0 To tBotao.Length - 1
                If Enabled Then
                    Select Case tBotao(i).Name
                        'Case "tbtnNovo" : tBotao(i).Enabled = False
                        Case "tbtnSalvar" : tBotao(i).Enabled = True
                        Case "tbtnExcluir" : tBotao(i).Enabled = True
                    End Select
                Else
                    Select Case tBotao(i).Name
                        'Case "tbtnNovo" : tBotao(i).Enabled = True
                        Case "tbtnSalvar" : tBotao(i).Enabled = False
                        Case "tbtnExcluir" : tBotao(i).Enabled = False
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Habilita_Botoes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CarregarStatus(Combo As ComboBox)
        Dim statusList As New Dictionary(Of String, String) From {
            {"Selecione", 0},
            {"Aprovada", "Aprovada"},
            {"Pendente", "Pendente"},
            {"Cancelada", "Cancelada"}
        }

        Combo.DataSource = New BindingSource(statusList, Nothing)
        Combo.DisplayMember = "Key"
        Combo.ValueMember = "Value"
        Combo.SelectedIndex = 0       ' Seleciona o primeiro item por padrão
    End Sub

End Module

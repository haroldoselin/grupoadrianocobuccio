Imports CreditCartTransactions.Services

Public Class frmPesqTransacao

#Region "Variaveis"

    Private paginaAtual As Integer = 1
    Private tamanhoPagina As Integer = 10

#End Region

#Region "Eventos"

    Private Sub frmPesqTransacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarStatus(cmbStatus)

        With dtpDataIni
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = " "
            .ShowUpDown = False
        End With

        With dtpDataFim
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = " "
            .ShowUpDown = False
        End With

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginaAtual > 1 Then
            paginaAtual -= 1
            Pesquisar()
        End If
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        Pesquisar()
        paginaAtual += 1
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

#End Region

#Region "Metodos"
    Private Sub Pesquisar()
        Dim transacaoService As New TransacaoService()
        Dim filtros As New Dictionary(Of String, Object)

        Try
            If Not String.IsNullOrWhiteSpace(txtNumCartao.Text) Then
                filtros.Add("Numero_Cartao", txtNumCartao.Text)
            End If

            If Not String.IsNullOrWhiteSpace(dtpDataIni.Text) And Not String.IsNullOrWhiteSpace(dtpDataFim.Text) Then
                filtros.Add("DataInicial", dtpDataIni.Value.ToString("yyyy-MM-dd 00:00:00"))
                filtros.Add("DataFinal", dtpDataFim.Value.ToString("yyyy-MM-dd 23:59:59"))
            End If

            If Not String.IsNullOrWhiteSpace(txtValor.Text) Then
                filtros.Add("Valor_Transacao", txtValor.Text)
            End If

            If cmbStatus.Text <> "Selecione" Then
                Dim status As KeyValuePair(Of String, String) = CType(cmbStatus.SelectedItem, KeyValuePair(Of String, String))
                filtros.Add("Status_Transacao", status.Value)
            End If


            Dim dt As DataTable = transacaoService.Listar(filtros, paginaAtual, tamanhoPagina)
            DataGridView1.DataSource = dt
            If dt.Rows.Count > 0 Then
                lblPagina.Text = $"Página: {paginaAtual}"
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpDataIni_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataIni.ValueChanged
        dtpDataIni.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtpDataFim_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataFim.ValueChanged
        dtpDataFim.CustomFormat = "dd/MM/yyyy"
    End Sub

#End Region

End Class
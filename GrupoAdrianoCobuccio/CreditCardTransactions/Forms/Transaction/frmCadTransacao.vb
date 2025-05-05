Imports CreditCardTransactions.Helpers
Imports CreditCardTransactions.Models
Imports CreditCartTransactions.Services

Public Class frmCadTransacao
    Inherits Form

#Region "Variaveis"

    Dim codigoTransacao As Integer = 0
    Private transacaoService As New TransacaoService()
    Private helper = New Helper()

    Dim Sep As Char

#End Region

#Region "Construtor"

    Public Sub New()
        InitializeComponent()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmTransacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor

            Sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

            With dtpData
                .Format = DateTimePickerFormat.Custom
                .CustomFormat = " "
                .ShowUpDown = False
            End With

            Top = 0
            Left = 0

            HabilitaBotoes(False, tbtnNovo, tbtnSalvar, tbtnExcluir)
            HabilitaCampos(False)
            CarregarStatus(cmbStatus)


        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmCadProduto_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                If Not Me.tbtnNovo.Enabled Then Exit Sub
                Me.tbtnNovo_Click(sender, e)
            Case Keys.F2
                If Not Me.tbtnSalvar.Enabled Then Exit Sub
                Me.tbtnSalvar_Click(sender, e)
            Case Keys.F8
                If Not tbtnExcluir.Enabled Then Exit Sub
                Me.tbtnExcluir_Click(sender, e)
            Case Keys.F3
                Me.tbtnFechar_Click(sender, e)
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub tbtnNovo_Click(sender As Object, e As EventArgs) Handles tbtnNovo.Click
        Try
            Cursor = Cursors.WaitCursor

            HabilitaBotoes(True, tbtnNovo, tbtnSalvar)
            HabilitaCampos(True)
            LimpaCampos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub tbtnSalvar_Click(sender As Object, e As EventArgs) Handles tbtnSalvar.Click

        Cursor = Cursors.WaitCursor

        Try
            If (ValidaCampos()) Then
                Dim trasacaoModel = New TransacaoModel()

                With trasacaoModel
                    .Id_Transacao = codigoTransacao
                    .Numero_Cartao = txtNumCartao.Text.Trim()
                    .Valor_Transacao = txtValor.Text
                    .Data_Transacao = Convert.ToDateTime(dtpData.Value)
                    .Descricao = txtDescricao.Text.Trim()
                    .Status_Transacao = CType(cmbStatus.SelectedItem, KeyValuePair(Of String, String)).Value
                End With

                If codigoTransacao = 0 Then
                    If (transacaoService.Inserir(trasacaoModel)) Then
                        MessageBox.Show("Transação cadastrada com sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        HabilitaBotoes(False, tbtnNovo, tbtnSalvar, tbtnExcluir)
                        HabilitaCampos(False)
                        LimpaCampos()
                    Else
                        MessageBox.Show("Ocorreu um erro. Verifique o log da aplicação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If (transacaoService.Atualizar(trasacaoModel)) Then
                        MessageBox.Show("Transação cadastrada com sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        HabilitaBotoes(False, tbtnNovo, tbtnSalvar, tbtnExcluir)
                        HabilitaCampos(False)
                        LimpaCampos()
                    Else
                        MessageBox.Show("Ocorreu um erro. Verifique o log da aplicação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End If
        Catch ex As Exception
            Logger.Registrar("Erro ao inserir transação: " & ex.Message)
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub tbtnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles tbtnExcluir.Click

        Try
            Cursor = Cursors.WaitCursor

            If codigoTransacao = 0 Then
                MessageBox.Show("Necessário informar o id da transação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (MessageBox.Show("Deseja realmente excluir a transação " & lblNumTransacao.Text & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                If (transacaoService.Excluir(codigoTransacao)) Then
                    HabilitaBotoes(False, tbtnNovo, tbtnSalvar, tbtnExcluir)
                    HabilitaCampos(False)
                    LimpaCampos()
                    MessageBox.Show("Transação excluída com sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ocorreu um erro. Verifique o log da aplicação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            Logger.Registrar("Erro ao inserir transação: " & ex.Message)
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim transacaoService As New TransacaoService()

        Try
            If String.IsNullOrWhiteSpace(txtTransacao.Text) Then
                MessageBox.Show("Necessário selecionar uma transação para exclusão!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtTransacao.Focus()
                Exit Sub
            End If

            Dim dt As DataTable = transacaoService.Pesquisar(Convert.ToInt16(txtTransacao.Text))
            If (dt.Rows.Count > 0) Then
                codigoTransacao = Convert.ToInt16(txtTransacao.Text)
                txtNumCartao.Text = dt.Rows(0)("Numero_cartao").ToString()
                cmbStatus.Text = dt.Rows(0)("Status_Transacao").ToString()
                txtValor.Text = dt.Rows(0)("Valor_Transacao").ToString()
                dtpData.Value = dt.Rows(0)("Data_Transacao").ToString()
                txtDescricao.Text = dt.Rows(0)("Descricao").ToString()

                If (cmbStatus.Text = "Aprovada") Then
                    HabilitaCampos(False)
                    HabilitaBotoes(False, tbtnNovo)
                    HabilitaBotoes(False, tbtnExcluir, tbtnSalvar)
                Else
                    HabilitaBotoes(True, tbtnExcluir)
                End If
            Else
                MessageBox.Show("Nenhum registro encontrado!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtTransacao.Focus()
            End If

        Catch ex As Exception
            Logger.Registrar("Erro consultar transação: " & ex.Message)
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tbtnPesquisar_Click(sender As Object, e As EventArgs) Handles tbtnPesquisar.Click
        Dim form = New frmPesqTransacao

        Try
            form.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            form = Nothing
        End Try
    End Sub

    Private Sub tbtnFechar_Click(sender As System.Object, e As System.EventArgs) Handles tbtnFechar.Click
        Close()
    End Sub

    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        dtpData.CustomFormat = "dd/MM/yyyy"
    End Sub

#End Region

#Region "Metodos"

    Private Sub LimpaCampos()
        lblNumTransacao.Text = String.Empty
        txtNumCartao.Text = String.Empty
        txtValor.Text = String.Empty
        txtDescricao.Text = String.Empty
        cmbStatus.SelectedIndex = 0
        txtTransacao.Text = String.Empty
        codigoTransacao = 0
    End Sub

    Private Sub HabilitaCampos(Enabled As Boolean)
        grpTransacao.Enabled = Enabled
    End Sub

    Private Function ValidaCampos() As Boolean

        If cmbStatus.SelectedIndex = 0 Then
            MessageBox.Show("Informe o status da transação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbStatus.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtNumCartao.Text) Then
            MessageBox.Show("Informe o numero do cartão de crédito!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNumCartao.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtValor.Text) Then
            MessageBox.Show("Informe o valor da transação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtValor.Focus()
            Return False
        End If

        If dtpData.Checked = False Then
            MessageBox.Show("Informe a data de transação!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpData.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub txtTransacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransacao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CInt(helper.SomenteNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

#End Region

End Class
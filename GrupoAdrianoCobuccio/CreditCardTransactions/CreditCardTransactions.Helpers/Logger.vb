Imports System.IO

Public Class Logger
    Private Shared logPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log_credit_card_transactions.txt")
    Public Shared Sub Registrar(mensagem As String)
        Try
            Dim textoLog As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensagem}"
            File.AppendAllText(logPath, textoLog & Environment.NewLine)
        Catch
            ' deixar vazio para não travar o log
        End Try
    End Sub
End Class

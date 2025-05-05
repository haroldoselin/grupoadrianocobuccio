Imports System.Configuration

Public Class Conexao

#Region "StringConexao"

    Public Function ObterStringConexao() As String
        Return ConfigurationManager.ConnectionStrings(1).ConnectionString
    End Function

#End Region

End Class


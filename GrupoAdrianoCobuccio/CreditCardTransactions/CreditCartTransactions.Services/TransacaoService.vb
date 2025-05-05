Imports CreditCardTransactions.Models
Imports CreditCartTransactions.Repositories

Public Class TransacaoService

#Region "Metodos"

    Public Function Listar(filtros As Dictionary(Of String, Object), pagina As Integer, tamanhoPagina As Integer) As DataTable
        Return New TransacaoRepository().Listar(filtros, pagina, tamanhoPagina)
    End Function

    Public Function Pesquisar(id As Integer) As DataTable
        Return New TransacaoRepository().Pesquisar(id)
    End Function

    Public Function Inserir(transacao As TransacaoModel) As Boolean
        Dim repository As New TransacaoRepository()
        Return repository.Inserir(transacao)
    End Function

    Public Function Atualizar(transacao As TransacaoModel) As Boolean
        Dim repository As New TransacaoRepository()
        Return repository.Atualizar(transacao)
    End Function

    Public Function Excluir(id As Integer) As Boolean
        Dim repository As New TransacaoRepository()
        Return repository.Excluir(id)
    End Function

    Public Function ResumoTransacoesUltimoMes() As DataTable
        Return New TransacaoRepository().ResumoTransacoesUltimoMes()
    End Function


#End Region

End Class

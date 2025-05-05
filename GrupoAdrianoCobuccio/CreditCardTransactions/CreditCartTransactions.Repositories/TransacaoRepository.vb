Imports System.Data.SqlClient
Imports CreditCardTransactions.Data
Imports CreditCardTransactions.Helpers
Imports CreditCardTransactions.Models

Public Class TransacaoRepository

#Region "Variaveis"
    Private ReadOnly logger As New Logger
#End Region

#Region "Metodos"

    Public Function Listar(filtros As Dictionary(Of String, Object), pagina As Integer, tamanhoPagina As Integer) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                Dim sql As String = "SELECT * FROM Tab_Transacao WITH(NOLOCK) WHERE 1=1"
                Dim cmd As New SqlCommand()

                If filtros.ContainsKey("Numero_Cartao") Then
                    sql &= " AND Numero_Cartao = @Numero_Cartao"
                    cmd.Parameters.AddWithValue("@Numero_Cartao", filtros("Numero_Cartao"))
                End If

                If filtros.ContainsKey("Status_Transacao") Then
                    sql &= " AND Status_Transacao = @Status_Transacao"
                    cmd.Parameters.AddWithValue("@Status_Transacao", filtros("Status_Transacao"))
                End If

                If filtros.ContainsKey("Valor_Transacao") Then
                    sql &= " AND Valor_Transacao = @Valor_Transacao"
                    cmd.Parameters.AddWithValue("@Valor_Transacao", filtros("Valor_Transacao"))
                End If

                If filtros.ContainsKey("DataInicial") AndAlso filtros.ContainsKey("DataFinal") Then
                    sql &= " AND Data_Transacao BETWEEN @DataInicial AND @DataFinal"
                    cmd.Parameters.AddWithValue("@DataInicial", filtros("DataInicial"))
                    cmd.Parameters.AddWithValue("@DataFinal", filtros("DataFinal"))
                End If

                sql &= " ORDER BY Data_Transacao DESC OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY"
                cmd.Parameters.AddWithValue("@Offset", (pagina - 1) * tamanhoPagina)
                cmd.Parameters.AddWithValue("@PageSize", tamanhoPagina)

                cmd.CommandText = sql
                cmd.Connection = conn

                conn.Open()
                Dim reader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        Catch ex As Exception
            Logger.Registrar("Erro ao listar transações: " & ex.Message)
        End Try

        Return dt

    End Function

    Public Function Pesquisar(id As Integer) As DataTable
        Dim dt As New DataTable()

        Try
            Dim sql As String = "SELECT * FROM Tab_Transacao WITH(NOLOCK) WHERE Id_Transacao = " & id & ""

            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                Dim cmd As New SqlCommand With {
                    .CommandText = Sql,
                    .Connection = conn
                }

                conn.Open()
                Dim reader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        Catch ex As Exception
            Logger.Registrar("Erro ao consultar transação: " & ex.Message)
        End Try

        Return dt

    End Function

    Public Function Inserir(transacao As TransacaoModel) As Boolean
        Dim retorno As Boolean = False

        Try
            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                Dim sql As String = "INSERT INTO Tab_Transacao (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao) " &
                                    "VALUES (@Numero_Cartao, @Valor_Transacao, @Data_Transacao, @Descricao, @Status_Transacao)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Numero_Cartao", transacao.Numero_Cartao)
                    cmd.Parameters.AddWithValue("@Valor_Transacao", transacao.Valor_Transacao)
                    cmd.Parameters.AddWithValue("@Data_Transacao", transacao.Data_Transacao)
                    cmd.Parameters.AddWithValue("@Descricao", transacao.Descricao)
                    cmd.Parameters.AddWithValue("@Status_Transacao", transacao.Status_Transacao)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using

                retorno = True

            End Using
        Catch ex As Exception
            Logger.Registrar("Erro ao inserir transação: " & ex.Message)
        End Try

        Return retorno

    End Function

    Public Function Atualizar(transacao As TransacaoModel) As Boolean
        Dim retorno As Boolean = False

        Try
            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                Dim sql As String = "UPDATE Tab_Transacao SET Numero_Cartao = @Numero_Cartao, Valor_Transacao = @Valor_Transacao, Data_Transacao = @Data_Transacao, Descricao = @Descricao, Status_Transacao = @Status_Transacao WHERE Id_Transacao = @Id_Transacao"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Numero_Cartao", transacao.Numero_Cartao)
                    cmd.Parameters.AddWithValue("@Valor_Transacao", transacao.Valor_Transacao)
                    cmd.Parameters.AddWithValue("@Data_Transacao", transacao.Data_Transacao)
                    cmd.Parameters.AddWithValue("@Descricao", transacao.Descricao)
                    cmd.Parameters.AddWithValue("@Status_Transacao", transacao.Status_Transacao)
                    cmd.Parameters.AddWithValue("@Id_Transacao", transacao.Id_Transacao)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using

                retorno = True

            End Using
        Catch ex As Exception
            Logger.Registrar("Erro ao inserir transação: " & ex.Message)
        End Try

        Return retorno

    End Function

    Public Function Excluir(id As Integer) As Boolean
        Dim retorno As Boolean

        Try
            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                Dim sql As String = "DELETE FROM Tab_Transacao WHERE Id_Transacao = @Id"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            retorno = True

        Catch ex As Exception
            Logger.Registrar("Erro ao excluir transação ID " & id & ": " & ex.Message)
            Throw
        End Try

        Return retorno

    End Function

    Public Function ResumoTransacoesUltimoMes() As DataTable
        Dim dt As New DataTable()
        Dim dataInicial As Date = DateTime.Now.AddMonths(-1)
        Dim dataFinal As Date = DateTime.Now

        Try
            Using conn As New SqlConnection(New Conexao().ObterStringConexao())
                conn.Open()
                Using cmd As New SqlCommand("proc_ResumoTransacoesPorPeriodo", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Data_Inicial", dataInicial)
                    cmd.Parameters.AddWithValue("@Data_Final", dataFinal)

                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Logger.Registrar("Erro ao gerar dados para a exportação do arquiv excel: " & ex.Message)
        End Try

        Return dt

    End Function

#End Region

End Class

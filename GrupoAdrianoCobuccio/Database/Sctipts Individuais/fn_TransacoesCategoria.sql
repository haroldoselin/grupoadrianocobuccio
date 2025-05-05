USE GrupoAC
GO

CREATE OR ALTER FUNCTION fn_TransacoesCategoria
(
    @Data_Inicial DATETIME,
    @Data_Final DATETIME
)

RETURNS TABLE

AS
RETURN
(
    SELECT
        Id_Transacao,
        Numero_Cartao,
        Valor_Transacao,
        Data_Transacao,
        Descricao,
        Status_Transacao,
        dbo.fn_RetornaCategorizarValor(Valor_Transacao) AS Categoria
    FROM
        Tab_Transacao WITH(NOLOCK)
    WHERE
        Data_Transacao BETWEEN @Data_Inicial AND @Data_Final
)

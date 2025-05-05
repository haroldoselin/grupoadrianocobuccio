USE GrupoAC
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE dbo.proc_ResumoTransacoesPorPeriodo 
    @Data_Inicial DATETIME,
    @Data_Final DATETIME,
    @Status_Transacao VARCHAR(20) = NULL  
AS

-- exec proc_ResumoTransacoesPorPeriodo '2025-01-01', '2025-05-05'

BEGIN
	SELECT
        Numero_Cartao,
		SUM(Valor_Transacao) AS Valor_Total,
		COUNT(*) AS Quantidade_Transacoes,
        Status_Transacao
    FROM
        Tab_Transacao WITH(NOLOCK)
    WHERE
        Data_Transacao >= @Data_Inicial
        AND Data_Transacao <= @Data_Final
        AND (@Status_Transacao IS NULL OR Status_Transacao = @Status_Transacao)
    GROUP BY
        Numero_Cartao, Status_Transacao
    ORDER BY
        Numero_Cartao
END


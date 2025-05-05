USE GrupoAC
GO

CREATE OR ALTER VIEW vw_ConsolidaTransacoesFinanceiras
AS

-- select * from vw_ConsolidaTransacoesFinanceiras

SELECT
    Numero_Cartao,
    Status_Transacao,
    COUNT(1) AS Quantidade_Transacoes,
    SUM(Valor_Transacao) AS Valor_Total,
    MAX(Data_Transacao) AS Ultima_Transacao,
    dbo.fn_RetornaCategorizarValor(AVG(Valor_Transacao)) AS Categoria_Media
FROM
    Tab_Transacao
GROUP BY
    Numero_Cartao,
    Status_Transacao

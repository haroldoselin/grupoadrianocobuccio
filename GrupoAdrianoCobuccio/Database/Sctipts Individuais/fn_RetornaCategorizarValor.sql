USE GrupoAC
GO

CREATE OR ALTER FUNCTION fn_RetornaCategorizarValor
(
    @FaixaValor DECIMAL(18, 2)
)

RETURNS VARCHAR(20)
AS

BEGIN
    DECLARE @Categoria VARCHAR(20)

    IF @FaixaValor > 2000
        SET @Categoria = 'Premium'
    ELSE IF @FaixaValor >= 1000
        SET @Categoria = 'Alta'
    ELSE IF @FaixaValor >= 500
        SET @Categoria = 'Média'
    ELSE
        SET @Categoria = 'Baixa'

    RETURN @Categoria
END
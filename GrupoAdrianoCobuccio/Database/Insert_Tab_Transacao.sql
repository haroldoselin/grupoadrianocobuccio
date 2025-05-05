USE GrupoAC

GO

SET NOCOUNT ON;

DECLARE @i INT = 1;

WHILE @i <= 1000
BEGIN
    INSERT INTO Tab_Transacao(Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao)
    VALUES (
        RIGHT('0000000000000000' + CAST(ABS(CHECKSUM(NEWID())) % 10000000000000000 AS VARCHAR(16)), 16), -- Número de cartão aleatório
        CAST(RAND(CHECKSUM(NEWID())) * 3000 + 1 AS DECIMAL(10,2)), -- Valor entre 1,00 e 3000,00
        DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 60), GETDATE()), -- Data nos últimos 60 dias
        CONCAT('Compra ', @i), -- Descrição dinâmica
        CHOOSE((ABS(CHECKSUM(NEWID())) % 3) + 1, 'Aprovada', 'Pendente', 'Cancelada') -- Status aleatório
    );

    SET @i += 1;
END

-- só para testes
UPDATE Tab_Transacao SET Status_Transacao = 'Aprovada' WHERE Status_Transacao IS NULL

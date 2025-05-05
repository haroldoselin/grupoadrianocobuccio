USE [GrupoAC]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_RetornaCategorizarValor]    Script Date: 04/05/2025 19:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fn_RetornaCategorizarValor]
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
GO
/****** Object:  Table [dbo].[Tab_Transacao]    Script Date: 04/05/2025 19:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tab_Transacao](
	[Id_Transacao] [int] IDENTITY(1,1) NOT NULL,
	[Numero_Cartao] [char](16) NOT NULL,
	[Valor_Transacao] [decimal](18, 2) NOT NULL,
	[Data_Transacao] [datetime] NOT NULL,
	[Descricao] [varchar](255) NULL,
	[Status_Transacao] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Transacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TransacoesCategoria]    Script Date: 04/05/2025 19:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   FUNCTION [dbo].[fn_TransacoesCategoria]
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
GO
/****** Object:  View [dbo].[vw_ConsolidaTransacoesFinanceiras]    Script Date: 04/05/2025 19:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW [dbo].[vw_ConsolidaTransacoesFinanceiras]
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
GO
ALTER TABLE [dbo].[Tab_Transacao] ADD  DEFAULT (getdate()) FOR [Data_Transacao]
GO
ALTER TABLE [dbo].[Tab_Transacao]  WITH CHECK ADD CHECK  (([Status_Transacao]='Cancelada' OR [Status_Transacao]='Pendente' OR [Status_Transacao]='Aprovada'))
GO
ALTER TABLE [dbo].[Tab_Transacao]  WITH CHECK ADD CHECK  (([Valor_Transacao]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[proc_ResumoTransacoesPorPeriodo]    Script Date: 04/05/2025 19:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[proc_ResumoTransacoesPorPeriodo] 
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

GO

USE [GrupoAC]
GO

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

ALTER TABLE [dbo].[Tab_Transacao] ADD  DEFAULT (getdate()) FOR [Data_Transacao]
GO

ALTER TABLE [dbo].[Tab_Transacao]  WITH CHECK ADD CHECK  (([Status_Transacao]='Cancelada' OR [Status_Transacao]='Pendente' OR [Status_Transacao]='Aprovada'))
GO

ALTER TABLE [dbo].[Tab_Transacao]  WITH CHECK ADD CHECK  (([Valor_Transacao]>(0)))
GO



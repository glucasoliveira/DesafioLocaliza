USE [EnterpriseDatabase]
GO

/****** Object:  Table [dbo].[Contratos]    Script Date: 28/09/2021 00:57:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contratos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CpfCliente] [bigint] NOT NULL,
	[IdVeiculo] [int] NOT NULL,
	[DataInicio] [smalldatetime] NOT NULL,
	[DataFim] [smalldatetime] NOT NULL,
	[Valor] [real] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


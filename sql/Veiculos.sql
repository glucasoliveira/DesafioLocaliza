USE [EnterpriseDatabase]
GO

/****** Object:  Table [dbo].[Veiculos]    Script Date: 28/09/2021 00:57:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Veiculos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [nvarchar](10) NOT NULL,
	[Tipo] [nvarchar](10) NOT NULL,
	[Marca] [nvarchar](30) NOT NULL,
	[Modelo] [nvarchar](30) NOT NULL,
	[Ano] [nchar](4) NOT NULL,
	[ValorDiaria] [real] NOT NULL,
	[Kilometragem] [bigint] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Veiculos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



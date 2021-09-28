USE [EnterpriseDatabase]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 28/09/2021 00:57:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Cpf] [bigint] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Cnh] [bigint] NOT NULL,
	[CategoriaCnh] [nvarchar](5) NOT NULL,
	[Endereco] [nvarchar](50) NOT NULL,
	[Bairro] [nvarchar](30) NOT NULL,
	[Cidade] [nvarchar](50) NOT NULL,
	[Estado] [nvarchar](30) NOT NULL,
	[Telefone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[DataNascimento] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
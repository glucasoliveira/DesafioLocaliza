
<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">Sobre o projeto</a>
      <ul>
        <li><a href="#built-with">Construído com</a></li>
      </ul>
    </li>
    <li>
      <ul>
        <li><a href="#prerequisites">Pré requisitos</a></li>
      </ul>
    </li>
    <li><a href="#contact">Contato</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre o Projeto

[![product-screenshot]]

O desafio se consiste em implementar um projeto para suportar uma alta demanda de abertura e manutenção de contratos de aluguel em uma empresa, além de definir a arquitetura para a migração do produto legado composto de uma aplicação integrada com uma base de dados já existente.

### Funcionalidades

O projeto conta com 3 controllers: Contrato, Cliente e Veículo

#### Contrato

* Busca de contratos no Banco de Dados
* Busca de contratos no Banco de Dados baseado no ID
* Busca de contratos no Banco de Dados baseado no CPF
* Criação de contrato
* Atualização de contrato

#### Cliente

* Busca de clientes no Banco de Dados
* Busca de clientes no Banco de Dados baseado no CPF
* Busca de clientes no Banco de Dados baseado na cidade
* Criação de cliente

#### Veículo

* Busca de veículos no Banco de Dados
* Busca de veículos no Banco de Dados baseado no ID
* Busca de veículos no Banco de Dados baseado na placa
* Criação de veículo

### Built With

* [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472)
* [Swagger](https://swagger.io)


### Pré Requisitos

É necessário a criação um banco de dados chamado EnterpriseDatabase.
* EnterpriseDatabase
  ```sh
  USE [master]
GO

/****** Object:  Database [EnterpriseDatabase]    Script Date: 28/09/2021 00:54:45 ******/
CREATE DATABASE [EnterpriseDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnterpriseDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnterpriseDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnterpriseDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnterpriseDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnterpriseDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EnterpriseDatabase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET ARITHABORT OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EnterpriseDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EnterpriseDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EnterpriseDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EnterpriseDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EnterpriseDatabase] SET  MULTI_USER 
GO

ALTER DATABASE [EnterpriseDatabase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EnterpriseDatabase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EnterpriseDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EnterpriseDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EnterpriseDatabase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EnterpriseDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [EnterpriseDatabase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EnterpriseDatabase] SET  READ_WRITE 
GO
  ```

Também é necessário a criação das seguintes tabelas

* Cliente
  ```sh
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
  ```	

* Contratos
  ```sh
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

  ```	

* Veiculos
  ```sh
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
  ```	

<!-- CONTACT -->
## Contact

Gabriel Lucas - gabriellucasoliveiradealmeida@gmail.com

<!-- MARKDOWN LINKS & IMAGES -->
[product-screenshot]: images/screenshot.png

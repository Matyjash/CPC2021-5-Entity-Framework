USE [master]
GO
/****** Object:  Database [BlackMarketDB]    Script Date: 29.05.2021 20:46:51 ******/
CREATE DATABASE [BlackMarketDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BlackMarketDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BlackMarketDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BlackMarketDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BlackMarketDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BlackMarketDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlackMarketDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlackMarketDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BlackMarketDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BlackMarketDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BlackMarketDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BlackMarketDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BlackMarketDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BlackMarketDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BlackMarketDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BlackMarketDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BlackMarketDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BlackMarketDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BlackMarketDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BlackMarketDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BlackMarketDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BlackMarketDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BlackMarketDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BlackMarketDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BlackMarketDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BlackMarketDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BlackMarketDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BlackMarketDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BlackMarketDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BlackMarketDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BlackMarketDB] SET  MULTI_USER 
GO
ALTER DATABASE [BlackMarketDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BlackMarketDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BlackMarketDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BlackMarketDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BlackMarketDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BlackMarketDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BlackMarketDB] SET QUERY_STORE = OFF
GO
USE [BlackMarketDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29.05.2021 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dealers]    Script Date: 29.05.2021 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dealers](
	[DealerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[RateId] [int] NULL,
 CONSTRAINT [PK_Dealers] PRIMARY KEY CLUSTERED 
(
	[DealerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GraphicCards]    Script Date: 29.05.2021 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GraphicCards](
	[GcId] [int] IDENTITY(1,1) NOT NULL,
	[ProducerId] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_graphic_cards] PRIMARY KEY CLUSTERED 
(
	[GcId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producers]    Script Date: 29.05.2021 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[ProducerId] [int] IDENTITY(1,1) NOT NULL,
	[ProducerName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_producers] PRIMARY KEY CLUSTERED 
(
	[ProducerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rates]    Script Date: 29.05.2021 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rates](
	[RateId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED 
(
	[RateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dealers] ON 

INSERT [dbo].[Dealers] ([DealerId], [Name], [Email], [RateId]) VALUES (1, N'CHEAPEST_2000', N'buy_card@31s.com', 6)
INSERT [dbo].[Dealers] ([DealerId], [Name], [Email], [RateId]) VALUES (2, N'Anonymous', N'brian.cooper2006@gmail.com', 2)
SET IDENTITY_INSERT [dbo].[Dealers] OFF
GO
SET IDENTITY_INSERT [dbo].[GraphicCards] ON 

INSERT [dbo].[GraphicCards] ([GcId], [ProducerId], [Name], [Price]) VALUES (1, 1, N'GeForce RTX 3060', 800)
INSERT [dbo].[GraphicCards] ([GcId], [ProducerId], [Name], [Price]) VALUES (2, 2, N'GeForce RTX 3060', 850)
INSERT [dbo].[GraphicCards] ([GcId], [ProducerId], [Name], [Price]) VALUES (3, 3, N'Quadro RTX 4000 8GB', 1000)
SET IDENTITY_INSERT [dbo].[GraphicCards] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([ProducerId], [ProducerName]) VALUES (1, N'MSI')
INSERT [dbo].[Producers] ([ProducerId], [ProducerName]) VALUES (2, N'Gigabyte')
INSERT [dbo].[Producers] ([ProducerId], [ProducerName]) VALUES (3, N'HP')
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
SET IDENTITY_INSERT [dbo].[Rates] ON 

INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (1, N'Very Bad')
INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (2, N'Bad')
INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (3, N'Neutral')
INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (4, N'Good')
INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (5, N'Very Good')
INSERT [dbo].[Rates] ([RateId], [Description]) VALUES (6, N'The Best')
SET IDENTITY_INSERT [dbo].[Rates] OFF
GO
ALTER TABLE [dbo].[Dealers]  WITH CHECK ADD  CONSTRAINT [FK_Dealers_Rates] FOREIGN KEY([RateId])
REFERENCES [dbo].[Rates] ([RateId])
GO
ALTER TABLE [dbo].[Dealers] CHECK CONSTRAINT [FK_Dealers_Rates]
GO
ALTER TABLE [dbo].[GraphicCards]  WITH CHECK ADD  CONSTRAINT [FK_GraphicCards_Producers] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producers] ([ProducerId])
GO
ALTER TABLE [dbo].[GraphicCards] CHECK CONSTRAINT [FK_GraphicCards_Producers]
GO
USE [master]
GO
ALTER DATABASE [BlackMarketDB] SET  READ_WRITE 
GO

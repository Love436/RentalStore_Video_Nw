USE [master]
GO
/****** Object:  Database [Db_RentalStore_Video_Nw]    Script Date: 11-07-2021 3.59.38 PM ******/
CREATE DATABASE [Db_RentalStore_Video_Nw]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentalStore_Video_Nw_Database_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalStore_Video_Nw_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RentalStore_Video_Nw_Database_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalStore_Video_Nw_Database.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Db_RentalStore_Video_Nw].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ARITHABORT OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET  MULTI_USER 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Db_RentalStore_Video_Nw', N'ON'
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET QUERY_STORE = OFF
GO
USE [Db_RentalStore_Video_Nw]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11-07-2021 3.59.39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Interest] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 11-07-2021 3.59.39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[VideoId] [int] NULL,
	[IssueDate] [nvarchar](50) NULL,
	[ReturnDate] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videos]    Script Date: 11-07-2021 3.59.39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videos](
	[VideoId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Rating] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Cost] [nvarchar](50) NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [nvarchar](50) NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Videos] PRIMARY KEY CLUSTERED 
(
	[VideoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [Name], [Mobile], [Address], [Interest], [PostalCode]) VALUES (2, N'Preet', N'64865455', N'Papatoe', N'Old Movies', N'145856')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Rentals] ON 

INSERT [dbo].[Rentals] ([RentalId], [CustomerId], [VideoId], [IssueDate], [ReturnDate], [Status]) VALUES (1, 2, 2, N'11-07-2021', N'Returned', N'Returned')
SET IDENTITY_INSERT [dbo].[Rentals] OFF
GO
SET IDENTITY_INSERT [dbo].[Videos] ON 

INSERT [dbo].[Videos] ([VideoId], [Title], [Rating], [Year], [Cost], [Copies], [Plot], [Genre]) VALUES (3, N'Jack', N'4', N'2020', N'5', N'4', N'rockstar', N'gene Movies')
SET IDENTITY_INSERT [dbo].[Videos] OFF
GO
USE [master]
GO
ALTER DATABASE [Db_RentalStore_Video_Nw] SET  READ_WRITE 
GO

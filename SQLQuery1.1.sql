USE [master]
GO
/****** Object:  Database [Device_Management_db]    Script Date: 26/7/2022 10:46:19 PM ******/
CREATE DATABASE [Device_Management_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Device Management', FILENAME = N'C:\Users\Kemani Harris\Documents\Visual Studio 2022\Device Management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Device Management_log', FILENAME = N'C:\Users\Kemani Harris\Documents\Visual Studio 2022\Device Management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Device_Management_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Device_Management_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Device_Management_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Device_Management_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Device_Management_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Device_Management_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [Device_Management_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Device_Management_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Device_Management_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Device_Management_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Device_Management_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Device_Management_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Device_Management_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Device_Management_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Device_Management_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Device_Management_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Device_Management_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Device_Management_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Device_Management_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Device_Management_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Device_Management_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Device_Management_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Device_Management_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Device_Management_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Device_Management_db] SET  MULTI_USER 
GO
ALTER DATABASE [Device_Management_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Device_Management_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Device_Management_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Device_Management_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Device_Management_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Device_Management_db] SET QUERY_STORE = OFF
GO
USE [Device_Management_db]
GO
/****** Object:  Table [dbo].[Devices]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Brand] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Barcode] [nvarchar](50) NULL,
	[Status] [bit] NULL,
	[IsAvailable] [bit] NULL,
	[BorrowerId] [int] NULL,
	[ExpectedReturnDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Devices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Devices_Projectors]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Devices_Projectors] AS
SELECT Description, Type, Brand, Model, Barcode, Status FROM Devices WHERE Type ='Projector'
GO
/****** Object:  View [dbo].[Devices_Speakers]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Devices_Speakers] AS
SELECT Description, Type, Brand, Model, Barcode, Status FROM Devices WHERE Type ='Speaker'
GO
/****** Object:  View [dbo].[Devices_Laptops]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Devices_Laptops] AS
SELECT Description, Type, Brand, Model, Barcode, Status FROM Devices WHERE Type ='Laptop'
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](13) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[Password] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [cons_add_unique_to_email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Users_Teachers]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Users_Teachers] AS
SELECT Name, Address, Telephone, Email, Department, Description
FROM Users
GO
/****** Object:  View [dbo].[Users_Technician]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Users_Technician] AS
SELECT Name, Address, Telephone, Email, Department, Description
FROM Users;
GO
/****** Object:  View [dbo].[Users_Admin]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Users_Admin] AS
SELECT Name, Address, Telephone, Email, Department, Description
FROM Users;
GO
/****** Object:  Table [dbo].[Device_Manager]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device_Manager](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NOT NULL,
	[Device_Id] [int] NOT NULL,
	[Technician_Id] [int] NULL,
	[Admin_Id] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Brand] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Barcode] [nvarchar](50) NULL,
	[Status] [bit] NULL,
	[TransactionType] [nvarchar](50) NULL,
	[TransactionDate] [datetime2](7) NULL,
	[IsApproved] [bit] NULL,
	[DecisionDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Device_Manager] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceTypes]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeviceTYpes] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionHistory]    Script Date: 26/7/2022 10:46:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionHistory](
	[HistoryId] [int] IDENTITY(1,1) NOT NULL,
	[DeviceManagerId] [int] NOT NULL,
	[BorrowerId] [int] NOT NULL,
	[BorrowerName] [nvarchar](50) NOT NULL,
	[BorrowerDepartment] [nvarchar](50) NOT NULL,
	[BorrowerDescription] [nvarchar](50) NOT NULL,
	[DeviceId] [int] NOT NULL,
	[DeviceName] [nvarchar](50) NOT NULL,
	[DeviceBrand] [nvarchar](50) NOT NULL,
	[DeviceModel] [nvarchar](50) NOT NULL,
	[DeviceBarcode] [nvarchar](50) NOT NULL,
	[ApproverId] [int] NOT NULL,
	[ApproverName] [nvarchar](50) NULL,
	[ApproverRole] [nvarchar](50) NULL,
	[TransactionType] [nvarchar](50) NOT NULL,
	[TransactionDate] [datetime2](7) NOT NULL,
	[Operation] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Device_Manager] ADD  CONSTRAINT [DF_Device_Manager_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Devices] ADD  CONSTRAINT [DF_Devices_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[TransactionHistory]  WITH CHECK ADD CHECK  (([Operation]='INS' OR [Operation]='DEL'))
GO
ALTER TABLE [dbo].[TransactionHistory]  WITH CHECK ADD CHECK  (([Operation]='INS' OR [Operation]='DEL'))
GO
USE [master]
GO
ALTER DATABASE [Device_Management_db] SET  READ_WRITE 
GO

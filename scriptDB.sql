USE [master]
GO
/****** Object:  Database [TaskEmployeexceed]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE DATABASE [TaskEmployeexceed]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TaskEmployeexceed', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TaskEmployeexceed.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TaskEmployeexceed_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TaskEmployeexceed_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TaskEmployeexceed] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TaskEmployeexceed].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TaskEmployeexceed] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET ARITHABORT OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TaskEmployeexceed] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TaskEmployeexceed] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TaskEmployeexceed] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TaskEmployeexceed] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TaskEmployeexceed] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [TaskEmployeexceed] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TaskEmployeexceed] SET  MULTI_USER 
GO
ALTER DATABASE [TaskEmployeexceed] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TaskEmployeexceed] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TaskEmployeexceed] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TaskEmployeexceed] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TaskEmployeexceed] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TaskEmployeexceed] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TaskEmployeexceed] SET QUERY_STORE = OFF
GO
USE [TaskEmployeexceed]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/3/2022 12:06:20 PM ******/
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
/****** Object:  Table [dbo].[Accounts]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeLanguagelevel]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeLanguagelevel](
	[EmployeeLanguageId] [int] NOT NULL,
	[EmployeeLanguageLevelId] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeLanguagelevel] PRIMARY KEY CLUSTERED 
(
	[EmployeeLanguageId] ASC,
	[EmployeeLanguageLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[NationalId] [bigint] NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[AccountId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
	[LineofBusinessId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageLevels]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageLevels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_LanguageLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LineofBusinesses]    Script Date: 7/3/2022 12:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineofBusinesses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_LineofBusinesses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220702212642_v1', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [Name]) VALUES (1, N'x-ceed')
INSERT [dbo].[Accounts] ([Id], [Name]) VALUES (2, N'we')
INSERT [dbo].[Accounts] ([Id], [Name]) VALUES (3, N'tedate')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (1, 1)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (2, 1)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (3, 1)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (4, 1)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (5, 1)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (1, 2)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (2, 2)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (4, 2)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (5, 2)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (1, 3)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (2, 3)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (3, 3)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (1, 4)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (4, 4)
INSERT [dbo].[EmployeeLanguagelevel] ([EmployeeLanguageId], [EmployeeLanguageLevelId]) VALUES (4, 6)
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Name], [NationalId], [DateOfBirth], [IsActive], [AccountId], [LanguageId], [LineofBusinessId]) VALUES (1, N'‪Aya Sre‬‏', 29708040105389, CAST(N'1999-01-01T00:00:00.0000000' AS DateTime2), 1, 2, 2, 3)
INSERT [dbo].[Employees] ([Id], [Name], [NationalId], [DateOfBirth], [IsActive], [AccountId], [LanguageId], [LineofBusinessId]) VALUES (2, N'‪Aya Saied‬‏', 29708040105389, CAST(N'1999-01-01T00:00:00.0000000' AS DateTime2), 1, 3, 2, 5)
INSERT [dbo].[Employees] ([Id], [Name], [NationalId], [DateOfBirth], [IsActive], [AccountId], [LanguageId], [LineofBusinessId]) VALUES (3, N'reaad', 29708040105389, CAST(N'1999-02-02T00:00:00.0000000' AS DateTime2), 0, 3, 2, 5)
INSERT [dbo].[Employees] ([Id], [Name], [NationalId], [DateOfBirth], [IsActive], [AccountId], [LanguageId], [LineofBusinessId]) VALUES (4, N'reyaad‬‏', 29708040105389, CAST(N'2006-02-05T00:00:00.0000000' AS DateTime2), 1, 2, 1, 4)
INSERT [dbo].[Employees] ([Id], [Name], [NationalId], [DateOfBirth], [IsActive], [AccountId], [LanguageId], [LineofBusinessId]) VALUES (5, N'‪Aya Saied‬‏', 29708040105389, CAST(N'2006-02-05T00:00:00.0000000' AS DateTime2), 1, 2, 1, 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[LanguageLevels] ON 

INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (1, N'b1', 1)
INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (2, N'b2', 1)
INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (3, N'c1', 2)
INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (4, N'c2', 2)
INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (5, N'a1', 3)
INSERT [dbo].[LanguageLevels] ([Id], [Name], [LanguageId]) VALUES (6, N'a1', 3)
SET IDENTITY_INSERT [dbo].[LanguageLevels] OFF
GO
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([Id], [Name]) VALUES (1, N'french')
INSERT [dbo].[Languages] ([Id], [Name]) VALUES (2, N'duetch')
INSERT [dbo].[Languages] ([Id], [Name]) VALUES (3, N'english')
SET IDENTITY_INSERT [dbo].[Languages] OFF
GO
SET IDENTITY_INSERT [dbo].[LineofBusinesses] ON 

INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (1, N'buss1', 1)
INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (2, N'buss1', 1)
INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (3, N'buss2', 2)
INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (4, N'busss2', 2)
INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (5, N'buss3', 3)
INSERT [dbo].[LineofBusinesses] ([Id], [Name], [AccountId]) VALUES (6, N'buss3', 3)
SET IDENTITY_INSERT [dbo].[LineofBusinesses] OFF
GO
/****** Object:  Index [IX_EmployeeLanguagelevel_EmployeeLanguageLevelId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_EmployeeLanguagelevel_EmployeeLanguageLevelId] ON [dbo].[EmployeeLanguagelevel]
(
	[EmployeeLanguageLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_AccountId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_AccountId] ON [dbo].[Employees]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_LanguageId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_LanguageId] ON [dbo].[Employees]
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_LineofBusinessId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_LineofBusinessId] ON [dbo].[Employees]
(
	[LineofBusinessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LanguageLevels_LanguageId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_LanguageLevels_LanguageId] ON [dbo].[LanguageLevels]
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LineofBusinesses_AccountId]    Script Date: 7/3/2022 12:06:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_LineofBusinesses_AccountId] ON [dbo].[LineofBusinesses]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeLanguagelevel]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeLanguagelevel_Employees_EmployeeLanguageId] FOREIGN KEY([EmployeeLanguageId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[EmployeeLanguagelevel] CHECK CONSTRAINT [FK_EmployeeLanguagelevel_Employees_EmployeeLanguageId]
GO
ALTER TABLE [dbo].[EmployeeLanguagelevel]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeLanguagelevel_LanguageLevels_EmployeeLanguageLevelId] FOREIGN KEY([EmployeeLanguageLevelId])
REFERENCES [dbo].[LanguageLevels] ([Id])
GO
ALTER TABLE [dbo].[EmployeeLanguagelevel] CHECK CONSTRAINT [FK_EmployeeLanguagelevel_LanguageLevels_EmployeeLanguageLevelId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Accounts_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Accounts_AccountId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Languages_LanguageId] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Languages_LanguageId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_LineofBusinesses_LineofBusinessId] FOREIGN KEY([LineofBusinessId])
REFERENCES [dbo].[LineofBusinesses] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_LineofBusinesses_LineofBusinessId]
GO
ALTER TABLE [dbo].[LanguageLevels]  WITH CHECK ADD  CONSTRAINT [FK_LanguageLevels_Languages_LanguageId] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[LanguageLevels] CHECK CONSTRAINT [FK_LanguageLevels_Languages_LanguageId]
GO
ALTER TABLE [dbo].[LineofBusinesses]  WITH CHECK ADD  CONSTRAINT [FK_LineofBusinesses_Accounts_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[LineofBusinesses] CHECK CONSTRAINT [FK_LineofBusinesses_Accounts_AccountId]
GO
USE [master]
GO
ALTER DATABASE [TaskEmployeexceed] SET  READ_WRITE 
GO

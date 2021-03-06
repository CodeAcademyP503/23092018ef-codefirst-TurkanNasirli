USE [Creditfirst]
GO
/****** Object:  Schema [bankApp]    Script Date: 9/28/2018 11:59:46 AM ******/
CREATE SCHEMA [bankApp]
GO
/****** Object:  Table [bankApp].[Credits]    Script Date: 9/28/2018 11:59:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bankApp].[Credits](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Disburs] [smalldatetime] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Person_ID] [int] NOT NULL,
 CONSTRAINT [PK_bankApp.Credits] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bankApp].[People]    Script Date: 9/28/2018 11:59:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bankApp].[People](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[CardNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_bankApp.People] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9/28/2018 11:59:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [bankApp].[Credits]  WITH CHECK ADD  CONSTRAINT [FK_bankApp.Credits_bankApp.People_Person_ID] FOREIGN KEY([Person_ID])
REFERENCES [bankApp].[People] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [bankApp].[Credits] CHECK CONSTRAINT [FK_bankApp.Credits_bankApp.People_Person_ID]
GO

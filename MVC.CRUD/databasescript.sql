create database TestDb
go
USE [TestDb] 
GO
/****** Object:  Table [dbo].[TblTest]    Script Date: 6/26/2017 2:03:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTest](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NULL,
	[Address] [varchar](500) NULL,
 CONSTRAINT [PK_TblTest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

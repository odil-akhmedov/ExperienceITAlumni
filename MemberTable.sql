USE [AlumniDB]
GO

/****** Object:  Table [dbo].[Member]    Script Date: 8/5/2014 3:49:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Member](
	[Member_Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleInitial] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FaceBook] [nvarchar](75) NULL,
	[Google] [nvarchar](50) NULL,
	[Twitter] [nvarchar](50) NULL,
	[LinkedIn] [nvarchar](100) NULL,
	[GitHub] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[EmployerName] [nvarchar](50) NULL,
	[UserPhoto] [image] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Member_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


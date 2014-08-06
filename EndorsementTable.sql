USE [AlumniDB]
GO

/****** Object:  Table [dbo].[Endorsement]    Script Date: 8/6/2014 9:49:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Endorsement](
	[EndorsementID] [int] NOT NULL,
	[EndorsementOutline] [text] NULL,
 CONSTRAINT [PK_Endorsement] PRIMARY KEY CLUSTERED 
(
	[EndorsementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


USE [StopCovid]
GO

/****** Object:  Table [dbo].[Personne]    Script Date: 01/01/2021 20:12:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personne](
	[id] [int] IDENTITY(12485,1) NOT NULL,
	[Nom] [nchar](20) NULL,
	[Prenom] [nchar](20) NULL,
	[Age] [int] NULL,
	[CIN] [nchar](20) NULL,
	[Malad] [nchar](20) NULL,
	[Contacteur] [nchar](20) NULL,
	[Vaccine] [nchar](20) NULL,
	[QR] [nchar](10) NULL,
 CONSTRAINT [PK_Personne] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



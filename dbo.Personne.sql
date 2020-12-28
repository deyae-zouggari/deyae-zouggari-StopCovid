CREATE TABLE [dbo].[Personne] (
    [id]         INT        NOT NULL IDENTITY(12485, 1),
    [Nom]        NCHAR (20) NULL,
    [Prenom]     NCHAR (20) NULL,
    [Age]        INT        NULL,
    [CIN]        NCHAR (20) NULL,
    [Malad]      NCHAR (20) NOT NULL,
    [Contacteur] NCHAR (20) NOT NULL,
    [Vaccine]    NCHAR (20) NOT NULL,
    CONSTRAINT [PK_Personne] PRIMARY KEY CLUSTERED ([id] ASC)
);


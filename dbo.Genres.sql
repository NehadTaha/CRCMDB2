
CREATE TABLE [dbo].[Genres] (
    [GenreID] INT           IDENTITY (1, 1) NOT NULL,
    [Genres]  NVARCHAR (50) NOT NULL,
	CONSTRAINT [PK_GenreID] PRIMARY KEY CLUSTERED ([GenreID] ASC)
);
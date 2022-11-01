CREATE TABLE [dbo].[Actors] (
    [ActorID]   INT       NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [BirthYear] INT    IDENTITY (1, 1) NOT NULL, 
    [DeathYear] VARCHAR (50) NOT NULL,
   
    [Played_in] VARCHAR (50) NOT NULL
	CONSTRAINT [PK_ActorID] PRIMARY KEY CLUSTERED ([ActorID] ASC)
	
);

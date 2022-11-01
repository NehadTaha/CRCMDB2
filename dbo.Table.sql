CREATE TABLE [dbo].[Movies]
(
	
    [MovieId] INT          NOT NULL IDENTITY,
    [Title]   VARCHAR (50) NOT NULL,
    [Year]    INT          NOT NULL,
	[Genre]     VARCHAR (50)          NOT NULL,
    CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED ([MovieId] ASC)

)

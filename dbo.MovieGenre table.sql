CREATE TABLE [dbo].[MovieGenre] (
    [MovieGenre] INT IDENTITY (1, 1) NOT NULL,
    [GenreId]    INT NOT NULL,
    [MovieId]    INT NOT NULL
	CONSTRAINT [PK_MovieGenre] PRIMARY KEY CLUSTERED ([MovieGenre] ASC)
	FOREIGN KEY (MovieId) REFERENCES Movies(MovieId),
     FOREIGN KEY (GenreId) REFERENCES Genres(GenreId)
);
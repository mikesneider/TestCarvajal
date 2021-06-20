CREATE TABLE [dbo].[Table]
(
	[Id_user] INT IDENTITY NOT NULL PRIMARY KEY, 
    [username] NVARCHAR(50) NULL, 
    [password] NVARCHAR(MAX) NULL
)

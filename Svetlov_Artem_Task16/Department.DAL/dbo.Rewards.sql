CREATE TABLE [dbo].[Table]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Birthday] DATE NOT NULL, 
    [Age] INT NOT NULL, 
    [Rewards] NVARCHAR(200) NULL
)

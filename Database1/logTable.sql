CREATE TABLE [dbo].[logTable]
(
	[RNumber] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [StartDate] DATETIME2 NOT NULL, 
    [EndDate] DATETIME2 NOT NULL, 
    [Amount] INT NOT NULL, 
    [TotalAmount] INT NOT NULL, 
    [NumOfWeeks] INT NOT NULL
)

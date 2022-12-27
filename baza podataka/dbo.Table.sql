CREATE TABLE [dbo].[Obaveze]
(
	[Obligation] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Time] TIME NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NULL
)

CREATE TABLE [dbo].[Environments]
(
	[EnvCode] VARCHAR(5) NOT NULL PRIMARY KEY, 
    [EnvName] VARCHAR(25) NOT NULL, 
    [EnvDetails] VARCHAR(256) NULL, 
    [CreateDateTime] DATETIME NOT NULL DEFAULT GETDATE() 
)

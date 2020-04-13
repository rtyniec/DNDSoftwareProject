CREATE TABLE [dbo].[Character]
(
	[Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [CharacterName] NVARCHAR(50) NOT NULL, 
    [Class] NVARCHAR(50) NOT NULL, 
    [Background] NVARCHAR(50) NOT NULL, 
    [Race] NVARCHAR(50) NOT NULL, 
    [Alignment] NVARCHAR(50) NOT NULL, 
    [ExperiencePoints] NVARCHAR(50) NOT NULL, 
    [Strength] INT NOT NULL, 
    [Dexterity] INT NOT NULL, 
    [Constitution] INT NOT NULL, 
    [Intelligence] INT NOT NULL, 
    [Wisdom] INT NOT NULL, 
    [Charisma] INT NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL
)

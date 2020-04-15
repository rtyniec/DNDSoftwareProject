CREATE PROCEDURE [dbo].[spCharacterLookup]
	@Id nvarchar(128)
AS
begin
		set nocount on;--does not return row count
	SELECT Id, CharacterName, Class, Background, Race, Alignment, ExperiencePoints,
	Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, CreatedDate --all of the current DB params;
	from [dbo].[Character]
	where @Id = Id;
end

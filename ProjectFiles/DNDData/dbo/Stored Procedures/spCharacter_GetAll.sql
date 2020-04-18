CREATE PROCEDURE [dbo].[spCharacter_GetAll]
	@UserId nvarchar(128) --i think we take in a parameter here... YES we do!
AS
begin
		set nocount on;--does not return row count
	SELECT Id, CharacterName, UserId, Class, Background, Race, Alignment, ExperiencePoints,
	Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, CreatedDate --all of the current DB params;
	from [dbo].[Character]
	where UserId = @UserId; --lets see if this works
end

CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
	
AS
begin
		set nocount on;
	SELECT Id, FirstName, LastName, EmailAddress, CreatedDate --these are the database parameters we made in User.sql
	from [dbo].[User]
	where Id = @Id;
end

CREATE PROCEDURE [dbo].[spRoomTypesGetById]
	@id int
AS
begin
	set nocount on;

	select [Id], [Title], [Description], [Price]
	from dbo.RoomTypes
	where Id=@id;



end

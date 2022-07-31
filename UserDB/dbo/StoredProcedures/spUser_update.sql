CREATE PROCEDURE [dbo].[spUser_update]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@id int 
AS
 begin 

 update dbo.[User]
 set FirstName = @FirstName ,
 LastName = @LastName
 where Id = @Id ;

 end

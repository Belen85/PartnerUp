CREATE PROCEDURE [dbo].[SP_User_Insert]
	@name NVARCHAR(50),
	@lastName NVARCHAR(50),
	@email NVARCHAR(256),
	@password NVARCHAR(256),
	@image NVARCHAR(256)
AS
	DECLARE  @salt CHAR(8)
	DECLARE @admin BIT
	SET @admin = FALSE;
	SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO [User] ([Name], [LastName], [Email], [Password], [Image], [Salt], [Admin])
	OUTPUT inserted.idUser
	VALUES (@name, @lastname, @email, dbo.SF_EncryptedPassword(@password, @salt), @image, @salt, @admin)

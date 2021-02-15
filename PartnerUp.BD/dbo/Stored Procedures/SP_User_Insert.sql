CREATE PROCEDURE [dbo].[SP_User_Insert]
	@Name NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(256),
	@Password NVARCHAR(256),
	@Image NVARCHAR(256)
AS
	DECLARE @IdUser INTEGER, @Salt CHAR(8)
	SET @Salt = [dbo].SF_GenerateSalt()
	SET @IdUser = @@IDENTITY
	INSERT INTO [User] ([IdUser],[Name], [LastName], [Email], [Password], [Image], [Salt])
	OUTPUT inserted.IdUser
	VALUES (@IdUser, @Name, @Lastname, @Email, dbo.SF_EncryptedPassword(@Password, @Salt), @Image, @Salt)

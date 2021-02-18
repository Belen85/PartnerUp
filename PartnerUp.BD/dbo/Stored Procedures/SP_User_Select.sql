CREATE PROCEDURE [dbo].[SP_User_Select]
	@email NVARCHAR(256),
	@password NVARCHAR(256)
AS
	DECLARE  @salt CHAR(8)
	SET @salt = (SELECT Salt FROM [User] WHERE Email=@email)
	SELECT IdUser,[Name],LastName,Email,[Image] FROM [User] WHERE  Password = dbo.SF_EncryptedPassword(@password, @salt)


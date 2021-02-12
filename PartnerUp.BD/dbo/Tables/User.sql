CREATE TABLE [dbo].[User] (
    [IdUser]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [LastName] NVARCHAR (50)  NOT NULL,
    [Email]    NVARCHAR (256) NOT NULL,
    [Password] VARBINARY (32) NOT NULL,
    [Salt]     CHAR (8)       NOT NULL,
    [Admin]    BIT            NOT NULL,
    [Image] NVARCHAR(256) NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([IdUser] ASC)
);


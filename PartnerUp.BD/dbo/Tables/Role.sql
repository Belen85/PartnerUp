CREATE TABLE [dbo].[Role] (
    [IdRole] INT           IDENTITY (1, 1) NOT NULL,
    [Role]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([IdRole] ASC)
);


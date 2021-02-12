CREATE TABLE [dbo].[Message] (
    [IdMessage]  INT            IDENTITY (1, 1) NOT NULL,
    [Text]       NVARCHAR (MAX) NOT NULL,
    [Date]       DATETIME       NOT NULL,
    [IdUserTo]   INT            NOT NULL,
    [IdUserFrom] INT            NOT NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([IdMessage] ASC),
    CONSTRAINT [FK_UserFrom_Message] FOREIGN KEY ([IdUserFrom]) REFERENCES [dbo].[User] ([IdUser]),
    CONSTRAINT [FK_UserTo_Message] FOREIGN KEY ([IdUserTo]) REFERENCES [dbo].[User] ([IdUser])
);


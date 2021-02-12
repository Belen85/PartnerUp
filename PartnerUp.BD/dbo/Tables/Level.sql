CREATE TABLE [dbo].[Level] (
    [IdLevel] INT           IDENTITY (1, 1) NOT NULL,
    [Level]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED ([IdLevel] ASC)
);


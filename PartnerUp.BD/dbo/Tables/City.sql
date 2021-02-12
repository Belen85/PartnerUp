CREATE TABLE [dbo].[City] (
    [IdCity] INT           IDENTITY (1, 1) NOT NULL,
    [City]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([IdCity] ASC)
);


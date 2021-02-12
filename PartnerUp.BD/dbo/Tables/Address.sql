CREATE TABLE [dbo].[Address] (
    [IdAddress]  INT            IDENTITY (1, 1) NOT NULL,
    [Number]     VARCHAR (8)    NOT NULL,
    [Street]     NVARCHAR (128) NOT NULL,
    [City]       NVARCHAR (32)  NOT NULL,
    [Country]    NVARCHAR (32)  NOT NULL,
    [Department] NVARCHAR (32)  NOT NULL,
    [LinkGoogle] NVARCHAR (MAX) NOT NULL,
    [PostalCode] VARCHAR (8)    NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([IdAddress] ASC)
);


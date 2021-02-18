CREATE TABLE [dbo].[School] (
    [IdSchool] INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NOT NULL,
    [Website]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_School] PRIMARY KEY CLUSTERED ([IdSchool] ASC)
);




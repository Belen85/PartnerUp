CREATE TABLE [dbo].[SchoolAddress] (
    [IdSchoolAddress] INT IDENTITY (1, 1) NOT NULL,
    [IdSchool]        INT NOT NULL,
    [IdAddress]       INT NOT NULL,
    CONSTRAINT [PK_SchoolAddress] PRIMARY KEY CLUSTERED ([IdSchoolAddress] ASC),
    CONSTRAINT [FK_Address_SchoolAddress] FOREIGN KEY ([IdAddress]) REFERENCES [dbo].[Address] ([IdAddress]),
    CONSTRAINT [FK_School_SchoolAddress] FOREIGN KEY ([IdSchool]) REFERENCES [dbo].[School] ([IdSchool])
);


CREATE TABLE [dbo].[DanceSchool] (
    [IdDanceSchool] INT IDENTITY (1, 1) NOT NULL,
    [IdDance]       INT NOT NULL,
    [IdSchool]      INT NOT NULL,
    CONSTRAINT [PK_DanceSchool] PRIMARY KEY CLUSTERED ([IdDanceSchool] ASC),
    CONSTRAINT [FK_Dance_DanceSchool] FOREIGN KEY ([IdDance]) REFERENCES [dbo].[Dance] ([IdDance]),
    CONSTRAINT [FK_School_DanceSchool] FOREIGN KEY ([IdSchool]) REFERENCES [dbo].[School] ([IdSchool])
);


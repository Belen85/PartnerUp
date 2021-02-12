CREATE TABLE [dbo].[Dance] (
    [IdDance]   INT           IDENTITY (1, 1) NOT NULL,
    [DanceName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Dance] PRIMARY KEY CLUSTERED ([IdDance] ASC)
);


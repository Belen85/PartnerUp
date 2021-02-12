CREATE TABLE [dbo].[Objective] (
    [IdObjective] INT           IDENTITY (1, 1) NOT NULL,
    [Objective]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Objective] PRIMARY KEY CLUSTERED ([IdObjective] ASC)
);


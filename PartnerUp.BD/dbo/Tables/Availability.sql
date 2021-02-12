CREATE TABLE [dbo].[Availability] (
    [IdAvailability] INT        IDENTITY (1, 1) NOT NULL,
    [Day]            NCHAR (50) NULL,
    [StartTime]      TIME (7)   NULL,
    [EndTime]        TIME (7)   NULL,
    [IdDancer]       INT        NOT NULL,
    CONSTRAINT [PK_Availability] PRIMARY KEY CLUSTERED ([IdAvailability] ASC),
    CONSTRAINT [FK_DancerProfile_Availability] FOREIGN KEY ([IdDancer]) REFERENCES [dbo].[DancerProfile] ([IdDancer])
);


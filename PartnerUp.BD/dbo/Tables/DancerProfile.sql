CREATE TABLE [dbo].[DancerProfile] (
    [IdDancer]     INT            IDENTITY (1, 1) NOT NULL,
    [Nickname]     NVARCHAR (50)  NOT NULL,
    [Comment]      NVARCHAR (MAX) NOT NULL,
    [CreationDate] DATETIME       NOT NULL,
    [IdUser]       INT            NOT NULL,
    [IdDance]      INT            NOT NULL,
    [IdLevel]      INT            NOT NULL,
    [IdObjective]  INT            NOT NULL,
    [IdRole]       INT            NOT NULL,
    [IdCity]       INT            NOT NULL,
    CONSTRAINT [PK_DancerProfile] PRIMARY KEY CLUSTERED ([IdDancer] ASC),
    CONSTRAINT [FK_City_DancerProfile] FOREIGN KEY ([IdCity]) REFERENCES [dbo].[City] ([IdCity]),
    CONSTRAINT [FK_Dance_DancerProfile] FOREIGN KEY ([IdDance]) REFERENCES [dbo].[Dance] ([IdDance]),
    CONSTRAINT [FK_Level_DancerProfile] FOREIGN KEY ([IdLevel]) REFERENCES [dbo].[Level] ([IdLevel]),
    CONSTRAINT [FK_Objective_DancerProfile] FOREIGN KEY ([IdObjective]) REFERENCES [dbo].[Objective] ([IdObjective]),
    CONSTRAINT [FK_Role_DancerProfile] FOREIGN KEY ([IdRole]) REFERENCES [dbo].[Role] ([IdRole]),
    CONSTRAINT [FK_User_DancerProfile] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([IdUser])
);


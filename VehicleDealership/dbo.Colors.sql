CREATE TABLE [dbo].[Colors] (
    [Id]       INT           NOT NULL IDENTITY,
    [Name]     NVARCHAR (50) NULL,
    [Color]    NVARCHAR (50) NULL,
    [Metallic] BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


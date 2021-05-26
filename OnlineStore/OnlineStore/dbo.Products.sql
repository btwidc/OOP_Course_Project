CREATE TABLE [dbo].[Products] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100)  NOT NULL,
    [Price]    DECIMAL (18, 2) NOT NULL,
    [Quantity] INT             NOT NULL,
    [Source]   NVARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);


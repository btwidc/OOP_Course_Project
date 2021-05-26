CREATE TABLE [dbo].[Purchases] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Product_id] INT             NOT NULL,
    [Name]       NVARCHAR (100)  NOT NULL,
    [Price]      DECIMAL (18, 2) NOT NULL,
    [Quantity]   INT             NOT NULL,
    [Source]     NVARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_dbo.Purchases] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Purchases_Products] FOREIGN KEY ([Product_id]) REFERENCES [dbo].[Products] ([Id]),
);


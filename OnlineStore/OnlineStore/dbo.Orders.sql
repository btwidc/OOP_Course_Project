CREATE TABLE [dbo].[Orders] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Id_user]    INT NOT NULL,
    [Id_product] INT NOT NULL,
    [Quantity]   INT NOT NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Users] FOREIGN KEY ([Id_user]) REFERENCES [dbo].[Users] ([id]),
	CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([Id_product]) REFERENCES [dbo].[Products] ([Id])
);


USE master;
CREATE DATABASE CourseProject;
USE CourseProject;

CREATE TABLE [dbo].[Users] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (100) NOT NULL,
    [password] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC),
    UNIQUE NONCLUSTERED ([password] ASC)
);

CREATE TABLE [dbo].[Products] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100)  NOT NULL,
    [Price]    DECIMAL (18, 2) NOT NULL,
    [Quantity] INT             NOT NULL,
    [Source]   NVARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Purchases] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Product_id] INT             NOT NULL,
    [Name]       NVARCHAR (100)  NOT NULL,
    [Price]      DECIMAL (18, 2) NOT NULL,
    [Quantity]   INT             NOT NULL,
    [Source]     NVARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_dbo.Purchases] PRIMARY KEY CLUSTERED ([Product_id] ASC),
	CONSTRAINT [FK_Purchases_Products] FOREIGN KEY ([Product_id]) REFERENCES [dbo].[Products] ([Id]),
);

CREATE TABLE [dbo].[Orders] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Id_user]    INT NOT NULL,
    [Id_product] INT NOT NULL,
    [Quantity]   INT NOT NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Users] FOREIGN KEY ([Id_user]) REFERENCES [dbo].[Users] ([id]),
    CONSTRAINT [FK_Orders_Purchases] FOREIGN KEY ([Id_product]) REFERENCES [dbo].[Purchases] ([Product_id])
);


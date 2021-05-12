CREATE TABLE [dbo].[Products]
(
	[id]       INT           IDENTITY (1, 1) NOT NULL,
	[name] NVARCHAR (20) NOT NULL,
    [price] MONEY NOT NULL,
	[quantity] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	UNIQUE NONCLUSTERED ([name] ASC),
)


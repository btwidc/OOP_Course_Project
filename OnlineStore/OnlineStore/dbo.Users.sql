CREATE TABLE [dbo].[Users] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (100) NOT NULL,
    [password] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC),
    UNIQUE NONCLUSTERED ([password] ASC)
);


﻿CREATE TABLE [dbo].[Users]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[username] NVARCHAR(20) NOT NULL UNIQUE,
	[password] NVARCHAR(20) NOT NULL UNIQUE
)

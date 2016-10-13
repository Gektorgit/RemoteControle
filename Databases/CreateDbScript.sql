USE master;
IF DB_ID('NettworkSettings') IS NOT NULL
    DROP DATABASE NettworkSettings
	CREATE DATABASE NettworkSettings
	GO

USE NettworkSettings;
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BannedProgramms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BannedProgramms];
GO
IF OBJECT_ID(N'[dbo].[Configuration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Configuration];
GO
IF OBJECT_ID(N'[dbo].[DaysOfWeek]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DaysOfWeek];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BannedProgramms'
CREATE TABLE [dbo].[BannedProgramms] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Day_id] int  NOT NULL,
    [ProgName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Configuration'
CREATE TABLE [dbo].[Configuration] (
    [id] int IDENTITY(1,1) NOT NULL,
    [IPAdress] varchar(50)  NOT NULL,
    [port] int  NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Details] varchar(50)  NULL
);
GO

-- Creating table 'DaysOfWeek'
CREATE TABLE [dbo].[DaysOfWeek] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Day] varchar(50)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Firstname] varchar(50)  NOT NULL,
    [Lastname] varchar(50)  NOT NULL,
    [Username] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Help] varchar(50)  NOT NULL,
    [E_Mail] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'BannedProgramms'
ALTER TABLE [dbo].[BannedProgramms]
ADD CONSTRAINT [PK_BannedProgramms]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Configuration'
ALTER TABLE [dbo].[Configuration]
ADD CONSTRAINT [PK_Configuration]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DaysOfWeek'
ALTER TABLE [dbo].[DaysOfWeek]
ADD CONSTRAINT [PK_DaysOfWeek]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Day_id] in table 'BannedProgramms'
ALTER TABLE [dbo].[BannedProgramms]
ADD CONSTRAINT [FK__BannedPro__Day_i__164452B1]
    FOREIGN KEY ([Day_id])
    REFERENCES [dbo].[DaysOfWeek]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__BannedPro__Day_i__164452B1'
CREATE INDEX [IX_FK__BannedPro__Day_i__164452B1]
ON [dbo].[BannedProgramms]
    ([Day_id]);
GO

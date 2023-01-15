-- Create a new database called 'flutterAvanzado'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'flutterAvanzado'
)
CREATE DATABASE flutterAvanzado
GO

CREATE TABLE [dbo].[Band] (
    [id]    UNIQUEIDENTIFIER NOT NULL,
    [name]  VARCHAR (250)    NOT NULL,
    [votes] INT              CONSTRAINT [DEFAULT_Band_votes] DEFAULT 0 NULL,
    CONSTRAINT [PK_Band] PRIMARY KEY CLUSTERED ([id] ASC)
);
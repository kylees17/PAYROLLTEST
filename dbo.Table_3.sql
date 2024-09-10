CREATE TABLE [dbo].[Employee] (
    [ID]       INT          NOT NULL,
    [fname]    VARCHAR (50) NULL,
    [mname]    VARCHAR (50) NULL,
    [lname]    VARCHAR (50) NULL,
    [address]  VARCHAR (50) NULL,
    [contact]  VARCHAR (50) NULL,
    [status]   VARCHAR (50) NULL,
    [pbirth]   VARCHAR (50) NULL,
    [sex]      VARCHAR (50) NULL,
    [birthday] DATE         NULL,
    [age]      INT          NULL,
    [emegency] INT          NULL,
    [drate]    INT          NULL,
    [position] VARCHAR (50) NULL,
    [dhired]   DATE         NULL,
    [payment]  VARCHAR (50) NULL,
    [wstatus]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([ID] ASC)
);


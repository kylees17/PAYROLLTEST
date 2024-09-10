CREATE TABLE [dbo].[Employee_new] (
    [ID]           INT          NOT NULL,
    [FirstName]    VARCHAR (50) NULL,
    [MiddleName]   VARCHAR (50) NULL,
    [LastName]     VARCHAR (50) NULL,
    [Address]      VARCHAR (50) NULL,
    [Contact]      VARCHAR (50) NULL,
    [Status]       VARCHAR (50) NULL,
    [BirthPlace]   VARCHAR (50) NULL,
    [Sex]          VARCHAR (50) NULL,
    [Birthday]     DATE         NULL,
    [Age]          VARCHAR (50) NULL,
    [Emergency]    VARCHAR (50) NULL,
    [DailyRate]    INT          NULL,
    [Position]     VARCHAR (50) NULL,
    [DateHired]    VARCHAR (50) NULL,
    [PaymentMethod] VARCHAR (50) NULL,
    [WorkStatus]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Employee_new] PRIMARY KEY CLUSTERED ([ID] ASC)
);


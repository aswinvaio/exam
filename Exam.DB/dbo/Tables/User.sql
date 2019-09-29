CREATE TABLE [dbo].[User] (
    [UserID]   INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (500) NOT NULL UNIQUE,
    [FullName] NVARCHAR (500) NOT NULL,
    [Password] NVARCHAR (500) NOT NULL,
    [Email]    NVARCHAR (500) NULL,
    [Mobile]   NVARCHAR (500) NULL,
    [Type]     BIT            CONSTRAINT [DF_User_Type] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);




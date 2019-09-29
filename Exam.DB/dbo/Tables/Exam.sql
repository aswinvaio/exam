CREATE TABLE [dbo].[Exam] (
    [ExamID]      INT      IDENTITY (1, 1) NOT NULL,
    [ExamXML]     XML      NULL,
    [CreatedDate] DATETIME NULL,
    CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED ([ExamID] ASC)
);




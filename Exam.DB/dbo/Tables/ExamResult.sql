CREATE TABLE [dbo].[ExamResult] (
    [ResultID]  INT IDENTITY (1, 1) NOT NULL,
    [UserID]    INT NOT NULL,
    [ExamID]    INT NOT NULL,
    [AnswerXML] XML NULL,
    [Score]     INT NULL,
    CONSTRAINT [PK_ExamResult] PRIMARY KEY CLUSTERED ([ResultID] ASC),
    CONSTRAINT [FK_ExamResult_ExamResult] FOREIGN KEY ([ResultID]) REFERENCES [dbo].[ExamResult] ([ResultID])
);


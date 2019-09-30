CREATE PROCEDURE [dbo].[Proc_Exam_GetAll]
AS
BEGIN
	SELECT [ExamID]
		,[ExamXML]
		,[CreatedDate]
	FROM [Exam]
END
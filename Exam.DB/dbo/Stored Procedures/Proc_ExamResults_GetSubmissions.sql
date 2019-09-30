CREATE PROCEDURE [dbo].[Proc_ExamResults_GetSubmissions] (@ExamId INT)
AS
BEGIN
	SELECT ER.[ResultID]
		,ER.[UserID]
		,ER.[Score]
		,ER.[UpdatedOn]
		,U.UserName
		,U.FullName
	FROM [ExamResult] ER
	INNER JOIN [User] U ON ER.UserID = U.UserID
	WHERE ER.ExamID = @ExamId
END
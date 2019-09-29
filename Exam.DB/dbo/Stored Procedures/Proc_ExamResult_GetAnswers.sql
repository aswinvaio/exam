CREATE PROCEDURE Proc_ExamResult_GetAnswers (
	@UserId INT
	,@ExamId INT
	,@AnswerXML NVARCHAR(MAX) OUT
	)
AS
BEGIN
	DECLARE @XML XML

	SELECT @XML = AnswerXML
	FROM ExamResult
	WHERE UserID = @UserId
		AND ExamId = @ExamId

	SET @AnswerXML = CONVERT(NVARCHAR(MAX), @XML)
END
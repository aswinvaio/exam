
CREATE PROCEDURE [dbo].[Proc_ExamResult_SaveAnswers] (
	@UserId INT
	,@ExamId INT
	,@AnswerXML XML
	,@Score INT
	,@Status INT OUT
	)
AS
BEGIN
	SET @Status = 0;--error

	IF NOT EXISTS (
			SELECT 1
			FROM ExamResult
			WHERE UserID = @UserId
				AND ExamID = @ExamId
			)
	BEGIN
		INSERT INTO [dbo].[ExamResult] (
			[UserID]
			,[ExamID]
			,[AnswerXML]
			,[Score]
			,[UpdatedOn]
			)
		VALUES (
			@UserId
			,@ExamId
			,@AnswerXML
			,@Score
			,GETDATE()
			)

		SET @Status = 1 --insert
	END
	ELSE
	BEGIN
		UPDATE [dbo].[ExamResult]
		SET [AnswerXML] = @AnswerXML
			,[Score] = @Score
			,[UpdatedOn] = GETDATE()
		WHERE UserID = @UserId
			AND ExamID = @ExamId

		SET @Status = 2 --update
	END
END
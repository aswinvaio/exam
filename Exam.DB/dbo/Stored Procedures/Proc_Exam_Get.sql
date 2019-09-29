﻿CREATE PROCEDURE Proc_Exam_Get (
	@ID INT
	,@ExamXML NVARCHAR(MAX) OUT
	)
AS
BEGIN
	DECLARE @XML XML

	SELECT @XML = ExamXML
	FROM Exam
	WHERE ExamID = @ID

	SET @ExamXML = CONVERT(NVARCHAR(MAX), @XML)
END
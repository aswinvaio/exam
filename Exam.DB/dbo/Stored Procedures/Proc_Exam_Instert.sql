﻿CREATE PROCEDURE Proc_Exam_Instert (
	@ExamXML XML
	,@ID INT OUT
	)
AS
BEGIN
	INSERT INTO [Exam] (ExamXML, CreatedDate)
	VALUES (@ExamXML, GETDATE())

	SET @ID = @@IDENTITY
END
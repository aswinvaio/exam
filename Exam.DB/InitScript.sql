-- Insert admin user
IF NOT EXISTS (
		SELECT 1
		FROM [USER]
		WHERE UserName = 'admin'
		)
BEGIN
	INSERT INTO [User] (
		UserName
		,FullName
		,[Password]
		,[Type]
		)
	VALUES (
		'admin'
		,'Administrator'
		,'!QAZ2wsx'
		,1
		)
END
-- Insert sample user
IF NOT EXISTS (
		SELECT 1
		FROM [USER]
		WHERE UserName = 'sampleuser'
		)
BEGIN
	INSERT INTO [User] (
		UserName
		,FullName
		,[Password]
		)
	VALUES (
		'sampleuser'
		,'Sample User Aswin'
		,'!QAZ2wsx'
		)
END

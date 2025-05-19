CREATE PROCEDURE [dbo].[spEnvironment_Insert]
	@EnvCode varchar(5),
	@EnvName varchar(25),
	@EnvDetails varchar(256)
AS
	INSERT into dbo.Environments (EnvCode,EnvName,EnvDetails,CreateDateTime)
	VALUES (@EnvCode,@EnvName,@EnvDetails,GETDATE())

RETURN 0

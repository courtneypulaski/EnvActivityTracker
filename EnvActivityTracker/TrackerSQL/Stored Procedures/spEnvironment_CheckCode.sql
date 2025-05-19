CREATE PROCEDURE [dbo].[spEnvironment_CheckCode]
	@EnvCode varchar(5),
	@CurrEnvCode varchar(5) output
AS
BEGIN
	SELECT @CurrEnvCode = EnvCode FROM Environments where EnvCode = @EnvCode
END

--CREATE PROC getLoginInfo(
--@Username as varchar(128),
--@Password as binary(64) OUTPUT
--)
--as
--begin
-- Select @Password = Pass from [user] where AccName =  @Username
--end
--go

--select AccName from [user]
--go
--DECLARE @Password as binary(64);
--exec getLoginInfo @Username = 'malesuada', @Password= @Password OUTPUT;
--select @Password as N'@Password'
--go

alter proc Verify_Login (@Username varchar(128), @Password varchar(128), @Verified binary OUTPUT) 
AS
Begin 
    DECLARE @returned binary(64)
    select @returned= Pass from [user] where AccName = @Username
	DECLARE @success binary
	if(@returned = HASHBYTES('SHA2_512', @Password)) Select @Verified = 1
	else Select @Verified = 0
end

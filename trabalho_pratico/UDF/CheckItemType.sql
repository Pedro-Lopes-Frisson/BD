CREATE FUNCTION dbo.GetItemType(@ItemName as VARCHAR(128))  
RETURNS VARCHAR(128)  
AS   
-- Returns the stock level for the product.  
BEGIN  
	DECLARE @ret AS VARCHAR(128);
	IF EXISTS(SELECT * FROM [magical] WHERE [Name]=@ItemName) 
		BEGIN
		SELECT @ret = 'Magical';
		RETURN @ret;
	END;
		ELSE IF EXISTS(SELECT * FROM [physical] WHERE [Name]=@ItemName) 
		BEGIN
		SELECT @ret = 'Physical';
		RETURN @ret;
	END;
		ELSE IF EXISTS(SELECT * FROM [armor] WHERE [Name]=@ItemName) 
		BEGIN
		SELECT @ret = 'Armor';
		RETURN @ret;
	END;
		ELSE IF EXISTS(SELECT * FROM [shield] WHERE [Name]=@ItemName) 
		BEGIN
		SELECT @ret = 'Shield';
		RETURN @ret;
	END;
		ELSE IF EXISTS(SELECT * FROM [melee] WHERE [Name]=@ItemName) 
		BEGIN
		SELECT @ret = 'Melee';
		RETURN @ret;
	END;
	RETURN @ret;
END;
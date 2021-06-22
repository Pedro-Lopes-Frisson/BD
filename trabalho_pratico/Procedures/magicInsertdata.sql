ALTER FUNCTION dbo.GetItemType(@ItemName as VARCHAR(128))  
RETURNS VARCHAR(128)  
AS   
-- Returns the stock level for the product.  
BEGIN  
	DECLARE @ret AS VARCHAR(128);
	IF EXISTS(SELECT * FROM [magical] WHERE [Name]=@ItemName) 
		SELECT @ret = 'Magical'
		RETURN @ret

	IF EXISTS(SELECT * FROM [physical] WHERE [Name]=@ItemName) 
		SELECT @ret = 'Physical'
		RETURN @ret

	IF EXISTS(SELECT * FROM [armor] WHERE [Name]=@ItemName) 
		SELECT @ret = 'Armor'
		RETURN @ret

	IF EXISTS(SELECT * FROM [shield] WHERE [Name]=@ItemName) 
		SELECT @ret = 'Shield'
		RETURN @ret

	IF EXISTS(SELECT * FROM [melee] WHERE [Name]=@ItemName) 
		SELECT @ret = 'Melee'
		RETURN @ret

	RETURN 'Erro'
END

go
exec magicalInsert
		  @ID               = 3,
		  @BaseItem_ID = NULL,
          @Stash_ID         = NULL,
          @TabNumber         = NULL,
          @Price             = 120.0,
          @Name              = 'Arco' ,
          @isUnique          = 0,
          @Upgraded          = 1			,
          @Rank              = 1			,
          @SpecialAttributes = NULL,
          @Damage            =200.0      ,
          @DamageType        = NULL      ,
          @CriticalChance    = 10.23		,
          @CriticalMutiplier = 10.2		,
          @Range             =29,
          @Accuraccy        = 99 ,
          @CoolDown         = 10 ,
          @RadiusOfEffectiveness = 123 ,
          --requiremtns
          @Level            = 12,
          @Dexterity        = 112,
          @Inteligence  	= 123.3,
          @Strength         = 123.4 ,
          @CharClass        = 'Dwarf'
go
SELECT * FROM magical
DELETE  FROM item WHERE Name='EspadaLongaQueMandaTiros'

DECLARE @ret as VARCHAR(128)
		SELECT @ret = 'Magical';
PRINT @ret
SELECT dbo.GetItemType('EspadaLongaQueMaaandaTiros')

CREATE PROC shieldInsert(
	--armor specifics
    @Defense			AS         decimal(6, 3)     ,
    @SpecialAbility     AS         varchar(128)      ,
	-- Item specifics
    @Price              AS         decimal(38,3)     ,
    @Name				AS         varchar(128)      ,
    @isUnique           AS         bit               ,
    @Upgraded           AS         int               ,
    @BaseItem_ID        AS          bigint            ,
    @Rank				AS         int               ,
    @TabNumber          AS         bigint            ,
    @Stash_ID           AS         bigint            
)
as
BEGIN
declare @Item_ID bigint;
select  @Item_ID = count(*) from item;
select  @Item_ID = @Item_ID+1;
	BEGIN TRY
	BEGIN TRANSACTION
	DECLARE @Level              AS         bigint   ;
	DECLARE @Dexterity          AS         DECIMAL(38,3);
	DECLARE @Inteligence        AS         DECIMAL(38,3);
	DECLARE @Strength           AS         DECIMAL(38,3);
	DECLARE @CharClass          AS         DECIMAL(38,3);
	SELECT @Level=[Level], @Dexterity=[Dexterity], @Inteligence=[Inteligence], @Strength=[Strength],@CharClass=[CharClass]
		FROM [item] WHERE [ID]=@BaseItem_ID

	INSERT INTO [item]  (ID       ,
		Stash_ID ,
		TabNumber,
		Price    ,
		[Name]   ,
		isUnique ,
		Upgraded ,
		[Rank]   ,
		BaseItem_ID ,
             [Level]    ,
             Dexterity  ,
             Inteligence,
             Strength   ,
             CharClass)

          VALUES (@Item_ID     ,
		@Stash_ID    ,
		@TabNumber   ,
		@Price       ,
		@Name        ,
		@isUnique    ,
		@Upgraded    ,
		@Rank        ,
              @BaseItem_ID ,
              @Level       ,
              @Dexterity   ,
              @Inteligence ,
              @Strength    ,
              @CharClass        );

		select  @Item_ID = count(*) from shield;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [shield](ID  ,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
				     Defense,
					 SpecialAbility
					      ) VALUES (@Item_ID       ,
							@Stash_ID              ,
							@TabNumber             ,
							@Price                 ,
							@Name                  ,
							@isUnique              ,
							@Upgraded              ,
							@Rank                  ,
							@Defense,
							@SpecialAbility)
		COMMIT;
	END TRY
		BEGIN CATCH
		    IF @@TRANCOUNT > 0
			ROLLBACK TRAN

		    DECLARE @ErrorMessage NVARCHAR(4000);  
		    DECLARE @ErrorSeverity INT;  
		    DECLARE @ErrorState INT;  

		    SELECT   
		       @ErrorMessage = ERROR_MESSAGE(),  
		       @ErrorSeverity = ERROR_SEVERITY(),  
		       @ErrorState = ERROR_STATE();  

		    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);  
		END CATCH
END

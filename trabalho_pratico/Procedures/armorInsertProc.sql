CREATE PROC armorInsert(
	--armor specifics
    @Defense			AS          decimal(6, 3)      ,
    @HealthBonus        AS          decimal(38, 5)               ,
	-- Item specifics
    @Price              AS          decimal(38,3)     ,
    @Name				AS          varchar(128)      ,
    @isUnique           AS          bit               ,
    @Upgraded           AS          int               ,
    @BaseItem_ID        AS          bigint            ,
    @Rank				AS          int               ,
    @TabNumber          AS          bigint            ,
    @Stash_ID           AS          bigint            ,
    @Level              AS         bigint   ,
    @Dexterity          AS         DECIMAL(38,3),
    @Inteligence    		AS         DECIMAL(38,3),
    @Strength           AS         DECIMAL(38,3),
    @CharClass          AS         DECIMAL(38,3)
)
as
BEGIN
declare @Item_ID bigint;
select  @Item_ID = count(*) from item;
select  @Item_ID = @Item_ID+1;
	BEGIN 
		BEGIN TRY
			BEGIN TRANSACTION
				INSERT INTO [item]  (ID       ,
						     Stash_ID ,
						     TabNumber,
						     Price    ,
						     [Name]   ,
						     isUnique ,
						     Upgraded ,
						     [Rank]   ,
			     BaseItem_ID,
			     [Level]      ,
			     Dexterity    ,
						     Inteligence  ,
						     Strength     ,
						     CharClass
						) VALUES (
			      @ID          ,
									@Stash_ID    ,
									@TabNumber   ,
									@Price       ,
									@Name        ,
									@isUnique    ,
									@Upgraded    ,
			      @BaseItem_ID ,
									@Rank        ,
			      @Level       ,
			      @Dexterity   ,
			      @Inteligence ,
			      @Strength    ,
			      @CharClass        );

				INSERT INTO [armor](ID  ,
						     Stash_ID ,
						     TabNumber,
						     Price    ,
						     [Name]   ,
						     isUnique ,
						     Upgraded ,
						     [Rank]   ,
						     Defense,
							 HealthBonus
							      ) VALUES (@item_ID                    ,
									@Stash_ID              ,
									@TabNumber             ,
									@Price                 ,
									@Name                  ,
									@isUnique              ,
									@Upgraded              ,
									@Rank                  ,
									@Defense,
									@HealthBonus)
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
go

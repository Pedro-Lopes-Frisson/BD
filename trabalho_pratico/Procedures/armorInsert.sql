USE [project_dummy]
GO
/****** Object:  StoredProcedure [dbo].[armorInsert]    Script Date: 22/06/2021 01:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[armorInsert](
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
    @Stash_ID           AS          bigint            
)
as
BEGIN
	declare @Item_ID bigint;
	SELECT  @Item_ID = count(*) from item;
	SELECT  @Item_ID = @Item_ID+1;
	DECLARE @Level              AS         bigint   ;
	DECLARE @Dexterity          AS         DECIMAL(38,3);
	DECLARE @Inteligence        AS         DECIMAL(38,3);
	DECLARE @Strength           AS         DECIMAL(38,3);
	DECLARE @CharClass          AS         DECIMAL(38,3);
	SELECT @Level=[Level], @Dexterity=[Dexterity], @Inteligence=[Inteligence], @Strength=[Strength],@CharClass=[CharClass]
		FROM [item] WHERE [ID]=@BaseItem_ID
		
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
						@Item_ID          ,
						@Stash_ID    ,
						@TabNumber   ,
						@Price       ,
						@Name        ,
						@isUnique    ,
						@Upgraded    ,
						@Rank,
						      @BaseItem_ID ,
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
							 HealthBonus,
							 BaseItem_ID
							      ) VALUES (@Item_ID                    ,
									@Stash_ID              ,
									@TabNumber             ,
									@Price                 ,
									@Name                  ,
									@isUnique              ,
									@Upgraded              ,
									@Rank                  ,
									@Defense,
									@HealthBonus,
									@BaseItem_ID)
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

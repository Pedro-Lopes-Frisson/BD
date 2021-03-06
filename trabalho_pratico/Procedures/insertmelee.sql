USE [project_dummy]
GO
/****** Object:  StoredProcedure [dbo].[meleeInsert]    Script Date: 22/06/2021 00:49:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[meleeInsert](
	--melee specifics
    @AttackSpeed        AS          DECIMAL(4,3)      ,
    @HandNum            AS          int               ,
    @MeleeType          AS          varchar(128)      ,
	-- Item specifics
    @Price              AS          decimal(38,3)     ,
    @Name             AS          varchar(128)      ,
    @isUnique           AS          bit               ,
	@BaseItem_ID		AS bigint,
    @Upgraded           AS          int               ,
    @Rank             AS          int               ,
    @TabNumber          AS          bigint            ,
    @Stash_ID           AS          bigint            ,
	-- weapon specifics
    @SpecialAttributes  AS          varchar(128)      ,    --Pode ser um composito ?
    @Damage             AS          decimal(38,2)     ,
    @DamageType         AS          varchar(128)      ,      -- Atributo multivalor ?
    @CriticalChance     AS          decimal(5,2)      ,
    @CriticalMutiplier  AS          decimal(5,2)      
    --requiremtns
                                  			)
AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION
	DECLARE @Level              AS         bigint   ;
	DECLARE @Dexterity          AS         DECIMAL(38,3);
	DECLARE @Inteligence        AS         DECIMAL(38,3);
	DECLARE @Strength           AS         DECIMAL(38,3);
	DECLARE @CharClass          AS         VARCHAR(128);
	SELECT @Level=[Level], @Dexterity=[Dexterity], @Inteligence=[Inteligence], @Strength=[Strength],@CharClass=[CharClass]
		FROM [item] WHERE [ID]=@BaseItem_ID

		DECLARE @Item_ID AS BIGINT;
		select  @Item_ID = count(*) from item;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [item]  (
					BaseItem_ID,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
				     [Level]      ,    			             
				     Dexterity    ,  
				     Inteligence  ,  
				     Strength     ,  
				     CharClass    
				) VALUES (
					        @BaseItem_ID,
							@Stash_ID    ,
							@TabNumber   ,
							@Price       ,
							@Name        ,
							@isUnique    ,
							@Upgraded    ,
							@Rank        ,
                            @Level       ,      
                            @Dexterity   ,      
                            @Inteligence ,  	
                            @Strength    ,      
                            @CharClass        ); 


		select  @Item_ID = count(*) from weapon;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [weapon](item_ID  ,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
					 BaseItem_ID,
				     SpecialAttributes     ,
				     Damage                ,
				     DamageType            ,
				     CriticalChance        ,
				     CriticalMutiplier     
					      ) VALUES (@Item_ID                    ,
							@Stash_ID              ,
							@TabNumber             ,
							@Price                 ,
							@Name                  ,
							@isUnique              ,
							@Upgraded              ,
							@Rank                  ,
							@BaseItem_ID,
							@SpecialAttributes     ,
							@Damage                ,
							@DamageType            ,
							@CriticalChance        ,
							@CriticalMutiplier     );
		select  @Item_ID = count(*) from melee;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [melee](Weapon_ID,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
				     SpecialAttributes     ,
				     Damage                ,
				     DamageType            ,
				     CriticalChance        ,
				     CriticalMutiplier     ,
				     AttackSpeed          ,
				     HandNum              ,
				     MeleeType            )
						VALUES (@Item_ID                    ,
							@Stash_ID              ,
							@TabNumber             ,
							@Price                 ,
							@Name                  ,
							@isUnique              ,
							@Upgraded              ,
							@Rank                  ,
							@SpecialAttributes     ,
							@Damage                ,
							@DamageType            ,
							@CriticalChance        ,
							@CriticalMutiplier     ,
				                        @AttackSpeed           ,
				                        @HandNum               ,
				                        @MeleeType             
						);
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


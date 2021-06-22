CREATE PROC magicalInsert(
          @ID                AS bigint				,
          @Stash_ID          AS bigint				,
          @TabNumber         AS bigint				,
          @Price             AS decimal(38,3)		,
          @Name              AS varchar(128)		,
          @isUnique          AS bit				,
          @Upgraded          AS int				,
	      @BaseItem_ID		AS BIGINT,
          @Rank              AS int				,
          @SpecialAttributes AS varchar(128) = NULL,
          @Damage            AS decimal(38,2)      ,
          @DamageType        AS varchar(128)       ,
          @CriticalChance    AS decimal(5,2)		,
          @CriticalMutiplier AS decimal(5,2)		,
          @Range             AS   int				,
          @Accuraccy         AS   decimal(5,2)		,
          @CoolDown               AS   decimal(6,2)            ,
          @RadiusOfEffectiveness  AS    int
)
AS
	BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DECLARE @Item_ID AS BIGINT;
			select  @Item_ID = count(*) from item;
			select  @Item_ID = @Item_ID + 1;

			DECLARE @Level              AS         bigint   ;
			DECLARE @Dexterity          AS         DECIMAL(38,3);
			DECLARE @Inteligence        AS         DECIMAL(38,3);
			DECLARE @Strength           AS         DECIMAL(38,3);
			DECLARE @CharClass          AS         DECIMAL(38,3);
			SELECT @Level=[Level], @Dexterity=[Dexterity], @Inteligence=[Inteligence], @Strength=[Strength],@CharClass=[CharClass]
				FROM [item] WHERE [ID] = @BaseItem_ID

			INSERT INTO [item]  (ID       ,
					     Stash_ID ,
					     TabNumber,
					     Price    ,
					     [Name]   ,
					     isUnique ,
					     Upgraded ,
					     Rank        ,
					     Level       ,      
					     Dexterity   ,      
					     Inteligence ,  	
					     Strength    ,      
					     CharClass        )

		 VALUES (@Item_ID          ,
								@Stash_ID    ,
								@TabNumber   ,
								@Price       ,
								@Name      ,
								@isUnique    ,
								@Upgraded    ,
								@Rank        ,
							    @Level       ,          
							    @Dexterity   ,      
							    @Inteligence ,	  
							    @Strength    ,      
							    @CharClass        
				);

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
								@SpecialAttributes     ,
								@Damage                ,
								@DamageType            ,
								@CriticalChance        ,
								@CriticalMutiplier     );
				select  @Item_ID = count(*) from ranged;
				select  @Item_ID = @Item_ID + 1;

			    INSERT INTO [ranged](item_ID,
					     Stash_ID   ,
					     TabNumber  ,
					     Price      ,
					     [Name]     ,
					     isUnique   ,
					     Upgraded   ,
					     [Rank]     ,
					     SpecialAttributes     ,
					     Damage                ,
					     DamageType            ,
					     CriticalChance        ,
					     CriticalMutiplier     ,
					     [Range]               ,
					     Accuraccy              )                   

							VALUES (@Item_ID          ,
								@Stash_ID    ,
								@TabNumber   ,
								@Price       ,
								@Name        ,
								@isUnique    ,
								@Upgraded    ,
								@Rank        ,
								@SpecialAttributes     ,
								@Damage                ,
								@DamageType            ,
								@CriticalChance        ,
								@CriticalMutiplier     ,
								@Range       ,
								@Accuraccy   );

				select  @Item_ID = count(*) from magical;
				select  @Item_ID = @Item_ID + 1;
			    INSERT INTO [magical](item_ID          ,
					     Stash_ID              ,
					     TabNumber             ,
					     Price                 ,
					     [Name]                ,
					     isUnique              ,
					     Upgraded              ,
					     [Rank]                ,
					     SpecialAttributes     ,
					     Damage                ,
					     DamageType            ,
					     CriticalChance        ,
					     CriticalMutiplier     ,
					     [Range]               ,
					     Accuraccy,
					     CoolDown                ,
					     RadiusOfEffectiveness  

				)                   

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
								@Range                 ,
								@Accuraccy             ,
								@CoolDown              ,
								@RadiusOfEffectiveness  
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

CREATE proc physicalInsert(
@ID                AS bigint				,
@Stash_ID          AS bigint				,
@TabNumber         AS bigint				,
@Price             AS decimal(38,3)		,
@Name              AS varchar(128)		,
@isUnique          AS bit				,
@Upgraded          AS int				,
@Rank              AS int				,
@SpecialAttributes AS varchar(128) = NULL,
@Damage            AS decimal(38,2)      ,
@DamageType        AS varchar(128)       ,
@CriticalChance    AS decimal(5,2)		,
@CriticalMutiplier AS decimal(5,2)		,
@Range             AS   int				,
@Accuraccy         AS   decimal(5,2)		,
@PiercingRate      AS   decimal(7,3)		,
@FireRate          AS   decimal(7,3)		
--requiremtns
@Level              AS         bigint   ,
@Dexterity          AS         DECIMAL(38,3),
@Inteligence		AS         DECIMAL(38,3),
@Strength           AS         DECIMAL(38,3),
@CharClass          AS         DECIMAL(38,3),
)
AS 
BEGIN
	BEGIN TRY
BEGIN TRANSACTION
	INSERT INTO [item]  (    ID                ,
                             Stash_ID          ,
                             TabNumber         ,
                             Price             ,
                             [Name]            ,
                             isUnique          ,
                             Upgraded          ,
                             [Rank]            ,
                             [Level]           ,
                             Dexterity         ,
                             Inteligence	   ,
                             Strength          ,
                             CharClass         ,
                             
			             ) VALUES (             @ID          ,
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
                                                
	INSERT INTO [weapon](item_ID       ,
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
			              ) VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @Name      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @Rank      ,
												@SpecialAttributes     ,
                                                @Damage                ,
                                                @DamageType            ,
                                                @CriticalChance        ,
                                                @CriticalMutiplier     );

	    INSERT INTO [ranged](item_ID       ,
                             Stash_ID ,
                             TabNumber,
                             Price    ,
                             [Name]   ,
                             isUnique ,
                             Upgraded ,
                             [Rank],
                             SpecialAttributes     ,
			                 Damage                ,
                             DamageType            ,
                             CriticalChance        ,
                             CriticalMutiplier     ,
                             [Range]               ,
                             Accuraccy              )                   
                                        VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @Name      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @Rank      ,
												@SpecialAttributes     ,
										        @Damage                ,
									            @DamageType            ,
									            @CriticalChance        ,
									            @CriticalMutiplier     ,
					                            @Range       ,
                                                @Accuraccy   );

	  INSERT INTO [physical](item_ID       ,
                             Stash_ID ,
                             TabNumber,
                             Price    ,
                             [Name]   ,
                             isUnique ,
                             Upgraded ,
                             [Rank],
                             SpecialAttributes     ,
							 Damage                ,
                             DamageType            ,
                             CriticalChance        ,
                             CriticalMutiplier     ,
                             [Range]               ,
                             Accuraccy              ,
                             PiercingRate          ,
                             FireRate              )                   
                                        VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @Name      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @Rank      ,
												@SpecialAttributes     ,
										        @Damage                ,
									            @DamageType            ,
									            @CriticalChance        ,
									            @CriticalMutiplier     ,
                                                @Range       ,
                                                @Accuraccy   ,
                                                @PiercingRate,
                                                @FireRate    );
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

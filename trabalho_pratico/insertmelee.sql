CREATE PROC meleeInsert(
	--melee specifics
    @Weapon_ID          AS          bigint            ,
    @AttackSpeed        AS          DECIMAL(4,3)      ,
    @HandNum            AS          int               ,
    @MeleeType          AS          varchar(128)      ,
	-- Item specifics
    @Price              AS          decimal(38,3)     ,
    @[Name]             AS          varchar(128)      ,
    @isUnique           AS          bit               ,
    @Upgraded           AS          int               ,
    @[Rank]             AS          int               ,
    @TabNumber          AS          bigint            ,
    @Stash_ID           AS          bigint            ,
	-- weapon specifics
    @SpecialAttributes  AS          varchar(128)      ,    --Pode ser um composito ?
    @Damage             AS          decimal(38,2)     ,
    @DamageType         AS          varchar(128)      ,      -- Atributo multivalor ?
    @CriticalChance     AS          decimal(5,2)      ,
    @CriticalMutiplier  AS          decimal(5,2)      )
                                  
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO [item]  (ID       ,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ) VALUES (@ID          ,
							@Stash_ID    ,
							@TabNumber   ,
							@Price       ,
							@Name      ,
							@isUnique    ,
							@Upgraded    ,
							@Rank      );

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
					      ) VALUES (@ID                    ,
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
		INSERT INTO [melee](item_ID  ,
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
				     Weapon_ID            ,
				     AttackSpeed          ,
				     HandNum              ,
				     MeleeType            )
						VALUES (@ID                    ,
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
				                        @Weapon_ID             ,
				                        @AttackSpeed           ,
				                        @HandNum               ,
				                        @MeleeType             ,
						);
	COMMIT;
END
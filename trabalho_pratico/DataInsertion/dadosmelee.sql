exec [dbo].[meleeInsert](
	--melee specifics
    @AttackSpeed      =1.2    ,
    @HandNum            =1,
    @MeleeType          = 'Yes'      ,
	-- Item specifics
    @Price         =12.4,
    @Name            = 'Espada'      ,
    @isUnique           = 0,
	@BaseItem_ID		= NULL,
    @Upgraded           = 0,
    @Rank             = 0,
    @TabNumber         =NULL,
    @Stash_ID           = NULL,
	-- weapon specifics
    @SpecialAttributes = NULL,    --Pode ser um composito ?
    @Damage             = 12.3     ,
    @DamageType         ='Slash',      -- Atributo multivalor ?
    @CriticalChance     = 12.1      ,
    @CriticalMutiplier  19.1      
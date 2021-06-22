DECLARE    @Weapon_ID          AS          bigint            ;
DECLARE    @AttackSpeed        AS          DECIMAL(4,3)      ;
DECLARE    @HandNum            AS          int               ;
DECLARE    @MeleeType          AS          varchar(128)      ;
	-- Item specifics
DECLARE    @Price              AS          decimal(38,3)     ;
DECLARE    @Name             AS          varchar(128)      ;
DECLARE    @isUnique           AS          bit               ;
DECLARE	@BaseItem_ID		AS bigint;
DECLARE    @Upgraded           AS          int               ;
DECLARE    @Rank             AS          int               ;
DECLARE    @TabNumber          AS          bigint           ;
DECLARE    @Stash_ID           AS          bigint            ;
	-- weapon specifics
DECLARE    @SpecialAttributes  AS          varchar(128)      ;    --Pode ser um composito ?
DECLARE    @Damage             AS          decimal(38,2)     ;
DECLARE    @DamageType         AS          varchar(128)      ;      -- Atributo multivalor ?
DECLARE    @CriticalChance     AS          decimal(5,2)      ;
DECLARE    @CriticalMutiplier  AS          decimal(5,2)      ;


EXEC dbo.meleeInsert
	--melee specifics
    @AttackSpeed       = 1.9,
    @HandNum           = 1,
    @MeleeType         = 'Maos'
    @Price             = 123.10,
    @Name             = 'Espada Muito Longa',
    @isUnique          = 0,
    @BaseItem_ID	= NULL,
    @Upgraded          = 0,
    @Rank             =  1,
    @TabNumber         = NULL,
    @Stash_ID           = NULL,
	-- weapon specifics
    @SpecialAttributes  = NULL,--Pode ser um composito ?
    @Damage             = 2012.0,
    @DamageType         =  'Physical',-- Atributo multivalor ?
    @CriticalChance     =  1.10    ,
    @CriticalMutiplier  =  1.1,
    --requiremtns

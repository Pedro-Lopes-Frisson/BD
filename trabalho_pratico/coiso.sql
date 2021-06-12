CREATE TABLE  physical (
  item_ID       bigint         NOT NULL,
  PiercingRate  decimal(7,3)    NOT NULL,
  FireRate      decimal(7,3)    NOT NULL,

    -- Item specifics
  Price     decimal(38,3)     NOT NULL,
  [Name]    varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  TabNumber bigint            NOT NULL,
  Stash_ID  bigint            NOT NULL,

    -- weapon specifics
  SpecialAttributes     varchar(128)  ,    --Pode ser um composito ?
  Damage                decimal(38,2)      NOT NULL,
  DamageType            varchar(128)     NOT NULL,      -- Atributo multivalor ?
  CriticalChance        decimal(5,2) NOT NULL DEFAULT 000.00,
  CriticalMutiplier     decimal(5,2) NOT NULL DEFAULT 000.00,

    -- ranged
  [Range]      int               NOT NULL DEFAULT 100,
  Accuraccy  DECIMAL(5,2)      NOT NULL DEFAULT 65.000,

  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [ranged]( item_ID ),
  CHECK (PiercingRate > 0),
  CHECK (FireRate > 0),
)

CREATE TRIGGER physicalTrigger   ON dbo.physical 
INSTEAD OF INSERT
AS 
BEGIN
	DECLARE @ID        AS bigint           ;
        DECLARE @Stash_ID  AS bigint           ;
        DECLARE @TabNumber AS bigint           ;
        DECLARE @Price     AS decimal(38,3)    ;
        DECLARE @[Name]    AS varchar(128)     ;
        DECLARE @isUnique  AS bit              ;
        DECLARE @Upgraded  AS int              ;
	    DECLARE @[Rank]    AS int              ;
	    DECLARE @SpecialAttributes   varchar(128)   ;
        DECLARE @Damage              decimal(38,2)  ;
        DECLARE @DamageType          varchar(128)   ;
        DECLARE @CriticalChance      decimal(5,2)   ;
        DECLARE @CriticalMutiplier   decimal(5,2)   ;
        DECLARE @Range               int            ;
        DECLARE @Accuraccy           decimal(5,2)   ;
        DECLARE @PiercingRate        decimal(7,3)   ;
        DECLARE @FireRate            decimal(7,3)   ;


	SELECT @ID       = ID        ,
               @Stash_ID = Stash_ID  ,
               @TabNumber= TabNumber ,
               @Price    = Price     ,
               @[Name]   = [Name]    ,
               @isUnique = isUnique  ,
               @Upgraded = Upgraded  ,
               @[Rank]   = [Rank]    ,
               @SpecialAttributes = SpecialAttributes,
               @Damage = Damage,
               @DamageType = DamageType,
               @CriticalChance = CriticalChance,
               @CriticalMutiplier = CriticalMutiplier,
               @Range = [Range]
               @Accuraccy = Accuraccy,
               @PiercingRate = PiercingRate,
               @FireRate = FireRate
               from inserted;


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
                                               @[Name]      ,
                                               @isUnique    ,
                                               @Upgraded    ,
                                               @[Rank]      );
	INSERT INTO [weapon](ID       ,
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
                             CriticalMutiplier     )                   
                                        VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @[Name]      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @[Rank]      );


    INSERT INTO [ranged](ID       ,
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
                             Accuracy              )                   
                                        VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @[Name]      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @[Rank]      ,
                                                @Range       ,
                                                @Accuraccy   );
    INSERT INTO [physical](ID       ,
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
                             Accuracy              ,
                             PiercingRate          ,
                             FireRate              )                   
                                        VALUES (@ID          ,
                                                @Stash_ID    ,
                                                @TabNumber   ,
                                                @Price       ,
                                                @[Name]      ,
                                                @isUnique    ,
                                                @Upgraded    ,
                                                @[Rank]      ,
                                                @Range       ,
                                                @Accuraccy   ,
                                                @PiercingRate,
                                                @FireRate    );
                                                

END


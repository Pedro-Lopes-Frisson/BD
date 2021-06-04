USE project_dummy;
GO

--DROP TABLE consumable;
--DROP TABLE cosmetic;
--DROP TABLE specialItem;
--DROP TABLE vendorStash;
--DROP TABLE buyerStash;
--DROP TABLE normalTab;
--DROP TABLE specialTab;
--DROP TABLE melee;
--DROP TABLE shield;
--DROP TABLE armor;
--DROP TABLE physical;
--DROP TABLE magical;
--DROP TABLE ranged;
--DROP TABLE weapon;
--DROP TABLE stashTabs;
--DROP TABLE [stash];
--DROP TABLE item;
--DROP TABLE [user];



CREATE TABLE specialItem (

            ID  int,   --NOT NULL,
            [Name]  varchar(128)  NOT NULL,
            Price  smallmoney  NOT NULL,
            CurrencyType  bit CONSTRAINT default_currencyType DEFAULT 1, -- By default special items are paid with real money
            -- 1 for real money
            [Rank] int , -- Pode ser null?
            PRIMARY KEY (ID)
          )

CREATE TABLE consumable (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID), -- NOT NULL,
            [Effect]          varchar(128) NOT NULL,
            Duration        decimal(38,3)       NOT NULL,
            Quantity        int          ,
            PRIMARY KEY (SpecialItem_ID),
            FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)

)

CREATE TABLE cosmetic (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID), -- NOT NULL,
            [Type]            varchar(128)   NOT NULL,
            BodyPart        varchar(128)   NOT NULL,
            Gender          varchar(128)   ,
            PRIMARY KEY (SpecialItem_ID),
            FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)
)

CREATE TABLE [user] (
            UserID          INT IDENTITY(1,1) NOT NULL,
            Email           NVARCHAR(320)  NOT NULL,
            AccName         varchar(128)    NOT NULL,
            Pass            BINARY(64)      NOT NULL,
            RealCurrency    decimal(38,3)          NOT NULL DEFAULT 0,
            GameCurrency    decimal(38,3)          NOT NULL DEFAULT 0,
            PRIMARY KEY (UserID)
        )

CREATE TABLE [stash] (
  ID             bigint                 NOT NULL,
  [User_ID]        int                    NOT NULL,
  NumberOfTabs   int                    NOT NULL DEFAULT 0,
  CHECK (NumberOfTabs < 65 and NumberOfTabs > 0),
  PRIMARY KEY (ID),
  FOREIGN KEY ([User_ID]) references [user](UserID)
)


CREATE TABLE vendorStash(
  ID             bigint                 NOT NULL,
  TypeCode       int          NOT NULL,
  PRIMARY KEY (ID, TypeCode),
  --CHECK(TypeCode LIKE 'vendor[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  FOREIGN KEY (ID) references [stash](ID)
)

CREATE TABLE buyerStash(
  ID             bigint                 NOT NULL,
  TypeCode       int          NOT NULL,
  PRIMARY KEY (ID, TypeCode),
  --CHECK(TypeCode LIKE 'buyer[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  FOREIGN KEY (ID) references [stash](ID)
)

CREATE TABLE stashTabs (
  [Stash_ID]        bigint                    NOT NULL,
  [Number]         bigint                 NOT NULL,
  PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID]) references [stash] ([ID])
)

CREATE TABLE normalTab (
  [Stash_ID]     bigint          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 60,
  PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID], [Number] ) references [stashTabs]([Stash_ID], [Number])
)

CREATE TABLE specialTab (
  [Stash_ID]     bigint          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 60,
  PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID], [Number] ) references [stashTabs]([Stash_ID], [Number])
)

CREATE TABLE item (

  ID        bigint            NOT NULL,
  Price     decimal(38,3)     NOT NULL,
  [Name]      varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  TabNumber bigint               NOT NULL,
  Stash_ID  bigint                NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (Stash_ID , TabNumber ) references [normalTab]([Stash_ID], [Number])

)

CREATE TABLE weapon(
  item_ID               bigint            NOT NULL,
  SpecialAttributes     varchar(128)  ,    --Pode ser um composito ?
  Damage                decimal(38,2)      NOT NULL,
  DamageType            varchar(128)     NOT NULL,      -- Atributo multivalor ?
  CriticalChance        decimal(5,2) NOT NULL DEFAULT 000.00,
  CriticalMutiplier     decimal(5,2) NOT NULL DEFAULT 000.00,

  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [item]( ID ),
  CHECK (CriticalChance <= 100.00 and CriticalChance >= 000.00
        and CriticalMutiplier <= 100.00 and CriticalMutiplier >= 000.00)

)

CREATE TABLE ranged (
  item_ID    bigint            NOT NULL,
  [Range]      int               NOT NULL DEFAULT 100,
  Accuraccy  DECIMAL(5,2)      NOT NULL DEFAULT 65.000,

  CHECK (Accuraccy <= 100.00 and Accuraccy >= 000.00),
  CHECK ([Range] < 1000),
  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [weapon]( item_ID ),

)

CREATE TABLE  physical (
  item_ID       bigint         NOT NULL,
  PiercingRate  decimal(7,3)    NOT NULL,
  FireRate      decimal(7,3)    NOT NULL,

  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [ranged]( item_ID ),
  CHECK (PiercingRate > 0),
  CHECK (FireRate > 0),
)



CREATE TABLE magical (
  item_ID    bigint                 NOT NULL,
  CoolDown   decimal(6,2)            NOT NULL,
  RadiusOfEffectiveness     int     NOT NULL,

  CHECK (RadiusOfEffectiveness >= 10.00 and RadiusOfEffectiveness <= 1000.00),
  CHECK (CoolDown > 0 and CoolDown <100),
  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [ranged]( item_ID )
)


CREATE TABLE melee(
    Weapon_ID     bigint            NOT NULL,
    AttackSpeed   DECIMAL(4,3)      NOT NULL DEFAULT 0.625,
    HandNum       int               NOT NULL DEFAULT 1,
    MeleeType     varchar(128)      NOT NULL,
    CHECK (AttackSpeed > 0 and AttackSpeed < 2.500),
    CHECK (HandNum > 0 and HandNum < 8),
    PRIMARY KEY  (Weapon_ID),
    FOREIGN KEY (Weapon_ID) references [weapon]( item_ID ),

)

CREATE TABLE armor (

  ID        bigint            NOT NULL,
  SpecialAttributes           varchar(128),
  Defense   DECIMAL(6,3)      NOT NULL,
  HealthBonus     decimal(38,5),
  
  CHECK (HealthBonus > 0),
  CHECK (Defense <= 100),
  PRIMARY KEY  (ID),
  FOREIGN KEY (ID) references [item]( ID ),
)
go
CREATE TABLE shield (

  ID        bigint            NOT NULL,
  Defense   DECIMAL(6,3)      NOT NULL,
  SpecialAbility    varchar(128),
  
  CHECK (Defense <= 100),
  PRIMARY KEY  (ID),
  FOREIGN KEY (ID) references [item]( ID ),
)



-- Procedure to insert a new user acc
go
CREATE PROCEDURE dbo.user_store_proc (
    @uEmail NVARCHAR(320),
    @uAccName VARCHAR(128),
    @uPassword NVARCHAR(50),
    @uRealCurrency DECIMAL(38,3)   = NULL,
    @uGameCurrency DECIMAL(38,3)   = NULL,
    @responseMessage NVARCHAR(250) OUTPUT )
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO dbo.[user] (Email, AccName, Pass, RealCurrency, GameCurrency)
        VALUES(@uEmail, @uAccName , HASHBYTES('SHA2_512', @uPassword), @uRealCurrency, @uGameCurrency)

        SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE()
    END CATCH

END

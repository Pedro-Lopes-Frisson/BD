
CREATE TABLE specialItem (

            ID  int   --NOT NULL,
            Name  varchar(128)  NOT NULL,
            Price  smallmoney  NOT NULL,
            CurrencyType  bit CONSTRAINT default_currencyType DEFAULT 1, -- By default special items are paid with real money
            -- 1 for real money
            [Rank] int , -- Pode ser null?
            PRIMARY KEY (ID)
          )

CREATE TABLE consumable (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID)-- NOT NULL,
            Effect          varchar(128) NOT NULL,
            Duration        DOUBLE(100,3)       NOT NULL,
            Quantity        int          ,
            PRIMARY KEY (SpecialItem_ID)
            CONSTRAINT FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)

)

CREATE TABLE cosmetic (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID)-- NOT NULL,
            Type            varchar(128)   NOT NULL,
            BodyPart        varchar(128)   NOT NULL,
            Gender          varchar(128)   ,
            PRIMARY KEY (SpecialItem_ID)
            CONSTRAINT FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)
)

CREATE TABLE [user] (
            UserID          INT IDENTITY(1,1) NOT NULL,
            Email           NVARCHAR(320)  NOT NULL,
            AccName         varchar(128)    NOT NULL,
            Pass            BINARY(64)      NOT NULL,
            RealCurrency    DOUBLE(100,3)          NOT NULL DEFAULT 0,
            GameCurrency    DOUBLE(100,3)          NOT NULL DEFAULT 0,
            Stash_ID        bigint        ,
            PRIMARY KEY (UserID)
        )

CREATE TABLE [stash] (
  ID             bigint                 NOT NULL,
  User_ID        int                    NOT NULL,
  NumberOfTabs   int                    NOT NULL DEFAULT 0,
  CHECK (NumberOfTabs < 65 and NumberOfTabs > 0)
  PRIMARY KEY (UserID, ID)
  CONSTRAINT FOREIGN KEY (User_ID) references [user](UserID)
)

CREATE TABLE vendorStash(
  ID             bigint                 NOT NULL,
  User_ID     NVARCHAR(320)          NOT NULL,
  TypeCode       nvarchar(200)          NOT NULL,
  PRIMARY KEY [stash](UserID, ID)
  --CHECK(TypeCode LIKE 'vendor[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  CONSTRAINT FOREIGN KEY (User_ID,ID) references [stash](UserID, ID)
)

CREATE TABLE buyerStash(
  ID             bigint                 NOT NULL,
  User_Email     NVARCHAR(320)          NOT NULL,
  TypeCode       nvarchar(200)          NOT NULL,
  PRIMARY KEY [stash](User_Email, ID)
  --CHECK(TypeCode LIKE 'buyer[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  CONSTRAINT FOREIGN KEY (User_ID,ID) references [stash](UserID, ID)
)

CREATE TABLE stashTabs (
  ID               bigint                 NOT NULL,
  User_ID          NVARCHAR(320)          NOT NULL,
  [Number]         bigint                 NOT NULL,
  PRIMARY KEY [stash](ID, User_ID, [Number])
  CONSTRAINT FOREIGN KEY (ID, User_ID ) references [stash](UserID, ID)
)

CREATE TABLE normalTab (
  ID               bigint                 NOT NULL,
  User_ID          NVARCHAR(320)          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 60,
  PRIMARY KEY [stash](ID, User_ID, [Number])
  CONSTRAINT FOREIGN KEY (ID, User_ID, [Number] ) references [stashTabs](UserID, ID, [Number])
)

CREATE TABLE specialTab (
  ID               bigint                 NOT NULL,
  User_ID          NVARCHAR(320)          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 20,
  PRIMARY KEY [stash](ID, User_ID, [Number])
  CONSTRAINT FOREIGN KEY (ID, User_ID, [Number] ) references [stashTabs](UserID, ID, [Number])
)

CREATE TABLE item (

  ID        bigint            NOT NULL,
  Price     DOUBLE(100,3)     NOT NULL,
  Name      varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  PRIMARY KEY  (ID)
)

CREATE TABLE weapon(
  item_ID    bigint            NOT NULL,
  SpecialAttributes     varchar(128)  ,--Pode ser um composito ?
  Damage    double(100,2)      NOT NULL,
  DamageType  varchar(128)     NOT NULL, -- Atributo multivalor ?
  CriticalChance decimal(5,2) NOT NULL DEFAULT 000.00,
  CriticalMutiplier decimal(5,2) NOT NULL DEFAULT 000.00,

  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [item]( ID )
  CHECK (CriticalChance <= 100.00 and CriticalChance >= 000.00
        and CriticalMutiplier <= 100.00 and CriticalMutiplier >= 000.00)

)

CREATE TABLE  ranged (
  item_ID    bigint            NOT NULL,
  Range      int               NOT NULL DEFAULT 100,
  Accuraccy  DECIMAL(5,2)      NOT NULL DEFAULT 65.000,

  CHECK (Accuraccy <= 100.00 and Accuraccy >= 000.00)
  CHECK (Range < 1000)
  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [weapon]( ID )

)

CREATE TABLE  physical (
  item_ID       bigint         NOT NULL,
  PiercingRate  double(7,3)    NOT NULL,
  FireRate      double(7,3)    NOT NULL,

  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [ranged]( ID )
  CHECK (PiercingRate > 0)
  CHECK (FireRate > 0)
)



CREATE TABLE  magical (
  item_ID    bigint                 NOT NULL,
  CoolDown   DOUBLE(7,2)            NOT NULL,
  RadiusOfEffectiveness     int     NOT NULL,

  CHECK (Accuraccy <= 100.00 and Accuraccy >= 000.00)
  CHECK (CoolDown > 0)
  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [ranged]( ID )
)


CREATE TABLE melee(
    Weapon_ID     bigint            NOT NULL,
    AttackSpeed   DECIMAL(4,3)      NOT NULL DEFAULT 0.625,
    HandNum       int               NOT NULL DEFAULT 1,
    MeleeType     varchar(128)      NOT NULL,
    CHECK (AttackSpeed > 0 and AttackSpeed < 2.500)
    CHECK (HandNum > 0 and HandNum < 8)
    PRIMARY KEY  (ID)
    CONSTRAINT FOREIGN KEY (ID) references [weapon]( ID )

)


CREATE TABLE armor (

  ID        bigint            NOT NULL,
  SpecialAttributes           varchar(128),
  Defense   DECIMAL(6,3)      NOT NULL,
  HealthBonus     decimal(100,5),

  CHECK (Defense <= 100)
  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [item]( ID )
  CHECK (HealthBonus > 0)
)
CREATE TABLE shield (

  ID        bigint            NOT NULL,
  Defense   DECIMAL(6,3)      NOT NULL,
  SpecialAbility    varchar(128),
  PRIMARY KEY  (ID)
  CONSTRAINT FOREIGN KEY (ID) references [item]( ID )
  CHECK (Defense <= 100)
)







-- Procedure to insert a new user acc
CREATE PROCEDURE dbo.user_store_proc
    @uEmail NVARCHAR(320),
    @uAccName VARCHAR(128),
    @uPassword NVARCHAR(50),
    @uRealCurrency DOUBLE(100,3)   = NULL,
    @uGameCurrency DOUBLE(100,3)   = NULL,
    --@uStashId     bigInt    =
    @uesponseMessage NVARCHAR(250) OUTPUT
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

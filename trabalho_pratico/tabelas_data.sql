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
go

CREATE TABLE consumable (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID), -- NOT NULL,
            [Effect]        varchar(128) NOT NULL,
            Duration        decimal(38,3)       NOT NULL,
            Quantity        int          ,
            PRIMARY KEY (SpecialItem_ID),
            FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)

)
go

CREATE TABLE cosmetic (
            SpecialItem_ID  int   FOREIGN KEY REFERENCES specialItem(ID), -- NOT NULL,
            [Type]          varchar(128)   NOT NULL,
            BodyPart        varchar(128)   NOT NULL,
            Gender          varchar(128)   ,
            PRIMARY KEY (SpecialItem_ID),
            FOREIGN KEY (SpecialItem_ID) references [specialItem] (ID)
)
go

create TABLE [user] (
            UserID          INT IDENTITY(1,1) NOT NULL,
            Email           NVARCHAR(320)  NOT NULL,
            AccName         varchar(128)    NOT NULL,
            Pass            BINARY(64)      NOT NULL,
            RealCurrency    decimal(38,3)          NOT NULL DEFAULT 0,
            GameCurrency    decimal(38,3)          NOT NULL DEFAULT 0,
            PRIMARY KEY (UserID),
        )
go
alter table [user] add constraint unique_email unique (Email)

CREATE TABLE [stash] (
  ID             bigint                 NOT NULL,
  [User_ID]        int                    NOT NULL,
  NumberOfTabs   int                    NOT NULL DEFAULT 0,
  CHECK (NumberOfTabs < 65 and NumberOfTabs > 0),
  PRIMARY KEY (ID),
  FOREIGN KEY ([User_ID]) references [user](UserID)
)
go

CREATE TABLE vendorStash(
  ID             bigint                 NOT NULL,
  TypeCode       int          NOT NULL,
  PRIMARY KEY (ID, TypeCode),
  --CHECK(TypeCode LIKE 'vendor[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  FOREIGN KEY (ID) references [stash](ID)
)
go

CREATE TABLE buyerStash(
  ID             bigint                 NOT NULL,
  TypeCode       int          NOT NULL,
  PRIMARY KEY (ID, TypeCode),
  --CHECK(TypeCode LIKE 'buyer[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
  FOREIGN KEY (ID) references [stash](ID)
)
go

CREATE TABLE stashTabs (
  [Stash_ID]        bigint                    NOT NULL,
  [Number]         bigint                 NOT NULL,
  PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID]) references [stash] ([ID])
)
go

CREATE TABLE normalTab (
  [Stash_ID]     bigint          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 60,
  PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID], [Number] ) references [stashTabs]([Stash_ID], [Number])
)
go

CREATE TABLE specialTab (
  [Stash_ID]     bigint          NOT NULL,
  [Number]         bigint                 NOT NULL,
  SlotSpace        int                    NOT NULL DEFAULT 20, PRIMARY KEY ([Stash_ID], [Number]),
  FOREIGN KEY ([Stash_ID], [Number] ) references [stashTabs]([Stash_ID], [Number])
)
go

CREATE TABLE item (

  ID        bigint identity(1,1)            NOT NULL, 
  Stash_ID  bigint            NOT NULL,
  TabNumber bigint            NOT NULL,
  BaseItem_ID bigint		  DEFAULT NULL,

  Price     decimal(38,3)     NOT NULL,
  [Name]    varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,

  PRIMARY KEY (ID),
  FOREIGN KEY (Stash_ID , TabNumber ) references [normalTab]([Stash_ID], [Number]),
  FOREIGN KEY (BaseItem_ID) references [item](ID)

)
go

CREATE TABLE weapon(
  item_ID               bigint            NOT NULL,
  SpecialAttributes     varchar(128)  ,    --Pode ser um composito ?
  Damage                decimal(38,2)      NOT NULL,
  DamageType            varchar(128)     NOT NULL,      -- Atributo multivalor ?
  CriticalChance        decimal(5,2) NOT NULL DEFAULT 000.00,
  CriticalMutiplier     decimal(5,2) NOT NULL DEFAULT 000.00,
  BaseItem_ID			bigint		  DEFAULT NULL,
	-- Item specifics
  Price     decimal(38,3)     NOT NULL,
  [Name]    varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  TabNumber bigint            NOT NULL,
  Stash_ID  bigint            NOT NULL,

  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [item]( ID ),
  FOREIGN KEY (BaseItem_ID) references weapon(item_ID),
  CHECK (CriticalChance <= 100.00 and CriticalChance >= 000.00),
  CHECK( CriticalMutiplier <= 100.00 and CriticalMutiplier >= 000.00)

)
go

CREATE TABLE ranged (
  item_ID    bigint            NOT NULL,
  [Range]      int               NOT NULL DEFAULT 100,
  Accuraccy  DECIMAL(5,2)      NOT NULL DEFAULT 65.000,
  BaseItem_ID bigint		  DEFAULT NULL,

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

  CHECK (Accuraccy <= 100.00 and Accuraccy >= 000.00),
  CHECK ([Range] < 1000),
  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [weapon]( item_ID ),
    FOREIGN KEY (BaseItem_ID) references ranged(item_ID)
)
go

CREATE TABLE  physical (
  item_ID       bigint         NOT NULL,
  PiercingRate  decimal(7,3)    NOT NULL,
  FireRate      decimal(7,3)    NOT NULL,
  BaseItem_ID bigint		  DEFAULT NULL,

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
  FOREIGN KEY (BaseItem_ID) references physical(item_ID),
  CHECK (PiercingRate > 0),
  CHECK (FireRate > 0),
)
go

CREATE TABLE magical (
  item_ID    bigint                 NOT NULL,
  CoolDown   decimal(6,2)            NOT NULL,
  RadiusOfEffectiveness     int     NOT NULL,
  BaseItem_ID bigint		  DEFAULT NULL,
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

  CHECK (RadiusOfEffectiveness >= 10.00 and RadiusOfEffectiveness <= 1000.00),
  CHECK (CoolDown > 0 and CoolDown <100),
  PRIMARY KEY  (item_ID),
  FOREIGN KEY (item_ID) references [ranged]( item_ID ),
  FOREIGN KEY (BaseItem_ID) references magical(item_ID)
)
go

CREATE TABLE melee(
    Weapon_ID     bigint            NOT NULL,
    AttackSpeed   DECIMAL(4,3)      NOT NULL DEFAULT 0.625,
    HandNum       int               NOT NULL DEFAULT 1,
    MeleeType     varchar(128)      NOT NULL,
    BaseItem_ID   bigint		    DEFAULT NULL,
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

    CHECK (AttackSpeed > 0 and AttackSpeed < 2.500),
    CHECK (HandNum > 0 and HandNum < 8),
    PRIMARY KEY  (Weapon_ID),
    FOREIGN KEY (Weapon_ID) references [weapon]( item_ID ),
    FOREIGN KEY (BaseItem_ID) references melee(Weapon_ID)

)
go

CREATE TABLE armor (

  ID        bigint            NOT NULL,
  SpecialAttributes           varchar(128),
  Defense   DECIMAL(6,3)      NOT NULL,
  HealthBonus     decimal(38,5),
  BaseItem_ID bigint		  DEFAULT NULL,
	-- Item specifics
  Price     decimal(38,3)     NOT NULL,
  [Name]    varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  TabNumber bigint            NOT NULL,
  Stash_ID  bigint            NOT NULL,
  
  CHECK (HealthBonus > 0),
  CHECK (Defense <= 100),
  PRIMARY KEY  (ID),
  FOREIGN KEY (ID) references [item]( ID ),
  FOREIGN KEY (BaseItem_ID) references armor(ID)
)
go

CREATE TABLE shield (

  ID        bigint            NOT NULL,
  Defense   DECIMAL(6,3)      NOT NULL,
  SpecialAbility    varchar(128),
  BaseItem_ID bigint		  DEFAULT NULL,
	-- Item specifics
  Price     decimal(38,3)     NOT NULL,
  [Name]    varchar(128)      NOT NULL,
  isUnique  bit               NOT NULL DEFAULT 0,
  Upgraded  int               NOT NULL DEFAULT 0,
  [Rank]    int               ,
  TabNumber bigint            NOT NULL,
  Stash_ID  bigint            NOT NULL,
  
  CHECK (Defense <= 100),
  PRIMARY KEY  (ID),
  FOREIGN KEY (ID) references [item]( ID ),
  FOREIGN KEY (BaseItem_ID) references shield(ID)
)

go
CREATE TABLE [class] (
    [Name]                   varchar(512)     NOT NULL,
    BaseStrength           DECIMAL(38,3),
    BaseInteligence        DECIMAL(38,3),
    BaseDexterity          DECIMAL(38,3),
    BaseLife               DECIMAL(38,3),
    BaseMana               DECIMAL(38,3),
    BaseAccuracy           DECIMAL(38,3),
    PRIMARY KEY ([Name]),
)

go

create TABLE [character] (
  
    [Name]             varchar(128)    NOT NULL,
    Strength           DECIMAL(38,3),
    Inteligence        DECIMAL(38,3),
    Dexterity          DECIMAL(38,3),
    User_email         NVARCHAR(320),
    Class_Name         VARCHAR(512),
    PRIMARY KEY (Class_Name, Name ),
    FOREIGN KEY (Class_Name) REFERENCES [class] (Name),
    FOREIGN KEY (User_email) REFERENCES [user] (Email)

)
go
CREATE TABLE [requirements] (
    Item_id             bigint   NOT NULL,
    [Level]             bigint   ,
    Dexterity           DECIMAL(38,3),
    Inteligence         DECIMAL(38,3),
    Strength            DECIMAL(38,3),
    CharClass           DECIMAL(38,3),
    PRIMARY KEY     (Item_ID),
    FOREIGN KEY (Item_ID) references [item] (ID) ,



)



-- View NON CLUSTERED fill factor 75% for items level podemos uqeres inserir a meio de uma tabela
CREATE NONCLUSTERED INDEX IxItemLevel ON dbo.[item] 
([Level]) WITH (FILLFACTOR = 75, PAD_INDEX = ON)
-- View For usernames non clustered 80% 
CREATE NONCLUSTERED INDEX IxUserNamesHash ON dbo.[user]
(AccName,Pass) WITH (FILLFACTOR = 75, PAD_INDEX = ON)

---- Procedure to insert a new user acc
--go
--CREATE PROCEDURE dbo.user_store_proc (
--    @uEmail NVARCHAR(320),
--    @uAccName VARCHAR(128),
--    @uPassword NVARCHAR(50),
--    @uRealCurrency DECIMAL(38,3)   = NULL,
--    @uGameCurrency DECIMAL(38,3)   = NULL,
--    @responseMessage NVARCHAR(250) OUTPUT )
--AS
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRY

--        INSERT INTO dbo.[user] (Email, AccName, Pass, RealCurrency, GameCurrency)
--        VALUES(@uEmail, @uAccName , HASHBYTES('SHA2_512', @uPassword), @uRealCurrency, @uGameCurrency)

--        SET @responseMessage='Success'

--    END TRY
--    BEGIN CATCH
--        SET @responseMessage=ERROR_MESSAGE()
--    END CATCH

------ USAGE
----DECLARE @responseMessage NVARCHAR(250);

----EXEC dbo.user_store_proc
----    @uEmail = N'pdfl@ua.pt',
----    @uAccName = N'asdf',
----    @uPassword  = N'aminhapass',
----    @uRealCurrency    = 1.00,
----    @uGameCurrency    = 1.0,
----    @responseMessage =    @responseMessage  OUTPUT 
go

-- SELECT * FROM [user]
---------------------------------------------------------------
--
-- INSERT USER DATA
--
-------------------------------------------------------
--INSERT INTO [User]([Email],[AccName],[Pass],[RealCurrency],[GameCurrency]) 
--VALUES('tincidunt.neque@Phaselluslibero.net','aliquet.', HASHBYTES('SHA2_512', 'XMX25CAM9HI'),'174.191','8.31'),
--('aliquet.molestie.tellus@acmattis.edu','quis,', HASHBYTES('SHA2_512', 'JSZ52ZIA4KW'),'19.390','2.41'),
--('Pellentesque.ut@atiaculis.org','malesuada', HASHBYTES('SHA2_512', 'BWY93FAX7TG'),'28.093','2.63'),
--('ipsum.porta@risusDonec.edu','consectetuer,',HASHBYTES('SHA2_512', 'BFA05NCL7GV'),'182.305','4.21'),
--('tellus.eu@accumsansedfacilisis.edu','ante',HASHBYTES('SHA2_512', 'YLJ79NKR9AO'),'138.354','1.27'),
--('elementum@ultricesposuere.com','pretium',HASHBYTES('SHA2_512', 'NXV07OZF9WN'),'77.255','7.80'),
--('dolor@lectusNullam.edu','eget',HASHBYTES('SHA2_512', 'TFK06WZI0XQ'),'82.133','0.67'),
--('nulla@mattisvelit.org','nostra,',HASHBYTES('SHA2_512', 'GGO12LSK6UV'),'197.596','4.77'),
--('et.magnis@gravidamolestie.edu','natoque',HASHBYTES('SHA2_512', 'QFP26PCW8IB'),'48.018','5.21'),
--('porttitor@erosProinultrices.org','ipsum',HASHBYTES('SHA2_512', 'YNK75XCW2TD'),'96.237','1.04'),
--('habitant@risusDonecegestas.com','feugiat.',HASHBYTES('SHA2_512', 'ZTJ82QVK8YJ'),'159.220','7.65'),
--('est@bibendumfermentummetus.com','nibh',HASHBYTES('SHA2_512', 'KZA99PET3CD'),'94.013','1.17'),
--('lobortis.augue.scelerisque@etmagnisdis.ca','tristique',HASHBYTES('SHA2_512', 'PCQ26XRE9FZ'),'70.204','6.59'),
--('dictum.placerat@tempus.org','eu',HASHBYTES('SHA2_512', 'SNG97IYY2UG'),'153.886','1.93'),
--('Mauris@tellusPhaselluselit.ca','ut',HASHBYTES('SHA2_512', 'JEE70OFA5ME'),'117.122','1.12'),
--('tellus@libero.org','eget',HASHBYTES('SHA2_512', 'ZNN14IML4NL'),'193.488','9.36'),
--('libero.et.tristique@imperdietornare.net','nec',HASHBYTES('SHA2_512', 'LTJ19GZT0JP'),'143.988','4.22'),
--('elementum.sem@erosProin.ca','blandit',HASHBYTES('SHA2_512', 'TYW24TWI4FV'),'129.941','3.13'),
--('penatibus.et.magnis@Curae.net','facilisis,',HASHBYTES('SHA2_512', 'XJF45SDD6DJ'),'69.049','9.56'),
--('scelerisque@elementumsem.edu','est,',HASHBYTES('SHA2_512', 'PEP27NYN8JN'),'192.162','6.21'),
--('Quisque.porttitor@sapien.co.uk','dui.',HASHBYTES('SHA2_512', 'XNZ19PZI3US'),'109.648','7.47'),
--('ante.ipsum.primis@egetipsum.com','vulputate',HASHBYTES('SHA2_512', 'SEH13VUK1MC'),'46.631','5.21'),
--('Donec@rutrumeu.co.uk','accumsan',HASHBYTES('SHA2_512', 'SDW58CDN6ER'),'147.580','8.98'),
--('massa.lobortis.ultrices@morbi.net','Nunc',HASHBYTES('SHA2_512', 'BRG09CWK3ZH'),'8.512','8.76'),
--('turpis.non@liberoet.co.uk','eu,',HASHBYTES('SHA2_512', 'ZUR44MAH2SB'),'172.514','8.23'),
--('Vivamus.rhoncus@aliquetdiam.org','lacinia',HASHBYTES('SHA2_512', 'ETL93WWC7ZZ'),'139.522','2.57')

------------------------------------------------------------------------
--
-- INSERT STASH DATA
--
------------------------------------------------------------------------
-- SELECT * FROM [stash]
--INSERT INTO stash([ID],[User_ID],[NumberOfTabs]) 
--VALUES(123,1,20),
--(507,2,1),
--(875,3,4),
--(739,4,4),
--(721,5,5),
--(959,6,5),
--(782,7,13),
--(63,8,13),
--(338,9,4),
--(378,10,9),
--(320,11,5),
--(518,12,15),
--(856,13,17),
--(840,14,10),
--(775,15,2),
--(55,16,9),
--(983,17,3),
--(512,18,1),
--(186,19,15),
--(143,20,18),
--(570,21,11),
--(761,22,1),
--(361,23,14),
--(903,24,18),
--(621,25,20),
--(325,26,13)



------------------------------------------------------------------------
--
-- INSERT STASHTABS DATA                         (Per Stash ADD X TAB)
--
------------------------------------------------------------------------
-- SELECT * FROM [stashTabs]

--INSERT INTO stashTabs([Stash_ID],[Number]) VALUES(55,1),(55,2),(55,3),(55,4),(55,5),(55,6),(55,7),(55,8),(55,9);


-------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) VALUES(63,1),(63,2),(63,3),(63,4),(63,5),(63,6),(63,7),(63,8),(63,9);

-------------------------------------

--INSERT INTO stashTabs([Stash_ID],[Number]) VALUES(123,1),(123,2),(123,3),(123,4),(123,5),(123,6),(123,7),(123,8),(123,9);
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(123,10),(123,11),(123,12),(123,13),(123,14),(123,15),(123,16);


-------------------------------------

--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(143,1),(143,2),(143,3),(143,4),(143,5),(143,6),(143,7),(143,8),(143,9);

-------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(186,1),(186,2),(186,3),(186,4),(186,5),(186,6),(186,7),(186,8),(186,9),(186,10),(186,11);

-------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(320,1),(320,2),(320,3),(320,4),(320,5);
-------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(325,1),(325,2),(325,3),(325,4),(325,5),(325,6),(325,7),(325,8),(325,9),(325,10),(325,11);

-------------------------------------

--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(338,1),(338,2),(338,3),(338,4);

------------------------------------

--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(361,1),(361,2),(361,3),(361,4),(361,5),(361,6),(361,7),(361,8),(361,9),(361,10),(361,11);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(378,1),(378,2),(378,3),(378,4),(378,5),(378,6),(378,7),(378,8),(378,9);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(507,1);

-------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(512,1);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(518,1),(518,2),(518,3),(518,4),(518,5),(518,6),(518,7),(518,8),(518,9),(518,10),(518,11);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(570,1),(570,2),(570,3),(570,4),(570,5),(570,6),(570,7),(570,8),(570,9),(570,10),(570,11);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(621,1),(621,2),(621,3),(621,4),(621,5),(621,6),(621,7),(621,8),(621,9),(621,10),(621,11),(621,12),(621,13),(621,14),(621,15);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(721,1),(721,2),(721,3),(721,4),(721,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(739,1),(739,2),(739,3),(739,4);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(761,1);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(775,1),(775,2),(775,3),(775,4),(775,5);

---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(782,1),(782,2),(782,3),(782,4),(782,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(840,1),(840,2),(840,3),(840,4),(840,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(856,1),(856,2),(856,3),(856,4),(856,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(875,1),(875,2),(875,3),(875,4);
---------------------------------------

--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(903,1),(903,2),(903,3),(903,4),(903,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(959,1),(959,2),(959,3),(959,4),(959,5);
---------------------------------------
--INSERT INTO stashTabs([Stash_ID],[Number]) 
--VALUES(983,1),(983,2),(983,3),(983,4);
---------------------------------------




------------------------------------------------------------------------
--
-- INSERT BuyerStash DATA                 
--
------------------------------------------------------------------------
-- SELECT * FROM [buyerStash]
--INSERT INTO buyerStash([ID],[TypeCode]) 
--VALUES
--(123,2),
--(507,2),
--(875,2),
--(739,2),
--(721,2),
--(959,2),
--(782,2),
--(63,2),
--(338,2),
--(378,2),
--(320,2),
--(518,2),
--(856,2),
--(840,2),
--(775,2),
--(55,2),
--(983,2),
--(512,2),
--(186,2),
--(143,2),
--(570,2),
--(761,2),
--(361,2),
--(903,2),
--(621,2),
--(325,2);
------------------------------------------------------------------------
--
-- INSERT BuyerStash DATA                 
--
------------------------------------------------------------------------
-- SELECT * FROM [vendorStash]

--INSERT INTO vendorStash([ID],[TypeCode]) 
--VALUES
--(123,1),
--(507,1),
--(875,1),
--(739,1),
--(721,1),
--(959,1),
--(782,1),
--(63,1),
--(338,1),
--(378,1),
--(320,1),
--(518,1),
--(856,1),
--(840,1),
--(775,1),
--(55,1),
--(983,1),
--(512,1),
--(186,1),
--(143,1),
--(570,1),
--(761,1),
--(361,1),
--(903,1),
--(621,1),
--(325,1);
------------------------------------------------------------------------
--
-- INSERT normalTabs DATA                 
--
------------------------------------------------------------------------
--INSERT INTO normalTab([Stash_ID],[Number]) select * from stashTabs where number < 10;
------------------------------------------------------------------------
--
-- INSERT specialTabs DATA                 
--
------------------------------------------------------------------------
--INSERT INTO specialTab([Stash_ID],[Number]) select * from stashTabs where number >= 10;
--SELECT * FROM specialTab;
--SELECT * FROM normalTab;



--DROP TRIGGER physicalTrigger;

--DROP TRIGGER physicalTrigger;
go
SELECT * FROM item;
SELECT * FROM stash;
SELECT * FROM weapon;
SELECT * FROM ranged;
SELECT * FROM physical;


-- 10001,  12.5 ,  2, 54, 'Bow', 0, 0, 0,4,55, 500 , 'Fire', 21, 10, 500, 57

go

--CREATE PROC getLoginInfo(
--@Username as varchar(128),
--@Password as binary(64) OUTPUT
--)
--as
--begin
-- Select @Password = Pass from [user] where AccName =  @Username
--end
--go

--select AccName from [user]
--go
--DECLARE @Password as binary(64);
--exec getLoginInfo @Username = 'malesuada', @Password= @Password OUTPUT;
--select @Password as N'@Password'
--go

alter proc Verify_Login (@Username varchar(128), @Password varchar(128), @Verified binary OUTPUT) 
AS
Begin 
    DECLARE @returned binary(64)
    select @returned= Pass from [user] where AccName = @Username
	DECLARE @success binary
	if(@returned = HASHBYTES('SHA2_512', @Password)) Select @Verified = 1
	else Select @Verified = 0
end
go

alter proc physicalTrigger (
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
@FireRate          AS   decimal(7,3)		,
--requiremtns
@Level              AS         bigint   ,
@Dexterity          AS         DECIMAL(38,3),
@Inteligence		AS         DECIMAL(38,3),
@Strength           AS         DECIMAL(38,3),
@CharClass          AS         DECIMAL(38,3),
)
AS 
BEGIN
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
                             CharClass         
                             
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
END
go

alter PROC magicalInsert(
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
          @CoolDown               AS   decimal(6,2)            ,
          @RadiusOfEffectiveness  AS    int,
          --requiremtns
          @Level              AS         bigint   ,
          @Dexterity          AS         DECIMAL(38,3),
          @Inteligence  		AS         DECIMAL(38,3),
          @Strength           AS         DECIMAL(38,3),
          @CharClass          AS         DECIMAL(38,3)
)
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
				     [Rank]        ,
                     [Level]       ,      
                     Dexterity   ,      
                     Inteligence ,  	
                     Strength    ,      
                     CharClass        ) 
				VALUES (@ID          ,
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

						VALUES (@ID          ,
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
				     CoolDown      ,          
                                     RadiusOfEffectiveness  

			)                   

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
							@Range                 ,
							@Accuraccy             ,
				         		@CoolDown              ,
						        @RadiusOfEffectiveness);
	COMMIT;
END
go

alter PROC meleeInsert(
	--melee specifics
    @Weapon_ID          AS          bigint            ,
    @AttackSpeed        AS          DECIMAL(4,3)      ,
    @HandNum            AS          int               ,
    @MeleeType          AS          varchar(128)      ,
	-- Item specifics
    @Price              AS          decimal(38,3)     ,
    @Name               AS          varchar(128)      ,
    @isUnique           AS          bit               ,
    @Upgraded           AS          int               ,
    @Rank               AS          int               ,
    @TabNumber          AS          bigint            ,
    @Stash_ID           AS          bigint            ,
	-- weapon specifics
    @SpecialAttributes  AS          varchar(128)      ,    --Pode ser um composito ?
    @Damage             AS          decimal(38,2)     ,
    @DamageType         AS          varchar(128)      ,      -- Atributo multivalor ?
    @CriticalChance     AS          decimal(5,2)      ,
    @CriticalMutiplier  AS          decimal(5,2)      ,
    --requiremtns
    @Level              AS         bigint   ,
    @Dexterity          AS         DECIMAL(38,3),
    @Inteligence		AS         DECIMAL(38,3),
    @Strength           AS         DECIMAL(38,3),
    @CharClass          AS         DECIMAL(38,3)

                                  			)
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
				     [Rank]   ,
                     [Level]      ,    			             
                     Dexterity    ,  
				     Inteligence  ,  
				     Strength     ,  
				     CharClass    )
					 VALUES (  @Weapon_ID          ,
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
					      ) VALUES (@Weapon_ID                    ,
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
		INSERT INTO [melee](Weapon_ID  ,
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
						VALUES (@Weapon_ID                    ,
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
				                        @MeleeType             
						);
	COMMIT;
END
go
alter PROC shieldInsert(
	--armor specifics
    @Defense			AS         decimal(6, 3)     ,
    @SpecialAbility     AS         varchar(128)      ,
	-- Item specifics
    @Price              AS         decimal(38,3)     ,
    @Name				AS         varchar(128)      ,
    @isUnique           AS         bit               ,
    @Upgraded           AS         int               ,
    @BaseItem_ID        AS          bigint            ,
    @Rank				AS         int               ,
    @TabNumber          AS         bigint            ,
    @Stash_ID           AS         bigint            ,
    --requiremtns
    @Level              AS         bigint   ,
    @Dexterity          AS         DECIMAL(38,3),
    @Inteligence		AS         DECIMAL(38,3),
    @Strength           AS         DECIMAL(38,3),
    @CharClass          AS         DECIMAL(38,3)

)
as
BEGIN
declare @Item_ID bigint;
select  @Item_ID = count(*) from item;
select  @Item_ID = @Item_ID+1;
	INSERT INTO [item]  (ID       ,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
             [Level]    ,
             Dexterity  ,
             Inteligence,
             Strength   ,
             CharClass)

          VALUES (@Item_ID     ,
			  @Stash_ID    ,
			  @TabNumber   ,
			  @Price       ,
			  @Name        ,
			  @isUnique    ,
			  @Upgraded    ,
			  @Rank        ,
              @BaseItem_ID ,
              @Level       ,
              @Dexterity   ,
              @Inteligence ,
              @Strength    ,
              @CharClass        );

		INSERT INTO [shield](ID  ,
				     Stash_ID ,
				     TabNumber,
				     Price    ,
				     [Name]   ,
				     isUnique ,
				     Upgraded ,
				     [Rank]   ,
				     Defense,
					 SpecialAbility
					      ) VALUES (@Item_ID       ,
							@Stash_ID              ,
							@TabNumber             ,
							@Price                 ,
							@Name                  ,
							@isUnique              ,
							@Upgraded              ,
							@Rank                  ,
							@Defense,
							@SpecialAbility)
END
go
alter PROC armorInsert(
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
    @Stash_ID           AS          bigint            ,
    @Level              AS         bigint   ,
    @Dexterity          AS         DECIMAL(38,3),
    @Inteligence    		AS         DECIMAL(38,3),
    @Strength           AS         DECIMAL(38,3),
    @CharClass          AS         DECIMAL(38,3)
)
as
BEGIN
declare @Item_ID bigint;
select  @Item_ID = count(*) from item;
select  @Item_ID = @Item_ID+1;
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
              @ID          ,
							@Stash_ID    ,
							@TabNumber   ,
							@Price       ,
							@Name        ,
							@isUnique    ,
							@Upgraded    ,
              @BaseItem_ID ,
							@Rank        ,
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
					 HealthBonus
					      ) VALUES (@item_ID                    ,
							@Stash_ID              ,
							@TabNumber             ,
							@Price                 ,
							@Name                  ,
							@isUnique              ,
							@Upgraded              ,
							@Rank                  ,
							@Defense,
							@HealthBonus)
END
go
CREATE PROC insertCosmetic(
            @ID    AS  int,
            @Name AS  varchar(128)  ,
			@CurrencyType as varchar(128),
            @Price AS  smallmoney  ,
            --@CurrencyType AS   bit,
            @Rank  AS  int ,
            @Type   AS      varchar(128)   ,
            @BodyPart  AS    varchar(128)   ,
            @Gender    AS    varchar(128)   
)
AS
	BEGIN
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@ID, @Name, @Price, @CurrencyType,@Rank)

		INSERT INTO [cosmetic] (ID,  [Type], [BodyPart], Gender)
		VALUES (@ID,@Type,@BodyPart,@Gender)
	END

go
CREATE PROC insertConsumable(
            @ID    AS  int,
            @Name AS  varchar(128)  ,
            @Price AS  smallmoney  ,
			@CurrencyType as varchar(128),
            --@CurrencyType AS   bit,
            @Rank  AS  int ,
	-- Consumable
	@Effect    AS  varchar(128),
	@Duration  AS    decimal(38,3),
	@Quantity   AS   int         
)
AS
	BEGIN
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@ID, @Name, @Price, @CurrencyType,@Rank)

		INSERT INTO [consumable] (ID,  [Effect], [Duration], Quantity)
		VALUES (@ID,@Effect,@Duration,@Quantity)
	END



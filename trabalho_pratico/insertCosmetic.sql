CREATE PROC insertCosmetic(
            @ID    AS  int,
            @Name AS  varchar(128)  ,
            @Price AS  smallmoney  ,
            --@CurrencyType AS   bit,
            @Rank  AS  int 
            @Type   AS      varchar(128)   ,
            @BodyPart  AS    varchar(128)   ,
            @Gender    AS    varchar(128)   ,
)
AS
	BEGIN
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@ID, @Name, @Price, @CurrencyType,@Rank)

		INSERT INTO [cosmetic] (ID,  [Type], [BodyPart], Gender)
		VALUES (@ID,@Type,@BodyPart,@Gender)
	END



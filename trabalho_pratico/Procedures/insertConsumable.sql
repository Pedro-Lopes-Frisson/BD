CREATE PROC insertConsumable(
       @Name AS  varchar(128)  ,
       @Price AS  smallmoney  ,
       @CurrencyType AS   bit = 0,
       @Rank  AS  int ,
       -- Consumable
       @Effect    AS  varchar(128),
       @Duration  AS    decimal(38,3),
       @Quantity   AS   int         
)
AS
	BEGIN
	DECLARE @Item_ID AS bigint;
	BEGIN TRY
	BEGIN TRANSACTION

		select  @Item_ID = count(*) from specialItem;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@Item_ID, @Name, @Price, @CurrencyType,@Rank)

		select  @Item_ID = count(*) from consumable;
		select  @Item_ID = @Item_ID + 1;
		INSERT INTO [consumable] (SpecialItem_ID,  [Effect], [Duration], Quantity)
		VALUES (@Item_ID,@Effect,@Duration,@Quantity)
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

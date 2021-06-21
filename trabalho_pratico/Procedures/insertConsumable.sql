CREATE PROC insertConsumable(
            @ID    AS  int,
            @Name AS  varchar(128)  ,
            @Price AS  smallmoney  ,
            --@CurrencyType AS   bit,
            @Rank  AS  int 
        	-- Consumable
        	@Effect    AS  varchar(128)
        	@Duration  AS    decimal(38,3
        	@Quantity   AS   int         
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
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@ID, @Name, @Price, @CurrencyType,@Rank)

		INSERT INTO [consumable] (ID,  [Effect], [Duration], Quantity)
		VALUES (@ID,@Effect,@Duration,@Quantity)
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

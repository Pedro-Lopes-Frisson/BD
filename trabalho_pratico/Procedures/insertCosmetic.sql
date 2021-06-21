CREATE PROC insertCosmetic( @ID    AS  int,
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
	BEGIN TRANSACTION
		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@ID, @Name, @Price, @CurrencyType,@Rank)

		INSERT INTO [cosmetic] (ID,  [Type], [BodyPart], Gender)
		VALUES (@ID,@Type,@BodyPart,@Gender)
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

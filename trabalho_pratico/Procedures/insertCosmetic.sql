USE [project_dummy]
GO
/****** Object:  StoredProcedure [dbo].[insertCosmetic]    Script Date: 22/06/2021 01:47:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[insertCosmetic](
			@Item_id   as bigint,
            @Name AS  varchar(128)  ,
            @Price AS  smallmoney  ,
            @CurrencyType AS   bit = 0,
            @Rank  AS  int ,
            @Type   AS      varchar(128)   ,
            @BodyPart  AS    varchar(128)   ,
            @Gender    AS    varchar(128)   
)
AS
	BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

		INSERT INTO [specialItem] (ID, Name, Price, CurrencyType,[Rank])
		VALUES (@Item_ID, @Name, @Price, @CurrencyType,@Rank)			
		INSERT INTO [cosmetic] (SpecialItem_ID,  [Type], [BodyPart], Gender)
		VALUES (@Item_ID,@Type,@BodyPart,@Gender)
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

exec [dbo].[insertConsumable]
            @ID    = 14 ,
            @Name ='Speed Pocao'  ,
            @Price = 1234.5  ,
            --@CurrencyType AS   bit,
            @Rank  = 1,
			@CurrencyType = 0,
	-- Consumable
			@Effect    = 'Aumenta Speed',
			@Duration  = 3,
			@Quantity   = 20000

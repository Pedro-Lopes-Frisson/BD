CREATE FUNCTION dbo.GetItemType(@ItemName as VARCHAR(128))  
RETURNS VARCHAR(128)  
AS   
--Returns Every ITEM that the user as in the stash
BEGIN  

DECLARE @return_value int
exec @return_value = [dbo].[GetSiteTypeByCapacityType] 10
SELECT 'Return Value' = @return_value

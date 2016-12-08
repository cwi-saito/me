update Orders
set 
	IsExportable = 1
	, UpdateTime = GETDATE()	
Where
	OrderId IN(SELECT OrderId FROM OrderDeliveries WHERE PBOrderNo = @OrderNo)
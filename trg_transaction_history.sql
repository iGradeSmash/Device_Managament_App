ALTER TRIGGER trg_transaction_history
ON Device_Manager
AFTER INSERT, UPDATE
AS
BEGIN
SET NOCOUNT ON;

INSERT INTO Device_Management_db.dbo.TransactionHistory(
DeviceManagerId
,BorrowerId
,BorrowerName
,BorrowerDepartment
,BorrowerDescription
,DeviceId
,DeviceName
,DeviceBrand
,DeviceModel
,DeviceBarcode
,ApproverId
,ApproverName
,ApproverRole
,TransactionType
,TransactionDate
,Operation)

SELECT 
i.Id
,i.[User_Id]
,i.[Name]
,i.[Department]
,i.[Description]
,i.Device_Id
,dev.[Description]
,i.[Brand]
,i.[Model]
,i.[Barcode]
,i.[Technician_Id]
,u.[Name]
,r.[RoleName]
,i.TransactionType
,GETDATE()
,'INS'
From  inserted i
LEFT JOIN Devices dev on i.Device_Id = dev.Id
LEFT JOIN Users u on i.Technician_Id = u.Id
LEFT JOIN [Role] r on u.RoleId = r.Id
INNER JOIN i on Device_Manager.Id = i.Id
END 
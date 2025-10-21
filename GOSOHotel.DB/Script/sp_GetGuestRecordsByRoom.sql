-- =============================================
-- Get Guest Records by Room Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetGuestRecordsByRoom]
    @RoomNo NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT CustomerID, Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status
    FROM GuestRecord
    WHERE RoomNo = @RoomNo
    ORDER BY CheckIn DESC;
END
GO

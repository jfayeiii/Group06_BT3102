-- =============================================
-- Get Guest Records by Status Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetGuestRecordsByStatus]
    @Status NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT CustomerID, Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status
    FROM GuestRecord
    WHERE Status = @Status
    ORDER BY CheckIn DESC;
END
GO

-- =============================================
-- Get All Guest Records Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetAllGuestRecords]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT CustomerID, Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status
    FROM GuestRecord
    ORDER BY CheckIn DESC;
END
GO

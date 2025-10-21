-- =============================================
-- Get Guest Record by ID Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetGuestRecordById]
    @CustomerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT CustomerID, Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status
    FROM GuestRecord
    WHERE CustomerID = @CustomerID;
END
GO

-- =============================================
-- Check In Guest Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_CheckInGuest]
    @CustomerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        UPDATE GuestRecord
        SET Status = 'Staying'
        WHERE CustomerID = @CustomerID AND Status = 'Enquired';
        
        IF @@ROWCOUNT = 0
            SELECT 'Guest record not found or not in Enquired status' AS Result;
        ELSE
            SELECT 'Guest checked in successfully' AS Result;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

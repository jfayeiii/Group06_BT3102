-- =============================================
-- Check Out Guest Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_CheckOutGuest]
    @CustomerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        UPDATE GuestRecord
        SET Status = 'CheckedOut'
        WHERE CustomerID = @CustomerID AND Status = 'Staying';
        
        IF @@ROWCOUNT = 0
            SELECT 'Guest record not found or not in Staying status' AS Result;
        ELSE
            SELECT 'Guest checked out successfully' AS Result;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

-- =============================================
-- Delete Guest Record Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_DeleteGuestRecord]
    @CustomerID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        DELETE FROM GuestRecord WHERE CustomerID = @CustomerID;
        
        IF @@ROWCOUNT = 0
            SELECT 'Guest record not found' AS Result;
        ELSE
            SELECT 'Guest record deleted successfully' AS Result;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

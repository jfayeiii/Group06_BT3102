-- =============================================
-- Update Guest Record Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_UpdateGuestRecord]
    @CustomerID INT,
    @Name NVARCHAR(100),
    @Gender NVARCHAR(10),
    @ContactNo NVARCHAR(20),
    @EmailAddress NVARCHAR(100),
    @Address NVARCHAR(200),
    @RoomType NVARCHAR(50),
    @RoomNo NVARCHAR(10),
    @NoOfGuests INT,
    @CheckIn DATE,
    @CheckOut DATE,
    @Status NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Validate room availability if changing room or dates
        IF @Status IN ('Enquired', 'Staying')
        BEGIN
            IF EXISTS (
                SELECT 1 FROM GuestRecord 
                WHERE RoomNo = @RoomNo 
                AND Status IN ('Enquired', 'Staying')
                AND CustomerID != @CustomerID
                AND (
                    (CheckIn <= @CheckOut AND CheckOut >= @CheckIn)
                )
            )
            BEGIN
                RAISERROR('Room is not available for the selected dates', 16, 1);
                RETURN;
            END
        END
        
        -- Validate room exists
        IF NOT EXISTS (SELECT 1 FROM [Room] WHERE RoomNo = @RoomNo)
        BEGIN
            RAISERROR('Room number does not exist', 16, 1);
            RETURN;
        END
        
        -- Validate room capacity
        IF @NoOfGuests > (SELECT Capacity FROM [Room] WHERE RoomNo = @RoomNo)
        BEGIN
            RAISERROR('Number of guests exceeds room capacity', 16, 1);
            RETURN;
        END
        
        UPDATE GuestRecord
        SET Name = @Name,
            Gender = @Gender,
            ContactNo = @ContactNo,
            EmailAddress = @EmailAddress,
            Address = @Address,
            RoomType = @RoomType,
            RoomNo = @RoomNo,
            NoOfGuests = @NoOfGuests,
            CheckIn = @CheckIn,
            CheckOut = @CheckOut,
            Status = @Status
        WHERE CustomerID = @CustomerID;
        
        IF @@ROWCOUNT = 0
            SELECT 'Guest record not found' AS Result;
        ELSE
            SELECT 'Guest record updated successfully' AS Result;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

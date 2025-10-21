-- =============================================
-- Create Guest Record Stored Procedure
-- =============================================

CREATE PROCEDURE [dbo].[sp_CreateGuestRecord]
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
    @Status NVARCHAR(20) = 'Enquired'
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Validate room availability
        IF @Status IN ('Enquired', 'Staying')
        BEGIN
            IF EXISTS (
                SELECT 1 FROM GuestRecord 
                WHERE RoomNo = @RoomNo 
                AND Status IN ('Enquired', 'Staying')
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
        
        INSERT INTO GuestRecord (Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status)
        VALUES (@Name, @Gender, @ContactNo, @EmailAddress, @Address, @RoomType, @RoomNo, @NoOfGuests, @CheckIn, @CheckOut, @Status);
        
        SELECT SCOPE_IDENTITY() AS NewCustomerId, 'Guest record created successfully' AS Result;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

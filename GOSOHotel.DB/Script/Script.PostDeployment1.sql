/*
Post-Deployment Script Template                         
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.       
 Use SQLCMD syntax to include a file in the post-deployment script.         
 Example:      :r .\myfile.sql                              
 Use SQLCMD syntax to reference a variable in the post-deployment script.       
 Example:      :setvar TableName MyTable                            
               SELECT * FROM [$(TableName)]                 
--------------------------------------------------------------------------------------
*/

USE [$(DatabaseName)];
GO

SET NOCOUNT ON;
GO

-- Seed data: do not provide explicit values for identity columns
INSERT INTO [dbo].[Admin] ([Username], [Password])
VALUES ('admin', 'gosohotel');
GO

INSERT INTO [dbo].[Front Desk] ([Username], [Password])
VALUES ('front desk', 'frontdesk');
GO

-- Ensure Room insert targets the correct table name [dbo].[Room]
INSERT INTO [dbo].[Room] (RoomNo, NoOfBeds, RoomType, Capacity)
VALUES
    ('101', 1, 'Single', 1),
    ('201', 2, 'Double', 2),
    ('301', 2, 'Twin', 2);
GO

-- Seed a sample guest record (identity CustomerID will be generated automatically)
INSERT INTO [dbo].[GuestRecord]
    (Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status)
VALUES
    ('Juan Cruz', 'Male', '0917123456', 'juan@email.com', 'Batangas', 'Single', '101', 1, '2025-09-24', '2025-09-25', 'Staying');
GO

-- Add foreign key from GuestRecord.RoomNo to Room.RoomNo
ALTER TABLE [dbo].[GuestRecord]
ADD CONSTRAINT FK_RoomNo FOREIGN KEY (RoomNo) REFERENCES [dbo].[Room](RoomNo);
GO

SET NOCOUNT OFF;
GO

-- Constraint verification section (unchanged logic)
PRINT N'Checking existing data against newly created constraints';
GO

USE [$(DatabaseName)];
GO

CREATE TABLE [#__checkStatus] (
    id           INT            IDENTITY (1, 1) PRIMARY KEY CLUSTERED,
    [Schema]     NVARCHAR (256),
    [Table]      NVARCHAR (256),
    [Constraint] NVARCHAR (256)
);

SET NOCOUNT ON;

DECLARE tableconstraintnames CURSOR LOCAL FORWARD_ONLY
    FOR SELECT SCHEMA_NAME([schema_id]),
               OBJECT_NAME([parent_object_id]),
               [name],
               0
        FROM   [sys].[objects]
        WHERE  [parent_object_id] IN (OBJECT_ID(N'dbo.GuestRecord'))
               AND [type] IN (N'F', N'C')
                   AND [object_id] IN (SELECT [object_id]
                                       FROM   [sys].[check_constraints]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0
                                       UNION
                                       SELECT [object_id]
                                       FROM   [sys].[foreign_keys]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0);

DECLARE @schemaname AS NVARCHAR (256);
DECLARE @tablename AS NVARCHAR (256);
DECLARE @checkname AS NVARCHAR (256);
DECLARE @is_not_trusted AS INT;
DECLARE @statement AS NVARCHAR (1024);

BEGIN TRY
    OPEN tableconstraintnames;
    FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
    WHILE @@fetch_status = 0
        BEGIN
            PRINT N'Checking constraint: ' + @checkname + N' [' + @schemaname + N'].[' + @tablename + N']';
            SET @statement = N'ALTER TABLE [' + @schemaname + N'].[' + @tablename + N'] WITH ' + CASE @is_not_trusted WHEN 0 THEN N'CHECK' ELSE N'NOCHECK' END + N' CHECK CONSTRAINT [' + @checkname + N']';
            BEGIN TRY
                EXECUTE [sp_executesql] @statement;
            END TRY
            BEGIN CATCH
                INSERT  [#__checkStatus] ([Schema], [Table], [Constraint])
                VALUES                  (@schemaname, @tablename, @checkname);
            END CATCH
            FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
        END
END TRY
BEGIN CATCH
    PRINT ERROR_MESSAGE();
END CATCH

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') >= 0
    CLOSE tableconstraintnames;

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') = -1
    DEALLOCATE tableconstraintnames;

SELECT N'Constraint verification failed:' + [Schema] + N'.' + [Table] + N',' + [Constraint]
FROM   [#__checkStatus];

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occurred while verifying constraints', 16, 127);
    END

SET NOCOUNT OFF;

DROP TABLE [#__checkStatus];
GO

PRINT N'Update complete.';
GO

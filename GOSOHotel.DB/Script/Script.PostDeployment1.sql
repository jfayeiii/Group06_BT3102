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

INSERT INTO [dbo].[Admin]
(
[Id],
[Username],
[Password])
VALUES('2345','admin','gosohotel')

INSERT INTO [dbo].[Front Desk]
(
[Id],
[Username],
[Password])
VALUES('6789','front desk','frontdesk')


ALTER TABLE dbo.GuestRecord
ADD CONSTRAINT FK_RoomNo FOREIGN KEY (RoomNo) REFERENCES dbo.Room(RoomNo);


INSERT INTO Rooms (RoomNo, NoOfBeds, RoomType, Capacity)
VALUES
('101', 1, 'Single', 1),
('201', 2, 'Double', 2),
('301', 2, 'Twin', 2);


INSERT INTO GuestRecord
(Name, Gender, ContactNo, EmailAddress, Address, RoomType, RoomNo, NoOfGuests, CheckIn, CheckOut, Status)
VALUES
('Juan Cruz', 'Male', '0917123456', 'juan@email.com', 'Batangas', 'Single', '101', 1, '2025-09-24', '2025-09-25', 'Staying');





CREATE TABLE [dbo].[GuestRecord]
(
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male','Female','Other')),
    ContactNo NVARCHAR(20),
    EmailAddress NVARCHAR(100),
    Address NVARCHAR(200),
    RoomType NVARCHAR(50),
    RoomNo NVARCHAR(10),
    NoOfGuests INT NOT NULL,
    CheckIn DATE,
    CheckOut DATE,
    Status NVARCHAR(20) CHECK (Status IN ('Enquired','Staying','CheckedOut'))
);

CREATE TABLE Reservation (
    ReservationID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    RoomID INT,
    CheckInDate DATE,
    CheckOutDate DATE,
    ReservationStatus NVARCHAR(20)
);
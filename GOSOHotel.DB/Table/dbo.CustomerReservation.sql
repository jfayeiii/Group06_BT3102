CREATE TABLE dbo.CustomerReservation
(
    ReservationId          INT IDENTITY(1,1) PRIMARY KEY, 
    CustomerId             INT NULL,                     
    CustomerName           NVARCHAR(200) NULL,
    Gender                 NVARCHAR(20)  NULL,
    Nationality            NVARCHAR(100) NULL,
    IdType                 NVARCHAR(50)  NULL,
    IdNumber               NVARCHAR(100) NULL,
    Contact                NVARCHAR(50)  NULL,
    Email                  NVARCHAR(150) NULL,
    Address                NVARCHAR(300) NULL,

    RoomType               NVARCHAR(100) NULL,
    RoomNumber             NVARCHAR(50)  NULL,
    ReservationStatus      NVARCHAR(50)  NULL,
    TimeOfArrival          TIME          NULL,
    RoomGuest              NVARCHAR(200) NULL,
    CheckInDate            DATETIME      NULL,
    CheckOutDate           DATETIME      NULL,
    TotalPricePerNight     DECIMAL(18,2) NULL,
    AmountToPay            DECIMAL(18,2) NULL,
    PaymentStatus          NVARCHAR(50)  NULL,

    -- Payment tracking
    AmountPaid             DECIMAL(18,2) NULL DEFAULT 0,
    ChangeDue              DECIMAL(18,2) NULL DEFAULT 0
);
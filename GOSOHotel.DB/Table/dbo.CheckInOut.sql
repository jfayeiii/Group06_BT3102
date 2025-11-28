CREATE TABLE dbo.CheckInOut
(
    Id                   INT IDENTITY(1,1) PRIMARY KEY,
    ReservationId        INT NULL,
    CustomerId           INT NULL,
    RoomId               INT NULL,

    CustomerName         NVARCHAR(200) NULL,
    RoomType             NVARCHAR(100) NULL,
    RoomNumber           NVARCHAR(50)  NULL,
    RoomGuest            NVARCHAR(200) NULL,
    NumberOfGuests       INT           NULL,

    CheckInDate          DATETIME      NULL,
    CheckOutDate         DATETIME      NULL,
    TimeOfArrival        TIME          NULL,

    PaymentStatus        NVARCHAR(50)  NULL,
    TotalPricePerNight   DECIMAL(18,2) NULL,
    AmountToPay          DECIMAL(18,2) NULL,
    AmountPaid           DECIMAL(18,2) NULL,
    AmountPaidBefore     DECIMAL(18,2) NULL,

    Status               NVARCHAR(50)  NULL,
    CreatedDate          DATETIME      NOT NULL DEFAULT (GETDATE()),
    ModifiedDate         DATETIME      NULL
);
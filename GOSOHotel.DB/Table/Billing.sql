CREATE TABLE dbo.Billing
(
    PaymentId           INT IDENTITY(1,1) PRIMARY KEY,
    ReservationId       INT NULL,
    CustomerId          INT NULL,
    GuestName           NVARCHAR(200) NULL,
    Gender              NVARCHAR(20)  NULL,
    RoomType            NVARCHAR(100) NULL,
    RoomNumber          NVARCHAR(50)  NULL,
    NumberOfGuests      INT           NULL,

    CheckInDate         DATETIME      NULL,
    CheckOutDate        DATETIME      NULL,

    RoomRate            DECIMAL(18,2) NOT NULL DEFAULT (0.00),
    LateCheckoutFee     DECIMAL(18,2) NOT NULL DEFAULT (0.00),
    DamageFee           DECIMAL(18,2) NOT NULL DEFAULT (0.00),

    AmountPaidBefore    DECIMAL(18,2) NOT NULL DEFAULT (0.00),
    AmountPaidNow       DECIMAL(18,2) NOT NULL DEFAULT (0.00),
    TotalAmount         DECIMAL(18,2) NOT NULL DEFAULT (0.00),

    PaymentDate         DATETIME      NULL,
    PaymentMethod       NVARCHAR(50)  NULL,
    PaymentStatus       NVARCHAR(50)  NULL,

    CreatedDate         DATETIME      NOT NULL DEFAULT (GETDATE()),
    ModifiedDate        DATETIME      NULL
);
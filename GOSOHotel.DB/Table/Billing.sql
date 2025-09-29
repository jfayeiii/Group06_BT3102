CREATE TABLE Billing (
    BillingID INT PRIMARY KEY IDENTITY(1,1),
    ReservationID INT,
    Amount DECIMAL(10,2),
    PaymentStatus NVARCHAR(20),
    PaymentDate DATE
);
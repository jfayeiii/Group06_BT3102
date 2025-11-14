CREATE TABLE [dbo].[Room]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    [RoomNo] INT NOT NULL UNIQUE,
    [RoomType] NVARCHAR(50) NOT NULL,
    [PricePerNight] DECIMAL(10, 2) NOT NULL,
    [Capacity] INT NOT NULL,
    [Status] NVARCHAR(50) NOT NULL DEFAULT 'Available',
    [NoOfBeds] INT NOT NULL,
    [CreatedDate] DATETIME NOT NULL,
    [ModifiedDate] DATETIME NULL
);

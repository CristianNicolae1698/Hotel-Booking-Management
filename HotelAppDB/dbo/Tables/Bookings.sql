CREATE TABLE [dbo].[Bookings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [TotalCost] MONEY NOT NULL, 
    [CheckedIn] BIT NOT NULL DEFAULT 0, 
    [GuestId] INT NOT NULL, 
    [RoomId] INT NOT NULL, 
    CONSTRAINT [FK_Bookings_Guests] FOREIGN KEY (GuestId) REFERENCES Guests(Id), 
    CONSTRAINT [FK_Bookings_Rooms] FOREIGN KEY ([RoomId]) REFERENCES Rooms(Id)
)

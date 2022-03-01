CREATE TABLE Flat (
	Number INT,
	HashId INT NOT NULL,
	Country VARCHAR(20),
	City VARCHAR(30),
	Street VARCHAR(30),
	BuildingNumber INT,
	FlatOfFloor INT,
	Price INT  NOT NULL,
	Area FLOAT NOT NULL,
	FirstDate DATE NOT NULL DEFAULT GETDATE(),
	Duplicates INT NOT NULL DEFAULT 0,
	Website VARCHAR(200) NOT NULL)







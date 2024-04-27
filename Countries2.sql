Create database Countries2;

CREATE TABLE Users(
	UserID INT IDENTITY PRIMARY KEY,
	username VARCHAR(255),
	date DATETIME,
	hash VARCHAR(255)
)

CREATE TABLE CreatedUsers(
	CreatedUsersID INT IDENTITY PRIMARY KEY,
	username VARCHAR(255)
)

CREATE TABLE Towns (
    TownsID INT PRIMARY KEY,
    Town_Name VARCHAR(100),
     CountryID INT
    
);

ALTER TABLE Towns
ADD CONSTRAINT FK_CountryID FOREIGN KEY (CountryID) REFERENCES Countries(CountriesID);

CREATE TABLE Countries (
    CountriesID INT PRIMARY KEY,
    CountryName VARCHAR(100),
    Currency VARCHAR(50),
    Capital INT FOREIGN KEY REFERENCES Towns(TownsID)
);

CREATE TABLE Excursions (
    ID INT PRIMARY KEY,
    Excursion_Name VARCHAR(100),
    Town INT FOREIGN KEY REFERENCES Towns(TownsID)
);

INSERT INTO Countries (CountriesID, CountryName, Currency) VALUES
    (1, 'Bulgaria', 'Bulgarian Lev'),
    (2, 'Greece', 'Euro' ),
    (3, 'Italy', 'Euro');

UPDATE Countries 
SET Capital = 1 
WHERE CountriesID=1;

UPDATE Countries 
SET Capital = 2 
WHERE CountriesID=2;

UPDATE Countries 
SET Capital = 3
WHERE CountriesID=3;

INSERT INTO Towns (TownsID, Town_Name, CountryID) VALUES
    (1, 'Sofia', 1),
    (2, 'Athens', 2),
    (3, 'Rome', 3);

INSERT INTO Excursions (ID, Excursion_Name, Town) VALUES
    (1, 'NDK', 1),
    (2, 'Acropolis of Athens', 2),
    (3, 'Colosseum', 3);
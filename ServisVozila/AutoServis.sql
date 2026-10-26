CREATE TABLE Klijenti (
    KlijentID INT identity(1,1) PRIMARY KEY,
    Ime VARCHAR(50) NOT NULL,
    Prezime VARCHAR(50) NOT NULL,
    Telefon VARCHAR(20),
    Email VARCHAR(100) unique,
    Adresa VARCHAR(100)
);

CREATE TABLE Vozila (
    VoziloID INT identity(1,1) PRIMARY KEY,
    KlijentID INT NOT NULL,
    Marka VARCHAR(50) NOT NULL,
    Model VARCHAR(50) NOT NULL,
    Godiste INT,
    Registracija VARCHAR(20) NOT NULL UNIQUE,
    FOREIGN KEY (KlijentID)
        REFERENCES Klijenti(KlijentID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE Servisi (
    ServisID INT identity(1,1) PRIMARY KEY,
    VoziloID INT NOT NULL,
    DatumServisa DATE NOT NULL,
    OpisKvara VARCHAR(255),
    OpisUsluge VARCHAR(255),
    Cena DECIMAL(10,2) NOT NULL,
    Kilometraza INT,
    FOREIGN KEY (VoziloID)
        REFERENCES Vozila(VoziloID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
ALTER TABLE Klijenti
ADD CONSTRAINT JUNIK
UNIQUE (Email);
SELECT
    Vozila.VoziloID,
    Klijenti.KlijentID,
    Klijenti.Ime,
    Vozila.Marka,
    Vozila.Model,
    Vozila.Godiste,
    Vozila.Registracija
FROM Klijenti
INNER JOIN Vozila
    ON Klijenti.KlijentID = Vozila.KlijentID
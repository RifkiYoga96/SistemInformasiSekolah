﻿CREATE TABLE Kelas(KelasId INT PRIMARY KEY IDENTITY(1,1), NamaKelas VARCHAR(50) NOT NULL DEFAULT(''), Tingkat INT);
ALTER TABLE Kelas
ADD JurusanId INT NOT NULL DEFAULT(0);
ALTER TABLE Kelas
ADD	Flag VARCHAR(3) NOT NULL DEFAULT('');

SELECT * FROM Kelas;

DELETE FROM Kelas;
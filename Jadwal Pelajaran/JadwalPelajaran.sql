﻿CREATE TABLE JadwalPelajaran (
	JadwalPelajaranId INT PRIMARY KEY IDENTITY(1,1),
	KelasId INT NOT NULL DEFAULT(0),

	Hari  VARCHAR(6) NOT NULL DEFAULT(''),
	JenisJadwal VARCHAR(6) NOT NULL DEFAULT(''),
	JamMulai VARCHAR(6) NOT NULL DEFAULT(''),
	JamSelesai VARCHAR(6) NOT NULL DEFAULT(''),

	MapelId INT NOT NULL DEFAULT(0),
	GuruId INT NOT NULL DEFAULT(0),
	Keterangan VARCHAR(50) NOT NULL DEFAULT(''),
);
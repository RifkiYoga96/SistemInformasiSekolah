CREATE TABLE Persensi
			(
				PersensiId INT PRIMARY KEY IDENTITY(1,1) ,Tgl DATE,Jam VARCHAR(5),
				KelasId INT,MapelId INT,GuruId INT
				FOREIGN KEY (KelasId) REFERENCES Kelas(KelasId),
				FOREIGN KEY (MapelId) REFERENCES Mapel(MapelId),
				FOREIGN KEY (GuruId) REFERENCES Guru(GuruId)
			);

			DROP TABLE Persensi;
			select * from siswa

			DELETE FROM KelasSiswaDetail
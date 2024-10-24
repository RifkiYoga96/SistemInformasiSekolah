CREATE TABLE KelasSiswa(KelasId INT,
						TahunAjaran VARCHAR(20), WaliKelasId INT
						FOREIGN KEY (KelasId) REFERENCES Kelas(KelasId),
						FOREIGN KEY (WaliKelasId) REFERENCES Guru(GuruId)
						);
						DROP TABLE KelasSiswa;
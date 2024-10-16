CREATE TABLE KelasSiswaDetail(
					KelasId INT,SiswaId INT
					FOREIGN KEY (KelasId) REFERENCES Kelas(KelasId)
							);
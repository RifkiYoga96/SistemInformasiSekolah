CREATE TABLE PersensiDetail(
			PersensiId INT,NoUrut INT, SiswaId INT,
			StatusPersensi VARCHAR(5), Keterangan VARCHAR (2)
			);

DROP TABLE PersensiDetail;


SELECT 
                    gm.GuruId, gm.MapelId,m.NamaMapel
                FROM 
                    GuruMapel gm
                    LEFT JOIN Mapel m ON gm.MapelId = m.MapelId
                WHERE
                    GuruId = 8
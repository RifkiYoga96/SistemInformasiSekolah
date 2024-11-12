CREATE TABLE PersensiDetail(
			PersensiId INT,NoUrut INT, SiswaId INT,
			StatusPersensi VARCHAR(5), Keterangan VARCHAR (20)
			);

DROP TABLE PersensiDetail;

Delete from persensi;


SELECT 
                    gm.GuruId, gm.MapelId,m.NamaMapel
                FROM 
                    GuruMapel gm
                    LEFT JOIN Mapel m ON gm.MapelId = m.MapelId
                WHERE
                    GuruId = 8
﻿﻿CREATE TABLE GuruMapel(
	GuruId INT NOT NULL DEFAULT(0),
	MapelId INT NOT NULL DEFAULT(0),
	CONSTRAINT PK_GuruMapel PRIMARY KEY CLUSTERED(MapelId, GuruId)
)
GO

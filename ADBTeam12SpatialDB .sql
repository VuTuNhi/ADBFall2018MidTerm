create database ADBTeam12SpatialDdB
go
CREATE TABLE QLiDatTr(
	Mamd varchar(5)  not null,
	Mau nvarchar(50) not null,
	YNghia nvarchar(500),
	Matdonuoc float not null,
	Matdodoanhthu float,
	ViTri geometry,
	PRIMARY KEY (Mamd)
);
go
INSERT INTO QLiDatTr(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M7', 'Xám', N'Trồng lúa', 75000, 250.6, geometry::STGeomFromText('MULTIPOLYGON (((0 -2,3 -1,3 3,1 3,0 2,0 -2),(5 0,7 -2,9 -2,9 3,7 3,8 1,5 0)))', 0));
go
INSERT INTO QLiDatTr(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M8', 'Nâu', N'Trồng cây ăn quả', 45000, 350.4, geometry::STGeomFromText('MULTIPOLYGON (((0 -2,5 -2,5 0,3 0,3 -1,0 -2)))', 0));
go
INSERT INTO QLiDatTr(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M9', 'Xám', N'Trồng rau', 35000, 450.5, geometry::STGeomFromText('MULTIPOLYGON (((3 0,5 0,7 1,7 3,5 4,3 3,3 0)))', 0));
go

--cau a 
select YNghia, Matdonuoc
from QLiDatTr
go
--cau b loai dat co dien tich be nhat

DECLARE @dientichbe float;
SELECT  @dientichbe=MIN(ViTri.STArea())
FROM QLiDatTr

SELECT *, ViTri.STArea() as a
FROM QLiDatTr
WHERE ViTri.STArea()= @dientichbe;
go
--

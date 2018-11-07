/*Câu 2 nhóm 12 đề 1*/
create database ADBTeam12SpatialDB
go
CREATE TABLE Qldattrong(
	Mamd varchar(5)  not null,
	Mau nvarchar(50) not null,
	YNghia nvarchar(500),
	Matdonuoc float not null,
	Matdodoanhthu float,
	ViTri geometry,
	PRIMARY KEY (Mamd)
);
go
INSERT INTO Qldattrong(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M7', 'Xám', N'Trồng lúa', 75000, 250.6, geometry::STGeomFromText('MULTIPOLYGON (((0 -2,3 -1,3 3,1 3,0 2,0 -2)),((5 0,7 -2,9 -2,9 3,7 3,8 1,5 0)))', 0));
go
INSERT INTO Qldattrong(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M8', 'Nâu', N'Trồng cây ăn quả', 45000, 350.4, geometry::STGeomFromText('MULTIPOLYGON (((0 -2,5 -2,5 0,3 0,3 -1,0 -2)))', 0));
go
INSERT INTO Qldattrong(Mamd, Mau, YNghia, Matdonuoc, Matdodoanhthu, ViTri) VALUES('M9', 'Xám', N'Trồng rau', 35000, 450.5, geometry::STGeomFromText('MULTIPOLYGON (((3 0,5 0,7 1,7 3,5 4,3 3,3 0)))', 0));
go


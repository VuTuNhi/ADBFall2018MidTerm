SELECT Ma, YNghia, ViTri.STArea() as DienTich,
	ViTri.STArea() * LuongNuoc as LuongNuocTuoiTieu
FROM dbo.qldatdai;




DECLARE @kenh geometry = geometry::STGeomFromText('POLYGON ((1 3,4 -2,  0 0,1 3))', 0);
SELECT Ma, ViTri.STIntersection(@kenh) as DienTichMat
FROM qldatdai;
SELECT * FROM qldatdai;
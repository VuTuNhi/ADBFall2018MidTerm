
/*Câu 2 nhóm 12 đề 1*/
use ADBTeam12SpatialDB
go
--cau 2a  Tính Lượng nước tưới tiêu cần thiết
select Qldattrong.Mamd as N'Mã Đất', Qldattrong.YNghia as N'ý nghĩa', (Qldattrong.vitri.STArea())*Qldattrong.Matdonuoc as N'Lượng nước tưới tiêu(/m3)' from Qldattrong
--cau 2b  loại đất có diện tích bé nhất
declare @min float
select @min = min(Qldattrong.vitri.STArea()) from Qldattrong

select Mamd as N'Mã đất' ,mau as N'Màu', YNghia as N'Ý Nghĩa', Matdonuoc as N'Mật độ nước',Matdodoanhthu as N'Mật độ doanh thu',ViTri as N'Vị trí'
 from Qldattrong where Qldattrong.vitri.STArea() =@min
/*cau 2c Giả sử ta cần đào 1 kênh nước để dẫn nước tưới tiêu. Kênh nước này được giới
hạn bởi 2 đường thẳng song song với Oy và lần lượt qua điểm A(2, 4) và B(4,-2). Hãy cho biết diện tích bị mất sau ứng với mỗi loại sau khi xây dựng
kênh nước này.*/
DECLARE @kenh geometry = geometry::STGeomFromText('POLYGON ((2 1, 4 1, 4 -5, 2 -5, 2 1))', 0);
select Qldattrong.MaMD as N'Mã Đất', Qldattrong.vitri.STIntersection(@kenh).STArea()*10000 as N'Diện tích mất' from Qldattrong
Imports DTO
Public Class DAL_VeChuyenBay
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub

    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM VECHUYENBAY"
        Return db.Execute(sql)
    End Function

    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT V.MAVE[Mã vé], K.TENKHACHHANG[Tên khách hàng], 
                K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], 
                V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], V.NGAYHUY[Ngày hủy], 
                V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K 
                ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE"
        Return db.Execute(sql)
    End Function
    Public Function AddVeChuyenBay(ByVal ve As DTO_VeChuyenBay) As Boolean
        Try
            Dim sql As String
            Dim MaVe As String = TaoMaVe()
            sql = String.Format("INSERT INTO VECHUYENBAY(MAVE, MAKHACHHANG, 
                    MACHUYENBAY, MAHANGVE, GIATIEN,NGAYHUY,MANHANVIEN,  NGAYGIOGD, LOAIVE) 
                    VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}',N'{8}')", MaVe, ve.MaKhachHang1, ve.MaChuyenBay1, ve.MaHangVe1, ve.GiaTien1, ve.NgayHuy1, ve.MaNhanVien1, ve.NgayGioGD1, ve.LoaiVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal ve As DTO_VeChuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE VECHUYENBAY SET MAKHACHHANG='{0}', MACHUYENBAY='{1}', MAHANGVE='{2}', MANHANVIEN='{3}', GIATIEN='{4}', NGAYGIOGD='{5}', LOAIVE=N'{6}' 
WHERE MAVE='{7}')", ve.MaKhachHang1, ve.MaChuyenBay1, ve.MaHangVe1, ve.MaNhanVien1, ve.GiaTien1, ve.NgayGioGD1, ve.LoaiVe1, ve.MaVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal mave As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM VECHUYENBAY WHERE MAVE='{0}'", mave)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function SortTheoMaVe() As DataTable
        Dim sql As String
        sql = "SELECT * FROM VECHUYENBAY ORDER BY MAVE DESC"
        Return db.Execute(sql)
    End Function
    Public Function TaoMaVe() As String
        Dim dt As New DataTable
        dt = SortTheoMaVe()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "VE1"
        End If
        Return String.Format("VE{0}", count)
    End Function
End Class

Imports DTO
Public Class DAL_KhachHang
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM KHACHHANG"
        Return db.Execute(sql)
    End Function
    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT MAKHACHHANG, TENKHACHHANG, 
                CMND, SDT FROM KHACHHANG"
        Return db.Execute(sql)
    End Function
    Public Function AddKhachHang(ByVal kh As DTO_KhachHang) As Boolean
        Try
            Dim sql As String
            Dim makh As String = TaoMaKhachHang()
            sql = String.Format("INSERT INTO KHACHHANG(MAKHACHHANG, TENKHACHHANG, CMND, SDT) 
        VALUES('{0}', N'{1}', '{2}', '{3}')", makh, kh.TenKhachHang1, kh.CMND1, kh.SDT1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal kh As DTO_KhachHang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE KHACHHANG SET TENKHACHHANG=N'{0}', CMND='{1}', SDT='{2}' 
            WHERE MAKHACHHANG='{3}'", kh.TenKhachHang1, kh.CMND1, kh.SDT1, kh.MaKhachHang1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaKH As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM KHACHHANG WHERE MAKHACHHANG='{0}'", MaKH)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayCMND(ByVal CMND As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM KHACHHANG WHERE CMND='{0}'", CMND)
        Return db.Execute(sql)
    End Function
    Public Function SortTheoMaKH() As DataTable
        Dim sql As String
        sql = "SELECT * FROM KHACHHANG ORDER BY MAKHACHHANG DESC"
        Return db.Execute(sql)
    End Function

    Public Function TaoMaKhachHang() As String
        Dim dt As New DataTable
        dt = SortTheoMaKH()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "KH1"
        End If
        Return String.Format("KH{0}", count)
    End Function
    Public Function TimKiemTheoMaKhachHang(ByVal MaKhachHang As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT MAKHACHHANG, TENKHACHHANG, 
                CMND, SDT FROM KHACHHANG 
                WHERE MAKHACHHANG LIKE('%{0}%')", MaKhachHang)
        Return db.Execute(sql)
    End Function

End Class

Imports DTO
Public Class DAL_CTDoanhThuThang
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM CTDOANHTHUTHANG"
        Return db.Execute(sql)
    End Function

    Public Function AddCTDoanhThuThang(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO CTDOANHTHUTHANG(THANG, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", ctdt.Thang1, ctdt.MaChuyenBay1, ctdt.SoVeBan1, ctdt.DoanhThu1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE CTDOANHTHUTHANG SET SOVEBANDUOC='{0}', DOANHTHU='{1}' WHERE THANG='{2}' MACHUYENBAY='{3}')", ctdt.SoVeBan1, ctdt.DoanhThu1, ctdt.Thang1, ctdt.MaChuyenBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND MACHUYENBAY='{1}'", ctdt.Thang1, ctdt.MaChuyenBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayNamThang(ByVal Thang As String, ByVal Nam As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT* FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", Thang, Nam)
        Return db.Execute(sql)
    End Function

End Class

Imports DTO
Public Class DAL_DoanhThuThang
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub

    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM DOANHTHUTHANG"
        Return db.Execute(sql)
    End Function

    Public Function AddCTDoanhThuThang(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dtt.Thang1, dtt.Nam1, dtt.SoChuyenBay1, dtt.DoanhThu1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE DOANHTHUTHANG SET SOCHUYENBAY='{0}', DOANHTHU='{1}' WHERE THANG='{2}' AND NAM='{3}')", dtt.SoChuyenBay1, dtt.DoanhThu1, dtt.Thang1, dtt.Nam1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM DOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", dtt.Thang1, dtt.Nam1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayNam(ByVal Nam As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT* FROM DOANHTHUTHANG WHERE NAM='{0}'", Nam)
        Return db.Execute(sql)
    End Function
End Class

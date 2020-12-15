
Imports DTO
Public Class DAL_DonGia
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM DONGIA"
        Return db.Execute(sql)
    End Function
    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT D.MATUYENBAY, H.TENHANGVE, DONGIA FROM DONGIA D,HANGVE H WHERE H.MAHANGVE = D.MAHANGVE "
        Return db.Execute(sql)
    End Function
    Public Function AddDonGia(ByVal dg As DTO_DonGia) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO DONGIA(MATUYENBAY, MAHANGVE, DONGIA) VALUES('{0}', '{1}', '{2}')", dg.MaTuyenBay1, dg.MaHangVe1, dg.DonGia1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function UpDate(ByVal dg As DTO_DonGia) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE DONGIA SET DONGIA='{0}' 
                    WHERE MATUYENBAY='{1}' AND MAHANGVE='{2}'", dg.DonGia1, dg.MaTuyenBay1, dg.MaHangVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal dg As DTO_DonGia) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM DONGIA WHERE MAHANGVE='{0}' AND MATUYENBAY='{1}'", dg.MaHangVe1, dg.MaTuyenBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function TimKiemTheoMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT D.MATUYENBAY, H.TENHANGVE, DONGIA FROM DONGIA D,HANGVE H WHERE H.MAHANGVE = D.MAHANGVE AND MATUYENBAY LIKE('%{0}%')", MaTuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function TimKiemTheoMaTuyenBayVaMaHangVe(ByVal MaTuyenBay As String, ByVal MaHangVe As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM DONGIA WHERE MATUYENBAY='{0}' AND MAHANGVE='{1}'", MaTuyenBay, MaHangVe)
        Return db.Execute(sql)
    End Function
End Class

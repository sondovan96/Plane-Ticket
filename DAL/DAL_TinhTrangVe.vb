Imports DTO
Public Class DAL_TinhTrangVe
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM TINHTRANGVE"
        Return db.Execute(sql)
    End Function
    Public Function HienThiTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT H.TENHANGVE, T.TONGSOGHE, T.SOGHETRONG
                FROM TINHTRANGVE T INNER JOIN HANGVE H ON T.MAHANGVE=H.MAHANGVE WHERE T.MACHUYENBAY='{0}'", MaChuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function AddTinhTrangVe(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO TINHTRANGVE(MACHUYENBAY, MAHANGVE, TONGSOGHE, SOGHETRONG) 
VALUES('{0}', '{1}', '{2}', '{3}')", ttv.MaChuyenBay1, ttv.MaHangVe1, ttv.TongSoGhe1, ttv.TongSoGhe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE TINHTRANGVE SET SOGHETRONG={0} ,TONGSOGHE={1} WHERE MACHUYENBAY='{2}' AND MAHANGVE='{3}'", ttv.TongSoGhe1, ttv.TongSoGhe1, ttv.MaChuyenBay1, ttv.MaHangVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM TINHTRANGVE WHERE MACHUYENBAY='{0}' AND MAHANGVE='{1}'", ttv.MaChuyenBay1, ttv.MaHangVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayTTVTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT* FROM TINHTRANGVE T INNER JOIN HANGVE H 
                ON T.MAHANGVE=H.MAHANGVE WHERE T.MACHUYENBAY='{0}'", MaChuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function LayGheTrongTheoMaChuyenBayVaMaHangVe(ByVal MaChuyenBay As String, ByVal MaHangVe As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT SOGHETRONG FROM TINHTRANGVE WHERE MACHUYENBAY='{0}' 
                AND MAHANGVE='{1}'", MaChuyenBay, MaHangVe)
        Return db.Execute(sql)
    End Function

End Class

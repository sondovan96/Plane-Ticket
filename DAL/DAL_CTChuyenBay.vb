Imports DTO
Public Class DAL_CTChuyenBay
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM CTCHUYENBAY"
        Return db.Execute(sql)
    End Function
    Public Function HienThiTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT S.TENSANBAY, 
                C.THOIGIANDUNG,C.GHICHU FROM CTCHUYENBAY C 
                INNER JOIN SANBAY S ON C.MASANBAYTG=S.MASANBAY WHERE C.MACHUYENBAY='{0}'", MaChuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function AddCTChuyenBay(ByVal ct As DTO_CTChuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO CTCHUYENBAY(MACHUYENBAY, MASANBAYTG, THOIGIANDUNG, GHICHU) 
VALUES('{0}', '{1}', '{2}', N'{3}')", ct.MaChuyenBay1, ct.MaSanBayTG1, ct.TGDung1, ct.GhiChu1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Update(ByVal ct As DTO_CTChuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE CTCHUYENBAY SET THOIGIANDUNG='{0}', GHICHU=N'{1}' 
WHERE MACHUYENBAY='{2}' AND MASANBAYTG='{3}'", ct.TGDung1, ct.GhiChu1, ct.MaChuyenBay1, ct.MaSanBayTG1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal ct As DTO_CTChuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM CTCHUYENBAY WHERE MACHUYENBAY='{0}' AND MASANBAYTG='{1}'", ct.MaChuyenBay1, ct.MaSanBayTG1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LaySBTGTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT* FROM CTCHUYENBAY WHERE MACHUYENBAY='{0}'", MaChuyenBay)
        Return db.Execute(sql)
    End Function
End Class

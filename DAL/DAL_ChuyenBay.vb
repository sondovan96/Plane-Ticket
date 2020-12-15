Imports DTO
Public Class DAL_ChuyenBay
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub

    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM CHUYENBAY"
        Return db.Execute(sql)
    End Function
    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT MACHUYENBAY, MATUYENBAY, MAMAYBAY, THOIGIANKHOIHANH,  THOIGIANBAY FROM CHUYENBAY"
        Return db.Execute(sql)
    End Function
    Public Function SortTheoMaChuyenBay()
        Dim sql As String
        sql = "SELECT* FROM CHUYENBAY ORDER BY MACHUYENBAY DESC"
        Return db.Execute(sql)
    End Function
    Public Function AddChuyenBay(ByVal cb As DTO_ChuyenBay) As Boolean
        Try
            Dim sql As String
            Dim MaChuyenbay As String = TaoMaChuyenBay()
            sql = String.Format("INSERT INTO CHUYENBAY(MACHUYENBAY, MATUYENBAY, 
                    MAMAYBAY, THOIGIANKHOIHANH, THOIGIANBAY) 
                    VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", MaChuyenbay, cb.MaTuyenBay1, cb.MaMayBay1, cb.TGKhoiHanh1, cb.TGBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal cb As DTO_ChuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE CHUYENBAY SET MATUYENBAY='{0}', MAMAYBAY='{1}', THOIGIANKHOIHANH='{2}', THOIGIANBAY='{3}' 
WHERE MACHUYENBAY='{4}'", cb.MaTuyenBay1, cb.MaMayBay1, cb.TGKhoiHanh1, cb.TGBay1, cb.MaChuyenBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaChuyenBay As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM CHUYENBAY WHERE MACHUYENBAY='{0}'", MaChuyenBay)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayChuyenBayTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT C.MACHUYENBAY, T.MATUYENBAY, C.MAMAYBAY, 
                C.THOIGIANKHOIHANH, C.THOIGIANBAY, S1.TENSANBAY[TENSANBAYDI], S2.TENSANBAY[TENSANBAYDEN] 
                From CHUYENBAY C INNER Join TUYENBAY T 
                ON C.MATUYENBAY=T.MATUYENBAY INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY 
                INNER Join SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MACHUYENBAY='{0}'", MaChuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function GetTGKhoiHanhOfMaChuyenBay(ByVal MaCHuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT THOIGIANKHOIHANH FROM CHUYENBAY WHERE MACHUYENBAY='{0}'", MaCHuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function TaoMaChuyenBay() As String
        Dim dt As New DataTable
        dt = SortTheoMaChuyenBay()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "CB1"
        End If
        Return String.Format("CB{0}", count)
    End Function
    Public Function TimKiemTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT MACHUYENBAY, MATUYENBAY, 
                MAMAYBAY, THOIGIANKHOIHANH, 
                THOIGIANBAY FROM CHUYENBAY WHERE MACHUYENBAY LIKE('%{0}%')", MaChuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function TraCuu(ByVal MaSanBayDi As String, ByVal MaSanBayDen As String, ByVal TGKhoiHanhTu As DateTime, ByVal TGKhoiHanhDen As DateTime)
        Dim sql As String
        sql = String.Format("SELECT C.MACHUYENBAY[Mã chuyến bay], 
                C.THOIGIANKHOIHANH[Thời gian KH], C.THOIGIANBAY[Thời gian bay] 
                From CHUYENBAY C INNER Join TUYENBAY T 
                ON C.MATUYENBAY=T.MATUYENBAY WHERE T.MASANBAYDI = '{0}' 
                AND T.MASANBAYDEN ='{1}' AND C.THOIGIANKHOIHANH BETWEEN('{2}') AND ('{3}') ", MaSanBayDi, MaSanBayDen, TGKhoiHanhTu, TGKhoiHanhDen)
        Return db.Execute(sql)
    End Function
End Class

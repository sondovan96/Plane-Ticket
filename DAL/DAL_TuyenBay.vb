Imports DTO
Public Class DAL_TuyenBay
    Dim db As DBConnect

    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM TUYENBAY"
        Return db.Execute(sql)
    End Function
    Public Function layDSTuyenBay() As DataTable
        Dim sql As String
        sql = "SELECT T.MATUYENBAY, S1.TENSANBAY,  
                S2.TENSANBAY FROM TUYENBAY T  
                INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY  
                INNER JOIN SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY"
        Return db.Execute(sql)
    End Function
    Public Function AddTuyenBay(ByVal tb As DTO_TuyenBay) As Boolean
        Try
            Dim sql As String
            Dim MaTuyenBay As String = TaoMaTuyenBay()
            sql = String.Format("INSERT INTO TUYENBAY(MATUYENBAY, MASANBAYDI," +
                    " MASANBAYDEN) VALUES('{0}', '{1}', '{2}')", MaTuyenBay, tb.MaSanBayDi1, tb.MaSanBayDen1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal tb As DTO_TuyenBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE TUYENBAY SET MASANBAYDI='{0}', MASANBAYDEN='{1}' WHERE MATUYENBAY='{2}'", tb.MaSanBayDi1, tb.MaSanBayDen1, tb.MaTuyenBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaTuyenBay As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM TUYENBAY WHERE MATUYENBAY='{0}'", MaTuyenBay)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function TimKiemTheoMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT T.MATUYENBAY[Mã tuyến bay], S1.TENSANBAY[Tên sân bay đi], 
                S2.TENSANBAY[Tên sân bay đến] FROM TUYENBAY T 
                INNER Join SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY 
                INNER Join SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MATUYENBAY Like('%{0}%')", MaTuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function SelectOfMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT T.MATUYENBAY, S1.MASANBAY[MASANBAYDI], S1.TENSANBAY[TENSANBAYDI], 
                S2.MASANBAY[MASANBAYDEN], S2.TENSANBAY[TENSANBAYDEN] FROM TUYENBAY T 
                INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY 
                INNER Join SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MATUYENBAY ='{0}'", MaTuyenBay)
        Return db.Execute(sql)
    End Function
    Public Function SelectOfMaSanBay(ByVal MaSanBayDi As String, ByVal MaSanBayDen As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM TUYENBAY WHERE MASANBAYDI ='{0}' AND MASANBAYDEN='{1}'", MaSanBayDi, MaSanBayDen)
        Return db.Execute(sql)
    End Function
    Public Function SortTheoMaTuyenBay() As DataTable
        Dim sql As String
        sql = "SELECT * FROM TUYENBAY ORDER BY MATUYENBAY DESC"
        Return db.Execute(sql)
    End Function
    Public Function TaoMaTuyenBay() As String
        Dim dt As New DataTable
        dt = SortTheoMaTuyenBay()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "TB1"
        End If
        Return String.Format("TB{0}", count)
    End Function
End Class

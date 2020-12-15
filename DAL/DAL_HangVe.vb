Imports DTO
Public Class DAL_HangVe
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function SelectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM HANGVE"
        Return db.Execute(sql)
    End Function

    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT MAHANGVE, TENHANGVE FROM HANGVE"
        Return db.Execute(sql)
    End Function
    Public Function Add(ByVal hv As DTO_HangVe) As Boolean
        Try
            Dim sql As String
            Dim mahangve As String = TaoMaHangVe()
            sql = String.Format("INSERT INTO HANGVE(MAHANGVE, TENHANGVE) VALUES('{0}', N'{1}')", mahangve, hv.TenHangVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal hv As DTO_HangVe) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE HANGVE SET TENHANGVE=N'{0}' WHERE MAHANGVE='{1}'", hv.TenHangVe1, hv.MaHangVe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaHangVe As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM HANGVE WHERE MAHANGVE='{0}'", MaHangVe)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function SortTheoMaHangVe() As DataTable
        Dim sql As String
        sql = "SELECT * FROM HANGVE ORDER BY MAHANGVE DESC"
        Return db.Execute(sql)
    End Function
    Public Function TimKiemTheoMaHangVe(ByVal MaHangVe As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT MAHANGVE, TENHANGVE FROM HANGVE 
                WHERE MAHANGVE LIKE('%{0}%')", MaHangVe)
        Return db.Execute(sql)
    End Function
    Public Function KiemTra(ByVal TenHangVe As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM HANGVE WHERE TENHANGVE =N'{0}'", TenHangVe)
        Return db.Execute(sql)
    End Function
    Public Function TaoMaHangVe() As String
        Dim dt As New DataTable
        dt = SortTheoMaHangVe()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "HV1"
        End If
        Return String.Format("HV{0}", count)
    End Function
End Class

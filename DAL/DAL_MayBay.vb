Imports DTO
Public Class DAL_MayBay
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM MAYBAY"
        Return db.Execute(sql)
    End Function

    Public Function AddMayBay(ByVal mb As DTO_MAYBAY) As Boolean
        Try
            Dim sql As String
            Dim mamb As String
            mamb = TaoMaMayBay()
            sql = String.Format("INSERT INTO MAYBAY(MAMAYBAY,TENMAYBAY,SOLUONGGHE) VALUES('{0}', '{1}', '{2}')", mamb, mb.TenMayBay1, mb.SLGhe1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal mb As DTO_MAYBAY) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE MAYBAY SET TENMAYBAY='{0}', SOLUONGGHE='{1}' WHERE MAMAYBAY='{2}'", mb.TenMayBay1, mb.SLGhe1, mb.MaMayBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaMayBay As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM MAYBAY WHERE MAMAYBAY='{0}'", MaMayBay)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function SortTheoMaMayBay() As DataTable
        Dim sql As String
        sql = "SELECT * FROM MAYBAY ORDER BY MAMAYBAY DESC"
        Return db.Execute(sql)
    End Function
    Public Function TaoMaMayBay() As String
        Dim dt As New DataTable
        dt = SortTheoMaMayBay()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "MB1"
        End If
        Return String.Format("MB{0}", count)
    End Function
    Public Function TimKiemTheoMaMayBay(ByVal MaMayBay As String)
        Dim sql As String
        sql = String.Format("SELECT MAMAYBAY[Mã máy bay], TENMAYBAY[Tên máy bay], 
                SOLUONGGHE[Số lượng ghế] FROM MAYBAY WHERE MAMAYBAY LIKE('%{0}%')", MaMayBay)
        Return db.Execute(sql)
    End Function
    Public Function KiemTraMayBay(ByVal tenmb As String, ByVal slghe As Integer) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM MAYBAY WHERE TENMAYBAY =N'{0}' AND SOLUONGGHE={1}", tenmb, slghe)
        Return db.Execute(sql)
    End Function
End Class

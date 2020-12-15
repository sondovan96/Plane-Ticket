Imports DTO
Public Class DAL_SanBay
    Private db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub

    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM SANBAY"
        Return db.Execute(sql)
    End Function

    Public Function selectHienThi() As DataTable
        Dim sql As String
        sql = "SELECT MASANBAY, TENSANBAY, TENTHANHPHO FROM SANBAY"
        Return db.Execute(sql)
    End Function
    Public Function addSanBay(ByVal sb As DTO_SanBay) As Boolean
        Try
            Dim sql As String
            Dim maSanBay As String = TaoMaSanBay()
            sql = String.Format("INSERT INTO SANBAY(MASANBAY, TENSANBAY, TENTHANHPHO) VALUES('{0}', N'{1}', N'{2}')", maSanBay, sb.TenSanBay1, sb.TenThanhPho1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function TimKiemMaSanBay(ByVal MaSanBay As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], TENTHANHPHO[Tên Thành Phố] 
FROM SANBAY WHERE MASANBAY LIKE('%{0}%')", MaSanBay)
        Return db.Execute(sql)
    End Function
    Public Function Update(ByVal sb As DTO_SanBay) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE SANBAY SET TENSANBAY=N'{0}', TENTHANHPHO=N'{1}' WHERE MASANBAY='{2}'", sb.TenSanBay1, sb.TenThanhPho1, sb.MaSanBay1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Delete(ByVal MaSanBay As String) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM SANBAY WHERE MASANBAY='{0}'", MaSanBay)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function KiemTraSanBay(ByVal tensb As String, ByVal tentp As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM SANBAY WHERE TENSANBAY =N'{0}' AND TENTHANHPHO=N'{1}'", tensb, tentp)
        Return db.Execute(sql)
    End Function
    Public Function SortTheoMaSanBay() As DataTable
        Dim sql As String
        sql = "SELECT MASANBAY, TENSANBAY, TENTHANHPHO FROM SANBAY ORDER BY MASANBAY DESC"
        Return db.Execute(sql)
    End Function
    Private Function TaoMaSanBay() As String

        Dim dt As New DataTable
        dt = SortTheoMaSanBay()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "SB1"
        End If
        Return String.Format("SB{0}", count)
    End Function
End Class

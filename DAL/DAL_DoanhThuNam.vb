Imports DTO
Public Class DAL_DoanhThuNam
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT* FROM DOANHTHUNAM"
        Return db.Execute(sql)
    End Function

    Public Function AddCTDoanhThuThang(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES('{0}', '{1}')", dtn.Nam1, dtn.DoanhThu1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE DOANHTHUNAM SET DOANHTHU='{0}' WHERE NAM='{1}')", dtn.DoanhThu1, dtn.Nam1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Try
            Dim sql As String
            sql = String.Format("DELETE FROM DOANHTHUNAM WHERE NAM='{0}'", dtn.Nam1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LayNam(ByVal Nam As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT* FROM DOANHTHUNAM WHERE NAM='{0}'", Nam)
        Return db.Execute(sql)
    End Function
End Class

Imports DTO
Public Class DAL_NhanVien
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub

    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "SELECT * FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN"
        Return db.Execute(sql)
    End Function
    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT N.MANHANVIEN, N.TENNHANVIEN, 
                A.USERNAME, A.PASSWORD, A.TYPE 
                FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN"
        Return db.Execute(sql)
    End Function
    Public Function AddNhanVien(ByVal nv As DTO_NhanVien) As Boolean
        Try
            Dim manhanvien As String = TaoMaNhanVien()
            Dim sql1 As String
            sql1 = String.Format("INSERT INTO NHANVIEN(MANHANVIEN, TENNHANVIEN) VALUES('{0}', N'{1}')", manhanvien, nv.TenNhanVien1)
            Dim sql2 As String
            sql2 = String.Format("INSERT INTO ACCOUNT(USERNAME, PASSWORD, MANHANVIEN, TYPE) VALUES('{0}', '{1}', '{2}','{3}')", nv.Username1, nv.Password1, manhanvien, nv.Type1)
            db.ExecuteNonQuery(sql1)
            db.ExecuteNonQuery(sql2)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal nv As DTO_NhanVien) As Boolean
        Try
            Dim sql1 As String
            sql1 = String.Format("UPDATE NHANVIEN SET TENNHANVIEN=N'{0}'WHERE MANHANVIEN='{1}'", nv.TenNhanVien1, nv.MaNhanVien1)
            Dim sql2 As String
            sql2 = String.Format("UPDATE ACCOUNT SET USERNAME='{0}', PASSWORD='{1}', TYPE='{2}' WHERE MANHANVIEN='{3}'", nv.Username1, nv.Password1, nv.Type1, nv.MaNhanVien1)
            db.ExecuteNonQuery(sql1)
            db.ExecuteNonQuery(sql2)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal MaNhanVien As String) As Boolean
        Try
            Dim sql1 As String
            sql1 = String.Format("DELETE FROM NHANVIEN WHERE MANHANVIEN='{0}'", MaNhanVien)
            Dim sql2 As String
            sql2 = String.Format("DELETE FROM ACCOUNT WHERE MANHANVIEN='{0}'", MaNhanVien)
            db.ExecuteNonQuery(sql2)
            db.ExecuteNonQuery(sql1)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TimTheoMaNhanVien(ByVal MaNhanVien As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT N.MANHANVIEN, N.TENNHANVIEN, 
                A.USERNAME, A.PASSWORD, A.TYPE 
                FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN 
                WHERE MANHANVIEN LIKE('%{0}%')", MaNhanVien)
        Return db.Execute(sql)
    End Function
    Public Function SortTheoMaNhanVien() As DataTable
        Dim sql As String
        sql = "SELECT * FROM NHANVIEN ORDER BY MANHANVIEN DESC"
        Return db.Execute(sql)
    End Function
    Public Function TaoMaNhanVien() As String
        Dim dt As New DataTable
        dt = SortTheoMaNhanVien()
        Dim count As Integer
        count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Return "NV1"
        End If
        Return String.Format("NV{0}", count)
    End Function
    Public Function LayUsernameAndPass(ByVal username As String, ByVal password As String) As DataTable
        Dim sql As String
        sql = String.Format("SELECT * FROM ACCOUNT WHERE USERNAME='{0}' AND PASSWORD='{1}'", username, password)
        Return db.Execute(sql)
    End Function
End Class

Imports DAL
Imports DTO
Public Class BUS_NhanVien
    Dim DAL As DAL_NhanVien
    Public Sub New()
        DAL = New DAL_NhanVien()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function AddNhanVien(ByVal nv As DTO_NhanVien) As Boolean
        Return DAL.AddNhanVien(nv)
    End Function
    Public Function Update(ByVal nv As DTO_NhanVien) As Boolean
        Return DAL.Update(nv)
    End Function
    Public Function Delete(ByVal MaNhanVien As String) As Boolean
        Return DAL.Delete(MaNhanVien)
    End Function

    Public Function TimTheoMaNhanVien(ByVal MaNhanVien As String) As DataTable
        Return DAL.TimTheoMaNhanVien(MaNhanVien)
    End Function
    Public Function SortTheoMaNhanVien() As DataTable
        Return DAL.SortTheoMaNhanVien()
    End Function

    Public Function LayUsernameAndPass(ByVal username As String, ByVal password As String) As DataTable
        Return DAL.LayUsernameAndPass(username, password)
    End Function
End Class

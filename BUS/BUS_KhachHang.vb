Imports DAL
Imports DTO
Public Class BUS_KhachHang
    Dim DAL As DAL_KhachHang
    Public Sub New()
        DAL = New DAL_KhachHang()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function AddKhachHang(ByVal kh As DTO_KhachHang) As Boolean
        Return DAL.AddKhachHang(kh)
    End Function
    Public Function Update(ByVal kh As DTO_KhachHang) As Boolean
        Return DAL.Update(kh)
    End Function
    Public Function Delete(ByVal MaKH As String) As Boolean
        Return DAL.Delete(MaKH)
    End Function
    Public Function LayCMND(ByVal CMND As String) As DataTable
        Return DAL.LayCMND(CMND)
    End Function
    Public Function SortTheoMaKH() As DataTable
        Return DAL.SortTheoMaKH()
    End Function

    Public Function TimKiemTheoMaKhachHang(ByVal MaKhachHang As String) As DataTable
        Return DAL.TimKiemTheoMaKhachHang(MaKhachHang)
    End Function
End Class

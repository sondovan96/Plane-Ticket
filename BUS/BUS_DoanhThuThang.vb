Imports DAL
Imports DTO
Public Class BUS_DoanhThuThang
    Dim DAL As DAL_DoanhThuThang
    Public Sub New()
        DAL = New DAL_DoanhThuThang()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function AddCTDoanhThuThang(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Return DAL.AddCTDoanhThuThang(dtt)
    End Function
    Public Function Update(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Return DAL.Update(dtt)
    End Function
    Public Function Delete(ByVal dtt As DTO_DoanhThuThang) As Boolean
        Return DAL.Delete(dtt)
    End Function
    Public Function layNam(ByVal Nam As String) As DataTable
        Return DAL.LayNam(Nam)
    End Function
End Class

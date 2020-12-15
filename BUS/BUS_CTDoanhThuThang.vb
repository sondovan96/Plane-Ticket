Imports DAL
Imports DTO
Public Class BUS_CTDoanhThuThang
    Dim DAL As DAL_CTDoanhThuThang
    Public Sub New()
        DAL = New DAL_CTDoanhThuThang()
    End Sub

    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function AddCTDoanhThuThang(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Return DAL.AddCTDoanhThuThang(ctdt)
    End Function
    Public Function Update(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Return DAL.Update(ctdt)
    End Function
    Public Function Delete(ByVal ctdt As DTO_CTDoanhThuThang) As Boolean
        Return DAL.Delete(ctdt)
    End Function
    Public Function LayNamThang(ByVal Thang As String, ByVal Nam As String) As DataTable
        Return DAL.LayNamThang(Thang, Nam)
    End Function
End Class

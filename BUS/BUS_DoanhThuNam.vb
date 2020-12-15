Imports DAL
Imports DTO
Public Class BUS_DoanhThuNam
    Dim DAL As DAL_DoanhThuNam
    Public Sub New()
        DAL = New DAL_DoanhThuNam()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function AddCTDoanhThuThang(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Return DAL.AddCTDoanhThuThang(dtn)
    End Function
    Public Function Update(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Return DAL.Update(dtn)
    End Function
    Public Function Delete(ByVal dtn As DTO_DoanhThuNam) As Boolean
        Return DAL.Delete(dtn)
    End Function
    Public Function layNam(ByVal Nam As String) As DataTable
        Return DAL.LayNam(Nam)
    End Function
End Class

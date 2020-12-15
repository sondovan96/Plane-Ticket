Imports DTO
Imports DAL
Public Class BUS_VeChuyenBay
    Dim DAL As DAL_VeChuyenBay
    Public Sub New()
        DAL = New DAL_VeChuyenBay()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function AddVeChuyenBay(ByVal ve As DTO_VeChuyenBay) As Boolean
        Return DAL.AddVeChuyenBay(ve)
    End Function
    Public Function Update(ByVal ve As DTO_VeChuyenBay) As Boolean
        Return DAL.Update(ve)
    End Function
    Public Function Delete(ByVal mave As String) As Boolean
        Return DAL.Delete(mave)
    End Function
    Public Function SortTheoMaVe() As DataTable
        Return DAL.SortTheoMaVe()
    End Function
End Class

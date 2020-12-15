Imports DAL
Imports DTO
Public Class BUS_CTChuyenBay
    Dim DAL As DAL_CTChuyenBay
    Public Sub New()
        DAL = New DAL_CTChuyenBay
    End Sub

    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThiTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.HienThiTheoMaChuyenBay(MaChuyenBay)
    End Function
    Public Function AddCTChuyenBay(ByVal ct As DTO_CTChuyenBay) As Boolean
        Return DAL.AddCTChuyenBay(ct)
    End Function

    Public Function Update(ByVal ct As DTO_CTChuyenBay) As Boolean
        Return DAL.Update(ct)
    End Function
    Public Function Delete(ByVal ct As DTO_CTChuyenBay) As Boolean
        Return DAL.Delete(ct)
    End Function
    Public Function LaySBTGTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.LaySBTGTheoMaChuyenBay(MaChuyenBay)
    End Function
End Class

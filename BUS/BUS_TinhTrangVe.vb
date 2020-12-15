Imports DAL
Imports DTO
Public Class BUS_TinhTrangVe
    Dim DAL As DAL_TinhTrangVe
    Public Sub New()
        DAL = New DAL_TinhTrangVe()
    End Sub

    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThiTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.HienThiTheoMaChuyenBay(MaChuyenBay)
    End Function
    Public Function AddTinhTrangVe(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Return DAL.AddTinhTrangVe(ttv)
    End Function
    Public Function Update(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Return DAL.Update(ttv)
    End Function
    Public Function Delete(ByVal ttv As DTO_TinhTrangVe) As Boolean
        Return DAL.Delete(ttv)
    End Function
    Public Function LayTTVTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.LayTTVTheoMaChuyenBay(MaChuyenBay)
    End Function
    Public Function LayGheTrongTheoMaChuyenBayVaMaHangVe(ByVal MaChuyenBay As String, ByVal MaHangVe As String) As DataTable
        Return DAL.LayGheTrongTheoMaChuyenBayVaMaHangVe(MaChuyenBay, MaHangVe)
    End Function

End Class

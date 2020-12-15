Imports DAL
Imports DTO
Public Class BUS_ChuyenBay
    Dim DAL As DAL_ChuyenBay
    Public Sub New()
        DAL = New DAL_ChuyenBay()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function SortTheoMaChuyenBay()
        Return DAL.SortTheoMaChuyenBay()
    End Function
    Public Function AddChuyenBay(ByVal cb As DTO_ChuyenBay) As Boolean
        Return DAL.AddChuyenBay(cb)
    End Function
    Public Function Update(ByVal cb As DTO_ChuyenBay) As Boolean
        Return DAL.Update(cb)
    End Function
    Public Function Delete(ByVal MaChuyenBay As String) As Boolean
        Return DAL.Delete(MaChuyenBay)
    End Function
    Public Function LayChuyenBayTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.LayChuyenBayTheoMaChuyenBay(MaChuyenBay)
    End Function
    Public Function GetTGKhoiHanhOfMaChuyenBay(ByVal MaCHuyenBay As String) As DataTable
        Return DAL.GetTGKhoiHanhOfMaChuyenBay(MaCHuyenBay)
    End Function
    Public Function TimKiemTheoMaChuyenBay(ByVal MaChuyenBay As String) As DataTable
        Return DAL.TimKiemTheoMaChuyenBay(MaChuyenBay)
    End Function
    Public Function TraCuu(ByVal MaSanBayDi As String, ByVal MaSanBayDen As String, ByVal TGKhoiHanhTu As DateTime, ByVal TGKhoiHanhDen As DateTime)
        Return DAL.TraCuu(MaSanBayDi, MaSanBayDen, TGKhoiHanhTu, TGKhoiHanhDen)
    End Function

End Class

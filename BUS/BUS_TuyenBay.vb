Imports DAL
Imports DTO
Public Class BUS_TuyenBay
    Dim DAL As DAL_TuyenBay
    Public Sub New()
        DAL = New DAL_TuyenBay()
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function layDSTuyenBay() As DataTable
        Return DAL.layDSTuyenBay()
    End Function
    Public Function AddTuyenBay(ByVal tb As DTO_TuyenBay) As Boolean
        Return DAL.AddTuyenBay(tb)
    End Function
    Public Function Update(ByVal tb As DTO_TuyenBay) As Boolean
        Return DAL.Update(tb)
    End Function
    Public Function Delete(ByVal MaTuyenBay As String) As Boolean
        Return DAL.Delete(MaTuyenBay)
    End Function
    Public Function TimKiemTheoMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Return DAL.TimKiemTheoMaTuyenBay(MaTuyenBay)
    End Function
    Public Function SelectOfMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Return DAL.SelectOfMaTuyenBay(MaTuyenBay)
    End Function
    Public Function SelectOfMaSanBay(ByVal MaSanBayDi As String, ByVal MaSanBayDen As String) As DataTable
        Return DAL.SelectOfMaSanBay(MaSanBayDi, MaSanBayDen)
    End Function
End Class

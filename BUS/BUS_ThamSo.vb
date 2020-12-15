Imports DAL
Imports DTO
Public Class BUS_ThamSo
    Dim DAL As DAL_ThamSo
    Public Sub New()
        DAL = New DAL_ThamSo()
    End Sub

    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function AddThamSo(ByVal ts As DTO_ThamSo) As Boolean
        Return DAL.AddThamSo(ts)
    End Function
    Public Function Update(ByVal ts As DTO_ThamSo) As Boolean
        Return DAL.Update(ts)
    End Function
End Class

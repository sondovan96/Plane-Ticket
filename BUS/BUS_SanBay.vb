Imports DAL
Imports DTO
Public Class BUS_SanBay
    Private DAL As DAL_SanBay
    Public Sub New()
        DAL = New DAL_SanBay
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function selectHienThi() As DataTable
        Return DAL.selectHienThi()
    End Function
    Public Function addSanBay(ByVal sb As DTO_SanBay) As Boolean
        Return DAL.addSanBay(sb)
    End Function
    Public Function TimKiemMaSanBay(ByVal MaSanBay As String) As DataTable
        Return DAL.TimKiemMaSanBay(MaSanBay)
    End Function
    Public Function Update(ByVal sb As DTO_SanBay) As Boolean
        Return DAL.Update(sb)
    End Function
    Public Function Delete(ByVal MaSanBay As String) As Boolean
        Return DAL.Delete(MaSanBay)
    End Function
    Public Function KiemTraSanBay(ByVal tensb As String, ByVal tentp As String) As Boolean
        Dim dt As New DataTable
        dt = DAL.KiemTraSanBay(tensb, tentp)
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
End Class

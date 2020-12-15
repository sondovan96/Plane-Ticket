Imports DAL
Imports DTO
Public Class BUS_MayBay
    Dim DAL As DAL_MayBay
    Public Sub New()
        DAL = New DAL_MayBay
    End Sub
    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function

    Public Function AddMayBay(ByVal mb As DTO_MAYBAY) As Boolean
        Return DAL.AddMayBay(mb)
    End Function
    Public Function Update(ByVal mb As DTO_MAYBAY) As Boolean
        Return DAL.Update(mb)
    End Function
    Public Function Delete(ByVal MaMayBay As String) As Boolean
        Return DAL.Delete(MaMayBay)
    End Function
    Public Function SortTheoMaMayBay() As DataTable
        Return DAL.SortTheoMaMayBay()
    End Function
    Public Function TimKiemTheoMaMayBay(ByVal MaMayBay As String)
        Return DAL.TimKiemTheoMaMayBay(MaMayBay)
    End Function
    Public Function KiemTraMayBay(ByVal tenmb As String, ByVal slghe As Integer) As Boolean
        Dim dt As New DataTable
        dt = DAL.KiemTraMayBay(tenmb, slghe)
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
End Class

Imports DAL
Imports DTO
Public Class BUS_HangVe
    Dim DAL As DAL_HangVe
    Public Sub New()
        DAL = New DAL_HangVe()
    End Sub
    Public Function SelectAll() As DataTable
        Return DAL.SelectAll()
    End Function

    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function Add(ByVal hv As DTO_HangVe) As Boolean
        Return DAL.Add(hv)
    End Function
    Public Function Update(ByVal hv As DTO_HangVe) As Boolean
        Return DAL.Update(hv)
    End Function
    Public Function Delete(ByVal MaHangVe As String) As Boolean
        Return DAL.Delete(MaHangVe)
    End Function
    Public Function SortTheoMaHangVe() As DataTable
        Return DAL.SortTheoMaHangVe()
    End Function
    Public Function TimKiemTheoMaHangVe(ByVal MaHangVe As String) As DataTable
        Return DAL.TimKiemTheoMaHangVe(MaHangVe)
    End Function
    Public Function KiemTra(ByVal TenHangVe As String) As Boolean
        Dim dt As New DataTable
        dt = DAL.KiemTra(TenHangVe)
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
End Class

Imports DAL
Imports DTO
Public Class BUS_DonGia
    Dim DAL As DAL_DonGia
    Public Sub New()
        DAL = New DAL_DonGia()
    End Sub

    Public Function selectAll() As DataTable
        Return DAL.selectAll()
    End Function
    Public Function HienThi() As DataTable
        Return DAL.HienThi()
    End Function
    Public Function AddDonGia(ByVal dg As DTO_DonGia) As Boolean
        Return DAL.AddDonGia(dg)
    End Function
    Public Function UpDate(ByVal dg As DTO_DonGia) As Boolean
        Return DAL.UpDate(dg)
    End Function
    Public Function Delete(ByVal dg As DTO_DonGia) As Boolean
        Return DAL.Delete(dg)
    End Function
    Public Function TimKiemTheoMaTuyenBay(ByVal MaTuyenBay As String) As DataTable
        Return DAL.TimKiemTheoMaTuyenBay(MaTuyenBay)
    End Function
    Public Function TimKiemTheoMaTuyenBayVaMaHangVe(ByVal MaTuyenBay As String, ByVal MaHangVe As String) As DataTable
        Return DAL.TimKiemTheoMaTuyenBayVaMaHangVe(MaTuyenBay, MaHangVe)
    End Function
End Class

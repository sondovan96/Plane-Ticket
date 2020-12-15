Imports BUS
Public Class frmBaoCaoThang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnXemBaoCao_Click(sender As Object, e As EventArgs) Handles btnXemBaoCao.Click
        Dim Month As Integer
        Dim Year As Integer
        Month = dtpThangNam.Value.Month
        Year = dtpThangNam.Value.Year
        Dim ctdoanhthuthangBUS As BUS_CTDoanhThuThang
        ctdoanhthuthangBUS = New BUS_CTDoanhThuThang()
        Dim dtCTDoanhThuThang As New DataTable
        dtCTDoanhThuThang = ctdoanhthuthangBUS.LayNamThang(Month, Year)
        Dim cr As CR_DoanhThuThang
        cr = New CR_DoanhThuThang()
        cr.SetDataSource(dtCTDoanhThuThang)
        crBaoCaoThang.ReportSource = cr
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub
End Class
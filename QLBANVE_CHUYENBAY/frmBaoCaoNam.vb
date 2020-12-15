Imports BUS
Public Class frmBaoCaoNam
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnXemBaoCao_Click(sender As Object, e As EventArgs) Handles btnXemBaoCao.Click
        Dim Year As String
        Dim doanhthuthangBUS As BUS_DoanhThuThang
        Year = dtpNam.Value.Year.ToString()
        doanhthuthangBUS = New BUS_DoanhThuThang()
        Dim dtDoanhThuThang As New DataTable
        dtDoanhThuThang = doanhthuthangBUS.layNam(Year)
        Dim cr As CR_DoanhThuNam
        cr = New CR_DoanhThuNam()
        cr.SetDataSource(dtDoanhThuThang)
        crBaoCaoNam.ReportSource = cr
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub
End Class
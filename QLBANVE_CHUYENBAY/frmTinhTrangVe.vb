Imports BUS
Imports DTO
Public Class frmTinhTrangVe
    Dim chuyenbayBUS As BUS_ChuyenBay
    Dim ttvBUS As BUS_TinhTrangVe
    Dim machuyenbay As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        chuyenbayBUS = New BUS_ChuyenBay()
        ttvBUS = New BUS_TinhTrangVe()
        machuyenbay = ""
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal machuyenbay1 As String)

        ' This call is required by the designer.
        InitializeComponent()
        chuyenbayBUS = New BUS_ChuyenBay()
        ttvBUS = New BUS_TinhTrangVe()
        machuyenbay = machuyenbay1
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub loadcb()
        Dim dtChuyenBay As New DataTable
        dtChuyenBay = chuyenbayBUS.selectAll()
        cboMaChuyenBay.DataSource = dtChuyenBay
        cboMaChuyenBay.DisplayMember = "MACHUYENBAY"
        cboMaChuyenBay.ValueMember = "MACHUYENBAY"
        cboMaChuyenBay.SelectedValue = machuyenbay
    End Sub

    Public Sub loadlv(ByVal machuyenbay As String)
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = ttvBUS.HienThiTheoMaChuyenBay(machuyenbay)
        lvTinhTrangVe.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvttv As ListViewItem
            lvttv = lvTinhTrangVe.Items.Add(stt)
            lvttv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvttv.SubItems.Add(dt.Rows(i)(1).ToString)
            lvttv.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
    Private Sub frmTinhTrangVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcb()
    End Sub

    Private Sub cboMaChuyenBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaChuyenBay.SelectedIndexChanged
        loadlv(cboMaChuyenBay.Text)
    End Sub
End Class
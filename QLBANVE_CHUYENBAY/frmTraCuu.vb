Imports BUS
Public Class frmTraCuu
    Dim chuyenbayBUS As BUS_ChuyenBay
    Dim cboMaChuyenBay As New ComboBox
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        chuyenbayBUS = New BUS_ChuyenBay()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal cboMaChuyenBay As ComboBox)

        ' This call is required by the designer.
        InitializeComponent()
        chuyenbayBUS = New BUS_ChuyenBay()
        Me.cboMaChuyenBay = cboMaChuyenBay
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub loadcbb()
        Dim busSanBay As New BUS_SanBay()
        busSanBay = New BUS_SanBay()
        Dim dtSanBayDi As New DataTable()
        dtSanBayDi = busSanBay.selectAll()
        cboSanBayDi.DataSource = dtSanBayDi
        cboSanBayDi.DisplayMember = "TENSANBAY"
        cboSanBayDi.ValueMember = "MASANBAY"


        Dim dtSanBayDen As New DataTable()
        dtSanBayDen = busSanBay.selectAll()
        cboSanBayDen.DataSource = dtSanBayDen
        cboSanBayDen.DisplayMember = "TENSANBAY"
        cboSanBayDen.ValueMember = "MASANBAY"

        If cboMaChuyenBay.Text = Nothing Then
            btnChonChuyenBay.Visible = False
            lbBanVe.Visible = False
            btnTimKiem.Location = New Point(125, 22)
            lbTimKiem.Location = New Point(123, 65)
        End If
    End Sub

    Private Sub loadlv(ByVal masanbayden As String, ByVal masanbaydi As String, ByVal thoigianKHTu As DateTime, ByVal thoiGianKHDen As DateTime)
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = chuyenbayBUS.TraCuu(masanbayden, masanbaydi, thoigianKHTu, thoiGianKHDen)
        lvTraCuu.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvtc As ListViewItem
            lvtc = lvTraCuu.Items.Add(stt)
            lvtc.SubItems.Add(dt.Rows(i)(0).ToString)
            lvtc.SubItems.Add(dt.Rows(i)(1).ToString)
            lvtc.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
    Private Sub frmTraCuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtMaChuyenBay.Enabled = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        If cboMaChuyenBay.Text = Nothing Then
            Me.Parent.Dispose()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Dim maSanBayDi As String = cboSanBayDi.SelectedValue.ToString()
            Dim maSanBayDen As String = cboSanBayDen.SelectedValue.ToString()
            Dim ngayKHTu As DateTime = dtpNgayKHTu.Value
            Dim ngayKHDen As DateTime = dtpNgayKHDen.Value
            loadlv(maSanBayDi, maSanBayDen, ngayKHTu, ngayKHDen)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lvTraCuu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTraCuu.SelectedIndexChanged
        If lvTraCuu.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvTraCuu.SelectedItems
                txtMaChuyenBay.Text = item.SubItems(1).Text
            Next
        End If
    End Sub

    Private Sub btnChonChuyenBay_Click(sender As Object, e As EventArgs) Handles btnChonChuyenBay.Click
        cboMaChuyenBay.Text = txtMaChuyenBay.Text
        Me.Close()
    End Sub

    Private Sub frmTraCuu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadcbb()
    End Sub
End Class
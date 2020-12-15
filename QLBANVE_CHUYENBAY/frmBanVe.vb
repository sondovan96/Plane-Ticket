Imports BUS
Imports DTO
Public Class frmBanVe
    Dim vechuyenbayBUS As BUS_VeChuyenBay
    Dim vechuyenbayDTO As DTO_VeChuyenBay
    Dim chuyenbayBUS As BUS_ChuyenBay
    Dim chuyenbayDTO As DTO_ChuyenBay
    Dim khachhangBUS As BUS_KhachHang
    Dim khachhangDTO As DTO_KhachHang
    Dim hangveBUS As BUS_HangVe
    Dim ttvBUS As BUS_TinhTrangVe
    Dim maNhanVien As String
    Public Sub New(ByVal row As DataRow)

        ' This call is required by the designer.
        InitializeComponent()
        vechuyenbayBUS = New BUS_VeChuyenBay()
        chuyenbayBUS = New BUS_ChuyenBay()
        khachhangBUS = New BUS_KhachHang()
        hangveBUS = New BUS_HangVe()
        maNhanVien = row("MANHANVIEN").ToString()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        vechuyenbayBUS = New BUS_VeChuyenBay()
        chuyenbayBUS = New BUS_ChuyenBay()
        khachhangBUS = New BUS_KhachHang()
        hangveBUS = New BUS_HangVe()


        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub loadlv()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = vechuyenbayBUS.HienThi()
        lvBanVe.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvbv As ListViewItem
            lvbv = lvBanVe.Items.Add(stt)
            lvbv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(1).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(2).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(3).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(4).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(5).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(6).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(7).ToString)
            lvbv.SubItems.Add(dt.Rows(i)(8).ToString)
            stt += 1
        Next
    End Sub
    Private Sub LamMoi()
        txtTenKhachHang.ResetText()
        txtCMND.ResetText()
        txtSDT.ResetText()
    End Sub
    Private Sub setTextBox()
        txtMaTuyenBay.Enabled = False
        txtSanBayDen.Enabled = False
        txtSanBayDi.Enabled = False
        txtSoGheTrong.Enabled = False
        txtThoiGianKhoiHanh.Enabled = False
        txtThoiGIanBay.Enabled = False
        txtGiaTien.Enabled = False
    End Sub
    Private Sub loadcb()
        Dim dtchuyenbay As New DataTable
        Dim dthangve As New DataTable

        dtchuyenbay = chuyenbayBUS.selectAll()
        dtchuyenbay.Rows.Add("Mã Chuyến Bay")
        cboMaChuyenBay.DataSource = dtchuyenbay
        cboMaChuyenBay.DisplayMember = "MACHUYENBAY"
        cboMaChuyenBay.ValueMember = "MACHUYENBAY"

        dthangve = hangveBUS.SelectAll()
        cboHangVe.DataSource = dthangve
        cboHangVe.DisplayMember = "TENHANGVE"
        cboHangVe.ValueMember = "MAHANGVE"

    End Sub

    Private Sub frmBanVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlv()
        setTextBox()
        loadcb()
        cboMaChuyenBay.Text = "Mã Chuyến Bay"
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub txtGiaTien_TextChanged(sender As Object, e As EventArgs) Handles txtGiaTien.TextChanged
        If txtGiaTien.Text = "" Then
            Return
        End If
        Dim Text As String
        Text = txtGiaTien.Text.Replace(",", "")
        Dim value As Decimal
        value = Convert.ToDecimal(Text)
        txtGiaTien.Text = String.Format("{0:0,0}", value)
    End Sub

    Private Sub lvBanVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBanVe.SelectedIndexChanged
        If lvBanVe.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvBanVe.SelectedItems
                txtCMND.Text = item.SubItems(3).Text
                cboMaChuyenBay.Text = item.SubItems(4).Text
                cboHangVe.Text = item.SubItems(5).Text
            Next
        End If
    End Sub

    Private Sub txtCMND_TextChanged(sender As Object, e As EventArgs) Handles txtCMND.TextChanged
        Dim dtKhachHang As New DataTable
        dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
        If dtKhachHang.Rows.Count = 0 Then
            txtTenKhachHang.Clear()
            txtSDT.Clear()
        Else
            txtTenKhachHang.Text = dtKhachHang.Rows(0)("TENKHACHHANG").ToString()
            txtSDT.Text = dtKhachHang.Rows(0)("SDT").ToString()
        End If
    End Sub


    Private Sub cboMaChuyenBay_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMaChuyenBay.SelectedValueChanged
        Dim dtChuyenBay As New DataTable
        dtChuyenBay = chuyenbayBUS.LayChuyenBayTheoMaChuyenBay(cboMaChuyenBay.Text)
        If dtChuyenBay.Rows.Count = 0 Then
            txtThoiGianKhoiHanh.ResetText()
            txtThoiGIanBay.ResetText()
        Else
            'ttvBUS = New BUS_TinhTrangVe()
            'Dim dtsoghe As New DataTable
            'dtsoghe = ttvBUS.LayGheTrongTheoMaChuyenBayVaMaHangVe(cboMaChuyenBay.Text, cboHangVe.SelectedValue)
            'For i = 0 To dtsoghe.Rows.Count - 1
            '    txtSoGheTrong.Text = dtsoghe.Rows(i)("SOGHETRONG").ToString()
            'Next
            txtMaTuyenBay.Text = dtChuyenBay.Rows(0)("MATUYENBAY").ToString()
            txtSanBayDi.Text = dtChuyenBay.Rows(0)("TENSANBAYDI").ToString()
            txtSanBayDen.Text = dtChuyenBay.Rows(0)("TENSANBAYDEN").ToString()
            txtThoiGianKhoiHanh.Text = dtChuyenBay.Rows(0)("THOIGIANKHOIHANH").ToString()
            txtThoiGIanBay.Text = dtChuyenBay.Rows(0)("THOIGIANBAY").ToString()
        End If
    End Sub

    Private Sub btnChiTietGheTrong_Click(sender As Object, e As EventArgs) Handles btnChiTietGheTrong.Click
        Dim frm As frmTinhTrangVe
        frm = New frmTinhTrangVe(cboMaChuyenBay.Text)
        frm.Show()
    End Sub

    Private Sub cboHangVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHangVe.SelectedIndexChanged
        Dim dongiaBUS As New BUS_DonGia()
        Dim dtdongia As New DataTable
        ttvBUS = New BUS_TinhTrangVe()
        Dim dtSoghetrong As New DataTable
        dtSoghetrong = ttvBUS.LayGheTrongTheoMaChuyenBayVaMaHangVe(cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString)
        For i = 0 To dtSoghetrong.Rows.Count - 1
            txtSoGheTrong.Text = dtSoghetrong.Rows(i)("SOGHETRONG").ToString()
        Next
        dtdongia = dongiaBUS.TimKiemTheoMaTuyenBayVaMaHangVe(txtMaTuyenBay.Text, cboHangVe.SelectedValue.ToString())
        For i = 0 To dtdongia.Rows.Count - 1
            txtGiaTien.Text = dtdongia.Rows(i)("DONGIA").ToString()
        Next

    End Sub

    Private Sub btnMuaVe_Click(sender As Object, e As EventArgs) Handles btnMuaVe.Click
        If (txtSoGheTrong.Text = "0" Or txtSoGheTrong.Text = "") Then
            MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtCMND.Text.Trim() <> "" AndAlso txtTenKhachHang.Text.Trim() <> "" AndAlso txtSDT.Text.Trim() <> "" AndAlso cboHangVe.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận mua vé?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    Dim makhachhang As String
                    Dim loaiVe As String = "Vé mua"
                    Dim dtKhachHang As New DataTable
                    dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
                    If (dtKhachHang.Rows.Count > 0) Then
                        makhachhang = dtKhachHang.Rows(0)("MAKHACHHANG").ToString()
                    Else
                        khachhangDTO = New DTO_KhachHang("", txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text)
                        If khachhangBUS.AddKhachHang(khachhangDTO) = False Then
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LamMoi()
                            Return
                        End If
                        dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
                        makhachhang = dtKhachHang.Rows(0)("MAKHACHHANG").ToString()
                    End If
                    vechuyenbayDTO = New DTO_VeChuyenBay("", makhachhang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), txtGiaTien.Text, "null", maNhanVien, DateTime.Now, loaiVe)
                    If vechuyenbayBUS.AddVeChuyenBay(vechuyenbayDTO) = True Then
                        MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            End If
        Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub btnDatVe_Click(sender As Object, e As EventArgs) Handles btnDatVe.Click
        If txtCMND.Text.Trim() <> "" AndAlso txtTenKhachHang.Text.Trim() <> "" AndAlso txtSDT.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận đặt vé?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    Dim maKhachHang As String
                    Dim loaiVe As String = "Vé đặt"
                    Dim dtKhachHang As New DataTable
                    dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
                    If (dtKhachHang.Rows.Count > 0) Then
                        maKhachHang = dtKhachHang.Rows(0)("MAKHACHHANG").ToString()
                    Else
                        khachhangDTO = New DTO_KhachHang("", txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text)
                        If khachhangBUS.AddKhachHang(khachhangDTO) = False Then
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LamMoi()
                            Return
                        End If
                        dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
                        maKhachHang = dtKhachHang.Rows(0)("MAKHACHHANG").ToString()
                    End If
                    vechuyenbayDTO = New DTO_VeChuyenBay("", maKhachHang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), txtGiaTien.Text, "null", maNhanVien, DateTime.Now, loaiVe)
                    If vechuyenbayBUS.AddVeChuyenBay(vechuyenbayDTO) = True Then
                        MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        Dim frm As Form
        frm = New frmTraCuu(cboMaChuyenBay)
        frm.Show()
    End Sub

    Private Sub btnHuyVe_Click(sender As Object, e As EventArgs) Handles btnHuyVe.Click
        If lvBanVe.SelectedIndices.Count > 0 Then
            Dim loaive As String
            Dim mave As String
            For Each item As ListViewItem In lvBanVe.SelectedItems
                mave = item.SubItems(1).Text
                loaive = item.SubItems(9).Text
            Next
            If loaive = "Vé đặt" Then
                If MessageBox.Show("Bạn muốn huỷ vé đặt?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = vbOK Then
                    Try
                        Dim dtKhachHang As New DataTable
                        Dim maKhachHang As String
                        dtKhachHang = khachhangBUS.LayCMND(txtCMND.Text)
                        maKhachHang = dtKhachHang.Rows(0)("MAKHACHHANG").ToString()
                        If vechuyenbayBUS.Delete(mave) = True Then
                            MessageBox.Show("Huỷ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Huỷ Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Huỷ Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        LamMoi()
                    End Try
                End If
            Else
                MessageBox.Show("Vé đã bán không thể huỷ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng chọn 1 hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub txtCMND_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCMND.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSDT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDT.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTenKhachHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenKhachHang.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
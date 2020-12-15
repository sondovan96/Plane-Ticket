Imports BUS
Imports DTO
Public Class frmQuanLyDonGia
    Dim dongiaBUS As BUS_DonGia
    Dim dongiaDTO As DTO_DonGia
    Dim tuyenbayDTO As DTO_TuyenBay
    Dim tuyenbayBUS As BUS_TuyenBay
    Dim sanbayBUS As BUS_SanBay
    Dim hangveBUS As BUS_HangVe
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dongiaBUS = New BUS_DonGia()
        tuyenbayBUS = New BUS_TuyenBay()
        sanbayBUS = New BUS_SanBay()
        hangveBUS = New BUS_HangVe()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadlv()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = dongiaBUS.HienThi()
        lvDonGia.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvdg As ListViewItem
            lvdg = lvDonGia.Items.Add(stt)
            lvdg.SubItems.Add(dt.Rows(i)(0).ToString)
            lvdg.SubItems.Add(dt.Rows(i)(1).ToString)
            lvdg.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
    Private Sub loadcb()
        Dim dtTuyenBay As New DataTable
        Dim dtSanBayDi As New DataTable
        Dim dtSanBayDen As New DataTable
        Dim dtHangVe As New DataTable

        dtTuyenBay = tuyenbayBUS.selectAll()
        dtTuyenBay.Rows.Add("Mã Tuyến Bay")
        cboMaTuyenBay.DataSource = dtTuyenBay
        cboMaTuyenBay.DisplayMember = "MATUYENBAY"
        cboMaTuyenBay.ValueMember = "MATUYENBAY"


        dtHangVe = hangveBUS.SelectAll()
        cboMaHangVe.DataSource = dtHangVe
        cboMaHangVe.DisplayMember = "TENHANGVE"
        cboMaHangVe.ValueMember = "MAHANGVE"


        dtSanBayDi = sanbayBUS.selectAll()
        dtSanBayDi.Rows.Add(-1, "Sân Bay Đi")
        cboSanBayDi.DataSource = dtSanBayDi
        cboSanBayDi.DisplayMember = "TENSANBAY"
        cboSanBayDi.ValueMember = "MASANBAY"


        dtSanBayDen = sanbayBUS.selectAll()
        dtSanBayDen.Rows.Add(-1, "Sân Bay Đến")
        cboSanBayDen.DataSource = dtSanBayDen
        cboSanBayDen.DisplayMember = "TENSANBAY"
        cboSanBayDen.ValueMember = "MASANBAY"

    End Sub

    Private Sub setDefault()
        cboSanBayDen.Enabled = False
        cboSanBayDi.Enabled = False

    End Sub
    Private Sub LamMoi()
        cboMaTuyenBay.Text = "Mã Tuyến Bay"
        txtDonGia.ResetText()
    End Sub

    Private Sub frmQuanLyDonGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlv()
        setDefault()
        loadcb()
        cboMaTuyenBay.Text = "Mã Tuyến Bay"
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub cboMaTuyenBay_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMaTuyenBay.SelectionChangeCommitted
        If IsDBNull(cboMaTuyenBay.SelectedValue) = False Then
            Dim tuyenbayBUS As New BUS_TuyenBay()
            Dim dtTuyenBay As New DataTable
            dtTuyenBay = tuyenbayBUS.SelectOfMaTuyenBay(cboMaTuyenBay.SelectedValue.ToString())
            If (dtTuyenBay.Rows.Count = 0) Then
                Return
            End If
            cboSanBayDi.Text = dtTuyenBay.Rows(0)("TENSANBAYDI").ToString()
            cboSanBayDi.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDI").ToString()
            cboSanBayDen.Text = dtTuyenBay.Rows(0)("TENSANBAYDEN").ToString()
            cboSanBayDen.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDEN").ToString()
        End If
    End Sub

    Private Sub cboMaTuyenBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaTuyenBay.SelectedIndexChanged
        If cboMaTuyenBay.Text = "Mã Tuyến Bay" Then
            cboSanBayDen.Text = "Sân Bay Đến"
            cboSanBayDi.Text = "Sân Bay Đi"
        End If
        If IsDBNull(cboMaTuyenBay.SelectedValue) = False Then
            Dim tuyenbayBUS As New BUS_TuyenBay()
            Dim dtTuyenBay As New DataTable
            dtTuyenBay = tuyenbayBUS.SelectOfMaTuyenBay(cboMaTuyenBay.SelectedValue.ToString())
            If (dtTuyenBay.Rows.Count = 0) Then
                Return
            End If
            cboSanBayDi.Text = dtTuyenBay.Rows(0)("TENSANBAYDI").ToString()
            cboSanBayDi.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDI").ToString()
            cboSanBayDen.Text = dtTuyenBay.Rows(0)("TENSANBAYDEN").ToString()
            cboSanBayDen.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDEN").ToString()
        End If
    End Sub



    Private Sub lvDonGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDonGia.SelectedIndexChanged
        If lvDonGia.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvDonGia.SelectedItems
                cboMaTuyenBay.Text = item.SubItems(1).Text
                cboMaHangVe.Text = item.SubItems(2).Text
                txtDonGia.Text = item.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtDonGia.Text <> "" Then
            Try
                dongiaDTO = New DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtDonGia.Text)
                If (dongiaBUS.AddDonGia(dongiaDTO)) Then
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                LamMoi()
            End Try
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub txtDonGia_TextChanged(sender As Object, e As EventArgs) Handles txtDonGia.TextChanged
        If txtDonGia.Text = "" Then
            lbDonGia.Text = ""
            Return
        End If
        Dim value As Decimal
        value = Convert.ToDecimal(txtDonGia.Text)
        lbDonGia.Text = String.Format("{0:0,0 VNĐ}", value)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If lvDonGia.SelectedIndices.Count > 0 Then
            If txtDonGia.Text.Trim() <> "" Then
                Try
                    dongiaDTO = New DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtDonGia.Text)
                    If dongiaBUS.UpDate(dongiaDTO) = True Then
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If lvDonGia.SelectedIndices.Count > 0 Then
            Try
                dongiaDTO = New DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtDonGia.Text)
                If dongiaBUS.Delete(dongiaDTO) = True Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                LamMoi()
            End Try
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlv()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = dongiaBUS.TimKiemTheoMaTuyenBay(txtTimKiem.Text)
        lvDonGia.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvdg As ListViewItem
            lvdg = lvDonGia.Items.Add(stt)
            lvdg.SubItems.Add(dt.Rows(i)(0).ToString)
            lvdg.SubItems.Add(dt.Rows(i)(1).ToString)
            lvdg.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub

    Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
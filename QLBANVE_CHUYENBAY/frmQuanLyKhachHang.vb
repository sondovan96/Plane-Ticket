Imports BUS
Imports DTO
Public Class frmQuanLyKhachHang
    Dim khachhangBUS As BUS_KhachHang
    Dim khachhangDTO As DTO_KhachHang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        khachhangBUS = New BUS_KhachHang()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loadlvKH()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = khachhangBUS.HienThi()
        lvKhachHang.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvkh As ListViewItem
            lvkh = lvKhachHang.Items.Add(stt)
            lvkh.SubItems.Add(dt.Rows(i)(0).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(1).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(2).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(3).ToString)
            stt += 1
        Next
    End Sub
    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaKhachHang.Enabled = False
        loadlvKH()
    End Sub
    Private Sub LamMoi()
        txtMaKhachHang.ResetText()
        txtCMND.ResetText()
        txtTenKhachHang.ResetText()
        txtSDT.ResetText()
    End Sub
    Private Sub lvKhachHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKhachHang.SelectedIndexChanged
        If lvKhachHang.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvKhachHang.SelectedItems
                txtMaKhachHang.Text = item.SubItems(1).Text
                txtTenKhachHang.Text = item.SubItems(2).Text
                txtCMND.Text = item.SubItems(3).Text
                txtSDT.Text = item.SubItems(4).Text
            Next
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaKhachHang.Text.Trim() <> "" Then
            If (txtTenKhachHang.Text.Trim() <> "" AndAlso txtCMND.Text.Trim() <> "" AndAlso txtSDT.Text.Trim() <> "") Then
                If MessageBox.Show("Xác nhận sửa khách hàng?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        khachhangDTO = New DTO_KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text)
                        If khachhangBUS.Update(khachhangDTO) = True Then
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        LamMoi()
                    End Try
                End If
            Else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvKH()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaKhachHang.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận xoá khách hàng?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If khachhangBUS.Delete(txtMaKhachHang.Text) = True Then
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            End If
        Else
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvKH()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = khachhangBUS.TimKiemTheoMaKhachHang(txtTimKiem.Text)
        lvKhachHang.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvkh As ListViewItem
            lvkh = lvKhachHang.Items.Add(stt)
            lvkh.SubItems.Add(dt.Rows(i)(0).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(1).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(2).ToString)
            lvkh.SubItems.Add(dt.Rows(i)(3).ToString)
            stt += 1
        Next
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
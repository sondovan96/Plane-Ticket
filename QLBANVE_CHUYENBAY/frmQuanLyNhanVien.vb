Imports BUS
Imports DTO
Public Class frmQuanLyNhanVien
    Dim nhanvienBUS As BUS_NhanVien
    Dim nhanvienDTO As DTO_NhanVien
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        nhanvienBUS = New BUS_NhanVien()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub LamMoi()
        txtMaNhanVien.ResetText()
        txtPassword.ResetText()
        txtTenNhanVien.ResetText()
        txtUsername.ResetText()
    End Sub
    Private Sub loadlvNhanVien()
        Dim dt As New DataTable
        Dim stt As String = 1
        dt = nhanvienBUS.HienThi()
        lvNhanVien.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvnv As ListViewItem
            lvnv = lvNhanVien.Items.Add(stt)
            lvnv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(1).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(2).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(3).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(4).ToString)
            stt += 1
        Next
    End Sub
    Private Sub frmQuanLyNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaNhanVien.Enabled = False
        loadlvNhanVien()
    End Sub

    Private Sub lvNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvNhanVien.SelectedIndexChanged
        If lvNhanVien.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvNhanVien.SelectedItems
                txtMaNhanVien.Text = item.SubItems(1).Text
                txtTenNhanVien.Text = item.SubItems(2).Text
                txtUsername.Text = item.SubItems(3).Text
                txtPassword.Text = item.SubItems(4).Text
                Dim loadnv As String
                loadnv = item.SubItems(5).Text
                If loadnv = 0 Then
                    rdbtnNVQuanTri.Checked = True
                Else
                    rdbtnNVBanVe.Checked = True
                End If
            Next
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenNhanVien.Text.Trim() <> "" AndAlso txtUsername.Text.Trim() <> "" AndAlso txtPassword.Text.Trim() <> "" Then
            Dim Type As Integer = 0
            Dim tenloai As String
            If rdbtnNVQuanTri.Checked = True Then
                Type = 0
                tenloai = rdbtnNVQuanTri.Text
            End If
            If rdbtnNVBanVe.Checked = True Then
                Type = 1
                tenloai = rdbtnNVBanVe.Text
            End If
            If MessageBox.Show("Xác nhận thêm nhân viên " + tenloai + "?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    nhanvienDTO = New DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtUsername.Text, txtPassword.Text, Type)
                    If nhanvienBUS.AddNhanVien(nhanvienDTO) = True Then
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            End If
        Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvNhanVien()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaNhanVien.Text.Trim() <> "" Then
            If txtTenNhanVien.Text.Trim() <> "" AndAlso txtUsername.Text.Trim() <> "" AndAlso txtPassword.Text.Trim() <> "" Then
                Dim Type As Integer = 0
                If (rdbtnNVQuanTri.Checked) Then
                    Type = 0
                End If
                If (rdbtnNVBanVe.Checked) Then
                    Type = 1
                End If
                If MessageBox.Show("Xác nhận sửa nhân viên?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        nhanvienDTO = New DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtUsername.Text, txtPassword.Text, Type)
                        If (nhanvienBUS.Update(nhanvienDTO)) Then
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
        loadlvNhanVien()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaNhanVien.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận xóa nhân viên?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If nhanvienBUS.Delete(txtMaNhanVien.Text) = True Then
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
        loadlvNhanVien()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = nhanvienBUS.TimTheoMaNhanVien(txtTimKiem.Text)
        lvNhanVien.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvnv As ListViewItem
            lvnv = lvNhanVien.Items.Add(stt)
            lvnv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(1).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(2).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(3).ToString)
            lvnv.SubItems.Add(dt.Rows(i)(4).ToString)
            stt += 1
        Next
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub
End Class
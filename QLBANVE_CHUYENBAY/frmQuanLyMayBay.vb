Imports BUS
Imports DTO
Public Class frmQuanLyMayBay
    Dim maybayBUS As BUS_MayBay
    Dim maybayDTO As DTO_MAYBAY
    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        maybayBUS = New BUS_MayBay()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadlvMayBay()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = maybayBUS.selectAll()
        lvMayBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvmb As ListViewItem
            lvmb = lvMayBay.Items.Add(stt)
            lvmb.SubItems.Add(dt.Rows(i)(0).ToString)
            lvmb.SubItems.Add(dt.Rows(i)(1).ToString)
            lvmb.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub

    Private Sub frmQuanLyMayBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaMayBay.Enabled = False
        loadlvMayBay()
        'btnThem.Enabled = False
    End Sub

    Private Sub lvMayBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMayBay.SelectedIndexChanged
        If lvMayBay.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvMayBay.SelectedItems
                txtMaMayBay.Text = item.SubItems(1).Text
                txtTenMayBay.Text = item.SubItems(2).Text
                txtSoLuongGhe.Text = item.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub LamMoi()
        txtMaMayBay.Clear()
        txtTenMayBay.Clear()
        txtSoLuongGhe.Clear()
        txtTenMayBay.Focus()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenMayBay.Text.Trim() <> "" AndAlso txtSoLuongGhe.Text.Trim() <> "" Then
            If maybayBUS.KiemTraMayBay(txtTenMayBay.Text, txtSoLuongGhe.Text) = True Then
                MessageBox.Show("Máy bay đã tồn tại, vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LamMoi()
                Return
            End If
            If MessageBox.Show("Xác nhận thêm máy bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    maybayDTO = New DTO_MAYBAY(txtMaMayBay.Text, txtTenMayBay.Text, txtSoLuongGhe.Text)
                    If (maybayBUS.AddMayBay(maybayDTO)) Then
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
        loadlvMayBay()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If (txtMaMayBay.Text.Trim() <> "") Then
            If txtTenMayBay.Text.Trim() <> "" AndAlso txtSoLuongGhe.Text.Trim() <> "" Then
                If maybayBUS.KiemTraMayBay(txtTenMayBay.Text, txtSoLuongGhe.Text) = True Then
                    MessageBox.Show("Máy bay đã tồn tại, vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    LamMoi()
                    Return
                End If
                If MessageBox.Show("Xác nhận sửa thông tin máy bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        maybayDTO = New DTO_MAYBAY(txtMaMayBay.Text, txtTenMayBay.Text, txtSoLuongGhe.Text)
                        If (maybayBUS.Update(maybayDTO)) Then
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
        loadlvMayBay()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaMayBay.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận xóa máy bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If maybayBUS.Delete(txtMaMayBay.Text) = True Then
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa không thành công, hiện đang có chuyến bay sử dụng máy bay này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        loadlvMayBay()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = maybayBUS.TimKiemTheoMaMayBay(txtTimKiem.Text)
        lvMayBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvmb As ListViewItem
            lvmb = lvMayBay.Items.Add(stt)
            lvmb.SubItems.Add(dt.Rows(i)(0).ToString)
            lvmb.SubItems.Add(dt.Rows(i)(1).ToString)
            lvmb.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub
End Class
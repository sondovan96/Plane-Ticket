Imports BUS
Imports DTO
Public Class frmQuanLyHangVe
    Dim hangveBUS As BUS_HangVe
    Dim hangveDTO As DTO_HangVe
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        hangveBUS = New BUS_HangVe()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loadlv()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = hangveBUS.SelectAll()
        lvHangVe.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvhv As ListViewItem
            lvhv = lvHangVe.Items.Add(stt)
            lvhv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvhv.SubItems.Add(dt.Rows(i)(1).ToString)
            stt += 1
        Next
    End Sub
    Private Sub frmQuanLyHangVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaHangVe.Enabled = False
        loadlv()
    End Sub

    Private Sub lvHangVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvHangVe.SelectedIndexChanged
        If lvHangVe.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvHangVe.SelectedItems
                txtMaHangVe.Text = item.SubItems(1).Text
                txtTenHangVe.Text = item.SubItems(2).Text
            Next
        End If
    End Sub
    Private Sub LamMoi()
        txtMaHangVe.ResetText()
        txtTenHangVe.ResetText()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If (txtTenHangVe.Text.Trim() <> "") Then
            If hangveBUS.KiemTra(txtTenHangVe.Text) = True Then
                MessageBox.Show("Hạng vé đã tồn tại, vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LamMoi()
                Return
            End If
            If MessageBox.Show("Xác nhận thêm hạng vé?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    hangveDTO = New DTO_HangVe(txtMaHangVe.Text, txtTenHangVe.Text)
                    If hangveBUS.Add(hangveDTO) = True Then
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
        loadlv()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If (txtMaHangVe.Text.Trim() <> "") Then
            If (txtTenHangVe.Text.Trim() <> "") Then
                If MessageBox.Show("Xác nhận sửa hạng vé?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        hangveDTO = New DTO_HangVe(txtMaHangVe.Text, txtTenHangVe.Text)
                        If (hangveBUS.Update(hangveDTO)) Then
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
        loadlv()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (txtMaHangVe.Text.Trim() <> "") Then
            If MessageBox.Show("Xác nhận xoá hạng vé?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If (hangveBUS.Delete(txtMaHangVe.Text)) Then
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
        loadlv()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = hangveBUS.TimKiemTheoMaHangVe(txtTimKiem.Text)
        lvHangVe.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvhv As ListViewItem
            lvhv = lvHangVe.Items.Add(stt)
            lvhv.SubItems.Add(dt.Rows(i)(0).ToString)
            lvhv.SubItems.Add(dt.Rows(i)(1).ToString)
            stt += 1
        Next
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub
End Class
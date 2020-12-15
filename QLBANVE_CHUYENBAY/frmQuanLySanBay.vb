Imports DTO
Imports BUS

Public Class frmQuanLySanBay
    Private sanbayBUS As BUS_SanBay
    Private thamsoBUS As BUS_ThamSo
    Dim slsanbay As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        sanbayBUS = New BUS_SanBay()
        thamsoBUS = New BUS_ThamSo()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loadlvSanBay()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = sanbayBUS.selectAll()
        lvSanBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvSB As ListViewItem
            lvSB = lvSanBay.Items.Add(stt)
            lvSB.SubItems.Add(dt.Rows(i)(0).ToString)
            lvSB.SubItems.Add(dt.Rows(i)(1).ToString)
            lvSB.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
    Private Sub LamMoi()
        txtMaSanBay.ResetText()
        txtTenSanBay.ResetText()
        txtTenThanhPho.ResetText()
        txtMaSanBay.Select()
    End Sub

    Private Sub frmQuanLySanBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlvSanBay()
        txtMaSanBay.Enabled = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub lvSanBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSanBay.SelectedIndexChanged
        If lvSanBay.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvSanBay.SelectedItems
                txtMaSanBay.Text = item.SubItems(1).Text
                txtTenSanBay.Text = item.SubItems(2).Text
                txtTenThanhPho.Text = item.SubItems(3).Text
            Next
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim dtThamso As New DataTable
        dtThamso = thamsoBUS.selectAll()
        slsanbay = dtThamso.Rows(0)(6).ToString
        If lvSanBay.Items.Count < slsanbay Then
            If txtTenSanBay.Text.Trim() <> "" AndAlso txtTenThanhPho.Text.Trim() <> "" Then
                If sanbayBUS.KiemTraSanBay(txtTenSanBay.Text, txtTenThanhPho.Text) = True Then
                    MessageBox.Show("Sân bay đã tồn tại, vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    LamMoi()
                    Return
                End If
                If MessageBox.Show("Thêm Sân Bay:" + txtTenSanBay.Text + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        Dim sanbayDTO As New DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text)
                        If sanbayBUS.addSanBay(sanbayDTO) = True Then
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception

                    Finally
                        LamMoi()
                    End Try
                End If
            Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(String.Format("Quy định chỉ nhập tối đa {0} sân bay!", slsanbay), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LamMoi()
        loadlvSanBay()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaSanBay.Text.Trim() <> "" Then
            If txtTenSanBay.Text.Trim() <> "" AndAlso txtTenThanhPho.Text.Trim() <> "" Then
                If MessageBox.Show("Xác nhận sửa sân bay?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        Dim sanbayDTO As New DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text)
                        If sanbayBUS.Update(sanbayDTO) = True Then
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
        loadlvSanBay()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSanBay.Text.Trim() <> "" Then
            If MessageBox.Show("Xác nhận xóa sân bay?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    Dim maSanBay As String
                    maSanBay = txtMaSanBay.Text
                    If sanbayBUS.Delete(maSanBay) = True Then
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa không thành công, đang có Tuyến Bay sử dụng sân bay này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        loadlvSanBay()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = sanbayBUS.TimKiemMaSanBay(txtTimKiem.Text)
        lvSanBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvsb As ListViewItem
            lvsb = lvSanBay.Items.Add(stt)
            lvsb.SubItems.Add(dt.Rows(i)(0).ToString)
            lvsb.SubItems.Add(dt.Rows(i)(1).ToString)
            lvsb.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub
End Class
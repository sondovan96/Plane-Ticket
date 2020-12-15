Imports BUS
Imports DTO
Public Class frmQuanLyTuyenBay

    Dim tuyenbayDTO As DTO_TuyenBay
    Dim tuyenbayBUS As BUS_TuyenBay

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        tuyenbayBUS = New BUS_TuyenBay()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadlvTuyenBay()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = tuyenbayBUS.layDSTuyenBay()
        lvTuyenBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvTB As ListViewItem
            lvTB = lvTuyenBay.Items.Add(stt)
            lvTB.SubItems.Add(dt.Rows(i)(0).ToString)
            lvTB.SubItems.Add(dt.Rows(i)(1).ToString)
            lvTB.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
    Private Sub loadcbb()
        Dim SanBayDi As New DataTable
        Dim SanBayDen As New DataTable
        Dim sanbayBUS As New BUS_SanBay

        SanBayDi = sanbayBUS.selectAll()
        cboSanBayDi.DataSource = SanBayDi
        cboSanBayDi.DisplayMember = "TENSANBAY"
        cboSanBayDi.ValueMember = "MASANBAY"

        SanBayDen = sanbayBUS.selectAll()
        cboSanBayDen.DataSource = SanBayDen
        cboSanBayDen.DisplayMember = "TENSANBAY"
        cboSanBayDen.ValueMember = "MASANBAY"
    End Sub
    Private Sub frmQuanLyTuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlvTuyenBay()
        txtMaTuyenBay.Enabled = False
        loadcbb()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If cboSanBayDen.Text.Trim() <> "" AndAlso cboSanBayDi.Text.Trim() <> "" Then
            If cboSanBayDi.Text = cboSanBayDen.Text Then
                MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LamMoi()
                Return
            Else
                If MessageBox.Show("Xác nhận thêm tuyến bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        tuyenbayDTO = New DTO_TuyenBay(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString())
                        If tuyenbayBUS.AddTuyenBay(tuyenbayDTO) = True Then
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
            End If
                Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvTuyenBay()
    End Sub
    Private Sub LamMoi()
        txtMaTuyenBay.ResetText()
        cboSanBayDen.Text = ""
        cboSanBayDi.Text = ""
        cboSanBayDi.Focus()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub lvTuyenBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTuyenBay.SelectedIndexChanged
        If lvTuyenBay.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvTuyenBay.SelectedItems
                txtMaTuyenBay.Text = item.SubItems(1).Text
                cboSanBayDi.Text = item.SubItems(2).Text
                cboSanBayDen.Text = item.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaTuyenBay.Text.Trim() <> "" Then
            If cboSanBayDi.Text = cboSanBayDen.Text Then
                MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If MessageBox.Show("Xác nhận sửa tuyến bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    tuyenbayDTO = New DTO_TuyenBay(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString())
                    If tuyenbayBUS.Update(tuyenbayDTO) = True Then
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
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvTuyenBay()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (txtMaTuyenBay.Text.Trim() <> "") Then
            If MessageBox.Show("Xác nhận xoá tuyến bay?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If tuyenbayBUS.Delete(txtMaTuyenBay.Text) = True Then
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
        loadlvTuyenBay()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = tuyenbayBUS.TimKiemTheoMaTuyenBay(txtTimKiem.Text)
        lvTuyenBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvTB As ListViewItem
            lvTB = lvTuyenBay.Items.Add(stt)
            lvTB.SubItems.Add(dt.Rows(i)(0).ToString)
            lvTB.SubItems.Add(dt.Rows(i)(1).ToString)
            lvTB.SubItems.Add(dt.Rows(i)(2).ToString)
            stt += 1
        Next
    End Sub
End Class
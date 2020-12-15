Imports BUS
Public Class frmDangNhap
    Dim nhanvienBUS As BUS_NhanVien
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        nhanvienBUS = New BUS_NhanVien()
        KhoiTao()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub KhoiTao()
        txtUsername.Focus()

        txtUsername.TabIndex = 0
        txtPassword.TabIndex = 1
        btnDangNhap.TabIndex = 2
        btnThoat.TabIndex = 3

        txtPassword.UseSystemPasswordChar = True

        AcceptButton = btnDangNhap
        CancelButton = btnThoat
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtUsername.Text <> "" AndAlso txtPassword.Text <> "" Then
            Dim dtNhanVien As New DataTable
            Try
                dtNhanVien = nhanvienBUS.LayUsernameAndPass(txtUsername.Text, txtPassword.Text)
            Catch ex As Exception
                MessageBox.Show("Lấy dữ liệu từ database thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
            If (dtNhanVien.Rows.Count > 0) Then
                Dim row As DataRow
                row = dtNhanVien.Rows(0)
                Dim frm As Form
                frm = New GUI_ManHinhChinh(row)
                Me.Hide()
                frm.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        If MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
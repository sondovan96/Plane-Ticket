Public Class GUI_ManHinhChinh

    Dim rowTTNhanVien As DataRow
    Public Sub New(ByVal row As DataRow)

        ' This call is required by the designer.
        InitializeComponent()
        rowTTNhanVien = row
        KhoiTaoGiaoDien()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function CheckExistForm(ByVal frm As Form) As Boolean
        For Each t As TabPage In tabCtrlMain.TabPages
            If frm.Text = t.Text Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub ActiveChildForm(ByVal frm As Form)
        For Each t As TabPage In tabCtrlMain.TabPages
            If frm.Text = t.Text Then
                tabCtrlMain.SelectedTab = t
                Return
            End If
        Next
    End Sub



    Private Function CreateTabPage(ByVal frm As Form) As TabPage
        Dim tabPage As TabPage
        Dim text As String = frm.Text
        tabPage = New TabPage(text)
        tabPage.BorderStyle = BorderStyle.None
        tabCtrlMain.TabPages.Add(tabPage)
        tabCtrlMain.SelectedTab = tabPage
        tabCtrlMain.Visible = True
        frm.TopLevel = False
        frm.Parent = tabPage
        frm.BackColor = Color.White
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Show()
        Return tabPage
    End Function

    Private Sub quanLySanBayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLySanBayToolStripMenuItem.Click
        Dim frm As New frmQuanLySanBay
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyTuyenBayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLyTuyenBayToolStripMenuItem.Click
        Dim frm As New frmQuanLyTuyenBay
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyMayBayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLyMayBayToolStripMenuItem.Click
        Dim frm As New frmQuanLyMayBay
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyHangVeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLyHangVeToolStripMenuItem.Click
        Dim frm As New frmQuanLyHangVe
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyChuyenBayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles quanLyChuyenBayToolStripMenuItem1.Click
        Dim frm As New frmQuanLyChuyenBay
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyDonGiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLyDonGiaToolStripMenuItem.Click
        Dim frm As New frmQuanLyDonGia
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub toolStripBtnBanVe_Click(sender As Object, e As EventArgs) Handles toolStripBtnBanVe.Click
        Dim frm As New frmBanVe(rowTTNhanVien)
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)

        Else
            ActiveChildForm(frm)
        End If
    End Sub
    Private Sub KhoiTaoGiaoDien()
        lbMaNhanVien.Text = String.Format("Mã nhân viên: {0}", rowTTNhanVien(2).ToString())
        lbUsername.Text = String.Format("Username: {0}", rowTTNhanVien(0).ToString())
        Dim type As Integer
        type = Convert.ToInt32(rowTTNhanVien(3).ToString())
        If type = 0 Then
            mstrMain.Enabled = True
            toolStripMain.Enabled = True
        End If
        If type = 1 Then
            mstrMain.Enabled = True
            toolStripMain.Enabled = True
            QuanLyThongTinToolStripMenuItem.Enabled = False
            baoCaoToolStripMenuItem.Enabled = False
            thayDoiQuyDinhToolStripMenuItem.Enabled = False
        End If
        tabCtrlMain.Visible = False

    End Sub

    Private Sub toolStripBtnTraCuuChuyenBay_Click(sender As Object, e As EventArgs) Handles toolStripBtnTraCuuChuyenBay.Click
        Dim frm As frmTraCuu
        frm = New frmTraCuu()
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub quanLyKhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quanLyKhachHangToolStripMenuItem.Click
        Dim frm As New frmQuanLyKhachHang
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub themNhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles themNhanVienToolStripMenuItem.Click
        Dim frm As New frmQuanLyNhanVien
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub GUI_ManHinhChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub toolStripBtnDangXuat_Click(sender As Object, e As EventArgs) Handles toolStripBtnDangXuat.Click
        If MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Hide()
            Dim frm As Form
            frm = New frmDangNhap()
            frm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub baoCaoThangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles baoCaoThangToolStripMenuItem.Click
        Dim frm As New frmBaoCaoThang
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub baoCaoNamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles baoCaoNamToolStripMenuItem.Click
        Dim frm As New frmBaoCaoNam
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub banVeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles banVeToolStripMenuItem.Click
        Dim frm As New frmBanVe
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub dangXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles dangXuatToolStripMenuItem.Click
        If MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Hide()
            Dim frm As Form
            frm = New frmDangNhap()
            frm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub thayDoiQuyDinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles thayDoiQuyDinhToolStripMenuItem.Click
        Dim frm As New frmThamSo
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub

    Private Sub thongTInNhaSanXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles thongTInNhaSanXuatToolStripMenuItem.Click
        Dim frm As New frmGioiThieu
        If CheckExistForm(frm) <> True Then
            CreateTabPage(frm)
        Else
            ActiveChildForm(frm)
        End If
    End Sub
End Class

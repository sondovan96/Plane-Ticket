<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_ManHinhChinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mstrMain = New System.Windows.Forms.MenuStrip()
        Me.heThongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dangXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.doiMatKhauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.thoatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.thaoTacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.banVeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanLyThongTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyChuyenBayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyTuyenBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLySanBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyMayBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyHangVeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyDonGiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quanLyKhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.themNhanVienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.thayDoiQuyDinhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.traCuuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.traCuuChuyenBayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.baoCaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.baoCaoThangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.baoCaoNamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.troGiupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.huongDanSuDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.thongTInNhaSanXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMain = New System.Windows.Forms.ToolStrip()
        Me.toolStripBtnBanVe = New System.Windows.Forms.ToolStripButton()
        Me.toolStripBtnTraCuuChuyenBay = New System.Windows.Forms.ToolStripButton()
        Me.toolStripBtnDangXuat = New System.Windows.Forms.ToolStripButton()
        Me.tabCtrlMain = New System.Windows.Forms.TabControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.lbMaNhanVien = New System.Windows.Forms.Label()
        Me.mstrMain.SuspendLayout()
        Me.toolStripMain.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstrMain
        '
        Me.mstrMain.BackColor = System.Drawing.Color.White
        Me.mstrMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.heThongToolStripMenuItem, Me.thaoTacToolStripMenuItem, Me.traCuuToolStripMenuItem, Me.baoCaoToolStripMenuItem, Me.troGiupToolStripMenuItem})
        Me.mstrMain.Location = New System.Drawing.Point(0, 0)
        Me.mstrMain.Name = "mstrMain"
        Me.mstrMain.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mstrMain.Size = New System.Drawing.Size(956, 24)
        Me.mstrMain.TabIndex = 3
        Me.mstrMain.Text = "menuStrip1"
        '
        'heThongToolStripMenuItem
        '
        Me.heThongToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dangXuatToolStripMenuItem, Me.doiMatKhauToolStripMenuItem, Me.thoatToolStripMenuItem1})
        Me.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem"
        Me.heThongToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.heThongToolStripMenuItem.Text = "Hệ thống"
        '
        'dangXuatToolStripMenuItem
        '
        Me.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem"
        Me.dangXuatToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.dangXuatToolStripMenuItem.Text = "Đăng xuất"
        '
        'doiMatKhauToolStripMenuItem
        '
        Me.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem"
        Me.doiMatKhauToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu"
        '
        'thoatToolStripMenuItem1
        '
        Me.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1"
        Me.thoatToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.thoatToolStripMenuItem1.Text = "Thoát"
        '
        'thaoTacToolStripMenuItem
        '
        Me.thaoTacToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.banVeToolStripMenuItem, Me.QuanLyThongTinToolStripMenuItem, Me.thayDoiQuyDinhToolStripMenuItem})
        Me.thaoTacToolStripMenuItem.Name = "thaoTacToolStripMenuItem"
        Me.thaoTacToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.thaoTacToolStripMenuItem.Text = "Thao tác"
        '
        'banVeToolStripMenuItem
        '
        Me.banVeToolStripMenuItem.Name = "banVeToolStripMenuItem"
        Me.banVeToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.banVeToolStripMenuItem.Text = "Bán vé"
        '
        'QuanLyThongTinToolStripMenuItem
        '
        Me.QuanLyThongTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quanLyChuyenBayToolStripMenuItem1, Me.quanLyTuyenBayToolStripMenuItem, Me.quanLySanBayToolStripMenuItem, Me.quanLyMayBayToolStripMenuItem, Me.quanLyHangVeToolStripMenuItem, Me.quanLyDonGiaToolStripMenuItem, Me.quanLyKhachHangToolStripMenuItem, Me.themNhanVienToolStripMenuItem})
        Me.QuanLyThongTinToolStripMenuItem.Name = "QuanLyThongTinToolStripMenuItem"
        Me.QuanLyThongTinToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.QuanLyThongTinToolStripMenuItem.Text = "Quản lý thông tin"
        '
        'quanLyChuyenBayToolStripMenuItem1
        '
        Me.quanLyChuyenBayToolStripMenuItem1.Name = "quanLyChuyenBayToolStripMenuItem1"
        Me.quanLyChuyenBayToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.quanLyChuyenBayToolStripMenuItem1.Text = "Chuyến bay"
        '
        'quanLyTuyenBayToolStripMenuItem
        '
        Me.quanLyTuyenBayToolStripMenuItem.Name = "quanLyTuyenBayToolStripMenuItem"
        Me.quanLyTuyenBayToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLyTuyenBayToolStripMenuItem.Text = "Tuyến bay"
        '
        'quanLySanBayToolStripMenuItem
        '
        Me.quanLySanBayToolStripMenuItem.Name = "quanLySanBayToolStripMenuItem"
        Me.quanLySanBayToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLySanBayToolStripMenuItem.Text = "Sân bay"
        '
        'quanLyMayBayToolStripMenuItem
        '
        Me.quanLyMayBayToolStripMenuItem.Name = "quanLyMayBayToolStripMenuItem"
        Me.quanLyMayBayToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLyMayBayToolStripMenuItem.Text = "Máy bay"
        '
        'quanLyHangVeToolStripMenuItem
        '
        Me.quanLyHangVeToolStripMenuItem.Name = "quanLyHangVeToolStripMenuItem"
        Me.quanLyHangVeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLyHangVeToolStripMenuItem.Text = "Hạng vé"
        '
        'quanLyDonGiaToolStripMenuItem
        '
        Me.quanLyDonGiaToolStripMenuItem.Name = "quanLyDonGiaToolStripMenuItem"
        Me.quanLyDonGiaToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLyDonGiaToolStripMenuItem.Text = "Đơn giá"
        '
        'quanLyKhachHangToolStripMenuItem
        '
        Me.quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem"
        Me.quanLyKhachHangToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.quanLyKhachHangToolStripMenuItem.Text = "Khách hàng"
        '
        'themNhanVienToolStripMenuItem
        '
        Me.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem"
        Me.themNhanVienToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.themNhanVienToolStripMenuItem.Text = "Nhân viên"
        '
        'thayDoiQuyDinhToolStripMenuItem
        '
        Me.thayDoiQuyDinhToolStripMenuItem.Name = "thayDoiQuyDinhToolStripMenuItem"
        Me.thayDoiQuyDinhToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.thayDoiQuyDinhToolStripMenuItem.Text = "Thay đổi quy định"
        '
        'traCuuToolStripMenuItem
        '
        Me.traCuuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.traCuuChuyenBayToolStripMenuItem})
        Me.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem"
        Me.traCuuToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.traCuuToolStripMenuItem.Text = "Tra cứu"
        '
        'traCuuChuyenBayToolStripMenuItem
        '
        Me.traCuuChuyenBayToolStripMenuItem.Name = "traCuuChuyenBayToolStripMenuItem"
        Me.traCuuChuyenBayToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.traCuuChuyenBayToolStripMenuItem.Text = "Chuyến bay"
        '
        'baoCaoToolStripMenuItem
        '
        Me.baoCaoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.baoCaoThangToolStripMenuItem, Me.baoCaoNamToolStripMenuItem})
        Me.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem"
        Me.baoCaoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.baoCaoToolStripMenuItem.Text = "Báo cáo"
        '
        'baoCaoThangToolStripMenuItem
        '
        Me.baoCaoThangToolStripMenuItem.Name = "baoCaoThangToolStripMenuItem"
        Me.baoCaoThangToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.baoCaoThangToolStripMenuItem.Text = "Tháng"
        '
        'baoCaoNamToolStripMenuItem
        '
        Me.baoCaoNamToolStripMenuItem.Name = "baoCaoNamToolStripMenuItem"
        Me.baoCaoNamToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.baoCaoNamToolStripMenuItem.Text = "Năm"
        '
        'troGiupToolStripMenuItem
        '
        Me.troGiupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.huongDanSuDungToolStripMenuItem, Me.thongTInNhaSanXuatToolStripMenuItem})
        Me.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem"
        Me.troGiupToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.troGiupToolStripMenuItem.Text = "Trợ giúp"
        '
        'huongDanSuDungToolStripMenuItem
        '
        Me.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem"
        Me.huongDanSuDungToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.huongDanSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng"
        '
        'thongTInNhaSanXuatToolStripMenuItem
        '
        Me.thongTInNhaSanXuatToolStripMenuItem.Name = "thongTInNhaSanXuatToolStripMenuItem"
        Me.thongTInNhaSanXuatToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.thongTInNhaSanXuatToolStripMenuItem.Text = "Thông tin nhà sản xuất"
        '
        'toolStripMain
        '
        Me.toolStripMain.AutoSize = False
        Me.toolStripMain.BackColor = System.Drawing.Color.Silver
        Me.toolStripMain.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.toolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBtnBanVe, Me.toolStripBtnTraCuuChuyenBay, Me.toolStripBtnDangXuat})
        Me.toolStripMain.Location = New System.Drawing.Point(0, 24)
        Me.toolStripMain.Name = "toolStripMain"
        Me.toolStripMain.Size = New System.Drawing.Size(956, 79)
        Me.toolStripMain.TabIndex = 4
        Me.toolStripMain.Text = "toolStrip1"
        '
        'toolStripBtnBanVe
        '
        Me.toolStripBtnBanVe.AutoSize = False
        Me.toolStripBtnBanVe.Image = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.toolBanVe
        Me.toolStripBtnBanVe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripBtnBanVe.Name = "toolStripBtnBanVe"
        Me.toolStripBtnBanVe.Size = New System.Drawing.Size(120, 70)
        Me.toolStripBtnBanVe.Text = "Bán vé"
        Me.toolStripBtnBanVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripBtnTraCuuChuyenBay
        '
        Me.toolStripBtnTraCuuChuyenBay.AutoSize = False
        Me.toolStripBtnTraCuuChuyenBay.Image = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.toolTraCuuChuyenBay
        Me.toolStripBtnTraCuuChuyenBay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripBtnTraCuuChuyenBay.Name = "toolStripBtnTraCuuChuyenBay"
        Me.toolStripBtnTraCuuChuyenBay.Size = New System.Drawing.Size(120, 70)
        Me.toolStripBtnTraCuuChuyenBay.Text = "Tra cứu chuyến bay"
        Me.toolStripBtnTraCuuChuyenBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripBtnDangXuat
        '
        Me.toolStripBtnDangXuat.AutoSize = False
        Me.toolStripBtnDangXuat.Image = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.toolDangXuat
        Me.toolStripBtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripBtnDangXuat.Name = "toolStripBtnDangXuat"
        Me.toolStripBtnDangXuat.Size = New System.Drawing.Size(120, 70)
        Me.toolStripBtnDangXuat.Text = "Đăng xuất"
        Me.toolStripBtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tabCtrlMain
        '
        Me.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlMain.Location = New System.Drawing.Point(0, 103)
        Me.tabCtrlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.tabCtrlMain.Name = "tabCtrlMain"
        Me.tabCtrlMain.SelectedIndex = 0
        Me.tabCtrlMain.Size = New System.Drawing.Size(956, 572)
        Me.tabCtrlMain.TabIndex = 5
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.lbUsername)
        Me.panel1.Controls.Add(Me.lbMaNhanVien)
        Me.panel1.Location = New System.Drawing.Point(779, 30)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(166, 69)
        Me.panel1.TabIndex = 6
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(2, 46)
        Me.lbUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(35, 13)
        Me.lbUsername.TabIndex = 0
        Me.lbUsername.Text = "label1"
        '
        'lbMaNhanVien
        '
        Me.lbMaNhanVien.AutoSize = True
        Me.lbMaNhanVien.Location = New System.Drawing.Point(2, 11)
        Me.lbMaNhanVien.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMaNhanVien.Name = "lbMaNhanVien"
        Me.lbMaNhanVien.Size = New System.Drawing.Size(35, 13)
        Me.lbMaNhanVien.TabIndex = 0
        Me.lbMaNhanVien.Text = "label1"
        '
        'GUI_ManHinhChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(956, 675)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.tabCtrlMain)
        Me.Controls.Add(Me.toolStripMain)
        Me.Controls.Add(Me.mstrMain)
        Me.Name = "GUI_ManHinhChinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.mstrMain.ResumeLayout(False)
        Me.mstrMain.PerformLayout()
        Me.toolStripMain.ResumeLayout(False)
        Me.toolStripMain.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mstrMain As MenuStrip
    Private WithEvents heThongToolStripMenuItem As ToolStripMenuItem
    Private WithEvents dangXuatToolStripMenuItem As ToolStripMenuItem
    Private WithEvents doiMatKhauToolStripMenuItem As ToolStripMenuItem
    Private WithEvents thoatToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents thaoTacToolStripMenuItem As ToolStripMenuItem
    Private WithEvents banVeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents QuanLyThongTinToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLyChuyenBayToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents quanLyTuyenBayToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLySanBayToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLyMayBayToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLyHangVeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLyDonGiaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents quanLyKhachHangToolStripMenuItem As ToolStripMenuItem
    Private WithEvents themNhanVienToolStripMenuItem As ToolStripMenuItem
    Private WithEvents thayDoiQuyDinhToolStripMenuItem As ToolStripMenuItem
    Private WithEvents traCuuToolStripMenuItem As ToolStripMenuItem
    Private WithEvents traCuuChuyenBayToolStripMenuItem As ToolStripMenuItem
    Private WithEvents baoCaoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents baoCaoThangToolStripMenuItem As ToolStripMenuItem
    Private WithEvents baoCaoNamToolStripMenuItem As ToolStripMenuItem
    Private WithEvents troGiupToolStripMenuItem As ToolStripMenuItem
    Private WithEvents huongDanSuDungToolStripMenuItem As ToolStripMenuItem
    Private WithEvents thongTInNhaSanXuatToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMain As ToolStrip
    Private WithEvents toolStripBtnBanVe As ToolStripButton
    Private WithEvents toolStripBtnTraCuuChuyenBay As ToolStripButton
    Private WithEvents toolStripBtnDangXuat As ToolStripButton
    Private WithEvents tabCtrlMain As TabControl
    Private WithEvents panel1 As Panel
    Private WithEvents lbUsername As Label
    Private WithEvents lbMaNhanVien As Label
End Class

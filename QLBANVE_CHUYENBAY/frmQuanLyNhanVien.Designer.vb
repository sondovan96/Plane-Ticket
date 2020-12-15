<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyNhanVien))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtTenNhanVien = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.gbxTTNhanVien = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.gbxDSNhanVien = New System.Windows.Forms.GroupBox()
        Me.lvNhanVien = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnNVBanVe = New System.Windows.Forms.RadioButton()
        Me.rdbtnNVQuanTri = New System.Windows.Forms.RadioButton()
        Me.gbxTTNhanVien.SuspendLayout()
        Me.gbxDSNhanVien.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.gbxThaoTac.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(130, 119)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(151, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(130, 86)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(151, 20)
        Me.txtUsername.TabIndex = 2
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(5, 124)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(53, 13)
        Me.label7.TabIndex = 16
        Me.label7.Text = "Password"
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.Location = New System.Drawing.Point(130, 54)
        Me.txtTenNhanVien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(151, 20)
        Me.txtTenNhanVien.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(5, 90)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(55, 13)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Username"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 27)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(72, 13)
        Me.label20.TabIndex = 15
        Me.label20.Text = "Mã nhân viên"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(130, 23)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.ReadOnly = True
        Me.txtMaNhanVien.Size = New System.Drawing.Size(151, 20)
        Me.txtMaNhanVien.TabIndex = 17
        Me.txtMaNhanVien.TabStop = False
        '
        'gbxTTNhanVien
        '
        Me.gbxTTNhanVien.Controls.Add(Me.GroupBox1)
        Me.gbxTTNhanVien.Controls.Add(Me.btnLamMoi)
        Me.gbxTTNhanVien.Controls.Add(Me.txtPassword)
        Me.gbxTTNhanVien.Controls.Add(Me.txtUsername)
        Me.gbxTTNhanVien.Controls.Add(Me.label7)
        Me.gbxTTNhanVien.Controls.Add(Me.txtTenNhanVien)
        Me.gbxTTNhanVien.Controls.Add(Me.label6)
        Me.gbxTTNhanVien.Controls.Add(Me.label20)
        Me.gbxTTNhanVien.Controls.Add(Me.label9)
        Me.gbxTTNhanVien.Controls.Add(Me.txtMaNhanVien)
        Me.gbxTTNhanVien.Location = New System.Drawing.Point(9, 54)
        Me.gbxTTNhanVien.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTNhanVien.Name = "gbxTTNhanVien"
        Me.gbxTTNhanVien.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTNhanVien.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTNhanVien.TabIndex = 53
        Me.gbxTTNhanVien.TabStop = False
        Me.gbxTTNhanVien.Text = "Thông tin nhân viên"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(5, 58)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(76, 13)
        Me.label9.TabIndex = 16
        Me.label9.Text = "Tên nhân viên"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(424, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Tìm kiếm "
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(481, 20)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(125, 20)
        Me.txtTimKiem.TabIndex = 8
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnTimKiem
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiem.FlatAppearance.BorderSize = 0
        Me.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimKiem.Location = New System.Drawing.Point(610, 16)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(25, 24)
        Me.btnTimKiem.TabIndex = 9
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'gbxDSNhanVien
        '
        Me.gbxDSNhanVien.Controls.Add(Me.lvNhanVien)
        Me.gbxDSNhanVien.Controls.Add(Me.label2)
        Me.gbxDSNhanVien.Controls.Add(Me.txtTimKiem)
        Me.gbxDSNhanVien.Controls.Add(Me.btnTimKiem)
        Me.gbxDSNhanVien.Location = New System.Drawing.Point(298, 54)
        Me.gbxDSNhanVien.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDSNhanVien.Name = "gbxDSNhanVien"
        Me.gbxDSNhanVien.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDSNhanVien.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSNhanVien.TabIndex = 55
        Me.gbxDSNhanVien.TabStop = False
        Me.gbxDSNhanVien.Text = "Danh sách nhân viên"
        '
        'lvNhanVien
        '
        Me.lvNhanVien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvNhanVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvNhanVien.FullRowSelect = True
        Me.lvNhanVien.GridLines = True
        Me.lvNhanVien.HideSelection = False
        Me.lvNhanVien.Location = New System.Drawing.Point(5, 54)
        Me.lvNhanVien.MultiSelect = False
        Me.lvNhanVien.Name = "lvNhanVien"
        Me.lvNhanVien.Size = New System.Drawing.Size(630, 428)
        Me.lvNhanVien.TabIndex = 16
        Me.lvNhanVien.UseCompatibleStateImageBehavior = False
        Me.lvNhanVien.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Nhân Viên"
        Me.ColumnHeader2.Width = 87
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên Nhân Viên"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Username"
        Me.ColumnHeader4.Width = 119
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Password"
        Me.ColumnHeader5.Width = 115
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Loại nhân viên"
        Me.ColumnHeader6.Width = 124
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(359, 11)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(218, 24)
        Me.label1.TabIndex = 39
        Me.label1.Text = "QUẢN LÝ NHÂN VIÊN"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Silver
        Me.btnThoat.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnCancel
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.FlatAppearance.BorderSize = 0
        Me.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThoat.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.White
        Me.btnThoat.Location = New System.Drawing.Point(904, 3)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(41, 41)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 7)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 56
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnThem
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.FlatAppearance.BorderSize = 0
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Location = New System.Drawing.Point(28, 18)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(41, 41)
        Me.btnThem.TabIndex = 6
        Me.btnThem.UseCompatibleTextRendering = True
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(226, 62)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Xóa"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(132, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(26, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Sửa"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 62)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Thêm"
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnXoa
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.FlatAppearance.BorderSize = 0
        Me.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoa.Location = New System.Drawing.Point(218, 18)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(41, 41)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'gbxThaoTac
        '
        Me.gbxThaoTac.Controls.Add(Me.btnThem)
        Me.gbxThaoTac.Controls.Add(Me.label5)
        Me.gbxThaoTac.Controls.Add(Me.label4)
        Me.gbxThaoTac.Controls.Add(Me.label3)
        Me.gbxThaoTac.Controls.Add(Me.btnSua)
        Me.gbxThaoTac.Controls.Add(Me.btnXoa)
        Me.gbxThaoTac.Location = New System.Drawing.Point(9, 461)
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 54
        Me.gbxThaoTac.TabStop = False
        Me.gbxThaoTac.Text = "Thao tác"
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.FlatAppearance.BorderSize = 0
        Me.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSua.Location = New System.Drawing.Point(125, 18)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(41, 41)
        Me.btnSua.TabIndex = 7
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Location = New System.Drawing.Point(205, 223)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 18
        Me.btnLamMoi.Text = "Làm Mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnNVBanVe)
        Me.GroupBox1.Controls.Add(Me.rdbtnNVQuanTri)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 62)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loại Nhân Viên"
        '
        'rdbtnNVBanVe
        '
        Me.rdbtnNVBanVe.AutoSize = True
        Me.rdbtnNVBanVe.Location = New System.Drawing.Point(36, 29)
        Me.rdbtnNVBanVe.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnNVBanVe.Name = "rdbtnNVBanVe"
        Me.rdbtnNVBanVe.Size = New System.Drawing.Size(59, 17)
        Me.rdbtnNVBanVe.TabIndex = 7
        Me.rdbtnNVBanVe.TabStop = True
        Me.rdbtnNVBanVe.Text = "Bán vé"
        Me.rdbtnNVBanVe.UseVisualStyleBackColor = True
        '
        'rdbtnNVQuanTri
        '
        Me.rdbtnNVQuanTri.AutoSize = True
        Me.rdbtnNVQuanTri.Location = New System.Drawing.Point(173, 29)
        Me.rdbtnNVQuanTri.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnNVQuanTri.Name = "rdbtnNVQuanTri"
        Me.rdbtnNVQuanTri.Size = New System.Drawing.Size(62, 17)
        Me.rdbtnNVQuanTri.TabIndex = 6
        Me.rdbtnNVQuanTri.TabStop = True
        Me.rdbtnNVQuanTri.Text = "Quản trị"
        Me.rdbtnNVQuanTri.UseVisualStyleBackColor = True
        '
        'frmQuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxTTNhanVien)
        Me.Controls.Add(Me.gbxDSNhanVien)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Name = "frmQuanLyNhanVien"
        Me.Text = "frmQuanLyNhanVien"
        Me.gbxTTNhanVien.ResumeLayout(False)
        Me.gbxTTNhanVien.PerformLayout()
        Me.gbxDSNhanVien.ResumeLayout(False)
        Me.gbxDSNhanVien.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtTenNhanVien As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label20 As Label
    Private WithEvents txtMaNhanVien As TextBox
    Private WithEvents gbxTTNhanVien As GroupBox
    Private WithEvents label9 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents gbxDSNhanVien As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents btnThoat As Button
    Private WithEvents panel1 As Panel
    Private WithEvents btnThem As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents gbxThaoTac As GroupBox
    Friend WithEvents lvNhanVien As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents rdbtnNVBanVe As RadioButton
    Private WithEvents rdbtnNVQuanTri As RadioButton
    Friend WithEvents btnLamMoi As Button
End Class

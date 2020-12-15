<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyKhachHang))
        Me.gbxTTKhachHang = New System.Windows.Forms.GroupBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.gbxDSKhachHang = New System.Windows.Forms.GroupBox()
        Me.lvKhachHang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.gbxTTKhachHang.SuspendLayout()
        Me.gbxDSKhachHang.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.gbxThaoTac.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTTKhachHang
        '
        Me.gbxTTKhachHang.Controls.Add(Me.txtCMND)
        Me.gbxTTKhachHang.Controls.Add(Me.txtMaKhachHang)
        Me.gbxTTKhachHang.Controls.Add(Me.label3)
        Me.gbxTTKhachHang.Controls.Add(Me.label20)
        Me.gbxTTKhachHang.Controls.Add(Me.label19)
        Me.gbxTTKhachHang.Controls.Add(Me.txtSDT)
        Me.gbxTTKhachHang.Controls.Add(Me.label2)
        Me.gbxTTKhachHang.Controls.Add(Me.txtTenKhachHang)
        Me.gbxTTKhachHang.Location = New System.Drawing.Point(8, 57)
        Me.gbxTTKhachHang.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTKhachHang.Name = "gbxTTKhachHang"
        Me.gbxTTKhachHang.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTKhachHang.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTKhachHang.TabIndex = 70
        Me.gbxTTKhachHang.TabStop = False
        Me.gbxTTKhachHang.Text = "Thông tin khách hàng"
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(106, 69)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(175, 20)
        Me.txtCMND.TabIndex = 2
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(106, 15)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.ReadOnly = True
        Me.txtMaKhachHang.Size = New System.Drawing.Size(175, 20)
        Me.txtMaKhachHang.TabIndex = 65
        Me.txtMaKhachHang.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(5, 73)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 63
        Me.label3.Text = "CMND"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 20)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(82, 13)
        Me.label20.TabIndex = 63
        Me.label20.Text = "Mã khách hàng"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(5, 46)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(86, 13)
        Me.label19.TabIndex = 64
        Me.label19.Text = "Tên khách hàng"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(106, 95)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(175, 20)
        Me.txtSDT.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(5, 99)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 13)
        Me.label2.TabIndex = 64
        Me.label2.Text = "Số điện thoại"
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Location = New System.Drawing.Point(106, 41)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(175, 20)
        Me.txtTenKhachHang.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(424, 24)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(52, 13)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Tìm kiếm "
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(481, 20)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(125, 20)
        Me.txtTimKiem.TabIndex = 6
        '
        'gbxDSKhachHang
        '
        Me.gbxDSKhachHang.Controls.Add(Me.lvKhachHang)
        Me.gbxDSKhachHang.Controls.Add(Me.label7)
        Me.gbxDSKhachHang.Controls.Add(Me.txtTimKiem)
        Me.gbxDSKhachHang.Controls.Add(Me.btnTimKiem)
        Me.gbxDSKhachHang.Location = New System.Drawing.Point(297, 57)
        Me.gbxDSKhachHang.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDSKhachHang.Name = "gbxDSKhachHang"
        Me.gbxDSKhachHang.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDSKhachHang.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSKhachHang.TabIndex = 72
        Me.gbxDSKhachHang.TabStop = False
        Me.gbxDSKhachHang.Text = "Danh sách khách hàng"
        '
        'lvKhachHang
        '
        Me.lvKhachHang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvKhachHang.FullRowSelect = True
        Me.lvKhachHang.GridLines = True
        Me.lvKhachHang.HideSelection = False
        Me.lvKhachHang.Location = New System.Drawing.Point(6, 43)
        Me.lvKhachHang.MultiSelect = False
        Me.lvKhachHang.Name = "lvKhachHang"
        Me.lvKhachHang.Size = New System.Drawing.Size(629, 441)
        Me.lvKhachHang.TabIndex = 16
        Me.lvKhachHang.UseCompatibleStateImageBehavior = False
        Me.lvKhachHang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Khách Hàng"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên Khách Hàng"
        Me.ColumnHeader3.Width = 175
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CMND"
        Me.ColumnHeader4.Width = 128
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Số điện thoại"
        Me.ColumnHeader5.Width = 128
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(359, 11)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(241, 24)
        Me.label6.TabIndex = 39
        Me.label6.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 5)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 73
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(165, 62)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Xóa"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(78, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(26, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Sửa"
        '
        'gbxThaoTac
        '
        Me.gbxThaoTac.Controls.Add(Me.label5)
        Me.gbxThaoTac.Controls.Add(Me.label4)
        Me.gbxThaoTac.Controls.Add(Me.btnSua)
        Me.gbxThaoTac.Controls.Add(Me.btnXoa)
        Me.gbxThaoTac.Location = New System.Drawing.Point(8, 464)
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 71
        Me.gbxThaoTac.TabStop = False
        Me.gbxThaoTac.Text = "Thao tác"
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
        Me.btnTimKiem.TabIndex = 7
        Me.btnTimKiem.UseVisualStyleBackColor = True
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
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.FlatAppearance.BorderSize = 0
        Me.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSua.Location = New System.Drawing.Point(71, 18)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(41, 41)
        Me.btnSua.TabIndex = 4
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnXoa
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.FlatAppearance.BorderSize = 0
        Me.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoa.Location = New System.Drawing.Point(157, 18)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(41, 41)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmQuanLyKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxTTKhachHang)
        Me.Controls.Add(Me.gbxDSKhachHang)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Name = "frmQuanLyKhachHang"
        Me.Text = "frmQuanLyKhachHang"
        Me.gbxTTKhachHang.ResumeLayout(False)
        Me.gbxTTKhachHang.PerformLayout()
        Me.gbxDSKhachHang.ResumeLayout(False)
        Me.gbxDSKhachHang.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents gbxTTKhachHang As GroupBox
    Private WithEvents txtCMND As TextBox
    Private WithEvents txtMaKhachHang As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents txtSDT As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtTenKhachHang As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents gbxDSKhachHang As GroupBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents label6 As Label
    Private WithEvents btnThoat As Button
    Private WithEvents panel1 As Panel
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents gbxThaoTac As GroupBox
    Friend WithEvents lvKhachHang As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class

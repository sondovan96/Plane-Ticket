<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyMayBay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyMayBay))
        Me.txtSoLuongGhe = New System.Windows.Forms.TextBox()
        Me.txtTenMayBay = New System.Windows.Forms.TextBox()
        Me.txtMaMayBay = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.gbxTTMayBay = New System.Windows.Forms.GroupBox()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.gbxDSMayBay = New System.Windows.Forms.GroupBox()
        Me.lvMayBay = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.gbxThaoTac.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.gbxTTMayBay.SuspendLayout()
        Me.gbxDSMayBay.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSoLuongGhe
        '
        Me.txtSoLuongGhe.Location = New System.Drawing.Point(106, 71)
        Me.txtSoLuongGhe.Name = "txtSoLuongGhe"
        Me.txtSoLuongGhe.Size = New System.Drawing.Size(175, 20)
        Me.txtSoLuongGhe.TabIndex = 2
        '
        'txtTenMayBay
        '
        Me.txtTenMayBay.Location = New System.Drawing.Point(106, 45)
        Me.txtTenMayBay.Name = "txtTenMayBay"
        Me.txtTenMayBay.Size = New System.Drawing.Size(175, 20)
        Me.txtTenMayBay.TabIndex = 1
        '
        'txtMaMayBay
        '
        Me.txtMaMayBay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaMayBay.Location = New System.Drawing.Point(106, 18)
        Me.txtMaMayBay.Name = "txtMaMayBay"
        Me.txtMaMayBay.ReadOnly = True
        Me.txtMaMayBay.Size = New System.Drawing.Size(175, 20)
        Me.txtMaMayBay.TabIndex = 47
        Me.txtMaMayBay.TabStop = False
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(5, 74)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(70, 13)
        Me.label18.TabIndex = 44
        Me.label18.Text = "Số lượng ghế"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(5, 48)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(68, 13)
        Me.label19.TabIndex = 46
        Me.label19.Text = "Tên máy bay"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(424, 24)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Tìm kiếm "
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(481, 20)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(125, 20)
        Me.txtTimKiem.TabIndex = 6
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 22)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(67, 13)
        Me.label20.TabIndex = 45
        Me.label20.Text = "Mã máy bay "
        '
        'gbxThaoTac
        '
        Me.gbxThaoTac.Controls.Add(Me.btnThem)
        Me.gbxThaoTac.Controls.Add(Me.label5)
        Me.gbxThaoTac.Controls.Add(Me.label4)
        Me.gbxThaoTac.Controls.Add(Me.label3)
        Me.gbxThaoTac.Controls.Add(Me.btnSua)
        Me.gbxThaoTac.Controls.Add(Me.btnXoa)
        Me.gbxThaoTac.Location = New System.Drawing.Point(8, 464)
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 54
        Me.gbxThaoTac.TabStop = False
        Me.gbxThaoTac.Text = "Thao tác"
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
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(359, 11)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(195, 24)
        Me.label2.TabIndex = 39
        Me.label2.Text = "QUẢN LÝ MÁY BAY"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 5)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 56
        '
        'gbxTTMayBay
        '
        Me.gbxTTMayBay.Controls.Add(Me.btnLamMoi)
        Me.gbxTTMayBay.Controls.Add(Me.txtSoLuongGhe)
        Me.gbxTTMayBay.Controls.Add(Me.txtTenMayBay)
        Me.gbxTTMayBay.Controls.Add(Me.txtMaMayBay)
        Me.gbxTTMayBay.Controls.Add(Me.label18)
        Me.gbxTTMayBay.Controls.Add(Me.label20)
        Me.gbxTTMayBay.Controls.Add(Me.label19)
        Me.gbxTTMayBay.Location = New System.Drawing.Point(8, 57)
        Me.gbxTTMayBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTMayBay.Name = "gbxTTMayBay"
        Me.gbxTTMayBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTMayBay.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTMayBay.TabIndex = 53
        Me.gbxTTMayBay.TabStop = False
        Me.gbxTTMayBay.Text = "Thông tin máy bay"
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Location = New System.Drawing.Point(205, 97)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 48
        Me.btnLamMoi.Text = "Làm Mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'gbxDSMayBay
        '
        Me.gbxDSMayBay.Controls.Add(Me.lvMayBay)
        Me.gbxDSMayBay.Controls.Add(Me.label6)
        Me.gbxDSMayBay.Controls.Add(Me.txtTimKiem)
        Me.gbxDSMayBay.Controls.Add(Me.btnTimKiem)
        Me.gbxDSMayBay.Location = New System.Drawing.Point(297, 57)
        Me.gbxDSMayBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDSMayBay.Name = "gbxDSMayBay"
        Me.gbxDSMayBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDSMayBay.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSMayBay.TabIndex = 55
        Me.gbxDSMayBay.TabStop = False
        Me.gbxDSMayBay.Text = "Danh sách máy bay"
        '
        'lvMayBay
        '
        Me.lvMayBay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvMayBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMayBay.FullRowSelect = True
        Me.lvMayBay.GridLines = True
        Me.lvMayBay.HideSelection = False
        Me.lvMayBay.Location = New System.Drawing.Point(5, 45)
        Me.lvMayBay.MultiSelect = False
        Me.lvMayBay.Name = "lvMayBay"
        Me.lvMayBay.Size = New System.Drawing.Size(630, 437)
        Me.lvMayBay.TabIndex = 16
        Me.lvMayBay.UseCompatibleStateImageBehavior = False
        Me.lvMayBay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Máy Bay"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 174
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên Máy Bay"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 235
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Số Lượng Ghế"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 157
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
        Me.btnThem.TabIndex = 3
        Me.btnThem.UseCompatibleTextRendering = True
        Me.btnThem.UseVisualStyleBackColor = True
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
        Me.btnSua.TabIndex = 4
        Me.btnSua.UseVisualStyleBackColor = True
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
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.UseVisualStyleBackColor = True
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
        'frmQuanLyMayBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gbxTTMayBay)
        Me.Controls.Add(Me.gbxDSMayBay)
        Me.Name = "frmQuanLyMayBay"
        Me.Text = "frmQuanLyMayBay"
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbxTTMayBay.ResumeLayout(False)
        Me.gbxTTMayBay.PerformLayout()
        Me.gbxDSMayBay.ResumeLayout(False)
        Me.gbxDSMayBay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtSoLuongGhe As TextBox
    Private WithEvents txtTenMayBay As TextBox
    Private WithEvents txtMaMayBay As TextBox
    Private WithEvents label18 As Label
    Private WithEvents label19 As Label
    Private WithEvents label6 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents label20 As Label
    Private WithEvents gbxThaoTac As GroupBox
    Private WithEvents btnThem As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents btnThoat As Button
    Private WithEvents gbxTTMayBay As GroupBox
    Private WithEvents gbxDSMayBay As GroupBox
    Friend WithEvents lvMayBay As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnLamMoi As Button
End Class

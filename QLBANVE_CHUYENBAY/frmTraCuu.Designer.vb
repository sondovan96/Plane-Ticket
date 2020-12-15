<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuu
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
        Me.label20 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.cboSanBayDen = New System.Windows.Forms.ComboBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.txtMaChuyenBay = New System.Windows.Forms.TextBox()
        Me.gbxTTChuyenBay = New System.Windows.Forms.GroupBox()
        Me.dtpNgayKHDen = New System.Windows.Forms.DateTimePicker()
        Me.cboSanBayDi = New System.Windows.Forms.ComboBox()
        Me.dtpNgayKHTu = New System.Windows.Forms.DateTimePicker()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.gbxDSChyenBay = New System.Windows.Forms.GroupBox()
        Me.lvTraCuu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label7 = New System.Windows.Forms.Label()
        Me.lbTimKiem = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lbBanVe = New System.Windows.Forms.Label()
        Me.btnChonChuyenBay = New System.Windows.Forms.Button()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.gbxTTChuyenBay.SuspendLayout()
        Me.gbxDSChyenBay.SuspendLayout()
        Me.gbxThaoTac.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 27)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(83, 13)
        Me.label20.TabIndex = 15
        Me.label20.Text = "Mã chuyến bay "
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(5, 83)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(68, 13)
        Me.label18.TabIndex = 13
        Me.label18.Text = "Sân bay đến"
        '
        'cboSanBayDen
        '
        Me.cboSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanBayDen.FormattingEnabled = True
        Me.cboSanBayDen.Location = New System.Drawing.Point(130, 77)
        Me.cboSanBayDen.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSanBayDen.Name = "cboSanBayDen"
        Me.cboSanBayDen.Size = New System.Drawing.Size(151, 21)
        Me.cboSanBayDen.TabIndex = 2
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(5, 57)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(58, 13)
        Me.label19.TabIndex = 16
        Me.label19.Text = "Sân bay đi"
        '
        'txtMaChuyenBay
        '
        Me.txtMaChuyenBay.Location = New System.Drawing.Point(130, 23)
        Me.txtMaChuyenBay.Name = "txtMaChuyenBay"
        Me.txtMaChuyenBay.ReadOnly = True
        Me.txtMaChuyenBay.Size = New System.Drawing.Size(151, 20)
        Me.txtMaChuyenBay.TabIndex = 17
        Me.txtMaChuyenBay.TabStop = False
        '
        'gbxTTChuyenBay
        '
        Me.gbxTTChuyenBay.Controls.Add(Me.label20)
        Me.gbxTTChuyenBay.Controls.Add(Me.label18)
        Me.gbxTTChuyenBay.Controls.Add(Me.cboSanBayDen)
        Me.gbxTTChuyenBay.Controls.Add(Me.label19)
        Me.gbxTTChuyenBay.Controls.Add(Me.dtpNgayKHDen)
        Me.gbxTTChuyenBay.Controls.Add(Me.cboSanBayDi)
        Me.gbxTTChuyenBay.Controls.Add(Me.dtpNgayKHTu)
        Me.gbxTTChuyenBay.Controls.Add(Me.txtMaChuyenBay)
        Me.gbxTTChuyenBay.Controls.Add(Me.label15)
        Me.gbxTTChuyenBay.Controls.Add(Me.label3)
        Me.gbxTTChuyenBay.Location = New System.Drawing.Point(8, 57)
        Me.gbxTTChuyenBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTChuyenBay.Name = "gbxTTChuyenBay"
        Me.gbxTTChuyenBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTChuyenBay.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTChuyenBay.TabIndex = 121
        Me.gbxTTChuyenBay.TabStop = False
        Me.gbxTTChuyenBay.Text = "Thông tin chuyến bay"
        '
        'dtpNgayKHDen
        '
        Me.dtpNgayKHDen.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayKHDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayKHDen.Location = New System.Drawing.Point(130, 137)
        Me.dtpNgayKHDen.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayKHDen.Name = "dtpNgayKHDen"
        Me.dtpNgayKHDen.Size = New System.Drawing.Size(150, 20)
        Me.dtpNgayKHDen.TabIndex = 4
        '
        'cboSanBayDi
        '
        Me.cboSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanBayDi.FormattingEnabled = True
        Me.cboSanBayDi.Location = New System.Drawing.Point(130, 51)
        Me.cboSanBayDi.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSanBayDi.Name = "cboSanBayDi"
        Me.cboSanBayDi.Size = New System.Drawing.Size(151, 21)
        Me.cboSanBayDi.TabIndex = 1
        '
        'dtpNgayKHTu
        '
        Me.dtpNgayKHTu.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayKHTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayKHTu.Location = New System.Drawing.Point(130, 109)
        Me.dtpNgayKHTu.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayKHTu.Name = "dtpNgayKHTu"
        Me.dtpNgayKHTu.Size = New System.Drawing.Size(150, 20)
        Me.dtpNgayKHTu.TabIndex = 3
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(5, 113)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(94, 13)
        Me.label15.TabIndex = 87
        Me.label15.Text = "Ngày khởi hành từ"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(74, 141)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 13)
        Me.label3.TabIndex = 87
        Me.label3.Text = "đến"
        '
        'gbxDSChyenBay
        '
        Me.gbxDSChyenBay.Controls.Add(Me.lvTraCuu)
        Me.gbxDSChyenBay.Location = New System.Drawing.Point(297, 57)
        Me.gbxDSChyenBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDSChyenBay.Name = "gbxDSChyenBay"
        Me.gbxDSChyenBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDSChyenBay.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSChyenBay.TabIndex = 123
        Me.gbxDSChyenBay.TabStop = False
        Me.gbxDSChyenBay.Text = "Danh sách chuyến bay"
        '
        'lvTraCuu
        '
        Me.lvTraCuu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvTraCuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTraCuu.FullRowSelect = True
        Me.lvTraCuu.GridLines = True
        Me.lvTraCuu.HideSelection = False
        Me.lvTraCuu.Location = New System.Drawing.Point(5, 23)
        Me.lvTraCuu.MultiSelect = False
        Me.lvTraCuu.Name = "lvTraCuu"
        Me.lvTraCuu.Size = New System.Drawing.Size(630, 459)
        Me.lvTraCuu.TabIndex = 0
        Me.lvTraCuu.UseCompatibleStateImageBehavior = False
        Me.lvTraCuu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Chuyến Bay"
        Me.ColumnHeader2.Width = 146
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ngày khởi hành"
        Me.ColumnHeader3.Width = 201
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Thời Gian Bay"
        Me.ColumnHeader4.Width = 219
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(359, 11)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(236, 24)
        Me.label7.TabIndex = 39
        Me.label7.Text = "TRA CỨU CHUYẾN BAY"
        '
        'lbTimKiem
        '
        Me.lbTimKiem.AutoSize = True
        Me.lbTimKiem.Location = New System.Drawing.Point(68, 63)
        Me.lbTimKiem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTimKiem.Name = "lbTimKiem"
        Me.lbTimKiem.Size = New System.Drawing.Size(49, 13)
        Me.lbTimKiem.TabIndex = 91
        Me.lbTimKiem.Text = "Tìm kiếm"
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
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lbBanVe
        '
        Me.lbBanVe.AutoSize = True
        Me.lbBanVe.Location = New System.Drawing.Point(154, 63)
        Me.lbBanVe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbBanVe.Name = "lbBanVe"
        Me.lbBanVe.Size = New System.Drawing.Size(90, 13)
        Me.lbBanVe.TabIndex = 93
        Me.lbBanVe.Text = "Chọn chuyến bay"
        '
        'btnChonChuyenBay
        '
        Me.btnChonChuyenBay.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnMua
        Me.btnChonChuyenBay.Location = New System.Drawing.Point(172, 18)
        Me.btnChonChuyenBay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChonChuyenBay.Name = "btnChonChuyenBay"
        Me.btnChonChuyenBay.Size = New System.Drawing.Size(41, 41)
        Me.btnChonChuyenBay.TabIndex = 6
        Me.btnChonChuyenBay.UseVisualStyleBackColor = True
        '
        'gbxThaoTac
        '
        Me.gbxThaoTac.Controls.Add(Me.lbBanVe)
        Me.gbxThaoTac.Controls.Add(Me.btnChonChuyenBay)
        Me.gbxThaoTac.Controls.Add(Me.lbTimKiem)
        Me.gbxThaoTac.Controls.Add(Me.btnTimKiem)
        Me.gbxThaoTac.Location = New System.Drawing.Point(8, 464)
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 122
        Me.gbxThaoTac.TabStop = False
        Me.gbxThaoTac.Text = "Thao tác"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnTimKiem
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiem.FlatAppearance.BorderSize = 0
        Me.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimKiem.Location = New System.Drawing.Point(71, 18)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(41, 41)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 5)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 124
        '
        'frmTraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxTTChuyenBay)
        Me.Controls.Add(Me.gbxDSChyenBay)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmTraCuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTraCuu"
        Me.gbxTTChuyenBay.ResumeLayout(False)
        Me.gbxTTChuyenBay.PerformLayout()
        Me.gbxDSChyenBay.ResumeLayout(False)
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label20 As Label
    Private WithEvents label18 As Label
    Private WithEvents cboSanBayDen As ComboBox
    Private WithEvents label19 As Label
    Private WithEvents txtMaChuyenBay As TextBox
    Private WithEvents gbxTTChuyenBay As GroupBox
    Private WithEvents dtpNgayKHDen As DateTimePicker
    Private WithEvents cboSanBayDi As ComboBox
    Private WithEvents dtpNgayKHTu As DateTimePicker
    Private WithEvents label15 As Label
    Private WithEvents label3 As Label
    Private WithEvents gbxDSChyenBay As GroupBox
    Private WithEvents label7 As Label
    Private WithEvents lbTimKiem As Label
    Private WithEvents btnThoat As Button
    Private WithEvents lbBanVe As Label
    Private WithEvents btnChonChuyenBay As Button
    Private WithEvents gbxThaoTac As GroupBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents panel1 As Panel
    Friend WithEvents lvTraCuu As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyDonGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyDonGia))
        Me.lbDonGia = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.cboSanBayDen = New System.Windows.Forms.ComboBox()
        Me.cboSanBayDi = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cboMaHangVe = New System.Windows.Forms.ComboBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.gbxTTMayBay = New System.Windows.Forms.GroupBox()
        Me.cboMaTuyenBay = New System.Windows.Forms.ComboBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.gboDSMayBay = New System.Windows.Forms.GroupBox()
        Me.lvDonGia = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.gbxTTMayBay.SuspendLayout()
        Me.gboDSMayBay.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.gbxThaoTac.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbDonGia
        '
        Me.lbDonGia.AutoSize = True
        Me.lbDonGia.Location = New System.Drawing.Point(193, 145)
        Me.lbDonGia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDonGia.Name = "lbDonGia"
        Me.lbDonGia.Size = New System.Drawing.Size(0, 13)
        Me.lbDonGia.TabIndex = 59
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(6, 84)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(68, 13)
        Me.label15.TabIndex = 55
        Me.label15.Text = "Sân bay đến"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(6, 53)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(58, 13)
        Me.label14.TabIndex = 56
        Me.label14.Text = "Sân bay đi"
        '
        'cboSanBayDen
        '
        Me.cboSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanBayDen.FormattingEnabled = True
        Me.cboSanBayDen.Location = New System.Drawing.Point(106, 79)
        Me.cboSanBayDen.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSanBayDen.Name = "cboSanBayDen"
        Me.cboSanBayDen.Size = New System.Drawing.Size(176, 21)
        Me.cboSanBayDen.TabIndex = 3
        '
        'cboSanBayDi
        '
        Me.cboSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanBayDi.FormattingEnabled = True
        Me.cboSanBayDi.Location = New System.Drawing.Point(106, 47)
        Me.cboSanBayDi.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSanBayDi.Name = "cboSanBayDi"
        Me.cboSanBayDi.Size = New System.Drawing.Size(176, 21)
        Me.cboSanBayDi.TabIndex = 2
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(106, 141)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(84, 20)
        Me.txtDonGia.TabIndex = 5
        '
        'cboMaHangVe
        '
        Me.cboMaHangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaHangVe.FormattingEnabled = True
        Me.cboMaHangVe.Location = New System.Drawing.Point(106, 110)
        Me.cboMaHangVe.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMaHangVe.Name = "cboMaHangVe"
        Me.cboMaHangVe.Size = New System.Drawing.Size(176, 21)
        Me.cboMaHangVe.TabIndex = 4
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(5, 145)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(44, 13)
        Me.label18.TabIndex = 44
        Me.label18.Text = "Đơn giá"
        '
        'gbxTTMayBay
        '
        Me.gbxTTMayBay.Controls.Add(Me.lbDonGia)
        Me.gbxTTMayBay.Controls.Add(Me.label15)
        Me.gbxTTMayBay.Controls.Add(Me.label14)
        Me.gbxTTMayBay.Controls.Add(Me.cboSanBayDen)
        Me.gbxTTMayBay.Controls.Add(Me.cboSanBayDi)
        Me.gbxTTMayBay.Controls.Add(Me.txtDonGia)
        Me.gbxTTMayBay.Controls.Add(Me.cboMaHangVe)
        Me.gbxTTMayBay.Controls.Add(Me.cboMaTuyenBay)
        Me.gbxTTMayBay.Controls.Add(Me.label18)
        Me.gbxTTMayBay.Controls.Add(Me.label20)
        Me.gbxTTMayBay.Controls.Add(Me.label19)
        Me.gbxTTMayBay.Location = New System.Drawing.Point(8, 57)
        Me.gbxTTMayBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTMayBay.Name = "gbxTTMayBay"
        Me.gbxTTMayBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTMayBay.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTMayBay.TabIndex = 58
        Me.gbxTTMayBay.TabStop = False
        Me.gbxTTMayBay.Text = "Thông tin đơn giá"
        '
        'cboMaTuyenBay
        '
        Me.cboMaTuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaTuyenBay.FormattingEnabled = True
        Me.cboMaTuyenBay.Location = New System.Drawing.Point(106, 16)
        Me.cboMaTuyenBay.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMaTuyenBay.Name = "cboMaTuyenBay"
        Me.cboMaTuyenBay.Size = New System.Drawing.Size(176, 21)
        Me.cboMaTuyenBay.TabIndex = 1
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 22)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(74, 13)
        Me.label20.TabIndex = 45
        Me.label20.Text = "Mã tuyến bay "
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(5, 117)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(68, 13)
        Me.label19.TabIndex = 46
        Me.label19.Text = "Tên hạng vé"
        '
        'gboDSMayBay
        '
        Me.gboDSMayBay.Controls.Add(Me.lvDonGia)
        Me.gboDSMayBay.Controls.Add(Me.label6)
        Me.gboDSMayBay.Controls.Add(Me.txtTimKiem)
        Me.gboDSMayBay.Controls.Add(Me.btnTimKiem)
        Me.gboDSMayBay.Location = New System.Drawing.Point(297, 57)
        Me.gboDSMayBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gboDSMayBay.Name = "gboDSMayBay"
        Me.gboDSMayBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gboDSMayBay.Size = New System.Drawing.Size(640, 489)
        Me.gboDSMayBay.TabIndex = 60
        Me.gboDSMayBay.TabStop = False
        Me.gboDSMayBay.Text = "Danh sách đơn giá"
        '
        'lvDonGia
        '
        Me.lvDonGia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDonGia.FullRowSelect = True
        Me.lvDonGia.GridLines = True
        Me.lvDonGia.HideSelection = False
        Me.lvDonGia.Location = New System.Drawing.Point(5, 47)
        Me.lvDonGia.MultiSelect = False
        Me.lvDonGia.Name = "lvDonGia"
        Me.lvDonGia.Size = New System.Drawing.Size(630, 435)
        Me.lvDonGia.TabIndex = 16
        Me.lvDonGia.UseCompatibleStateImageBehavior = False
        Me.lvDonGia.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Tuyến Bay"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã Hạng Vé"
        Me.ColumnHeader3.Width = 204
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Đơn Gía"
        Me.ColumnHeader4.Width = 179
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
        Me.txtTimKiem.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(359, 11)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(190, 24)
        Me.label2.TabIndex = 39
        Me.label2.Text = "QUẢN LÝ ĐƠN GIÁ"
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
        Me.panel1.TabIndex = 61
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
        Me.gbxThaoTac.TabIndex = 59
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
        Me.btnTimKiem.TabIndex = 10
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
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.UseVisualStyleBackColor = False
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
        'frmQuanLyDonGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxTTMayBay)
        Me.Controls.Add(Me.gboDSMayBay)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Name = "frmQuanLyDonGia"
        Me.Text = "frmQuanLyDonGia"
        Me.gbxTTMayBay.ResumeLayout(False)
        Me.gbxTTMayBay.PerformLayout()
        Me.gboDSMayBay.ResumeLayout(False)
        Me.gboDSMayBay.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lbDonGia As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents cboSanBayDen As ComboBox
    Private WithEvents cboSanBayDi As ComboBox
    Private WithEvents txtDonGia As TextBox
    Private WithEvents cboMaHangVe As ComboBox
    Private WithEvents label18 As Label
    Private WithEvents gbxTTMayBay As GroupBox
    Private WithEvents cboMaTuyenBay As ComboBox
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents gboDSMayBay As GroupBox
    Private WithEvents label6 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents btnThoat As Button
    Private WithEvents btnThem As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents gbxThaoTac As GroupBox
    Friend WithEvents lvDonGia As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class

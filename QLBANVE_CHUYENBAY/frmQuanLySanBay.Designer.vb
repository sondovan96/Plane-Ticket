<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySanBay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySanBay))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.gbxTTSanBay = New System.Windows.Forms.GroupBox()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txtTenThanhPho = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.txtMaSanBay = New System.Windows.Forms.TextBox()
        Me.txtTenSanBay = New System.Windows.Forms.TextBox()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.gbxDSSanBay = New System.Windows.Forms.GroupBox()
        Me.lvSanBay = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.gbxTTSanBay.SuspendLayout()
        Me.gbxThaoTac.SuspendLayout()
        Me.gbxDSSanBay.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(948, 47)
        Me.panel1.TabIndex = 56
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(359, 11)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(193, 24)
        Me.label2.TabIndex = 39
        Me.label2.Text = "QUẢN LÝ SÂN BAY"
        '
        'gbxTTSanBay
        '
        Me.gbxTTSanBay.Controls.Add(Me.btnLamMoi)
        Me.gbxTTSanBay.Controls.Add(Me.label18)
        Me.gbxTTSanBay.Controls.Add(Me.txtTenThanhPho)
        Me.gbxTTSanBay.Controls.Add(Me.label20)
        Me.gbxTTSanBay.Controls.Add(Me.label19)
        Me.gbxTTSanBay.Controls.Add(Me.txtMaSanBay)
        Me.gbxTTSanBay.Controls.Add(Me.txtTenSanBay)
        Me.gbxTTSanBay.Location = New System.Drawing.Point(11, 51)
        Me.gbxTTSanBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxTTSanBay.Name = "gbxTTSanBay"
        Me.gbxTTSanBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxTTSanBay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbxTTSanBay.Size = New System.Drawing.Size(285, 407)
        Me.gbxTTSanBay.TabIndex = 57
        Me.gbxTTSanBay.TabStop = False
        Me.gbxTTSanBay.Text = "Thông tin sân bay"
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Location = New System.Drawing.Point(200, 98)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 47
        Me.btnLamMoi.Text = "Làm Mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(8, 76)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(77, 13)
        Me.label18.TabIndex = 43
        Me.label18.Text = "Tên thành phố"
        '
        'txtTenThanhPho
        '
        Me.txtTenThanhPho.Location = New System.Drawing.Point(109, 72)
        Me.txtTenThanhPho.Name = "txtTenThanhPho"
        Me.txtTenThanhPho.Size = New System.Drawing.Size(166, 20)
        Me.txtTenThanhPho.TabIndex = 2
        Me.txtTenThanhPho.Tag = "2"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(8, 24)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(62, 13)
        Me.label20.TabIndex = 45
        Me.label20.Text = "Mã sân bay"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(8, 50)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(66, 13)
        Me.label19.TabIndex = 46
        Me.label19.Text = "Tên sân bay"
        '
        'txtMaSanBay
        '
        Me.txtMaSanBay.Location = New System.Drawing.Point(109, 20)
        Me.txtMaSanBay.Name = "txtMaSanBay"
        Me.txtMaSanBay.Size = New System.Drawing.Size(166, 20)
        Me.txtMaSanBay.TabIndex = 1
        Me.txtMaSanBay.Tag = ""
        '
        'txtTenSanBay
        '
        Me.txtTenSanBay.Location = New System.Drawing.Point(109, 46)
        Me.txtTenSanBay.Name = "txtTenSanBay"
        Me.txtTenSanBay.Size = New System.Drawing.Size(166, 20)
        Me.txtTenSanBay.TabIndex = 1
        Me.txtTenSanBay.Tag = ""
        '
        'gbxThaoTac
        '
        Me.gbxThaoTac.Controls.Add(Me.btnThem)
        Me.gbxThaoTac.Controls.Add(Me.label5)
        Me.gbxThaoTac.Controls.Add(Me.label4)
        Me.gbxThaoTac.Controls.Add(Me.label3)
        Me.gbxThaoTac.Controls.Add(Me.btnSua)
        Me.gbxThaoTac.Controls.Add(Me.btnXoa)
        Me.gbxThaoTac.Location = New System.Drawing.Point(11, 462)
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 58
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
        'gbxDSSanBay
        '
        Me.gbxDSSanBay.Controls.Add(Me.lvSanBay)
        Me.gbxDSSanBay.Controls.Add(Me.label6)
        Me.gbxDSSanBay.Controls.Add(Me.txtTimKiem)
        Me.gbxDSSanBay.Controls.Add(Me.btnTimKiem)
        Me.gbxDSSanBay.Location = New System.Drawing.Point(300, 51)
        Me.gbxDSSanBay.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDSSanBay.Name = "gbxDSSanBay"
        Me.gbxDSSanBay.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDSSanBay.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSSanBay.TabIndex = 59
        Me.gbxDSSanBay.TabStop = False
        Me.gbxDSSanBay.Text = "Danh sách sân bay"
        '
        'lvSanBay
        '
        Me.lvSanBay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvSanBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSanBay.FullRowSelect = True
        Me.lvSanBay.GridLines = True
        Me.lvSanBay.HideSelection = False
        Me.lvSanBay.Location = New System.Drawing.Point(5, 46)
        Me.lvSanBay.Name = "lvSanBay"
        Me.lvSanBay.Size = New System.Drawing.Size(630, 438)
        Me.lvSanBay.TabIndex = 16
        Me.lvSanBay.UseCompatibleStateImageBehavior = False
        Me.lvSanBay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Sân Bay"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên Sân Bay"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 252
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tên Thành phố"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 239
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
        Me.btnThem.Tag = ""
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
        Me.btnSua.Tag = ""
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
        Me.btnXoa.Tag = ""
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Silver
        Me.btnThoat.BackgroundImage = Global.QLBANVE_CHUYENBAY.My.Resources.Resources.btnCancel
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'frmQuanLySanBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxDSSanBay)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Controls.Add(Me.gbxTTSanBay)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmQuanLySanBay"
        Me.Text = "Thêm sân bay"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbxTTSanBay.ResumeLayout(False)
        Me.gbxTTSanBay.PerformLayout()
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.gbxDSSanBay.ResumeLayout(False)
        Me.gbxDSSanBay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label2 As Label
    Private WithEvents btnThoat As Button
    Private WithEvents gbxTTSanBay As GroupBox
    Private WithEvents label18 As Label
    Private WithEvents txtTenThanhPho As TextBox
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents txtTenSanBay As TextBox
    Private WithEvents gbxThaoTac As GroupBox
    Private WithEvents btnThem As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents gbxDSSanBay As GroupBox
    Private WithEvents label6 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents txtMaSanBay As TextBox
    Friend WithEvents lvSanBay As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnLamMoi As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTuyenBay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyTuyenBay))
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.gbxThaoTac = New System.Windows.Forms.GroupBox()
        Me.gbxDSTuyenBay = New System.Windows.Forms.GroupBox()
        Me.lvTuyenBay = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.gbxTTTuyenBay = New System.Windows.Forms.GroupBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.cboSanBayDen = New System.Windows.Forms.ComboBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.cboSanBayDi = New System.Windows.Forms.ComboBox()
        Me.txtMaTuyenBay = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.gbxThaoTac.SuspendLayout()
        Me.gbxDSTuyenBay.SuspendLayout()
        Me.gbxTTTuyenBay.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gbxThaoTac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxThaoTac.Name = "gbxThaoTac"
        Me.gbxThaoTac.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxThaoTac.Size = New System.Drawing.Size(285, 82)
        Me.gbxThaoTac.TabIndex = 50
        Me.gbxThaoTac.TabStop = False
        Me.gbxThaoTac.Text = "Thao tác"
        '
        'gbxDSTuyenBay
        '
        Me.gbxDSTuyenBay.Controls.Add(Me.lvTuyenBay)
        Me.gbxDSTuyenBay.Controls.Add(Me.label2)
        Me.gbxDSTuyenBay.Controls.Add(Me.txtTimKiem)
        Me.gbxDSTuyenBay.Controls.Add(Me.btnTimKiem)
        Me.gbxDSTuyenBay.Location = New System.Drawing.Point(297, 57)
        Me.gbxDSTuyenBay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDSTuyenBay.Name = "gbxDSTuyenBay"
        Me.gbxDSTuyenBay.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDSTuyenBay.Size = New System.Drawing.Size(640, 489)
        Me.gbxDSTuyenBay.TabIndex = 51
        Me.gbxDSTuyenBay.TabStop = False
        Me.gbxDSTuyenBay.Text = "Danh sách tuyến bay"
        '
        'lvTuyenBay
        '
        Me.lvTuyenBay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvTuyenBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTuyenBay.FullRowSelect = True
        Me.lvTuyenBay.GridLines = True
        Me.lvTuyenBay.HideSelection = False
        Me.lvTuyenBay.Location = New System.Drawing.Point(5, 51)
        Me.lvTuyenBay.Name = "lvTuyenBay"
        Me.lvTuyenBay.Size = New System.Drawing.Size(630, 433)
        Me.lvTuyenBay.TabIndex = 16
        Me.lvTuyenBay.UseCompatibleStateImageBehavior = False
        Me.lvTuyenBay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Tuyến Bay"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 131
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sân Bay Đi"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 214
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sân Bay Đến"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 224
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
        Me.txtTimKiem.TabIndex = 6
        '
        'gbxTTTuyenBay
        '
        Me.gbxTTTuyenBay.Controls.Add(Me.label20)
        Me.gbxTTTuyenBay.Controls.Add(Me.label18)
        Me.gbxTTTuyenBay.Controls.Add(Me.cboSanBayDen)
        Me.gbxTTTuyenBay.Controls.Add(Me.label19)
        Me.gbxTTTuyenBay.Controls.Add(Me.cboSanBayDi)
        Me.gbxTTTuyenBay.Controls.Add(Me.txtMaTuyenBay)
        Me.gbxTTTuyenBay.Location = New System.Drawing.Point(8, 57)
        Me.gbxTTTuyenBay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxTTTuyenBay.Name = "gbxTTTuyenBay"
        Me.gbxTTTuyenBay.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxTTTuyenBay.Size = New System.Drawing.Size(285, 402)
        Me.gbxTTTuyenBay.TabIndex = 49
        Me.gbxTTTuyenBay.TabStop = False
        Me.gbxTTTuyenBay.Text = "Thông tin tuyến bay"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(5, 27)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(74, 13)
        Me.label20.TabIndex = 15
        Me.label20.Text = "Mã tuyến bay "
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
        Me.cboSanBayDen.Location = New System.Drawing.Point(130, 80)
        Me.cboSanBayDen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'cboSanBayDi
        '
        Me.cboSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanBayDi.FormattingEnabled = True
        Me.cboSanBayDi.Location = New System.Drawing.Point(130, 51)
        Me.cboSanBayDi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboSanBayDi.Name = "cboSanBayDi"
        Me.cboSanBayDi.Size = New System.Drawing.Size(151, 21)
        Me.cboSanBayDi.TabIndex = 1
        '
        'txtMaTuyenBay
        '
        Me.txtMaTuyenBay.Location = New System.Drawing.Point(130, 23)
        Me.txtMaTuyenBay.Name = "txtMaTuyenBay"
        Me.txtMaTuyenBay.ReadOnly = True
        Me.txtMaTuyenBay.Size = New System.Drawing.Size(151, 20)
        Me.txtMaTuyenBay.TabIndex = 17
        Me.txtMaTuyenBay.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(359, 11)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(220, 24)
        Me.label1.TabIndex = 39
        Me.label1.Text = "QUẢN LÝ TUYẾN BAY"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 5)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 52
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
        'frmQuanLyTuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.gbxThaoTac)
        Me.Controls.Add(Me.gbxDSTuyenBay)
        Me.Controls.Add(Me.gbxTTTuyenBay)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmQuanLyTuyenBay"
        Me.Text = "frmQuanLyTuyenBay"
        Me.gbxThaoTac.ResumeLayout(False)
        Me.gbxThaoTac.PerformLayout()
        Me.gbxDSTuyenBay.ResumeLayout(False)
        Me.gbxDSTuyenBay.PerformLayout()
        Me.gbxTTTuyenBay.ResumeLayout(False)
        Me.gbxTTTuyenBay.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnThem As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents btnXoa As Button
    Private WithEvents gbxThaoTac As GroupBox
    Private WithEvents btnSua As Button
    Private WithEvents btnThoat As Button
    Private WithEvents gbxDSTuyenBay As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents gbxTTTuyenBay As GroupBox
    Private WithEvents label20 As Label
    Private WithEvents label18 As Label
    Private WithEvents cboSanBayDen As ComboBox
    Private WithEvents label19 As Label
    Private WithEvents cboSanBayDi As ComboBox
    Private WithEvents txtMaTuyenBay As TextBox
    Private WithEvents label1 As Label
    Private WithEvents panel1 As Panel
    Friend WithEvents lvTuyenBay As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class

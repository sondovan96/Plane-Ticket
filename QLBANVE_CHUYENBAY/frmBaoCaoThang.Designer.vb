<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoThang
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtpThangNam = New System.Windows.Forms.DateTimePicker()
        Me.btnXemBaoCao = New System.Windows.Forms.Button()
        Me.crBaoCaoThang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(948, 47)
        Me.panel1.TabIndex = 122
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(359, 11)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(181, 24)
        Me.label7.TabIndex = 39
        Me.label7.Text = "BÁO CÁO THÁNG"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.crBaoCaoThang)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(948, 504)
        Me.Panel2.TabIndex = 123
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.label1)
        Me.Panel3.Controls.Add(Me.dtpThangNam)
        Me.Panel3.Controls.Add(Me.btnXemBaoCao)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(948, 37)
        Me.Panel3.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(324, 12)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 126
        Me.label1.Text = "Tháng năm"
        '
        'dtpThangNam
        '
        Me.dtpThangNam.CustomFormat = "MM/yyyy"
        Me.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangNam.Location = New System.Drawing.Point(388, 9)
        Me.dtpThangNam.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpThangNam.Name = "dtpThangNam"
        Me.dtpThangNam.Size = New System.Drawing.Size(84, 20)
        Me.dtpThangNam.TabIndex = 125
        '
        'btnXemBaoCao
        '
        Me.btnXemBaoCao.AutoSize = True
        Me.btnXemBaoCao.Location = New System.Drawing.Point(477, 5)
        Me.btnXemBaoCao.Name = "btnXemBaoCao"
        Me.btnXemBaoCao.Size = New System.Drawing.Size(80, 28)
        Me.btnXemBaoCao.TabIndex = 124
        Me.btnXemBaoCao.Text = "Xem báo cáo"
        Me.btnXemBaoCao.UseVisualStyleBackColor = True
        '
        'crBaoCaoThang
        '
        Me.crBaoCaoThang.ActiveViewIndex = -1
        Me.crBaoCaoThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Default
        Me.crBaoCaoThang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crBaoCaoThang.Location = New System.Drawing.Point(0, 37)
        Me.crBaoCaoThang.Name = "crBaoCaoThang"
        Me.crBaoCaoThang.Size = New System.Drawing.Size(948, 467)
        Me.crBaoCaoThang.TabIndex = 1
        Me.crBaoCaoThang.ToolPanelWidth = 150
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
        Me.btnThoat.TabIndex = 40
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmBaoCaoThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmBaoCaoThang"
        Me.Text = "frmBaoCaoThang"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label7 As Label
    Private WithEvents btnThoat As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents crBaoCaoThang As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel3 As Panel
    Private WithEvents label1 As Label
    Private WithEvents dtpThangNam As DateTimePicker
    Private WithEvents btnXemBaoCao As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoNam
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtpNam = New System.Windows.Forms.DateTimePicker()
        Me.crBaoCaoNam = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnXemBaoCao = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Silver
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.btnThoat)
        Me.panel1.Location = New System.Drawing.Point(-4, 4)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(957, 47)
        Me.panel1.TabIndex = 131
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(359, 11)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(155, 24)
        Me.label7.TabIndex = 39
        Me.label7.Text = "BÁO CÁO NĂM"
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(327, 60)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 133
        Me.label1.Text = "Năm"
        '
        'dtpNam
        '
        Me.dtpNam.CustomFormat = "yyyy"
        Me.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNam.Location = New System.Drawing.Point(359, 58)
        Me.dtpNam.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNam.Name = "dtpNam"
        Me.dtpNam.Size = New System.Drawing.Size(94, 20)
        Me.dtpNam.TabIndex = 132
        '
        'crBaoCaoNam
        '
        Me.crBaoCaoNam.ActiveViewIndex = -1
        Me.crBaoCaoNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crBaoCaoNam.Cursor = System.Windows.Forms.Cursors.Default
        Me.crBaoCaoNam.Location = New System.Drawing.Point(5, 84)
        Me.crBaoCaoNam.Margin = New System.Windows.Forms.Padding(2)
        Me.crBaoCaoNam.Name = "crBaoCaoNam"
        Me.crBaoCaoNam.Size = New System.Drawing.Size(936, 462)
        Me.crBaoCaoNam.TabIndex = 130
        Me.crBaoCaoNam.ToolPanelWidth = 150
        '
        'btnXemBaoCao
        '
        Me.btnXemBaoCao.AutoSize = True
        Me.btnXemBaoCao.Location = New System.Drawing.Point(457, 57)
        Me.btnXemBaoCao.Name = "btnXemBaoCao"
        Me.btnXemBaoCao.Size = New System.Drawing.Size(80, 23)
        Me.btnXemBaoCao.TabIndex = 129
        Me.btnXemBaoCao.Text = "Xem báo cáo"
        Me.btnXemBaoCao.UseVisualStyleBackColor = True
        '
        'frmBaoCaoNam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 551)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dtpNam)
        Me.Controls.Add(Me.crBaoCaoNam)
        Me.Controls.Add(Me.btnXemBaoCao)
        Me.Name = "frmBaoCaoNam"
        Me.Text = "frmBaoCaoNam"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label7 As Label
    Private WithEvents btnThoat As Button
    Private WithEvents label1 As Label
    Private WithEvents dtpNam As DateTimePicker
    Friend WithEvents crBaoCaoNam As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Private WithEvents btnXemBaoCao As Button
End Class

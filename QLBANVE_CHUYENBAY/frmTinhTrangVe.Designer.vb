<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinhTrangVe
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
        Me.cboMaChuyenBay = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lvTinhTrangVe = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'cboMaChuyenBay
        '
        Me.cboMaChuyenBay.FormattingEnabled = True
        Me.cboMaChuyenBay.Location = New System.Drawing.Point(187, 44)
        Me.cboMaChuyenBay.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMaChuyenBay.Name = "cboMaChuyenBay"
        Me.cboMaChuyenBay.Size = New System.Drawing.Size(114, 21)
        Me.cboMaChuyenBay.TabIndex = 41
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(120, 9)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(169, 24)
        Me.label8.TabIndex = 44
        Me.label8.Text = "TÌNH TRẠNG VÉ"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(90, 47)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 13)
        Me.label2.TabIndex = 42
        Me.label2.Text = "Mã chuyến bay"
        '
        'lvTinhTrangVe
        '
        Me.lvTinhTrangVe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvTinhTrangVe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTinhTrangVe.FullRowSelect = True
        Me.lvTinhTrangVe.GridLines = True
        Me.lvTinhTrangVe.HideSelection = False
        Me.lvTinhTrangVe.Location = New System.Drawing.Point(13, 81)
        Me.lvTinhTrangVe.MultiSelect = False
        Me.lvTinhTrangVe.Name = "lvTinhTrangVe"
        Me.lvTinhTrangVe.Size = New System.Drawing.Size(383, 273)
        Me.lvTinhTrangVe.TabIndex = 45
        Me.lvTinhTrangVe.UseCompatibleStateImageBehavior = False
        Me.lvTinhTrangVe.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 44
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Hạng Vé"
        Me.ColumnHeader2.Width = 111
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tổng Số Ghế"
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Số Ghế Trống"
        Me.ColumnHeader4.Width = 113
        '
        'frmTinhTrangVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 366)
        Me.Controls.Add(Me.lvTinhTrangVe)
        Me.Controls.Add(Me.cboMaChuyenBay)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label2)
        Me.Name = "frmTinhTrangVe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTinhTrangVe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboMaChuyenBay As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents label2 As Label
    Friend WithEvents lvTinhTrangVe As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class

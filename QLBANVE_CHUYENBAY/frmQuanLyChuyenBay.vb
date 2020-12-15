Imports BUS
Imports DTO
Public Class frmQuanLyChuyenBay
    Dim chuyenbayBUS As BUS_ChuyenBay
    Dim chuyenbayDTO As DTO_ChuyenBay
    Dim ctchuyenbayBUS As BUS_CTChuyenBay
    Dim ctchuyenbayDTO As DTO_CTChuyenBay
    Dim ttvBUS As BUS_TinhTrangVe
    Dim ttvDTO As DTO_TinhTrangVe
    Dim hangveBUS
    Dim hangveDTO As DTO_HangVe
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        chuyenbayBUS = New BUS_ChuyenBay()
        ctchuyenbayBUS = New BUS_CTChuyenBay()
        ttvBUS = New BUS_TinhTrangVe()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadlvChuyenBay()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = chuyenbayBUS.selectAll()
        lvDSChuyenBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvcb As ListViewItem
            lvcb = lvDSChuyenBay.Items.Add(stt)
            lvcb.SubItems.Add(dt.Rows(i)(0).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(1).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(2).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(3).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(4).ToString)
            stt += 1
        Next
    End Sub
    Private Sub loadcbChuyenBay()
        Dim tuyenbayBUS As New BUS_TuyenBay()
        Dim maybayBUS As New BUS_MayBay()
        Dim hangveBUS As New BUS_HangVe()
        Dim sanbayBUS As New BUS_SanBay()


        Dim dtTuyenBay As New DataTable
        Dim dtMayBay As New DataTable
        Dim dtHangVe As New DataTable

        dtTuyenBay = tuyenbayBUS.selectAll()
        dtMayBay = maybayBUS.selectAll()
        dtHangVe = hangveBUS.SelectAll()

        dtTuyenBay.Rows.Add("Mã Tuyến Bay")
        cboMaTuyenBay.DataSource = dtTuyenBay
        cboMaTuyenBay.DisplayMember = "MATUYENBAY"
        cboMaTuyenBay.ValueMember = "MATUYENBAY"

        dtMayBay.Rows.Add("Mã Máy Bay")
        cboMaMayBay.DataSource = dtMayBay
        cboMaMayBay.DisplayMember = "MAMAYBAY"
        cboMaMayBay.ValueMember = "MAMAYBAY"

        cboMaHangVe.DataSource = dtHangVe
        cboMaHangVe.DisplayMember = "TENHANGVE"
        cboMaHangVe.ValueMember = "MAHANGVE"

        Dim dtSanBayDi As New DataTable
        dtSanBayDi = sanbayBUS.selectAll()
        dtSanBayDi.Rows.Add(-1, "Sân Bay Đi")
        cboSanBayDi.DataSource = dtSanBayDi
        cboSanBayDi.DisplayMember = "TENSANBAY"
        cboSanBayDi.ValueMember = "MASANBAY"


        Dim dtSanBayDen As New DataTable
        dtSanBayDen = sanbayBUS.selectAll()
        dtSanBayDen.Rows.Add(-1, "Sân Bay Đến")
        cboSanBayDen.DataSource = dtSanBayDen
        cboSanBayDen.DisplayMember = "TENSANBAY"
        cboSanBayDen.ValueMember = "MASANBAY"

        Dim dtSanBayTG As New DataTable
        dtSanBayTG = sanbayBUS.selectAll()
        dtSanBayTG.Rows.Add(-1, "Sân Bay TG")
        cboTenSanBayTG.DataSource = dtSanBayTG
        cboTenSanBayTG.DisplayMember = "TENSANBAY"
        cboTenSanBayTG.ValueMember = "MASANBAY"

        gbxThemHangVeChoChuyenBay.Enabled = False
        gbxThemSanBayTGChoChuyenBay.Enabled = False

    End Sub
    Private Sub setDefault()
        cboMaTuyenBay.Text = "Mã Tuyến Bay"
        cboMaMayBay.Text = "Mã Máy bay"
        cboTenSanBayTG.Text = "Sân Bay TG"
    End Sub
    Private Sub LamMoi()
        txtMaChuyenBay.ResetText()
        setDefault()
        dtpkThoiGianKhoiHanh.ResetText()
        txtThoiGianBay.ResetText()
    End Sub

    Private Sub frmQuanLyChuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadlvChuyenBay()
        loadcbChuyenBay()
        txtMaChuyenBay.Enabled = False
        cboSanBayDi.Enabled = False
        cboSanBayDen.Enabled = False
        setDefault()

    End Sub

    Private Sub lvDSChuyenBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDSChuyenBay.SelectedIndexChanged
        If lvDSChuyenBay.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvDSChuyenBay.SelectedItems
                txtMaChuyenBay.Text = item.SubItems(1).Text
                cboMaTuyenBay.Text = item.SubItems(2).Text
                cboMaMayBay.Text = item.SubItems(3).Text
                dtpkThoiGianKhoiHanh.Value = item.SubItems(4).Text
                txtThoiGianBay.Text = item.SubItems(5).Text
            Next
            gbxThemHangVeChoChuyenBay.Enabled = True
            gbxThemSanBayTGChoChuyenBay.Enabled = True
            loadlvHangve()
            loadlvSBTG()
        Else
            gbxThemHangVeChoChuyenBay.Enabled = False
            gbxThemSanBayTGChoChuyenBay.Enabled = False
        End If
    End Sub


    Private Sub cboMaTuyenBay_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMaTuyenBay.SelectionChangeCommitted
        If IsDBNull(cboMaTuyenBay.SelectedValue) = False Then
            Dim tuyenbayBUS As New BUS_TuyenBay()
            Dim dtTuyenBay As New DataTable
            dtTuyenBay = tuyenbayBUS.SelectOfMaTuyenBay(cboMaTuyenBay.SelectedValue.ToString())
            If (dtTuyenBay.Rows.Count = 0) Then
                Return
            End If
            cboSanBayDi.Text = dtTuyenBay.Rows(0)("TENSANBAYDI").ToString()
            cboSanBayDi.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDI").ToString()
            cboSanBayDen.Text = dtTuyenBay.Rows(0)("TENSANBAYDEN").ToString()
            cboSanBayDen.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDEN").ToString()
        End If
    End Sub

    'Private Sub cboSanBayDi_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSanBayDi.SelectionChangeCommitted
    '    Dim tuyenbayBUS As New BUS_TuyenBay()
    '    Dim dtTuyenBay As New DataTable
    '    dtTuyenBay = tuyenbayBUS.SelectOfMaSanBay(cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString())
    '    If (dtTuyenBay.Rows.Count = 0) Then
    '        cboMaTuyenBay.Text = ""    
    '    Else
    '        cboMaTuyenBay.Text = dtTuyenBay.Rows(0)("MATUYENBAY").ToString()
    '    End If
    'End Sub

    Private Sub cboMaTuyenBay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaTuyenBay.SelectedIndexChanged
        If cboMaTuyenBay.Text = "Mã Tuyến Bay" Then
            cboSanBayDi.Text = "Sân Bay Đi"
            cboSanBayDen.Text = "Sân Bay Đến"
        End If
        If IsDBNull(cboMaTuyenBay.SelectedValue) = False Then
            Dim tuyenbayBUS As New BUS_TuyenBay()
            Dim dtTuyenBay As New DataTable
            dtTuyenBay = tuyenbayBUS.SelectOfMaTuyenBay(cboMaTuyenBay.SelectedValue.ToString())
            If (dtTuyenBay.Rows.Count = 0) Then
                Return
            End If
            cboSanBayDi.Text = dtTuyenBay.Rows(0)("TENSANBAYDI").ToString()
            cboSanBayDi.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDI").ToString()
            cboSanBayDen.Text = dtTuyenBay.Rows(0)("TENSANBAYDEN").ToString()
            cboSanBayDen.SelectedValue = dtTuyenBay.Rows(0)("MASANBAYDEN").ToString()
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim thamsoBUS As New BUS_ThamSo()
        Dim dtThamso As New DataTable
        Dim tgtoithieu As Integer
        dtThamso = thamsoBUS.selectAll()
        tgtoithieu = dtThamso.Rows(0)(0).ToString

        If txtThoiGianBay.Text > tgtoithieu Then
            If (txtThoiGianBay.Text.Trim() <> "") Then
                If MessageBox.Show("Xác nhận thêm chuyến bay?", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                    Try
                        chuyenbayDTO = New DTO_ChuyenBay(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, dtpkThoiGianKhoiHanh.Value, txtThoiGianBay.Text)
                        If chuyenbayBUS.AddChuyenBay(chuyenbayDTO) = True Then
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        LamMoi()
                    End Try
                End If
            Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(String.Format("Quy định thời gian bay tối thiểu là {0} phút!", tgtoithieu), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        loadlvChuyenBay()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If (txtMaChuyenBay.Text.Trim() <> "") Then
            Dim thamsoBUS As New BUS_ThamSo()
            Dim dtThamso As New DataTable
            Dim tgtoithieu As Integer
            dtThamso = thamsoBUS.selectAll()
            tgtoithieu = dtThamso.Rows(0)(0).ToString

            If txtThoiGianBay.Text > tgtoithieu Then
                If (txtThoiGianBay.Text.Trim() <> "") Then
                    If MessageBox.Show("Xác nhận sửa chuyến bay?", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                        Try
                            chuyenbayDTO = New DTO_ChuyenBay(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, dtpkThoiGianKhoiHanh.Value, txtThoiGianBay.Text)
                            If (chuyenbayBUS.Update(chuyenbayDTO)) Then
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            LamMoi()
                        End Try
                    End If
                Else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(String.Format("Quy định thời gian bay tối thiểu là {0} phút!", tgtoithieu), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvChuyenBay()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If (txtMaChuyenBay.Text.Trim() <> "") Then
            If MessageBox.Show("Xác nhận xoá chuyến bay?", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = vbOK Then
                Try
                    If chuyenbayBUS.Delete(txtMaChuyenBay.Text) = True Then
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LamMoi()
                End Try
            End If
        Else
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvChuyenBay()
    End Sub



    Private Sub loadlvHangve()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = ttvBUS.HienThiTheoMaChuyenBay(txtMaChuyenBay.Text)
        lvDSHangVe.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvhv As ListViewItem
            lvhv = lvDSHangVe.Items.Add(stt)
            lvhv.SubItems.Add(dt.Rows(i)(0))
            lvhv.SubItems.Add(dt.Rows(i)(1))
            lvhv.SubItems.Add(dt.Rows(i)(2))
            stt += 1
        Next
    End Sub


    Private Sub btnThemHV_Click(sender As Object, e As EventArgs) Handles btnThemHV.Click
        If txtTongSoGhe.Text <> "" Then
            Try
                ttvDTO = New DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtTongSoGhe.Text, txtTongSoGhe.Text)
                If (ttvBUS.AddTinhTrangVe(ttvDTO)) Then
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                txtTongSoGhe.ResetText()
            End Try
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvHangve()
    End Sub

    Private Sub lvDSHangVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDSHangVe.SelectedIndexChanged
        If lvDSHangVe.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvDSHangVe.SelectedItems
                cboMaHangVe.Text = item.SubItems(1).Text
                txtTongSoGhe.Text = item.SubItems(2).Text
            Next
        End If
    End Sub

    Private Sub btnSuaHV_Click(sender As Object, e As EventArgs) Handles btnSuaHV.Click
        If lvDSHangVe.SelectedIndices.Count > 0 Then
            If txtTongSoGhe.Text <> "" Then
                Try
                    ttvDTO = New DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtTongSoGhe.Text, txtTongSoGhe.Text)
                    If ttvBUS.Update(ttvDTO) = True Then
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    txtTongSoGhe.ResetText()
                End Try
            Else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvHangve()
    End Sub

    Private Sub btnXoaHV_Click(sender As Object, e As EventArgs) Handles btnXoaHV.Click
        If lvDSHangVe.SelectedIndices.Count > 0 Then
            Try
                ttvDTO = New DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), txtTongSoGhe.Text, txtTongSoGhe.Text)
                If ttvBUS.Delete(ttvDTO) = True Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                txtTongSoGhe.ResetText()
            End Try
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvHangve()
    End Sub

    Private Sub loadlvSBTG()
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = ctchuyenbayBUS.HienThiTheoMaChuyenBay(txtMaChuyenBay.Text)
        lvSBTG.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvSB As ListViewItem
            lvSB = lvSBTG.Items.Add(stt)
            lvSB.SubItems.Add(dt.Rows(i)(0).ToString)
            lvSB.SubItems.Add(dt.Rows(i)(1).ToString)
            lvSB.SubItems.Add(dt.Rows(i)(2).ToString)
        Next
    End Sub
    Private Sub LamMoiSBTG()
        txtGhiChu.ResetText()
        txtThoiGianNghi.ResetText()
        cboTenSanBayTG.Text = "Sân Bay TG"
    End Sub

    Private Sub btnThemSBTG_Click(sender As Object, e As EventArgs) Handles btnThemSBTG.Click
        Dim thamsoBUS As New BUS_ThamSo()
        Dim dtThamso As New DataTable
        Dim sanbaytgtoida As Integer
        Dim tgdungtoithieu As Integer
        Dim tgdungtoida As Integer
        dtThamso = thamsoBUS.selectAll()
        sanbaytgtoida = dtThamso.Rows(0)(1).ToString
        tgdungtoithieu = dtThamso.Rows(0)(2).ToString
        tgdungtoida = dtThamso.Rows(0)(3).ToString
        If lvSBTG.Items.Count < sanbaytgtoida Then
            If tgdungtoithieu <= txtThoiGianNghi.Text And txtThoiGianNghi.Text <= tgdungtoida Then


                If (txtThoiGianNghi.Text <> "" AndAlso txtGhiChu.Text <> "") Then
                    Try
                        ctchuyenbayDTO = New DTO_CTChuyenBay(txtMaChuyenBay.Text, cboTenSanBayTG.SelectedValue.ToString(), txtThoiGianNghi.Text, txtGhiChu.Text)
                        If ctchuyenbayBUS.AddCTChuyenBay(ctchuyenbayDTO) = True Then
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        LamMoiSBTG()
                    End Try
                Else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(String.Format("Quy định {0} <= thời gian dừng <= {1}!", tgdungtoithieu, tgdungtoida), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(String.Format("Quy định chỉ nhập tối đa {0} sân bay trung gian!", sanbaytgtoida), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvSBTG()
    End Sub

    Private Sub btnSuaSBTG_Click(sender As Object, e As EventArgs) Handles btnSuaSBTG.Click
        If lvSBTG.SelectedIndices.Count > 0 Then
            Dim thamsoBUS As New BUS_ThamSo()
            Dim dtThamso As New DataTable
            Dim sanbaytgtoida As Integer
            Dim tgdungtoithieu As Integer
            Dim tgdungtoida As Integer
            dtThamso = thamsoBUS.selectAll()
            sanbaytgtoida = dtThamso.Rows(0)(1).ToString
            tgdungtoithieu = dtThamso.Rows(0)(2).ToString
            tgdungtoida = dtThamso.Rows(0)(3).ToString

            If tgdungtoithieu <= txtThoiGianNghi.Text And txtThoiGianNghi.Text <= tgdungtoida Then
                If txtThoiGianNghi.Text <> "" AndAlso txtGhiChu.Text <> "" Then
                    Try
                        ctchuyenbayDTO = New DTO_CTChuyenBay(txtMaChuyenBay.Text, cboTenSanBayTG.SelectedValue.ToString(), txtThoiGianNghi.Text, txtGhiChu.Text)
                        If ctchuyenbayBUS.Update(ctchuyenbayDTO) = True Then
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        LamMoiSBTG()
                    End Try
                Else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(String.Format("Quy định {0} <= thời gian dừng <= {1}!", tgdungtoithieu, tgdungtoida), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
                    MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvSBTG()
    End Sub

    Private Sub btnXoaSBTG_Click(sender As Object, e As EventArgs) Handles btnXoaSBTG.Click
        If lvSBTG.SelectedIndices.Count > 0 Then
            Try
                ctchuyenbayDTO = New DTO_CTChuyenBay(txtMaChuyenBay.Text, cboTenSanBayTG.SelectedValue.ToString(), txtThoiGianNghi.Text, txtGhiChu.Text)
                If ctchuyenbayBUS.Delete(ctchuyenbayDTO) = True Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                LamMoiSBTG()
            End Try
        Else
            MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadlvSBTG()
    End Sub

    Private Sub lvSBTG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSBTG.SelectedIndexChanged
        If lvSBTG.SelectedIndices.Count > 0 Then
            For Each item As ListViewItem In lvSBTG.SelectedItems
                cboTenSanBayTG.Text = item.SubItems(1).Text
                txtThoiGianNghi.Text = item.SubItems(2).Text
                txtGhiChu.Text = item.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim dt As New DataTable
        Dim stt As Integer = 1
        dt = chuyenbayBUS.TimKiemTheoMaChuyenBay(txtTimKiem.Text)
        lvDSChuyenBay.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim lvcb As ListViewItem
            lvcb = lvDSChuyenBay.Items.Add(stt)
            lvcb.SubItems.Add(dt.Rows(i)(0).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(1).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(2).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(3).ToString)
            lvcb.SubItems.Add(dt.Rows(i)(4).ToString)
            stt += 1
        Next
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub

    Private Sub txtThoiGianBay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThoiGianBay.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTongSoGhe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTongSoGhe.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtThoiGianNghi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThoiGianNghi.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
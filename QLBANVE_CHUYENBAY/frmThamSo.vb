Imports BUS
Imports DTO
Public Class frmThamSo
    Dim thamsoBUS As BUS_ThamSo
    Dim thamsoDTO As DTO_ThamSo
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        thamsoBUS = New BUS_ThamSo()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmThamSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KhoiTao()
    End Sub
    Public Sub KhoiTao()
        Dim dtThamSo As New DataTable
        dtThamSo = thamsoBUS.selectAll()
        For i = 0 To dtThamSo.Rows.Count - 1
            txtTGBayMin.Text = dtThamSo.Rows(i)(0).ToString
            txtSoSanBayTGMax.Text = dtThamSo.Rows(i)(1).ToString
            txtTGDungMin.Text = dtThamSo.Rows(i)(2).ToString
            txtTGDungMax.Text = dtThamSo.Rows(i)(3).ToString
            txtTGMinDatVe.Text = dtThamSo.Rows(i)(4).ToString
            txtTGMinHuyVe.Text = dtThamSo.Rows(i)(5).ToString
            txtSanBayToiDa.Text = dtThamSo.Rows(i)(6).ToString
        Next

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtSoSanBayTGMax.Text.Trim() <> "" AndAlso txtTGBayMin.Text.Trim() <> "" AndAlso txtTGDungMax.Text.Trim() <> "" AndAlso txtTGDungMin.Text.Trim() <> "" AndAlso txtTGMinDatVe.Text.Trim() <> "" AndAlso txtTGMinHuyVe.Text.Trim() <> "" Then
            Try
                thamsoDTO = New DTO_ThamSo(txtTGBayMin.Text, txtSoSanBayTGMax.Text, txtTGDungMin.Text, txtTGDungMax.Text, txtTGMinDatVe.Text, txtTGMinHuyVe.Text, txtSanBayToiDa.Text)
                If thamsoBUS.Update(thamsoDTO) = True Then
                    MessageBox.Show("Cập nhật công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        KhoiTao()
    End Sub

    Private Sub txtTGBayMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTGBayMin.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoSanBayTGMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoSanBayTGMax.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSanBayToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSanBayToiDa.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTGDungMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTGDungMin.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTGDungMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTGDungMax.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTGMinDatVe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTGMinDatVe.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTGMinHuyVe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTGMinHuyVe.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
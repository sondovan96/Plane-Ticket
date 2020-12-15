Public Class DTO_DonGia
    Dim MaTuyenBay As String
    Dim MaHangVe As String
    Dim DonGia As Double

    Public Sub New()
    End Sub

    Public Sub New(maTuyenBay As String, maHangVe As String, donGia As Double)
        Me.MaTuyenBay = maTuyenBay
        Me.MaHangVe = maHangVe
        Me.DonGia = donGia
    End Sub

    Public Property MaTuyenBay1 As String
        Get
            Return MaTuyenBay
        End Get
        Set(value As String)
            MaTuyenBay = value
        End Set
    End Property

    Public Property MaHangVe1 As String
        Get
            Return MaHangVe
        End Get
        Set(value As String)
            MaHangVe = value
        End Set
    End Property

    Public Property DonGia1 As Double
        Get
            Return DonGia
        End Get
        Set(value As Double)
            DonGia = value
        End Set
    End Property
End Class

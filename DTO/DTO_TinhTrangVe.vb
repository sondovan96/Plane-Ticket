Public Class DTO_TinhTrangVe
    Dim MaChuyenBay As String
    Dim MaHangVe As String
    Dim TongSoGhe As Integer
    Dim SoGheDat As Integer

    Public Sub New()
    End Sub

    Public Sub New(maChuyenBay As String, maHangVe As String, tongSoGhe As Integer, soGheDat As Integer)
        Me.MaChuyenBay = maChuyenBay
        Me.MaHangVe = maHangVe
        Me.TongSoGhe = tongSoGhe
        Me.SoGheDat = soGheDat
    End Sub

    Public Property MaChuyenBay1 As String
        Get
            Return MaChuyenBay
        End Get
        Set(value As String)
            MaChuyenBay = value
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

    Public Property TongSoGhe1 As Integer
        Get
            Return TongSoGhe
        End Get
        Set(value As Integer)
            TongSoGhe = value
        End Set
    End Property

    Public Property SoGheDat1 As Integer
        Get
            Return SoGheDat
        End Get
        Set(value As Integer)
            SoGheDat = value
        End Set
    End Property
End Class

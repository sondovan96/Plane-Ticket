Public Class DTO_VeChuyenBay
    Dim MaVe As String
    Dim MaKhachHang As String
    Dim MaChuyenBay As String
    Dim MaHangVe As String
    Dim GiaTien As Double
    Dim NgayHuy As String
    Dim MaNhanVien As String
    Dim NgayGioGD As DateTime
    Dim LoaiVe As String

    Public Sub New()
    End Sub

    Public Sub New(maVe As String, maKhachHang As String, maChuyenBay As String, maHangVe As String, giaTien As Double, ngayHuy As String, maNhanVien As String, ngayGioGD As Date, loaiVe As String)
        Me.MaVe = maVe
        Me.MaKhachHang = maKhachHang
        Me.MaChuyenBay = maChuyenBay
        Me.MaHangVe = maHangVe
        Me.GiaTien = giaTien
        Me.NgayHuy = ngayHuy
        Me.MaNhanVien = maNhanVien
        Me.NgayGioGD = ngayGioGD
        Me.LoaiVe = loaiVe
    End Sub

    Public Property MaVe1 As String
        Get
            Return MaVe
        End Get
        Set(value As String)
            MaVe = value
        End Set
    End Property

    Public Property MaKhachHang1 As String
        Get
            Return MaKhachHang
        End Get
        Set(value As String)
            MaKhachHang = value
        End Set
    End Property

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

    Public Property GiaTien1 As Double
        Get
            Return GiaTien
        End Get
        Set(value As Double)
            GiaTien = value
        End Set
    End Property

    Public Property NgayHuy1 As String
        Get
            Return NgayHuy
        End Get
        Set(value As String)
            NgayHuy = value
        End Set
    End Property

    Public Property MaNhanVien1 As String
        Get
            Return MaNhanVien
        End Get
        Set(value As String)
            MaNhanVien = value
        End Set
    End Property

    Public Property NgayGioGD1 As Date
        Get
            Return NgayGioGD
        End Get
        Set(value As Date)
            NgayGioGD = value
        End Set
    End Property

    Public Property LoaiVe1 As String
        Get
            Return LoaiVe
        End Get
        Set(value As String)
            LoaiVe = value
        End Set
    End Property
End Class

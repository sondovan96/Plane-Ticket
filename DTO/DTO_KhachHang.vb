Public Class DTO_KhachHang
    Dim MaKhachHang As String
    Dim TenKhachHang As String
    Dim CMND As String
    Dim SDT As String

    Public Sub New()
    End Sub

    Public Sub New(maKhachHang As String, tenKhachHang As String, cMND As String, sDT As String)
        Me.MaKhachHang = maKhachHang
        Me.TenKhachHang = tenKhachHang
        Me.CMND = cMND
        Me.SDT = sDT
    End Sub

    Public Property MaKhachHang1 As String
        Get
            Return MaKhachHang
        End Get
        Set(value As String)
            MaKhachHang = value
        End Set
    End Property

    Public Property TenKhachHang1 As String
        Get
            Return TenKhachHang
        End Get
        Set(value As String)
            TenKhachHang = value
        End Set
    End Property

    Public Property CMND1 As String
        Get
            Return CMND
        End Get
        Set(value As String)
            CMND = value
        End Set
    End Property

    Public Property SDT1 As String
        Get
            Return SDT
        End Get
        Set(value As String)
            SDT = value
        End Set
    End Property
End Class

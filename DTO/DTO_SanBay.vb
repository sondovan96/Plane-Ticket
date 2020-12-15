Public Class DTO_SanBay
    Private MaSanBay As String
    Private TenSanBay As String
    Private TenThanhPho As String

    Public Sub New()
    End Sub

    Public Sub New(maSanBay As String, tenSanBay As String, tenThanhPho As String)
        Me.MaSanBay = maSanBay
        Me.TenSanBay = tenSanBay
        Me.TenThanhPho = tenThanhPho
    End Sub

    Public Property MaSanBay1 As String
        Get
            Return MaSanBay
        End Get
        Set(value As String)
            MaSanBay = value
        End Set
    End Property

    Public Property TenSanBay1 As String
        Get
            Return TenSanBay
        End Get
        Set(value As String)
            TenSanBay = value
        End Set
    End Property

    Public Property TenThanhPho1 As String
        Get
            Return TenThanhPho
        End Get
        Set(value As String)
            TenThanhPho = value
        End Set
    End Property
End Class

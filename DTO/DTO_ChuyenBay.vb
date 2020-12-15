Public Class DTO_ChuyenBay
    Dim MaChuyenBay As String
    Dim MaTuyenBay As String
    Dim MaMayBay As String
    Dim TGKhoiHanh As DateTime
    Dim TGBay As Integer

    Public Sub New()

    End Sub

    Public Sub New(maChuyenBay As String, maTuyenBay As String, maMayBay As String, tGKhoiHanh As Date, tGBay As Integer)
        Me.MaChuyenBay = maChuyenBay
        Me.MaTuyenBay = maTuyenBay
        Me.MaMayBay = maMayBay
        Me.TGKhoiHanh = tGKhoiHanh
        Me.TGBay = tGBay
    End Sub

    Public Property MaChuyenBay1 As String
        Get
            Return MaChuyenBay
        End Get
        Set(value As String)
            MaChuyenBay = value
        End Set
    End Property

    Public Property MaTuyenBay1 As String
        Get
            Return MaTuyenBay
        End Get
        Set(value As String)
            MaTuyenBay = value
        End Set
    End Property

    Public Property MaMayBay1 As String
        Get
            Return MaMayBay
        End Get
        Set(value As String)
            MaMayBay = value
        End Set
    End Property

    Public Property TGKhoiHanh1 As Date
        Get
            Return TGKhoiHanh
        End Get
        Set(value As Date)
            TGKhoiHanh = value
        End Set
    End Property

    Public Property TGBay1 As Integer
        Get
            Return TGBay
        End Get
        Set(value As Integer)
            TGBay = value
        End Set
    End Property
End Class

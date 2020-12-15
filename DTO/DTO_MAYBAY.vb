Public Class DTO_MAYBAY
    Dim MaMayBay As String
    Dim TenMayBay As String
    Dim SLGhe As Integer

    Public Sub New()
    End Sub

    Public Sub New(maMayBay As String, tenMayBay As String, sLGhe As Integer)
        Me.MaMayBay = maMayBay
        Me.TenMayBay = tenMayBay
        Me.SLGhe = sLGhe
    End Sub

    Public Property MaMayBay1 As String
        Get
            Return MaMayBay
        End Get
        Set(value As String)
            MaMayBay = value
        End Set
    End Property

    Public Property TenMayBay1 As String
        Get
            Return TenMayBay
        End Get
        Set(value As String)
            TenMayBay = value
        End Set
    End Property

    Public Property SLGhe1 As Integer
        Get
            Return SLGhe
        End Get
        Set(value As Integer)
            SLGhe = value
        End Set
    End Property
End Class

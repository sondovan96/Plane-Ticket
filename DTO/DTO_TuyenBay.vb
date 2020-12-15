Public Class DTO_TuyenBay
    Dim MaTuyenBay As String
    Dim MaSanBayDi As String
    Dim MaSanBayDen As String

    Public Sub New()
    End Sub

    Public Sub New(maTuyenBay As String, maSanBayDi As String, maSanBayDen As String)
        Me.MaTuyenBay = maTuyenBay
        Me.MaSanBayDi = maSanBayDi
        Me.MaSanBayDen = maSanBayDen
    End Sub

    Public Property MaTuyenBay1 As String
        Get
            Return MaTuyenBay
        End Get
        Set(value As String)
            MaTuyenBay = value
        End Set
    End Property

    Public Property MaSanBayDi1 As String
        Get
            Return MaSanBayDi
        End Get
        Set(value As String)
            MaSanBayDi = value
        End Set
    End Property

    Public Property MaSanBayDen1 As String
        Get
            Return MaSanBayDen
        End Get
        Set(value As String)
            MaSanBayDen = value
        End Set
    End Property
End Class

Public Class DTO_DoanhThuThang
    Dim Thang As Integer
    Dim Nam As Integer
    Dim SoChuyenBay As Integer
    Dim DoanhThu As Double

    Public Sub New()
    End Sub

    Public Sub New(thang As Integer, nam As Integer, soChuyenBay As Integer, doanhThu As Double)
        Me.Thang = thang
        Me.Nam = nam
        Me.SoChuyenBay = soChuyenBay
        Me.DoanhThu = doanhThu
    End Sub

    Public Property Thang1 As Integer
        Get
            Return Thang
        End Get
        Set(value As Integer)
            Thang = value
        End Set
    End Property

    Public Property Nam1 As Integer
        Get
            Return Nam
        End Get
        Set(value As Integer)
            Nam = value
        End Set
    End Property

    Public Property SoChuyenBay1 As Integer
        Get
            Return SoChuyenBay
        End Get
        Set(value As Integer)
            SoChuyenBay = value
        End Set
    End Property

    Public Property DoanhThu1 As Double
        Get
            Return DoanhThu
        End Get
        Set(value As Double)
            DoanhThu = value
        End Set
    End Property
End Class

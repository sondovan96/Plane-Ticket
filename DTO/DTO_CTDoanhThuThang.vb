Public Class DTO_CTDoanhThuThang
    Dim Thang As Integer
    Dim Nam As Integer
    Dim MaChuyenBay As String
    Dim SoVeBan As Integer
    Dim DoanhThu As Double

    Public Sub New()

    End Sub

    Public Sub New(thang As Integer, nam As Integer, maChuyenBay As String, soVeBan As Integer, doanhThu As Double)
        Me.Thang = thang
        Me.Nam = nam
        Me.MaChuyenBay = maChuyenBay
        Me.SoVeBan = soVeBan
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

    Public Property MaChuyenBay1 As String
        Get
            Return MaChuyenBay
        End Get
        Set(value As String)
            MaChuyenBay = value
        End Set
    End Property

    Public Property SoVeBan1 As Integer
        Get
            Return SoVeBan
        End Get
        Set(value As Integer)
            SoVeBan = value
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

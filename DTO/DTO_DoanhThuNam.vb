Public Class DTO_DoanhThuNam
    Dim Nam As Integer
    Dim DoanhThu As Double

    Public Sub New()
    End Sub

    Public Sub New(nam As Integer, doanhThu As Double)
        Me.Nam = nam
        Me.DoanhThu = doanhThu
    End Sub

    Public Property Nam1 As Integer
        Get
            Return Nam
        End Get
        Set(value As Integer)
            Nam = value
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

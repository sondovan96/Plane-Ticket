Public Class DTO_CTChuyenBay
    Dim MaChuyenBay As String
    Dim MaSanBayTG As String
    Dim TGDung As Integer
    Dim GhiChu As String

    Public Sub New()
    End Sub

    Public Sub New(maChuyenBay As String, maSanBayTG As String, tGDung As Integer, ghiChu As String)
        Me.MaChuyenBay = maChuyenBay
        Me.MaSanBayTG = maSanBayTG
        Me.TGDung = tGDung
        Me.GhiChu = ghiChu
    End Sub

    Public Property MaChuyenBay1 As String
        Get
            Return MaChuyenBay
        End Get
        Set(value As String)
            MaChuyenBay = value
        End Set
    End Property

    Public Property MaSanBayTG1 As String
        Get
            Return MaSanBayTG
        End Get
        Set(value As String)
            MaSanBayTG = value
        End Set
    End Property

    Public Property TGDung1 As Integer
        Get
            Return TGDung
        End Get
        Set(value As Integer)
            TGDung = value
        End Set
    End Property

    Public Property GhiChu1 As String
        Get
            Return GhiChu
        End Get
        Set(value As String)
            GhiChu = value
        End Set
    End Property
End Class

Public Class DTO_ThamSo
    Dim TGBayToiThieu As Integer
    Dim SanBayTGToiDa As Integer
    Dim TGDungToiThieu As Integer
    Dim TGDungToiDa As Integer
    Dim TGChamNhatDatVe As Integer
    Dim TGChamNhatHuyVe As Integer
    Dim SanBayToiDa As Integer
    Public Sub New()
    End Sub

    Public Sub New(tGBayToiThieu As Integer, sanBayTGToiDa As Integer, tGDungToiThieu As Integer, tGDungToiDa As Integer, tGChamNhatDatVe As Integer, tGChamNhatHuyVe As Integer, SanBayToiDa As Integer)
        Me.TGBayToiThieu = tGBayToiThieu
        Me.SanBayTGToiDa = sanBayTGToiDa
        Me.TGDungToiThieu = tGDungToiThieu
        Me.TGDungToiDa = tGDungToiDa
        Me.TGChamNhatDatVe = tGChamNhatDatVe
        Me.TGChamNhatHuyVe = tGChamNhatHuyVe
        Me.SanBayToiDa = SanBayToiDa
    End Sub

    Public Property TGBayToiThieu1 As Integer
        Get
            Return TGBayToiThieu
        End Get
        Set(value As Integer)
            TGBayToiThieu = value
        End Set
    End Property

    Public Property SanBayTGToiDa1 As Integer
        Get
            Return SanBayTGToiDa
        End Get
        Set(value As Integer)
            SanBayTGToiDa = value
        End Set
    End Property

    Public Property TGDungToiThieu1 As Integer
        Get
            Return TGDungToiThieu
        End Get
        Set(value As Integer)
            TGDungToiThieu = value
        End Set
    End Property

    Public Property TGDungToiDa1 As Integer
        Get
            Return TGDungToiDa
        End Get
        Set(value As Integer)
            TGDungToiDa = value
        End Set
    End Property

    Public Property TGChamNhatDatVe1 As Integer
        Get
            Return TGChamNhatDatVe
        End Get
        Set(value As Integer)
            TGChamNhatDatVe = value
        End Set
    End Property

    Public Property TGChamNhatHuyVe1 As Integer
        Get
            Return TGChamNhatHuyVe
        End Get
        Set(value As Integer)
            TGChamNhatHuyVe = value
        End Set
    End Property

    Public Property SanBayToiDa1 As Integer
        Get
            Return SanBayToiDa
        End Get
        Set(value As Integer)
            SanBayToiDa = value
        End Set
    End Property
End Class

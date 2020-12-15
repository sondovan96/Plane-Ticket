Public Class DTO_HangVe
    Dim MaHangVe As String
    Dim TenHangVe As String

    Public Sub New()
    End Sub

    Public Sub New(maHangVe As String, tenHangVe As String)
        Me.MaHangVe = maHangVe
        Me.TenHangVe = tenHangVe
    End Sub

    Public Property MaHangVe1 As String
        Get
            Return MaHangVe
        End Get
        Set(value As String)
            MaHangVe = value
        End Set
    End Property

    Public Property TenHangVe1 As String
        Get
            Return TenHangVe
        End Get
        Set(value As String)
            TenHangVe = value
        End Set
    End Property
End Class

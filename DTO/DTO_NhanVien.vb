Public Class DTO_NhanVien
    Dim MaNhanVien As String
    Dim TenNhanVien As String
    Dim Username As String
    Dim Password As String
    Dim type As Integer
    Public Sub New()
    End Sub

    Public Sub New(maNhanVien As String, tenNhanVien As String, username As String, password As String, type As Integer)
        Me.MaNhanVien = maNhanVien
        Me.TenNhanVien = tenNhanVien
        Me.Username = username
        Me.Password = password
        Me.type = type
    End Sub

    Public Property MaNhanVien1 As String
        Get
            Return MaNhanVien
        End Get
        Set(value As String)
            MaNhanVien = value
        End Set
    End Property

    Public Property TenNhanVien1 As String
        Get
            Return TenNhanVien
        End Get
        Set(value As String)
            TenNhanVien = value
        End Set
    End Property

    Public Property Username1 As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property Password1 As String
        Get
            Return Password
        End Get
        Set(value As String)
            Password = value
        End Set
    End Property

    Public Property Type1 As Integer
        Get
            Return type
        End Get
        Set(value As Integer)
            type = value
        End Set
    End Property
End Class

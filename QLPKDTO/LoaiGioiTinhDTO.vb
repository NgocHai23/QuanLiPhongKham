Public Class LoaiGioiTinhDTO
    Private iMaLoaiGioiTinh As Integer
    Private strTenLoaiGioiTinh As String

    Public Sub New(iMaLoaiGioiTinh As Integer, strTenLoaiGioiTinh As String)
        Me.iMaLoaiGioiTinh = iMaLoaiGioiTinh
        Me.strTenLoaiGioiTinh = strTenLoaiGioiTinh
    End Sub

    Public Property MaLoaiGioiTinh As Integer
        Get
            Return iMaLoaiGioiTinh
        End Get
        Set(value As Integer)
            iMaLoaiGioiTinh = value
        End Set
    End Property

    Public Property TenLoaiGioiTinh As String
        Get
            Return strTenLoaiGioiTinh
        End Get
        Set(value As String)
            strTenLoaiGioiTinh = value
        End Set
    End Property

End Class

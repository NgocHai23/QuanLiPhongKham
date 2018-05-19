Public Class BenhNhanDTO
    Private strMaBenhNhan As String
    Private strHoTenBenhNhan As String
    Private dateNamSinh As DateTime
    Private strDiaChi As String
    Private dateNgayKhamBenh As DateTime
    Private iMaLoaiGioiTinh As Integer

    Public Sub New(strMaBenhNhan As Integer, strHoTenBenhNhan As String, dateNamSinh As DateTime, strDiaChi As String, dateNgayKhamBenh As DateTime, iMaLoaiGioiTinh As Integer)
        Me.strMaBenhNhan = strMaBenhNhan
        Me.strHoTenBenhNhan = strHoTenBenhNhan
        Me.dateNamSinh = dateNamSinh
        Me.strDiaChi = strDiaChi
        Me.dateNgayKhamBenh = dateNgayKhamBenh
        Me.iMaLoaiGioiTinh = iMaLoaiGioiTinh
    End Sub

    Public Property MaBenhNhan As String
        Get
            Return strMaBenhNhan
        End Get
        Set(value As String)
            strMaBenhNhan = value
        End Set
    End Property

    Public Property HoTenBenhNhan As String
        Get
            Return strHoTenBenhNhan
        End Get
        Set(value As String)
            strHoTenBenhNhan = value
        End Set
    End Property

    Public Property NamSinh As Date
        Get
            Return dateNamSinh
        End Get
        Set(value As Date)
            dateNamSinh = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property NgayKhamBenh As Date
        Get
            Return dateNgayKhamBenh
        End Get
        Set(value As Date)
            dateNgayKhamBenh = value
        End Set
    End Property

    Public Property MaLoaiGioiTinh As Integer
        Get
            Return iMaLoaiGioiTinh
        End Get
        Set(value As Integer)

            iMaLoaiGioiTinh = value
        End Set
    End Property

End Class
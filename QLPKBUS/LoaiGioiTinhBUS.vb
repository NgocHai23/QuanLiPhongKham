Imports QLPKDTO
Imports QLPKDAL
Imports Utils
Public Class LoaiGioiTinhBUS
    Private lgtDAL As LoaiGioiTinhDAL
    Public Sub New()
        lgtDAL = New LoaiGioiTinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        lgtDAL = New LoaiGioiTinhDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listLoaiGioiTinh As List(Of LoaiGioiTinhDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lgtDAL.selectALL(listLoaiGioiTinh)
    End Function
End Class
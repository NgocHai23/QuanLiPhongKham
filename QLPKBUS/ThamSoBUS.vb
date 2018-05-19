Imports QLPKDAL
Imports QLPKDTO
Imports Utils
Public Class ThamSoBUS
    Private tsDAL As ThamSoDAL
    Public Sub New()
        tsDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New ThamSoDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef thamSo As ThamSoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tsDAL.selectALL(thamSo)
    End Function
End Class

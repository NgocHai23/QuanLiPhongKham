Imports QLPKDTO
Imports QLPKDAL
Imports Utils
Public Class BenhNhanBUS
    Private bnDAL As BenhNhanDAL
    Public Sub New()
        bnDAL = New BenhNhanDAL()
    End Sub
    Public Sub New(connectionString As String)
        bnDAL = New BenhNhanDAL(connectionString)
    End Sub

    'kiem tra ho ten co de trong khong'
    Public Function isValidName(bn As BenhNhanDTO) As Boolean
        If (bn.HoTenBenhNhan.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(bn As BenhNhanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bnDAL.insert(bn)
    End Function
    Public Function buildMDG(ByRef nextMabn As Integer) As Result
        Return bnDAL.buildMSBN(nextMabn)
    End Function
End Class

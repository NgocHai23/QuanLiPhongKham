Public Class ThamSoDTO
    Private iBenhNhanToiDa As Integer

    Public Sub New(iBenhNhanToiDa As Integer)
        Me.iBenhNhanToiDa = iBenhNhanToiDa
    End Sub

    Public Property BenhNhanToiDa As Integer
        Get
            Return iBenhNhanToiDa
        End Get
        Set(value As Integer)
            iBenhNhanToiDa = value
        End Set
    End Property
End Class

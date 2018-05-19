Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPKDTO
Imports Utils
Public Class LoaiGioiTinhDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listLoaiGioiTinh As List(Of LoaiGioiTinhDTO)) As Result

        Dim query As String = "SELECT [maloaigioitinh], [tenloaigioitinh] FROM [loaigioitinh]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiGioiTinh.Clear()
                        While reader.Read()
                            listLoaiGioiTinh.Add(New LoaiGioiTinhDTO(reader("maloaigioitinh"), reader("tenloaigioitinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại giới tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class

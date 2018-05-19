Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPKDTO
Imports Utils
Public Class BenhNhanDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMSBN(ByRef nextMsbn As String) As Result 'ex: 18222229

        nextMsbn = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMsbn = x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [mabenhnhan] "
        query &= "From [benhnhan] "
        query &= "Order By [mabenhnhan] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("mabenhnhan")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMsbn = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMsbn = nextMsbn + tmp
                        System.Console.WriteLine(nextMsbn)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã bệnh nhân kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dg As BenhNhanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [benhnhan] ([hotenbenhnhan], [namsinh], [diachi], [ngaykhambenh], [maloaigioitinh])"
        query &= "VALUES (@hotennhanvien,@namsinh,@diachi,@ngaykhambenh,@maloaigioitinh)"

        'get MSHS
        Dim nextMaDocGia = "1"
        buildMSBN(nextMaDocGia)
        dg.MaBenhNhan = nextMaDocGia

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.MaBenhNhan)
                    .Parameters.AddWithValue("@hotendocgia", dg.HoTenBenhNhan)
                    .Parameters.AddWithValue("@namsinh", dg.NamSinh)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@ngaykhambenh", dg.NgayKhamBenh)
                    .Parameters.AddWithValue("@maloaigioitinh", dg.MaLoaiGioiTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm bệnh nhân không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class

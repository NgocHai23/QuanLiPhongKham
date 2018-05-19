Imports System.Windows.Forms
Imports QLPKBUS
Imports QLPKDTO
Imports Utils
Public Class DanhSachKhamBenh
    Private bnBus As BenhNhanBUS
    Private lgtBus As LoaiGioiTinhBUS
    Private tsBus As ThamSoBUS
    Private tsDTO As ThamSoDTO

    Public Sub New()
        InitializeComponent()
        bnBus = New BenhNhanBUS
        lgtBus = New LoaiGioiTinhBUS
        tsBus = New ThamSoBUS
        Dim result As Result
        result = tsBus.selectAll(tsDTO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách quy định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
    End Sub

    Private Sub DanhSachKhamBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lay ngay theo win
        lbNgayKham.Text = Date.Now

        ' Load LoaiGioiTinh list
        Dim listLoaiGioiTinh = New List(Of LoaiGioiTinhDTO)
        Dim result As Result
        result = lgtBus.selectAll(listLoaiGioiTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbGioiTinh.DataSource = New BindingSource(listLoaiGioiTinh, String.Empty)
        cbGioiTinh.DisplayMember = "TenLoaiGioiTinh"
        cbGioiTinh.ValueMember = "MaLoaiGioiTinh"
    End Sub

    Private Sub butNhanBenh_Click(sender As Object, e As EventArgs) Handles butNhanBenh.Click
        If (txtHoTen.Text.Length < 1) Then
            MessageBox.Show("Vui lòng nhập họ tên", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = bnBus.insert(New BenhNhanDTO(Nothing, txtHoTen.Text, dtpNamSinh.Value, txtDiaChi.Text, dtpNamSinh.Value, cbGioiTinh.SelectedValue))
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        MessageBox.Show("Thêm độc giả thành công.")
    End Sub
End Class

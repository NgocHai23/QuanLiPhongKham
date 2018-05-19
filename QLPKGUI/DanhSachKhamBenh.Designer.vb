<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanhSachKhamBenh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DanhSachKhamBenh))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNgayKham = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNamSinh = New System.Windows.Forms.DateTimePicker()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.butNhanBenh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.butNhanBenh)
        Me.GroupBox1.Controls.Add(Me.cbGioiTinh)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.dtpNamSinh)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbNgayKham)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 297)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngày Khám Bệnh:"
        '
        'lbNgayKham
        '
        Me.lbNgayKham.AutoSize = True
        Me.lbNgayKham.Location = New System.Drawing.Point(326, 24)
        Me.lbNgayKham.Name = "lbNgayKham"
        Me.lbNgayKham.Size = New System.Drawing.Size(135, 24)
        Me.lbNgayKham.TabIndex = 1
        Me.lbNgayKham.Text = "<ngày khám>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Danh Sách Khám Bệnh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Họ Tên Bệnh Nhân "
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(274, 66)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(357, 28)
        Me.txtHoTen.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Năm Sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Địa Chỉ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Giới Tính"
        '
        'dtpNamSinh
        '
        Me.dtpNamSinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNamSinh.Location = New System.Drawing.Point(274, 104)
        Me.dtpNamSinh.Name = "dtpNamSinh"
        Me.dtpNamSinh.Size = New System.Drawing.Size(147, 28)
        Me.dtpNamSinh.TabIndex = 7
        Me.dtpNamSinh.Value = New Date(2018, 5, 12, 0, 0, 0, 0)
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(274, 142)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(357, 28)
        Me.txtDiaChi.TabIndex = 8
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Location = New System.Drawing.Point(274, 180)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(147, 30)
        Me.cbGioiTinh.TabIndex = 9
        '
        'butNhanBenh
        '
        Me.butNhanBenh.Location = New System.Drawing.Point(274, 239)
        Me.butNhanBenh.Name = "butNhanBenh"
        Me.butNhanBenh.Size = New System.Drawing.Size(187, 41)
        Me.butNhanBenh.TabIndex = 10
        Me.butNhanBenh.Text = "Nhận Bệnh"
        Me.butNhanBenh.UseVisualStyleBackColor = True
        '
        'DanhSachKhamBenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 352)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DanhSachKhamBenh"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbNgayKham As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNamSinh As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents butNhanBenh As Button
End Class

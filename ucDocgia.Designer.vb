<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDocGia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMadocgia = New System.Windows.Forms.Label()
        Me.lblTendocgia = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSdt = New System.Windows.Forms.Label()
        Me.lblNgaysinh = New System.Windows.Forms.Label()
        Me.txtMaDocGia = New System.Windows.Forms.TextBox()
        Me.txtTenDocGia = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.dgvDocGia = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.lblNhapthongtin = New System.Windows.Forms.Label()
        Me.txtTimKiemDocGia = New System.Windows.Forms.TextBox()
        Me.btnTimKiemDocGia = New System.Windows.Forms.Button()
        CType(Me.dgvDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMadocgia
        '
        Me.lblMadocgia.AutoSize = True
        Me.lblMadocgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMadocgia.Location = New System.Drawing.Point(29, 54)
        Me.lblMadocgia.Name = "lblMadocgia"
        Me.lblMadocgia.Size = New System.Drawing.Size(84, 16)
        Me.lblMadocgia.TabIndex = 0
        Me.lblMadocgia.Text = "Mã độc giả"
        '
        'lblTendocgia
        '
        Me.lblTendocgia.AutoSize = True
        Me.lblTendocgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTendocgia.Location = New System.Drawing.Point(29, 84)
        Me.lblTendocgia.Name = "lblTendocgia"
        Me.lblTendocgia.Size = New System.Drawing.Size(90, 16)
        Me.lblTendocgia.TabIndex = 1
        Me.lblTendocgia.Text = "Tên độc giả"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiachi.Location = New System.Drawing.Point(29, 119)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(58, 16)
        Me.lblDiachi.TabIndex = 2
        Me.lblDiachi.Text = "Địa chỉ "
        '
        'lblSdt
        '
        Me.lblSdt.AutoSize = True
        Me.lblSdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSdt.Location = New System.Drawing.Point(29, 153)
        Me.lblSdt.Name = "lblSdt"
        Me.lblSdt.Size = New System.Drawing.Size(98, 16)
        Me.lblSdt.TabIndex = 3
        Me.lblSdt.Text = "Số điện thoại"
        '
        'lblNgaysinh
        '
        Me.lblNgaysinh.AutoSize = True
        Me.lblNgaysinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgaysinh.Location = New System.Drawing.Point(29, 187)
        Me.lblNgaysinh.Name = "lblNgaysinh"
        Me.lblNgaysinh.Size = New System.Drawing.Size(76, 16)
        Me.lblNgaysinh.TabIndex = 4
        Me.lblNgaysinh.Text = "Ngày sinh"
        '
        'txtMaDocGia
        '
        Me.txtMaDocGia.Location = New System.Drawing.Point(149, 50)
        Me.txtMaDocGia.Name = "txtMaDocGia"
        Me.txtMaDocGia.Size = New System.Drawing.Size(118, 20)
        Me.txtMaDocGia.TabIndex = 5
        '
        'txtTenDocGia
        '
        Me.txtTenDocGia.Location = New System.Drawing.Point(149, 84)
        Me.txtTenDocGia.Name = "txtTenDocGia"
        Me.txtTenDocGia.Size = New System.Drawing.Size(118, 20)
        Me.txtTenDocGia.TabIndex = 6
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(149, 119)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(118, 20)
        Me.txtDiaChi.TabIndex = 7
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(149, 153)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(118, 20)
        Me.txtSoDienThoai.TabIndex = 8
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.No
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(149, 187)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(118, 20)
        Me.dtpNgaySinh.TabIndex = 9
        '
        'dgvDocGia
        '
        Me.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocGia.Location = New System.Drawing.Point(290, 50)
        Me.dgvDocGia.Name = "dgvDocGia"
        Me.dgvDocGia.Size = New System.Drawing.Size(718, 281)
        Me.dgvDocGia.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(38, 253)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(162, 253)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(38, 308)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 13
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi.Location = New System.Drawing.Point(162, 308)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 14
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'btnHienThi
        '
        Me.btnHienThi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHienThi.Location = New System.Drawing.Point(97, 351)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(75, 23)
        Me.btnHienThi.TabIndex = 15
        Me.btnHienThi.Text = "Hiển thị"
        Me.btnHienThi.UseVisualStyleBackColor = True
        '
        'lblNhapthongtin
        '
        Me.lblNhapthongtin.AutoSize = True
        Me.lblNhapthongtin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNhapthongtin.Location = New System.Drawing.Point(471, 334)
        Me.lblNhapthongtin.Name = "lblNhapthongtin"
        Me.lblNhapthongtin.Size = New System.Drawing.Size(106, 16)
        Me.lblNhapthongtin.TabIndex = 16
        Me.lblNhapthongtin.Text = "Nhập thông tin"
        '
        'txtTimKiemDocGia
        '
        Me.txtTimKiemDocGia.Location = New System.Drawing.Point(583, 334)
        Me.txtTimKiemDocGia.Name = "txtTimKiemDocGia"
        Me.txtTimKiemDocGia.Size = New System.Drawing.Size(168, 20)
        Me.txtTimKiemDocGia.TabIndex = 17
        '
        'btnTimKiemDocGia
        '
        Me.btnTimKiemDocGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiemDocGia.Location = New System.Drawing.Point(625, 360)
        Me.btnTimKiemDocGia.Name = "btnTimKiemDocGia"
        Me.btnTimKiemDocGia.Size = New System.Drawing.Size(91, 23)
        Me.btnTimKiemDocGia.TabIndex = 18
        Me.btnTimKiemDocGia.Text = "Tìm kiếm"
        Me.btnTimKiemDocGia.UseVisualStyleBackColor = True
        '
        'ucDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTimKiemDocGia)
        Me.Controls.Add(Me.txtTimKiemDocGia)
        Me.Controls.Add(Me.lblNhapthongtin)
        Me.Controls.Add(Me.btnHienThi)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvDocGia)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenDocGia)
        Me.Controls.Add(Me.txtMaDocGia)
        Me.Controls.Add(Me.lblNgaysinh)
        Me.Controls.Add(Me.lblSdt)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblTendocgia)
        Me.Controls.Add(Me.lblMadocgia)
        Me.Name = "ucDocGia"
        Me.Size = New System.Drawing.Size(1052, 589)
        CType(Me.dgvDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMadocgia As Label
    Friend WithEvents lblTendocgia As Label
    Friend WithEvents lblDiachi As Label
    Friend WithEvents lblSdt As Label
    Friend WithEvents lblNgaysinh As Label
    Friend WithEvents txtMaDocGia As TextBox
    Friend WithEvents txtTenDocGia As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents dgvDocGia As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnHienThi As Button
    Friend WithEvents lblNhapthongtin As Label
    Friend WithEvents txtTimKiemDocGia As TextBox
    Friend WithEvents btnTimKiemDocGia As Button
End Class

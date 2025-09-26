<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblMaSach = New System.Windows.Forms.Label()
        Me.lblTenSach = New System.Windows.Forms.Label()
        Me.lblTacGia = New System.Windows.Forms.Label()
        Me.lblTheLoai = New System.Windows.Forms.Label()
        Me.lblSoLuong = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.lblnhapthongtin = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSach
        '
        Me.lblMaSach.AutoSize = True
        Me.lblMaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSach.Location = New System.Drawing.Point(30, 57)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(65, 16)
        Me.lblMaSach.TabIndex = 0
        Me.lblMaSach.Text = "Mã sách"
        '
        'lblTenSach
        '
        Me.lblTenSach.AutoSize = True
        Me.lblTenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSach.Location = New System.Drawing.Point(30, 92)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(71, 16)
        Me.lblTenSach.TabIndex = 1
        Me.lblTenSach.Text = "Tên sách"
        '
        'lblTacGia
        '
        Me.lblTacGia.AutoSize = True
        Me.lblTacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTacGia.Location = New System.Drawing.Point(30, 133)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(60, 16)
        Me.lblTacGia.TabIndex = 2
        Me.lblTacGia.Text = "Tác giả"
        '
        'lblTheLoai
        '
        Me.lblTheLoai.AutoSize = True
        Me.lblTheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheLoai.Location = New System.Drawing.Point(30, 180)
        Me.lblTheLoai.Name = "lblTheLoai"
        Me.lblTheLoai.Size = New System.Drawing.Size(64, 16)
        Me.lblTheLoai.TabIndex = 3
        Me.lblTheLoai.Text = "Thể loại"
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = True
        Me.lblSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuong.Location = New System.Drawing.Point(30, 224)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(68, 16)
        Me.lblSoLuong.TabIndex = 4
        Me.lblSoLuong.Text = "Số lượng"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(102, 53)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(116, 20)
        Me.txtMaSach.TabIndex = 5
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(102, 89)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(116, 20)
        Me.txtTenSach.TabIndex = 6
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(102, 130)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(116, 20)
        Me.txtTacGia.TabIndex = 7
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Location = New System.Drawing.Point(102, 177)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.Size = New System.Drawing.Size(116, 20)
        Me.txtTheLoai.TabIndex = 8
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(102, 220)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(116, 20)
        Me.txtSoLuong.TabIndex = 9
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(33, 275)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 23)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(33, 320)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 23)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(135, 275)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(83, 23)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi.Location = New System.Drawing.Point(135, 320)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(83, 23)
        Me.btnLamMoi.TabIndex = 13
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'dgvSach
        '
        Me.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Location = New System.Drawing.Point(267, 53)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.ReadOnly = True
        Me.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSach.Size = New System.Drawing.Size(702, 290)
        Me.dgvSach.TabIndex = 14
        '
        'btnHienThi
        '
        Me.btnHienThi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHienThi.Location = New System.Drawing.Point(89, 369)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(75, 23)
        Me.btnHienThi.TabIndex = 15
        Me.btnHienThi.Text = "Hiển thị"
        Me.btnHienThi.UseVisualStyleBackColor = True
        '
        'lblnhapthongtin
        '
        Me.lblnhapthongtin.AutoSize = True
        Me.lblnhapthongtin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnhapthongtin.Location = New System.Drawing.Point(380, 346)
        Me.lblnhapthongtin.Name = "lblnhapthongtin"
        Me.lblnhapthongtin.Size = New System.Drawing.Size(106, 16)
        Me.lblnhapthongtin.TabIndex = 16
        Me.lblnhapthongtin.Text = "Nhập thông tin"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(492, 346)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(181, 20)
        Me.txtTimKiem.TabIndex = 17
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(535, 372)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(103, 23)
        Me.btnTimKiem.TabIndex = 18
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'ucSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.lblnhapthongtin)
        Me.Controls.Add(Me.btnHienThi)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTheLoai)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.lblSoLuong)
        Me.Controls.Add(Me.lblTheLoai)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.lblTenSach)
        Me.Controls.Add(Me.lblMaSach)
        Me.Name = "ucSach"
        Me.Size = New System.Drawing.Size(1064, 571)
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaSach As Label
    Friend WithEvents lblTenSach As Label
    Friend WithEvents lblTacGia As Label
    Friend WithEvents lblTheLoai As Label
    Friend WithEvents lblSoLuong As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents txtTheLoai As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents dgvSach As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnHienThi As Button
    Friend WithEvents lblnhapthongtin As Label
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents btnTimKiem As Button
End Class

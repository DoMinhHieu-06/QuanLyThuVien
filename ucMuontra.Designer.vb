<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMuonTra
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
        Me.dgvMuonTra = New System.Windows.Forms.DataGridView()
        Me.cbDocGia = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cbSach = New System.Windows.Forms.ComboBox()
        Me.cbTrangThai = New System.Windows.Forms.ComboBox()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.txtTimKiemSach = New System.Windows.Forms.TextBox()
        Me.btnTimSach = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvMuonTra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMuonTra
        '
        Me.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuonTra.Location = New System.Drawing.Point(311, 49)
        Me.dgvMuonTra.Name = "dgvMuonTra"
        Me.dgvMuonTra.Size = New System.Drawing.Size(532, 265)
        Me.dgvMuonTra.TabIndex = 0
        '
        'cbDocGia
        '
        Me.cbDocGia.FormattingEnabled = True
        Me.cbDocGia.Location = New System.Drawing.Point(148, 49)
        Me.cbDocGia.Name = "cbDocGia"
        Me.cbDocGia.Size = New System.Drawing.Size(121, 21)
        Me.cbDocGia.TabIndex = 1
        '
        'cbSach
        '
        Me.cbSach.FormattingEnabled = True
        Me.cbSach.Location = New System.Drawing.Point(148, 91)
        Me.cbSach.Name = "cbSach"
        Me.cbSach.Size = New System.Drawing.Size(121, 21)
        Me.cbSach.TabIndex = 2
        '
        'cbTrangThai
        '
        Me.cbTrangThai.FormattingEnabled = True
        Me.cbTrangThai.Location = New System.Drawing.Point(148, 128)
        Me.cbTrangThai.Name = "cbTrangThai"
        Me.cbTrangThai.Size = New System.Drawing.Size(121, 21)
        Me.cbTrangThai.TabIndex = 3
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.Cursor = System.Windows.Forms.Cursors.No
        Me.dtpNgayMuon.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(148, 170)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(121, 20)
        Me.dtpNgayMuon.TabIndex = 4
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.Cursor = System.Windows.Forms.Cursors.No
        Me.dtpNgayTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTra.Location = New System.Drawing.Point(148, 212)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(121, 20)
        Me.dtpNgayTra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Độc giả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Trạng thái"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ngày mượn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ngày trả"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(68, 268)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(194, 268)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(68, 308)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 13
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLamMoi.Location = New System.Drawing.Point(194, 308)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 23)
        Me.btnLamMoi.TabIndex = 14
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'btnHienThi
        '
        Me.btnHienThi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHienThi.Location = New System.Drawing.Point(128, 350)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(75, 23)
        Me.btnHienThi.TabIndex = 15
        Me.btnHienThi.Text = "Hiển thị"
        Me.btnHienThi.UseVisualStyleBackColor = True
        '
        'txtTimKiemSach
        '
        Me.txtTimKiemSach.Location = New System.Drawing.Point(509, 320)
        Me.txtTimKiemSach.Name = "txtTimKiemSach"
        Me.txtTimKiemSach.Size = New System.Drawing.Size(100, 20)
        Me.txtTimKiemSach.TabIndex = 16
        '
        'btnTimSach
        '
        Me.btnTimSach.Location = New System.Drawing.Point(626, 320)
        Me.btnTimSach.Name = "btnTimSach"
        Me.btnTimSach.Size = New System.Drawing.Size(75, 23)
        Me.btnTimSach.TabIndex = 17
        Me.btnTimSach.Text = "Tìm"
        Me.btnTimSach.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "nhập thông tin"
        '
        'ucMuontra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTimSach)
        Me.Controls.Add(Me.txtTimKiemSach)
        Me.Controls.Add(Me.btnHienThi)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNgayTra)
        Me.Controls.Add(Me.dtpNgayMuon)
        Me.Controls.Add(Me.cbTrangThai)
        Me.Controls.Add(Me.cbSach)
        Me.Controls.Add(Me.cbDocGia)
        Me.Controls.Add(Me.dgvMuonTra)
        Me.Name = "ucMuontra"
        Me.Size = New System.Drawing.Size(1011, 584)
        CType(Me.dgvMuonTra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMuonTra As DataGridView
    Friend WithEvents cbDocGia As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbSach As ComboBox
    Friend WithEvents cbTrangThai As ComboBox
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnHienThi As Button
    Friend WithEvents txtTimKiemSach As TextBox
    Friend WithEvents btnTimSach As Button
    Friend WithEvents Label6 As Label
End Class

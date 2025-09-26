<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBaoCao
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTongMuon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTongDocGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTongSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTongMuon)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTongDocGia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTongSach)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thống kê tổng"
        '
        'txtTongMuon
        '
        Me.txtTongMuon.Location = New System.Drawing.Point(150, 80)
        Me.txtTongMuon.Name = "txtTongMuon"
        Me.txtTongMuon.ReadOnly = True
        Me.txtTongMuon.Size = New System.Drawing.Size(100, 20)
        Me.txtTongMuon.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tổng lượt mượn:"
        '
        'txtTongDocGia
        '
        Me.txtTongDocGia.Location = New System.Drawing.Point(150, 50)
        Me.txtTongDocGia.Name = "txtTongDocGia"
        Me.txtTongDocGia.ReadOnly = True
        Me.txtTongDocGia.Size = New System.Drawing.Size(100, 20)
        Me.txtTongDocGia.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tổng độc giả:"
        '
        'txtTongSach
        '
        Me.txtTongSach.Location = New System.Drawing.Point(150, 20)
        Me.txtTongSach.Name = "txtTongSach"
        Me.txtTongSach.ReadOnly = True
        Me.txtTongSach.Size = New System.Drawing.Size(100, 20)
        Me.txtTongSach.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tổng sách:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAll)
        Me.GroupBox2.Controls.Add(Me.btnThongKe)
        Me.GroupBox2.Controls.Add(Me.dtpDenNgay)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpTuNgay)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 120)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lọc báo cáo"
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(389, 67)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "Hiển thị tất cả"
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(308, 67)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(75, 23)
        Me.btnThongKe.TabIndex = 1
        Me.btnThongKe.Text = "Thống kê"
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Cursor = System.Windows.Forms.Cursors.No
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(90, 70)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtpDenNgay.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Đến ngày:"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Cursor = System.Windows.Forms.Cursors.No
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(90, 30)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtpTuNgay.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Từ ngày:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvBaoCao)
        Me.GroupBox3.Location = New System.Drawing.Point(54, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(930, 400)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chi tiết mượn – trả"
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBaoCao.Location = New System.Drawing.Point(3, 16)
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.Size = New System.Drawing.Size(924, 381)
        Me.dgvBaoCao.TabIndex = 0
        '
        'ucBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ucBaoCao"
        Me.Size = New System.Drawing.Size(1065, 605)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtTongMuon As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents txtTongDocGia As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents txtTongSach As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents btnAll As Button
    Private WithEvents btnThongKe As Button
    Private WithEvents dtpDenNgay As DateTimePicker
    Private WithEvents Label5 As Label
    Private WithEvents dtpTuNgay As DateTimePicker
    Private WithEvents Label4 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents dgvBaoCao As DataGridView
End Class

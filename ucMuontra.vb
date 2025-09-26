Imports System.Data.SqlClient

Public Class ucMuonTra

    Private connectionString As String = "Data Source=DESKTOP-15CO6TL\MSSQLSERVER01;Initial Catalog=Ql_thuvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' 📌 Load dữ liệu MuonTra
    Private Sub LoadData()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaMuonTra, MaDocGia, MaSach, NgayMuon, NgayTra, TrangThai FROM MuonTra"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvMuonTra.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' 📌 Load danh sách độc giả + sách vào ComboBox
    Private Sub LoadCombobox()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Load DocGia
                Dim daDocGia As New SqlDataAdapter("SELECT MaDocGia, TenDocGia FROM DocGia", conn)
                Dim dtDocGia As New DataTable()
                daDocGia.Fill(dtDocGia)
                cbDocGia.DataSource = dtDocGia
                cbDocGia.DisplayMember = "TenDocGia"
                cbDocGia.ValueMember = "MaDocGia"

                ' Load Sach
                Dim daSach As New SqlDataAdapter("SELECT MaSach, TenSach FROM Sach", conn)
                Dim dtSach As New DataTable()
                daSach.Fill(dtSach)
                cbSach.DataSource = dtSach
                cbSach.DisplayMember = "TenSach"
                cbSach.ValueMember = "MaSach"
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi load Combobox: " & ex.Message)
        End Try
    End Sub

    ' 📌 Khi load UC
    Private Sub ucMuonTra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombobox()
        LoadData()
        cbTrangThai.Items.Add("Đang mượn")
        cbTrangThai.Items.Add("Đã trả")
        cbTrangThai.SelectedIndex = 0
    End Sub

    ' 📌 Thêm phiếu mượn
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO MuonTra (MaDocGia, MaSach, NgayMuon, NgayTra, TrangThai) 
                                       VALUES (@MaDocGia, @MaSach, @NgayMuon, @NgayTra, @TrangThai)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaDocGia", cbDocGia.SelectedValue)
                    cmd.Parameters.AddWithValue("@MaSach", cbSach.SelectedValue)
                    cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value.Date)
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value.Date)
                    cmd.Parameters.AddWithValue("@TrangThai", cbTrangThai.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Thêm phiếu mượn thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm phiếu mượn: " & ex.Message)
        End Try
    End Sub

    ' 📌 Xóa phiếu mượn
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvMuonTra.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn phiếu mượn cần xóa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM MuonTra WHERE MaMuonTra = @MaMuonTra"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaMuonTra", dgvMuonTra.CurrentRow.Cells("MaMuonTra").Value.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Xóa phiếu mượn thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa phiếu mượn: " & ex.Message)
        End Try
    End Sub

    ' 📌 Sửa phiếu mượn
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvMuonTra.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn phiếu mượn cần sửa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE MuonTra 
                                       SET MaDocGia=@MaDocGia, MaSach=@MaSach, NgayMuon=@NgayMuon, NgayTra=@NgayTra, TrangThai=@TrangThai 
                                       WHERE MaMuonTra=@MaMuonTra"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaMuonTra", dgvMuonTra.CurrentRow.Cells("MaMuonTra").Value)
                    cmd.Parameters.AddWithValue("@MaDocGia", cbDocGia.SelectedValue)
                    cmd.Parameters.AddWithValue("@MaSach", cbSach.SelectedValue)
                    cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value.Date)
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value.Date)
                    cmd.Parameters.AddWithValue("@TrangThai", cbTrangThai.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Cập nhật phiếu mượn thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa phiếu mượn: " & ex.Message)
        End Try
    End Sub

    ' 📌 Chọn dòng → hiển thị vào control
    Private Sub dgvMuonTra_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMuonTra.SelectionChanged
        If dgvMuonTra.CurrentRow IsNot Nothing Then
            cbDocGia.SelectedValue = dgvMuonTra.CurrentRow.Cells("MaDocGia").Value.ToString()
            cbSach.SelectedValue = dgvMuonTra.CurrentRow.Cells("MaSach").Value.ToString()
            dtpNgayMuon.Value = Convert.ToDateTime(dgvMuonTra.CurrentRow.Cells("NgayMuon").Value)
            dtpNgayTra.Value = Convert.ToDateTime(dgvMuonTra.CurrentRow.Cells("NgayTra").Value)
            cbTrangThai.Text = dgvMuonTra.CurrentRow.Cells("TrangThai").Value.ToString()
        End If
    End Sub

    ' 📌 Làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        cbDocGia.SelectedIndex = 0
        cbSach.SelectedIndex = 0
        dtpNgayMuon.Value = DateTime.Today
        dtpNgayTra.Value = DateTime.Today
        cbTrangThai.SelectedIndex = 0
        dgvMuonTra.ClearSelection()
    End Sub

    ' 📌 Hiển thị toàn bộ
    Private Sub btnHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        LoadData()
    End Sub

    ' 📌 Tìm kiếm sách
    Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
        Dim tukhoa As String = txtTimKiemSach.Text.Trim()

        If tukhoa = "" Then
            MessageBox.Show("Vui lòng nhập mã sách hoặc tên sách cần tìm!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT mt.MaMuonTra, mt.MaDocGia, dg.TenDocGia, 
                                          mt.MaSach, s.TenSach, mt.NgayMuon, mt.NgayTra, mt.TrangThai
                                   FROM MuonTra mt
                                   JOIN Sach s ON mt.MaSach = s.MaSach
                                   JOIN DocGia dg ON mt.MaDocGia = dg.MaDocGia
                                   WHERE mt.MaSach LIKE @TuKhoa OR s.TenSach LIKE @TuKhoa"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" & tukhoa & "%")
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvMuonTra.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm sách: " & ex.Message)
        End Try
    End Sub
End Class

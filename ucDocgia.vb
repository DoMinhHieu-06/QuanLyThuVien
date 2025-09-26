Imports System.Data.SqlClient

Public Class ucDocGia

    ' 🔹 Chuỗi kết nối SQL Server (sửa lại Data Source cho đúng)
    Private connectionString As String = "Data Source=DESKTOP-15CO6TL\MSSQLSERVER01;Initial Catalog=Ql_thuvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' 📌 Hàm load dữ liệu
    Private Sub LoadData()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaDocGia, TenDocGia, DiaChi, SoDienThoai, NgaySinh FROM DocGia"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvDocGia.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' 📌 Thêm độc giả
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO DocGia (MaDocGia, TenDocGia, DiaChi, SoDienThoai, NgaySinh) VALUES (@MaDocGia, @TenDocGia, @DiaChi, @SoDienThoai, @NgaySinh)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text)
                    cmd.Parameters.AddWithValue("@TenDocGia", txtTenDocGia.Text)
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text)
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Thêm độc giả thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm độc giả: " & ex.Message)
        End Try
    End Sub

    ' 📌 Xóa độc giả
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDocGia.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn độc giả cần xóa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM DocGia WHERE MaDocGia = @MaDocGia"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaDocGia", dgvDocGia.CurrentRow.Cells("MaDocGia").Value.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Xóa độc giả thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa độc giả: " & ex.Message)
        End Try
    End Sub

    ' 📌 Sửa độc giả
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvDocGia.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn độc giả cần sửa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE DocGia SET TenDocGia=@TenDocGia, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, NgaySinh=@NgaySinh WHERE MaDocGia=@MaDocGia"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaDocGia", txtMaDocGia.Text)
                    cmd.Parameters.AddWithValue("@TenDocGia", txtTenDocGia.Text)
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text)
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Cập nhật độc giả thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa độc giả: " & ex.Message)
        End Try
    End Sub

    ' 📌 Khi chọn dòng trong DataGridView → đổ vào TextBox

    Private Sub dgvDocGia_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDocGia.SelectionChanged
        If dgvDocGia.CurrentRow IsNot Nothing Then
            txtMaDocGia.Text = dgvDocGia.CurrentRow.Cells("MaDocGia").Value.ToString()
            txtTenDocGia.Text = dgvDocGia.CurrentRow.Cells("TenDocGia").Value.ToString()
            txtDiaChi.Text = dgvDocGia.CurrentRow.Cells("DiaChi").Value.ToString()
            txtSoDienThoai.Text = dgvDocGia.CurrentRow.Cells("SoDienThoai").Value.ToString()

            ' ✅ Kiểm tra NULL trước khi gán vào DateTimePicker
            Dim vNgay = dgvDocGia.CurrentRow.Cells("NgaySinh").Value
            If vNgay IsNot Nothing AndAlso Not Convert.IsDBNull(vNgay) Then
                dtpNgaySinh.Value = Convert.ToDateTime(vNgay)
            Else
                dtpNgaySinh.Value = DateTime.Today ' hoặc để mặc định
            End If
        End If
    End Sub


    ' 📌 Làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtMaDocGia.Clear()
        txtTenDocGia.Clear()
        txtDiaChi.Clear()
        txtSoDienThoai.Clear()
        dtpNgaySinh.Value = DateTime.Today
        dgvDocGia.ClearSelection()
    End Sub

    ' 📌 Hiển thị toàn bộ độc giả
    Private Sub btnHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        LoadData()
    End Sub
    ' 📌 Nút Tìm kiếm độc giả
    Private Sub btnTimKiemDocGia_Click(sender As Object, e As EventArgs) Handles btnTimKiemDocGia.Click
        Dim tukhoa As String = txtTimKiemDocGia.Text.Trim()

        If tukhoa = "" Then
            MessageBox.Show("Vui lòng nhập Mã độc giả hoặc Tên độc giả để tìm kiếm!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaDocGia, TenDocGia, NgaySinh, DiaChi, SoDienThoai 
                                   FROM DocGia 
                                   WHERE MaDocGia LIKE @TuKhoa OR TenDocGia LIKE @TuKhoa"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" & tukhoa & "%")
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvDocGia.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm độc giả: " & ex.Message)
        End Try
    End Sub

    ' 📌 Khi load UC
    Private Sub ucDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


End Class

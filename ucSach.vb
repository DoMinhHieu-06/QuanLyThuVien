Imports System.Data.SqlClient

Public Class ucSach

    ' 🔹 Chuỗi kết nối SQL Server (bạn sửa lại Data Source cho đúng máy của bạn)
    Private connectionString As String = "Data Source=DESKTOP-15CO6TL\MSSQLSERVER01;Initial Catalog=Ql_thuvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' 📌 Hàm tải toàn bộ sách từ CSDL
    Private Sub LoadData()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaSach, TenSach, TacGia, TheLoai, SoLuong FROM Sach"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvSach.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' 📌 Sự kiện load UserControl
    Private Sub ucSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' 📌 Nút Thêm sách
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Sach (MaSach, TenSach, TacGia, TheLoai, SoLuong) VALUES (@MaSach, @TenSach, @TacGia, @TheLoai, @SoLuong)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text)
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text)
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text)
                    cmd.Parameters.AddWithValue("@TheLoai", txtTheLoai.Text)
                    cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(txtSoLuong.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Thêm sách thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm sách: " & ex.Message)
        End Try
    End Sub

    ' 📌 Nút Xóa sách
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvSach.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn sách cần xóa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM Sach WHERE MaSach = @MaSach"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaSach", dgvSach.CurrentRow.Cells("MaSach").Value.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Xóa sách thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa sách: " & ex.Message)
        End Try
    End Sub

    ' 📌 Nút Sửa sách
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvSach.CurrentRow Is Nothing Then
            MessageBox.Show("Hãy chọn sách cần sửa.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Sach SET TenSach=@TenSach, TacGia=@TacGia, TheLoai=@TheLoai, SoLuong=@SoLuong WHERE MaSach=@MaSach"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text)
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text)
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text)
                    cmd.Parameters.AddWithValue("@TheLoai", txtTheLoai.Text)
                    cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(txtSoLuong.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Cập nhật sách thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa sách: " & ex.Message)
        End Try
    End Sub

    ' 📌 Khi chọn 1 dòng → đổ dữ liệu vào TextBox
    Private Sub dgvSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSach.SelectionChanged
        If dgvSach.CurrentRow IsNot Nothing Then
            txtMaSach.Text = dgvSach.CurrentRow.Cells("MaSach").Value.ToString()
            txtTenSach.Text = dgvSach.CurrentRow.Cells("TenSach").Value.ToString()
            txtTacGia.Text = dgvSach.CurrentRow.Cells("TacGia").Value.ToString()
            txtTheLoai.Text = dgvSach.CurrentRow.Cells("TheLoai").Value.ToString()
            txtSoLuong.Text = dgvSach.CurrentRow.Cells("SoLuong").Value.ToString()
        End If
    End Sub

    ' 📌 Nút Làm Mới (Clear textbox + bỏ chọn DataGridView)
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtMaSach.Clear()
        txtTenSach.Clear()
        txtTacGia.Clear()
        txtTheLoai.Clear()
        txtSoLuong.Clear()
        dgvSach.ClearSelection()
    End Sub

    ' 📌 Nút Hiển thị toàn bộ sách
    Private Sub btnHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        LoadData()
    End Sub

    ' 📌 Nút Tìm kiếm sách
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim tukhoa As String = txtTimKiem.Text.Trim()

        If tukhoa = "" Then
            MessageBox.Show("Vui lòng nhập Mã sách hoặc Tên sách để tìm kiếm!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaSach, TenSach, TacGia, TheLoai, SoLuong 
                                   FROM Sach 
                                   WHERE MaSach LIKE @TuKhoa OR TenSach LIKE @TuKhoa"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" & tukhoa & "%")
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvSach.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
        End Try
    End Sub

End Class

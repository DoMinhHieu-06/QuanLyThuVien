Imports System.Data.SqlClient

Public Class ucBaoCao
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub ucBaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=DESKTOP-15CO6TL\MSSQLSERVER01;Initial Catalog=Ql_thuvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        LoadThongKe()
        LoadBaoCao()
    End Sub

    ' Hàm load thống kê tổng
    Private Sub LoadThongKe()
        Try
            conn.Open()
            ' Tổng số sách
            Dim cmd1 As New SqlCommand("SELECT COUNT(*) FROM Sach", conn)
            txtTongSach.Text = cmd1.ExecuteScalar().ToString()

            ' Tổng số độc giả
            Dim cmd2 As New SqlCommand("SELECT COUNT(*) FROM DocGia", conn)
            txtTongDocGia.Text = cmd2.ExecuteScalar().ToString()

            ' Tổng số lượt mượn
            Dim cmd3 As New SqlCommand("SELECT COUNT(*) FROM MuonTra", conn)
            txtTongMuon.Text = cmd3.ExecuteScalar().ToString()

        Catch ex As Exception
            MessageBox.Show("Lỗi thống kê: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Hàm load chi tiết mượn – trả
    Private Sub LoadBaoCao(Optional ByVal tuNgay As Date = Nothing, Optional ByVal denNgay As Date = Nothing)
        Try
            Dim sql As String = "SELECT MT.MaMuonTra, DG.TenDocGia, S.TenSach, MT.NgayMuon, MT.NgayTra, MT.TrangThai
                                 FROM MuonTra MT
                                 INNER JOIN DocGia DG ON MT.MaDocGia = DG.MaDocGia
                                 INNER JOIN Sach S ON MT.MaSach = S.MaSach"

            ' Nếu có lọc ngày
            If tuNgay <> Nothing And denNgay <> Nothing Then
                sql &= " WHERE MT.NgayMuon BETWEEN @TuNgay AND @DenNgay"
            End If

            da = New SqlDataAdapter(sql, conn)

            If tuNgay <> Nothing And denNgay <> Nothing Then
                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay)
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay)
            End If

            dt = New DataTable()
            da.Fill(dt)
            dgvBaoCao.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Lỗi báo cáo: " & ex.Message)
        End Try
    End Sub

    ' Nút thống kê theo ngày
    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        LoadBaoCao(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date)
    End Sub

    ' Nút hiển thị tất cả
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        LoadBaoCao()
    End Sub

    Private Sub dgvBaoCao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaoCao.CellContentClick

    End Sub
End Class

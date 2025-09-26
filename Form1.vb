Imports System.Data.SqlClient
Module DB
    ' Biến kết nối toàn cục
    Public conn As SqlConnection

    ' Hàm kết nối đến SQL Server
    Public Sub ConnectDB()
        ' 👉 Chuỗi kết nối SQL Server
        conn = New SqlConnection("Data Source=DESKTOP-15CO6TL\MSSQLSERVER01;Initial Catalog=Ql_thuvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        conn.Open()
    End Sub
End Module

Public Class Form1
    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim user As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()

        If user = "" Or pass = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.")
            Exit Sub
        End If

        Try
            ConnectDB()
            Dim query As String = "SELECT * FROM Users WHERE Username=@u AND Password=@p"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@u", user)
            cmd.Parameters.AddWithValue("@p", pass)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                conn.Close()
                Me.Hide()
                frmMain.Show()
            Else
                conn.Close()
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối: " & ex.Message)
        End Try
    End Sub
End Class

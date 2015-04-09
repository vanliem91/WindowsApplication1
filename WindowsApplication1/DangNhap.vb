Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class fmrDangnhap

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        Me.Close()
    End Sub

    Private Sub bntDangnhap_Click(sender As Object, e As EventArgs) Handles bntDangnhap.Click
        Dim ChuoiSomee As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"
        Dim Ketnoi As SqlConnection = New SqlConnection(ChuoiSomee)
        Dim SqlAdapter As New SqlDataAdapter("Select * from BNhanVien where MaNV ='" & txtTaikhoan.Text & "' and Matkhau='" & txtMatkhau.Text & "' ", Ketnoi)
        Dim table As New DataTable

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(table)
            If table.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                frmGiaodien.Show()

                Me.Hide()
            Else
                MessageBox.Show("Sai tên Đăng Nhập hoặc Mật Khẩu")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bntNhaplai_Click(sender As Object, e As EventArgs) Handles bntNhaplai.Click
        txtMatkhau.Text = ""
        txtTaikhoan.Text = ""
    End Sub

    Private Sub fmrDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

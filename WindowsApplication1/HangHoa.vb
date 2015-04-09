Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmHanghoa
    Public Sub loaddata()
        Dim KetNoi As New SqlConnection(connect)
        Dim SqlAdapter As New SqlDataAdapter("Select * From SanPham", KetNoi)
        Try
            KetNoi.Open()
            SqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        KetNoi.Close()

    End Sub
    Dim connect As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"
    Dim tb As New DataTable


    Private Sub frmHanghoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        Dim SqlAdapter As New SqlDataAdapter("Select * From SanPham", KetNoi)
        Try
            KetNoi.Open()
            SqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub dgvBang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBang.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim Dulieu As Integer = dgvBang.CurrentCell.RowIndex
        txtSP.Text = dgvBang.Item(0, Dulieu).Value
        txtGia.Text = dgvBang.Item(1, Dulieu).Value
        txtSL.Text = dgvBang.Item(2, Dulieu).Value
        txtL.Text = dgvBang.Item(3, Dulieu).Value
        txtCT.Text = dgvBang.Item(4, Dulieu).Value

    End Sub

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        frmGiaodien.Show()
        Me.Hide()
    End Sub

    Private Sub bntXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        Dim KetNoi As New SqlConnection(connect)
        KetNoi.Open()
        Dim Xoa As String = "DELETE FROM SanPham WHERE SanPham=@SanPham"
        Dim sl As New SqlCommand(Xoa, KetNoi)
        Try
            sl.Parameters.AddWithValue("@SanPham", txtSP.Text)

            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Đã xóa sản phẩm thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb
        dgvBang.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click
        Dim KetNoi As New SqlConnection(connect)
        KetNoi.Open()
        Dim Them As String = "INSERT INTO SanPham VALUES ( @SanPham ,@Gia , @SoLuong ,@loai,@ChiTiet )"
        Dim sl As New SqlCommand(Them, KetNoi)
        Try
            sl.Parameters.AddWithValue("@SanPham", txtSP.Text)
            sl.Parameters.AddWithValue("@Gia", txtGia.Text)
            sl.Parameters.AddWithValue("@SoLuong", txtSL.Text)
            sl.Parameters.AddWithValue("@loai", txtL.Text)
            sl.Parameters.AddWithValue("@ChiTiet", txtCT.Text)

            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Thêm Sản Phẩm hoàn tất")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb
        dgvBang.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub bntSua_Click(sender As Object, e As EventArgs) Handles bntSua.Click
        Dim KetNoi As New SqlConnection(connect)
        KetNoi.Open()
        Dim Sua As String = "UPDATE SanPham SET SanPham=@SanPham ,Gia=@Gia ,SoLuong= @SoLuong ,Loai=@loai,ChiTiet=@ChiTiet"
        Dim sl As New SqlCommand(Sua, KetNoi)
        Try
            sl.Parameters.AddWithValue("@SanPham", txtSP.Text)
            sl.Parameters.AddWithValue("@Gia", txtGia.Text)
            sl.Parameters.AddWithValue("@SoLuong", txtSL.Text)
            sl.Parameters.AddWithValue("@loai", txtL.Text)
            sl.Parameters.AddWithValue("@ChiTiet", txtCT.Text)

            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Sửa thông tin Sản Phẩm hoàn tất")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb
        dgvBang.DataSource = Nothing
        loaddata()


    End Sub
End Class

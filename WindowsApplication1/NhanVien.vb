Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmNhanvien
    Public Sub loaddata()
        Dim KetNoi As New SqlConnection(connect)
        Dim SqlAdapter As New SqlDataAdapter("Select * From TNhanVien", KetNoi)
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

    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        Dim SqlAdapter As New SqlDataAdapter("Select * From TNhanVien", KetNoi)
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
        txtHoten.Text = dgvBang.Item(0, Dulieu).Value
        txtChucvu.Text = dgvBang.Item(1, Dulieu).Value
        txtSdt.Text = dgvBang.Item(2, Dulieu).Value
        txtLuong.Text = dgvBang.Item(3, Dulieu).Value
    End Sub

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        frmGiaodien.Show()
        Me.Hide()

    End Sub

    Private Sub bntXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        Dim KetNoi As New SqlConnection(connect)
        KetNoi.Open()
        Dim Xoa As String = "DELETE FROM TNhanVien WHERE HoTen=@HoTen"
        Dim sl As New SqlCommand(Xoa, KetNoi)
        Try
            sl.Parameters.AddWithValue("@HoTen", txtHoten.Text)
         
            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Đã xóa nhân viên thành công")
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
        Dim Them As String = "INSERT INTO TNhanVien VALUES ( @HoTen ,@ChucVu , @SDT ,Luong =@Luong)"
        Dim sl As New SqlCommand(Them, KetNoi)
        Try
            sl.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            sl.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
            sl.Parameters.AddWithValue("@SDT", txtSdt.Text)
            sl.Parameters.AddWithValue("@Luong", txtLuong.Text)

            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Thêm Nhân Viên hoàn tất")
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
        Dim Sua As String = "UPDATE TNhanVien SET HoTen = @HoTen ,ChucVu =@ChucVu , SDT =@SDT ,Luong =@Luong WHERE HoTen=@HoTen"
        Dim sl As New SqlCommand(Sua, KetNoi)
        Try
            sl.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            sl.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
            sl.Parameters.AddWithValue("@SDT", txtSdt.Text)
            sl.Parameters.AddWithValue("@Luong", txtLuong.Text)

            sl.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Sửa thông tin Nhân Viên hoàn tất")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb
        dgvBang.DataSource = Nothing
        loaddata()


    End Sub
End Class
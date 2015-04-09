Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmGiaodien
    Dim connect As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"
    Dim tb As New DataTable

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        fmrDangnhap.Show()
        Me.Hide()
    End Sub

    Private Sub AToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        frmNhanvien.Show()
        Me.Hide()

    End Sub

    Private Sub frmGiaodien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        Dim SqlAdapter As New SqlDataAdapter("Select * from BNhanVien where MaNV ='" & fmrDangnhap.txtTaikhoan.Text & "' ", KetNoi)
     

    

        lblXinchao.Text = "Xin Chào " + fmrDangnhap.txtTaikhoan.Text + " Chúc một ngày làm việc tốt lành"
    End Sub

    Private Sub lblXinchao_Click(sender As Object, e As EventArgs) Handles lblXinchao.Click

    End Sub

    Private Sub HàngTrongKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HàngTrongKhoToolStripMenuItem.Click
        frmHanghoa.Show()
        Me.Hide()
    End Sub
End Class
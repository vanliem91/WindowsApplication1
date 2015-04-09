<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrDangnhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTaikhoan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.bntDangnhap = New System.Windows.Forms.Button()
        Me.bntNhaplai = New System.Windows.Forms.Button()
        Me.bntThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTaikhoan
        '
        Me.txtTaikhoan.Location = New System.Drawing.Point(164, 28)
        Me.txtTaikhoan.Name = "txtTaikhoan"
        Me.txtTaikhoan.Size = New System.Drawing.Size(125, 20)
        Me.txtTaikhoan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tài khoản:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu:"
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(164, 67)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhau.Size = New System.Drawing.Size(125, 20)
        Me.txtMatkhau.TabIndex = 3
        '
        'bntDangnhap
        '
        Me.bntDangnhap.Location = New System.Drawing.Point(29, 107)
        Me.bntDangnhap.Name = "bntDangnhap"
        Me.bntDangnhap.Size = New System.Drawing.Size(75, 23)
        Me.bntDangnhap.TabIndex = 4
        Me.bntDangnhap.Text = "Đăng nhập"
        Me.bntDangnhap.UseVisualStyleBackColor = True
        '
        'bntNhaplai
        '
        Me.bntNhaplai.Location = New System.Drawing.Point(137, 107)
        Me.bntNhaplai.Name = "bntNhaplai"
        Me.bntNhaplai.Size = New System.Drawing.Size(75, 23)
        Me.bntNhaplai.TabIndex = 5
        Me.bntNhaplai.Text = "Nhập lại"
        Me.bntNhaplai.UseVisualStyleBackColor = True
        '
        'bntThoat
        '
        Me.bntThoat.Location = New System.Drawing.Point(241, 107)
        Me.bntThoat.Name = "bntThoat"
        Me.bntThoat.Size = New System.Drawing.Size(75, 23)
        Me.bntThoat.TabIndex = 6
        Me.bntThoat.Text = "Thoát"
        Me.bntThoat.UseVisualStyleBackColor = True
        '
        'fmrDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 151)
        Me.Controls.Add(Me.bntThoat)
        Me.Controls.Add(Me.bntNhaplai)
        Me.Controls.Add(Me.bntDangnhap)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaikhoan)
        Me.Name = "fmrDangnhap"
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents bntDangnhap As System.Windows.Forms.Button
    Friend WithEvents bntNhaplai As System.Windows.Forms.Button
    Friend WithEvents bntThoat As System.Windows.Forms.Button

End Class

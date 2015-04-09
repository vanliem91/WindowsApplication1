<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanvien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvBang = New System.Windows.Forms.DataGridView()
        Me.txtHoten = New System.Windows.Forms.TextBox()
        Me.txtChucvu = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.txtLuong = New System.Windows.Forms.TextBox()
        Me.bntThem = New System.Windows.Forms.Button()
        Me.bntSua = New System.Windows.Forms.Button()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.bntThoat = New System.Windows.Forms.Button()
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ tên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chức vụ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số điện thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lương:"
        '
        'dgvBang
        '
        Me.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBang.Location = New System.Drawing.Point(49, 218)
        Me.dgvBang.Name = "dgvBang"
        Me.dgvBang.Size = New System.Drawing.Size(466, 150)
        Me.dgvBang.TabIndex = 4
        '
        'txtHoten
        '
        Me.txtHoten.Location = New System.Drawing.Point(173, 32)
        Me.txtHoten.Name = "txtHoten"
        Me.txtHoten.Size = New System.Drawing.Size(246, 20)
        Me.txtHoten.TabIndex = 5
        '
        'txtChucvu
        '
        Me.txtChucvu.Location = New System.Drawing.Point(173, 69)
        Me.txtChucvu.Name = "txtChucvu"
        Me.txtChucvu.Size = New System.Drawing.Size(246, 20)
        Me.txtChucvu.TabIndex = 6
        '
        'txtSdt
        '
        Me.txtSdt.Location = New System.Drawing.Point(173, 104)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(246, 20)
        Me.txtSdt.TabIndex = 7
        '
        'txtLuong
        '
        Me.txtLuong.Location = New System.Drawing.Point(173, 143)
        Me.txtLuong.Name = "txtLuong"
        Me.txtLuong.Size = New System.Drawing.Size(246, 20)
        Me.txtLuong.TabIndex = 8
        '
        'bntThem
        '
        Me.bntThem.Location = New System.Drawing.Point(66, 177)
        Me.bntThem.Name = "bntThem"
        Me.bntThem.Size = New System.Drawing.Size(75, 23)
        Me.bntThem.TabIndex = 9
        Me.bntThem.Text = "Thêm"
        Me.bntThem.UseVisualStyleBackColor = True
        '
        'bntSua
        '
        Me.bntSua.Location = New System.Drawing.Point(187, 177)
        Me.bntSua.Name = "bntSua"
        Me.bntSua.Size = New System.Drawing.Size(75, 23)
        Me.bntSua.TabIndex = 10
        Me.bntSua.Text = "Sửa"
        Me.bntSua.UseVisualStyleBackColor = True
        '
        'bntXoa
        '
        Me.bntXoa.Location = New System.Drawing.Point(307, 177)
        Me.bntXoa.Name = "bntXoa"
        Me.bntXoa.Size = New System.Drawing.Size(75, 23)
        Me.bntXoa.TabIndex = 11
        Me.bntXoa.Text = "Xóa"
        Me.bntXoa.UseVisualStyleBackColor = True
        '
        'bntThoat
        '
        Me.bntThoat.Location = New System.Drawing.Point(431, 177)
        Me.bntThoat.Name = "bntThoat"
        Me.bntThoat.Size = New System.Drawing.Size(75, 23)
        Me.bntThoat.TabIndex = 12
        Me.bntThoat.Text = "Thoát"
        Me.bntThoat.UseVisualStyleBackColor = True
        '
        'frmNhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 380)
        Me.Controls.Add(Me.bntThoat)
        Me.Controls.Add(Me.bntXoa)
        Me.Controls.Add(Me.bntSua)
        Me.Controls.Add(Me.bntThem)
        Me.Controls.Add(Me.txtLuong)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtChucvu)
        Me.Controls.Add(Me.txtHoten)
        Me.Controls.Add(Me.dgvBang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNhanvien"
        Me.Text = "Nhân Viên"
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvBang As System.Windows.Forms.DataGridView
    Friend WithEvents txtHoten As System.Windows.Forms.TextBox
    Friend WithEvents txtChucvu As System.Windows.Forms.TextBox
    Friend WithEvents txtSdt As System.Windows.Forms.TextBox
    Friend WithEvents txtLuong As System.Windows.Forms.TextBox
    Friend WithEvents bntThem As System.Windows.Forms.Button
    Friend WithEvents bntSua As System.Windows.Forms.Button
    Friend WithEvents bntXoa As System.Windows.Forms.Button
    Friend WithEvents bntThoat As System.Windows.Forms.Button
End Class

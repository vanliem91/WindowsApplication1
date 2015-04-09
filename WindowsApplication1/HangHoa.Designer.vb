<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHanghoa
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
        Me.txtCT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bntThoat = New System.Windows.Forms.Button()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.bntSua = New System.Windows.Forms.Button()
        Me.bntThem = New System.Windows.Forms.Button()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtSP = New System.Windows.Forms.TextBox()
        Me.dgvBang = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCT
        '
        Me.txtCT.Location = New System.Drawing.Point(162, 167)
        Me.txtCT.Name = "txtCT"
        Me.txtCT.Size = New System.Drawing.Size(246, 20)
        Me.txtCT.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Chi Tiết"
        '
        'bntThoat
        '
        Me.bntThoat.Location = New System.Drawing.Point(413, 199)
        Me.bntThoat.Name = "bntThoat"
        Me.bntThoat.Size = New System.Drawing.Size(75, 23)
        Me.bntThoat.TabIndex = 27
        Me.bntThoat.Text = "Thoát"
        Me.bntThoat.UseVisualStyleBackColor = True
        '
        'bntXoa
        '
        Me.bntXoa.Location = New System.Drawing.Point(291, 199)
        Me.bntXoa.Name = "bntXoa"
        Me.bntXoa.Size = New System.Drawing.Size(75, 23)
        Me.bntXoa.TabIndex = 26
        Me.bntXoa.Text = "Xóa"
        Me.bntXoa.UseVisualStyleBackColor = True
        '
        'bntSua
        '
        Me.bntSua.Location = New System.Drawing.Point(175, 199)
        Me.bntSua.Name = "bntSua"
        Me.bntSua.Size = New System.Drawing.Size(75, 23)
        Me.bntSua.TabIndex = 25
        Me.bntSua.Text = "Sửa"
        Me.bntSua.UseVisualStyleBackColor = True
        '
        'bntThem
        '
        Me.bntThem.Location = New System.Drawing.Point(50, 199)
        Me.bntThem.Name = "bntThem"
        Me.bntThem.Size = New System.Drawing.Size(75, 23)
        Me.bntThem.TabIndex = 24
        Me.bntThem.Text = "Thêm"
        Me.bntThem.UseVisualStyleBackColor = True
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(161, 124)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(246, 20)
        Me.txtL.TabIndex = 23
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(161, 85)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(246, 20)
        Me.txtSL.TabIndex = 22
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(161, 50)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(246, 20)
        Me.txtGia.TabIndex = 21
        '
        'txtSP
        '
        Me.txtSP.Location = New System.Drawing.Point(161, 13)
        Me.txtSP.Name = "txtSP"
        Me.txtSP.Size = New System.Drawing.Size(246, 20)
        Me.txtSP.TabIndex = 20
        '
        'dgvBang
        '
        Me.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBang.Location = New System.Drawing.Point(37, 243)
        Me.dgvBang.Name = "dgvBang"
        Me.dgvBang.Size = New System.Drawing.Size(466, 150)
        Me.dgvBang.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Loại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Số Lượng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Giá"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sản Phẩm"
        '
        'frmHanghoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 404)
        Me.Controls.Add(Me.txtCT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bntThoat)
        Me.Controls.Add(Me.bntXoa)
        Me.Controls.Add(Me.bntSua)
        Me.Controls.Add(Me.bntThem)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtSP)
        Me.Controls.Add(Me.dgvBang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHanghoa"
        Me.Text = "Quản Lý hàng hóa"
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bntThoat As System.Windows.Forms.Button
    Friend WithEvents bntXoa As System.Windows.Forms.Button
    Friend WithEvents bntSua As System.Windows.Forms.Button
    Friend WithEvents bntThem As System.Windows.Forms.Button
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtSP As System.Windows.Forms.TextBox
    Friend WithEvents dgvBang As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

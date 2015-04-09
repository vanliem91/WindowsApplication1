<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaodien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiaodien))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngTrongKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngChờNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngĐãBánToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhầnMềmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblXinchao = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.HàngHóaToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.PhầnMềmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.AToolStripMenuItem1})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AToolStripMenuItem.Text = "Đăng xuất"
        '
        'AToolStripMenuItem1
        '
        Me.AToolStripMenuItem1.Name = "AToolStripMenuItem1"
        Me.AToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.AToolStripMenuItem1.Text = "Thoát"
        '
        'HàngHóaToolStripMenuItem
        '
        Me.HàngHóaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HàngTrongKhoToolStripMenuItem, Me.HàngChờNhậpToolStripMenuItem, Me.HàngĐãBánToolStripMenuItem})
        Me.HàngHóaToolStripMenuItem.Name = "HàngHóaToolStripMenuItem"
        Me.HàngHóaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.HàngHóaToolStripMenuItem.Text = "Hàng Hóa"
        '
        'HàngTrongKhoToolStripMenuItem
        '
        Me.HàngTrongKhoToolStripMenuItem.Name = "HàngTrongKhoToolStripMenuItem"
        Me.HàngTrongKhoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngTrongKhoToolStripMenuItem.Text = "Hàng trong kho"
        '
        'HàngChờNhậpToolStripMenuItem
        '
        Me.HàngChờNhậpToolStripMenuItem.Name = "HàngChờNhậpToolStripMenuItem"
        Me.HàngChờNhậpToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngChờNhậpToolStripMenuItem.Text = "Hàng chờ nhập"
        '
        'HàngĐãBánToolStripMenuItem
        '
        Me.HàngĐãBánToolStripMenuItem.Name = "HàngĐãBánToolStripMenuItem"
        Me.HàngĐãBánToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngĐãBánToolStripMenuItem.Text = "Hàng đã bán"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchNhânViênToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'DanhSáchNhânViênToolStripMenuItem
        '
        Me.DanhSáchNhânViênToolStripMenuItem.Name = "DanhSáchNhânViênToolStripMenuItem"
        Me.DanhSáchNhânViênToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DanhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên"
        '
        'PhầnMềmToolStripMenuItem
        '
        Me.PhầnMềmToolStripMenuItem.Name = "PhầnMềmToolStripMenuItem"
        Me.PhầnMềmToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PhầnMềmToolStripMenuItem.Text = "Phần Mềm"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(67, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 150)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblXinchao
        '
        Me.lblXinchao.AutoSize = True
        Me.lblXinchao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXinchao.Location = New System.Drawing.Point(12, 48)
        Me.lblXinchao.Name = "lblXinchao"
        Me.lblXinchao.Size = New System.Drawing.Size(224, 20)
        Me.lblXinchao.TabIndex = 2
        Me.lblXinchao.Text = "                                           "
        '
        'frmGiaodien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 273)
        Me.Controls.Add(Me.lblXinchao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGiaodien"
        Me.Text = "Giao Diện Chính"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngHóaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngTrongKhoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngChờNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngĐãBánToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhầnMềmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblXinchao As System.Windows.Forms.Label
End Class

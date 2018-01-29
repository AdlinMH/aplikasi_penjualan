<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTambahBarang
    Inherits Inventory.FormBasic

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rbKode = New System.Windows.Forms.RadioButton()
        Me.tbPencarian = New System.Windows.Forms.TextBox()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbStokBaru = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbHargaJual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbHargaBeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSatuan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(725, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(725, 50)
        Me.lblTitle.Text = "Tambah Barang"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gvData)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Size = New System.Drawing.Size(725, 596)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbKode)
        Me.Panel7.Controls.Add(Me.tbPencarian)
        Me.Panel7.Controls.Add(Me.rbNama)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 133)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(725, 47)
        Me.Panel7.TabIndex = 20
        '
        'rbKode
        '
        Me.rbKode.AutoSize = True
        Me.rbKode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rbKode.Location = New System.Drawing.Point(6, 15)
        Me.rbKode.Name = "rbKode"
        Me.rbKode.Size = New System.Drawing.Size(49, 17)
        Me.rbKode.TabIndex = 14
        Me.rbKode.TabStop = True
        Me.rbKode.Text = "Kode"
        Me.rbKode.UseVisualStyleBackColor = True
        '
        'tbPencarian
        '
        Me.tbPencarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPencarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPencarian.Location = New System.Drawing.Point(127, 15)
        Me.tbPencarian.Name = "tbPencarian"
        Me.tbPencarian.Size = New System.Drawing.Size(155, 20)
        Me.tbPencarian.TabIndex = 16
        '
        'rbNama
        '
        Me.rbNama.AutoSize = True
        Me.rbNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rbNama.Location = New System.Drawing.Point(62, 15)
        Me.rbNama.Name = "rbNama"
        Me.rbNama.Size = New System.Drawing.Size(52, 17)
        Me.rbNama.TabIndex = 15
        Me.rbNama.TabStop = True
        Me.rbNama.Text = "Nama"
        Me.rbNama.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tbStokBaru)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.tbHargaJual)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.tbHargaBeli)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.tbSatuan)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.tbStok)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.tbNama)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(725, 133)
        Me.Panel6.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(79, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tambah Stok"
        '
        'tbStokBaru
        '
        Me.tbStokBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbStokBaru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbStokBaru.Location = New System.Drawing.Point(82, 98)
        Me.tbStokBaru.Name = "tbStokBaru"
        Me.tbStokBaru.Size = New System.Drawing.Size(70, 20)
        Me.tbStokBaru.TabIndex = 14
        Me.tbStokBaru.Text = "0"
        Me.tbStokBaru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(368, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Harga Jual"
        '
        'tbHargaJual
        '
        Me.tbHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbHargaJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.errMessage.SetIconAlignment(Me.tbHargaJual, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.tbHargaJual.Location = New System.Drawing.Point(371, 98)
        Me.tbHargaJual.Name = "tbHargaJual"
        Me.tbHargaJual.Size = New System.Drawing.Size(150, 20)
        Me.tbHargaJual.TabIndex = 17
        Me.tbHargaJual.Text = "0"
        Me.tbHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(368, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Harga Beli"
        '
        'tbHargaBeli
        '
        Me.tbHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbHargaBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.errMessage.SetIconAlignment(Me.tbHargaBeli, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.tbHargaBeli.Location = New System.Drawing.Point(371, 52)
        Me.tbHargaBeli.Name = "tbHargaBeli"
        Me.tbHargaBeli.Size = New System.Drawing.Size(150, 20)
        Me.tbHargaBeli.TabIndex = 15
        Me.tbHargaBeli.Text = "0"
        Me.tbHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(155, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Satuan"
        '
        'tbSatuan
        '
        Me.tbSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSatuan.Enabled = False
        Me.tbSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSatuan.Location = New System.Drawing.Point(158, 98)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.Size = New System.Drawing.Size(70, 20)
        Me.tbSatuan.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stok"
        '
        'tbStok
        '
        Me.tbStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbStok.Enabled = False
        Me.tbStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbStok.Location = New System.Drawing.Point(6, 98)
        Me.tbStok.Name = "tbStok"
        Me.tbStok.Size = New System.Drawing.Size(70, 20)
        Me.tbStok.TabIndex = 11
        Me.tbStok.Text = "0"
        Me.tbStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Barang"
        '
        'tbKode
        '
        Me.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKode.Enabled = False
        Me.tbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbKode.Location = New System.Drawing.Point(82, 8)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(70, 20)
        Me.tbKode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Barang"
        '
        'tbNama
        '
        Me.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNama.Enabled = False
        Me.tbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNama.Location = New System.Drawing.Point(6, 52)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(200, 20)
        Me.tbNama.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.btnReload)
        Me.Panel8.Controls.Add(Me.btnUbah)
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnBatal)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 531)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(725, 65)
        Me.Panel8.TabIndex = 22
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnReload.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReload.FlatAppearance.BorderSize = 0
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.Image = Global.Inventory.My.Resources.Resources.ic_cached_white_48dp_1x
        Me.btnReload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReload.Location = New System.Drawing.Point(0, 0)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(65, 65)
        Me.btnReload.TabIndex = 7
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUbah.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Image = Global.Inventory.My.Resources.Resources.ic_mode_edit_white_48dp_1x
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(465, 0)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(65, 65)
        Me.btnUbah.TabIndex = 4
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSimpan.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.Inventory.My.Resources.Resources.ic_save_white_48dp_1x
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(530, 0)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(65, 65)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBatal.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.Inventory.My.Resources.Resources.ic_cancel_white_48dp_1x
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(595, 0)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(65, 65)
        Me.btnBatal.TabIndex = 3
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTutup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Image = Global.Inventory.My.Resources.Resources.ic_exit_to_app_white_48dp_1x
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTutup.Location = New System.Drawing.Point(660, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 0
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'gvData
        '
        Me.gvData.AllowUserToAddRows = False
        Me.gvData.AllowUserToDeleteRows = False
        Me.gvData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvData.ColumnHeadersHeight = 35
        Me.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvData.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.EnableHeadersVisualStyles = False
        Me.gvData.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gvData.Location = New System.Drawing.Point(0, 180)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvData.RowHeadersVisible = False
        Me.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(725, 351)
        Me.gvData.TabIndex = 23
        '
        'FormTambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(725, 656)
        Me.Name = "FormTambahBarang"
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents rbKode As RadioButton
    Friend WithEvents tbPencarian As TextBox
    Friend WithEvents rbNama As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnReload As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbHargaBeli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSatuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStok As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbHargaJual As TextBox
    Friend WithEvents gvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbStokBaru As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPesanan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpanDetail = New System.Windows.Forms.Button()
        Me.tbSatuan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.tbBarang = New System.Windows.Forms.TextBox()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnPelanggan = New System.Windows.Forms.Button()
        Me.tbNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbPPN1 = New System.Windows.Forms.TextBox()
        Me.tbDiskon1 = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbPPN2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDiskon2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSubTotal = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(629, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(629, 50)
        Me.lblTitle.Text = "Pesanan Pelanggan"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gvData)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Size = New System.Drawing.Size(629, 611)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnBatal)
        Me.Panel7.Controls.Add(Me.btnSimpanDetail)
        Me.Panel7.Controls.Add(Me.tbSatuan)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.tbJumlah)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.btnBarang)
        Me.Panel7.Controls.Add(Me.tbBarang)
        Me.Panel7.Controls.Add(Me.tbNamaBarang)
        Me.Panel7.Controls.Add(Me.tbQty)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.tbHarga)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 169)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(629, 97)
        Me.Panel7.TabIndex = 22
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBatal.Enabled = False
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(470, 66)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(65, 20)
        Me.btnBatal.TabIndex = 27
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpanDetail
        '
        Me.btnSimpanDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSimpanDetail.Enabled = False
        Me.btnSimpanDetail.FlatAppearance.BorderSize = 0
        Me.btnSimpanDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanDetail.ForeColor = System.Drawing.Color.White
        Me.btnSimpanDetail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpanDetail.Location = New System.Drawing.Point(535, 66)
        Me.btnSimpanDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpanDetail.Name = "btnSimpanDetail"
        Me.btnSimpanDetail.Size = New System.Drawing.Size(65, 20)
        Me.btnSimpanDetail.TabIndex = 26
        Me.btnSimpanDetail.Text = "Simpan"
        Me.btnSimpanDetail.UseVisualStyleBackColor = False
        '
        'tbSatuan
        '
        Me.tbSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSatuan.Enabled = False
        Me.tbSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSatuan.Location = New System.Drawing.Point(82, 68)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.Size = New System.Drawing.Size(70, 20)
        Me.tbSatuan.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(79, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Satuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(284, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Sub Total"
        '
        'tbJumlah
        '
        Me.tbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbJumlah.Enabled = False
        Me.tbJumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbJumlah.Location = New System.Drawing.Point(287, 68)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(123, 20)
        Me.tbJumlah.TabIndex = 23
        Me.tbJumlah.Text = "0"
        Me.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Barang"
        '
        'btnBarang
        '
        Me.btnBarang.Enabled = False
        Me.btnBarang.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Location = New System.Drawing.Point(288, 26)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(26, 20)
        Me.btnBarang.TabIndex = 21
        Me.btnBarang.Text = "---"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'tbBarang
        '
        Me.tbBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBarang.Enabled = False
        Me.tbBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbBarang.Location = New System.Drawing.Point(6, 26)
        Me.tbBarang.Name = "tbBarang"
        Me.tbBarang.Size = New System.Drawing.Size(70, 20)
        Me.tbBarang.TabIndex = 19
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaBarang.Enabled = False
        Me.tbNamaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNamaBarang.Location = New System.Drawing.Point(82, 26)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaBarang.TabIndex = 20
        '
        'tbQty
        '
        Me.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQty.Enabled = False
        Me.tbQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbQty.Location = New System.Drawing.Point(6, 68)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(70, 20)
        Me.tbQty.TabIndex = 11
        Me.tbQty.Text = "0"
        Me.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(155, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Qty"
        '
        'tbHarga
        '
        Me.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbHarga.Enabled = False
        Me.tbHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbHarga.Location = New System.Drawing.Point(158, 68)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(123, 20)
        Me.tbHarga.TabIndex = 13
        Me.tbHarga.Text = "0"
        Me.tbHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.rtbAlamat)
        Me.Panel6.Controls.Add(Me.dtTanggal)
        Me.Panel6.Controls.Add(Me.btnPelanggan)
        Me.Panel6.Controls.Add(Me.tbNamaPelanggan)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.tbPelanggan)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(629, 169)
        Me.Panel6.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(341, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Alamat"
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Enabled = False
        Me.rtbAlamat.Location = New System.Drawing.Point(6, 98)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(308, 56)
        Me.rtbAlamat.TabIndex = 19
        Me.rtbAlamat.Text = ""
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(396, 8)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(147, 20)
        Me.dtTanggal.TabIndex = 18
        '
        'btnPelanggan
        '
        Me.btnPelanggan.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelanggan.Location = New System.Drawing.Point(288, 52)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Size = New System.Drawing.Size(26, 20)
        Me.btnPelanggan.TabIndex = 9
        Me.btnPelanggan.Text = "---"
        Me.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPelanggan.UseVisualStyleBackColor = True
        '
        'tbNamaPelanggan
        '
        Me.tbNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaPelanggan.Enabled = False
        Me.tbNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNamaPelanggan.Location = New System.Drawing.Point(82, 52)
        Me.tbNamaPelanggan.Name = "tbNamaPelanggan"
        Me.tbNamaPelanggan.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaPelanggan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pelanggan"
        '
        'tbPelanggan
        '
        Me.tbPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPelanggan.Enabled = False
        Me.tbPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPelanggan.Location = New System.Drawing.Point(6, 52)
        Me.tbPelanggan.Name = "tbPelanggan"
        Me.tbPelanggan.Size = New System.Drawing.Size(70, 20)
        Me.tbPelanggan.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Pesanan"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(422, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sub Total"
        '
        'gvData
        '
        Me.gvData.AllowUserToAddRows = False
        Me.gvData.AllowUserToDeleteRows = False
        Me.gvData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvData.ColumnHeadersHeight = 35
        Me.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column5, Me.Column6, Me.Column10, Me.Column7, Me.Column8, Me.Column9, Me.Column2, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvData.DefaultCellStyle = DataGridViewCellStyle5
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.EnableHeadersVisualStyles = False
        Me.gvData.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gvData.Location = New System.Drawing.Point(0, 266)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvData.RowHeadersVisible = False
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(629, 172)
        Me.gvData.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Kode_Barang"
        Me.Column3.HeaderText = "Kode Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Nama_Barang"
        Me.Column5.HeaderText = "Nama Barang"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "Qty"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Satuan"
        Me.Column10.HeaderText = "Satuan"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Harga"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.HeaderText = "Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Sub_Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column8.HeaderText = "Sub Total"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "No_Pesanan"
        Me.Column9.HeaderText = "No_Pesanan"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DataBarang"
        Me.Column2.HeaderText = "DataBarang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "DataPesanan"
        Me.Column4.HeaderText = "DataPesanan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.btnPrint)
        Me.Panel8.Controls.Add(Me.btnTambah)
        Me.Panel8.Controls.Add(Me.btnUbah)
        Me.Panel8.Controls.Add(Me.btnHapus)
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 546)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(629, 65)
        Me.Panel8.TabIndex = 24
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.Inventory.My.Resources.Resources.ic_print_white_48dp_1x
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(65, 65)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTambah.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Image = Global.Inventory.My.Resources.Resources.ic_add_circle_white_48dp_1x
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTambah.Location = New System.Drawing.Point(304, 0)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(65, 65)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTambah.UseVisualStyleBackColor = False
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
        Me.btnUbah.Location = New System.Drawing.Point(369, 0)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(65, 65)
        Me.btnUbah.TabIndex = 4
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHapus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = Global.Inventory.My.Resources.Resources.ic_delete_white_48dp_1x
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(434, 0)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(65, 65)
        Me.btnHapus.TabIndex = 1
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = False
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
        Me.btnSimpan.Location = New System.Drawing.Point(499, 0)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(65, 65)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = False
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
        Me.btnTutup.Location = New System.Drawing.Point(564, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 0
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.tbPPN1)
        Me.Panel1.Controls.Add(Me.tbDiskon1)
        Me.Panel1.Controls.Add(Me.tbTotal)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tbPPN2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbDiskon2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbSubTotal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 438)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 108)
        Me.Panel1.TabIndex = 25
        '
        'tbPPN1
        '
        Me.tbPPN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPPN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPPN1.Location = New System.Drawing.Point(481, 58)
        Me.tbPPN1.Name = "tbPPN1"
        Me.tbPPN1.Size = New System.Drawing.Size(33, 20)
        Me.tbPPN1.TabIndex = 25
        Me.tbPPN1.Text = "0"
        Me.tbPPN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDiskon1
        '
        Me.tbDiskon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDiskon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbDiskon1.Location = New System.Drawing.Point(481, 32)
        Me.tbDiskon1.Name = "tbDiskon1"
        Me.tbDiskon1.Size = New System.Drawing.Size(33, 20)
        Me.tbDiskon1.TabIndex = 24
        Me.tbDiskon1.Text = "0"
        Me.tbDiskon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotal
        '
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.Enabled = False
        Me.tbTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbTotal.Location = New System.Drawing.Point(481, 84)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(135, 20)
        Me.tbTotal.TabIndex = 23
        Me.tbTotal.Text = "0"
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(444, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total"
        '
        'tbPPN2
        '
        Me.tbPPN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPPN2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPPN2.Location = New System.Drawing.Point(517, 58)
        Me.tbPPN2.Name = "tbPPN2"
        Me.tbPPN2.Size = New System.Drawing.Size(99, 20)
        Me.tbPPN2.TabIndex = 21
        Me.tbPPN2.Text = "0"
        Me.tbPPN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(446, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "PPN"
        '
        'tbDiskon2
        '
        Me.tbDiskon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDiskon2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbDiskon2.Location = New System.Drawing.Point(517, 32)
        Me.tbDiskon2.Name = "tbDiskon2"
        Me.tbDiskon2.Size = New System.Drawing.Size(99, 20)
        Me.tbDiskon2.TabIndex = 19
        Me.tbDiskon2.Text = "0"
        Me.tbDiskon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(435, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Diskon"
        '
        'tbSubTotal
        '
        Me.tbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSubTotal.Enabled = False
        Me.tbSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSubTotal.Location = New System.Drawing.Point(481, 6)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.Size = New System.Drawing.Size(135, 20)
        Me.tbSubTotal.TabIndex = 17
        Me.tbSubTotal.Text = "0"
        Me.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(629, 671)
        Me.Name = "FormPesanan"
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbQty As TextBox
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents tbNamaPelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents gvData As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents tbBarang As TextBox
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbAlamat As RichTextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbPPN2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbDiskon2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSubTotal As TextBox
    Friend WithEvents tbSatuan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents tbPPN1 As TextBox
    Friend WithEvents tbDiskon1 As TextBox
    Friend WithEvents btnSimpanDetail As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

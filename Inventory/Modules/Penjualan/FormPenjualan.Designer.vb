<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.btnPesanan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.tbNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPesanan = New System.Windows.Forms.TextBox()
        Me.panelKredit = New System.Windows.Forms.Panel()
        Me.dtTempo = New System.Windows.Forms.DateTimePicker()
        Me.cbTermin = New System.Windows.Forms.ComboBox()
        Me.tbDibayarkan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbPPN1 = New System.Windows.Forms.TextBox()
        Me.tbDiskon1 = New System.Windows.Forms.TextBox()
        Me.tbPPN2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDiskon2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPanjar = New System.Windows.Forms.TextBox()
        Me.tbSisa = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.panelKredit.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(603, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(603, 50)
        Me.lblTitle.Text = "Penjualan"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.gvData)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Size = New System.Drawing.Size(603, 628)
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.cbJenis)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Controls.Add(Me.btnPesanan)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.rtbAlamat)
        Me.Panel6.Controls.Add(Me.dtTanggal)
        Me.Panel6.Controls.Add(Me.tbNamaPelanggan)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.tbPelanggan)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbPesanan)
        Me.Panel6.Controls.Add(Me.panelKredit)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(603, 209)
        Me.Panel6.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Jenis Pembayaran"
        '
        'cbJenis
        '
        Me.cbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Tunai", "Kredit"})
        Me.cbJenis.Location = New System.Drawing.Point(108, 42)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(62, 21)
        Me.cbJenis.TabIndex = 28
        Me.cbJenis.Text = "Tunai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(325, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "No. Penjualan"
        '
        'tbKode
        '
        Me.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKode.Enabled = False
        Me.tbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbKode.Location = New System.Drawing.Point(108, 10)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(82, 20)
        Me.tbKode.TabIndex = 24
        '
        'btnPesanan
        '
        Me.btnPesanan.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesanan.Location = New System.Drawing.Point(164, 75)
        Me.btnPesanan.Name = "btnPesanan"
        Me.btnPesanan.Size = New System.Drawing.Size(26, 20)
        Me.btnPesanan.TabIndex = 22
        Me.btnPesanan.Text = "---"
        Me.btnPesanan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesanan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Alamat"
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Enabled = False
        Me.rtbAlamat.Location = New System.Drawing.Point(88, 130)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(219, 56)
        Me.rtbAlamat.TabIndex = 19
        Me.rtbAlamat.Text = ""
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(423, 12)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(158, 20)
        Me.dtTanggal.TabIndex = 18
        '
        'tbNamaPelanggan
        '
        Me.tbNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaPelanggan.Enabled = False
        Me.tbNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNamaPelanggan.Location = New System.Drawing.Point(164, 101)
        Me.tbNamaPelanggan.Name = "tbNamaPelanggan"
        Me.tbNamaPelanggan.Size = New System.Drawing.Size(143, 20)
        Me.tbNamaPelanggan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 103)
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
        Me.tbPelanggan.Location = New System.Drawing.Point(88, 101)
        Me.tbPelanggan.Name = "tbPelanggan"
        Me.tbPelanggan.Size = New System.Drawing.Size(70, 20)
        Me.tbPelanggan.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Pesanan"
        '
        'tbPesanan
        '
        Me.tbPesanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPesanan.Enabled = False
        Me.tbPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPesanan.Location = New System.Drawing.Point(88, 75)
        Me.tbPesanan.Name = "tbPesanan"
        Me.tbPesanan.Size = New System.Drawing.Size(70, 20)
        Me.tbPesanan.TabIndex = 3
        '
        'panelKredit
        '
        Me.panelKredit.Controls.Add(Me.dtTempo)
        Me.panelKredit.Controls.Add(Me.cbTermin)
        Me.panelKredit.Controls.Add(Me.tbDibayarkan)
        Me.panelKredit.Controls.Add(Me.Label6)
        Me.panelKredit.Controls.Add(Me.Label15)
        Me.panelKredit.Controls.Add(Me.Label16)
        Me.panelKredit.Controls.Add(Me.Label14)
        Me.panelKredit.Location = New System.Drawing.Point(315, 64)
        Me.panelKredit.Name = "panelKredit"
        Me.panelKredit.Size = New System.Drawing.Size(276, 109)
        Me.panelKredit.TabIndex = 31
        '
        'dtTempo
        '
        Me.dtTempo.Enabled = False
        Me.dtTempo.Location = New System.Drawing.Point(109, 42)
        Me.dtTempo.Name = "dtTempo"
        Me.dtTempo.Size = New System.Drawing.Size(158, 20)
        Me.dtTempo.TabIndex = 30
        '
        'cbTermin
        '
        Me.cbTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTermin.FormattingEnabled = True
        Me.cbTermin.Items.AddRange(New Object() {"1", "2", "3", "6", "9", "12"})
        Me.cbTermin.Location = New System.Drawing.Point(109, 12)
        Me.cbTermin.Name = "cbTermin"
        Me.cbTermin.Size = New System.Drawing.Size(40, 21)
        Me.cbTermin.TabIndex = 28
        Me.cbTermin.Text = "1"
        '
        'tbDibayarkan
        '
        Me.tbDibayarkan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDibayarkan.Enabled = False
        Me.tbDibayarkan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbDibayarkan.Location = New System.Drawing.Point(109, 73)
        Me.tbDibayarkan.Name = "tbDibayarkan"
        Me.tbDibayarkan.Size = New System.Drawing.Size(158, 20)
        Me.tbDibayarkan.TabIndex = 3
        Me.tbDibayarkan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Jatuh Tempo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(11, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Cicilan Dibayarkan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(156, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "/ bulan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(11, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Jumlah Cicilan"
        '
        'gvData
        '
        Me.gvData.AllowUserToAddRows = False
        Me.gvData.AllowUserToDeleteRows = False
        Me.gvData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvData.ColumnHeadersHeight = 35
        Me.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column7, Me.Column5, Me.Column4, Me.Column6})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvData.DefaultCellStyle = DataGridViewCellStyle4
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.EnableHeadersVisualStyles = False
        Me.gvData.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gvData.Location = New System.Drawing.Point(0, 209)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvData.RowHeadersVisible = False
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(603, 354)
        Me.gvData.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "NoPenjualan"
        Me.Column8.HeaderText = "NoPenjualan"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "KodeBarang"
        Me.Column2.HeaderText = "Kode Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Nama_Barang"
        Me.Column3.HeaderText = "Nama Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Qty"
        Me.Column7.HeaderText = "Qty"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Satuan"
        Me.Column5.HeaderText = "Satuan"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Harga"
        Me.Column4.HeaderText = "Harga"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Sub_Total"
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnBatal)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 563)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(603, 65)
        Me.Panel8.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Inventory.My.Resources.Resources.ic_print_white_48dp_1x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 65)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnSimpan.Location = New System.Drawing.Point(408, 0)
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
        Me.btnBatal.Location = New System.Drawing.Point(473, 0)
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
        Me.btnTutup.Location = New System.Drawing.Point(538, 0)
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
        Me.Panel1.Controls.Add(Me.tbPPN2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbDiskon2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbSubTotal)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.tbTotal)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tbPanjar)
        Me.Panel1.Controls.Add(Me.tbSisa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 173)
        Me.Panel1.TabIndex = 26
        '
        'tbPPN1
        '
        Me.tbPPN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPPN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPPN1.Location = New System.Drawing.Point(406, 59)
        Me.tbPPN1.Name = "tbPPN1"
        Me.tbPPN1.Size = New System.Drawing.Size(33, 20)
        Me.tbPPN1.TabIndex = 33
        Me.tbPPN1.Text = "0"
        Me.tbPPN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDiskon1
        '
        Me.tbDiskon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDiskon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbDiskon1.Location = New System.Drawing.Point(406, 33)
        Me.tbDiskon1.Name = "tbDiskon1"
        Me.tbDiskon1.Size = New System.Drawing.Size(33, 20)
        Me.tbDiskon1.TabIndex = 32
        Me.tbDiskon1.Text = "0"
        Me.tbDiskon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPPN2
        '
        Me.tbPPN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPPN2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPPN2.Location = New System.Drawing.Point(442, 59)
        Me.tbPPN2.Name = "tbPPN2"
        Me.tbPPN2.Size = New System.Drawing.Size(99, 20)
        Me.tbPPN2.TabIndex = 31
        Me.tbPPN2.Text = "0"
        Me.tbPPN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(371, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "PPN"
        '
        'tbDiskon2
        '
        Me.tbDiskon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDiskon2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbDiskon2.Location = New System.Drawing.Point(442, 33)
        Me.tbDiskon2.Name = "tbDiskon2"
        Me.tbDiskon2.Size = New System.Drawing.Size(99, 20)
        Me.tbDiskon2.TabIndex = 29
        Me.tbDiskon2.Text = "0"
        Me.tbDiskon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(360, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Diskon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(372, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Sisa"
        '
        'tbSubTotal
        '
        Me.tbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSubTotal.Enabled = False
        Me.tbSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSubTotal.Location = New System.Drawing.Point(406, 7)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.Size = New System.Drawing.Size(135, 20)
        Me.tbSubTotal.TabIndex = 17
        Me.tbSubTotal.Text = "0"
        Me.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(362, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Panjar"
        '
        'tbTotal
        '
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.Enabled = False
        Me.tbTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbTotal.Location = New System.Drawing.Point(406, 85)
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
        Me.Label12.Location = New System.Drawing.Point(368, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(346, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sub Total"
        '
        'tbPanjar
        '
        Me.tbPanjar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPanjar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPanjar.Location = New System.Drawing.Point(406, 111)
        Me.tbPanjar.Name = "tbPanjar"
        Me.tbPanjar.Size = New System.Drawing.Size(135, 20)
        Me.tbPanjar.TabIndex = 25
        Me.tbPanjar.Text = "0"
        Me.tbPanjar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSisa
        '
        Me.tbSisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSisa.Enabled = False
        Me.tbSisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSisa.Location = New System.Drawing.Point(406, 137)
        Me.tbSisa.Name = "tbSisa"
        Me.tbSisa.Size = New System.Drawing.Size(135, 20)
        Me.tbSisa.TabIndex = 27
        Me.tbSisa.Text = "0"
        Me.tbSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(603, 688)
        Me.Name = "FormPenjualan"
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelKredit.ResumeLayout(False)
        Me.panelKredit.PerformLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbAlamat As RichTextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents tbNamaPelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPesanan As TextBox
    Friend WithEvents gvData As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents btnPesanan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtTempo As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbSisa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbPanjar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbSubTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tbPPN1 As TextBox
    Friend WithEvents tbDiskon1 As TextBox
    Friend WithEvents tbPPN2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbDiskon2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents panelKredit As Panel
    Friend WithEvents tbDibayarkan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbTermin As ComboBox
    Friend WithEvents Label16 As Label
End Class

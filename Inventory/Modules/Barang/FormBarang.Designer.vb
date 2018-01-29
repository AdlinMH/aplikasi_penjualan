<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
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
        Me.rbKode = New System.Windows.Forms.RadioButton()
        Me.tbPencarian = New System.Windows.Forms.TextBox()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbHargaJual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbHargaBeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSatuan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStok = New System.Windows.Forms.TextBox()
        Me.btnKelompok = New System.Windows.Forms.Button()
        Me.tbNamaKelompok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKelompok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargabeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblTitle.Text = "Barang"
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
        Me.Panel7.Location = New System.Drawing.Point(0, 181)
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
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.tbHargaJual)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.tbHargaBeli)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.tbSatuan)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.tbStok)
        Me.Panel6.Controls.Add(Me.btnKelompok)
        Me.Panel6.Controls.Add(Me.tbNamaKelompok)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.tbKelompok)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.tbNama)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(725, 181)
        Me.Panel6.TabIndex = 19
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
        Me.Label6.Location = New System.Drawing.Point(79, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Satuan"
        '
        'tbSatuan
        '
        Me.tbSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSatuan.Location = New System.Drawing.Point(82, 144)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.Size = New System.Drawing.Size(70, 20)
        Me.tbSatuan.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stok"
        '
        'tbStok
        '
        Me.tbStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbStok.Location = New System.Drawing.Point(6, 144)
        Me.tbStok.Name = "tbStok"
        Me.tbStok.Size = New System.Drawing.Size(70, 20)
        Me.tbStok.TabIndex = 11
        Me.tbStok.Text = "0"
        Me.tbStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnKelompok
        '
        Me.btnKelompok.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKelompok.Location = New System.Drawing.Point(288, 98)
        Me.btnKelompok.Name = "btnKelompok"
        Me.btnKelompok.Size = New System.Drawing.Size(26, 20)
        Me.btnKelompok.TabIndex = 9
        Me.btnKelompok.Text = "---"
        Me.btnKelompok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKelompok.UseVisualStyleBackColor = True
        '
        'tbNamaKelompok
        '
        Me.tbNamaKelompok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaKelompok.Enabled = False
        Me.tbNamaKelompok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNamaKelompok.Location = New System.Drawing.Point(82, 98)
        Me.tbNamaKelompok.Name = "tbNamaKelompok"
        Me.tbNamaKelompok.Size = New System.Drawing.Size(200, 20)
        Me.tbNamaKelompok.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kelompok"
        '
        'tbKelompok
        '
        Me.tbKelompok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKelompok.Enabled = False
        Me.tbKelompok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbKelompok.Location = New System.Drawing.Point(6, 98)
        Me.tbKelompok.Name = "tbKelompok"
        Me.tbKelompok.Size = New System.Drawing.Size(70, 20)
        Me.tbKelompok.TabIndex = 7
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
        Me.Panel8.Controls.Add(Me.btnTambah)
        Me.Panel8.Controls.Add(Me.btnUbah)
        Me.Panel8.Controls.Add(Me.btnHapus)
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
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTambah.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Image = Global.Inventory.My.Resources.Resources.ic_add_circle_white_48dp_1x
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTambah.Location = New System.Drawing.Point(335, 0)
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
        Me.btnUbah.Location = New System.Drawing.Point(400, 0)
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
        Me.btnHapus.Location = New System.Drawing.Point(465, 0)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvData.ColumnHeadersHeight = 35
        Me.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.Column1, Me.StokDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HargabeliDataGridViewTextBoxColumn, Me.HargaJualDataGridViewTextBoxColumn})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvData.DefaultCellStyle = DataGridViewCellStyle5
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.EnableHeadersVisualStyles = False
        Me.gvData.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gvData.Location = New System.Drawing.Point(0, 228)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvData.RowHeadersVisible = False
        Me.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(725, 303)
        Me.gvData.TabIndex = 23
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 300
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Nama_Kelompok"
        Me.Column1.HeaderText = "Nama Kelompok"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "Stok"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.StokDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        Me.StokDataGridViewTextBoxColumn.Width = 50
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        Me.SatuanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SatuanDataGridViewTextBoxColumn.Width = 50
        '
        'HargabeliDataGridViewTextBoxColumn
        '
        Me.HargabeliDataGridViewTextBoxColumn.DataPropertyName = "Harga_beli"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.HargabeliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HargabeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli"
        Me.HargabeliDataGridViewTextBoxColumn.Name = "HargabeliDataGridViewTextBoxColumn"
        Me.HargabeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaJualDataGridViewTextBoxColumn
        '
        Me.HargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga_Jual"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.HargaJualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.HargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn.Name = "HargaJualDataGridViewTextBoxColumn"
        Me.HargaJualDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(725, 656)
        Me.Name = "FormBarang"
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
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbKelompok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbHargaBeli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSatuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStok As TextBox
    Friend WithEvents btnKelompok As Button
    Friend WithEvents tbNamaKelompok As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbHargaJual As TextBox
    Friend WithEvents gvData As DataGridView
    Friend WithEvents KodeKelompokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargabeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

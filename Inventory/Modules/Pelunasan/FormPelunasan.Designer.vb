<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelunasan
    Inherits Inventory.FormBasic

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSisa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTermin = New System.Windows.Forms.TextBox()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.btnPiutang = New System.Windows.Forms.Button()
        Me.dtTempo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPiutang = New System.Windows.Forms.TextBox()
        Me.tbNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPelanggan = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(509, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(509, 50)
        Me.lblTitle.Text = "Pelunasan"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Size = New System.Drawing.Size(509, 381)
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.dtTanggal)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.tbSisa)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.tbBayar)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.tbTotalBayar)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbTermin)
        Me.Panel6.Controls.Add(Me.tbTotalHarga)
        Me.Panel6.Controls.Add(Me.btnPiutang)
        Me.Panel6.Controls.Add(Me.dtTempo)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tbPiutang)
        Me.Panel6.Controls.Add(Me.tbNamaPelanggan)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.tbPelanggan)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(509, 381)
        Me.Panel6.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(260, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Tanggal"
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(335, 10)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(166, 20)
        Me.dtTanggal.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Sisa"
        '
        'tbSisa
        '
        Me.tbSisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSisa.Enabled = False
        Me.tbSisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbSisa.Location = New System.Drawing.Point(100, 228)
        Me.tbSisa.Name = "tbSisa"
        Me.tbSisa.Size = New System.Drawing.Size(147, 20)
        Me.tbSisa.TabIndex = 44
        Me.tbSisa.Text = "0"
        Me.tbSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "No. Pelunasan"
        '
        'tbKode
        '
        Me.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKode.Enabled = False
        Me.tbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbKode.Location = New System.Drawing.Point(100, 10)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(82, 20)
        Me.tbKode.TabIndex = 42
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnBatal)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 316)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(509, 65)
        Me.Panel8.TabIndex = 40
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
        Me.btnSimpan.Location = New System.Drawing.Point(314, 0)
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
        Me.btnBatal.Location = New System.Drawing.Point(379, 0)
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
        Me.btnTutup.Location = New System.Drawing.Point(444, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 0
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Bayar"
        '
        'tbBayar
        '
        Me.tbBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbBayar.Location = New System.Drawing.Point(100, 264)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(147, 20)
        Me.tbBayar.TabIndex = 39
        Me.tbBayar.Text = "0"
        Me.tbBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Total Bayar"
        '
        'tbTotalBayar
        '
        Me.tbTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalBayar.Enabled = False
        Me.tbTotalBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbTotalBayar.Location = New System.Drawing.Point(100, 194)
        Me.tbTotalBayar.Name = "tbTotalBayar"
        Me.tbTotalBayar.Size = New System.Drawing.Size(147, 20)
        Me.tbTotalBayar.TabIndex = 37
        Me.tbTotalBayar.Text = "0"
        Me.tbTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(9, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Pembayaran Ke"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Total Harga"
        '
        'tbTermin
        '
        Me.tbTermin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTermin.Enabled = False
        Me.tbTermin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbTermin.Location = New System.Drawing.Point(100, 160)
        Me.tbTermin.Name = "tbTermin"
        Me.tbTermin.Size = New System.Drawing.Size(46, 20)
        Me.tbTermin.TabIndex = 33
        Me.tbTermin.Text = "0"
        Me.tbTermin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalHarga.Enabled = False
        Me.tbTotalHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbTotalHarga.Location = New System.Drawing.Point(100, 128)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(147, 20)
        Me.tbTotalHarga.TabIndex = 33
        Me.tbTotalHarga.Text = "0"
        Me.tbTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPiutang
        '
        Me.btnPiutang.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPiutang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPiutang.Location = New System.Drawing.Point(188, 37)
        Me.btnPiutang.Name = "btnPiutang"
        Me.btnPiutang.Size = New System.Drawing.Size(26, 20)
        Me.btnPiutang.TabIndex = 31
        Me.btnPiutang.Text = "---"
        Me.btnPiutang.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPiutang.UseVisualStyleBackColor = True
        '
        'dtTempo
        '
        Me.dtTempo.Enabled = False
        Me.dtTempo.Location = New System.Drawing.Point(335, 49)
        Me.dtTempo.Name = "dtTempo"
        Me.dtTempo.Size = New System.Drawing.Size(166, 20)
        Me.dtTempo.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(260, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Jatuh Tempo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "No. Piutang"
        '
        'tbPiutang
        '
        Me.tbPiutang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPiutang.Enabled = False
        Me.tbPiutang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPiutang.Location = New System.Drawing.Point(100, 36)
        Me.tbPiutang.Name = "tbPiutang"
        Me.tbPiutang.Size = New System.Drawing.Size(82, 20)
        Me.tbPiutang.TabIndex = 24
        '
        'tbNamaPelanggan
        '
        Me.tbNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaPelanggan.Enabled = False
        Me.tbNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNamaPelanggan.Location = New System.Drawing.Point(176, 90)
        Me.tbNamaPelanggan.Name = "tbNamaPelanggan"
        Me.tbNamaPelanggan.Size = New System.Drawing.Size(154, 20)
        Me.tbNamaPelanggan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 92)
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
        Me.tbPelanggan.Location = New System.Drawing.Point(100, 90)
        Me.tbPelanggan.Name = "tbPelanggan"
        Me.tbPelanggan.Size = New System.Drawing.Size(70, 20)
        Me.tbPelanggan.TabIndex = 7
        '
        'FormPelunasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(509, 441)
        Me.Name = "FormPelunasan"
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents tbBayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTotalBayar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTotalHarga As TextBox
    Friend WithEvents btnPiutang As Button
    Friend WithEvents dtTempo As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPiutang As TextBox
    Friend WithEvents tbNamaPelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPelanggan As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSisa As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTermin As TextBox
End Class

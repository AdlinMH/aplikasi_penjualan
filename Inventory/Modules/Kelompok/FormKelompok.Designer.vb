<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKelompok
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rbKode = New System.Windows.Forms.RadioButton()
        Me.tbPencarian = New System.Windows.Forms.TextBox()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.DataKelompokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KodeKelompokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKelompokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataKelompokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(480, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(480, 50)
        Me.lblTitle.Text = "Kelompok Barang"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gvData)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(0, 124)
        Me.Panel5.Size = New System.Drawing.Size(480, 408)
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tbKode)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.tbNama)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(480, 64)
        Me.Panel6.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Kelompok"
        '
        'tbKode
        '
        Me.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKode.Enabled = False
        Me.tbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbKode.Location = New System.Drawing.Point(91, 7)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.Size = New System.Drawing.Size(70, 20)
        Me.tbKode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Kelompok"
        '
        'tbNama
        '
        Me.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbNama.Location = New System.Drawing.Point(91, 34)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(185, 20)
        Me.tbNama.TabIndex = 5
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
        Me.gvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeKelompokDataGridViewTextBoxColumn, Me.NamaKelompokDataGridViewTextBoxColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvData.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.EnableHeadersVisualStyles = False
        Me.gvData.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gvData.Location = New System.Drawing.Point(0, 47)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvData.RowHeadersVisible = False
        Me.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(480, 296)
        Me.gvData.TabIndex = 14
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
        Me.Panel8.Location = New System.Drawing.Point(0, 343)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(480, 65)
        Me.Panel8.TabIndex = 17
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
        Me.btnTambah.Location = New System.Drawing.Point(90, 0)
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
        Me.btnUbah.Location = New System.Drawing.Point(155, 0)
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
        Me.btnHapus.Location = New System.Drawing.Point(220, 0)
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
        Me.btnSimpan.Location = New System.Drawing.Point(285, 0)
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
        Me.btnBatal.Location = New System.Drawing.Point(350, 0)
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
        Me.btnTutup.Location = New System.Drawing.Point(415, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 0
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbKode)
        Me.Panel7.Controls.Add(Me.tbPencarian)
        Me.Panel7.Controls.Add(Me.rbNama)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(480, 47)
        Me.Panel7.TabIndex = 18
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
        Me.tbPencarian.Location = New System.Drawing.Point(121, 14)
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
        'DataKelompokBindingSource
        '
        Me.DataKelompokBindingSource.DataSource = GetType(Inventory.DataKelompok)
        '
        'KodeKelompokDataGridViewTextBoxColumn
        '
        Me.KodeKelompokDataGridViewTextBoxColumn.DataPropertyName = "Kode_Kelompok"
        Me.KodeKelompokDataGridViewTextBoxColumn.HeaderText = "Kode Kelompok"
        Me.KodeKelompokDataGridViewTextBoxColumn.Name = "KodeKelompokDataGridViewTextBoxColumn"
        Me.KodeKelompokDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeKelompokDataGridViewTextBoxColumn.Width = 120
        '
        'NamaKelompokDataGridViewTextBoxColumn
        '
        Me.NamaKelompokDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kelompok"
        Me.NamaKelompokDataGridViewTextBoxColumn.HeaderText = "Nama Kelompok"
        Me.NamaKelompokDataGridViewTextBoxColumn.Name = "NamaKelompokDataGridViewTextBoxColumn"
        Me.NamaKelompokDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaKelompokDataGridViewTextBoxColumn.Width = 300
        '
        'FormKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(480, 532)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "FormKelompok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.SetChildIndex(Me.PanelHeader, 0)
        Me.Controls.SetChildIndex(Me.lblTitle, 0)
        Me.Controls.SetChildIndex(Me.Panel6, 0)
        Me.Controls.SetChildIndex(Me.Panel5, 0)
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DataKelompokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents rbKode As RadioButton
    Friend WithEvents tbPencarian As TextBox
    Friend WithEvents rbNama As RadioButton
    Friend WithEvents gvData As DataGridView
    Friend WithEvents KodeKelompokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaKelompokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataKelompokBindingSource As BindingSource
End Class

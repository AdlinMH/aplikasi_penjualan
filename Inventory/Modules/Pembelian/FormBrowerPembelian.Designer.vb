<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBrowerPembelian
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
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.DataPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rbKode = New System.Windows.Forms.RadioButton()
        Me.tbPencarian = New System.Windows.Forms.TextBox()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.NoPembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(545, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(545, 50)
        Me.lblTitle.Text = "Daftar Pembelian"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gvData)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Size = New System.Drawing.Size(545, 474)
        '
        'gvData
        '
        Me.gvData.AllowUserToAddRows = False
        Me.gvData.AllowUserToDeleteRows = False
        Me.gvData.AutoGenerateColumns = False
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
        Me.gvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoPembelianDataGridViewTextBoxColumn, Me.Nama_Pembelian, Me.TanggalDataGridViewTextBoxColumn})
        Me.gvData.DataSource = Me.DataPembelianBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
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
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(545, 362)
        Me.gvData.TabIndex = 1
        '
        'DataPembelianBindingSource
        '
        Me.DataPembelianBindingSource.DataSource = GetType(Inventory.DataPembelian)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbKode)
        Me.Panel7.Controls.Add(Me.tbPencarian)
        Me.Panel7.Controls.Add(Me.rbNama)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(545, 47)
        Me.Panel7.TabIndex = 6
        '
        'rbKode
        '
        Me.rbKode.AutoSize = True
        Me.rbKode.Checked = True
        Me.rbKode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rbKode.Location = New System.Drawing.Point(6, 15)
        Me.rbKode.Name = "rbKode"
        Me.rbKode.Size = New System.Drawing.Size(49, 17)
        Me.rbKode.TabIndex = 6
        Me.rbKode.TabStop = True
        Me.rbKode.Text = "Kode"
        Me.rbKode.UseVisualStyleBackColor = True
        '
        'tbPencarian
        '
        Me.tbPencarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPencarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPencarian.Location = New System.Drawing.Point(120, 15)
        Me.tbPencarian.Name = "tbPencarian"
        Me.tbPencarian.Size = New System.Drawing.Size(155, 20)
        Me.tbPencarian.TabIndex = 8
        '
        'rbNama
        '
        Me.rbNama.AutoSize = True
        Me.rbNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rbNama.Location = New System.Drawing.Point(62, 15)
        Me.rbNama.Name = "rbNama"
        Me.rbNama.Size = New System.Drawing.Size(52, 17)
        Me.rbNama.TabIndex = 7
        Me.rbNama.Text = "Nama"
        Me.rbNama.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.btnReload)
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnBatal)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 409)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(545, 65)
        Me.Panel8.TabIndex = 2
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
        Me.btnReload.TabIndex = 5
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReload.UseVisualStyleBackColor = False
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
        Me.btnSimpan.Location = New System.Drawing.Point(350, 0)
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
        Me.btnBatal.Location = New System.Drawing.Point(415, 0)
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
        Me.btnTutup.Location = New System.Drawing.Point(480, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'NoPembelianDataGridViewTextBoxColumn
        '
        Me.NoPembelianDataGridViewTextBoxColumn.DataPropertyName = "No_Pembelian"
        Me.NoPembelianDataGridViewTextBoxColumn.HeaderText = "No Pembelian"
        Me.NoPembelianDataGridViewTextBoxColumn.Name = "NoPembelianDataGridViewTextBoxColumn"
        Me.NoPembelianDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Nama_Pembelian
        '
        Me.Nama_Pembelian.DataPropertyName = "Nama_Supplier"
        Me.Nama_Pembelian.HeaderText = "Nama Supplier"
        Me.Nama_Pembelian.Name = "Nama_Pembelian"
        Me.Nama_Pembelian.ReadOnly = True
        Me.Nama_Pembelian.Width = 200
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        Me.TanggalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormBrowerPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 534)
        Me.Name = "FormBrowerPembelian"
        Me.Panel5.ResumeLayout(False)
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbKode As RadioButton
    Friend WithEvents tbPencarian As TextBox
    Friend WithEvents rbNama As RadioButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnReload As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTutup As Button
    Protected WithEvents gvData As DataGridView
    Protected WithEvents Panel7 As Panel
    Friend WithEvents KodeSupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataPembelianBindingSource As BindingSource
    Friend WithEvents NoPembelianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Pembelian As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

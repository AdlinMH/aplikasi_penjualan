<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGantiPassword
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPassO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUserN = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassN1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPassN2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbUserO = New System.Windows.Forms.TextBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Size = New System.Drawing.Size(424, 10)
        '
        'lblTitle
        '
        Me.lblTitle.Size = New System.Drawing.Size(424, 50)
        Me.lblTitle.Text = "Ganti Password"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tbUserO)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.tbPassN2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.tbPassN1)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.tbPassO)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.tbUserN)
        Me.Panel5.Size = New System.Drawing.Size(424, 351)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Password Lama"
        '
        'tbPassO
        '
        Me.tbPassO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPassO.Location = New System.Drawing.Point(24, 140)
        Me.tbPassO.Name = "tbPassO"
        Me.tbPassO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassO.Size = New System.Drawing.Size(147, 20)
        Me.tbPassO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "User Name Baru"
        '
        'tbUserN
        '
        Me.tbUserN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUserN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbUserN.Location = New System.Drawing.Point(24, 92)
        Me.tbUserN.Name = "tbUserN"
        Me.tbUserN.Size = New System.Drawing.Size(147, 20)
        Me.tbUserN.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Controls.Add(Me.btnSimpan)
        Me.Panel8.Controls.Add(Me.btnBatal)
        Me.Panel8.Controls.Add(Me.btnTutup)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 286)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(424, 65)
        Me.Panel8.TabIndex = 50
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSimpan.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.Inventory.My.Resources.Resources.ic_done_white_48dp_1x
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(229, 0)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(65, 65)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Masuk"
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
        Me.btnBatal.Location = New System.Drawing.Point(294, 0)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(65, 65)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Password Baru"
        '
        'tbPassN1
        '
        Me.tbPassN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassN1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPassN1.Location = New System.Drawing.Point(24, 188)
        Me.tbPassN1.Name = "tbPassN1"
        Me.tbPassN1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassN1.Size = New System.Drawing.Size(147, 20)
        Me.tbPassN1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Ulangi Password"
        '
        'tbPassN2
        '
        Me.tbPassN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassN2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbPassN2.Location = New System.Drawing.Point(24, 237)
        Me.tbPassN2.Name = "tbPassN2"
        Me.tbPassN2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassN2.Size = New System.Drawing.Size(147, 20)
        Me.tbPassN2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "User Name Lama"
        '
        'tbUserO
        '
        Me.tbUserO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUserO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tbUserO.Location = New System.Drawing.Point(24, 45)
        Me.tbUserO.Name = "tbUserO"
        Me.tbUserO.Size = New System.Drawing.Size(147, 20)
        Me.tbUserO.TabIndex = 1
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
        Me.btnTutup.Location = New System.Drawing.Point(359, 0)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(65, 65)
        Me.btnTutup.TabIndex = 8
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'FormGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(424, 411)
        Me.Name = "FormGantiPassword"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.errMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents tbPassO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUserN As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPassN2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassN1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbUserO As TextBox
    Friend WithEvents btnTutup As Button
End Class

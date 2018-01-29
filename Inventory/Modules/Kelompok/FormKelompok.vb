Imports System.Data.SqlClient

Public Class FormKelompok

#Region "Instance"

    Private _isTambah As Boolean = False
    Private _isUbah As Boolean = False
    Private _isTampil As Boolean = True

    Private _db As DbEntities
    Private _cls As ClassKelompok
    Private _data As DataKelompok

#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        _db = New DbEntities()
        _cls = New ClassKelompok(_db)
        _data = New DataKelompok()
        gvData.AutoGenerateColumns = False
    End Sub
#End Region

#Region "Events"
    Private Sub FormKelompok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvData.DataSource = _cls.GetEntities()
        InitControls()
    End Sub

    Private Sub gvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvData.CellClick
        If IsHaveData() Then
            _data = _cls.GetEntity(IdSelected())
            ModelToView()
            InitControls()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        InitStatus("tambah")
        _data = New DataKelompok()
        ModelToView()
        tbKode.Text = _cls.GetNextKode()
        InitControls()
        tbNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If ValidateChildren(ValidationConstraints.Enabled) Then
            ViewToModel()
            _cls.Data = _data
            _cls.AddOrUpdate()

            gvData.DataSource = _cls.GetEntities()
            _data = New DataKelompok()
            ModelToView()
            InitStatus("tampil")
            InitControls()
            btnTambah.Focus()

            MessageBox.Show("Data Sudah Tersimpan")
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        gvData.DataSource = _cls.GetEntities()
        ResetSearch()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        InitStatus("ubah")
        _data = _cls.GetEntity(IdSelected())
        ModelToView()
        InitControls()

        tbNama.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        _data = _cls.GetEntity(IdSelected())
        _cls.Data = _data
        _cls.DeleteData()
        gvData.DataSource = _cls.GetEntities()

        _data = New DataKelompok()
        ModelToView()
        InitControls()

        btnTambah.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        InitStatus("tampil")
        _data = New DataKelompok()
        ModelToView()

        InitControls()
        ResetErrorMessage()
        btnTambah.Focus()
    End Sub

    Private Sub TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNama.Validating
        Dim textbox As Control = sender

        If (String.IsNullOrEmpty(textbox.Text)) Then
            e.Cancel = True
            errMessage.SetError(textbox, "Field Tidak Boleh Kosong")
        Else
            errMessage.SetError(textbox, String.Empty)
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        If (rbKode.Checked) Then
            gvData.DataSource = _cls.GetEntities(Function(x) x.Kode_Kelompok.Contains(tbPencarian.Text))
        Else
            gvData.DataSource = _cls.GetEntities(Function(x) x.Nama_Kelompok.Contains(tbPencarian.Text))
        End If
    End Sub

#End Region

#Region "Functions"
    Private Function IsHaveData() As Boolean
        Return gvData.RowCount > 0
    End Function

    Private Function IdSelected() As String
        Dim idx = gvData.CurrentRow.Index
        Return gvData.Item(0, idx).Value
    End Function
#End Region

#Region "Methods"

    Private Sub InitStatus(status As String)
        _isTampil = IIf(status = "tampil", True, False)
        _isTambah = IIf(status = "tambah", True, False)
        _isUbah = IIf(status = "ubah", True, False)
    End Sub

    Private Sub InitControls()

        rbKode.Checked = True

        tbNama.Enabled = Not _isTampil

        btnSimpan.Enabled = Not _isTampil
        btnBatal.Enabled = Not _isTampil

        gvData.Enabled = _isTampil
        tbPencarian.Enabled = _isTampil
        rbKode.Enabled = _isTampil
        rbNama.Enabled = _isTampil

        btnHapus.Enabled = IsHaveData() And Not _isTambah And Not _isUbah
        btnUbah.Enabled = IsHaveData() And Not _isTambah And Not _isUbah
        btnTambah.Enabled = Not _isTambah And Not _isUbah
        btnReload.Enabled = Not _isTambah And Not _isUbah
    End Sub

    Private Sub ResetErrorMessage()
        errMessage.SetError(tbNama, String.Empty)
    End Sub

    Private Sub ResetSearch()
        tbPencarian.Text = String.Empty
        rbKode.Checked = True
    End Sub

    Private Sub ViewToModel()
        _data.Kode_Kelompok = tbKode.Text
        _data.Nama_Kelompok = tbNama.Text
    End Sub

    Private Sub ModelToView()
        tbKode.Text = _data.Kode_Kelompok
        tbNama.Text = _data.Nama_Kelompok
    End Sub

#End Region

End Class
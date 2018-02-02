Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormTerminPelunasan
#Region "Instance"

    Private _isTambah As Boolean = False
    Private _isUbah As Boolean = False
    Private _isTampil As Boolean = True
    Private _isTambahDetail As Boolean = False
    Private _isUbahDetail As Boolean = False
    Private _isTampilDetail As Boolean = True
    Private _idSelected As String = String.Empty

    Private _db As DbEntities
    Private _cls As ClassTerminPelunasan

    Private _data As DataTerminPelunasan
    Private _bs As BindingSource

    Private m_data As DataPelunasan
    Public ReadOnly Property Entity()
        Get
            Return m_data
        End Get
    End Property

    Private _idx As Integer = 0
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        InitStatus("tambah")
        _db = New DbEntities()
        _cls = New ClassTerminPelunasan(_db)
        _clsPesanan = New ClassPesanan(_db)
        _clsPiutang = New ClassPiutang(_db)
        _bs = New BindingSource()

        _data = New DataPenjualan()
        tbKodePenjualan.Text = _cls.GetNextKode()
        gvData.AutoGenerateColumns = False
    End Sub

    Public Sub New(entity As DataPenjualan)
        InitializeComponent()
        InitStatus("ubah")
        _db = New DbEntities()
        _cls = New ClassTerminPelunasan(_db)
        _clsPesanan = New ClassPesanan(_db)
        _bs = New BindingSource()

        _data = entity
        ModelToView()
        gvData.AutoGenerateColumns = False
    End Sub
#End Region

    Private Sub InitStatus(status As String)
        _isTambah = IIf(status = "tambah", True, False)
        _isUbah = IIf(status = "ubah", True, False)
        _isTampil = IIf(status = "tampil", True, False)
    End Sub

    Private Sub tbPesanan_TextChanged(sender As Object, e As EventArgs)
        gvData.DataSource = pesanan.DetailPesanan
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            ViewToModel()
            _cls.Data = _data
            _cls.AddOrUpdate()

            MessageBox.Show("Data Sudah Tersimpan")
            Close()
        End If
    End Sub

    Private Sub ViewToModel()
        _data.No_Termin = tbKode.Text
        _data.Jumlah_Termin = tbJumlahTermin.Text
        _data.No_Penjualan = tbKodePenjualan.Text

    End Sub

    Private Sub ModelToView()
        tbKodePenjualan.Text = _data.No_Penjualan
        tbKode.Text = _data.No_Termin

        If (_data.DataPelanggan Is Nothing) Then
            tbJumlahTermin.Text = ""
            tbNamaPelanggan.Text = ""
            rtbAlamat.Text = ""
        Else
            tbJumlahTermin.Text = _data.DataPelanggan.Kode_Pelanggan
            tbNamaPelanggan.Text = _data.DataPelanggan.Nama_Pelanggan
            rtbAlamat.Text = _data.DataPelanggan.Alamat
        End If
    End Sub

    Private Sub tbPanjar_TextChanged(sender As Object, e As EventArgs)
        If (tbPanjar.Text Is "") Then
            tbPanjar.Text = "0"
        End If

        If (tbTotal.Text Is "") Then
            tbTotal.Text = "0"
        End If

        Dim total, panjar As Decimal
        total = Decimal.Parse(tbTotal.Text)
        panjar = Decimal.Parse(tbPanjar.Text)
        tbSisa.Text = total - panjar
    End Sub

    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (cbJenis.Text = "Tunai") Then
            tbPanjar.Enabled = False
            dtTempo.Enabled = False
            tbPanjar.Text = "0"
        Else
            tbPanjar.Enabled = True
            dtTempo.Enabled = True
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim rpt = New ReportDocument()
        rpt.Load(CurDir() + "\Modules\Laporan\" + "Faktur Penjualan.rpt")
        rpt.Refresh()

        rpt.SetDataSource(_data.DataPesanan.DetailPesanan.ToList())
        rpt.SetParameterValue("Nama Pelanggan", tbNamaPelanggan.Text)
        rpt.SetParameterValue("Alamat", rtbAlamat.Text)
        rpt.SetParameterValue("Tanggal", dtTanggal.Value)
        rpt.SetParameterValue("Sub Total", tbSubTotal.Text)
        rpt.SetParameterValue("Diskon", tbDiskon2.Text)
        rpt.SetParameterValue("PPN", tbPPN2.Text)
        rpt.SetParameterValue("Total", tbTotal.Text)

        rpt.SetParameterValue("Panjar", tbPanjar.Text)

        rpt.SetParameterValue("Sisa", tbSisa.Text)
        rpt.SetParameterValue("Jenis", cbJenis.Text)
        rpt.SetParameterValue("No Penjualan", tbKodePenjualan.Text)


        Dim view = New FormLaporan(ReportName.FakturPemesanan, rpt)
        view.ShowDialog()
    End Sub
End Class

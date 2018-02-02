Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormPenjualan
#Region "Instance"

    Private _isTambah As Boolean = False
    Private _isUbah As Boolean = False
    Private _isTampil As Boolean = True
    Private _isTambahDetail As Boolean = False
    Private _isUbahDetail As Boolean = False
    Private _isTampilDetail As Boolean = True
    Private _idSelected As String = String.Empty

    Private _db As DbEntities
    Private _cls As ClassPenjualan
    Private _clsPesanan As ClassPesanan
    Private _clsPiutang As ClassPiutang
    Private _clsTerminPelunasan As ClassTerminPelunasan

    Private _data As DataPenjualan
    Private _detail As DetailPesanan
    Private _dataDetail As DetailPesanan
    Private _dataTerminPelunasan As DataTerminPelunasan
    Private _bs As BindingSource

    Private _idx As Integer = 0
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        InitStatus("tambah")
        _db = New DbEntities()
        _cls = New ClassPenjualan(_db)
        _clsPesanan = New ClassPesanan(_db)
        _clsPiutang = New ClassPiutang(_db)
        _clsTerminPelunasan = New ClassTerminPelunasan(_db)
        _bs = New BindingSource()

        _data = New DataPenjualan()
        tbKode.Text = _cls.GetNextKode()
        gvData.AutoGenerateColumns = False
    End Sub

    Public Sub New(entity As DataPenjualan)
        InitializeComponent()
        InitStatus("ubah")
        _db = New DbEntities()
        _cls = New ClassPenjualan(_db)
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

    Private Sub tbPesanan_TextChanged(sender As Object, e As EventArgs) Handles tbPesanan.TextChanged
        Dim pesanan As DataPesanan
        pesanan = _clsPesanan.GetEntity(tbPesanan.Text)
        gvData.DataSource = pesanan.DetailPesanan
    End Sub

    Private Sub btnPesanan_Click(sender As Object, e As EventArgs) Handles btnPesanan.Click
        Dim frm = New FormBrowerPesanan(_db)
        frm.ShowDialog()

        If (frm.DialogResult = DialogResult.OK) Then
            _data.DataPesanan = frm.Entity
            tbPesanan.Text = _data.DataPesanan.No_Pesanan
            tbPelanggan.Text = _data.DataPesanan.DataPelanggan.Kode_Pelanggan
            tbNamaPelanggan.Text = _data.DataPesanan.DataPelanggan.Nama_Pelanggan
            rtbAlamat.Text = _data.DataPesanan.DataPelanggan.Alamat
            _bs.DataSource = _data.DataPesanan.DetailPesanan
            gvData.DataSource = _bs
            tbTotal.Text = _data.DataPesanan.Total
            tbDiskon1.Text = _data.DataPesanan.Diskon1
            tbDiskon2.Text = _data.DataPesanan.Diskon2
            tbPPN1.Text = _data.DataPesanan.PPN1
            tbPPN2.Text = _data.DataPesanan.PPN2
            tbSubTotal.Text = _data.DataPesanan.Sub_Total

            tbDibayarkan.Text = IIf(tbTotal.Text <> "", Math.Ceiling(Convert.ToDecimal(tbTotal.Text) / Convert.ToDecimal(cbTermin.Text)), "")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Try
                ViewToModel()
                _cls.Data = _data
                _cls.AddOrUpdate()

                _data.DataPesanan.Digunakan = "Y"
                _clsPesanan.Data = _data.DataPesanan
                _clsPesanan.AddOrUpdate()

                If (_data.Jenis = "Kredit") Then
                    Dim dataPiutang = New DataPiutang()
                    dataPiutang.Nilai = _data.Total
                    dataPiutang.Jatuh_Tempo = _data.Jatuh_Tempo
                    dataPiutang.Kode_Pelanggan = _data.Kode_Pelanggan
                    dataPiutang.No_Piutang = _data.No_Penjualan
                    dataPiutang.Panjar = _data.Panjar
                    dataPiutang.Total_Bayar = 0
                    _clsPiutang.Data = dataPiutang
                    _clsPiutang.AddOrUpdate()

                    Dim dataTerminPelunasan = New DataTerminPelunasan()
                    dataTerminPelunasan.No_Termin = _data.No_Penjualan.Replace("PJL", "TPL")
                    dataTerminPelunasan.No_Penjualan = _data.No_Penjualan
                    dataTerminPelunasan.Jumlah_Termin = Convert.ToInt32(cbTermin.Text)
                    _clsTerminPelunasan.Data = dataTerminPelunasan
                    _clsTerminPelunasan.AddOrUpdate()
                End If

                MessageBox.Show("Data Sudah Tersimpan")
                Close()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan. mohon periksa dan lengkapi input atau hubungi Administrator")
            End Try
        End If
    End Sub

    Private Sub ViewToModel()
        _data.No_Pesanan = tbPesanan.Text
        _data.Kode_Pelanggan = tbPelanggan.Text
        _data.Diskon1 = Decimal.Parse(tbDiskon1.Text)
        _data.Diskon2 = Decimal.Parse(tbDiskon2.Text)
        _data.PPN1 = Decimal.Parse(tbPPN1.Text)
        _data.PPN2 = Decimal.Parse(tbPPN2.Text)
        _data.Total = Decimal.Parse(tbTotal.Text)
        _data.Sub_Total = Decimal.Parse(tbSubTotal.Text)
        _data.Tanggal = dtTanggal.Value.Date
        _data.Panjar = Decimal.Parse(tbPanjar.Text)
        _data.Jenis = cbJenis.Text
        _data.Jatuh_Tempo = dtTempo.Value.Date
        _data.No_Penjualan = tbKode.Text

    End Sub

    Private Sub ModelToView()
        tbKode.Text = _data.No_Penjualan
        tbSubTotal.Text = _data.Sub_Total
        tbDiskon1.Text = _data.Diskon1
        tbDiskon2.Text = _data.Diskon2
        tbPPN1.Text = _data.PPN1
        tbPPN2.Text = _data.PPN2
        tbTotal.Text = _data.Total
        dtTanggal.Value = _data.Tanggal
        dtTempo.Value = _data.Jatuh_Tempo
        tbPanjar.Text = _data.Panjar
        cbJenis.Text = _data.Jenis
        tbPesanan.Text = _data.No_Pesanan

        If (_data.DataPelanggan Is Nothing) Then
            tbPelanggan.Text = ""
            tbNamaPelanggan.Text = ""
            rtbAlamat.Text = ""
        Else
            tbPelanggan.Text = _data.DataPelanggan.Kode_Pelanggan
            tbNamaPelanggan.Text = _data.DataPelanggan.Nama_Pelanggan
            rtbAlamat.Text = _data.DataPelanggan.Alamat
        End If
    End Sub

    Private Sub tbPanjar_TextChanged(sender As Object, e As EventArgs) Handles tbPanjar.TextChanged
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

    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If (cbJenis.Text = "Tunai") Then
            tbPanjar.Enabled = False
            tbPanjar.Text = "0"
            panelKredit.Visible = False
        Else
            tbPanjar.Enabled = True
            panelKredit.Visible = True
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        rpt.SetParameterValue("No Penjualan", tbKode.Text)


        Dim view = New FormLaporan(ReportName.FakturPemesanan, rpt)
        view.ShowDialog()
    End Sub

    Private Sub cbTermin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTermin.SelectedIndexChanged
        dtTempo.Value = dtTempo.Value.AddMonths(Convert.ToInt32(cbTermin.Text))
        tbDibayarkan.Text = IIf(tbTotal.Text <> "", Math.Ceiling(Convert.ToDecimal(tbTotal.Text) / Convert.ToDecimal(cbTermin.Text)), "")
    End Sub

    Private Sub dtTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtTanggal.ValueChanged
        dtTempo.Value = dtTanggal.Value.AddMonths(Convert.ToInt32(cbTermin.Text))
    End Sub
End Class

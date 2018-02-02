Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormPesanan

#Region "Instance"

    Private _isTambah As Boolean = False
    Private _isUbah As Boolean = False
    Private _isTampil As Boolean = True
    Private _isTambahDetail As Boolean = False
    Private _isUbahDetail As Boolean = False
    Private _isTampilDetail As Boolean = True
    Private _idSelected As String = String.Empty

    Private _db As DbEntities
    Private _cls As ClassPesanan
    Private _clsPelanggan As ClassPelanggan
    Private _clsBarang As ClassBarang

    Private _data As DataPesanan
    Private _dataDetail As DetailPesanan
    Private _bs As BindingSource

    Private _idx As Integer = 0

#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        InitStatus("tambah")
        _db = New DbEntities()
        _cls = New ClassPesanan(_db)
        _clsPelanggan = New ClassPelanggan(_db)
        _clsBarang = New ClassBarang(_db)
        _bs = New BindingSource()

        _data = New DataPesanan()
        _data.DetailPesanan = New List(Of DetailPesanan)
        tbKode.Text = _cls.GetNextKode()
        gvData.AutoGenerateColumns = False
    End Sub

    Public Sub New(entity As DataPesanan)
        InitializeComponent()
        InitStatus("ubah")
        _db = New DbEntities()
        _cls = New ClassPesanan(_db)
        _clsPelanggan = New ClassPelanggan(_db)
        _clsBarang = New ClassBarang(_db)
        _bs = New BindingSource()

        _data = entity
        ModelToView()
        gvData.AutoGenerateColumns = False
    End Sub

#End Region

#Region "Events"
    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _bs.DataSource = _data.DetailPesanan
        gvData.DataSource = _bs
        InitControlDetail()
        InitControls()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If (ValidateChildren()) Then
            InitStatusDetail("tambah")
            InitControlDetail()
            btnBarang.Focus()
        End If
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

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        InitStatusDetail("ubah")
        _dataDetail = _data.DetailPesanan.ElementAt(_idx)
        ModelToView(_dataDetail)
        InitControlDetail()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        _dataDetail = _data.DetailPesanan.ElementAt(_idx)
        _dataDetail.DataBarang.Stok += _dataDetail.Qty
        _data.DetailPesanan.Remove(_dataDetail)
        _bs.ResetBindings(False)
        Dim subTotal = _data.DetailPesanan.Sum(Function(x) x.Sub_Total)
        tbSubTotal.Text = subTotal
        InitControlDetail()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        Dim frm = New FormBrowerPelanggan(_db)
        frm.ShowDialog()

        If (frm.DialogResult = DialogResult.OK) Then
            _data.DataPelanggan = frm.Entity
            tbPelanggan.Text = _data.DataPelanggan.Kode_Pelanggan
            tbNamaPelanggan.Text = _data.DataPelanggan.Nama_Pelanggan
            rtbAlamat.Text = _data.DataPelanggan.Alamat
        End If
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        Dim frm = New FormBrowerBarang(_db)
        frm.ShowDialog()

        If (frm.DialogResult = DialogResult.OK) Then
            _dataDetail = New DetailPesanan()
            _dataDetail.DataBarang = frm.Entity
            tbBarang.Text = _dataDetail.DataBarang.Kode_Barang
            tbNamaBarang.Text = _dataDetail.DataBarang.Nama_Barang
            tbSatuan.Text = _dataDetail.DataBarang.Satuan
            tbHarga.Text = _dataDetail.DataBarang.Harga_Jual
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        InitStatusDetail("tampil")
        _dataDetail = New DetailPesanan()
        _dataDetail.Nama_Barang = ""
        _dataDetail.Kode_Barang = ""
        _dataDetail.Qty = 0
        _dataDetail.Satuan = ""
        _dataDetail.Harga = 0
        _dataDetail.Sub_Total = 0

        ModelToView(_dataDetail)
        InitControlDetail()
        ResetError()
    End Sub

    Private Sub btnSimpanDetail_Click(sender As Object, e As EventArgs) Handles btnSimpanDetail.Click

        If ValidatingDetail() Then
            If (_isTambahDetail) Then
                ViewToModel(_dataDetail)
                _dataDetail.DataBarang.Stok -= _dataDetail.Qty
                _data.DetailPesanan.Add(_dataDetail)
            Else
                ViewToModel(_dataDetail)
                _dataDetail.DataBarang.Stok += _dataDetail.Qty - _dataDetail.DataBarang.Stok
            End If

            tbSubTotal.Text = _data.DetailPesanan.Sum(Function(x) x.Sub_Total)

            _bs.ResetBindings(False)

            InitStatusDetail("tampil")
            _dataDetail = New DetailPesanan()
            _dataDetail.Nama_Barang = ""
            _dataDetail.Kode_Barang = ""
            _dataDetail.Qty = 0
            _dataDetail.Satuan = ""
            _dataDetail.Harga = 0
            _dataDetail.Sub_Total = 0

            ModelToView(_dataDetail)
            InitControlDetail()
        End If


    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim rpt = New ReportDocument()
        rpt.Load(CurDir() + "\Modules\Laporan\" + "Faktur Pemesanan.rpt")
        rpt.Refresh()

        rpt.SetDataSource(_data.DetailPesanan.ToList())
        rpt.SetParameterValue("Nama Pelanggan", tbNamaPelanggan.Text)
        rpt.SetParameterValue("Alamat", rtbAlamat.Text)
        rpt.SetParameterValue("Tanggal", dtTanggal.Value)
        rpt.SetParameterValue("Sub Total", tbSubTotal.Text)
        rpt.SetParameterValue("Diskon", tbDiskon2.Text)
        rpt.SetParameterValue("PPN", tbPPN2.Text)
        rpt.SetParameterValue("Total", tbTotal.Text)
        rpt.SetParameterValue("No Pemesanan", tbKode.Text)


        Dim view = New FormLaporan(ReportName.FakturPemesanan, rpt)
        view.ShowDialog()
    End Sub

    Private Sub tbPelanggan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPelanggan.Validating
        If (String.IsNullOrWhiteSpace(tbPelanggan.Text)) Then
            e.Cancel = True
            errMessage.SetError(tbPelanggan, "Field tidak boleh kosong")
        Else
            errMessage.SetError(tbPelanggan, "")
        End If

    End Sub

    Private Sub gvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvData.CellClick
        _idx = gvData.CurrentRow.Index
    End Sub

    'Private Sub tbSubTotal_TextChanged(sender As Object, e As EventArgs) Handles tbSubTotal.TextChanged, tbDiskon1.TextChanged
    '    Dim subTotal = Decimal.Parse(tbSubTotal.Text)
    '    Dim disc = Decimal.Parse(tbDiskon1.Text)
    '    Dim ppn = Decimal.Parse(tbPPN1.Text)
    '    Dim disc2 = subTotal * disc / 100
    '    Dim ppn2 = (subTotal - disc2) * ppn / 100
    '    Dim total = subTotal - disc2 + ppn2
    '    tbDiskon2.Text = disc2
    '    tbPPN2.Text = ppn2
    '    tbTotal.Text = total
    'End Sub

    'Private Sub tbPPN1_TextChanged(sender As Object, e As EventArgs) Handles tbPPN1.TextChanged
    '    Dim subTotal = Decimal.Parse(tbSubTotal.Text)
    '    Dim disc2 = Decimal.Parse(tbDiskon2.Text)
    '    Dim ppn = Decimal.Parse(tbPPN1.Text)
    '    Dim ppn2 = (subTotal - disc2) * ppn / 100
    '    Dim total = subTotal - disc2 + ppn2
    '    tbPPN2.Text = ppn2
    '    tbTotal.Text = total
    'End Sub

    Private Sub tbQty_TextChanged(sender As Object, e As EventArgs) Handles tbQty.TextChanged, tbHarga.TextChanged
        Dim harga As Decimal
        Dim qty As Integer

        If (Integer.TryParse(tbQty.Text, qty) And Decimal.TryParse(tbHarga.Text, harga)) Then
            tbJumlah.Text = harga * qty
        Else
            tbJumlah.Text = "0"
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

    Private Function ValidatingDetail() As Boolean
        Dim result As Boolean = True

        If (tbQtyValidating()) Then
            result = False
        End If

        Return result
    End Function
#End Region

#Region "Methods"
    Private Sub MenghitungDiskonDanPPH()
        Dim subTotal = Decimal.Parse(tbSubTotal.Text)
        Dim disc = Decimal.Parse(tbDiskon1.Text)

        Dim ppn = Decimal.Parse(tbPPN1.Text)
        Dim disc2 = subTotal * disc / 100
        Dim ppn2 = (subTotal - disc2) * ppn / 100
        Dim total = subTotal - disc2 + ppn2
        tbDiskon2.Text = disc2
        tbPPN2.Text = ppn2
        tbTotal.Text = total
    End Sub
    Private Sub ResetError()
        errMessage.SetError(tbQty, "")
        errMessage.SetError(tbHarga, "")
    End Sub

    Private Sub InitStatus(status As String)
        _isTambah = IIf(status = "tambah", True, False)
        _isUbah = IIf(status = "ubah", True, False)
        _isTampil = IIf(status = "tampil", True, False)
    End Sub

    Private Sub InitStatusDetail(status As String)
        _isTambahDetail = IIf(status = "tambah", True, False)
        _isUbahDetail = IIf(status = "ubah", True, False)
        _isTampilDetail = IIf(status = "tampil", True, False)
    End Sub

    Private Sub InitControls()
        btnPrint.Enabled = Not _isTampil
        btnSimpan.Enabled = Not _isTampil
    End Sub

    Private Sub InitControlDetail()

        btnSimpanDetail.Enabled = Not _isTampilDetail
        btnBatal.Enabled = Not _isTampilDetail
        btnBarang.Enabled = Not _isTampilDetail
        tbQty.Enabled = Not _isTampilDetail
        tbHarga.Enabled = Not _isTampilDetail
        btnTambah.Enabled = Not _isTampil And _isTampilDetail
        btnUbah.Enabled = Not _isTampil And _isTampilDetail And IsHaveData()
        btnHapus.Enabled = Not _isTampil And _isTampilDetail And IsHaveData()
    End Sub

    Private Sub ViewToModel()
        _data.No_Pesanan = tbKode.Text
        _data.Kode_Pelanggan = tbPelanggan.Text
        _data.Diskon1 = Decimal.Parse(tbDiskon1.Text)
        _data.Diskon2 = Decimal.Parse(tbDiskon2.Text)
        _data.PPN1 = Decimal.Parse(tbPPN1.Text)
        _data.PPN2 = Decimal.Parse(tbPPN2.Text)
        _data.Total = Decimal.Parse(tbTotal.Text)
        _data.Sub_Total = Decimal.Parse(tbSubTotal.Text)
        _data.Tanggal = dtTanggal.Value.Date
    End Sub

    Private Sub ModelToView()
        tbKode.Text = _data.No_Pesanan
        tbSubTotal.Text = _data.Sub_Total
        tbDiskon1.Text = _data.Diskon1
        tbDiskon2.Text = _data.Diskon2
        tbPPN1.Text = _data.PPN1
        tbPPN2.Text = _data.PPN2
        tbTotal.Text = _data.Total
        dtTanggal.Value = _data.Tanggal

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

    Private Sub ModelToView(entity As DetailPesanan)
        tbQty.Text = entity.Qty
        tbHarga.Text = entity.Harga
        tbJumlah.Text = entity.Sub_Total
        tbSatuan.Text = entity.Satuan

        If (entity.DataBarang Is Nothing) Then
            tbBarang.Text = ""
            tbNamaBarang.Text = ""
            tbSatuan.Text = ""
        Else
            tbBarang.Text = entity.DataBarang.Kode_Barang
            tbNamaBarang.Text = entity.DataBarang.Nama_Barang
            tbSatuan.Text = entity.DataBarang.Satuan
        End If
    End Sub

    Private Sub ViewToModel(entity As DetailPesanan)
        entity.Kode_Barang = tbBarang.Text
        entity.Nama_Barang = tbNamaBarang.Text
        entity.No_Pesanan = tbKode.Text
        entity.Qty = Integer.Parse(tbQty.Text)
        entity.Harga = Decimal.Parse(tbHarga.Text)
        entity.Sub_Total = Decimal.Parse(tbJumlah.Text)
        entity.Satuan = tbSatuan.Text
    End Sub

    Private Function tbQtyValidating() As Boolean
        Dim i As Integer

        If (tbQty.Text = "") Then
            errMessage.SetError(tbQty, "Field tidak boleh kosong")
            Return True
        ElseIf (Not Integer.TryParse(tbQty.Text, i)) Then
            errMessage.SetError(tbQty, "Field harus angka")
            Return True
        ElseIf (i > _dataDetail.DataBarang.Stok) Then
            errMessage.SetError(tbQty, "Sisa stock tidak mencukupi")
            Return True
        Else
            errMessage.SetError(tbQty, "")
            Return False
        End If
    End Function

    Private Sub tbQty_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbQty.Validating
        Dim qty As Integer

        If (Not Integer.TryParse(tbQty.Text, qty)) Then
            e.Cancel = True
            errMessage.SetError(tbQty, "Field harus angka")
        Else
            errMessage.SetError(tbQty, "")
        End If
    End Sub

    Private Sub tbHarga_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbHarga.Validating
        Dim harga As Decimal

        If (Not Decimal.TryParse(tbHarga.Text, harga)) Then
            e.Cancel = True
            errMessage.SetError(tbHarga, "Field harus angka")
        Else
            errMessage.SetError(tbHarga, "")
        End If
    End Sub

    Private Sub tbSubTotal_TextChanged(sender As Object, e As EventArgs) Handles tbSubTotal.TextChanged
        Dim amt1, amt2, pct1, pct2, subTotal As Decimal
        subTotal = Decimal.Parse(tbSubTotal.Text)
        pct1 = Decimal.Parse(tbDiskon1.Text)
        pct2 = Decimal.Parse(tbPPN1.Text)

        amt1 = pct1 * subTotal / 100
        amt2 = pct2 * (subTotal - amt1) / 100
        tbDiskon2.Text = amt1
        tbPPN2.Text = amt2
        tbTotal.Text = subTotal - amt1 + amt2
    End Sub

    Private Sub tbDiskon2_TextChanged(sender As Object, e As EventArgs) Handles tbDiskon2.TextChanged
        If (tbDiskon2.Text Is "") Then
            tbDiskon2.Text = "0"
        End If

        If (tbDiskon2.Focused) Then
            Dim amt1, amt2, pct1, pct2, subTotal As Decimal
            subTotal = Decimal.Parse(tbSubTotal.Text)
            amt1 = Decimal.Parse(tbDiskon2.Text)
            pct2 = Decimal.Parse(tbPPN1.Text)

            pct1 = amt1 / subTotal * 100
            amt2 = pct2 * (subTotal - amt1) / 100
            tbDiskon1.Text = pct1.ToString("n0")
            tbPPN2.Text = amt2
            tbTotal.Text = subTotal - amt1 + amt2
        End If
    End Sub

    Private Sub tbDiskon1_TextChanged(sender As Object, e As EventArgs) Handles tbDiskon1.TextChanged

        If (tbDiskon1.Text Is "") Then
            tbDiskon1.Text = "0"
        End If


        If (tbDiskon1.Focused) Then
            Dim amt1, amt2, pct1, pct2, subTotal As Decimal
            subTotal = Decimal.Parse(tbSubTotal.Text)
            pct1 = Decimal.Parse(tbDiskon1.Text)
            pct2 = Decimal.Parse(tbPPN1.Text)

            amt1 = pct1 * subTotal / 100
            amt2 = pct2 * (subTotal - amt1) / 100
            tbDiskon2.Text = amt1
            tbPPN2.Text = amt2
            tbTotal.Text = subTotal - amt1 + amt2
        End If
    End Sub

    Private Sub tbPPN1_TextChanged(sender As Object, e As EventArgs) Handles tbPPN1.TextChanged
        If (tbPPN1.Text Is "") Then
            tbPPN1.Text = "0"
        End If

        If (tbPPN1.Focused) Then
            Dim amt2, pct2, subTotal As Decimal
            subTotal = Decimal.Parse(tbSubTotal.Text) - Decimal.Parse(tbDiskon2.Text)
            pct2 = Decimal.Parse(tbPPN1.Text)
            amt2 = pct2 * subTotal / 100
            tbPPN2.Text = amt2
            tbTotal.Text = subTotal + amt2
        End If
    End Sub

    Private Sub tbPPN2_TextChanged(sender As Object, e As EventArgs) Handles tbPPN2.TextChanged
        If (tbPPN2.Text Is "") Then
            tbPPN2.Text = "0"
        End If

        If (tbPPN2.Focused) Then
            Dim amt2, pct2, subTotal As Decimal
            subTotal = Decimal.Parse(tbSubTotal.Text) - Decimal.Parse(tbDiskon2.Text)
            amt2 = Decimal.Parse(tbPPN2.Text)
            pct2 = amt2 / subTotal * 100
            tbPPN1.Text = pct2
            tbTotal.Text = subTotal + amt2
        End If
    End Sub



#End Region
End Class
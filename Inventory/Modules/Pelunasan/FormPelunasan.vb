Imports System.Data.SqlClient

Public Class FormPelunasan
#Region "Property"

    Private _isTambah As Boolean = False
    Private _isUbah As Boolean = False
    Private _isTampil As Boolean = True

    Private _db As DbEntities
    Private _data As DataPelunasan
    Private _cls As ClassPelunasan
    Private _clsPiutang As ClassPiutang

#End Region

#Region "Instance"
    Private _sqlConn As SqlConnection
    Private _idSelected As String = String.Empty
    Private _idxRow As Integer
    Private _isTambahDetail As Boolean = True
    Private _isUbahDetail As Boolean
    Private _bs As BindingSource
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        InitStatus("tambah")
        _db = New DbEntities()
        _cls = New ClassPelunasan(_db)
        _clsPiutang = New ClassPiutang(_db)
        _data = New DataPelunasan()
        tbKode.Text = _cls.GetNextKode()
    End Sub
#End Region

#Region "Events"
    Private Sub InitStatus(status As String)
        _isTambah = IIf(status = "tambah", True, False)
        _isUbah = IIf(status = "ubah", True, False)
        _isTampil = IIf(status = "tampil", True, False)
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



    Private Sub TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPelanggan.Validating
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
#End Region

#Region "Functions"

#End Region

#Region "Methods"

    Private Sub ViewToModel()
        _data.No_Pelunasan = tbKode.Text
        _data.No_Piutang = tbPiutang.Text
        _data.Tanggal = dtTanggal.Value
        _data.Bayar = tbBayar.Text

    End Sub

    Public Sub ModelToView()
        tbKode.Text = _data.No_Pelunasan
        tbPiutang.Text = _data.No_Piutang
        tbBayar.Text = _data.Bayar
        dtTanggal.Value = _data.Tanggal
    End Sub


    Dim alamat As String
    Private Sub btnPiutang_Click(sender As Object, e As EventArgs) Handles btnPiutang.Click
        Dim frm = New FormBrowerPiutang(_db)
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim jumlahTermin = (From d In _db.DataTerminPelunasan Where d.No_Penjualan = _data.No_Piutang Select d.Jumlah_Termin).FirstOrDefault()
            Dim countTermin = (From d In _db.DataPelunasan Where d.No_Piutang = _data.No_Piutang).Count
            _data.DataPiutang = frm.Entity
            tbPiutang.Text = _data.DataPiutang.No_Piutang
            dtTempo.Value = _data.DataPiutang.Jatuh_Tempo
            tbPelanggan.Text = _data.DataPiutang.Kode_Pelanggan
            tbNamaPelanggan.Text = _data.DataPiutang.DataPelanggan.Nama_Pelanggan
            tbTermin.Text = countTermin + 1
            tbTotalHarga.Text = _data.DataPiutang.Nilai
            Dim panjar As Long = _data.DataPiutang.Panjar
            Dim totalBayar As Long = IIf(jumlahTermin <> 0, _data.DataPiutang.Nilai / jumlahTermin, _data.DataPiutang.Total_Bayar)
            tbTotalBayar.Text = panjar + totalBayar

            tbSisa.Text = Long.Parse(tbTotalHarga.Text) - Long.Parse(tbTotalBayar.Text)
        End If

    End Sub

    Private Sub tbBayar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbBayar.Validating
        Dim l As Long

        If String.IsNullOrWhiteSpace(tbBayar.Text) Then
            e.Cancel = True
            errMessage.SetError(tbBayar, "Field Tidak Boleh Kosong")
        ElseIf Not Long.TryParse(tbBayar.Text, l) Then
            e.Cancel = True
            errMessage.SetError(tbBayar, "Field Harus Angka")
        ElseIf Long.Parse(tbBayar.Text) < 1 Then
            e.Cancel = True
            errMessage.SetError(tbBayar, "Field Tidak Boleh 0 atau negatif")
        Else
            errMessage.SetError(tbBayar, String.Empty)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            'Dim rpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Dim rpt = New Faktur_Pelunasan_Kredit()
            Dim path = CurDir() + "\Laporan\"
            rpt.Load(path + "Faktur Pelunasan Kredit.rpt")
            rpt.Refresh()

            rpt.SetParameterValue("No Pelunasan", tbKode.Text)
            rpt.SetParameterValue("No Piutang", tbPiutang.Text)
            rpt.SetParameterValue("Nama Pelanggan", tbNamaPelanggan.Text)
            rpt.SetParameterValue("Jatuh Tempo", dtTempo.Text)
            rpt.SetParameterValue("Total Harga", tbTotalHarga.Text)
            rpt.SetParameterValue("Total Bayar", tbTotalBayar.Text)
            rpt.SetParameterValue("Sisa", tbSisa.Text)
            rpt.SetParameterValue("Bayar", tbBayar.Text)
            rpt.SetParameterValue("Tanggal", dtTanggal.Value)
            rpt.SetParameterValue("Alamat", alamat)

            ' Dim view = New FormLaporan("Pelunasan Kredit")
            ' View.ShowDialog()
            Close()
        End If
    End Sub

    Private Sub tbPiutang_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPiutang.Validating
        If String.IsNullOrWhiteSpace(tbPiutang.Text) Then
            e.Cancel = True
            errMessage.SetError(tbPiutang, "Field Tidak Boleh Kosong")
        Else
            errMessage.SetError(tbPiutang, String.Empty)
        End If
    End Sub

#End Region
End Class

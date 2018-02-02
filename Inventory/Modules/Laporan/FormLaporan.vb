Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporan

#Region "Instance"

    Private _db As DbEntities
    Private _cls As Object
    Private _reportName As ReportName
    Private _rpt As ReportDocument
    Private _path As String
    Private _reportFile As String

#End Region

#Region "Constructor"
    Public Sub New(rptName As ReportName)
        InitializeComponent()
        _db = New DbEntities()
        _reportName = rptName
        _rpt = New ReportDocument()
        _path = CurDir() + "\Modules\Laporan\"
        _reportFile = ""
        InitializeComponent()
    End Sub

    Public Sub New(rptName As ReportName, rpt As ReportDocument)
        InitializeComponent()
        _db = New DbEntities()
        _reportName = rptName
        _rpt = rpt
        InitializeComponent()
    End Sub

#End Region

#Region "Event"

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _reportName = ReportName.Barang Then
            lblTitle.Text = "Persediaan Barang"
            _reportFile = "Laporan Barang.rpt"
            _cls = New ClassBarang(_db)

        ElseIf _reportName = ReportName.Pelanggan Then
            lblTitle.Text = "Persediaan Pelanggan"
            _reportFile = "Laporan Pelanggan.rpt"
            _cls = New ClassPelanggan(_db)

        ElseIf _reportName = ReportName.Penjualan Then
            lblTitle.Text = "Laporan Penjualan"
            _reportFile = "Laporan Penjualan.rpt"
            _cls = New ClassLaporanPenjualan(_db)

        ElseIf _reportName = ReportName.Pelunasan Then
            lblTitle.Text = "Laporan Pelunasan Kredit"
            _reportFile = "Laporan Pelunasan Kredit.rpt"
            _cls = New ClassLaporanPelunasanKredit(_db)

        ElseIf _reportName = ReportName.Pembelian Then
            lblTitle.Text = "Laporan Pembelian"
            _reportFile = "Laporan Pembelian.rpt"
            _cls = New ClassPembelian(_db)

        ElseIf _reportName = ReportName.FakturPemesanan Then
            lblTitle.Text = "Faktur Pemesanan"
        End If

        Dim list = _cls.GetEntities()
        _rpt.Load(_path + _reportFile, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        _rpt.Refresh()
        _rpt.SetDataSource(list)
        CrystalReportViewer1.ReportSource = _rpt
        CrystalReportViewer1.Refresh()
    End Sub

#End Region
End Class

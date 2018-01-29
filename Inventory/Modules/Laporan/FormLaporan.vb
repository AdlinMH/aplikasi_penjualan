Public Class FormLaporan

#Region "Instance"

    Private _db As DbEntities
    Private _cls As Object
    Private _ReportName As ReportName


#End Region

#Region "Constructor"
    Public Sub New(rptName As ReportName)
        InitializeComponent()
        _db = New DbEntities()
        _ReportName = rptName

        InitializeComponent()
    End Sub

#End Region

#Region "Event"

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Dim path = CurDir() + "\Modules\Laporan\"
        Dim reportFile = ""

        If _ReportName = ReportName.Barang Then
            lblTitle.Text = "Persediaan Barang"
            reportFile = "Laporan Barang.rpt"
            _cls = New ClassBarang(_db)

        ElseIf _ReportName = ReportName.Pelanggan Then
            lblTitle.Text = "Persediaan Pelanggan"
            reportFile = "Laporan Pelanggan.rpt"
            _cls = New ClassPelanggan(_db)

        ElseIf _ReportName = ReportName.Penjualan Then
            lblTitle.Text = "Laporan Penjualan"
            reportFile = "Laporan Penjualan.rpt"
            _cls = New ClassLaporanPenjualan(_db)

        End If

        Dim list = _cls.GetEntities()
        rpt.Load(path + reportFile, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        rpt.Refresh()
        rpt.SetDataSource(list)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

#End Region
End Class

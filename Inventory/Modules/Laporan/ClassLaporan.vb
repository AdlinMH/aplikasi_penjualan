#Region "Laporan Penjualan"

Public Class ClassLaporanPenjualan
    Public Property No_Penjualan As String
    Public Property No_Pesanan As String
    Public Property Nama_Pelanggan As String
    Public Property Tanggal As String
    Public Property Jatuh_Tempo As String
    Public Property SubTotal As Long
    Public Property Diskon As String
    Public Property PPN As String
    Public Property Total As Double
    Public Property Panjar As Double
    Public Property Jenis As String

    Private _db As DbEntities

    Public Sub New()
    End Sub

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of ClassLaporanPenjualan, Boolean)) As Object
        Dim data = (From x In _db.DataPenjualan).ToList()

        Dim d As List(Of ClassLaporanPenjualan) = New List(Of ClassLaporanPenjualan)
        Dim dd As ClassLaporanPenjualan
        For Each x In data
            dd = New ClassLaporanPenjualan
            With dd
                .No_Penjualan = x.No_Penjualan
                .No_Pesanan = x.No_Pesanan
                .Nama_Pelanggan = x.DataPelanggan.Nama_Pelanggan
                .Tanggal = x.Tanggal.Value.ToString("dd/MM/yyyy")
                .Diskon = x.Diskon1.ToString() & "%"
                .Jatuh_Tempo = x.Jatuh_Tempo.Value.ToString("dd/MM/yyyy")
                .Panjar = x.Panjar
                .Total = x.Total
                .PPN = (x.PPN1 & "%")
                .Jenis = x.Jenis
            End With
            d.Add(dd)
        Next
        Return d
    End Function

End Class

#End Region

#Region "Laporan Pembelian"

Public Class ClassLaporanPembelian
    Public Property No_Pembelian As String
    Public Property Nama_Supplier As String
    Public Property Tanggal As String
    Public Property SubTotal As Long
    Public Property Diskon As String
    Public Property PPN As String
    Public Property Total As Double

    Private _db As DbEntities

    Public Sub New()
    End Sub

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of ClassLaporanPembelian, Boolean)) As Object
        Dim data = (From x In _db.DataPembelian).ToList()

        Dim d As List(Of ClassLaporanPembelian) = New List(Of ClassLaporanPembelian)
        Dim dd As ClassLaporanPembelian
        For Each x In data
            dd = New ClassLaporanPembelian
            With dd
                .No_Pembelian = x.No_Pembelian
                .Nama_Supplier = x.DataSupplier.Nama_Supplier
                .Tanggal = x.Tanggal.ToString("dd/MM/yyyy")
                .Diskon = x.Diskon1.ToString() & "%"
                .Total = x.Total
            End With
            d.Add(dd)
        Next
        Return d
    End Function

End Class

#End Region

#Region "Laporan Pelunasan Kredit"

Public Class ClassLaporanPelunasanKredit
    Public Property No_Pelunasan As String
    Public Property No_Piutang As String
    Public Property Nama_Pelanggan As String
    Public Property Jatuh_Tempo As String
    Public Property Total_Bayar As Double
    Public Property Bayar As Double

    Private _db As DbEntities

    Public Sub New()
    End Sub

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of ClassLaporanPelunasanKredit, Boolean)) As Object
        Dim data = (From x In _db.DataPelunasan).ToList()

        Dim d As List(Of ClassLaporanPelunasanKredit) = New List(Of ClassLaporanPelunasanKredit)
        Dim dd As ClassLaporanPelunasanKredit
        For Each x In data
            dd = New ClassLaporanPelunasanKredit
            With dd
                .No_Pelunasan = x.No_Pelunasan
                .No_Piutang = x.No_Piutang
                .Nama_Pelanggan = x.DataPiutang.DataPelanggan.Nama_Pelanggan
                .Jatuh_Tempo = x.DataPiutang.Jatuh_Tempo.Value.ToString("dd/MM/yyyy")
                .Total_Bayar = x.DataPiutang.Total_Bayar
                .Bayar = x.Bayar
            End With
            d.Add(dd)
        Next
        Return d
    End Function

End Class

#End Region
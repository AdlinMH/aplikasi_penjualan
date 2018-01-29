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
                .Tanggal = x.Tanggal.ToString()
                .Diskon = x.Diskon1.ToString() & "% + " & x.Diskon2.ToString() & "%"
                .Jatuh_Tempo = x.Jatuh_Tempo.ToString()
                .Panjar = x.Panjar
                .Total = x.Total
                .PPN = (x.PPN1 & "% + " & x.PPN2 & "%")
                .Jenis = x.Jenis
            End With
            d.Add(dd)
        Next
        Return d
    End Function

    Private Function IsEmpty(Val As Double, DefaultVal As Double)
        If (IsNothing(Val)) Then
            Return DefaultVal
        Else
            Return Val
        End If
    End Function
End Class

#End Region


#Region "Laporan "
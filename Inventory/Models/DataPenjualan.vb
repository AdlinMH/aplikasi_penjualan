'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class DataPenjualan
    Public Property No_Penjualan As String
    Public Property Tanggal As Nullable(Of Date)
    Public Property Jenis As String
    Public Property No_Pesanan As String
    Public Property Kode_Pelanggan As String
    Public Property Jatuh_Tempo As Nullable(Of Date)
    Public Property Sub_Total As Nullable(Of Long)
    Public Property Diskon1 As Nullable(Of Decimal)
    Public Property Diskon2 As Nullable(Of Decimal)
    Public Property PPN1 As Nullable(Of Decimal)
    Public Property PPN2 As Nullable(Of Decimal)
    Public Property Total As Nullable(Of Decimal)
    Public Property Panjar As Nullable(Of Decimal)
    Public Property Delete As String
    Public Property ID As Integer

    Public Overridable Property DataPelanggan As DataPelanggan
    Public Overridable Property DataPesanan As DataPesanan

End Class

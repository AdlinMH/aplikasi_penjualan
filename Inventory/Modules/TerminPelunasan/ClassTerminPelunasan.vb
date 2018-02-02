Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassTerminPelunasan
    Public WriteOnly Property Data() As DataTerminPelunasan
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataTerminPelunasan

    Const KODE As String = "TPL-"
    Private _db As DbEntities

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Sub AddOrUpdate()
        _db.Entry(_data).State = EntityState.Added
        _db.SaveChanges()
    End Sub

    Public Sub Delete()
        _db.SaveChanges()
    End Sub

    Public Function GetNextKode() As String
        Dim data = _db.DataPenjualan.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataPenjualan
        Return _db.DataPenjualan.Find(code)
    End Function

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of DataPenjualan, Boolean)) As Object
        Return _db.DataPenjualan.Where(Function(x) x.Delete = "N").Where(condition).Select(Function(x) New With {x.No_Penjualan, x.DataPelanggan.Nama_Pelanggan, x.Tanggal, x.Sub_Total, x.Diskon1, x.Diskon2, x.Total}).ToList()
    End Function

End Class


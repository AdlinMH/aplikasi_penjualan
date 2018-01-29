Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassPembelian
    Public WriteOnly Property Data() As DataPembelian
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataPembelian

    Const KODE As String = "PSN-"
    Private _db As DbEntities

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Sub AddOrUpdate()
        If _data.ID = 0 Then
            _data.Delete = "N"
            _data.Digunakan = "N"
            _db.Entry(_data).State = EntityState.Added
        End If
        _db.SaveChanges()
    End Sub

    Public Sub Delete()
        _data.Delete = "Y"
        _db.SaveChanges()
    End Sub

    Public Function GetNextKode() As String
        Dim data = _db.DataPembelian.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataPembelian
        Return _db.DataPembelian.Find(code)
    End Function

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of DataPembelian, Boolean)) As Object
        Return _db.DataPembelian.Where(Function(x) x.Delete = "N").Where(condition).Select(Function(x) New With {x.No_Pembelian, x.DataSupplier.Nama_Supplier, x.Tanggal, x.Sub_Total, x.Diskon1, x.Diskon2, x.Total}).ToList()
    End Function

End Class


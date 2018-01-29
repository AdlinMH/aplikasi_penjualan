Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassBarang
    Public WriteOnly Property Data() As DataBarang
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataBarang

    Const KODE As String = "BRG-"
    Private _db As DbEntities

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Sub AddOrUpdate()
        If _data.ID = 0 Then
            _data.Delete = "N"
            _db.Entry(_data).State = EntityState.Added
        End If
        _db.SaveChanges()
    End Sub

    Public Sub DeleteData()
        _data.Delete = "Y"
        _db.SaveChanges()
    End Sub

    Public Function GetNextKode() As String
        Dim data = _db.DataBarang.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataBarang
        Return _db.DataBarang.Find(code)
    End Function

    Public Function GetEntities() As IEnumerable(Of DataBarang)
        Return _db.DataBarang.Where(Function(x) x.Delete = "N").ToList()
    End Function

    Public Function GetEntitiesView() As Object
        Return GetEntitiesView(Function(x) True)
    End Function

    Public Function GetEntitiesView(condition As Func(Of DataBarang, Boolean)) As Object
        Return _db.DataBarang.Where(Function(x) x.Delete = "N").Where(condition).Select(Function(x) New With {x.Kode_Barang, x.Nama_Barang, x.DataKelompok.Nama_Kelompok, x.Stok, x.Satuan, x.Harga_beli, x.Harga_Jual}).ToList()
    End Function
End Class


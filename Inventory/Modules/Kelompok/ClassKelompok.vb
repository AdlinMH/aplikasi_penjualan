Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassKelompok
    Public WriteOnly Property Data() As DataKelompok
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataKelompok

    Const KODE As String = "KLP-"
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
        Dim data = _db.DataKelompok.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataKelompok
        Return _db.DataKelompok.Find(code)
    End Function


    Public Function GetEntities() As IEnumerable(Of DataKelompok)
        Return _db.DataKelompok.Where(Function(x) x.Delete = "N").ToList()
    End Function

    Public Function GetEntities(predicate As Func(Of DataKelompok, Boolean))
        Return _db.DataKelompok.Where(Function(x) x.Delete = "N").Where(predicate).ToList()
    End Function

End Class
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassPelunasan
    Public WriteOnly Property Data() As DataPelunasan
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataPelunasan

    Const KODE As String = "PEL-"
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

    Public Sub Delete()
        _data.Delete = "Y"
        _db.SaveChanges()
    End Sub

    Public Function GetNextKode() As String
        Dim data = _db.DataPelunasan.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataPelunasan
        Return _db.DataPelunasan.Find(code)
    End Function

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of DataPelunasan, Boolean)) As Object
        Return _db.DataPelunasan.Where(Function(x) x.Delete = "N").Where(condition)
    End Function

End Class


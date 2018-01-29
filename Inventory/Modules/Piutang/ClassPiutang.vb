Imports System.Data.Common
Imports System.Data.SqlClient

Public Class ClassPiutang
    Public WriteOnly Property Data() As DataPiutang
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataPiutang

    Const KODE As String = "PEL-"
    Private _db As DbEntities

    Public Sub New(db As DbEntities)
        _db = db
    End Sub

    Public Sub AddOrUpdate()
        _db.Entry(_data).State = EntityState.Added
        _db.SaveChanges()
    End Sub


    Public Function GetEntity(code As String) As DataPiutang
        Return _db.DataPiutang.Find(code)
    End Function

    Public Function GetEntities() As Object
        Return GetEntities(Function(x) True)
    End Function

    Public Function GetEntities(condition As Func(Of DataPiutang, Boolean)) As Object
        Return _db.DataPiutang.Where(condition).ToList()
    End Function

End Class


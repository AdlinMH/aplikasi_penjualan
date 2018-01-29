Public Class ClassPelanggan

    Public WriteOnly Property Data() As DataPelanggan
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataPelanggan

    Const KODE As String = "PLG-"
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
        Dim data = _db.DataPelanggan.OrderByDescending(Function(x) x.ID).FirstOrDefault()

        If (IsNothing(data)) Then
            Return String.Concat(KODE, 1)
        Else
            Return String.Concat(KODE, data.ID + 1)
        End If
    End Function

    Public Function GetEntity(code As String) As DataPelanggan
        Return _db.DataPelanggan.Find(code)
    End Function

    Public Function GetEntities() As IEnumerable(Of DataPelanggan)
        Return _db.DataPelanggan.Where(Function(x) x.Delete = "N").ToList()
    End Function

    Public Function GetEntities(condition As Func(Of DataPelanggan, Boolean)) As IEnumerable(Of DataPelanggan)
        Return _db.DataPelanggan.Where(Function(x) x.Delete = "N").Where(condition).ToList()
    End Function

End Class


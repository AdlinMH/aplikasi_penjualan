Public NotInheritable Class DAL
    Public WriteOnly Property Data() As Object
        Set
            _data = Value
        End Set
    End Property
    Private _data As Object

    Private _db As DbEntities

    Public Sub New(db As DbEntities)
        _db = db
    End Sub
End Class

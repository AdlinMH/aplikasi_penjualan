Imports System.Data.SqlClient

Public Class ClassUser
    Private _db As DbEntities
    Public Property Data() As DataUser
        Get
            Return _data
        End Get
        Set
            _data = Value
        End Set
    End Property
    Private _data As DataUser
    Public Sub New(db)
        _data = New DataUser()
        _db = db
    End Sub

    Public Function IsAuthorized() As Boolean
        Dim user = _db.DataUser.Where(Function(x) x.User_Name = _data.User_Name And x.Password = _data.Password)

        If (IsNothing(user)) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function GantiPassword(user1 As String, user2 As String, pass1 As String, pass2 As String) As Boolean
        Data = New DataUser()
        Data.Password = pass1
        Data.User_Name = user1
        If Not IsAuthorized() Then
            MessageBox.Show("Kombinsasi Nama User dan Password Salah")
            Return False
        End If

        _db.Entry(Data).State = EntityState.Modified
        _db.SaveChanges()
        Return True
    End Function

End Class
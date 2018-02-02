Imports System.Data.SqlClient

Public Class FormLogin
    Private _db As DbEntities
    Private _cls As ClassUser
    Private _data As DataUser

    Public Sub New()
        InitializeComponent()
        _db = New DbEntities()
        _data = New DataUser()
        _cls = New ClassUser(_db)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        _data.Password = tbPass.Text
        _data.User_Name = tbUser.Text

        _cls.Data = _data
        Dim a = _cls.IsAuthorized()

        If a Then
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Kombinasi Nama User dan Password Salah")
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class

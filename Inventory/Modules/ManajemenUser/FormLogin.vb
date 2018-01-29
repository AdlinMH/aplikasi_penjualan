Imports System.Data.SqlClient

Public Class FormLogin
    Private _sqlConn As SqlConnection

    Public Sub New(_sqlConn As SqlConnection)
        InitializeComponent()
        Me._sqlConn = _sqlConn
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cls = New ClassUser(_sqlConn)
        Dim data = New ModelUser()
        data.Password = tbPass.Text
        data.UserName = tbUser.Text
        cls.Data = data
        Dim a = cls.IsAuthorized()

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

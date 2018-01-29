Imports System.Data.SqlClient

Public Class ClassUser
    Private _sqlConn As SqlConnection
    Public Property Data() As ModelUser
        Get
            Return _data
        End Get
        Set
            _data = Value
        End Set
    End Property
    Private _data As ModelUser
    Public Sub New(sqlConn As SqlConnection)
        _data = New ModelUser()
        _sqlConn = sqlConn
    End Sub

    Public Function IsAuthorized() As Boolean
        Dim sqlCmd As SqlCommand
        Dim sql As String
        Dim sda As SqlDataAdapter
        Dim dt As DataTable

        sql = "SELECT * FROM dbo.DataUser WHERE [User Name] = @id AND [Password] = @pass"
        sqlCmd = New SqlCommand(sql, _sqlConn)
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = _data.UserName
        sqlCmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = _data.Password

        If _sqlConn.State = ConnectionState.Closed Then
            _sqlConn.Open()
        End If

        sda = New SqlDataAdapter(sqlCmd)
        dt = New DataTable()
        sda.Fill(dt)
        sda.Dispose()

        Try
            Return dt.Rows(0).ItemArray.Count > 0
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function GantiPassword(user1 As String, user2 As String, pass1 As String, pass2 As String) As Boolean
        Data = New ModelUser()
        Data.Password = pass1
        Data.UserName = user1
        If Not IsAuthorized() Then
            MessageBox.Show("Kombinsasi Nama User dan Password Salah")
            Return False
        End If

        Dim sqlCmd As SqlCommand
        Dim sql As String

        sql = "Update DataUser set [User Name] = @user, [Password] = @pass where [User Name] = @id"
        sqlCmd = New SqlCommand(sql, _sqlConn)
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = user1
        sqlCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user2
        sqlCmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass2

        If _sqlConn.State = ConnectionState.Closed Then
            _sqlConn.Open()
        End If

        sqlCmd.ExecuteNonQuery()
        Return True
    End Function

End Class
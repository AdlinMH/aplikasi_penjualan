Imports System.Data.SqlClient

Public Class ClassDB
    Public Shared Function GetLastID(sqlConn As SqlConnection, tableName As String) As Integer

        Dim sqlCmd As SqlCommand
        Dim sql As String

        If sqlConn.State = ConnectionState.Closed Then
            sqlConn.Open()
        End If

        sql = String.Format("SELECT IDENT_CURRENT('{0}')", tableName)

        sqlCmd = New SqlCommand(sql, sqlConn)
        sqlCmd.CommandType = CommandType.Text

        Dim id = sqlCmd.ExecuteScalar()

        sql = String.Format("SELECT COUNT(*) FROM {0} ", tableName)

        sqlCmd = New SqlCommand(sql, sqlConn)
        sqlCmd.CommandType = CommandType.Text

        Dim rowCount = Convert.ToInt32(sqlCmd.ExecuteScalar())

        If rowCount = 0 Then
            Return 0
        Else
            Return id
        End If

    End Function
End Class

Public Class ModelUser
    Public Property UserName() As String
        Get
            Return m_UserName
        End Get
        Set(value As String)
            m_UserName = value
        End Set
    End Property
    Private m_UserName As String

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(value As String)
            m_Password = value
        End Set
    End Property
    Private m_Password As String
End Class

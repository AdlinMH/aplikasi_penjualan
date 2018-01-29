Imports System.Data.SqlClient

Public Class FormDaftarPelunasanKredit
    Private _sqlConn As SqlConnection

#Region "Constructor"
    Public Sub New()
        InitializeComponent()

        Run()
    End Sub

    Private Sub Run()
        'Dim cls = New ClassPelunasan()
        'gvData.DataSource = cls.GetDataList()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub
#End Region

End Class

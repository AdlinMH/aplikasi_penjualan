Imports System.Data.SqlClient

Public Class FormDaftarPiutang

#Region "Instance"
    Private _bs As BindingSource
    Private _cls As ClassPiutang
    Private _db As DbEntities
    Private _data As DataPiutang
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        _bs = New BindingSource()
        _db = New DbEntities()
        _cls = New ClassPiutang(_db)

        gvData.AutoGenerateColumns = False
    End Sub
#End Region

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        _bs.DataSource = _cls.GetEntities()
        _bs.ResetBindings(False)
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _bs.DataSource = _cls.GetEntities()
        gvData.DataSource = _bs
    End Sub

#Region "Functions"

    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        If rbKode.Checked Then
            gvData.DataSource = _cls.GetEntities(Function(x) x.No_Piutang.Contains(tbPencarian.Text))
        Else
            gvData.DataSource = _cls.GetEntities(Function(x) x.DataPelanggan.Nama_Pelanggan.Contains(tbPencarian.Text))
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

#End Region

End Class

Imports System.Data.SqlClient

Public Class FormDaftarPembelian

#Region "Instance"
    Private _bs As BindingSource
    Private _cls As ClassPembelian
    Private _db As DbEntities
    Private _data As DataPembelian
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
        _bs = New BindingSource()
        _db = New DbEntities()
        _cls = New ClassPembelian(_db)
    End Sub
#End Region

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        _bs.DataSource = _cls.GetEntities()
        _bs.ResetBindings(False)
        initControl()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        _data = _cls.GetEntity(IdSelected())
        Dim frm = New FormPembelian(_data)
        frm.ShowDialog()

        _bs.DataSource = _cls.GetEntities()
        _bs.ResetBindings(False)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        _data = _cls.GetEntity(IdSelected())
        _cls.Data = _data
        _cls.Delete()

        _bs.DataSource = _cls.GetEntities()
        _bs.ResetBindings(False)
        initControl()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _bs.DataSource = _cls.GetEntities()
        gvData.DataSource = _bs
        initControl()
    End Sub

#Region "Functions"
    Private Function isHaveData() As Boolean
        Return gvData.RowCount > 0
    End Function

    Private Function IdSelected() As String
        Dim idx = gvData.CurrentRow.Index
        Return gvData.Item(0, idx).Value
    End Function

    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        If rbKode.Checked Then
            gvData.DataSource = _cls.GetEntities(Function(x) x.No_Pembelian.Contains(tbPencarian.Text))
        Else
            gvData.DataSource = _cls.GetEntities(Function(x) x.DataSupplier.Nama_Supplier.Contains(tbPencarian.Text))
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

#End Region

#Region "Method"
    Private Sub initControl()
        btnHapus.Enabled = isHaveData()
        btnUbah.Enabled = isHaveData()
    End Sub
#End Region
End Class

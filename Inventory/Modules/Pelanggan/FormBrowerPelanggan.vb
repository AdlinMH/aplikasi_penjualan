Public Class FormBrowerPelanggan

    Private m_data As DataPelanggan
    Public ReadOnly Property Entity()
        Get
            Return m_data
        End Get
    End Property

    Private ReadOnly _cls As ClassPelanggan

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(db As DbEntities)
        InitializeComponent()
        _cls = New ClassPelanggan(db)
    End Sub

    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        If rbKode.Checked Then
            gvData.DataSource = _cls.GetEntities(Function(x) x.Kode_Pelanggan.Contains(tbPencarian.Text))
        Else
            gvData.DataSource = _cls.GetEntities(Function(x) x.Nama_Pelanggan.Contains(tbPencarian.Text))
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim idx = gvData.CurrentRow.Index
        m_data = gvData.CurrentRow.DataBoundItem
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub FormBrowerPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvData.DataSource = _cls.GetEntities()
        gvData.Select()
    End Sub
End Class

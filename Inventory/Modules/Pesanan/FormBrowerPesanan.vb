Public Class FormBrowerPesanan

    Private m_data As DataPesanan
    Public ReadOnly Property Entity()
        Get
            Return m_data
        End Get
    End Property

    Private ReadOnly _cls As ClassPesanan

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(db As DbEntities)
        InitializeComponent()
        _cls = New ClassPesanan(db)
    End Sub

    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        If rbKode.Checked Then
            gvData.DataSource = _cls.GetEntities(Function(x) x.No_Pesanan.Contains(tbPencarian.Text))
        Else
            gvData.DataSource = _cls.GetEntities(Function(x) x.No_Pesanan.Contains(tbPencarian.Text))
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim idx = gvData.CurrentRow.Index
        m_data = _cls.GetEntity(gvData.Item(0, idx).Value)
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

    Private Sub FormBrowerPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvData.DataSource = _cls.GetEntities(Function(x) x.Digunakan = "N")
        gvData.Select()
    End Sub
End Class

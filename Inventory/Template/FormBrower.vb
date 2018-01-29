Public Class FormBrower
    Private m_code As String = String.Empty
    Public ReadOnly Property Code()
        Get
            Return m_code
        End Get
    End Property

    Private m_data As DataRow
    Public ReadOnly Property Data()
        Get
            Return m_data
        End Get
    End Property

    Private ReadOnly _dt As DataTable
    Private ReadOnly _code As String
    Private ReadOnly _nama As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(title As String, a As Object)
        InitializeComponent()
        lblTitle.Text = title
        gvData.DataSource = a
        gvData.Select()
    End Sub

    Public Sub New(title As String, dt As DataTable)
        InitializeComponent()
        lblTitle.Text = title
        _dt = dt
        _code = dt.Columns(0).ColumnName
        _nama = dt.Columns(1).ColumnName
        gvData.DataSource = dt
        gvData.Select()
    End Sub


    Private Sub tbPencarian_TextChanged(sender As Object, e As EventArgs) Handles tbPencarian.TextChanged
        Dim dv As DataView = New DataView(_dt)

        If rbKode.Checked Then
            dv.RowFilter = String.Format("[{0}] Like '%{1}%'", _code, tbPencarian.Text.Trim())
        Else
            dv.RowFilter = String.Format("[{0}] Like '%{1}%'", _nama, tbPencarian.Text.Trim())
        End If
        gvData.DataSource = dv
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim idx = gvData.CurrentRow.Index
        m_code = gvData.Item(0, idx).Value
        DialogResult = DialogResult.OK
        Dispose()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
        Dispose()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        DialogResult = DialogResult.Cancel
        Dispose()
    End Sub
End Class

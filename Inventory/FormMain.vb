Imports System.Data.SqlClient
Imports System.Threading

Public Enum ReportName
    Barang
    Pelanggan
    Penjualan
    Pelunasan
End Enum

Public Class FormMain

    Public Sub New()
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalDigits = 2
        Thread.BeginThreadAffinity()

        InitializeComponent()
        MenuStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode
        MenuStrip1.Renderer = New MyRenderer()


    End Sub

    Private Sub KelompokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelompokBarangToolStripMenuItem.Click
        Dim frm = New FormKelompok()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim frm = New FormBarang()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim frm = New FormPelanggan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim frm = New FormSupplier()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm = New FormPesanan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransaksiPelunanasanKreditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm = New FormDaftarPesanan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TransaksiPenjualanTunaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenjualanTunaiToolStripMenuItem.Click
        Dim frm = New FormPenjualan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Dim frm = New FormDaftarPenjualan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim frm = New FormDaftarPelunasanKredit()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim frm = New FormPelunasan()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm = New FormTambahBarang()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Dim frm = New FormDaftarPiutang()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PersedianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersedianBarangToolStripMenuItem.Click
        Dim view = New FormLaporan(ReportName.Barang)
        view.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Dim view = New FormLaporan(ReportName.Pelanggan)
        view.ShowDialog()
    End Sub

    Private Sub PenjualanTunaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanTunaiToolStripMenuItem.Click
        'Dim cls = New ClassPenjualan()
        'Dim list = cls.GetModelFromDT(cls.GetDataList())
        'Dim rpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        'Dim path = CurDir() + "\Laporan\"
        'rpt.Load(path + "Laporan Penjualan.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        'rpt.Refresh()

        'rpt.SetDataSource(list)

        Dim view = New FormLaporan(ReportName.Penjualan)
        view.ShowDialog()
    End Sub

    Private Sub PenjualanKreditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanKreditToolStripMenuItem.Click
        Dim view = New FormLaporan(ReportName.Pelunasan)
        view.ShowDialog()
    End Sub
    Private Sub FormMain_Shown(sender As Object, e As EventArgs)

    End Sub

    Private Sub GantiPasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem1.Click
        Dim frm = New FormGantiPassword()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Function IsFormOpen(form As Form) As Boolean
        For Each frm As Form In MdiChildren
            If frm.Name = form.Name Then
                frm.Activate()
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim frm = New FormPembelian()
        If IsFormOpen(frm) Then
            Return
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class

Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.FromArgb(34, 191, 92), Color.FromArgb(32, 156, 59))
        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using
    End Sub

End Class

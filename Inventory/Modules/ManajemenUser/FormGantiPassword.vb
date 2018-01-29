Imports System.Data.SqlClient

Public Class FormGantiPassword
    Private _sqlConn As SqlConnection

    Public Sub New(_sqlConn As SqlConnection)
        InitializeComponent()
        Me._sqlConn = _sqlConn
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateChildren() Then
            Dim cls = New ClassUser(_sqlConn)
            If cls.GantiPassword(tbUserO.Text, tbUserN.Text, tbPassO.Text, tbPassN1.Text) Then
                MessageBox.Show("Nama User dan Password berhasil diubah")
                Close()
            End If
        End If
    End Sub

    Private Sub tbPassN1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbUserO.Validating, tbUserN.Validating, tbPassO.Validating
        Dim ctrl As Control = sender
        If ctrl.Text = "" Then
            e.Cancel = True
            errMessage.SetError(ctrl, "Field Tidak Boleh Kosong")
        Else
            errMessage.SetError(ctrl, String.Empty)
        End If
    End Sub

    Private Sub tbPassN2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPassN2.Validating
        Dim ctrl As Control = sender
        If ctrl.Text = "" Then
            e.Cancel = True
            errMessage.SetError(ctrl, "Field Tidak Boleh Kosong")
        ElseIf tbPassN2.Text.Length < 4 Then
            e.Cancel = True
            errMessage.SetError(tbPassN2, "Panjang Password minimal 4 karakter")
        ElseIf Not tbPassN1.Text = tbPassN2.Text Then
            e.Cancel = True
            errMessage.SetError(ctrl, "Password Baru tidak sama dengan Ulangi Password")
        Else
            errMessage.SetError(ctrl, String.Empty)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub tbPassN1_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles  tbPassN1.Validating
        Dim ctrl As Control = sender
        If ctrl.Text = "" Then
            e.Cancel = True
            errMessage.SetError(ctrl, "Field Tidak Boleh Kosong")
        ElseIf tbPassN2.Text.Length < 4 Then
            e.Cancel = True
            errMessage.SetError(tbPassN2, "Panjang Password minimal 4 karakter")
        Else
            errMessage.SetError(ctrl, String.Empty)
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub
End Class

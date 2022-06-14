Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hitung As Double

        hitung = Me.BB.Text / ((Me.TB.Text / 100) * (Me.TB.Text / 100))
        Me.Hasil.Text = hitung

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
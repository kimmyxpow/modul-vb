Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jk, l, th, um, total As Double

        jk = Me.jjk.Text * 15000
        l = Me.jl.Text * 10000
        th = Me.jth.Text * 100000
        um = Me.jjk.Text * 10000

        total = jk + l - th

        If (total < 0) Then
            Me.gaji.Text = 0
        Else
            Me.gaji.Text = total
        End If

        Me.makan.Text = um
    End Sub
End Class


Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = "PetzShop " + Date.Now
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "PetzShop" + Date.Now
        Timer1.Start()

    End Sub



    Private Sub btnInventaris_Click_1(sender As Object, e As EventArgs) Handles btnInventaris.Click
        allbarangform.Show()
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        Form2.Show()
    End Sub

    Private Sub Transaksi_Click(sender As Object, e As EventArgs) Handles Transaksi.Click
        Form3.Show()
    End Sub
End Class

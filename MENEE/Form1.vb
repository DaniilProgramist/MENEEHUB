Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a + b) / 2
        TextBox3.Text = c


    End Sub
End Class

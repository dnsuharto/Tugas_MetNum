Public Class Form6

    Dim b As Integer
    Dim c As Integer
    Dim d As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = TextBox1.Text
        c = TextBox2.Text
        c = c + 1
        Do Until b = c
            d = 3 * (b * b) + b - 1
            ListBox1.Items.Add(d)
            b = b + 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
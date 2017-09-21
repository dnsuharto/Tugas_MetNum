Public Class Form5
    Dim FirstNumber As Single
    Dim SecondNumber As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNumber = Val(TextBox1.Text)
        SecondNumber = Val(TextBox2.Text)
        TextBox3.Text = FirstNumber * SecondNumber
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
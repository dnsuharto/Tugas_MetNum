Public Class Form4

    Dim x As Integer
    Dim y As Integer
    Dim hasil As Long
    Dim a As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        hasil = 1
        For a = 1 To y
            hasil = hasil * x
            TextBox3.Text = Str(hasil)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
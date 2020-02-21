Public Class Another
    Private Sub Another_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FridayForm.Show()
        Me.Hide()
    End Sub
End Class
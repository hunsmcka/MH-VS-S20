Public Class ValidateUserData
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click

        IsEmpty()

    End Sub

    Sub IsEmpty()
        Dim userMessage As String
        If TextBox1.Text = "" Then
            userMessage = "Please enter text in textbox 1."
            TextBox1.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage = "Please enter text in textbox 2."
            TextBox2.Select()
        End If
    End Sub

End Class
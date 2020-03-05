Public Class MathContestForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FormControl_Enabled(sender As Object, e As EventArgs) Handles Me.Load, ClearButton.Click
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        MathProblemGroupBox.Enabled = False

    End Sub

    Private Sub AgeTextBox_Validate(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        Dim ageNumber As Integer
        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber < 7 Or ageNumber > 11 Then
                MsgBox("Student is not eligble to compete.")
            Else

            End If

        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""

        End Try

    End Sub
End Class

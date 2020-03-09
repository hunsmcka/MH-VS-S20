Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'https://github.com/hunsmcka/MH-VS-S20

Public Class MathContestForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes the program when exit button is clicked
        Me.Close()

    End Sub

    Public Function CorrectAnswer(function1 As Integer) As Integer

        Return function1
    End Function

    Private Sub FormControl_Enabled(sender As Object, e As EventArgs) Handles Me.Load, ClearButton.Click
        'Clears all the data when the clear button is clicked or the program is loaded
        InformationGroupBox.Enabled = True
        TestButton.Enabled = True
        AnswerTextBox.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        Number1stTextBox.Text = ""
        Number2ndTextBox.Text = ""
        AnswerTextBox.Text = ""
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
        CorrectTextBox.Text = Str(0)
        NumberTextBox.Text = Str(0)
        NameTextBox.Focus()

        CorrectAnswer(0)

    End Sub

    Private Sub AgeTextBox_Validate(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        'Checks the data inputed into the age text box when the cursor leaves the text box
        Dim ageNumber As Integer

        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber < 7 Or ageNumber > 11 Then
                MsgBox("Student is not eligble to compete.")
                AgeTextBox.BackColor = Color.Red
            Else

            End If

        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""
            AgeTextBox.BackColor = Color.Red
        End Try

    End Sub

    Private Sub AgeTextBox_Enter(sender As Object, e As EventArgs) Handles AgeTextBox.Enter
        AgeTextBox.BackColor = Color.White

    End Sub

    Private Sub GradeTextBox_Validate(sender As Object, e As EventArgs) Handles GradeTextBox.Leave
        'Checks the data inputed into the grade text box when the cursor leaves the text box
        Dim gradeNumber As Integer

        Try
            gradeNumber = CInt(GradeTextBox.Text)
            If gradeNumber < 1 Or gradeNumber > 4 Then
                MsgBox("Student is not eligble to compete.")
                GradeTextBox.BackColor = Color.Red

            Else

            End If

        Catch ex As Exception
            MsgBox("Please enter a valid grade.")
            GradeTextBox.Text = ""
            GradeTextBox.BackColor = Color.Red

        End Try

    End Sub

    Private Sub GradeTextBox_Enter(sender As Object, e As EventArgs) Handles GradeTextBox.Enter
        GradeTextBox.BackColor = Color.White

    End Sub

    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        'Checks the information of the student and if it is correct will begin the test
        If NameTextBox.Text = "" Then
            MsgBox("Please enter the student's name.")
            NameTextBox.Focus()

        ElseIf AgeTextBox.BackColor = Color.Red Then
            MsgBox("Please enter a valid age.")
            AgeTextBox.Focus()

        ElseIf AgeTextBox.Text = "" Then
            MsgBox("Please enter the student's age.")
            AgeTextBox.Focus()

        ElseIf GradeTextBox.BackColor = Color.Red Then
            MsgBox("Please enter a valid grade.")
            GradeTextBox.Focus()

        ElseIf GradeTextBox.Text = "" Then
            MsgBox("Please enter the student's grade.")
            GradeTextBox.Focus()

        Else
            SubmitButton.Enabled = True
            SummaryButton.Enabled = True
            AnswerTextBox.Enabled = True
            InformationGroupBox.Enabled = False
            TestButton.Enabled = False
            AnswerTextBox.Focus()

            Dim randomType As Integer

            Number1stTextBox.Text = Str(Int((20 * Rnd()) + 0))
            Number2ndTextBox.Text = Str(Int((20 * Rnd()) + 0))
            randomType = CInt(Int((4 * Rnd()) + 0))


            If randomType = 1 Then
                AddRadioButton.Checked = True

            ElseIf randomType = 2 Then
                SubtractRadioButton.Checked = True

            ElseIf randomType = 3 Then
                MultiplyRadioButton.Checked = True

            Else
                DivideRadioButton.Checked = True

            End If

        End If

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Checks the answer of the student and sees if it's correct
        Dim studentAnswer As Integer
        Dim correctAnswer As Integer
        Dim numberOfAnswer As Integer
        Dim randomNumber1 As Integer
        Dim randomNumber2 As Integer
        Dim randomType As Integer

        AnswerTextBox.Focus()

        correctAnswer = CInt(CorrectTextBox.Text)
        numberOfAnswer = CInt(NumberTextBox.Text)
        randomNumber1 = CInt(Number1stTextBox.Text)
        randomNumber2 = CInt(Number2ndTextBox.Text)


        Try
            studentAnswer = CInt(AnswerTextBox.Text)

            If AddRadioButton.Checked = True Then

                If studentAnswer = randomNumber1 + randomNumber2 Then
                    CorrectTextBox.Text = Str(1 + correctAnswer)
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                Else
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                End If

            ElseIf SubtractRadioButton.Checked = True Then

                If studentAnswer = randomNumber1 - randomNumber2 Then
                    CorrectTextBox.Text = Str(1 + correctAnswer)
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                Else
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                End If

            ElseIf MultiplyRadioButton.Checked = True Then

                If studentAnswer = randomNumber1 * randomNumber2 Then
                    CorrectTextBox.Text = Str(1 + correctAnswer)
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                Else
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                End If

            Else

                If studentAnswer = CInt(randomNumber1 / randomNumber2) Then
                    CorrectTextBox.Text = Str(1 + correctAnswer)
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                Else
                    NumberTextBox.Text = Str(1 + numberOfAnswer)

                End If

            End If

            randomType = CInt(Int((4 * Rnd()) + 0))
            Number1stTextBox.Text = Str(Int((20 * Rnd()) + 0))
            Number2ndTextBox.Text = Str(Int((20 * Rnd()) + 0))

            If randomType = 1 Then
                AddRadioButton.Checked = True

            ElseIf randomType = 2 Then
                SubtractRadioButton.Checked = True

            ElseIf randomType = 3 Then
                MultiplyRadioButton.Checked = True

            Else
                DivideRadioButton.Checked = True

            End If

            AnswerTextBox.Text = ""
            AnswerTextBox.Focus()

        Catch ex As Exception
            MsgBox("Please enter a valid answer.")
            AnswerTextBox.Focus()

        End Try

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'Displays the performance of the student
        MsgBox(NameTextBox.Text & " got " & CorrectTextBox.Text & " answers out of possible " &
               NumberTextBox.Text)

        AnswerTextBox.Focus()

    End Sub

End Class

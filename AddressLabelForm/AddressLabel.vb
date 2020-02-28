Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET 0265
'Spring 2020
'Address Label Programm
'https//github.com/hunsmcka/MH-VS-S20
Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        Dim displayText As String

        displayText = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine &
            StreetNameTextBox.Text & vbNewLine & CityTextBox.Text & ", " &
            StateTextBox.Text & " " & ZipTextBox.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""

    End Sub
End Class

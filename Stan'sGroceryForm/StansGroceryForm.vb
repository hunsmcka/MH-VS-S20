Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET 0265
'Spring 2020
'Stan's Grocery
'https://github.com/hunsmcka/MH-VS-S20

Public Class StansGroceryForm
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub
End Class

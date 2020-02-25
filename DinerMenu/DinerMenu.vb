Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/hunsmcka/MH-VS-S20

Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~Fresh, Fresher, Freshest Fish~" & vbNewLine _
            & vbNewLine _
            & "Do you like fish? It's just fine at Freddy's diner" & vbNewLine _
            & "Freddy also has some fresher fish that's fresher and much finer" & vbNewLine _
            & "but his best fish is his freshest fish and Freddy says with pride" & vbNewLine _
            & "'The finest fish at Freddy's is my freshest fish, french-fried!'" & vbNewLine _
            & "SO... don't order the fresh or the fresher fish" & vbNewLine _
            & "at Finney's if you're wise, you'll say, 'fetch me the finest" & vbNewLine _
            & "french-fried freshest fish that Finney fries!'"
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~Soup of the Day~" & vbNewLine _
            & vbNewLine _
            & "Bisque de Crevettes" & vbNewLine _
            & "A traditional recipe from the Charente region of France"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "~Special Foster's Salad~" & vbNewLine _
            & vbNewLine _
            & "We begin with a sprig of the finest Austailian parsley hand" & vbNewLine _
            & "selected by our head chef's, wife's, best-friend's, sister-in-law." & vbNewLine _
            & "The premium parsley is plated on a bed of grilled to order" & vbNewLine _
            & "T-bone steak and fianlly garnished with an ice cold" & vbNewLine _
            & "can of Foster's Homemade Steak Sauce." & vbNewLine _
            & vbNewLine _
            & "~Desert options Include~" & vbNewLine _
            & vbNewLine _
            & "1 Cookie"
    End Sub

End Class
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
        DisplaySpecialLabel.Text = "~Fresh, Fresher, Freshest Fish~

            Do you like fish? It's just fine at Freddy's diner 
            Freddy also has some fresher fish that's fresher and much finer 
            but his best fish is his freshest fish and Freddy says with pride
            'The finest fish at Freddy's is my freshest fish, french-fried!'
            SO... don't order the fresh or the fresher fish
            at Finney's if you're wise, you'll say, 'fetch me the finest
            french-fried freshest fish that Finney fries!'"
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "               ~Soup of the Day~

                Bisque de Crevettes 
                A traditional recipe from the Charente region of France"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "           ~Special Foster's Salad~
            
            We begin with a sprig of the finest Austailian parsley hand
            selected by our head chef's, wife's, best-friend's, sister-in-law.
            The premium parsley is plated on a bed of grilled to order
            T-bone steak and fianlly garnished with an ice cold
            can of Foster's Homemade Steak Sauce.

            ~Desert options Include~

            1 Cookie"
    End Sub

End Class
Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Roll of The Dice Again
'https://github.com/hunsmcka/MH-VS-S20
Public Class RollDiceForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        Dim firstDice As Single
        Dim secondDice As Single
        Dim sumOfDice As Single
        Dim diceArray(10) As Integer
        Dim columnHeader As String
        Dim rollColumn As String

        columnHeader = ""
        rollColumn = ""

        For roll = 1 To 1000

            Randomize()
            firstDice = Int((6 * Rnd()) + 1)

            Randomize()
            secondDice = Int((6 * Rnd()) + 1)

            sumOfDice = firstDice + secondDice

            'Adds total rolls for each number
            If sumOfDice = 2 Then
                diceArray(0) += 1

            ElseIf sumOfDice = 3 Then
                diceArray(1) += 1

            ElseIf sumOfDice = 4 Then
                diceArray(2) += 1

            ElseIf sumOfDice = 5 Then
                diceArray(3) += 1

            ElseIf sumOfDice = 6 Then
                diceArray(4) += 1

            ElseIf sumOfDice = 7 Then
                diceArray(5) += 1

            ElseIf sumOfDice = 8 Then
                diceArray(6) += 1

            ElseIf sumOfDice = 9 Then
                diceArray(7) += 1

            ElseIf sumOfDice = 10 Then
                diceArray(8) += 1

            ElseIf sumOfDice = 11 Then
                diceArray(9) += 1

            Else
                diceArray(10) += 1
            End If
        Next

        For i = 2 To 12
            columnHeader &= CStr(i).PadLeft(4) & "|"
        Next

        'Display the header
        RollDiceListBox.Items.Add(Space(19) & "Roll of The Dice" & Space(19))
        RollDiceListBox.Items.Add(StrDup(55, "-"))
        RollDiceListBox.Items.Add(columnHeader)
        RollDiceListBox.Items.Add(StrDup(55, "-"))

        'Write the total rolls for each number
        For i = LBound(diceArray) To UBound(diceArray)
            rollColumn &= CStr(diceArray(i)).PadLeft(4) & "|"
        Next

        RollDiceListBox.Items.Add(rollColumn)
        RollDiceListBox.Items.Add(vbNewLine)

        RollDiceListBox.TopIndex = RollDiceListBox.Items.Count - 1

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollDiceListBox.Items.Clear()

    End Sub
End Class

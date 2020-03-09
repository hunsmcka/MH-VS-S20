Module RoleDice

    Sub Main()
        Dim firstDice As Integer
        Dim secondDice As Integer
        Dim sumOfDice As Integer
        Dim diceArray(1, 10) As Integer

        diceArray(0, 0) = 2
        diceArray(0, 1) = 3
        diceArray(0, 2) = 4
        diceArray(0, 3) = 5
        diceArray(0, 4) = 6
        diceArray(0, 5) = 7
        diceArray(0, 6) = 8
        diceArray(0, 7) = 9
        diceArray(0, 8) = 10
        diceArray(0, 9) = 11
        diceArray(0, 10) = 12

        firstDice = Int((6 * Rnd()) + 1)
        secondDice = Int((6 * Rnd()) + 1)
        sumOfDice = firstDice + secondDice

        For roll = 1 To 10
            If sumOfDice = 2 Then
                diceArray(1, 0) += 1
            ElseIf sumOfDice = 3 Then
                diceArray(1, 1) += 1
            ElseIf sumOfDice = 4 Then
                diceArray(1, 2) += 1
            ElseIf sumOfDice = 5 Then
                diceArray(1, 3) += 1
            ElseIf sumOfDice = 6 Then
                diceArray(1, 4) += 1
            ElseIf sumOfDice = 7 Then
                diceArray(1, 5) += 1
            ElseIf sumOfDice = 8 Then
                diceArray(1, 6) += 1
            ElseIf sumOfDice = 9 Then
                diceArray(1, 7) += 1
            ElseIf sumOfDice = 10 Then
                diceArray(1, 8) += 1
            ElseIf sumOfDice = 11 Then
                diceArray(1, 9) += 1
            Else
                diceArray(1, 10) += 1
            End If
        Next

    End Sub

End Module

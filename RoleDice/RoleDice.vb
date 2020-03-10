Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Roll Dice
'https://github.com/hunsmcka/MH-VS-S20
Module RoleDice

    Sub Main()
        Dim firstDice As Single
        Dim secondDice As Single
        Dim sumOfDice As Single
        Dim diceArray(10) As Integer
        Dim reRoll As String
        reRoll = "Y"

        Do While reRoll = "Y"
            'Reset Array to 0

            diceArray(0) = 0
            diceArray(1) = 0
            diceArray(2) = 0
            diceArray(3) = 0
            diceArray(4) = 0
            diceArray(5) = 0
            diceArray(6) = 0
            diceArray(7) = 0
            diceArray(8) = 0
            diceArray(9) = 0
            diceArray(10) = 0

            For roll = 1 To 1000
                Randomize()
                firstDice = Int((6 * Rnd()) + 1)
                Randomize()
                secondDice = Int((6 * Rnd()) + 1)
                sumOfDice = firstDice + secondDice


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


            Console.WriteLine("2,  3,  4,  5,  6,  7,  8,  9,  10,  11,  12")
            Console.WriteLine(diceArray(0) & ", " & diceArray(1) & ", " & diceArray(2) & ", " & diceArray(3) & ", " &
                              diceArray(4) & ", " & diceArray(5) & ", " & diceArray(6) & ", " & diceArray(7) & ", " &
                              diceArray(8) & ", " & diceArray(9) & ", " & diceArray(10))
            Console.WriteLine("Run again? Y/N")



            'Run Again Question
            reRoll = Console.ReadLine()

            If reRoll = "Y" Then

            Else

                Exit Sub

            End If
        Loop

    End Sub

End Module

Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/rosstimo/MH-VS-S20

Module BetterCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim mathChoice As String
        Dim inputNumber As Boolean
        Dim quitProgram As Boolean

        quitProgram = False

        Do While quitProgram = False
            inputNumber = True

            Do While inputNumber = True
                Console.Write("Choose a number: ")
            Loop
        Loop

    End Sub

End Module
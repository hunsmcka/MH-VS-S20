Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/hunsmcka/MH-VS-S20

Module BetterCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim firstInput As String
        Dim secondInput As String
        Dim mathChoice As String
        Dim inputNumber As Boolean
        Dim inputChoice As Boolean
        Dim quitProgram As Boolean

        quitProgram = False

        Do While quitProgram = False
            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")

            inputNumber = True

            Do While inputNumber = True
                Console.Write("Choose a number: ")
                firstInput = Console.ReadLine()

                Try
                    firstNumber = CInt(firstInput)
                    Console.WriteLine("You entered """ & firstNumber & """")
                    inputNumber = False
                Catch ex As Exception
                    If firstInput = "q" Or firstInput = "Q" Then
                        Console.WriteLine("You entered """ & firstInput & """")
                        quitProgram = True
                        inputNumber = False
                    Else
                        Console.WriteLine("You entered """ & firstInput & """, please enter a whole number.")
                        quitProgram = False
                        inputNumber = True
                    End If
                End Try

            Loop

            Do While inputNumber = False And quitProgram = False
                Console.Write("Choose a number: ")
                secondInput = Console.ReadLine()

                Try
                    secondNumber = CInt(secondInput)
                    Console.WriteLine("You entered """ & secondNumber & """")
                    inputNumber = True
                Catch ex As Exception
                    If secondInput = "q" Or secondInput = "Q" Then
                        Console.WriteLine("You entered """ & secondInput & """")
                        quitProgram = True
                        inputNumber = True
                    Else
                        Console.WriteLine("You entered """ & secondInput & """, please enter a whole number.")
                        quitProgram = False
                        inputNumber = False
                    End If

                End Try

            Loop

            inputChoice = False

            Do While inputChoice = False And quitProgram = False
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Mulitply")
                Console.WriteLine("4. Divide")

                mathChoice = Console.ReadLine()

                If mathChoice = "1" Then
                    Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)
                    inputChoice = True

                ElseIf mathChoice = "2" Then
                    Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)
                    inputChoice = True

                ElseIf mathChoice = "3" Then
                    Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)
                    inputChoice = True

                ElseIf mathChoice = "4" Then
                    Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)
                    inputChoice = True

                ElseIf mathChoice = "q" Or mathChoice = "Q" Then
                    Console.WriteLine("You entered """ & mathChoice & """")
                    quitProgram = True
                    inputChoice = True

                Else
                    Console.WriteLine("You entered """ & mathChoice & """")
                    inputChoice = False

                End If

            Loop

        Loop

        Console.WriteLine("Have a nice day")
        Console.WriteLine("Please enter to close this window")
        Console.ReadLine()

    End Sub

End Module
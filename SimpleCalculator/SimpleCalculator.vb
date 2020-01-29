Option Explicit On
Option Strict On
Option Compare Binary

'McKay Hunsaker
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/hunsmcka/MH-VS-S20

Module SimpleCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim mathAction As String
        Dim quitChoice As Boolean
        Dim promtUser As Boolean

        quitChoice = False

        Do While quitChoice = False
            promtUser = True

            Do While promtUser = True
                'prompt user for two numbers
                Console.WriteLine("Please enter a number and press enter.")
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promtUser = False
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number.")
                    promtUser = True
                Catch ex As Exception
                    Console.WriteLine("You broke my program.")
                    promtUser = True
                End Try
            Loop

            Do While promtUser = False
                Console.WriteLine("Please enter a second number and press enter.")
                Try
                    secondNumber = CInt(Console.ReadLine())
                    promtUser = True
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number.")
                    promtUser = False
                Catch ex As Exception
                    Console.WriteLine("You broke my program.")
                    promtUser = False
                End Try
            Loop

            'prompt user for operator type
            Console.WriteLine("Choose one of the following action:")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Multiply")

            mathAction = Console.ReadLine()

            'perform operation base on user's input 
            If mathAction = "1" Then
                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)

            ElseIf mathAction = "2" Then
                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)

            Else
                Console.WriteLine("I'm sorry, that option is invalid. Please try again.")

            End If

            'promp user if they want to run the program again or quit
            Console.WriteLine("Press Enter to run again. Press Q and Enter to run again.")

            If Console.ReadLine() = "Q" Then
                quitChoice = True
            Else
                quitChoice = False
                Console.Clear()
            End If

        Loop

        Console.WriteLine("Thank you have a nice day.")
        Console.ReadLine()

    End Sub

End Module
Option Explicit On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/hunsmcka/MH-VS-S20

Module SimpleCalculator

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String
        Dim mathAction As String

        'prompt user for two numbers
        Console.WriteLine("Please enter a number and press enter.")
        firstNumber = Console.ReadLine()

        Console.WriteLine("Please enter a second number and press enter.")
        secondNumber = Console.ReadLine()

        Try
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        Catch ex As Exception
            Console.WriteLine("Please enter a whole number.")
        End Try

        'prompt user for operator type
        Console.WriteLine("Choose one of the following action:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Multiply")

        mathAction = Console.ReadLine()

        'perform operation base on user's input
        If mathAction = "1" Then
            Console.WriteLine(firstNumber & "+" & secondNumber & "=" & CInt(firstNumber) + CInt(secondNumber))
        ElseIf mathAction = "2" Then
            Console.WriteLine(firstNumber & "*" & secondNumber & "=" & CInt(firstNumber) * CInt(secondNumber))
        Else
            Console.WriteLine("I'm sorry, that option is invalid. Please try again.")
        End If

        'display result prompt to end
        Console.ReadLine()

    End Sub

End Module
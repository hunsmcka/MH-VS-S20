Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String

        firstNumber = Console.ReadLine()
        secondNumber = Console.ReadLine()

        Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        Console.ReadLine()

    End Sub

End Module

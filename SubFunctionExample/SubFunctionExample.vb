Option Explicit On
Option Infer On
Option Compare Binary
Option Strict On
Module SubFunctionExample

    Sub Main()

        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'MySub(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'DoMath(7, 5, "Subtract")
        'Console.ReadLine()

        'For i = 1 To 80 Step 20
        ShowPattern(20, "McKay")
        'Next
        Console.ReadLine()

    End Sub

    Sub MySub(myNumber As Integer)
        'myNumber = myNumber + 2
        myNumber += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'myNumber = myNumber - 3
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

    Sub DoMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "Add" Then
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "Subtract" Then
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "Multiply" Then
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "Divide" Then
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)
    End Sub

    Sub ShowPattern(length As Integer, character As String)
        'Dim character As String
        Dim pattern As String
        Console.WriteLine(Len(character))
        'character = "*"
        pattern = ""
        For index = 1 To length
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next

    End Sub

End Module
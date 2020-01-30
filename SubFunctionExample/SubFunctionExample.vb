Option Explicit On
Option Infer On
Option Compare Binary
Option Strict On
Module SubFunctionExample

    Sub Main()
        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        MySub(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        myNumber = MyFunc(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
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

End Module
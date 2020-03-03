Module ArrayExample

    Sub Main()
        Dim myArray(3) As Integer

        myArray(1) = 5

        myArray = {1, 2, 3, 4}

        myArray(0) = 5

        AnotherArrayExample()

        Console.ReadLine()
    End Sub

    Sub AnotherArrayExample()
        'no element definition
        Dim infoArray() As String

        infoArray = Split("Hello,Goodbye,Pizza,Hungry,Ice Cream", ",")

        'For Each thingy In infoArray
        '    Console.WriteLine(thingy)
        '    infoArray.Contains(thingy)
        'Next

        For i = LBound(infoArray) To UBound(infoArray)
            Console.WriteLine("At" & Str(i) & " Value is: " & infoArray(i))
        Next

        Console.ReadLine()

    End Sub
End Module

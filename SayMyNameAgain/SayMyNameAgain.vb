Option Explicit On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Say My Name Again
'https://github.com/hunsmcka/MH-VS-S20


Module SayMyNameAgain

    Sub Main()

        Dim theName As String

        Console.WriteLine("Please tell me your name.")
        theName = Console.ReadLine()

        If theName = "Emily" Then
            Console.WriteLine("Hello " & theName & " how are you today?")
        ElseIf theName = "Joe" Then
            Console.WriteLine("Hello do you prefer Big Joe or Little Joe?")
        ElseIf theName = "McKay" Then
            Console.WriteLine("Do you not remember me? We spoke together on the phone. I told you I would find you!")
        Else
            Console.WriteLine("Get your filthy hands off my keyboard " & theName & " !")
        End If

        Console.ReadLine()

    End Sub

End Module
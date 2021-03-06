﻿Public Class ValidateUserData
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click

        Console.WriteLine(UserMessage(TextBox1.Text, "Please enter text in textbox 1.", False))


        'Dim userMessage As String

        ''IsEmpty()
        'userMessage = ""

        'If IsStringEmpty(TextBox3.Text) = True Then
        '    userMessage &= "Please enter text in textbox 3." & vbNewLine
        '    TextBox3.Select()
        'End If

        'If IsStringEmpty(TextBox2.Text) = True Then
        '    userMessage &= "Please enter text in textbox 2." & vbNewLine
        '    TextBox2.Select()
        'End If

        'If IsStringEmpty(TextBox1.Text) = True Then
        '    userMessage &= "Please enter text in textbox 1." & vbNewLine
        '    TextBox1.Select()
        'End If

        'If userMessage <> "" Then
        '    MsgBox(userMessage)
        'End If

    End Sub

    Function UserMessage(stringToTest As String, uniqueMessage As String, clearUserMessage As Boolean) As String
        Static runningMessage As String
        runningMessage = ""

        If clearUserMessage <> True Then
            runningMessage &= uniqueMessage & vbNewLine
        Else
            runningMessage = ""
        End If

        Return runningMessage
    End Function

    Sub IsEmpty()
        'Check each if empty and alert user
        Dim userMessage As String

        userMessage = ""

        'Another way to check a condition
        'Select Case ""
        'Case TextBox3.Text
        '        userMessage &= "Please enter text in textbox 3." & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= "Please enter text in textbox 2." & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= "Please enter text in textbox 1." & vbNewLine
        'End Select

        If TextBox3.Text = "" Then
            userMessage &= "Please enter text in textbox 3." & vbNewLine
            TextBox3.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage &= "Please enter text in textbox 2." & vbNewLine
            TextBox2.Select()
        End If

        If TextBox1.Text = "" Then
            userMessage &= "Please enter text in textbox 1." & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

    End Sub

    Function IsStringEmpty(stringToTest As String) As Boolean
        Dim status As Boolean
        If stringToTest = "" Then
            status = True
        Else
            status = False
        End If

        Return status
    End Function

    Public Function RunningTotal(currentValue As Integer, clearTotal As Boolean) As Integer
        'Accumulate running total of argument with clear total option
        Static total As Integer

        If clearTotal <> False Then
            total += currentValue
        Else
            total = 0
        End If

        Return total
    End Function

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim tempNumber As Integer
        Const VALUE As Integer = 5

        'For i = 1 To 10
        tempNumber = RunningTotal(VALUE, True)
        'Next
        Console.WriteLine(tempNumber)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RunningTotal(0, False)
    End Sub
End Class
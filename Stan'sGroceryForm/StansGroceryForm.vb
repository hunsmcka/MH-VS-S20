Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET 0265
'Spring 2020
'Stan's Grocery
'https://github.com/hunsmcka/MH-VS-S20

Public Class StansGroceryForm
    Private itemsTextFile As String = "C:\Users\mckay\source\repos\MH-VS-S20\Stan'sGroceryForm\GroceryItems.txt"
    Public itemInfo(2, 4) As String

    Sub ReadFileToArray()
        Dim numberAisle As Integer = 0

        Try
            FileOpen(1, itemsTextFile, OpenMode.Input)

            Do While Not EOF(1)
                Input(1, itemInfo(numberAisle, 0))
                Input(1, itemInfo(numberAisle, 1))
                Input(1, itemInfo(numberAisle, 2))
                Input(1, itemInfo(numberAisle, 3))
                Input(1, itemInfo(numberAisle, 4))
                numberAisle += 1

            Loop

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        Finally
            FileClose(1)

        End Try

        For i = 0 To 2
            For j = 0 To 4
                ItemComboBox.Items.Add(itemInfo(i, j))
                ItemListBox.Items.Add(itemInfo(i, j))
            Next
        Next

    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReadFileToArray()
    End Sub

    Sub SearchItem()
        Dim itemFound As Boolean
        itemFound = False
        Try

            For i = 0 To 2
                For j = 0 To 4
                    If itemInfo(i, j) = SearchTextBox.Text Then
                        MsgBox("You will find " & itemInfo(i, j) & " on asile " & (i + 1) & ", item number " & (j + 1))
                        itemFound = True
                    End If

                Next

            Next

        Catch ex As Exception
            MsgBox("Please enter a proper item.")

        End Try

        If itemFound = False Then
            MsgBox("We're sorry this item was not found. Please select a different item.")
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchTextBox.Text = "zzz" Then
            Me.Close()

        Else
            SearchItem()

        End If
    End Sub

    Private Sub ItemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemListBox.SelectedIndexChanged
        SearchTextBox.Text = ItemListBox.SelectedItem.ToString

    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged
        SearchTextBox.Text = ItemComboBox.SelectedItem.ToString

    End Sub

End Class

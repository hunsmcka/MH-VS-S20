﻿Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DataListBox
        FirstNameTextBox.Text = "Anakin"
        LastNameTextBox.Text = "Skywalker"
        Tester()
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        DataListBox.Items.Add(FirstNameTextBox.Text & " " & LastNameTextBox.Text)
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Dim index As Integer

        Me.Text = DataListBox.SelectedIndex.ToString
        index = InStr(DataListBox.SelectedItem.ToString, " ")

        FirstNameTextBox.Text = Trim(Strings.Left(DataListBox.SelectedItem.ToString, index))
        LastNameTextBox.Text = Trim(Strings.Mid(DataListBox.SelectedItem.ToString, index, Len(DataListBox.SelectedItem.ToString)))

    End Sub

    Sub Tester()
        Dim someNumber As Double
        someNumber = 10 * Math.Sin(Math.PI / 2)
        Console.WriteLine()
    End Sub
End Class

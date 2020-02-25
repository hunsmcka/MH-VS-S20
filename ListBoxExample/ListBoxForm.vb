Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DataListBox
        FirstNameTextBox.Text = "Anakin"
        LastNameTextBox.Text = "Skywalker"
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
        'TO DO add selected to first name and last name text box
        index = InStr(DataListBox.SelectedItem.ToString, " ")

        FirstNameTextBox.Text = Strings.Left(DataListBox.SelectedItem.ToString, index)
        'TODO Right don't work
        LastNameTextBox.Text = Strings.Right(DataListBox.SelectedItem.ToString, index)

    End Sub
End Class

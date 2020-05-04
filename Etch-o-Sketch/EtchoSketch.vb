Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET 0265
'Spring 2020
'https://github.com//hunsmcka/MH-VS-S20
Public Class EtchoSketchForm

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove

        Dim graph As Graphics
        Static oldX As Integer
        Static oldY As Integer
        Dim penColor As Color = ColorChange(False)
        Dim myPen As New Pen(penColor)

        graph = DrawingPictureBox.CreateGraphics

        If e.Button.ToString = "Left" Then
            'Draw line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)

        ElseIf e.Button.ToString = "Right" Then
            'Clear graph
            ClearGraphics()

        ElseIf e.Button.ToString = "Middle" Then
            'Open color dialog and change color to selected color
            myPen.Color = ColorChange(True)

        End If

        oldX = e.X
        oldY = e.Y

        myPen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes the program
        Me.Close()
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        'Get access to color dialog
        ColorChange(True)
    End Sub

    Function ColorChange(pickColor As Boolean) As Color
        Static newColor As Color

        If pickColor Then
            'Open color dialog and change color to what is selected
            ColorDialog1.ShowDialog()
            newColor = ColorDialog1.Color

        ElseIf newColor = Color.Empty Then
            'When program starts set color to black
            newColor = Color.Black

        End If

        Return newColor
    End Function

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        'Clear graph
        ClearGraphics()
    End Sub

    Sub ClearGraphics()
        'Clear picture box
        DrawingPictureBox.Refresh()
    End Sub

    Private Sub WaveformButton_Click(sender As Object, e As EventArgs) Handles WaveformButton.Click
        MsgBox("Unsupported Feature")
    End Sub
End Class

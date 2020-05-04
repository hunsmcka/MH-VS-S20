<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchoSketchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.WaveformButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(809, 358)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'WaveformButton
        '
        Me.WaveformButton.Location = New System.Drawing.Point(451, 399)
        Me.WaveformButton.Name = "WaveformButton"
        Me.WaveformButton.Size = New System.Drawing.Size(119, 32)
        Me.WaveformButton.TabIndex = 2
        Me.WaveformButton.Text = "&Draw Waveform"
        Me.WaveformButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(80, 399)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(119, 32)
        Me.EraseButton.TabIndex = 0
        Me.EraseButton.Text = "&Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(262, 399)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(119, 32)
        Me.ColorButton.TabIndex = 1
        Me.ColorButton.Text = "&Change Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(634, 399)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(119, 32)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EtchoSketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 463)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.WaveformButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "EtchoSketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-o-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents WaveformButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ColorButton As Button
    Friend WithEvents ExitButton As Button
End Class

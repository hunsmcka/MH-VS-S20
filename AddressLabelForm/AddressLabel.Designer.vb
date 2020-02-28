<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetNameLabel = New System.Windows.Forms.Label()
        Me.StreetNameTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabelButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(15, 59)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(293, 22)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(12, 39)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(76, 17)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(12, 89)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(76, 17)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(15, 109)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(293, 22)
        Me.LastNameTextBox.TabIndex = 2
        '
        'StreetNameLabel
        '
        Me.StreetNameLabel.AutoSize = True
        Me.StreetNameLabel.Location = New System.Drawing.Point(12, 139)
        Me.StreetNameLabel.Name = "StreetNameLabel"
        Me.StreetNameLabel.Size = New System.Drawing.Size(87, 17)
        Me.StreetNameLabel.TabIndex = 5
        Me.StreetNameLabel.Text = "Street Name"
        '
        'StreetNameTextBox
        '
        Me.StreetNameTextBox.Location = New System.Drawing.Point(15, 159)
        Me.StreetNameTextBox.Name = "StreetNameTextBox"
        Me.StreetNameTextBox.Size = New System.Drawing.Size(293, 22)
        Me.StreetNameTextBox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 189)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(31, 17)
        Me.CityLabel.TabIndex = 7
        Me.CityLabel.Text = "City"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(15, 209)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(293, 22)
        Me.CityTextBox.TabIndex = 6
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.StateLabel.Location = New System.Drawing.Point(12, 239)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 9
        Me.StateLabel.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(15, 259)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(112, 22)
        Me.StateTextBox.TabIndex = 8
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ZipLabel.Location = New System.Drawing.Point(12, 289)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(65, 17)
        Me.ZipLabel.TabIndex = 11
        Me.ZipLabel.Text = "Zip Code"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(15, 309)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(112, 22)
        Me.ZipTextBox.TabIndex = 10
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetNameLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(24, 30)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(328, 367)
        Me.InputGroupBox.TabIndex = 12
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'DisplayLabelButton
        '
        Me.DisplayLabelButton.Location = New System.Drawing.Point(33, 271)
        Me.DisplayLabelButton.Name = "DisplayLabelButton"
        Me.DisplayLabelButton.Size = New System.Drawing.Size(123, 79)
        Me.DisplayLabelButton.TabIndex = 13
        Me.DisplayLabelButton.Text = "&Display Label"
        Me.DisplayLabelButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(174, 271)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(123, 79)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(315, 271)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(123, 79)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Controls.Add(Me.ExitButton)
        Me.OutputGroupBox.Controls.Add(Me.ClearButton)
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabelButton)
        Me.OutputGroupBox.Location = New System.Drawing.Point(385, 30)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(476, 366)
        Me.OutputGroupBox.TabIndex = 16
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(10, 35)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 20)
        Me.DisplayLabel.TabIndex = 16
        '
        'AddressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 421)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "AddressLabelForm"
        Me.Text = "Address Label Viewer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetNameLabel As Label
    Friend WithEvents StreetNameTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents DisplayLabelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
End Class

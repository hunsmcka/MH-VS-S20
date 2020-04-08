<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningMileageLabel = New System.Windows.Forms.Label()
        Me.BeginningMileageTextBox = New System.Windows.Forms.TextBox()
        Me.EndingMileageLabel = New System.Windows.Forms.Label()
        Me.EndingMileageTextBox = New System.Windows.Forms.TextBox()
        Me.NumberofDaysLabel = New System.Windows.Forms.Label()
        Me.NumberofDaysTextBox = New System.Windows.Forms.TextBox()
        Me.MilesOrKilometersGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilometerRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCitizenCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAADiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.DistanceDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceDrivenLabel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MinusDiscountLabel = New System.Windows.Forms.Label()
        Me.MinusDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.YouOweLabel = New System.Windows.Forms.Label()
        Me.YouOweTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MilesOrKilometersGroupBox.SuspendLayout()
        Me.DiscountGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(224, 10)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(253, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(109, 17)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 50)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(60, 17)
        Me.AddressLabel.TabIndex = 3
        Me.AddressLabel.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(224, 45)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(253, 22)
        Me.AddressTextBox.TabIndex = 2
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 85)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(31, 17)
        Me.CityLabel.TabIndex = 5
        Me.CityLabel.Text = "City"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(224, 80)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(253, 22)
        Me.CityTextBox.TabIndex = 4
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(12, 120)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 7
        Me.StateLabel.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(224, 115)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(253, 22)
        Me.StateTextBox.TabIndex = 6
        '
        'BeginningMileageLabel
        '
        Me.BeginningMileageLabel.AutoSize = True
        Me.BeginningMileageLabel.Location = New System.Drawing.Point(12, 155)
        Me.BeginningMileageLabel.Name = "BeginningMileageLabel"
        Me.BeginningMileageLabel.Size = New System.Drawing.Size(195, 17)
        Me.BeginningMileageLabel.TabIndex = 9
        Me.BeginningMileageLabel.Text = "Beginning Odometer Reading"
        '
        'BeginningMileageTextBox
        '
        Me.BeginningMileageTextBox.Location = New System.Drawing.Point(224, 150)
        Me.BeginningMileageTextBox.Name = "BeginningMileageTextBox"
        Me.BeginningMileageTextBox.Size = New System.Drawing.Size(253, 22)
        Me.BeginningMileageTextBox.TabIndex = 8
        '
        'EndingMileageLabel
        '
        Me.EndingMileageLabel.AutoSize = True
        Me.EndingMileageLabel.Location = New System.Drawing.Point(12, 190)
        Me.EndingMileageLabel.Name = "EndingMileageLabel"
        Me.EndingMileageLabel.Size = New System.Drawing.Size(176, 17)
        Me.EndingMileageLabel.TabIndex = 11
        Me.EndingMileageLabel.Text = "Ending Odometer Reading"
        '
        'EndingMileageTextBox
        '
        Me.EndingMileageTextBox.Location = New System.Drawing.Point(224, 185)
        Me.EndingMileageTextBox.Name = "EndingMileageTextBox"
        Me.EndingMileageTextBox.Size = New System.Drawing.Size(253, 22)
        Me.EndingMileageTextBox.TabIndex = 10
        '
        'NumberofDaysLabel
        '
        Me.NumberofDaysLabel.AutoSize = True
        Me.NumberofDaysLabel.Location = New System.Drawing.Point(12, 225)
        Me.NumberofDaysLabel.Name = "NumberofDaysLabel"
        Me.NumberofDaysLabel.Size = New System.Drawing.Size(110, 17)
        Me.NumberofDaysLabel.TabIndex = 13
        Me.NumberofDaysLabel.Text = "Number of Days"
        '
        'NumberofDaysTextBox
        '
        Me.NumberofDaysTextBox.Location = New System.Drawing.Point(224, 220)
        Me.NumberofDaysTextBox.Name = "NumberofDaysTextBox"
        Me.NumberofDaysTextBox.Size = New System.Drawing.Size(253, 22)
        Me.NumberofDaysTextBox.TabIndex = 12
        '
        'MilesOrKilometersGroupBox
        '
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.KilometerRadioButton)
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MilesOrKilometersGroupBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.MilesOrKilometersGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesOrKilometersGroupBox.Location = New System.Drawing.Point(63, 287)
        Me.MilesOrKilometersGroupBox.Name = "MilesOrKilometersGroupBox"
        Me.MilesOrKilometersGroupBox.Size = New System.Drawing.Size(296, 130)
        Me.MilesOrKilometersGroupBox.TabIndex = 14
        Me.MilesOrKilometersGroupBox.TabStop = False
        Me.MilesOrKilometersGroupBox.Text = "Is Odometer In Miles Or Kilometers?"
        '
        'KilometerRadioButton
        '
        Me.KilometerRadioButton.AutoSize = True
        Me.KilometerRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KilometerRadioButton.Location = New System.Drawing.Point(6, 91)
        Me.KilometerRadioButton.Name = "KilometerRadioButton"
        Me.KilometerRadioButton.Size = New System.Drawing.Size(101, 24)
        Me.KilometerRadioButton.TabIndex = 16
        Me.KilometerRadioButton.TabStop = True
        Me.KilometerRadioButton.Text = "Kilometer"
        Me.KilometerRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesRadioButton.Location = New System.Drawing.Point(6, 57)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(70, 24)
        Me.MilesRadioButton.TabIndex = 15
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupBox
        '
        Me.DiscountGroupBox.Controls.Add(Me.SeniorCitizenCheckBox)
        Me.DiscountGroupBox.Controls.Add(Me.AAADiscountCheckBox)
        Me.DiscountGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountGroupBox.Location = New System.Drawing.Point(601, 287)
        Me.DiscountGroupBox.Name = "DiscountGroupBox"
        Me.DiscountGroupBox.Size = New System.Drawing.Size(237, 105)
        Me.DiscountGroupBox.TabIndex = 15
        Me.DiscountGroupBox.TabStop = False
        Me.DiscountGroupBox.Text = "Enter Any Discounts"
        '
        'SeniorCitizenCheckBox
        '
        Me.SeniorCitizenCheckBox.AutoSize = True
        Me.SeniorCitizenCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeniorCitizenCheckBox.Location = New System.Drawing.Point(13, 70)
        Me.SeniorCitizenCheckBox.Name = "SeniorCitizenCheckBox"
        Me.SeniorCitizenCheckBox.Size = New System.Drawing.Size(208, 24)
        Me.SeniorCitizenCheckBox.TabIndex = 17
        Me.SeniorCitizenCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCitizenCheckBox.UseVisualStyleBackColor = True
        '
        'AAADiscountCheckBox
        '
        Me.AAADiscountCheckBox.AutoSize = True
        Me.AAADiscountCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAADiscountCheckBox.Location = New System.Drawing.Point(13, 36)
        Me.AAADiscountCheckBox.Name = "AAADiscountCheckBox"
        Me.AAADiscountCheckBox.Size = New System.Drawing.Size(202, 24)
        Me.AAADiscountCheckBox.TabIndex = 16
        Me.AAADiscountCheckBox.Text = "AAA Member Discount"
        Me.AAADiscountCheckBox.UseVisualStyleBackColor = True
        '
        'DistanceDrivenTextBox
        '
        Me.DistanceDrivenTextBox.Enabled = False
        Me.DistanceDrivenTextBox.Location = New System.Drawing.Point(750, 10)
        Me.DistanceDrivenTextBox.Name = "DistanceDrivenTextBox"
        Me.DistanceDrivenTextBox.Size = New System.Drawing.Size(227, 22)
        Me.DistanceDrivenTextBox.TabIndex = 16
        '
        'DistanceDrivenLabel
        '
        Me.DistanceDrivenLabel.AutoSize = True
        Me.DistanceDrivenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceDrivenLabel.Location = New System.Drawing.Point(528, 12)
        Me.DistanceDrivenLabel.Name = "DistanceDrivenLabel"
        Me.DistanceDrivenLabel.Size = New System.Drawing.Size(193, 20)
        Me.DistanceDrivenLabel.TabIndex = 17
        Me.DistanceDrivenLabel.Text = "Distance Driven In Miles"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileageChargeLabel.Location = New System.Drawing.Point(528, 47)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(126, 20)
        Me.MileageChargeLabel.TabIndex = 19
        Me.MileageChargeLabel.Text = "Mileage Charge"
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Enabled = False
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(750, 45)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(227, 22)
        Me.MileageChargeTextBox.TabIndex = 18
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayChargeLabel.Location = New System.Drawing.Point(528, 82)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(98, 20)
        Me.DayChargeLabel.TabIndex = 21
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Enabled = False
        Me.DayChargeTextBox.Location = New System.Drawing.Point(750, 80)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(227, 22)
        Me.DayChargeTextBox.TabIndex = 20
        '
        'MinusDiscountLabel
        '
        Me.MinusDiscountLabel.AutoSize = True
        Me.MinusDiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinusDiscountLabel.Location = New System.Drawing.Point(528, 117)
        Me.MinusDiscountLabel.Name = "MinusDiscountLabel"
        Me.MinusDiscountLabel.Size = New System.Drawing.Size(126, 20)
        Me.MinusDiscountLabel.TabIndex = 23
        Me.MinusDiscountLabel.Text = "Minus Discount"
        '
        'MinusDiscountTextBox
        '
        Me.MinusDiscountTextBox.Enabled = False
        Me.MinusDiscountTextBox.Location = New System.Drawing.Point(750, 115)
        Me.MinusDiscountTextBox.Name = "MinusDiscountTextBox"
        Me.MinusDiscountTextBox.Size = New System.Drawing.Size(227, 22)
        Me.MinusDiscountTextBox.TabIndex = 22
        '
        'YouOweLabel
        '
        Me.YouOweLabel.AutoSize = True
        Me.YouOweLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YouOweLabel.Location = New System.Drawing.Point(528, 152)
        Me.YouOweLabel.Name = "YouOweLabel"
        Me.YouOweLabel.Size = New System.Drawing.Size(76, 20)
        Me.YouOweLabel.TabIndex = 25
        Me.YouOweLabel.Text = "You Owe"
        '
        'YouOweTextBox
        '
        Me.YouOweTextBox.Enabled = False
        Me.YouOweTextBox.Location = New System.Drawing.Point(750, 150)
        Me.YouOweTextBox.Name = "YouOweTextBox"
        Me.YouOweTextBox.Size = New System.Drawing.Size(227, 22)
        Me.YouOweTextBox.TabIndex = 24
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(232, 423)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(91, 23)
        Me.CalculateButton.TabIndex = 26
        Me.CalculateButton.Text = "C&alculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(352, 423)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(91, 23)
        Me.ClearButton.TabIndex = 27
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(472, 423)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(91, 23)
        Me.SummaryButton.TabIndex = 28
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(592, 423)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(91, 23)
        Me.ExitButton.TabIndex = 29
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CarRentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 475)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.YouOweLabel)
        Me.Controls.Add(Me.YouOweTextBox)
        Me.Controls.Add(Me.MinusDiscountLabel)
        Me.Controls.Add(Me.MinusDiscountTextBox)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.DistanceDrivenLabel)
        Me.Controls.Add(Me.DistanceDrivenTextBox)
        Me.Controls.Add(Me.DiscountGroupBox)
        Me.Controls.Add(Me.MilesOrKilometersGroupBox)
        Me.Controls.Add(Me.NumberofDaysLabel)
        Me.Controls.Add(Me.NumberofDaysTextBox)
        Me.Controls.Add(Me.EndingMileageLabel)
        Me.Controls.Add(Me.EndingMileageTextBox)
        Me.Controls.Add(Me.BeginningMileageLabel)
        Me.Controls.Add(Me.BeginningMileageTextBox)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Acme Car Rental Service"
        Me.MilesOrKilometersGroupBox.ResumeLayout(False)
        Me.MilesOrKilometersGroupBox.PerformLayout()
        Me.DiscountGroupBox.ResumeLayout(False)
        Me.DiscountGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents BeginningMileageLabel As Label
    Friend WithEvents BeginningMileageTextBox As TextBox
    Friend WithEvents EndingMileageLabel As Label
    Friend WithEvents EndingMileageTextBox As TextBox
    Friend WithEvents NumberofDaysLabel As Label
    Friend WithEvents NumberofDaysTextBox As TextBox
    Friend WithEvents MilesOrKilometersGroupBox As GroupBox
    Friend WithEvents KilometerRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents DiscountGroupBox As GroupBox
    Friend WithEvents SeniorCitizenCheckBox As CheckBox
    Friend WithEvents AAADiscountCheckBox As CheckBox
    Friend WithEvents DistanceDrivenTextBox As TextBox
    Friend WithEvents DistanceDrivenLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents MinusDiscountLabel As Label
    Friend WithEvents MinusDiscountTextBox As TextBox
    Friend WithEvents YouOweLabel As Label
    Friend WithEvents YouOweTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
End Class

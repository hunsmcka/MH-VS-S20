Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

'McKay Hunsaker
'RCET0265
'Spring 2020
'Car Rental
'https://github.com/hunsmcka/MH-VS-S20

Public Class CarRentalForm
    Private Sub CarRentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Sub ResetAll()
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        BeginningMileageTextBox.Text = ""
        EndingMileageTextBox.Text = ""
        NumberofDaysTextBox.Text = ""
        DistanceDrivenTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        MinusDiscountTextBox.Text = ""
        YouOweTextBox.Text = ""
        MilesRadioButton.Checked = True
        AAADiscountCheckBox.Checked = False
        SeniorCitizenCheckBox.Checked = False
        SummaryButton.Enabled = False
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim testValid As Boolean
        testValid = True

        'Validate the information if the information is correct then calculate the price
        If NameTextBox.Text = "" Then
            MsgBox("Please enter the customer's name.")
            NameTextBox.Focus()
            testValid = False
        ElseIf AddressTextBox.Text = "" Then
            MsgBox("Please enter the customer's address.")
            AddressTextBox.Focus()
            testValid = False
        ElseIf CityTextBox.Text = "" Then
            MsgBox("Please enter the city that the customer lives in.")
            CityTextBox.Focus()
            testValid = False
        ElseIf StateTextBox.Text = "" Then
            MsgBox("Please enter the state that the customer lives in.")
            StateTextBox.Focus()
            testValid = False
        ElseIf BeginningMileageTextBox.Text = "" Then
            MsgBox("Please enter the Beginning Odometer Reading.")
            BeginningMileageTextBox.Focus()
            testValid = False
        ElseIf EndingMileageTextBox.Text = "" Then
            MsgBox("Please enter the Ending Odometer Reading.")
            EndingMileageTextBox.Focus()
            testValid = False
        ElseIf NumberofDaysTextBox.Text = "" Then
            MsgBox("Please enter the Number of Days.")
            NumberofDaysTextBox.Focus()
            testValid = False
        Else
            Try
                If CDec(BeginningMileageTextBox.Text) > CDec(EndingMileageTextBox.Text) Then
                    MsgBox("The Beginning Odometer Reading has to be smaller than the Ending Odometer Reading.")
                    BeginningMileageTextBox.Text = ""
                    EndingMileageTextBox.Text = ""
                    BeginningMileageTextBox.Focus()
                    testValid = False
                Else
                    testValid = True
                End If
            Catch ex As Exception
                MsgBox("Please enter a number in the Odometer Reading.")
                BeginningMileageTextBox.Text = ""
                EndingMileageTextBox.Text = ""
                BeginningMileageTextBox.Focus()
                testValid = False
            End Try

            Try
                If CDec(NumberofDaysTextBox.Text) < 1 Then
                    MsgBox("Alert: The Number of Days must be greater than 0!")
                    NumberofDaysTextBox.Focus()
                    testValid = False
                ElseIf CDec(NumberofDaysTextBox.Text) > 45 Then
                    MsgBox("Alert: The Number of Days cannot be greater than 45.")
                    NumberofDaysTextBox.Focus()
                    testValid = False
                Else
                    testValid = True
                End If
            Catch ex As Exception
                MsgBox("Please enter a number in the Number of Days.")
                NumberofDaysTextBox.Text = ""
                NumberofDaysTextBox.Focus()
                testValid = False
            End Try
        End If

        Dim mileage As Decimal
        Dim dayCharge As Decimal
        Dim totalCharge As Decimal
        Dim totalDiscount As Decimal

        If testValid = True Then
            If MilesRadioButton.Checked = True Then
                mileage = CDec(EndingMileageTextBox.Text) - CDec(BeginningMileageTextBox.Text)
                SumMileage(mileage)
                DistanceDrivenTextBox.Text = Math.Round(mileage, 2).ToString
                MileageChargeTextBox.Text = "$" & Math.Round(MileageCharge(mileage), 2).ToString
                SumCharge(MileageCharge(mileage))
                SumCustomers(1)

                dayCharge = CDec(NumberofDaysTextBox.Text) * 15D
                DayChargeTextBox.Text = "$" & Math.Round(dayCharge, 2).ToString

                totalCharge = CDec(MileageChargeTextBox.Text) + CDec(DayChargeTextBox.Text)

                If SeniorCitizenCheckBox.Checked = True And AAADiscountCheckBox.Checked = True Then
                    totalDiscount = totalCharge * 0.08D
                ElseIf SeniorCitizenCheckBox.Checked = True And AAADiscountCheckBox.Checked = False Then
                    totalDiscount = totalCharge * 0.03D
                ElseIf SeniorCitizenCheckBox.Checked = False And AAADiscountCheckBox.Checked = True Then
                    totalDiscount = totalCharge * 0.05D
                Else
                    totalDiscount = 0.00D
                End If

                MinusDiscountTextBox.Text = "$" & Math.Round(totalDiscount, 2).ToString
                YouOweTextBox.Text = "$" & Math.Round((totalCharge - totalDiscount), 2).ToString

                SummaryButton.Enabled = True

            ElseIf KilometerRadioButton.Checked = True Then
                mileage = (CDec(EndingMileageTextBox.Text) - CDec(BeginningMileageTextBox.Text)) / 1.609D
                SumMileage(mileage)
                DistanceDrivenTextBox.Text = Math.Round(mileage, 2).ToString
                MileageChargeTextBox.Text = "$" & Math.Round(MileageCharge(mileage), 2).ToString
                SumCharge(MileageCharge(mileage))
                SumCustomers(1)


                dayCharge = CDec(NumberofDaysTextBox.Text) * 15D
                DayChargeTextBox.Text = "$" & Math.Round(dayCharge, 2).ToString

                totalCharge = CDec(MileageChargeTextBox.Text) + CDec(DayChargeTextBox.Text)

                If SeniorCitizenCheckBox.Checked = True And AAADiscountCheckBox.Checked = True Then
                    totalDiscount = totalCharge * 0.08D
                ElseIf SeniorCitizenCheckBox.Checked = True And AAADiscountCheckBox.Checked = False Then
                    totalDiscount = totalCharge * 0.03D
                ElseIf SeniorCitizenCheckBox.Checked = False And AAADiscountCheckBox.Checked = True Then
                    totalDiscount = totalCharge * 0.05D
                Else
                    totalDiscount = 0.00D
                End If

                MinusDiscountTextBox.Text = "$" & Math.Round(totalDiscount, 1).ToString
                YouOweTextBox.Text = "$" & Math.Round(totalCharge - totalDiscount, 1).ToString

                SummaryButton.Enabled = True
            Else
                MsgBox("Error, please select either Miles or Kilometers.")
            End If

        Else

        End If

    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        Dim mileCharge As Decimal

        Select Case miles
            Case <= 200
                mileCharge = miles * 0
            Case > 500
                mileCharge = (miles - 500) * 0.1D + 36
            Case Else
                mileCharge = (miles - 200) * 0.12D
        End Select

        Return mileCharge
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Push Exit Button to close the form
        Me.Close()
    End Sub

    Function SumMileage(ByRef mileage As Decimal) As Decimal
        Dim totalMiles As Decimal

        totalMiles += mileage

        Return totalMiles
    End Function

    Function SumCustomers(ByRef customer As Integer) As Integer
        Dim customers As Integer

        customers += customer

        Return customers
    End Function

    Function SumCharge(ByRef charge As Decimal) As Decimal
        Dim totalCost As Decimal

        totalCost += charge

        Return totalCost
    End Function

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show("Total Customers: " & Str(SumCustomers(0)) & vbNewLine &
               "Total Miles Driven: " & Math.Round(SumMileage(0)).ToString & " mi" & vbNewLine &
               "Total Charge: $" & Math.Round(SumCharge(0)).ToString, "Detailed Summary")
    End Sub
End Class

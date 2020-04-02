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
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        'Validate the information if the information is correct then calculate the price
        If NameTextBox.Text = "" Then
            MsgBox("Please enter the customer's name.")
            NameTextBox.Focus()
        ElseIf AddressTextBox.Text = "" Then
            MsgBox("Please enter the customer's address.")
            AddressTextBox.Focus()
        ElseIf CityTextBox.Text = "" Then
            MsgBox("Please enter the city that the customer lives in.")
            CityTextBox.Focus()
        ElseIf StateTextBox.Text = "" Then
            MsgBox("Please enter the state that the customer lives in.")
            StateTextBox.Focus()
        ElseIf BeginningMileageTextBox.Text = "" Then
            MsgBox("Please enter the Beginning Odometer Reading.")
            BeginningMileageTextBox.Focus()
        ElseIf EndingMileageTextBox.Text = "" Then
            MsgBox("Please enter the Ending Odometer Reading.")
            EndingMileageTextBox.Focus()
        ElseIf CDec(BeginningMileageTextBox.Text) > CDec(EndingMileageTextBox.Text) Then
            MsgBox("The Beginning Odometer Reading has to be smaller than the Ending Odometer Reading.")
            BeginningMileageTextBox.Text = ""
            EndingMileageTextBox.Text = ""
            BeginningMileageTextBox.Focus()
        ElseIf NumberofDaysTextBox.Text = "" Then
            MsgBox("Please enter the Number of Days.")
            NumberofDaysTextBox.Focus()
        Else

        End If
    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        Dim mileCharge As Decimal

        Select Case miles
            Case <= 200
                mileCharge = miles * 0
            Case > 500
                mileCharge = miles * 0.1D
            Case Else
                mileCharge = miles * 0.12D
        End Select

        Return mileCharge
    End Function

End Class

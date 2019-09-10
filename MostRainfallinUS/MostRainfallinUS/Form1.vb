' Program Name: Most Rainfall in US
' Author:       Sean Ervin
' Date:         September 6, 2019
' Purpose:      The Fitness Challenge program enteres the wieght loss
'               loss from team members For a fitness challenge. It displays Each
'               weight loss value. After all weight loss values have been entered,
'               it displays the average weight loss for the team.
Public Class frmRainfall
    Private Sub BtnRainfall_Click(sender As Object, e As EventArgs) Handles btnRainfall.Click
        ' The btnRainfall_Click event accepts and displays up to 12 rainfall values
        ' and then calculates and displays the average rainfall for all the states.

        ' Declare and itialize variables
        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalRainfall As Decimal = 0D
        Dim strInputMessage As String = "Enter the rainfall for state #"
        Dim strInputHeading As String = "Rainfall"
        Dim strNormalMessage As String = "Enter the rainfall for state #"
        Dim strNonNumericError As String = "Error - Enter a number for the rainfall for state #"
        Dim strNegativeError As String = "Error - Enter a positive number for the rainfall for state #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the weight loss of up to 8 team members.
        ' The loop terminates when the user has entered 8 weight loss vales or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = strCancelClicked
            If IsNumeric(strRainfall) Then
                decRainfall = Convert.ToDecimal(strRainfall)
                If decRainfall > 0 Then
                    lstRainfall.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Calculates and displays average team weight loss
        If intNumberOfEntries > 1 Then
            lblAverageRain.Visible = True
            decAverageLoss = decTotalRainfall / (intNumberOfEntries - 1)
            lblAverageRain.Text = "Average Rainfall per Month is " &
                decAverageLoss.ToString("F1") & " inches"
        Else
            MsgBox("No rainfall value entered")
        End If

        ' Disables the Weight Loss button
        btnRainfall.Enabled = False
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the ListBox object and hides
        ' the average weight loss label. It also enables the Weight Loss button

        lstRainfall.Items.Clear()
        lblAverageRain.Visible = False
        btnRainfall.Enabled = True
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class

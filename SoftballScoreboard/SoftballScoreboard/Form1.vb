' Program Name: Fitness Challenge
' Author:       Sean Ervin
' Date:         September 6, 2019
' Purpose:      Softball Scoreboard program enters the score for that inning
'               It displays Each weight loss value. After all inning score values 
'               have been entered, it displays the total score.
Public Class frmSoftballScoreboard
    Private Sub BtnInningScore_Click(sender As Object, e As EventArgs) Handles btnInningScore.Click
        ' The btnInningScore_Click event accepts and displays up to 7 inning score values
        ' and then calculates and displays the total inning score for the team.

        ' Declare and itialize variables
        Dim strInningScore As String
        Dim decInningScore As Decimal
        Dim intTotalInningScore As Integer = 0D
        Dim strInputMessage As String = "Enter score at the end of innning #"
        Dim strInputHeading As String = "Softball Inning Score"
        Dim strNormalMessage As String = "Enter score at the end of innning #"
        Dim strNonNumericError As String = "Error - Enter score at the end of innning #"
        Dim strNegativeError As String = "Error - Enter a positive score at the end of innning #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the weight loss of up to 8 team members.
        ' The loop terminates when the user has entered 7 inning socres vales or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strInningScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInningScore = strCancelClicked
            If IsNumeric(strInningScore) Then
                decInningScore = Convert.ToDecimal(strInningScore)
                If decInningScore > 0 Then
                    lstInningScore.Items.Add(decInningScore)
                    intTotalInningScore += decInningScore
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInningScore = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Displays total inning score
        If intNumberOfEntries > 1 Then
            lblAverageRain.Visible = True
            lblAverageRain.Text = "Total Inning Score " & Environment.NewLine & "is " &
                intTotalInningScore.ToString("F1")
        Else
            MsgBox("No InningScore value entered")
        End If

        ' Disables the Weight Loss button
        btnInningScore.Enabled = False
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the ListBox object and hides
        ' the total inning score label. It also enables the Enter Score button

        lstInningScore.Items.Clear()
        lblAverageRain.Visible = False
        btnInningScore.Enabled = True
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class

' Program Name: Factorial Calculator
' Author:       Sean Ervin
' Date:         September 10, 2019
' Purpose:      Get the factorial of a entered number, and all its previous numbers between 0 and 13.
Public Class frmFactorialCalc
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate_Click event handler calculates the factorial for the entered number
        ' and all previous numbers if the entered number is between 0 and 13.
        Dim intAmount As Integer

        ' Try catch any errors caused by there being nothing in the text box, or
        ' letters being in it.
        Try
            intAmount = Convert.ToInt32(txtNumber.Text)
        Catch
            ' Show an error if the text box is empty, or a letter.
            MessageBox.Show("You must enter a numerical value!")

            ' Clear everything and set the focus to txtNumber.
            lstFactorials.Items.Clear()
            txtNumber.Clear()
            txtNumber.Focus()

            ' Stop executing the rest of the method.
            Return
        End Try

        Dim intLastFactorial As Integer

        If intAmount > 0 And intAmount < 13 Then
            ' Iterate through all previous numbers calculate its factorial and 
            ' store its factorial for the next iteration.
            For i As Integer = 1 To intAmount
                Dim intFactorial As Integer = i * intLastFactorial

                ' If the current number is 1, then set the factorial to 1
                If i = 1 Then
                    intFactorial = 1
                End If
                intLastFactorial = intFactorial

                lstFactorials.Items.Add(i & "! " & intFactorial)
            Next
        Else
            ' Display the error
            MessageBox.Show("The number you enter must be GREATER than 0, and LESS than 13!")

            ' Clear everything and set the focus to txtNumber
            lstFactorials.Items.Clear()
            txtNumber.Clear()
            txtNumber.Focus()
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' The ClearToolStripMenuItem_Click event handler clears the list and 
        ' text box, then sets the textbox as the focus.
        lstFactorials.Items.Clear()
        txtNumber.Clear()
        txtNumber.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' The ClearToolStripMenuItem_Click event handler exits the window.

        Close()
    End Sub

    Private Sub FrmFactorialCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The FrmFactorialCalc_Load event handler sets the text box as focus.

        txtNumber.Focus()
    End Sub
End Class

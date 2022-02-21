'Name
'Details
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim a As Integer 'Declaring a as integer value
        a = Val(txtA.Text) 'Assigning a to textbox


        ' Compute only if passed value is positive and greater than 0

        If a > 0 Then

            ' variable for loop

            Dim powerCounter As Integer = 1

            ' clear previously stored values

            powerListBox.Items.Clear()

            ' display the heading in the ListBox

            powerListBox.Items.Add("n" + vbTab + "n^2" + vbTab + "n^3")

            Dim square As Integer = 1

            Dim cube As Integer = 1

            ' loop till all values are printed

            Do While powerCounter <= a

                square = powerCounter * powerCounter

                cube = powerCounter * powerCounter * powerCounter

                ' compute the powers and add to the ListBox

                powerListBox.Items.Add(powerCounter.ToString + vbTab + square.ToString + vbTab + cube.ToString)

                ' increment counter

                powerCounter += 1

            Loop

            ' if entered value is 0 or less than display an error message

        Else

            ' clear the content of ListBox

            powerListBox.Items.Clear()

            ' add an error message

            powerListBox.Items.Add("Enter a valid" & " number > 0")

        End If
    End Sub
End Class

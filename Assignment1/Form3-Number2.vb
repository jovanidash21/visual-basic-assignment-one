Public Class FormNumber2

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim firstname As String = FirstNameTextBox.Text 'First Name Of The User
        Dim lastname As String = LastNameTextBox.Text 'Last Name Of The User
        Dim studentnumber As String = StudentNumberTextBox.Text 'Student Number Of The User

        If firstname = "" Or lastname = "" Or studentnumber = "" Then
            MessageBox.Show("Please Fill Out The Form!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Displays Error Message Box If The User Submit An Atleast One Blank TextBox 
        Else
            MessageBox.Show("Hello " + firstname + " " + lastname & vbNewLine & "Your Student Number is " + studentnumber,
                "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None)
            'Displays Greetings Message Box If The User Submit All The TexBox With A Value
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close() 'Closes this form
        FormAssignment1.Show() 'Shows Form For Home
    End Sub

End Class
Public Class FormNumber2

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim firstname As String = FirstNameTextBox.Text
        Dim lastname As String = LastNameTextBox.Text
        Dim studentnumber As String = StudentNumberTextBox.Text

        If firstname = "" Or lastname = "" Or studentnumber = "" Then
            MessageBox.Show("Please Fill Out The Form!",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Hello " + firstname + " " + lastname & vbNewLine & "Your Student Number is " + studentnumber,
                "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        FormAssignment1.Show()
    End Sub

End Class
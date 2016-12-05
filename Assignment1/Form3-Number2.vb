Public Class FormNumber2

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim firstname As String
        Dim lastname As String
        Dim studentnumber As String

        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or StudentNumberTextBox.Text = "" Then
            MessageBox.Show("Please Fill Out The Form",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Hello " + FirstNameTextBox.Text + " " + LastNameTextBox.Text & vbNewLine & "Your Student Number is " + StudentNumberTextBox.Text,
                "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        FormAssignment1.Show()
    End Sub

End Class
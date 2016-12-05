Public Class FormNumber2

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        MessageBox.Show("Hello " + FirstNameTextBox.Text + " " + LastNameTextBox.Text & vbNewLine & "Your Student Number is " + StudentNumberTextBox.Text, "Greetings!",
            MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        FormAssignment1.Show()
    End Sub

End Class
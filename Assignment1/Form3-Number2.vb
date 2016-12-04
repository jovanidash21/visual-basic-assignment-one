Public Class FormNumber2

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Me.Hide()
        FormNumber2point1.Show()
        FormNumber2point1.FirstNameValue.Text = FirstNameTextBox.Text
        FormNumber2point1.LastNameValue.Text = LastNameTextBox.Text
        FormNumber2point1.StudentNumberValue.Text = StudentNumberTextBox.Text
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        FormAssignment1.Show()
    End Sub

End Class
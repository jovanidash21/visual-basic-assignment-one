Public Class FormNumber1

    Private Sub FormNumber1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SumTextBox.Text = "0"
        DifferenceTextBox.Text = "0"
        ProductTextBox.Text = "0"
        QuotientTextBox.Text = "0"

    End Sub

    Private Sub FirstNumberTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FirstNumberTextBox.KeyPress
        If FirstNumberTextBox.Text.Length > 11 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SecondNumberTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SecondNumberTextBox.KeyPress
        If SecondNumberTextBox.Text.Length > 11 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim firstnumber As Double = Val(FirstNumberTextBox.Text)
        Dim secondnumber As Double = Val(SecondNumberTextBox.Text)

        SumTextBox.Text = Format(firstnumber + secondnumber, "0.000")
        DifferenceTextBox.Text = Format(firstnumber - secondnumber, "0.000")
        ProductTextBox.Text = Format(firstnumber * secondnumber, "0.000")
        QuotientTextBox.Text = Format(firstnumber / secondnumber, "0.000")
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        FormAssignment1.Show()
    End Sub

End Class
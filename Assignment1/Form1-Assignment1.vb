﻿Public Class FormAssignment1

    Private Sub Number1_Click(sender As Object, e As EventArgs) Handles Number1.Click
        Me.Hide() 'Hides this form
        FormNumber1.Show() 'Shows Form For Item Number 1
    End Sub

    Private Sub Number2_Click(sender As Object, e As EventArgs) Handles Number2.Click
        Me.Hide() 'Hides this form
        FormNumber2.Show() 'Shows Form For Item Number 2
    End Sub

End Class

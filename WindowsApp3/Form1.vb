Public Class Form1
    Private Sub lblSettings_Click(sender As Object, e As EventArgs)
        dlgColor.Color = Panel1.BackColor
        Dim ans As DialogResult
        ans = dlgColor.ShowDialog
        If ans = DialogResult.OK Then
            Panel1.BackColor = dlgColor.Color

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form2.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class

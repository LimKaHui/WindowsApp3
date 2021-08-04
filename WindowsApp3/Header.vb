Public Class Header
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Header_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(Panel2, Form4)
        Panel2.Visible = True
    End Sub

    Friend Sub SwitchPanel(ByVal pnlName As Panel, ByVal panel As Form)
        With pnlName
            .Controls.Clear()
            panel.TopLevel = False
            .Controls.Add(panel)
            panel.Show()
        End With

    End Sub
End Class
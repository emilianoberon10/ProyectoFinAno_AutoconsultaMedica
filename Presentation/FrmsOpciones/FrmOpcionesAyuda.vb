Public Class FrmOpcionesAyuda
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If panel_cons.Visible = True Then
            panel_cons.Visible = False
            Guna2Button1.Image = My.Resources.right_arrow
        Else
            panel_cons.Visible = True
            Guna2Button1.Image = My.Resources.arrow_down_sign_to_navigate
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If panel_cons.Visible = True Then
            panel_cons.Visible = False
            Guna2Button1.Image = My.Resources.right_arrow
        Else
            panel_cons.Visible = True
            Guna2Button1.Image = My.Resources.arrow_down_sign_to_navigate
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If panel_cons.Visible = True Then
            panel_cons.Visible = False
            Guna2Button1.Image = My.Resources.right_arrow
        Else
            panel_cons.Visible = True
            Guna2Button1.Image = My.Resources.arrow_down_sign_to_navigate
        End If
    End Sub
End Class
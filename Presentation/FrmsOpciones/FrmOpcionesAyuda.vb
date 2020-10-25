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

End Class
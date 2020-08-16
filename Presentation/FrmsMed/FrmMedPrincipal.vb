Public Class FrmMedPrincipal

    Private Sub FrmMedPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        OpenChildForm(New FrmSolicitudesChat, panelChildMedico)
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
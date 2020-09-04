Public Class FrmMedPrincipal

    Private Sub FrmMedPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNombre.Text = FrmLogIn.medic._pNom
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        OpenChildForm(New FrmSolicitudesChat, panelChildMedico)
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        Dim form As New FrmChats
        form.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro que desa cerrar sesion?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

End Class
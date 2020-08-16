Public Class FrmPrincipalGerente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        OpenChildForm(New FrmIngresarGerente, PanelChildForm)
    End Sub

    Private Sub btnIngresarMedico_Click(sender As Object, e As EventArgs) Handles btnIngresarMedico.Click
        OpenChildForm(New FrmMedicoGerente, PanelChildForm)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        OpenChildForm(New FrmModificarGerente, PanelChildForm)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        OpenChildForm(New FrmEliminarGerente, PanelChildForm)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

    End Sub

End Class
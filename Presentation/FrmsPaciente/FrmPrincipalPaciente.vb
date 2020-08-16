Public Class FrmPrincipalPaciente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New FrmConsultaPaciente, PanelChildFormPac)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        'cierro totalmente la app
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAgendaMedica_Click(sender As Object, e As EventArgs) Handles btnAgendaMedica.Click
        OpenChildForm(New FrmAgendaMedica, PanelChildFormPac)

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        OpenChildForm(New FrmHistorial, PanelChildFormPac)

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        OpenChildForm(New FrmConsultaPaciente, PanelChildFormPac)
    End Sub

End Class
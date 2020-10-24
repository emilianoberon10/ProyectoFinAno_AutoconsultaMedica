Public Class FrmHistorial

    Private Sub FrmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticos
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(helpPanel)
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btn_Filtrar.Click
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticosFecha(DateTimePicker1.Text)
    End Sub

    Private Sub btnEntre_Click(sender As Object, e As EventArgs) Handles btn_Entre.Click
        DgvHistorial.DataSource = FrmLogIn.paci.VerDiagnosticosEntreFecha(DateTimePicker1.Text, DateTimePicker2.Text)

    End Sub

    Private Sub switch_CheckedChanged(sender As Object, e As EventArgs) Handles switch.CheckedChanged
        If switch.Checked Then
            btn_Entre.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            btn_Entre.Enabled = False
            DateTimePicker2.Enabled = False
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If helpPanel.Visible = True Then
            helpPanel.Visible = False
        Else
            helpPanel.Visible = True
        End If
    End Sub
End Class
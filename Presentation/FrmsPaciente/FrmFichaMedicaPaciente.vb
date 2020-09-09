Imports Logic

Public Class FrmFichaMedicaPaciente

    Private Sub btnConsul_Paint(sender As Object, e As PaintEventArgs) Handles btnAceptar.Paint
        BotonRedondeado(btnAceptar)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtProcedencia.Text = "" Or txtOcupacion.Text = "" Or txtMotivoConsulta.Text = "" Then
            ErrorProvider1.SetError(lbMotiv, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(lbOcup, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(lbProc, "Los campos con ( * ) son obligatorios.")
        Else
            Dim ficha As New FichaMedica(FrmLogIn.paci._ci, txtProcedencia.Text,
                                     txtOcupacion.Text, txtMedicina.Text, txtMotivoConsulta.Text,
            txtAntecedentes.Text)
            If ficha.GuardarFicha() Then
                Me.Close()
            Else
                MsgBox("ERROR AL GUARDAR LA FICHA, por favor reintente.")
            End If
        End If
    End Sub

    Private Sub ckbMedicina_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMedicina.CheckedChanged
        If ckbMedicina.Checked Then
            txtMedicina.Enabled = True
        Else
            txtMedicina.Enabled = False
        End If
    End Sub

    Private Sub chbAntecedentes_CheckedChanged(sender As Object, e As EventArgs) Handles chbAntecedentes.CheckedChanged
        If chbAntecedentes.Checked Then
            txtAntecedentes.Enabled = True
        Else
            txtAntecedentes.Enabled = False
        End If
    End Sub

End Class
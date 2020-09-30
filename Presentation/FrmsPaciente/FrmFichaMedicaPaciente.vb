Imports Logic

Public Class FrmFichaMedicaPaciente
    Dim ficha As FichaMedica

    Private Sub btnConsul_Paint(sender As Object, e As PaintEventArgs)
        'ficha = New FichaMedica(FrmLogIn.paci._ci)
        'Dim dt As New DataGridView With {
        '    .DataSource = ficha.GetFicha()
        '}

        'txtProcedencia.Text = dt.Rows(0).Cells(0).Value

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtProcedencia.Text = "" Or txtOcupacion.Text = "" Or txtMotivoConsulta.Text = "" Then
            ErrorProvider1.SetError(lbMotiv, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(lbOcup, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(lbProc, "Los campos con ( * ) son obligatorios.")
        Else
            ficha = New FichaMedica(FrmLogIn.paci._ci, txtProcedencia.Text,
                                     txtOcupacion.Text, txtMedicina.Text, txtMotivoConsulta.Text, txtAntecedentes.Text)
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

    Private Sub txtMedicina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProcedencia.KeyPress, txtOcupacion.KeyPress, txtMotivoConsulta.KeyPress, txtMedicina.KeyPress, txtAntecedentes.KeyPress
        DesecharCaracteresEspeciales(e)
    End Sub

End Class
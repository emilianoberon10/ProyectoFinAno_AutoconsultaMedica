Imports Logic

Public Class FrmMedicoGerente

    Private Sub FrmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If txtCedula.Text = "" Or txtEspecialidad.Text = "" Or txtLugarTrabajo.Text = "" Or txtPNom.Text = "" Or txtPApe.Text = "" Or txtSnom.Text = "" Or txtSape.Text = "" Or Integer.Parse(txtTelefono.Text) = 0 Or txtDomicilio.Text = "" Or cbSexo.Text = "Sexo" Then

            MsgBox("Todos los campos son obligatorios")
        Else
            Dim medico As New Medico(txtCedula.Text, Integer.Parse(txtTelefono.Text), txtEdad.Text,
                                     txtDomicilio.Text, cbSexo.Text, txtPNom.Text, txtPApe.Text, txtSnom.Text,
                                     txtSape.Text, txtEspecialidad.Text, txtLugarTrabajo.Text, txtCedula.Text)
            If medico.Guardar() Then
                MsgBox("Ya existe un medico con esa cedula")
            Else
                If chkLun.Checked Then medico._horario = txtHoraEntradaLunes.Text & " a " & txtHoraSalidaLunes.Text And medico.SetHorario("lun")
                If chkMar.Checked Then medico._horario = txtHoraEntradaMartes.Text & " a " & txtHoraSalidaMartes.Text And medico.SetHorario("mar")
                If chkMier.Checked Then medico._horario = txtHoraEntradaMiercoles.Text & " a " & txtHoraSalidaMiercoles.Text And medico.SetHorario("mie")
                If chkJuev.Checked Then medico._horario = txtHoraEntradaJueves.Text & " a " & txtHoraSalidaJueves.Text And medico.SetHorario("jue")
                If chkVier.Checked Then medico._horario = txtHoraEntradaViernes.Text & " a " & txtHoraSalidaViernes.Text And medico.SetHorario("vie")
                If chkSab.Checked Then medico._horario = txtHoraEntradaSabado.Text & " a " & txtHoraSalidaSabado.Text And medico.SetHorario("sab")
                If chkDom.Checked Then medico._horario = txtHoraEntradaDomingo.Text & " a " & txtHoraSalidaDomingo.Text And medico.SetHorario("dom")

                MsgBox("Se ingreso con exito")

            End If
        End If

    End Sub

    Private Sub FrmMedico_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        BotonRedondeado(btnIngresar)
    End Sub

End Class
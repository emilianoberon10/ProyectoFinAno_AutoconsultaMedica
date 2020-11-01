Imports Logic

Public Class FrmMedicoGerente
	Dim medico As Medico

	Private Sub FrmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarComboBoxEspec(cbEsp)
		Traductor.traducirForm(Me)
		Traductor.traducirPanel(Panel1)
	End Sub

	Private Function ComprobarDatos() As Boolean
		If (txtCedula.Text IsNot "" Or txtLugarTrabajo.Text IsNot "" Or txtPNom.Text IsNot "" Or txtPApe.Text IsNot "" Or txtSape.Text IsNot "" Or txtTelefono.Text IsNot "" Or txtDomicilio.Text IsNot "" Or cbSexo.Text IsNot "" Or
		   txtNumMed.Text IsNot "") Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

		If ComprobarDatos() Then

			ErrorProvider1.SetError(Persona_ci, "Todos los campos son obligatorios")
			General.GetForm(Estado.Error, "Todos los campos son obligatorios")
		Else
			If MessageBox.Show("Marco los checbox arriba de los horarios de trabajo?", "Advertencia",
		 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				medico = New Medico()
				With medico
					._ci = txtCedula.Text
					._contraseña = EncriptarContraseña(txtCedula.Text)
					._edad = Integer.Parse(txtEdad.Text)
					._sexo = cbSexo.Text
					._pNom = txtPNom.Text
					._pApe = txtPApe.Text
					._sNom = txtSnom.Text
					._sApe = txtSape.Text
					._domicilio = txtDomicilio.Text
					._tel_cel = Integer.Parse(txtTelefono.Text)
					._numMed = txtNumMed.Text
					._especialidad = cbEsp.Text
					._lugarTrabajo = txtLugarTrabajo.Text
				End With
				Try
					If medico.Guardar() Then
						General.GetForm(Estado.Error, "Ya existe un medico con esa cedula")
					Else

#Region "comprobar y guardar horarios"

						If chkLun.Checked AndAlso txtHoraEntradaLunes.Text IsNot "" Then
							If txtHoraEntradaLunes.Text.Length <= 30 Then
								medico._horario = txtHoraEntradaLunes.Text
								medico.SetHorario("lun")
							End If
						End If
						If chkMar.Checked AndAlso txtHoraEntradaMartes.Text IsNot "" Then
							medico._horario = txtHoraEntradaMartes.Text
							medico.SetHorario("mar")
						End If
						If chkMier.Checked AndAlso txtHoraEntradaMiercoles.Text IsNot "" Then
							medico._horario = txtHoraEntradaMiercoles.Text
							medico.SetHorario("mie")
						End If
						If chkJuev.Checked AndAlso txtHoraEntradaJueves.Text IsNot "" Then
							medico._horario = txtHoraEntradaJueves.Text
							medico.SetHorario("jue")
						End If
						If chkVier.Checked AndAlso txtHoraEntradaViernes.Text IsNot "" Then
							medico._horario = txtHoraEntradaViernes.Text
							medico.SetHorario("vie")
						End If
						If chkSab.Checked AndAlso txtHoraEntradaSabado.Text IsNot "" Then
							medico._horario = txtHoraEntradaSabado.Text
							medico.SetHorario("sab")
						End If
						If chkDom.Checked AndAlso txtHoraEntradaDomingo.Text IsNot "" Then
							medico._horario = txtHoraEntradaDomingo.Text
							medico.SetHorario("dom")
						End If

#End Region

						General.GetForm(Estado.Ok, "Se ingreso con exito")
						txtCedula.Text = ""
						cbEsp.Text = ""
						txtLugarTrabajo.Text = ""
						txtPNom.Text = ""
						txtPApe.Text = ""
						txtSnom.Text = ""
						txtSape.Text = ""
						txtTelefono.Text = ""
						txtDomicilio.Text = ""
						cbSexo.Text = ""
						txtNumMed.Text = ""
						txtHoraEntradaLunes.Text = ""
						txtHoraEntradaMartes.Text = ""
						txtHoraEntradaMiercoles.Text = ""
						txtHoraEntradaJueves.Text = ""
						txtHoraEntradaViernes.Text = ""
						txtHoraEntradaSabado.Text = ""
						txtHoraEntradaDomingo.Text = ""
						chkLun.Checked = False
						chkMar.Checked = False
						chkMier.Checked = False
						chkJuev.Checked = False
						chkVier.Checked = False
						chkSab.Checked = False
						chkDom.Checked = False
					End If
				Catch ex As Exception
					ErrorProvider1.SetError(ingreMed, ex.Message)
					General.GetForm(Estado.Error, ex.Message)
				End Try

			End If
		End If

	End Sub

#Region "check horarios"

	Private Sub chkLun_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaLunes.Enabled = True
	End Sub

	Private Sub chkMar_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaMartes.Enabled = True
	End Sub

	Private Sub chkMier_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaMiercoles.Enabled = True
	End Sub

	Private Sub chkJuev_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaJueves.Enabled = True
	End Sub

	Private Sub chkVier_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaViernes.Enabled = True
	End Sub

	Private Sub chkSab_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaSabado.Enabled = True
	End Sub

	Private Sub chkDom_CheckedChanged(sender As Object, e As EventArgs)
		txtHoraEntradaDomingo.Enabled = True
	End Sub

#End Region

	Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress, txtNumMed.KeyPress
		e.Handled = Not Char.IsDigit(e.KeyChar)
		If Asc(e.KeyChar) = 8 Then
			e.Handled = Char.IsDigit(e.KeyChar)
		End If
	End Sub

	Private Sub txtHoraEntradaLunes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraEntradaViernes.KeyPress, txtHoraEntradaSabado.KeyPress, txtHoraEntradaMiercoles.KeyPress, txtHoraEntradaMartes.KeyPress, txtHoraEntradaLunes.KeyPress, txtHoraEntradaJueves.KeyPress, txtHoraEntradaDomingo.KeyPress

		e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "a" Or e.KeyChar = ":")
		If e.KeyChar = ":" And sender.Text.IndexOf(":") > 2 OrElse e.KeyChar = "a" And sender.Text.IndexOf("a") > 1 Then
			e.Handled = True
		End If

		If Asc(e.KeyChar) = 8 Or e.KeyChar = " " Then
			e.Handled = Char.IsDigit(e.KeyChar)
		End If
	End Sub

	Private Sub txts_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress, txtSnom.KeyPress, txtSape.KeyPress, txtPNom.KeyPress, txtPApe.KeyPress, txtNumMed.KeyPress, txtLugarTrabajo.KeyPress, txtEdad.KeyPress, txtDomicilio.KeyPress, txtNumMed.KeyPress

		DesecharCaracteresEspeciales(e)
		txtCedula.MaxLength = 8
		txtNumMed.MaxLength = 4
		txtEdad.MaxLength = 3
		txtTelefono.MaxLength = 9
		txtPNom.MaxLength = 30
		txtPApe.MaxLength = 30
		txtSnom.MaxLength = 30
		txtSape.MaxLength = 30
		txtLugarTrabajo.MaxLength = 30
		txtDomicilio.MaxLength = 255
	End Sub

End Class
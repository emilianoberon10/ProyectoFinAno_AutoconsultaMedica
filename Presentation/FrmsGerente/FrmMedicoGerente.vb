Imports Logic

Public Class FrmMedicoGerente
    Dim medico As Medico

    Private Sub FrmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboBoxEspec(cbEsp)
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(Panel1)
    End Sub

    Private Function ComprobarDatos() As Boolean
        If txtCedula.Text = "" Or cbEsp.Text = "" Or txtLugarTrabajo.Text = "" Or
           txtPNom.Text = "" Or txtPApe.Text = "" Or txtSnom.Text = "" Or txtSape.Text = "" Or
           Integer.Parse(txtTelefono.Text) = 0 Or txtDomicilio.Text = "" Or cbSexo.Text = "" Or txtNumMed.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        If ComprobarDatos() Then

            ErrorProvider1.SetError(ingreMed, "Todos los campos son obligatorios")
            General.GetForm(Estado.Error, "Todos los campos son obligatorios")
        Else
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
                        If txtHoraEntradaLunes.Text.Length <= 30 Then medico._horario = txtHoraEntradaLunes.Text And medico.SetHorario("lun")
                    End If
                    If chkMar.Checked AndAlso txtHoraEntradaMartes.Text IsNot "" Then
                        medico._horario = txtHoraEntradaMartes.Text And medico.SetHorario("mar")
                    End If
                    If chkMier.Checked AndAlso txtHoraEntradaMiercoles.Text IsNot "" Then
                        medico._horario = txtHoraEntradaMiercoles.Text And medico.SetHorario("mie")
                    End If
                    If chkJuev.Checked AndAlso txtHoraEntradaJueves.Text IsNot "" Then
                        medico._horario = txtHoraEntradaJueves.Text And medico.SetHorario("jue")
                    End If
                    If chkVier.Checked AndAlso txtHoraEntradaViernes.Text IsNot "" Then
                        medico._horario = txtHoraEntradaViernes.Text And medico.SetHorario("vie")
                    End If
                    If chkSab.Checked AndAlso txtHoraEntradaSabado.Text IsNot "" Then
                        medico._horario = txtHoraEntradaSabado.Text And medico.SetHorario("sab")
                    End If
                    If chkDom.Checked AndAlso txtHoraEntradaDomingo.Text IsNot "" Then
                        medico._horario = txtHoraEntradaDomingo.Text And medico.SetHorario("dom")
                    End If

#End Region

                    General.GetForm(Estado.Ok, "Se ingreso con exito")

                End If
            Catch ex As Exception
                ErrorProvider1.SetError(ingreMed, ex.Message)
                General.GetForm(Estado.Error, ex.Message)
            End Try

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

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress
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

    Private Sub txts_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress, txtSnom.KeyPress, txtSape.KeyPress, txtPNom.KeyPress, txtPApe.KeyPress, txtNumMed.KeyPress, txtLugarTrabajo.KeyPress, txtEdad.KeyPress, txtDomicilio.KeyPress
        DesecharCaracteresEspeciales(e)
    End Sub


End Class
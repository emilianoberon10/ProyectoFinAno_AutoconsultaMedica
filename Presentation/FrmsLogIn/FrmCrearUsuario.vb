Imports Logic

Public Class FrmCrearUsuario

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If ComprobarCamposUsuario() Then
            ErrorProvider1.SetError(Label1, "TODOS LOS CAMPOS SON OBLIGATORIOS!!")
            General.GetForm(Estado.Error, "Todos los campos son obligatorios!!")
        Else
            Try
                Dim paciente As New Paciente()
                With paciente
                    ._ci = txtCedula.Text
                    ._mail = txtCorreo.Text
                    ._contraseña = EncriptarContraseña(txtCedula.Text)
                    ._tel_cel = Integer.Parse(txtTelefono.Text)
                    ._edad = Integer.Parse(txtEdad.Text)
                    ._domicilio = txtDomicilio.Text
                    ._sexo = cbSexo.Text
                    ._pNom = txtPNom.Text
                    ._pApe = txtSnom.Text
                    ._sNom = txtPape.Text
                    ._sApe = txtSape.Text
                End With

                If paciente.Guardar() Then
                    General.GetForm(Estado.Ok, "Usuario creado correctamente, utilice su cedula para iniciar sesion")
                End If
            Catch ex As Exception
                General.GetForm(Estado.Critical, ex.Message)
            End Try
        End If
    End Sub

    Private Function ComprobarCamposUsuario() As Boolean
        If (txtCedula.Text = "" Or txtCorreo.Text = "" Or txtCedula.Text = "" Or txtTelefono.Text = "" Or
           txtEdad.Text = "" Or txtDomicilio.Text = "" Or cbSexo.Text = "" Or txtPNom.Text = "" Or
           txtSnom.Text = "" Or txtPape.Text = "" Or txtSape.Text = "") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtCedu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress, txtEdad.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

    Private Sub ControlCaracteres_keyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtSnom.KeyPress, txtSape.KeyPress, txtPNom.KeyPress, txtPape.KeyPress, txtEdad.KeyPress, txtDomicilio.KeyPress, txtCorreo.KeyPress, txtCedula.KeyPress
        DesecharCaracteresEspeciales(e)
    End Sub

    Private Sub txtCedu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, btnCrear.KeyDown, btnCancelar.KeyDown, txtTelefono.KeyDown, txtSnom.KeyDown, txtSape.KeyDown, txtPNom.KeyDown, txtPape.KeyDown, txtEdad.KeyDown, txtDomicilio.KeyDown, txtCorreo.KeyDown, txtCedula.KeyDown
        DesecharAltF4(e)

    End Sub

End Class
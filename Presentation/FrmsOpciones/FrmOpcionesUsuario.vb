Public Class FrmOpcionesUsuario
    Private Sub FrmOpcionesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña1.Focus()
        Traductor.traducirForm(Me)
        Select Case FrmLogIn.tipoLogin
            Case "Paciente"
                fotoPerfil.Image = ObtenerImagen(FrmLogIn.paci._ci)
                dgvDatosUsuario.DataSource = FrmLogIn.paci.ListarPersona
            Case "Gerente"
                fotoPerfil.Image = ObtenerImagen(FrmLogIn.gere._ci)

                dgvDatosUsuario.DataSource = FrmLogIn.gere.ListarPersona
            Case "Medico"
                fotoPerfil.Image = ObtenerImagen(FrmLogIn.medic._ci)

                dgvDatosUsuario.DataSource = FrmLogIn.medic.ListarPersona
        End Select
        txtPnom.Text = dgvDatosUsuario.Item(0, 0).Value()
        txtSnom.Text = dgvDatosUsuario.Item(1, 0).Value()
        txtPape.Text = dgvDatosUsuario.Item(2, 0).Value()
        txtSape.Text = dgvDatosUsuario.Item(3, 0).Value()
        txtEdad.Text = dgvDatosUsuario.Item(4, 0).Value()
        txtTel.Text = dgvDatosUsuario.Item(5, 0).Value()
        txtDir.Text = dgvDatosUsuario.Item(6, 0).Value()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim result As Boolean = False

        If (txtEdad.Text IsNot "" And txtPnom.Text IsNot "" And txtPape.Text IsNot "" And txtSape.Text IsNot "") Then
            If Integer.Parse(txtEdad.Text) <= 120 AndAlso Integer.Parse(txtEdad.Text) >= 10 Then
                If Integer.Parse(txtTel.Text) <= 9 OrElse Integer.Parse(txtTel.Text) >= 8 Then

                    Select Case FrmLogIn.tipoLogin

                        Case "Paciente"
                            Try
                                With FrmLogIn.paci
                                    ._pNom = txtPnom.Text
                                    ._pApe = txtPape.Text
                                    ._sNom = txtSnom.Text
                                    ._sApe = txtSape.Text
                                    ._edad = Integer.Parse(txtEdad.Text)
                                    ._tel_cel = Integer.Parse(txtTel.Text)
                                    ._domicilio = txtDir.Text
                                    result = .ModificarP()
                                End With
                            Catch ex As Exception
                                GetForm(Estado.Error, ex.Message)
                                ErrorProvider1.SetError(lbActuDatos, ex.Message)
                            End Try
                        Case "Gerente"
                            Try
                                With FrmLogIn.gere
                                    ._pNom = txtPnom.Text
                                    ._pApe = txtPape.Text
                                    ._sNom = txtSnom.Text
                                    ._sApe = txtSape.Text
                                    ._tel_cel = Integer.Parse(txtTel.Text)
                                    ._edad = Integer.Parse(txtEdad.Text)
                                    result = .ModificarP()
                                End With

                            Catch ex As Exception
                                GetForm(Estado.Error, ex.Message)
                                ErrorProvider1.SetError(lbActuDatos, ex.Message)
                            End Try
                        Case "Medico"
                            Try
                                With FrmLogIn.medic
                                    ._pNom = txtPnom.Text
                                    ._pApe = txtPape.Text
                                    ._sNom = txtSnom.Text
                                    ._sApe = txtSape.Text
                                    ._edad = Integer.Parse(txtEdad.Text)
                                    ._tel_cel = Integer.Parse(txtTel.Text)
                                    result = .ModificarP()
                                End With
                            Catch ex As Exception
                                GetForm(Estado.Error, ex.Message)
                                ErrorProvider1.SetError(lbActuDatos, ex.Message)
                            End Try
                    End Select

                    If result = True Then
                        GetForm(Estado.Ok, "Se modifico correctamente")
                        MsgBox("Si modifico su nombre o foto de perfil, por favor reinicie sesion")
                    Else
                        GetForm(Estado.Error, "No se pudo modificar")

                    End If
                Else
                    GetForm(Estado.Error, "Verifique que el numero de telefono tenga 8 o 9 digitos")
                    ErrorProvider1.SetError(lbActuDatos, "Verifique que el numero de telefono tenga 8 o 9 digitos")
                End If
            Else
                GetForm(Estado.Error, "Verifique que la edad sea menor o igual a 120 o mayor a 10")
                ErrorProvider1.SetError(lbActuDatos, "Verifique que la edad sea menor o igual a 120 o mayor a 10")
            End If
        Else

            GetForm(Estado.Error, "Todos los campos son obligatorios!")
            ErrorProvider1.SetError(lbActuDatos, "Todos los campos son obligatorios!")

        End If

    End Sub

    Private Sub btn_cambiar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        ErrorProvider1.Clear()

        If txtContraseña1.Text IsNot "" OrElse txtContraseña2.Text IsNot "" Then

            If txtContraseña1.TextLength >= 8 Then

                If txtContraseña1.Text = txtContraseña2.Text Then


                    If MessageBox.Show("Seguro que desa cambiar su contraseña?", "Advertencia",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                        Select Case FrmLogIn.tipoLogin
                            Case "Paciente"

                                With FrmLogIn.paci
                                    ._contraseña = txtContraActual.Text
                                    .EncriptarContraseña()

                                    If .ComprobarContraseña Then
                                        ._contraseña = txtContraseña2.Text
                                        .EncriptarContraseña()
                                        If .ModificarContraseña() Then
                                            GetForm(Estado.Ok, "Se modifico con exito")
                                        Else
                                            GetForm(Estado.Error, "No se pudo modificar la contraseña")
                                            ErrorProvider1.SetError(lbUsuario, "No se pudo modificar la contraseña")
                                        End If
                                    Else
                                        ErrorProvider1.SetError(Persona_pass, "La contraseña actual es incorrecta")
                                    End If

                                End With

                            Case "Gerente"
                                With FrmLogIn.gere
                                    ._contraseña = txtContraActual.Text
                                    .EncriptarContraseña()

                                    If .ComprobarContraseña Then
                                        ._contraseña = txtContraseña2.Text
                                        .EncriptarContraseña()
                                        If .ModificarContraseña() Then
                                            GetForm(Estado.Ok, "Se modifico con exito")
                                        Else
                                            GetForm(Estado.Error, "No se pudo modificar la contraseña")
                                            ErrorProvider1.SetError(lbUsuario, "No se pudo modificar la contraseña")
                                        End If
                                    Else
                                        ErrorProvider1.SetError(Persona_pass, "La contraseña actual es incorrecta")
                                    End If
                                End With
                            Case "Medico"
                                With FrmLogIn.medic
                                    ._contraseña = txtContraActual.Text
                                    .EncriptarContraseña()

                                    If .ComprobarContraseña Then
                                        ._contraseña = txtContraseña2.Text
                                        .EncriptarContraseña()
                                        If .ModificarContraseña() Then
                                            GetForm(Estado.Ok, "Se modifico con exito")
                                        Else
                                            GetForm(Estado.Error, "No se pudo modificar la contraseña")
                                            ErrorProvider1.SetError(lbUsuario, "No se pudo modificar la contraseña")
                                        End If
                                    Else
                                        ErrorProvider1.SetError(Persona_pass, "La contraseña actual es incorrecta")
                                    End If
                                End With
                        End Select

                        txtContraActual.Text = ""
                        txtContraseña1.Text = ""
                        txtContraseña2.Text = ""
                    Else
                        txtContraActual.Text = ""
                        txtContraseña1.Text = ""
                        txtContraseña2.Text = ""
                    End If
                Else
                    GetForm(Estado.Error, "Las contraseñas no coinciden")
                    ErrorProvider1.SetError(lbCambiarContraseña, "Contraseña muy corta!")
                End If
            Else
                GetForm(Estado.Error, "Contraseña muy corta!")
                ErrorProvider1.SetError(lbCambiarContraseña, "Alguno de los campos de contraseña esta vacio")
            End If

        Else
            GetForm(Estado.Error, "Alguno de los campos de contraseña esta vacio")
            ErrorProvider1.SetError(lbCambiarContraseña, "Alguno de los campos de contraseña esta vacio")
        End If
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles fotoPerfil.Click
        GuardarImagen(FrmLogIn.paci._ci, ofdFoto, fotoPerfil)
    End Sub

    Private Sub txtContraseña1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress, txtSnom.KeyPress, txtSape.KeyPress, txtPnom.KeyPress, txtPape.KeyPress, txtEdad.KeyPress, txtDir.KeyPress, txtContraseña2.KeyPress, txtContraseña1.KeyPress, txtContraActual.KeyPress


        txtTel.MaxLength = 9
        txtSnom.MaxLength = 30
        txtSape.MaxLength = 30
        txtPnom.MaxLength = 30
        txtPape.MaxLength = 30
        txtEdad.MaxLength = 3
        txtDir.MaxLength = 255
        txtContraseña2.MaxLength = 100
        txtContraseña1.MaxLength = 100
        txtContraActual.MaxLength = 100


    End Sub
End Class
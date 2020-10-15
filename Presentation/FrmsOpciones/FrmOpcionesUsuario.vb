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

                Select Case FrmLogIn.tipoLogin

                    Case "Paciente"
                        Try
                            With FrmLogIn.paci
                                ._pNom = txtPnom.Text
                                ._pApe = txtPape.Text
                                ._sNom = txtSnom.Text
                                ._sApe = txtSape.Text
                                ._edad = Integer.Parse(txtEdad.Text)
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
                    ErrorProvider1.SetError(lbActuDatos, "No se pudo modificar")
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
        If txtContraseña1.Text IsNot "" OrElse txtContraseña2.Text IsNot "" Then

            If txtContraseña1.TextLength >= 8 Then

                If txtContraseña1.Text = txtContraseña2.Text Then


                    If MessageBox.Show("Seguro que desa cambiar su contraseña?", "Advertencia",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        Select Case FrmLogIn.tipoLogin
                            Case "Paciente"
                                FrmLogIn.paci._contraseña = txtContraseña2.Text
                                FrmLogIn.paci.EncriptarContraseña()
                                FrmLogIn.paci.ModificarContraseña()
                            Case "Gerente"
                                FrmLogIn.gere._contraseña = txtContraseña2.Text
                                FrmLogIn.gere.EncriptarContraseña()
                                FrmLogIn.gere.ModificarContraseña()
                            Case "Medico"
                                FrmLogIn.medic._contraseña = txtContraseña2.Text
                                FrmLogIn.medic.EncriptarContraseña()
                                FrmLogIn.medic.ModificarContraseña()
                        End Select
                        txtContraseña1.Text = ""
                        txtContraseña2.Text = ""
                    Else
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
End Class
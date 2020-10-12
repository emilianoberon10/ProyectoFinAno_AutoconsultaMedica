Public Class FrmOpcionesUsuario
    Private Sub FrmOpcionesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        Select Case FrmLogIn.tipoLogin
            Case "Paciente"
                ObtenerImagen(FrmLogIn.paci._ci)
                dgvDatosUsuario.DataSource = FrmLogIn.paci.ObtenerNombreEdad
            Case "Gerente"
                ObtenerImagen(FrmLogIn.gere._ci)

                dgvDatosUsuario.DataSource = FrmLogIn.gere.ObtenerNombreEdad
            Case "Medico"
                ObtenerImagen(FrmLogIn.medic._ci)

                dgvDatosUsuario.DataSource = FrmLogIn.medic.ObtenerNombreEdad
        End Select
        txtPnom.Text = dgvDatosUsuario.Item(0, 0).Value()
        txtSnom.Text = dgvDatosUsuario.Item(1, 0).Value()
        txtPape.Text = dgvDatosUsuario.Item(2, 0).Value()
        txtSape.Text = dgvDatosUsuario.Item(3, 0).Value()
        txtEdad.Text = dgvDatosUsuario.Item(4, 0).Value()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim result As Boolean = False
        Select Case FrmLogIn.tipoLogin
            Case "Paciente"
                With FrmLogIn.paci
                    ._pNom = txtPnom.Text
                    ._pApe = txtPape.Text
                    ._sNom = txtSnom.Text
                    ._sApe = txtSape.Text
                    ._edad = Integer.Parse(txtEdad.Text)
                    result = .ModificarP()

                End With
            Case "Gerente"
                With FrmLogIn.gere
                    ._pNom = txtPnom.Text
                    ._pApe = txtPape.Text
                    ._sNom = txtSnom.Text
                    ._sApe = txtSape.Text
                    ._edad = Integer.Parse(txtEdad.Text)

                    result = .ModificarP()

                End With
            Case "Medico"
                With FrmLogIn.medic
                    ._pNom = txtPnom.Text
                    ._pApe = txtPape.Text
                    ._sNom = txtSnom.Text
                    ._sApe = txtSape.Text
                    ._edad = Integer.Parse(txtEdad.Text)
                    result = .ModificarP()
                End With
        End Select

        If result = True Then
            txtPnom.Text = ""
            txtPape.Text = ""
            txtSnom.Text = ""
            txtSape.Text = ""
            txtEdad.Text = ""
            GetForm(Estado.Ok, "Se modifico correctamente")
            MsgBox("Si modifico su nombre o foto de perfil, por favor reinicie sesion")
        Else
            GetForm(Estado.Ok, "Se modifico correctamente")
            ErrorProvider1.SetError(lbActuDatos, "Se modifico correctamente")
        End If
    End Sub

    Private Sub btn_cambiar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txtContraseña1.Text IsNot "" OrElse txtContraseña2.Text IsNot "" Then
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
                ErrorProvider1.SetError(lbCambiarContraseña, "Las contraseñas no coinciden")
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
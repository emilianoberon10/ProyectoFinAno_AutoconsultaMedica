Imports Logic

Public Class FrmCrearUsuario

    Private Sub FrmCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
                    ._ci = txtCedu.Text
                    ._mail = txtCorreo.Text
                    ._contraseña = txtCedu.Text
                    ._tel_cel = Integer.Parse(txtTel.Text)
                    ._edad = Integer.Parse(txtEdad.Text)
                    ._domicilio = txtDir.Text
                    ._sexo = cbSexo.Text
                    ._pNom = txtPriNom.Text
                    ._pApe = txtSegNom.Text
                    ._sNom = txtApe.Text
                    ._sApe = txtSegApe.Text
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
        If (txtCedu.Text = "" Or txtCorreo.Text = "" Or txtCedu.Text = "" Or txtTel.Text = "" Or
           txtEdad.Text = "" Or txtDir.Text = "" Or cbSexo.Text = "" Or txtPriNom.Text = "" Or
           txtSegNom.Text = "" Or txtApe.Text = "" Or txtSegApe.Text = "") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_Paint(sender As Object, e As PaintEventArgs) Handles btnCancelar.Paint, btnCrear.Paint
        BotonRedondeado(btnCancelar)
        BotonRedondeado(btnCrear)
    End Sub

    Private Sub txtCedu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress, txtEdad.KeyPress, txtCedu.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

    'txtCedu.Text, txtCorreo.Text, txtCedu.Text,
    'Integer.Parse(txtTel.Text), Integer.Parse(txtEdad.Text), txtDir.Text, cbSexo.Text,
    'txtPriNom.Text, txtSegNom.Text, txtApe.Text, txtSegApe.Text
End Class
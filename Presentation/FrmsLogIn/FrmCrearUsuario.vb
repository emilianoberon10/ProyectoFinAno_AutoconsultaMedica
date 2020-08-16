Imports Logic

Public Class FrmCrearUsuario

    Private Sub FrmCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If txtCedu.Text = "" Or txtCorreo.Text = "" Or txtCedu.Text = "" Or txtTel.Text = "" Or txtEdad.Text = "" Or txtDir.Text = "" Or cbSexo.Text = "" Or txtPriNom.Text = "" Or txtSegNom.Text = "" Or txtApe.Text Or txtSegApe.Text = "" Then
            MsgBox("ERROR:: Todos los campos son obligatorios!")
        Else

            Dim paciente As New Paciente(txtCedu.Text, txtCorreo.Text, txtCedu.Text,
                                 txtTel.Text, txtEdad.Text, txtDir.Text, cbSexo.Text,
                                 txtPriNom.Text, txtSegNom.Text, txtApe.Text, txtSegApe.Text,
                                 DateTimePicker1.Value)
            paciente.Guardar()
            MsgBox("Usuario creado correctamente, utilice su cedula para iniciar sesion")
        End If
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnCancelar.Paint, btnCrear.Paint
        BotonRedondeado(btnCancelar)
        BotonRedondeado(btnCrear)
    End Sub

End Class
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
                MsgBox("Se ingreso con exito")
            End If
        End If

    End Sub

    Private Sub FrmMedico_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        BotonRedondeado(btnIngresar)
    End Sub

End Class
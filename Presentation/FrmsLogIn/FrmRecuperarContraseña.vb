Public Class FrmRecuperarContraseña

    Private Sub FrmRecuperarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles  btnRestablecer.Click

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles  btnRecuperar.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles  btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

End Class
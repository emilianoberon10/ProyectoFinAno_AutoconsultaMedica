Public Class FrmChatPaciente

    Private Sub FrmChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogIn.paci.EliminarSolicitudAceptada()
    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btnSalirChat.Click
        Me.Visible = False
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btnEnviarMensaje.PerformClick()
        End If
    End Sub

End Class
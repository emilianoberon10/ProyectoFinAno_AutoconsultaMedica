Public Class FrmChatPaciente

    Private Sub FrmChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogIn.paci.EliminarSolicitudAceptada()
    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btnSalirChat.Click
        Me.Visible = False
    End Sub

End Class
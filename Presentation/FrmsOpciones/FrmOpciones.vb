Public Class FrmOpciones
    Private Sub FrmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirPanel(optionPanel)
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_ayuda_Click(sender As Object, e As EventArgs) Handles btn_ayuda.Click
        OpenChildForm(New FrmOpcionesAyuda, childPanel)

    End Sub

    Private Sub btn_usuario_Click(sender As Object, e As EventArgs) Handles btn_usuario.Click
        OpenChildForm(New FrmOpcionesUsuario, childPanel)

    End Sub

End Class
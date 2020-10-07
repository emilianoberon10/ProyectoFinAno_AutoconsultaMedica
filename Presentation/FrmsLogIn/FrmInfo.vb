Public Class FrmInfo

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbForgotPassEs.LinkClicked
        Dim frm As New FrmRecuperarContraseña
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCrearUsuario.LinkClicked
        Dim frm As New FrmCrearUsuario
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

End Class
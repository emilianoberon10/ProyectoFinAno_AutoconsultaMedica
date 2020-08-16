Public Class FrmInfo

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbRecuperarPass.LinkClicked
        Dim frm As New FrmRecuperarContraseña
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCrearUsuario.LinkClicked
        Dim frm As New FrmCrearUsuario
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Close()
    End Sub

End Class
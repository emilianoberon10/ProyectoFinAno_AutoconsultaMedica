Imports System.Text
Imports Logic
Public Class FrmRecuperarContraseña

    Private Sub FrmRecuperarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btn_recuperar.Click
        Dim r As New Random
        Dim p As New Paciente
        Dim pass As String
        Dim res As String
        pass = RandomString(r)

        With p
            ._ci = txtCedula.Text
            ._mail = txtCorreo.Text
            ._contraseña = pass
            .EncriptarContraseña()
        End With

        res = p.RestablecerContra(pass)

        lbMensaje.Text = res
        lbMensaje.Visible = True

    End Sub
    Private Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(10, 15)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
        txtCedula.MaxLength = 8
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        txtCorreo.MaxLength = 255

    End Sub
End Class
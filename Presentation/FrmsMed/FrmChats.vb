Public Class FrmChats

    Private Sub FrmChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Start()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnVerFichaMedica_Click(sender As Object, e As EventArgs) Handles btnVerFichaMedica.Click

    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Esta seguro de cerrar el chat?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btnEnviarMensaje.PerformClick()
        End If
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs)
        Dim msj As String = "Medico: " & txtMensaje.Text
        txtChat.Text &= msj & vbNewLine
        FrmLogIn.medic.EnviarMsj(msj)
        txtMensaje.Text = ""
        txtMensaje.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim mensaje As String = FrmLogIn.medic.ComprobarMsj()
        If mensaje IsNot "" Then txtChat.Text &= mensaje & vbNewLine

    End Sub

End Class
Public Class FrmChats

    Private Sub FrmChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = FrmSolicitudesChat.diag
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btnSalirChat.Click
        If MessageBox.Show("Esta seguro de cerrar el chat?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Application.Exit()
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

End Class
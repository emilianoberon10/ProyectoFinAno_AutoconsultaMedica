Public Class FrmEsperaChat

    Private Sub FrmEsperaChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        CircularProgressBar1.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        Timer1.Start() 'Iniciamos el temporizador 1'
        TimerComprobarChatAceptado.Start()
        lbNombre.Text = FrmLogIn.paci._pNom
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If CircularProgressBar1.Value = 100 Then
            CircularProgressBar1.Value = 0
            Timer1.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub TimerComprobarChatAceptado_Tick(sender As Object, e As EventArgs) Handles TimerComprobarChatAceptado.Tick

        If FrmLogIn.paci.ComprobarChatAceptado Then
            TimerComprobarChatAceptado.Stop()
            Dim form As New FrmChatPaciente
            form.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If FrmLogIn.paci.CancelarSolicitud() Then
                MessageBox.Show("Cancelado con exito", "Solicitud Cancelada", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        End If
    End Sub
End Class
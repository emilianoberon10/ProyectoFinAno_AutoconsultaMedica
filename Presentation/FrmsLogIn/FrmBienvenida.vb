Public Class FrmBienvenida

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressBar1.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        Timer1.Start() 'Iniciamos el temporizador 1'
        If FrmLogIn.tipoLogin = "Paciente" Then
            FrmLogIn.paci._pNom = FrmLogIn.paci.ObtenerNombre() 'Guardo el nombre del paciente para personalizar su interfaz y mostrarlo en el chat
            lbNombre.Text = FrmLogIn.paci._pNom

        ElseIf FrmLogIn.tipoLogin = "Gerente" Then
            FrmLogIn.gere._pNom = FrmLogIn.gere.ObtenerNombre() 'Guardo el nombre del paciente para personalizar su interfaz y mostrarlo en el chat
            lbNombre.Text = FrmLogIn.gere._pNom
        Else
            FrmLogIn.medic._pNom = FrmLogIn.medic.ObtenerNombre() 'Guardo el nombre del paciente para personalizar su interfaz y mostrarlo en el chat
            lbNombre.Text = FrmLogIn.medic._pNom
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

End Class
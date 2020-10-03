Imports System.Runtime.InteropServices

Public Class FrmChatPaciente

    Private Sub FrmChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogIn.paci.EliminarSolicitudAceptada()
        Timer1.Start()

    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("Esta seguro de cerrar el chat?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            FrmLogIn.paci.FinalizarChat()
            Me.Close()
        End If
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        DesecharCaracteresEspeciales(e)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btnEnviarMensaje.PerformClick()
        End If
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        Dim msj As String = "Paciente: " & txtMensaje.Text
        If msj IsNot "Paciente: " Then
            Try
                txtChat.Text &= msj & vbNewLine
                FrmLogIn.paci.EnviarMsj(msj)
                txtMensaje.Text = ""
                txtMensaje.Focus()

            Catch ex As Exception
                General.GetForm(Estado.Error, ex.Message)
            End Try

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim mensaje As String = FrmLogIn.paci.ComprobarMsj()
        If mensaje IsNot "" Then txtChat.Text &= mensaje & vbNewLine
    End Sub

#Region "poder mover el form"

    'DLLImport,Significa que el método declarado a
    'continuación no está en .NET, sino en un archivo DLL externo (nativo).
    'En este caso, se encuentra en el archivo User32.dll, que es un componente
    'estándar de Windows. El cual nos permite utilizar los eventos/método del sistema
    'operativo, en este caso capturar las señales del mouse.
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region 'region de mover form

End Class
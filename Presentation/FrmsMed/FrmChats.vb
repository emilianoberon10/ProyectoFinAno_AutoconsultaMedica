Imports System.Runtime.InteropServices

Public Class FrmChats

    Private Sub FrmChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(TopPanel)
        Me.KeyPreview = True
        Guna2DataGridView1.DataSource = FrmLogIn.medic.VerChatsAntiguos
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Esta seguro de Modificar el diagnostico por: " & txtDiagnostico.Text & "", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            If FrmLogIn.medic.ModificarDiagnostico(txtCi.Text, txtDiagnostico.Text) Then
                GetForm(Estado.Ok, "Se modifico correctamente")
            End If
        End If
    End Sub

    Private Sub btnVerFichaMedica_Click(sender As Object, e As EventArgs) Handles btn_fichaMed.Click

        FrmLogIn.paci = New Logic.Paciente(txtCi.Text)
        Dim frm As New FrmFichaMedicaPaciente
        frm.Show()
    End Sub

    Private Sub btnSalirChat_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Esta seguro de cerrar el chat?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            'FrmLogIn.medic.FinalizarChat()
            Me.Close()
        End If
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btn_enviar.PerformClick()
        End If
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Dim msj As String = "Medico: " & txtMensaje.Text
        If msj IsNot "Medico: " Then
            Try
                txtChat.Text &= msj & vbNewLine
                FrmLogIn.medic.EnviarMsj(msj)
                txtMensaje.Text = ""
                txtMensaje.Focus()
            Catch ex As Exception
                General.GetForm(Estado.Error, ex.Message)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim mensaje As String = FrmLogIn.medic.ComprobarMsj()
        If mensaje IsNot "" Then txtChat.Text &= mensaje & vbNewLine
        mensaje = ""
    End Sub

    Private Sub FrmChats_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmLogIn.medic.FinalizarChat()
    End Sub

    Private Sub FrmChats_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, txtMensaje.KeyDown, txtDiagnostico.KeyDown, btn_fichaMed.KeyDown, btn_modificar.KeyDown, btn_enviar.KeyDown, btn_salir.KeyDown, txtCi.KeyDown
        DesecharAltF4(e)
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

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

#End Region 'region de mover form

End Class
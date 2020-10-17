Imports System.Runtime.InteropServices

Public Class FrmPrincipalPaciente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New FrmConsultaPaciente, PanelChildFormPac)
        lbNombre.Text = FrmLogIn.paci._pNom
        fotoPerfil.Image = ObtenerImagen(FrmLogIn.paci._ci)
        If Traductor.idioma Is "ES" Then
            btnChangeLanguage.Image = My.Resources.spain
        ElseIf Traductor.idioma Is "EN" Then
            btnChangeLanguage.Image = My.Resources.england
        End If
        Traductor.traducirPanel(Me.PanelMenuPac)
        Traductor.traducirPanel(Me.TopPanel)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        'cierro totalmente la app
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnAgendaMedica_Click(sender As Object, e As EventArgs) Handles btn_Agenda.Click
        OpenChildForm(New FrmAgendaMedica, PanelChildFormPac)
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        OpenChildForm(New FrmHistorial, PanelChildFormPac)
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        OpenChildForm(New FrmConsultaPaciente, PanelChildFormPac)
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        Dim opciones As New FrmOpciones
        opciones.ShowDialog()
    End Sub

    Dim foto As String

    Private Sub fotoPerfil_Click(sender As Object, e As EventArgs) Handles fotoPerfil.Click, lbCambiarFoto.Click
        GuardarImagen(FrmLogIn.paci._ci, ofdFoto, fotoPerfil)
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

    Private Sub btnChangeLanguage_Click(sender As Object, e As EventArgs) Handles btnChangeLanguage.Click
        If Traductor.idioma Is "ES" Then
            Traductor.idioma = "EN"
            Traductor.traducirPanel(Me.PanelMenuPac)
            Traductor.traducirPanel(Me.TopPanel)
            btnChangeLanguage.Image = My.Resources.england
        ElseIf Traductor.idioma Is "EN" Then
            Traductor.idioma = "ES"
            Traductor.traducirPanel(Me.PanelMenuPac)
            Traductor.traducirPanel(Me.TopPanel)
            btnChangeLanguage.Image = My.Resources.spain

        End If
    End Sub

#End Region 'region de mover form

End Class
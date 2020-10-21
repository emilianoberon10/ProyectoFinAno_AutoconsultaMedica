Imports System.Runtime.InteropServices

Public Class FrmPrincipalGerente

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNombre.Text = FrmLogIn.gere._pNom
        fotoPerfil.Image = ObtenerImagen(FrmLogIn.gere._ci)
        Traductor.traducirPanel(PanelMenu)
        Traductor.traducirPanel(TopPanel)
        If Traductor.idioma Is "ES" Then
            btnChangeLanguage.Image = My.Resources.spain
        ElseIf Traductor.idioma Is "EN" Then
            btnChangeLanguage.Image = My.Resources.england
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btn_patologia.Click
        OpenChildForm(New FrmIngresarGerente, PanelChildForm)
    End Sub

    Private Sub btnIngresarMedico_Click(sender As Object, e As EventArgs) Handles btn_ingrMed.Click
        OpenChildForm(New FrmMedicoGerente, PanelChildForm)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        OpenChildForm(New FrmModificarGerente, PanelChildForm)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        OpenChildForm(New FrmEliminarGerente, PanelChildForm)
    End Sub
    Private Sub btn_dashBoard_Click(sender As Object, e As EventArgs) Handles btn_dashBoard.Click
        OpenChildForm(New FrmDatosUso, PanelChildForm)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub fotoPerfil_Click(sender As Object, e As EventArgs) Handles fotoPerfil.Click
        GuardarImagen(FrmLogIn.gere._ci, ofdFoto, fotoPerfil)

    End Sub
    Private Sub btnChangeLanguage_Click(sender As Object, e As EventArgs) Handles btnChangeLanguage.Click
        If Traductor.idioma Is "ES" Then
            Traductor.idioma = "EN"
            Traductor.traducirPanel(Me.PanelMenu)
            Traductor.traducirPanel(Me.TopPanel)
            btnChangeLanguage.Image = My.Resources.england
        ElseIf Traductor.idioma Is "EN" Then
            Traductor.idioma = "ES"
            Traductor.traducirPanel(Me.PanelMenu)
            Traductor.traducirPanel(Me.TopPanel)
            btnChangeLanguage.Image = My.Resources.spain

        End If
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        Dim frm As New FrmOpciones
        frm.Show()
    End Sub
#Region "Hover's"

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackColor = Color.FromArgb(48, 63, 105)
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackColor = Color.FromArgb(26, 31, 55)
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.BackColor = Color.FromArgb(48, 63, 105)

    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackColor = Color.FromArgb(26, 31, 55)
    End Sub

#End Region

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

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown, app_titulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region 'region de mover form

End Class
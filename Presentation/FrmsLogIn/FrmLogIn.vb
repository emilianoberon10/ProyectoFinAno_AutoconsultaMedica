Imports System.Runtime.InteropServices
Imports Logic
Imports System.Threading.Thread
Imports System.Globalization
Imports Presentation.My.Resources
Imports System.ComponentModel

Public Class FrmLogIn

#Region "variables"

    'objetos para el usuario que se loguea
    Protected Friend paci As Paciente

    Protected Friend gere As Gerente

    Protected Friend medic As Medico

    ' ----------------------------------------
    Public tipoLogin As String

#Region "Froms que se abren apartir del login"

    'forms del login
    ReadOnly frmInfo As New FrmInfo

    ReadOnly frmCrear As New FrmCrearUsuario
    ReadOnly frmRecuPass As New FrmRecuperarContraseña
    ReadOnly formwelcome As New FrmBienvenida

    'forms de usuarios
    Private frmPaciente As FrmPrincipalPaciente

    Private frmGerente As FrmPrincipalGerente
    Private frmMedico As FrmMedPrincipal

#End Region

#End Region

    'Metodo que se ejecuta al cerrar el frm principal, no el login
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        ErrorProviderUserBien.Clear()
        ErrorProviderPass.Clear()
        txtUser.FillColor = Color.FromArgb(48, 63, 105)
        txtUser.Clear()
        txtPass.Clear()
        If Traductor.idioma Is "ES" Then
            btnChangeLanguage.Image = My.Resources.spain
        ElseIf Traductor.idioma Is "EN" Then
            btnChangeLanguage.Image = My.Resources.england
        End If
        Traductor.traducirForm(Me)
        Me.Show()
        txtUser.Focus()
    End Sub

    Private Sub FrmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        txtPass.MaxLength = 255
        txtUser.MaxLength = 8
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click

        ErrorProviderLogIn.Clear()
        If txtPass.Text.Length < 6 Then

            ErrorProviderPass.Clear()
            ErrorProviderPass.SetError(Me.lbContraseña, "La contraseña debe contener almenos 8 caracteres")

        ElseIf txtUser.Text.Length < 4 Then

            ErrorProviderUserMal.Clear()
            ErrorProviderUserMal.SetError(Me.lbUsuario, "El nombre de usuario es muy corto")
        Else
            Select Case ConfirmarLogin(txtUser.Text, EncriptarContraseña(txtPass.Text))
                Case "Paciente"
                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")

                    Me.Hide()

                    paci = New Paciente(txtUser.Text) 'Guardo la ci del paciente para poder usarla luego
                    tipoLogin = "Paciente"

                    formwelcome.ShowDialog()
                    frmPaciente = New FrmPrincipalPaciente
                    frmPaciente.Show()
                    AddHandler frmPaciente.FormClosed, AddressOf Me.Logout
                    Me.Hide()

                Case "Gerente"
                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")

                    Me.Hide()

                    gere = New Gerente(txtUser.Text)  'Guardo la ci del paciente para poder usarla luego
                    tipoLogin = "Gerente"

                    formwelcome.ShowDialog()

                    frmGerente = New FrmPrincipalGerente
                    frmGerente.Show()
                    AddHandler frmGerente.FormClosed, AddressOf Me.Logout
                    Me.Hide()

                Case "Medico"
                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")

                    Me.Hide()

                    medic = New Medico() 'Guardo la ci del paciente para poder usarla luego
                    medic._numMed = txtUser.Text
                    tipoLogin = "Medico"

                    formwelcome.ShowDialog()

                    frmMedico = New FrmMedPrincipal
                    frmMedico.Show()
                    AddHandler frmMedico.FormClosed, AddressOf Me.Logout
                    Me.Hide()
                Case Else
                    ErrorProviderLogIn.SetError(Me.txtUser, "Nombre de usuario o contraseña INCORRECTOS.")
                    GetForm(Estado.Error, "Nombre de usuario o contraseña INCORRECTOS.")
                    txtPass.Clear()
                    txtPass.Focus()
            End Select
        End If
    End Sub

    Private Sub llbForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbForgotPassEs.LinkClicked
        frmRecuPass.ShowDialog()
    End Sub

    Private Sub llbCrearUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCrearUsuario.LinkClicked
        frmCrear.ShowDialog()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        frmInfo.ShowDialog()
    End Sub

    Private Sub btnVerPass_Click_1(sender As Object, e As EventArgs) Handles btnVerPass.Click
        If txtPass.UseSystemPasswordChar = True Then
            btnVerPass.Image = My.Resources.password_open
            txtPass.UseSystemPasswordChar = False
        Else
            btnVerPass.Image = My.Resources.password
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

#Region "Estilisado"

    Private Sub btnChangeLanguage_Click(sender As Object, e As EventArgs) Handles btnChangeLanguage.Click
        CambiarIdioma(btnChangeLanguage, Me)
    End Sub

    Private Sub FrmLogIn_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, txtUser.KeyDown, txtPass.KeyDown, btn_Iniciar.KeyDown
        DesecharAltF4(e)
    End Sub

#Region "funcionamiento text area"

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        DesecharCaracteresEspeciales(e)
        'al dar enter en el textBox de la contraseña genero un evento click para el boton login
        'con el if compruebo que el keypress fue un enter y no otra letra
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btn_Iniciar.PerformClick()
        End If
    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        With txtUser
            .ForeColor = Color.FromArgb(240, 240, 240)
        End With
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        With txtPass

            .UseSystemPasswordChar = True 'coloco los caracteres de contraseña
            .ForeColor = Color.FromArgb(240, 240, 240)

        End With
    End Sub

    'para mostrar si el largo de la ci es correcto
    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        ErrorProviderUserMal.Clear()
        ErrorProviderUserBien.Clear()
        If txtUser.Text.Length < 4 Then
            ErrorProviderUserMal.SetError(Me.lbUsuario, "El nombre de usuario es muy corto")
            txtUser.FillColor = Color.FromArgb(48, 63, 105)
        Else
            ErrorProviderUserBien.SetError(Me.lbUsuario, "El largo es correcto")
            txtUser.FillColor = Color.FromArgb(50, 194, 77)
        End If
    End Sub

#End Region 'region estilos text area

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

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles topPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region 'region de mover form

#Region "bnts Hover"

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackColor = Color.FromArgb(48, 63, 105)
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackColor = Color.FromArgb(36, 43, 73)
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.BackColor = Color.FromArgb(48, 63, 105)

    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackColor = Color.FromArgb(36, 43, 73)

    End Sub

#End Region

#End Region 'region de estilos

End Class
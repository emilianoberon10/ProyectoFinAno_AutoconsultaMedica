Imports System.Runtime.InteropServices
Imports Logic

Public Class FrmLogIn

    Public paci As Paciente
    Public gere As Gerente
    Public medic As Medico
    Public tipoLogin As String

    ' Las letras In y Es al final de los labels significan Ingles y Español
    Private lenguaje As String = "ES"

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ErrorProvider1.Clear()
        If txtPass.Text.Length < 8 Then
            ErrorProvider4.SetError(Me.lbContraseña, "La contraseña debe contener almenos 8 caracteres")
        ElseIf txtUser.Text.Length < 8 Then
            ErrorProvider2.Clear()
            ErrorProvider2.SetError(Me.lbUsuario, "El nombre de usuario es muy corto")
        Else

            Select Case ConfirmarLogin(txtUser.Text, txtPass.Text)
                Case "Paciente"
                    Me.Hide()
                    Dim formwelcome As New FrmBienvenida()

                    paci = New Paciente(txtUser.Text) 'Guardo la ci del paciente para poder usarla luego
                    tipoLogin = "Paciente"

                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")
                    formwelcome.ShowDialog()
                    Dim form As New FrmPrincipalPaciente
                    form.Show()
                    AddHandler form.FormClosed, AddressOf Me.Logout
                    Me.Hide()

                Case "Gerente"
                    Me.Hide()
                    Dim formwelcome As New FrmBienvenida()

                    gere = New Gerente(txtUser.Text)  'Guardo la ci del paciente para poder usarla luego
                    tipoLogin = "Gerente"

                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")
                    formwelcome.ShowDialog()

                    Dim form As New FrmPrincipalGerente
                    form.Show()
                    AddHandler form.FormClosed, AddressOf Me.Logout
                    Me.Hide()

                Case "Medico"
                    Me.Hide()
                    Dim formwelcome As New FrmBienvenida()

                    medic = New Medico(txtUser.Text) 'Guardo la ci del paciente para poder usarla luego
                    tipoLogin = "Medico"

                    General.GetForm(Estado.Ok, "Inicio de sesion exitoso")
                    formwelcome.ShowDialog()

                    Dim form As New FrmMedPrincipal
                    form.Show()
                    AddHandler form.FormClosed, AddressOf Me.Logout
                    Me.Hide()
                Case Else
                    ErrorProvider1.SetError(Me.txtUser, "Nombre de usuario o contraseña INCORRECTOS.")
                    GetForm(Estado.Error, "Nombre de usuario o contraseña INCORRECTOS.")
                    txtPass.Clear()
                    txtPass.Focus()
            End Select
        End If
    End Sub

    Private Sub llbForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbForgotPassIn.LinkClicked, llbForgotPassEs.LinkClicked
        Dim frm As New FrmRecuperarContraseña
        frm.ShowDialog()
    End Sub

    Private Sub llbCrearUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCrearUsuarioEs.LinkClicked, llbCrearUsuarioIn.LinkClicked
        Dim frm As New FrmCrearUsuario
        frm.ShowDialog()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim frm As New FrmInfo
        frm.ShowDialog()
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

        If lenguaje = "ES" Then
            btnChangeLanguage.Image = My.Resources.england
            lenguaje = "EN"
        ElseIf lenguaje = "EN" Then
            btnChangeLanguage.Image = My.Resources.spain
            lenguaje = "ES"
        End If
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        BotonRedondeado(btnLogin)
    End Sub

#Region "funcionamiento text area"

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

#End Region 'region estilos text area

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        'al dar enter en el textBox de la contraseña genero un evento click para el boton login
        'con el if compruebo que el keypress fue un enter y no otra letra
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            'aqui genero el evento click
            btnLogin.PerformClick()
        End If
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

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles topPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#Region "btn cerrar y minimizar"

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

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
        If txtUser.Text.Length < 8 Then
            ErrorProvider2.SetError(Me.lbUsuario, "El nombre de usuario es muy corto")
            txtUser.BackColor = Color.FromArgb(48, 63, 105)
        Else
            ErrorProvider3.SetError(Me.lbUsuario, "El largo es correcto")
            txtUser.BackColor = Color.Green
        End If
    End Sub

#End Region

#End Region 'region de mover form

#End Region 'region de estilos

End Class
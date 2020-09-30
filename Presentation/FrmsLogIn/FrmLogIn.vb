Imports System.Runtime.InteropServices
Imports Logic

Imports Presentation.My.Resources

Public Class FrmLogIn

    'objetos para el usuario que se loguea
    Protected Friend paci As Paciente

    Protected Friend gere As Gerente

    Protected Friend medic As Medico

    ' ----------------------------------------
    Public tipoLogin As String

#Region "Froms que se abren apartid del login"

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

    ' Las letras In y Es al final de los labels significan Ingles y Español
    Shared lenguaje As String = "ES"

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        ErrorProviderUserBien.Clear()
        ErrorProviderPass.Clear()
        txtUser.BackColor = Color.FromArgb(48, 63, 105)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub

    Private Sub FrmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTextos()
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

        ErrorProviderLogIn.Clear()
        If txtPass.Text.Length < 6 Then

            ErrorProviderPass.Clear()
            ErrorProviderPass.SetError(Me.lbContraseña, "La contraseña debe contener almenos 8 caracteres")

        ElseIf txtUser.Text.Length < 8 Then

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

                    medic = New Medico(txtUser.Text) 'Guardo la ci del paciente para poder usarla luego
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

    Private Sub llbForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmRecuPass.ShowDialog()
    End Sub

    Private Sub llbCrearUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
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

        If lenguaje = "ES" Then
            btnChangeLanguage.Image = Resources.england
            lenguaje = "EN"
            Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("en-US")
        ElseIf lenguaje = "EN" Then
            btnChangeLanguage.Image = Resources.spain
            lenguaje = "ES"
            SetTextos()
        End If
    End Sub

    Private Sub SetTextos()
        'Metodo para setear los labels apartir del archivo Res.resx
        With Me
            lbUsuario.Text = Res.usuario
            lbContraseña.Text = Res.contra
            btnLogin.Text = Res.btn_Iniciar
            llbCrearUsuarioEs.Text = Res.crearUsuario
            llbForgotPassEs.Text = Res.passPerdida
        End With

        With frmInfo
            .Label1.Text = Res.Info_rocordatorio
            .Label2.Text = Res.Info_recordatorio2
            .Label3.Text = Res.Info_recordatorio3
            .llbCrearUsuario.Text = Res.crearUsuario
            .llbRecuperarPass.Text = Res.passPerdida
        End With
        With frmCrear
            .lbci.Text = Res.Persona_ci
            .lbedad.Text = Res.Persona_edad
            .lbTel.Text = Res.Persona_tel
            .lbDir.Text = Res.Persona_dir
            .lbPnom.Text = Res.Persona_pNom
            .lbPape.Text = Res.Persona_pApe
            .lbSnom.Text = Res.Persona_sNom
            .lbSape.Text = Res.Persona_sApe
            .lbCorreo.Text = Res.Persona_correo
            .btnCancelar.Text = Res.btn_cancelar
            .btnCrear.Text = Res.btn_crear
        End With
        With frmRecuPass
            .Label1.Text = Res.RecuperarPass_titulo
            .Label2.Text = Res.Persona_ci
            .Label3.Text = Res.Persona_correo
            .Label4.Text = Res.RecuperarPass_usuario
            .Label5.Text = Res.RecuperarPass_passNueva
            .Label6.Text = Res.RecuperarPass_passNueva2
            .btnCancelar.Text = Res.btn_cancelar
            .btnRecuperar.Text = Res.btn_recuperar
            .btnRestablecer.Text = Res.btn_restablecer
        End With
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs)
        'BotonRedondeado(btnLogin)
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
            btnLogin.PerformClick()
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
        If txtUser.Text.Length < 8 Then
            ErrorProviderUserMal.SetError(Me.lbUsuario, "El nombre de usuario es muy corto")
            txtUser.BackColor = Color.FromArgb(48, 63, 105)
        Else
            ErrorProviderUserBien.SetError(Me.lbUsuario, "El largo es correcto")
            txtUser.BackColor = Color.FromArgb(50, 194, 77)
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
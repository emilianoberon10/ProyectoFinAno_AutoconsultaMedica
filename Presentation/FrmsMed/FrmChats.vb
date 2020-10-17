Imports System.Runtime.InteropServices
Imports Logic
Public Class FrmChats

    Private Sub FrmChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(TopPanel)
        Me.KeyPreview = True
        dgvChats.DataSource = FrmLogIn.medic.VerChatsAntiguos()
        cargarChats()
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
        Dim mensaje As String = ""
        mensaje = FrmLogIn.medic.ComprobarMsj()
        If mensaje IsNot "" Then txtChat.Text &= mensaje & vbNewLine
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
#Region "ChatsAntiguos"
    Private _CurrentContactPanelName As String = Nothing

    'Used to give unique control names such as label1, label2 etc
    Private _ContactPanelsAddedCount As Integer = 0

    'Add contact panel to flow layout panel
    Public Sub CreatePanel()

        Dim contactPanel As Panel
        contactPanel = New Panel()

        'Set panel properties
        With contactPanel
            .BackColor = Color.FromArgb(37, 45, 76)
            .Size = New Size(250, 60)
            .Name = "pnlContact" + (_ContactPanelsAddedCount + 1).ToString
        End With

        'Add panel to flow layout panel
        flpMain.Controls.Add(contactPanel)

        'Update panel variables
        _CurrentContactPanelName = contactPanel.Name
        _ContactPanelsAddedCount += 1


    End Sub

    Public Sub createContactPictureBox(ByVal panelName As String, ByVal imagePath As Image)
        Dim contactPicture As New Guna.UI2.WinForms.Guna2CirclePictureBox
        With contactPicture
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Size(50, 50)
            .Location = New Point(40, 5)
            .Name = "picContactImage" + (_ContactPanelsAddedCount).ToString
            .Image = imagePath
        End With

        For Each control As Control In flpMain.Controls
            If control.Name = panelName Then
                control.Controls.Add(contactPicture)
            End If
        Next

    End Sub
    Public Sub createButton(ByVal panelName As String, ByVal idChat As Integer)
        Dim contactPicture As New Guna.UI2.WinForms.Guna2CircleButton
        With contactPicture
            .Size = New Size(30, 30)
            .Location = New Point(5, 15)
            .Name = idChat
            .Text = "<"
            .Animated = True
            .FillColor = Color.FromArgb(0, 60, 255)
            .PressedColor = Color.FromArgb(0, 20, 255)

            AddHandler .Click, AddressOf ButtonClick_Click
        End With

        For Each control As Control In flpMain.Controls
            If control.Name = panelName Then
                control.Controls.Add(contactPicture)
            End If
        Next

    End Sub
    Public Sub createNameLabel(ByVal panelName As String, ByVal textshow As String)
        Dim label As New Label
        With label
            .AutoSize = True
            .Location = New Point(100, 20)
            .Name = "lbContactName" + _ContactPanelsAddedCount.ToString
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ForeColor = Color.WhiteSmoke
            .Text = textshow
        End With

        For Each control As Control In flpMain.Controls
            If control.Name = panelName Then
                control.Controls.Add(label)
            End If
        Next
    End Sub

    Public Sub createEstadoLabel(ByVal panelName As String, ByVal textshow As String)
        Dim label As New Label
        With label
            .AutoSize = True
            .Location = New Point(100, 40)
            .Name = "lbContactName" + _ContactPanelsAddedCount.ToString
            .Font = New Font("Segoe UI", 8, FontStyle.Regular)
            .ForeColor = Color.Gainsboro
            .Text = textshow
        End With

        For Each control As Control In flpMain.Controls
            If control.Name = panelName Then
                control.Controls.Add(label)
            End If
        Next
    End Sub
    Public Sub createFechaLabel(ByVal panelName As String, ByVal textshow As String)
        Dim label As New Label
        With label
            .AutoSize = True
            .Location = New Point(150, 40)
            .Name = "lbContactName" + _ContactPanelsAddedCount.ToString
            .Font = New Font("Segoe UI", 8, FontStyle.Regular)
            .ForeColor = Color.Gainsboro
            .Text = textshow
        End With

        For Each control As Control In flpMain.Controls
            If control.Name = panelName Then
                control.Controls.Add(label)
            End If
        Next
    End Sub
    Private Sub cargarChats()
        Dim paciente As New Paciente

        For fila As Integer = 0 To dgvChats.Rows.Count - 2
            paciente._ci = dgvChats.Item(0, fila).Value()
            paciente._pNom = dgvChats.Item(1, fila).Value()

            CreatePanel()
            createContactPictureBox(_CurrentContactPanelName, ObtenerImagen(paciente._ci))
            createNameLabel(_CurrentContactPanelName, paciente._pNom)
            createEstadoLabel(_CurrentContactPanelName, dgvChats.Item(2, fila).Value())
            createFechaLabel(_CurrentContactPanelName, dgvChats.Item(3, fila).Value())
            createButton(_CurrentContactPanelName, dgvChats.Item(4, fila).Value())

        Next
    End Sub

    Private Sub ButtonClick_Click(sender As Object, e As EventArgs)
        txtChat.Text = ""
        dgvChats.DataSource = FrmLogIn.medic.CargarChat(sender.name)
        txtDiagnostico.Text = FrmLogIn.medic.CargarDiagChat(sender.name)

        For fila As Integer = 0 To dgvChats.Rows.Count - 1
            For col As Integer = 0 To dgvChats.ColumnCount - 1
                txtChat.Text &= dgvChats.Item(col, fila).Value() & vbNewLine
            Next
        Next


    End Sub


#End Region
End Class
Imports System.Runtime.InteropServices
Imports Logic
Public Class FrmModifDiagnostico

    Dim diagAnterior As String
    Dim ciPac As String
    Dim frmChat As FrmChats
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(frmchat As FrmChats, diagAnterior As String, ciPac As String)
        Me.New()
        Me.diagAnterior = diagAnterior
        Me.ciPac = ciPac
        Me.frmChat = frmchat
    End Sub
    Private Sub FrmModifDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim enf As New Enfermedad
        dgvEnfermedades.DataSource = enf.ObtenerEnfermedades
    End Sub

    Private Sub dgvEnfermedades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnfermedades.CellDoubleClick
        Dim columna As Integer
        columna = e.ColumnIndex
        Dim FilaActual As Integer
        FilaActual = dgvEnfermedades.CurrentRow.Index
        Dim diag As String
        Try
            diag = dgvEnfermedades.Item(columna, FilaActual).Value

            If MessageBox.Show("Esta seguro de Modificar el diagnostico de " & diagAnterior & " por: " & diag & "", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then


                If FrmLogIn.medic.ModificarDiagnostico(ciPac, diag) Then
                    GetForm(Estado.Ok, "Se modifico correctamente")
                    frmChat.txtDiagnostico.Text = diag
                Else
                    GetForm(Estado.Error, "No se pudo Modificar")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region 'region de mover form
End Class
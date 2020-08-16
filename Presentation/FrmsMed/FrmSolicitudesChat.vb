Public Class FrmSolicitudesChat

    Public diag As String
    Private Sub FrmSolicitudesChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Solicitudes()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Solicitudes()
    End Sub

    Private Sub dgvSolicitudes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitudes.CellDoubleClick
        Dim FilaActual As Integer = dgvSolicitudes.CurrentRow.Index

        Dim ci As String = dgvSolicitudes.Rows(FilaActual).Cells(1).Value
        diag = dgvSolicitudes.Rows(FilaActual).Cells(3).Value

        If MessageBox.Show("Sera redireccionado al chat con, desea continuar?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If FrmLogIn.medic.AceptarChat(ci, diag) Then
                Dim form As New FrmChats
                form.Show()
            End If
        End If
    End Sub

    Private Sub Solicitudes()
        dgvSolicitudes.DataSource = FrmLogIn.medic.ComprobarSoli()
    End Sub
End Class
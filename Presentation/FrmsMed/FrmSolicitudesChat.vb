Public Class FrmSolicitudesChat

    Public diag As String

    Private Sub FrmSolicitudesChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() 'inicio el timer
        'cargo el dataGrid por primera vez
        Solicitudes()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'actualizo el datagrid de solicitudes cada 5segundos
        Solicitudes()
    End Sub

    Private Sub dgvSolicitudes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitudes.CellDoubleClick
        Dim FilaActual As Integer = dgvSolicitudes.CurrentRow.Index

        Dim ci As String = dgvSolicitudes.Rows(FilaActual).Cells(0).Value
        diag = dgvSolicitudes.Rows(FilaActual).Cells(2).Value

        If MessageBox.Show("Sera redireccionado al chat con, desea continuar?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If FrmLogIn.medic.AceptarChat(ci, diag) Then
                Dim form As New FrmChats
                form.Show()
            End If
        End If
    End Sub

    Private Sub Solicitudes()
        'cargo las solicitudes de chat en un metodo aparte para llamarlo luego cada 5s
        dgvSolicitudes.DataSource = FrmLogIn.medic.ComprobarSoli()
    End Sub

    'Metodo para pintar la celda de riesgo segun su respectivo color
    Private Sub dgvSolicitudes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSolicitudes.CellFormatting
        If Me.dgvSolicitudes.Columns(e.ColumnIndex).Name = "riesgo" Then
            If Convert.ToString(e.Value) = "rojo" Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Red
            ElseIf Convert.ToString(e.Value) = "naranja" Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Orange
            ElseIf Convert.ToString(e.Value) = "amarillo" Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Yellow
            ElseIf Convert.ToString(e.Value) = "verde" Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Green
            ElseIf Convert.ToString(e.Value) = "azul" Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.DodgerBlue
            End If
        End If
    End Sub

End Class
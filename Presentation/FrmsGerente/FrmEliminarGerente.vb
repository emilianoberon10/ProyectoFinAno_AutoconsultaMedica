Imports Logic

Public Class FrmEliminarGerente

    Private Sub FrmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Select Case cbFiltro.Text
                    Case "Sintomas"
                        Dim borrar As New Sintoma(txtFiltro.Text)
                        If borrar.BorrarSintoma() Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                    Case "Enfermedades"
                        Dim borrar As New Enfermedad
                        If borrar.BorrarEnfermedad(txtFiltro.Text) Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                    Case "Medicos"
                        Dim borrar As New Medico(txtFiltro.Text)
                        If borrar.Borrar Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                End Select
            End If
        Catch ex As Exception
            ErrorProvider1.SetError(lbEliminar, ex.Message)
            General.GetForm(Estado.Error, ex.Message)
        End Try
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged
        Select Case cbFiltro.Text
            Case "Sintomas"
                dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
            Case "Enfermedades"
                dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
            Case "Medicos"
                dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
        End Select
    End Sub

    Private Sub dgvDatos_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Dim columna As Integer
            columna = e.ColumnIndex
            'Obtén el número de la fila que se seleccionó en el Datagridview
            Dim FilaActual As Integer
            FilaActual = dgvDatos.CurrentRow.Index
            'Mostrar en el cuadro de texto el valor de la columna seleccionada
            txtFiltro.Text = dgvDatos.Rows(FilaActual).Cells(columna).Value
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
        End Try
    End Sub
End Class
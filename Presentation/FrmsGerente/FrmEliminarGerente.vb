Imports Logic

Public Class FrmEliminarGerente

    Private Sub FrmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If MessageBox.Show("Seguro que desea eliminar," & txtFiltro.Text & "?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Select Case cbFiltro.Text
                    Case "Sintomas"
                        Dim borrar As New Sintoma(txtFiltro.Text)
                        If borrar.BorrarSintoma() Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                    Case "Enfermedades"
                        Dim borrar As New Enfermedad(txtFiltro.Text)
                        If borrar.BorrarEnfermedad() Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                    Case "Medicos"
                        Dim borrar As New Medico(txtFiltro.Text)
                        If borrar.Borrar Then General.GetForm(Estado.Ok, "Eliminado con exito") Else General.GetForm(Estado.Error, "No se pudo eliminar o ya no existe")
                        dgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                End Select
            End If
            txtFiltro.Enabled = True
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

    Private Sub dgvDatos_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatos.CellDoubleClick
        Try
            Dim columna As Integer
            columna = e.ColumnIndex
            'Obtén el número de la fila que se seleccionó en el Datagridview
            Dim FilaActual As Integer
            FilaActual = DgvDatos.CurrentRow.Index
            Select Case cbFiltro.Text
                Case "Sintomas"
                    txtFiltro.Text = DgvDatos.Rows(FilaActual).Cells(1).Value
                Case "Enfermedades"
                    txtFiltro.Text = DgvDatos.Rows(FilaActual).Cells(1).Value
                Case "Medicos"
                    txtFiltro.Text = DgvDatos.Rows(FilaActual).Cells(0).Value
            End Select
            txtFiltro.Enabled = False
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
        End Try
    End Sub

End Class
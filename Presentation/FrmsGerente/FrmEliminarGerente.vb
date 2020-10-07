Imports Logic

Public Class FrmEliminarGerente

    Private Sub FrmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    Dim borrar As New Sintoma
                    If borrar.BorrarSintoma(txtFiltro.Text) Then MsgBox("Se elimino con exito") Else
                Case "Enfemdedades"
                    Dim borrar As New Enfermedad
                    If borrar.BorrarEnfermedad(txtFiltro.Text) Then MsgBox("Se elimino con exito") Else
                Case "Medicos"
                    Dim borrar As New Medico
                    If borrar.Borrar(txtFiltro.Text) Then MsgBox("Se elimino con exito") Else
            End Select
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
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
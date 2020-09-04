Imports Logic

Public Class FrmModificarGerente

    Private Sub FrmModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sintoma As New Sintoma
        cargarComboBoxSintomas(cbSintoma1)
        cargarComboBoxSintomas(cbSintoma2)
        cargarComboBoxSintomas(cbSintoma3)
        cargarComboBoxSintomas(cbSintoma4)
        cargarComboBoxSintomas(cbSintoma5)
        cargarComboBoxSintomas(cbSintoma6)
        cargarComboBoxSintomas(cbSintoma7)
        cargarComboBoxSintomas(cbSintoma8)
        cargarComboBoxSintomas(cbSintoma9)
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged, ComboBox1.SelectedIndexChanged
        Select Case cbFiltro.Text
            Case "Sintomas"
                PanelModSintoma.Visible = True
                PanelModifMedico.Visible = False
                PanelModEnfermedad.Visible = False
                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
            Case "Medicos"
                PanelModifMedico.Visible = True
                PanelModSintoma.Visible = False
                PanelModEnfermedad.Visible = False
                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
            Case "Enfermedades"
                PanelModEnfermedad.Visible = True
                PanelModSintoma.Visible = False
                PanelModifMedico.Visible = False
                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
        End Select
    End Sub

    Private Sub btnModificar_Paint(sender As Object, e As PaintEventArgs) Handles btnModificar.Paint
        BotonRedondeado(btnModificar)
    End Sub

    Private Sub DgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatos.CellClick
        Dim columna As Integer
        columna = e.ColumnIndex
        Dim FilaActual As Integer
        FilaActual = DgvDatos.CurrentRow.Index

        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    txtNombreSintoma.Text = DgvDatos.Rows(FilaActual).Cells(columna).Value
                Case "Medicos"
                    txtPriNom.Text = DgvDatos.Rows(FilaActual).Cells(columna).Value
                    txtPriApe.Text = DgvDatos.Rows(FilaActual).Cells(columna).Value
                    txtSegNombre.Text = DgvDatos.Rows(FilaActual).Cells(columna).Value
                    txtSApellido.Text = DgvDatos.Rows(FilaActual).Cells(columna).Value

                Case "Enfermedades"
                    txtNombreEnfermedad.Text = DgvDatos.Item(1, FilaActual).Value()
                    cbRiesgo.Text = DgvDatos.Item(2, FilaActual).Value()
                    txtDescripcion.Text = DgvDatos.Item(3, FilaActual).Value()

                    cbSintoma1.Text = DgvDatos.Item(5, FilaActual).Value()
                    cbSintoma2.Text = DgvDatos.Item(6, FilaActual).Value()
                    cbSintoma3.Text = DgvDatos.Item(7, FilaActual).Value()
                    cbSintoma4.Text = DgvDatos.Item(8, FilaActual).Value()
                    cbSintoma5.Text = DgvDatos.Item(9, FilaActual).Value()
                    cbSintoma6.Text = DgvDatos.Item(10, FilaActual).Value()
                    cbSintoma7.Text = DgvDatos.Item(11, FilaActual).Value()
                    cbSintoma8.Text = DgvDatos.Item(12, FilaActual).Value()
                    cbSintoma9.Text = DgvDatos.Item(13, FilaActual).Value()
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    Dim sintoma As New Sintoma(txtNombreSintoma.Text)
                    sintoma.ModificarSintoma()
                Case "Medicos"
                    '.....
                Case "Enfermedades"

                    Dim sintomasComboBox As New ArrayList
                    With sintomasComboBox 'agrego los sintomas de los comboBox a un array
                        .Add(cbSintoma1.Text)
                        .Add(cbSintoma2.Text)
                        .Add(cbSintoma3.Text)
                        .Add(cbSintoma4.Text)
                        .Add(cbSintoma5.Text)
                        .Add(cbSintoma6.Text)
                        .Add(cbSintoma7.Text)
                        .Add(cbSintoma8.Text)
                        .Add(cbSintoma9.Text)
                    End With

                    Dim enfermedad As New Enfermedad(txtNombreEnfermedad.Text, cbRiesgo.Text, txtDescripcion.Text)
                    Dim define As Define
                    Dim sintoma As Sintoma
                    Dim listaSintomas As New List(Of Sintoma)

                    For Each elemet As String In sintomasComboBox
                        'comprobamos los campos vacioss para descartarlos
                        If elemet = "" Then
                            sintomasComboBox.Remove(elemet)
                        Else
                            'creamos distintas instancias de sintoma para gurdarlas en una lista
                            sintoma = New Sintoma(elemet)
                            listaSintomas.Add(sintoma)
                        End If
                    Next

                    define = New Define(enfermedad._nombre, listaSintomas)

                    If enfermedad.ModificarEnfermedad() Then
                        define.ModifDefine(define)
                        MsgBox("Se guardo con exito")
                    Else
                        MsgBox("No se pudo guardar")
                    End If

            End Select
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try
    End Sub

End Class
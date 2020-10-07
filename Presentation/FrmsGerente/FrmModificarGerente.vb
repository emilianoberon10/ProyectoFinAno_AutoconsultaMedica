Imports Logic

Public Class FrmModificarGerente

    Private Sub FrmModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(PanelModSintoma)
        Traductor.traducirPanel(PanelModEnfermedad)
        Traductor.traducirPanel(PanelModifMedico)
        Traductor.traducirPanel(Panel1)

        CargarComboBoxSintomas(cbSintoma1)
        CargarComboBoxSintomas(cbSintoma2)
        CargarComboBoxSintomas(cbSintoma3)
        CargarComboBoxSintomas(cbSintoma4)
        CargarComboBoxSintomas(cbSintoma5)
        CargarComboBoxSintomas(cbSintoma6)
        CargarComboBoxSintomas(cbSintoma7)
        CargarComboBoxSintomas(cbSintoma8)
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged
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
                    'PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,
                    'lugarTrabajo, Tel_cel, Domicilio, sexo, Lun, Mar, Mie, Jue, Vie, Sab, Dom, nombre Especialidad
                    txtPNom.Text = DgvDatos.Item(1, FilaActual).Value()
                    txtSnom.Text = DgvDatos.Item(2, FilaActual).Value()
                    txtPape.Text = DgvDatos.Item(3, FilaActual).Value()
                    txtSape.Text = DgvDatos.Item(4, FilaActual).Value()
                    txtLugarTrabajo.Text = DgvDatos.Item(5, FilaActual).Value()
                    cbEsp.Text = DgvDatos.Item(6, FilaActual).Value()
                    txtTelefono.Text = DgvDatos.Item(7, FilaActual).Value()
                    txtDomicilio.Text = DgvDatos.Item(8, FilaActual).Value()
                    cbSexo.Text = DgvDatos.Item(9, FilaActual).Value()
                    CargarComboBoxEspec(cbEsp)

                    txtHoraEntradaLunes.Text = DgvDatos.Item(10, FilaActual).Value()
                    txtHoraEntradaMartes.Text = DgvDatos.Item(11, FilaActual).Value()
                    txtHoraEntradaMiercoles.Text = DgvDatos.Item(12, FilaActual).Value()
                    txtHoraEntradaJueves.Text = DgvDatos.Item(13, FilaActual).Value()
                    txtHoraEntradaViernes.Text = DgvDatos.Item(14, FilaActual).Value()
                    txtHoraEntradaSabado.Text = DgvDatos.Item(15, FilaActual).Value()
                    txtHoraEntradaDomingo.Text = DgvDatos.Item(16, FilaActual).Value()

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
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    If txtNombreSintoma.Text IsNot "" Then
                        Dim sintoma As New Sintoma(txtNombreSintoma.Text)
                        sintoma.ModificarSintoma()
                    End If
                Case "Medicos"
                    '.....
                Case "Enfermedades"
                    Dim Enfermedad As New Enfermedad(txtNombreEnfermedad.Text, cbRiesgo.Text, txtDescripcion.Text)
                    Dim define As Define
                    Dim sintoma As Sintoma
                    Dim listaSintomas As New List(Of Sintoma)

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
                    End With

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

                    define = New Define(Enfermedad._nombre, listaSintomas)

                    If Enfermedad.ModificarEnfermedad() Then
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

#Region "check horarios"

    Private Sub chkLun_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaLunes.Enabled = True
    End Sub

    Private Sub chkMar_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaMartes.Enabled = True
    End Sub

    Private Sub chkMier_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaMiercoles.Enabled = True
    End Sub

    Private Sub chkJuev_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaJueves.Enabled = True
    End Sub

    Private Sub chkVier_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaViernes.Enabled = True
    End Sub

    Private Sub chkSab_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaSabado.Enabled = True
    End Sub

    Private Sub chkDom_CheckedChanged(sender As Object, e As EventArgs)
        txtHoraEntradaDomingo.Enabled = True
    End Sub

    Private Sub txtHoraEntradaLunes_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "a" Or e.KeyChar = ":")
        If e.KeyChar = ":" And sender.Text.IndexOf(":") > -2 OrElse e.KeyChar = "a" And sender.Text.IndexOf("a") > -1 Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 8 Or e.KeyChar = " " Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

#End Region

End Class
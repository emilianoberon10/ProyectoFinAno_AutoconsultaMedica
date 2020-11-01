Imports Logic

Public Class FrmModificarGerente

    Private Sub FrmModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        Traductor.traducirPanel(PanelModSintoma)
        Traductor.traducirPanel(PanelModEnfermedad)
        Traductor.traducirPanel(PanelModifMedico)
        Traductor.traducirPanel(Panel1)
        cargarCombos()
        txtHoraEntradaLunes.Enabled = False
        txtHoraEntradaMartes.Enabled = False
        txtHoraEntradaMiercoles.Enabled = False
        txtHoraEntradaJueves.Enabled = False
        txtHoraEntradaViernes.Enabled = False
        txtHoraEntradaSabado.Enabled = False
        txtHoraEntradaDomingo.Enabled = False
    End Sub
    Private Sub cargarCombos()
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
                txtNombreSintoma.Focus()
            Case "Medicos"
                PanelModifMedico.Visible = True
                PanelModSintoma.Visible = False
                PanelModEnfermedad.Visible = False
                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                txtCedula.Focus()

            Case "Enfermedades"
                PanelModEnfermedad.Visible = True
                PanelModSintoma.Visible = False
                PanelModifMedico.Visible = False
                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                txtNombreEnfermedad.Focus()

        End Select
    End Sub

    Private Sub DgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatos.CellDoubleClick
        chb1.Checked = False
        chb2.Checked = False
        chb3.Checked = False
        chb4.Checked = False
        chb5.Checked = False
        chb6.Checked = False
        chb7.Checked = False
        chb8.Checked = False

        Dim columna As Integer
        columna = e.ColumnIndex
        Dim FilaActual As Integer
        FilaActual = DgvDatos.CurrentRow.Index

        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    txtIdSint.Text = DgvDatos.Item(0, FilaActual).Value()
                    txtNombreSintoma.Text = DgvDatos.Item(1, FilaActual).Value()
                Case "Medicos"
                    'Cedula, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,edad
                    'lugarTrabajo, Especialidad, Tel_cel, Domicilio, sexo, Lun, Mar, Mie, Jue, Vie, Sab, Dom
                    CargarComboBoxEspec(cbEsp)

                    txtCedula.Text = DgvDatos.Item(0, FilaActual).Value()
                    txtPNom.Text = DgvDatos.Item(1, FilaActual).Value()
                    txtSnom.Text = DgvDatos.Item(2, FilaActual).Value()
                    txtPape.Text = DgvDatos.Item(3, FilaActual).Value()
                    txtSape.Text = DgvDatos.Item(4, FilaActual).Value()
                    txtEdad.Text = DgvDatos.Item(5, FilaActual).Value()
                    txtLugarTrabajo.Text = DgvDatos.Item(6, FilaActual).Value()
                    cbEsp.Text = DgvDatos.Item(7, FilaActual).Value()
                    txtTelefono.Text = DgvDatos.Item(8, FilaActual).Value()
                    txtDomicilio.Text = DgvDatos.Item(9, FilaActual).Value()
                    cbSexo.Text = DgvDatos.Item(10, FilaActual).Value()

                    txtHoraEntradaLunes.Text = DgvDatos.Item(11, FilaActual).Value()
                    txtHoraEntradaMartes.Text = DgvDatos.Item(12, FilaActual).Value()
                    txtHoraEntradaMiercoles.Text = DgvDatos.Item(13, FilaActual).Value()
                    txtHoraEntradaJueves.Text = DgvDatos.Item(14, FilaActual).Value()
                    txtHoraEntradaViernes.Text = DgvDatos.Item(15, FilaActual).Value()
                    txtHoraEntradaSabado.Text = DgvDatos.Item(16, FilaActual).Value()
                    txtHoraEntradaDomingo.Text = DgvDatos.Item(17, FilaActual).Value()

                    If txtHoraEntradaLunes.Text IsNot "" Then chkLun.Checked = True
                    If txtHoraEntradaMartes.Text IsNot "" Then chkMar.Checked = True
                    If txtHoraEntradaMiercoles.Text IsNot "" Then chkMier.Checked = True
                    If txtHoraEntradaJueves.Text IsNot "" Then chkJuev.Checked = True
                    If txtHoraEntradaViernes.Text IsNot "" Then chkVier.Checked = True
                    If txtHoraEntradaSabado.Text IsNot "" Then chkSab.Checked = True
                    If txtHoraEntradaDomingo.Text IsNot "" Then chkDom.Checked = True

                Case "Enfermedades"

                    Dim enf As New Enfermedad(DgvDatos.Item(1, FilaActual).Value())

                    txtNombreEnfermedad.Text = DgvDatos.Item(1, FilaActual).Value()
                    cbRiesgo.Text = DgvDatos.Item(2, FilaActual).Value()
                    txtDescripcion.Text = DgvDatos.Item(3, FilaActual).Value()

                    Dim sintomas As ArrayList = enf.ObtenerSintomasEnfermedades
                    Dim sints(8) As String

                    Dim i As Integer = 0
                    For Each sint As String In sintomas
                        sints(i) = sint
                        i = i + 1
                    Next

                    cbSintoma1.Text = sints.GetValue(0)
                    cbSintoma2.Text = sints.GetValue(1) : If cbSintoma2.Text IsNot "" Then chb1.Checked = True
                    cbSintoma3.Text = sints.GetValue(2) : If cbSintoma3.Text IsNot "" Then chb2.Checked = True
                    cbSintoma4.Text = sints.GetValue(3) : If cbSintoma4.Text IsNot "" Then chb3.Checked = True
                    cbSintoma5.Text = sints.GetValue(4) : If cbSintoma5.Text IsNot "" Then chb4.Checked = True
                    cbSintoma6.Text = sints.GetValue(5) : If cbSintoma6.Text IsNot "" Then chb5.Checked = True
                    cbSintoma7.Text = sints.GetValue(6) : If cbSintoma7.Text IsNot "" Then chb6.Checked = True
                    cbSintoma8.Text = sints.GetValue(7) : If cbSintoma8.Text IsNot "" Then chb7.Checked = True
                    cbSintoma8.Text = sints.GetValue(8) : If cbSintoma9.Text IsNot "" Then chb8.Checked = True

            End Select
        Catch ex As Exception
            GetForm(Estado.Error, ex.Message)
            ErrorProvider1.SetError(modifAclaracion, ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            Select Case cbFiltro.Text
                Case "Sintomas"
                    If txtNombreSintoma.Text IsNot "" Then
                        Dim sintoma As New Sintoma(txtNombreSintoma.Text, txtIdSint.Text)
                        Try
                            If sintoma.ModificarSintoma() Then
                                GetForm(Estado.Ok, "Sintoma modificado con exito")
                                txtIdSint.Text = ""
                                txtNombreSintoma.Text = ""
                            End If
                        Catch ex As Exception
                            General.GetForm(Estado.Error, ex.Message)
                            ErrorProvider1.SetError(modificar, ex.Message)
                        End Try
                    End If
                Case "Medicos"
                    Dim medico As New Medico
                    With medico
                        ._ci = txtCedula.Text
                        ._pNom = txtPNom.Text
                        ._sNom = txtSnom.Text
                        ._pApe = txtPape.Text
                        ._sApe = txtSape.Text
                        ._lugarTrabajo = txtLugarTrabajo.Text
                        ._especialidad = cbEsp.Text
                        ._tel_cel = txtTelefono.Text
                        ._domicilio = txtDomicilio.Text
                        ._sexo = cbSexo.Text
                        ._edad = txtEdad.Text
                    End With
                    Try
                        If medico.Modificar() Then

#Region "comprobar y guardar horarios"

                            If chkLun.Checked AndAlso txtHoraEntradaLunes.Text IsNot "" Then
                                If txtHoraEntradaLunes.Text.Length <= 30 Then
                                    medico._horario = txtHoraEntradaLunes.Text
                                    medico.SetHorario("lun")
                                End If
                            End If
                            If chkMar.Checked AndAlso txtHoraEntradaMartes.Text IsNot "" Then
                                medico._horario = txtHoraEntradaMartes.Text
                                medico.SetHorario("mar")
                            End If
                            If chkMier.Checked AndAlso txtHoraEntradaMiercoles.Text IsNot "" Then
                                medico._horario = txtHoraEntradaMiercoles.Text
                                medico.SetHorario("mie")
                            End If
                            If chkJuev.Checked AndAlso txtHoraEntradaJueves.Text IsNot "" Then
                                medico._horario = txtHoraEntradaJueves.Text
                                medico.SetHorario("jue")
                            End If
                            If chkVier.Checked AndAlso txtHoraEntradaViernes.Text IsNot "" Then
                                medico._horario = txtHoraEntradaViernes.Text
                                medico.SetHorario("vie")
                            End If
                            If chkSab.Checked AndAlso txtHoraEntradaSabado.Text IsNot "" Then
                                medico._horario = txtHoraEntradaSabado.Text
                                medico.SetHorario("sab")
                            End If
                            If chkDom.Checked AndAlso txtHoraEntradaDomingo.Text IsNot "" Then
                                medico._horario = txtHoraEntradaDomingo.Text
                                medico.SetHorario("dom")
                            End If

#End Region

                            General.GetForm(Estado.Ok, "Se modifico con exito")
                            DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                            txtCedula.Text = ""
                            cbEsp.Text = ""
                            txtLugarTrabajo.Text = ""
                            txtPNom.Text = ""
                            txtPape.Text = ""
                            txtSnom.Text = ""
                            txtSape.Text = ""
                            txtTelefono.Text = ""
                            txtDomicilio.Text = ""
                            cbSexo.Text = ""
                            txtEdad.Text = ""
                            txtHoraEntradaLunes.Text = ""
                            txtHoraEntradaMartes.Text = ""
                            txtHoraEntradaMiercoles.Text = ""
                            txtHoraEntradaJueves.Text = ""
                            txtHoraEntradaViernes.Text = ""
                            txtHoraEntradaSabado.Text = ""
                            txtHoraEntradaDomingo.Text = ""
                            chkLun.CheckState = False
                            chkMar.CheckState = False
                            chkMier.CheckState = False
                            chkJuev.CheckState = False
                            chkVier.CheckState = False
                            chkSab.CheckState = False
                            chkDom.CheckState = False
                        Else
                            General.GetForm(Estado.Error, "No se pudo modificar")
                        End If

                    Catch ex As Exception
                        General.GetForm(Estado.Error, ex.Message)
                        ErrorProvider1.SetError(modificar, ex.Message)

                    End Try


                Case "Enfermedades"

                    Dim enfermedad As New Enfermedad(txtNombreEnfermedad.Text, cbRiesgo.Text, txtDescripcion.Text)
                    enfermedad.ComprobarRiesgo()
                    Dim define As Define
                    Dim sintomasComboBox As New ArrayList
                    Dim sintomas As ArrayList = enfermedad.ObtenerSintomasEnfermedades
                    Dim sints(sintomas.Count) As String

                    With sintomasComboBox 'agrego los sintomas de los comboBox a un array
                        If cbSintoma1.Enabled = True Then .Add(cbSintoma1.Text)
                        If cbSintoma2.Enabled = True Then .Add(cbSintoma2.Text)
                        If cbSintoma3.Enabled = True Then .Add(cbSintoma3.Text)
                        If cbSintoma4.Enabled = True Then .Add(cbSintoma4.Text)
                        If cbSintoma5.Enabled = True Then .Add(cbSintoma5.Text)
                        If cbSintoma6.Enabled = True Then .Add(cbSintoma6.Text)
                        If cbSintoma7.Enabled = True Then .Add(cbSintoma7.Text)
                        If cbSintoma8.Enabled = True Then .Add(cbSintoma8.Text)
                        If cbSintoma9.Enabled = True Then .Add(cbSintoma9.Text)
                    End With


                    Dim i As Integer = 0
                    For Each sint As String In sintomas
                        sints(i) = sint
                        i = i + 1
                    Next

                    define = New Define(enfermedad._nombre, sintomasComboBox)

                    Try
                        If enfermedad.ModificarEnfermedad() Then
                            If define.ModifDefine(sints) Then
                                GetForm(Estado.Ok, "Enfermedad modificado con exito")
                                cargarCombos()
                                txtNombreEnfermedad.Text = ""
                                txtDescripcion.Text = ""
                                cbRiesgo.Text = ""
                                DgvDatos.DataSource = CargarDataGrid(cbFiltro.Text)
                            End If
                        Else
                            GetForm(Estado.Error, "No se pudo modificar")
                        End If

                    Catch ex As Exception
                        GetForm(Estado.Error, ex.Message)
                        ErrorProvider1.SetError(modificar, ex.Message)

                    End Try

            End Select
        Catch ex As Exception
            ErrorProvider1.SetError(modificar, "Ocurrio un error inesperado " & ex.Message)
        End Try
    End Sub

#Region "check horarios"

    Private Sub chkLun_CheckedChanged(sender As Object, e As EventArgs) Handles chkLun.CheckedChanged
        If chkLun.Checked Then
            txtHoraEntradaLunes.Enabled = True
        Else
            txtHoraEntradaLunes.Enabled = False
        End If

    End Sub

    Private Sub chkMar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMar.CheckedChanged
        If chkMar.Checked Then
            txtHoraEntradaMartes.Enabled = True
        Else
            txtHoraEntradaMartes.Enabled = False
        End If

    End Sub

    Private Sub chkMier_CheckedChanged(sender As Object, e As EventArgs) Handles chkMier.CheckedChanged
        If chkMier.Checked Then
            txtHoraEntradaMiercoles.Enabled = True
        Else
            txtHoraEntradaMiercoles.Enabled = False
        End If
    End Sub

    Private Sub chkJuev_CheckedChanged(sender As Object, e As EventArgs) Handles chkJuev.CheckedChanged

        If chkJuev.Checked Then
            txtHoraEntradaJueves.Enabled = True
        Else
            txtHoraEntradaJueves.Enabled = False
        End If
    End Sub

    Private Sub chkVier_CheckedChanged(sender As Object, e As EventArgs) Handles chkVier.CheckedChanged

        If chkVier.Checked Then
            txtHoraEntradaViernes.Enabled = True
        Else
            txtHoraEntradaViernes.Enabled = False
        End If
    End Sub

    Private Sub chkSab_CheckedChanged(sender As Object, e As EventArgs) Handles chkSab.CheckedChanged

        If chkSab.Checked Then
            txtHoraEntradaSabado.Enabled = True
        Else
            txtHoraEntradaSabado.Enabled = False
        End If
    End Sub

    Private Sub chkDom_CheckedChanged(sender As Object, e As EventArgs) Handles chkDom.CheckedChanged

        If chkDom.Checked Then
            txtHoraEntradaDomingo.Enabled = True
        Else
            txtHoraEntradaDomingo.Enabled = False
        End If
    End Sub

#End Region
#Region "Activar sintomas"

    Private Sub chb1_CheckedChanged(sender As Object, e As EventArgs) Handles chb1.CheckedChanged
        If chb1.Checked Then
            cbSintoma2.Enabled = True
        Else
            cbSintoma2.Enabled = False
        End If
    End Sub

    Private Sub chb2_CheckedChanged(sender As Object, e As EventArgs) Handles chb2.CheckedChanged
        If chb2.Checked Then
            cbSintoma3.Enabled = True
        Else
            cbSintoma3.Enabled = False
        End If
    End Sub

    Private Sub chb3_CheckedChanged(sender As Object, e As EventArgs) Handles chb3.CheckedChanged
        If chb3.Checked Then
            cbSintoma4.Enabled = True
        Else
            cbSintoma4.Enabled = False
        End If
    End Sub

    Private Sub chb4_CheckedChanged(sender As Object, e As EventArgs) Handles chb4.CheckedChanged
        cbSintoma5.Enabled = True
        If chb4.Checked Then
            cbSintoma5.Enabled = True
        Else
            cbSintoma5.Enabled = False
        End If
    End Sub

    Private Sub chb5_CheckedChanged(sender As Object, e As EventArgs) Handles chb5.CheckedChanged
        If chb5.Checked Then
            cbSintoma6.Enabled = True
        Else
            cbSintoma6.Enabled = False
        End If
    End Sub

    Private Sub chb6_CheckedChanged(sender As Object, e As EventArgs) Handles chb6.CheckedChanged
        If chb6.Checked Then
            cbSintoma7.Enabled = True
        Else
            cbSintoma7.Enabled = False
        End If
    End Sub

    Private Sub chb7_CheckedChanged(sender As Object, e As EventArgs) Handles chb7.CheckedChanged
        If chb7.Checked Then
            cbSintoma8.Enabled = True
        Else
            cbSintoma8.Enabled = False
        End If
    End Sub

    Private Sub chb8_CheckedChanged(sender As Object, e As EventArgs) Handles chb8.CheckedChanged
        If chb8.Checked Then
            cbSintoma9.Enabled = True
        Else
            cbSintoma9.Enabled = False
        End If
    End Sub


#End Region
    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress, txtTelefono.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
        If Asc(e.KeyChar) = 8 Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub
    Private Sub txtHoraEntradaLunes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraEntradaViernes.KeyPress, txtHoraEntradaSabado.KeyPress, txtHoraEntradaMiercoles.KeyPress, txtHoraEntradaMartes.KeyPress, txtHoraEntradaLunes.KeyPress, txtHoraEntradaJueves.KeyPress, txtHoraEntradaDomingo.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "a" Or e.KeyChar = ":")
        If e.KeyChar = ":" And sender.Text.IndexOf(":") > -2 OrElse e.KeyChar = "a" And sender.Text.IndexOf("a") > -1 Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 8 Or e.KeyChar = " " Then
            e.Handled = Char.IsDigit(e.KeyChar)
        End If
    End Sub

    Private Sub Textos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtSnom.KeyPress, txtSape.KeyPress, txtPNom.KeyPress, txtPape.KeyPress, txtLugarTrabajo.KeyPress, txtEdad.KeyPress, txtDomicilio.KeyPress, txtCedula.KeyPress, txtDescripcion.KeyPress, txtNombreEnfermedad.KeyPress

        DesecharCaracteresEspeciales(e)
        txtCedula.MaxLength = 8
        txtEdad.MaxLength = 3
        txtTelefono.MaxLength = 9
        txtPNom.MaxLength = 30
        txtPape.MaxLength = 30
        txtSnom.MaxLength = 30
        txtSape.MaxLength = 30
        txtNombreEnfermedad.MaxLength = 30
        txtLugarTrabajo.MaxLength = 30
        txtDescripcion.MaxLength = 255
        txtDomicilio.MaxLength = 255
    End Sub


End Class
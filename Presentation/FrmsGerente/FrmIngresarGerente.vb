Imports Logic

Public Class FrmIngresarGerente

    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sintoma As New Sintoma()
        CargarComboBoxSintomas(cbSintoma1)
        CargarComboBoxSintomas(cbSintoma2)
        CargarComboBoxSintomas(cbSintoma3)
        CargarComboBoxSintomas(cbSintoma4)
        CargarComboBoxSintomas(cbSintoma5)
        CargarComboBoxSintomas(cbSintoma6)
        CargarComboBoxSintomas(cbSintoma7)
        CargarComboBoxSintomas(cbSintoma8)
    End Sub

    Private Sub btnIngresarSintoma_Click(sender As Object, e As EventArgs) Handles btnIngresarSintoma.Click
        ErrorProviderNomSint.Clear()
        Dim sintoma As Sintoma
        Dim sintomaIngresar As String = txtNombreSintoma.Text
        If sintomaIngresar = "" Then
            ErrorProviderNomSint.SetError(lbNomSint, "Debe ingresar un nombre de enfermedad")
            General.GetForm(Estado.Error, "Debe ingresar un nombre de enfermedad")
        Else

            sintoma = New Sintoma(sintomaIngresar)

            If sintoma.GuardarSintomas() Then
                General.GetForm(Estado.Error, "Ya existe ese sintoma")
                ErrorProviderNomSint.Clear()
            Else
                General.GetForm(Estado.Ok, "Se guardo con exito")
                ErrorProviderNomSint.Clear()
                txtNombreSintoma.Text = ""
            End If

        End If

    End Sub

    Private Sub btnIngresarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnIngresarEnfermedad.Click
        Dim enfermedad As Enfermedad
        Dim sintoma As Sintoma
        Dim define As Define
        Dim listaSintomas As New List(Of Sintoma)
        Dim enfermedadIngresar As String = txtNombreEnfermedad.Text
        Dim riesgo As String = cbRiesgo.Text
        Dim descripcion As String = txtDescripcion.Text
        'array para guardar los sintomas de una enf
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

        'recorro el array de sintomas
        For Each elemet As String In sintomasComboBox
            'comprobamos los campos vacioss para descartarlos
            If elemet = "" Then
                sintomasComboBox.Remove(elemet)
            Else
                sintoma = New Sintoma(elemet)
                listaSintomas.Add(sintoma)
            End If
        Next

        If enfermedadIngresar = "" Or riesgo = "Riesgo" Or descripcion = "Descripcion" Then
            ErrorProviderNomDesEnf.SetError(lbNomEnf, "Los campos Nombre, Riesgo y Descripcion son obligatorios")
            General.GetForm(Estado.Error, "Los campos Nombre, Riesgo y Descripcion son obligatorios")

        ElseIf listaSintomas.Count = 0 Then
            ErrorProviderSintEnf.SetError(lbNomEnf, "Debe seleccionar al menos 2 sintomas")
            General.GetForm(Estado.Error, "Los campos Nombre, Riesgo y Descripcion son obligatoriosSe guardo con exito")
        Else
            enfermedad = New Enfermedad(enfermedadIngresar, riesgo, descripcion)
            enfermedad.ComprobarRiesgo()

            'lista de sintomas que definen una enfermedad
            define = New Define(enfermedad._nombre, listaSintomas)

            If enfermedad.GuardarEnfermedad() Then
                General.GetForm(Estado.Error, "Ya existe esa enfermedad")
            Else
                define.GuardarDefine(define)
                General.GetForm(Estado.Ok, "Se guardo con exito")
            End If
        End If
    End Sub

#Region "Estilos"

    Private Sub btnIngresarSintoma_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresarSintoma.Paint, btnIngresarEnfermedad.Paint
        BotonRedondeado(btnIngresarEnfermedad)
        BotonRedondeado(btnIngresarSintoma)
    End Sub

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

#End Region

End Class
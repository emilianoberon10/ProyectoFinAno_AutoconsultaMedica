Imports System.IO
Imports Logic

Public Class FrmIngresarGerente

    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)

        CargarComboBoxSintomas(cbSintoma1)
        CargarComboBoxSintomas(cbSintoma2)
        CargarComboBoxSintomas(cbSintoma3)
        CargarComboBoxSintomas(cbSintoma4)
        CargarComboBoxSintomas(cbSintoma5)
        CargarComboBoxSintomas(cbSintoma6)
        CargarComboBoxSintomas(cbSintoma7)
        CargarComboBoxSintomas(cbSintoma8)
        CargarComboBoxSintomas(comboSintoma9)
    End Sub

    Private Sub btnIngresarSintoma_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
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

    Private Sub btnIngresarEnfermedad_Click(sender As Object, e As EventArgs) Handles btn_ingresar2.Click
        Dim enfermedad As Enfermedad
        Dim define As Define

        Dim enfermedadIngresar As String = txtNombreEnfermedad.Text
        Dim riesgo As String = cbRiesgo.Text
        Dim descripcion As String = txtDescripcion.Text
        'array para guardar los sintomas de una enf
        Dim sintomasComboBox As New ArrayList



        If ComprobarCamposEnf() Then
            ErrorProviderNomDesEnf.SetError(lbNomEnf, "Los campos Nombre, Riesgo y Descripcion son obligatorios")
            General.GetForm(Estado.Error, "Los campos Nombre, Riesgo y Descripcion son obligatorios")
        Else
            If cbSintoma1.Enabled = True Then sintomasComboBox.Add(cbSintoma1.Text)
            If cbSintoma2.Enabled = True Then sintomasComboBox.Add(cbSintoma2.Text)
            If cbSintoma3.Enabled = True Then sintomasComboBox.Add(cbSintoma3.Text)
            If cbSintoma4.Enabled = True Then sintomasComboBox.Add(cbSintoma4.Text)
            If cbSintoma5.Enabled = True Then sintomasComboBox.Add(cbSintoma5.Text)
            If cbSintoma6.Enabled = True Then sintomasComboBox.Add(cbSintoma6.Text)
            If cbSintoma7.Enabled = True Then sintomasComboBox.Add(cbSintoma7.Text)
            If cbSintoma8.Enabled = True Then sintomasComboBox.Add(cbSintoma8.Text)
            If comboSintoma9.Enabled = True Then sintomasComboBox.Add(comboSintoma9.Text)

            If sintomasComboBox.Count = 0 Then
                ErrorProviderNomDesEnf.SetError(lbNomEnf, "Debe seleccionar al menos un sintoma")
                General.GetForm(Estado.Error, "Debe seleccionar al menos un sintoma")
            ElseIf sintomasComboBox.Count > 0 Then

                enfermedad = New Enfermedad(enfermedadIngresar, riesgo, descripcion)
                enfermedad.ComprobarRiesgo()

                'lista de sintomas que definen una enfermedad
                define = New Define(enfermedad._nombre, sintomasComboBox)

                Try
                    If enfermedad.GuardarEnfermedad() Then
                        General.GetForm(Estado.Error, "Ya existe esa enfermedad")
                    Else
                        If define.GuardarDefine() Then
                            General.GetForm(Estado.Ok, "Se guardo con exito")
                            txtNombreEnfermedad.Text = ""
                            txtDescripcion.Text = ""
                            cbSintoma1.Enabled = False
                            cbSintoma2.Enabled = False
                            cbSintoma3.Enabled = False
                            cbSintoma4.Enabled = False
                            cbSintoma5.Enabled = False
                            cbSintoma6.Enabled = False
                            cbSintoma7.Enabled = False
                            cbSintoma8.Enabled = False
                        Else
                            General.GetForm(Estado.Error, "No se pudo guardar")
                        End If
                    End If
                Catch ex As Exception
                    ErrorProviderNomDesEnf.SetError(lbNomEnf, ex.Message)
                    General.GetForm(Estado.Error, ex.Message)
                End Try

            End If
        End If
    End Sub
    Private Function ComprobarCamposEnf() As Boolean
        If txtNombreEnfermedad.Text Is "" Or cbRiesgo.Text Is "Riesgo" Or txtDescripcion.Text Is "" Then
            Return True
        Else
            Return False
        End If
    End Function

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

    Private Sub chb8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If chb8.Checked Then
            cbSintoma9.Enabled = True
        Else
            cbSintoma9.Enabled = False
        End If
    End Sub


#End Region
    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreSintoma.KeyPress, txtNombreEnfermedad.KeyPress, txtDescripcion.KeyPress
        DesecharCaracteresEspeciales(e)
        txtNombreEnfermedad.MaxLength = 30
        txtNombreSintoma.MaxLength = 30
        txtDescripcion.MaxLength = 255
    End Sub

    Private Sub llbCargarExcel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCargarExcel.LinkClicked
        'OpenFileDialog1.Title = "Open CSV File"
        'OpenFileDialog1.Filter = "CSV Files (L*.csv)|*.csv"

        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

        '    If File.Exists(OpenFileDialog1.FileName) Then

        '        Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(OpenFileDialog1.FileName)
        '        Dim CurrentRecord As String() ' this array will hold each line of data
        '        'Tell the parser we are using delimited text file
        '        afile.TextFieldType = FileIO.FieldType.Delimited
        '        'Tell Parser how we will delimit
        '        afile.Delimiters = New String() {","}
        '        'For this example field will be enclosed in quotes i.e. "MyEntry","MyEntry2"
        '        afile.HasFieldsEnclosedInQuotes = True

        '        Do Until afile.EndOfData
        '            Try
        '                CurrentRecord = afile.ReadFields
        '                'Now we have our line in an array CurrentRecord 
        '                'Do what we wish with it
        '                MsgBox(CurrentRecord.ToString)

        '            Catch ex As FileIO.MalformedLineException
        '                MsgBox("Malformed Text")
        '                Exit Do
        '            End Try

        '        Loop

        '    Else
        '        MsgBox("File does not exist")
        '    End If
        'End If
    End Sub
End Class
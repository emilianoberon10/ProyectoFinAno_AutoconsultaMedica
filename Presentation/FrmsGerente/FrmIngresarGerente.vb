Imports Logic

Public Class FrmIngresarGerente

    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sintoma As New Sintoma()
        cargarComboBoxSintomas(cbSintoma1)
        cargarComboBoxSintomas(cbSintoma2)
        cargarComboBoxSintomas(cbSintoma3)
        cargarComboBoxSintomas(cbSintoma4)
        cargarComboBoxSintomas(cbSintoma5)
        cargarComboBoxSintomas(cbSintoma6)
        cargarComboBoxSintomas(cbSintoma7)
        cargarComboBoxSintomas(cbSintoma8)
    End Sub

    Private Sub btnIngresarSintoma_Click(sender As Object, e As EventArgs) Handles btnIngresarSintoma.Click
        Dim sintoma As Sintoma
        Dim sintomaIngresar As String = txtNombreSintoma.Text

        'guardo el nombre del sintoma en una instacia
        'para no tener que pasarlo por parametro
        sintoma = New Sintoma(sintomaIngresar)

        If sintoma.GuardarSintomas() Then
            MsgBox("Ya existe ese sintoma")
        Else
            MsgBox("Se guardo con exito")
        End If

    End Sub

    Private Sub btnIngresarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnIngresarEnfermedad.Click

        Dim enfermedadIngresar As String = txtNombreEnfermedad.Text
        Dim riesgo As String = cbRiesgo.Text
        Dim descripcion As String = txtDescripcion.Text
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

        Dim enfermedad As Enfermedad
        Dim define As Define
        Dim sintoma As Sintoma
        Dim listaSintomas As New List(Of Sintoma)

        For Each elemet As String In sintomasComboBox
            'comprobamos los campos vacioss para descartarlos
            If elemet = "" Then
                sintomasComboBox.Remove(elemet)
            Else
                'cremos distintas instancias de sintoma para gurdarlas en una lista
                sintoma = New Sintoma(elemet)
                listaSintomas.Add(sintoma)
            End If
        Next

        If enfermedadIngresar = "Nombre" Or riesgo = "Riesgo" Or descripcion = "Descripcion" Or listaSintomas.Count = 0 Then
            MsgBox("Los campos Nombre, Riesgo y Descripcion son obligatorios")
        Else
            'guardo el nombre del sintoma en una instacia
            'para no tener que pasarlo por parametro
            enfermedad = New Enfermedad(enfermedadIngresar, riesgo, descripcion)
            enfermedad.ComprobarRiesgo()

            'lista de sintomas que definen una enfermedad
            define = New Define(enfermedad._nombre, listaSintomas)

            If enfermedad.GuardarEnfermedad() Then
                MsgBox("Ya existe esa enfermedad")
            Else
                define.GuardarDefine(define)
                MsgBox("Se guardo con exito")
            End If
        End If
    End Sub

#Region "Estilos"

    Private Sub btnIngresarSintoma_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresarSintoma.Paint, btnIngresarEnfermedad.Paint
        BotonRedondeado(btnIngresarEnfermedad)
        BotonRedondeado(btnIngresarSintoma)
    End Sub

    'Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtNombreEnfermedad.Enter, txtDescripcion.Enter
    '    txtNombreEnfermedad.Text = ""
    '    txtNombreEnfermedad.ForeColor = Color.FromArgb(240, 240, 240)
    'End Sub
    'Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtNombreSintoma.Enter
    '    txtNombreSintoma.Text = ""
    '    txtNombreSintoma.ForeColor = Color.FromArgb(240, 240, 240)
    'End Sub
    'Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtNombreSintoma.Leave, txtNombreEnfermedad.Leave, txtDescripcion.Leave
    '    txtNombreSintoma.Text = "Nombre"
    '    txtNombreSintoma.ForeColor = Color.FromArgb(240, 240, 240)
    '    txtNombreEnfermedad.Text = "Nombre"
    '    txtNombreEnfermedad.ForeColor = Color.FromArgb(240, 240, 240)
    'End Sub

#End Region

End Class
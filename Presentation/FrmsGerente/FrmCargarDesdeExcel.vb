Imports Logic
Imports Microsoft.VisualBasic.FileIO

Public Class FrmCargarDesdeExcel

    Private Sub FrmCargarDesdeExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
    End Sub

    Private Sub btn_cargarExcel_Click(sender As Object, e As EventArgs) Handles btn_cargarExcel.Click
        SeleccionarArchivo()
    End Sub

    'Private Sub ImportarExcel_a_DataGridView()

    '    Dim iRow As Integer = 2
    '    Dim lsSintoma As New List(Of Sintoma)

    '    OpenFileDialog1.FileName = ""
    '    OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
    '    OpenFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

    '    If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        DataGridView1.Columns.Clear()

    '        Dim ruta_archivo As String = "C:\Users\GaaraXz\Documents\sintomas.xlsx"
    '        Try
    '            Dim sl As New SLDocument(ruta_archivo)

    '            While String.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1))
    '                Dim sintoma As New Sintoma
    '                sintoma._id = sl.GetCellValueAsString(iRow, 1)
    '                sintoma._nombre = sl.GetCellValueAsString(iRow, 2)

    '                lsSintoma.Add(sintoma)

    '                iRow += 1
    '            End While
    '        Catch ex As Exception
    '            MsgBox("ERROR:" & vbNewLine & ex.Message)
    '        End Try

    '    End If

    '    DataGridView1.DataSource = lsSintoma

    'End Sub

    Private rutaDoc As String
    Private Sub SeleccionarArchivo()
        ' Muestra un cuadro de dialogo para que seleccione el archivo
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.FileName = ""
        openFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv"

        openFileDialog1.FilterIndex = 2
        If cbFiltro.Text = "" Then
            MsgBox("Seleccione un filtro por favor")
        Else
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try

                    rutaDoc = openFileDialog1.FileName
                    If almacenarDatos() Then
                        MessageBox.Show("Documento cargado correctamente.")
                    Else
                        MessageBox.Show("EL documento no se pudo guardar")
                    End If
                Catch Ex As Exception
                    MessageBox.Show("No se pudo cargar el archivo. Error: " & Ex.Message)
                End Try
            End If
        End If
    End Sub

    Dim man As New Sintoma


    Private Function almacenarDatos() As Boolean
        Dim res As Boolean
        Dim filtro As String = cbFiltro.Text
        Dim tf As New TextFieldParser(rutaDoc)

        tf.TextFieldType = FileIO.FieldType.Delimited
        tf.SetDelimiters(";")

        Try
            Select Case filtro
                Case "Sintomas"
                    res = guardarSintoma(tf)
                Case "Enfermedades"
                    res = guardarEnfermedad(tf)
                Case "Medicos"
                    res = guardarMedico(tf)
                Case ""
                    MsgBox("Seleccione un filtro por favor")
            End Select
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
            res = False
        End Try
        Return res
    End Function
    Public Function guardarSintoma(tf) As Boolean
        Dim lst As New List(Of Sintoma)
        Dim res As Boolean = False
        Dim sintoma As Sintoma

        Try
            tf.ReadFields() ' salto el encabezado
            While Not tf.EndOfData

                Dim field = tf.ReadFields()

                sintoma = New Sintoma
                With sintoma
                    ._nombre = (field(0))
                    .GuardarSintomas()
                End With

                lst.Add(sintoma)
                res = True

            End While

        Catch ex As MalformedLineException
            MessageBox.Show("Error " & vbNewLine & ex.Message)
            res = False
        End Try

        DataGridView1.DataSource = lst
        Return res
    End Function
    Public Function guardarEnfermedad(tf) As Boolean
        Dim res As Boolean = False
        Dim arr As ArrayList
        Dim lst As New List(Of Enfermedad)
        Dim enf As Enfermedad
        Dim define As Define

        Try
            tf.ReadFields()
            While Not tf.EndOfData

                Dim field = tf.ReadFields()
                enf = New Enfermedad
                define = New Define
                arr = New ArrayList
                arr.Add(field(4))
                With enf
                    ._nombre = (field(0))
                    ._riesgo = (field(1))
                    ._descripcion = (field(2))
                End With
                lst.Add(enf)

                With define
                    ._enfermedad = (field(3))
                    ._sintomas = arr
                End With

                ' guardamos la enfermedad con sus sintomas relacionados
                enf.GuardarEnfermedad()
                define.GuardarDefine()

                arr.Clear()
                res = True

            End While

        Catch ex As MalformedLineException
            MessageBox.Show("Error " & vbNewLine & ex.Message)
        res = False
        End Try

        DataGridView1.DataSource = lst
        Return res
    End Function
    Public Function guardarMedico(tf) As Boolean
        Dim lst As New List(Of Medico)
        Dim res As Boolean = False
        Dim med As Medico

        tf.ReadFields()
        While Not tf.EndOfData
            Dim field = tf.ReadFields()
            Try
                med = New Medico
                With med
                    ._ci = field(0)
                    ._numMed = Convert.ToInt32(field(1).ToString)
                    ._especialidad = field(2)
                    ._lugarTrabajo = field(10)
                    ._contraseña = MetodosCompartidos.EncriptarContraseña(field(11))
                    ._edad = Convert.ToInt32(field(12).ToString)
                    ._sexo = field(13)
                    ._pNom = field(14)
                    ._pApe = field(15)
                    ._sNom = field(16)
                    ._sApe = field(17)
                    ._domicilio = field(18)
                    ._tel_cel = Convert.ToInt32(field(19).ToString)

                    .Guardar()

                    ._horario = field(3) : .SetHorario("lun")
                    ._horario = field(4) : .SetHorario("mar")
                    ._horario = field(5) : .SetHorario("mie")
                    ._horario = field(6) : .SetHorario("jue")
                    ._horario = field(7) : .SetHorario("vie")
                    ._horario = field(8) : .SetHorario("sab")
                    ._horario = field(9) : .SetHorario("dom")

                End With

                lst.Add(med)
                res = True

            Catch ex As MalformedLineException
                MessageBox.Show("Error " & vbNewLine & ex.Message)
                res = False
            End Try

        End While
        DataGridView1.DataSource = lst
        Return res
    End Function

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged
        Dim filtro As String = cbFiltro.Text

        Select Case filtro
            Case "Sintomas"
                MsgBox("Las columnas del archivo deben ser: " & vbNewLine & "nombre")
            Case "Enfermedades"
                MsgBox("Las columnas del archivo deben ser: " & vbNewLine & " idEnf| nombre | riesgo | descripcion | nomEnf | idSint" & vbNewLine & "idSint debe ser el nombre del sintoma")

            Case "Medicos"
                MsgBox("Las columnas del archivo deben ser: " & vbNewLine & "| ciM | numMed | idspecialidad | lun | mar | mie | jue | vie | sab | dom | lugarTrabajo | contrasena | pnom | snom | pape | sape | domicilio | tel_cel | " & vbNewLine & "especialidad debe ser el numero de id, los horarios(lun,mar,etc) deben tener el fortmato de, 09:15 a 17:20 por ejemplo")
            Case ""
        End Select
    End Sub
End Class
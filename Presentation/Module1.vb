Imports System.Drawing.Drawing2D
Imports Logic

Module Module1

    Public Sub BotonRedondeado(btn As Button)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn.ClientRectangle
        myRectangle.Inflate(0, 60)
        buttonPath.AddEllipse(myRectangle)
        btn.Region = New Region(buttonPath)
    End Sub

    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form, PanelChildForm As Panel)
        Dim currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Function CargarDataGrid(filtro As String) As DataTable

        Select Case filtro
            Case "Sintomas"
                Dim grid As New Sintoma
                Return grid.ObtenerSintomas()
            Case "Enfermedades"
                Dim grid As New Enfermedad
                Return grid.ObtenerEnfermedades()
            Case "Medicos"
                Dim grid As New Medico
                Return grid.Listar()
            Case ""
                MsgBox("Debe seleccionar")
        End Select

    End Function

    Public Sub CargarComboBoxSintomas(cb As ComboBox)
        Dim sinObt As New Sintoma
        With cb
            .DataSource = sinObt.DevolverSintomaComboBox.Tables(0)
            .DisplayMember = "nombre" 'elnombre de tu columna de tu base de datos q deseas mostrar
            .ValueMember = "id" 'el id de tu tabla relacionada con el nombre que muestras muy importante para saber el ide de quien seleccionas en tu combobox
            .Text = "SINTOMA"
        End With

    End Sub

    Public Function ConfirmarLogin(ci As String, pass As String)
        Dim log As New Login
        Select Case log.confirmarLog(ci, pass)
            Case "Paciente"
                Return "Paciente"
            Case "Gerente"
                Return "Gerente"
            Case "Medico"
                Return "Medico"
        End Select
    End Function

End Module
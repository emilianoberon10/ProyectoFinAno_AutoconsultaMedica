Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Logic

Module MetodosCompartidos

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
        childForm.FormBorderStyle = FormBorderStyle.None 'form hijo sin bordes
        childForm.Dock = DockStyle.Fill 'para que el form hijo ocupe todo su espacio
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm

        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Function CargarDataGrid(filtro As String) As DataTable
        'Cargar dataGrid segun filtro para ventanas de gerente
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
                MsgBox("Debe seleccionar un filtro")
        End Select

    End Function

#Region "cargarCombos"

    Public Sub CargarComboBoxSintomas(cb As ComboBox)
        Dim sinObt As New Sintoma
        With cb
            .DataSource = sinObt.DevolverSintomaComboBox.Tables(0)
            .DisplayMember = "nombre" 'elnombre de tu columna de tu base de datos q deseas mostrar
            .ValueMember = "id" 'el id de tu tabla relacionada con el nombre que muestras muy importante para saber el ide de quien seleccionas en tu combobox
            .Text = "SINTOMA"
        End With

    End Sub

    Public Sub CargarComboBoxEspec(cb As ComboBox)
        Dim med As New Medico
        With cb
            .DataSource = med.comboEspec.Tables(0)
            .DisplayMember = "nombre" 'elnombre de tu columna de tu base de datos q deseas mostrar
            .ValueMember = "id" 'el id de tu tabla relacionada con el nombre que muestras muy importante para saber el ide de quien seleccionas en tu combobox
        End With

    End Sub

#End Region

#Region "imagenes"

    Public Sub GuardarImagen(ci As String, ofdFoto As FileDialog, fotoPerfil As PictureBox)
        Dim foto As String
        ofdFoto.Filter = "JPG|*.jpg|PNG|*.png" 'filtro de archivos
        ofdFoto.FileName = "Cargar foto de perfil" 'nombre del archivo
        ofdFoto.Title = "SUBIR ARCHIVO" 'titulo de la ventana

        If ofdFoto.ShowDialog = Windows.Forms.DialogResult.OK Then

            foto = ofdFoto.FileName
            fotoPerfil.Image = Image.FromFile(foto) 'guardo la foto seleccionada en un pictureBox

            Using ms As New MemoryStream()
                'convierto a base 64
                fotoPerfil.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                Dim obyte = ms.ToArray()
                Dim imagen64 As String = Convert.ToBase64String(obyte)

                'guardo la imagen en base 64 en la bd
                Dim img As New fotoPerfil(ci, imagen64)
                If img.Guardar() Then
                    General.GetForm(Estado.Ok, "Imagen guardada con exito")
                Else
                    General.GetForm(Estado.Critical, "No se puedo guardar la imagen")
                End If
            End Using
        End If

    End Sub

    Public Function ObtenerImagen(ci) As Image
        Dim imagen64 As String = ""
        Dim img As New fotoPerfil(ci)
        Try
            imagen64 = img.Obtener

            If imagen64 = "No se encontro imagen" Then
                General.GetForm(Estado.Error, "No se encotro una imagen cargada")
                Return My.Resources.profileEmpty
            Else
                'transformo de base 64 a byteArray
                Dim byteArray = Convert.FromBase64String(imagen64)
                'transformo el byteArray a imagen
                Dim mas As MemoryStream = New MemoryStream(byteArray)
                Dim image = Drawing.Image.FromStream(mas)

                Return image

            End If
        Catch ex As Exception
            General.GetForm(Estado.Critical, ex.Message)
        End Try
    End Function

#End Region

    Public Function EncriptarContraseña(strg) As String

        Dim sha256 As SHA256 = SHA256.Create() 'creo una instancia de la clase SHA256Managed
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(strg) 'transformo mi string en una cadena de bytes
        Dim hash As Byte() = sha256.ComputeHash(bytes) 'creo un hash(cadena con una longitud fija) de 256 bytes apartir de mi array anterior
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2")) 'represento en forma de String de un dato asociado a una variable primitiva( mi array de bytes )
        Next

        Return stringBuilder.ToString()
    End Function

    Public Sub DesecharCaracteresEspeciales(e As KeyPressEventArgs)
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then

            MessageBox.Show("Se ha tecleado un carácter especial.")

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

End Module
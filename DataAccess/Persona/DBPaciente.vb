Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DBPaciente
    Inherits ConexionBD

#Region "ABM paciente"

    Public Function SetPaciente(ci, mail, contraseña, tel_cel, edad, domicilio, sexo, pNom, sNom, pApe, sApe) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                Try
                    _command.Connection = _connection

                    _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci)"
                    _command.Parameters.AddWithValue("@ci", ci)
                    _command.CommandType = CommandType.Text
                    Dim reader As MySqlDataReader = _command.ExecuteReader
                    If reader.HasRows Then
                        reader.Dispose()
                        Return True
                    Else
                        reader.Dispose()

                        _command.CommandText = "INSERT INTO persona VALUES(@ci,@tel,@edad,@domi,@sexo,@pnom,@pape,@snom,@sape);"
                        _command.CommandText &= "INSERT INTO paciente VALUES(@ci,@mail,@contraseña);"

                        _command.Parameters.AddWithValue("@tel", tel_cel)
                        _command.Parameters.AddWithValue("@domi", domicilio)
                        _command.Parameters.AddWithValue("@sexo", sexo)
                        _command.Parameters.AddWithValue("@pnom", pNom)
                        _command.Parameters.AddWithValue("@pape", pApe)
                        _command.Parameters.AddWithValue("@snom", sNom)
                        _command.Parameters.AddWithValue("@sape", sApe)
                        _command.Parameters.AddWithValue("@mail", mail)
                        _command.Parameters.AddWithValue("@edad", edad)
                        _command.Parameters.AddWithValue("@contraseña", contraseña)

                        _command.ExecuteNonQuery()
                        Return False
                    End If
                Catch ex As MySqlException
                    Throw New SystemException("ERROR(DBPaciente,SetPaciente)" & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function BorrarPaciente(ci) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci)"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    _command.CommandText = "DELETE FROM fichamedica WHERE cedP=@ci;"
                    _command.ExecuteNonQuery()
                    _command.CommandText = "DELETE FROM diagnostico WHERE idP=@ci;"
                    _command.ExecuteNonQuery()
                    _command.CommandText = "DELETE FROM chat WHERE ciPac=@ci;"
                    _command.ExecuteNonQuery()
                    _command.CommandText = "DELETE FROM paciente WHERE ciP=@ci;"
                    _command.ExecuteNonQuery()
                    _command.CommandText = "DELETE FROM persona WHERE ci=@ci;"
                    _command.ExecuteNonQuery()
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using

    End Function

    Public Function ModificarContraseña(ci, contraseña) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    _command.CommandText = "UPDATE paciente SET contrasena=@pass WHERE ciP=@ci;"
                    _command.Parameters.AddWithValue("@pass", contraseña)

                    _command.ExecuteNonQuery()
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using

    End Function

    Public Function RestablecerContra(ci As String, mail As String, contra As String, contraSinEncrip As String) As String
        Dim resultado As String = "Nada"
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand

                _command.Connection = _connection
                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci OR mail=@mail);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.Parameters.AddWithValue("@mail", mail)
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()

                    _command.CommandText = "UPDATE paciente SET contrasena=@pass WHERE ciP=@ci OR mail=@mail;"
                    _command.Parameters.AddWithValue("@pass", contra)
                    _command.ExecuteNonQuery()

                    If ci IsNot "" Then
                        If DBEnvioCorreo.EnviarCorreoRecuperarPass(ci, contraSinEncrip, ObtenerCorreo(ci)) Then
                        End If
                    ElseIf mail IsNot "" Then
                        If DBEnvioCorreo.EnviarCorreoRecuperarPass(ci, contraSinEncrip, mail) Then
                        End If
                    End If
                    resultado = "Se envio un mensaje a su casilla de correo electronico con su contraseña y usuario." & vbNewLine & "Por favor al iniciar sesion modifique su contraseña"

                Else
                    resultado = "No se encotro su usuario o direccion de correo, por favor verifiquelos." & vbNewLine & "Si no posee una cuenta puede crearla en el menu del logib"
                End If

            End Using
        End Using
        Return resultado
    End Function

#End Region

#Region "Chat"

    Public Function SolicitaChat(ci As String, nombre As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                Try
                    _command.Connection = _connection
                    _command.CommandText = "SET @diagnostico = (SELECT nombre
					                                            FROM riesgo R,enfermedad E
					                                            WHERE E.riesgo=idRiesgo
					                                            AND nombre =(SELECT nomE
					                                            			FROM diagnostico
					                                            			WHERE idP=@ci and fecha=CURDATE()
					                                            			ORDER BY idDiag DESC limit 1)ORDER BY idriesgo ASC);"
                    _command.CommandText &= "INSERT INTO solicita(id,ci,nombre,diagnostico,estado) VALUES(null,@ci,@nombre,@diagnostico,'Pendiente');"
                    _command.Parameters.AddWithValue("@ci", ci)
                    _command.Parameters.AddWithValue("@nombre", nombre)
                    _command.CommandType = CommandType.Text
                    _command.ExecuteNonQuery()
                    Return True
                Catch ex As MySqlException
                    Throw New SystemException(ex.Message)
                End Try

            End Using
        End Using

    End Function

    Public Function PreguntarSolicitudAceptada(ci As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT estado FROM solicita WHERE ci=@ci AND estado='Atendido' ORDER BY id DESC;"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader = _command.ExecuteReader
                While (reader.Read())
                    If reader.GetString(0) = "Pendiente" Then
                        Return False
                    Else
                        Return True
                    End If
                End While

            End Using
        End Using
    End Function

    Public Function EliminarSolicitudAceptada(ci As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "DELETE FROM solicita WHERE ci=@ci AND estado='Atendido';"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function CancelarSolicitud(ci As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "DELETE FROM solicita WHERE ci=@ci;"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function EnviarMensajePac(ci, msj) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SET @med = (SELECT idMed FROM chat WHERE ciPac=@ci AND estado='Proceso');
                                        SET @chat = (SELECT idChat FROM chat WHERE ciPac=@ci AND estado='Proceso');
                                        INSERT INTO mensaje VALUES (null,curtime(),@chat,@ci,@med,@msj);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.Parameters.AddWithValue("@msj", msj)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function ComprobarMsjPac(ci) As String
        Dim msj As String = ""
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SET @med = (SELECT idMed FROM chat WHERE ciPac=@ci AND estado='Proceso');
                                        SELECT txt FROM mensaje WHERE emisor=@med AND receptor=@ci AND
                                        hora BETWEEN CURTIME()-1 AND CURTIME()+2 order by idMsj DESC LIMIT 1;"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        msj = reader.GetString(0)
                    End While
                End If

            End Using
        End Using
        Return msj
    End Function

#End Region

#Region "ficha"

    Public Function SetFichaMedica(ci As String, procedencia As String, ocupacion As String,
                                   medicacion As String, motConsu As String, enfermedades As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command As New MySqlCommand
                _command.Connection = _connection
                _command.CommandText = "SET @idDiag = (SELECT idDiag FROM diagnostico WHERE idP=@co AND fecha=CURDATE());
                                        INSERT INTO fichaMedica(fecha,procedencia,idDiag,id,cedP,ocup,medicacion,Motiv_Cons, antecedentesFamiliares)
                                                    VALUES(CURDATE(),@proced,@idDiag,null,@ci,@ocupacion,@medicacion,@motCons,@enfermedades)"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.Parameters.AddWithValue("@proced", procedencia)
                _command.Parameters.AddWithValue("@ocupacion", ocupacion)
                _command.Parameters.AddWithValue("@medicacion", medicacion)
                _command.Parameters.AddWithValue("@motCons", motConsu)
                _command.Parameters.AddWithValue("@enfermedades", enfermedades)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function GetFichaMedica(ci) As DataTable
        Return DevolverTabla("SELECT procedencia,ocup,medicacion,Motiv_Cons,antecedentesFamiliares FROM fichaMedica WHERE cedP='" & ci & "' ORDER BY id DESC")
    End Function

#End Region

    Public Function ComprobarContraseña(contraseña) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT contrasena FROM paciente WHERE contrasena=@pass);"
                _command.Parameters.AddWithValue("@pass", contraseña)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then

                    Return True
                Else
                    Return False
                End If

            End Using
        End Using

    End Function
    Public Function ObtenerCorreo(ci) As String
        Dim correo As String = ""
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT mail FROM paciente WHERE ciP=@ci"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        correo = reader.GetString(0)
                    End While
                Else
                    MsgBox("No se pudo obtener su correo")
                End If

            End Using
        End Using
        Return correo
    End Function
End Class
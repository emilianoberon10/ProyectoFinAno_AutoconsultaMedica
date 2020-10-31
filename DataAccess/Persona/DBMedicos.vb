Imports MySql.Data.MySqlClient

Public Class DBMedicos : Inherits ConexionBD

    Public Sub New()
    End Sub

#Region "ABM"
    Public Function GetCi(numMed) As String
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT ciM FROM medico WHERE numMed=@numMed"
                _command.Parameters.AddWithValue("@numMed", numMed)
                _command.CommandType = CommandType.Text

                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        Dim ciM As String = reader.GetString(0)
                        Return ciM
                    End While
                Else
                    MsgBox("No se pudo obtener en nombre")
                End If

            End Using
        End Using
    End Function
    'Guardar medicos
    Public Function SetMedico(ciMedico As String, especialidad As String, numMedico As Integer, LugarTrabajo As String,
                              contraseña As String, tel_cel As Integer, domicilio As String, sexo As String, pNom As String,
                              sNom As String, pApe As String, sApe As String, edad As Integer) As Boolean
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=@ci)"
                _command.Parameters.AddWithValue("@ci", ciMedico)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader
                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    Try
                        reader.Dispose()

                        _command.CommandText = "SET @idEspec = (SELECT id FROM especialidad WHERE nombre=@espec);"
                        _command.CommandText &= "INSERT INTO persona(ci,Tel_cel,Edad,Domicilio,Sexo,pNom,sNom,pApe,sApe) VALUES(@ci,@tel,@edad,@domi,@sexo,@pnom,@snom,@pape,@sape);"
                        _command.CommandText &= "INSERT INTO medico(ciM,numMed,idEspecialidad,lugarTrabajo,contrasena) VALUES(@ci,@num,@idEspec,@lugartrab,@contraseña)"
                        _command.Parameters.AddWithValue("@tel", tel_cel)
                        _command.Parameters.AddWithValue("@edad", edad)
                        _command.Parameters.AddWithValue("@domi", domicilio)
                        _command.Parameters.AddWithValue("@sexo", sexo)
                        _command.Parameters.AddWithValue("@pnom", pNom)
                        _command.Parameters.AddWithValue("@snom", sNom)
                        _command.Parameters.AddWithValue("@pape", pApe)
                        _command.Parameters.AddWithValue("@sape", sApe)
                        _command.Parameters.AddWithValue("@num", numMedico)
                        _command.Parameters.AddWithValue("@espec", especialidad)
                        _command.Parameters.AddWithValue("@lugartrab", LugarTrabajo)
                        _command.Parameters.AddWithValue("@contraseña", contraseña)
                        _command.ExecuteNonQuery()
                    Catch ex As MySqlException
                        Throw New SystemException("ERROR:(setMedico):" & ex.Message)
                    End Try
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function ModificarContraseña(ci As String, contraseña As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=@ci);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    _command.CommandText = "UPDATE medico SET contrasena=@pass WHERE ciM=@ci;"
                    _command.Parameters.AddWithValue("@pass", contraseña)

                    _command.ExecuteNonQuery()
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using

    End Function

    Public Function SetHorariosMedico(ci As String, horario As String, dia As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=@ci)"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    Select Case dia
                        Case "lun"
                            _command.CommandText = "UPDATE medico SET lun=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "mar"
                            _command.CommandText = "UPDATE medico SET mar=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "mie"
                            _command.CommandText = "UPDATE medico SET mie=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "jue"
                            _command.CommandText = "UPDATE medico SET jue=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "vie"
                            _command.CommandText = "UPDATE medico SET vie=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "sab"
                            _command.CommandText = "UPDATE medico SET sab=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                        Case "dom"
                            _command.CommandText = "UPDATE medico SET dom=@horario WHERE ciM=@ci;"
                            _command.Parameters.AddWithValue("@horario", horario)
                            _command.ExecuteNonQuery()
                            Return False

                    End Select
                Else
                    Return True
                End If
            End Using
        End Using
    End Function

    ' Obtener tabla medicos
    Public Function ObtenerMedicos() As DataTable
        Dim _consultaSQL As String

        _consultaSQL = "SELECT ciM Cedula,pnom PrimerNombre,snom SegundoNombre,pape PrimerApellido,sape SegundoApellido,edad,
                                lugarTrabajo as 'Lugar de Trabajo',nombre Especialidad,tel_cel as 'Telefono',Domicilio,sexo,Lun Lunes,
                                Mar Martes, Mie Miercoles, Jue Jueves, Vie Viernes, Sab Sabado,Dom Domingo
                        FROM medico M
                        JOIN especialidad E ON id=idEspecialidad
                        JOIN persona ON ciM=ci"
        Return DevolverTabla(_consultaSQL)
    End Function

    'Borrar un medico
    Public Function BorarMedico(ciMedico As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand()
                _command.Connection = _connection
                _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=@ci)"
                _command.Parameters.AddWithValue("@ci", ciMedico)
                _command.CommandType = CommandType.Text
                Dim reader = _command.ExecuteReader()

                If reader.HasRows Then
                    reader.Dispose()

                    _command.CommandText = "DELETE FROM chat WHERE idMEd=@ci;DELETE FROM medico WHERE ciM=@ci;"
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

    'modificar un medico
    Public Function ModifMedico(ciMedico, especialidad, LugarTrabajo,
                              tel_cel, domicilio, sexo, pNom, sNom, pApe, sApe, edad) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _command.CommandText = "UPDATE persona SET pnom=@pNom, snom=@sNom, pape=@pApe, sape=@sApe, edad=@edad,                                                  tel_cel=@tel ,domicilio=@domi,sexo=@sexo WHERE ci=@ci;              
                                            SET @idEsp=(SELECT id FROM especialidad WHERE nombre=@especialidad);
                                            UPDATE medico SET idEspecialidad=@idEsp WHERE ciM=@ci;"
                    _command.Parameters.AddWithValue("@ci", ciMedico)
                    _command.Parameters.AddWithValue("@especialidad", especialidad)
                    _command.Parameters.AddWithValue("@tel", tel_cel)
                    _command.Parameters.AddWithValue("@edad", edad)
                    _command.Parameters.AddWithValue("@domi", domicilio)
                    _command.Parameters.AddWithValue("@sexo", sexo)
                    _command.Parameters.AddWithValue("@pnom", pNom)
                    _command.Parameters.AddWithValue("@snom", sNom)
                    _command.Parameters.AddWithValue("@pape", pApe)
                    _command.Parameters.AddWithValue("@sape", sApe)
                    _command.Parameters.AddWithValue("@lugartrab", LugarTrabajo)
                    _command.CommandType = CommandType.Text
                    _command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New SystemException("ERROR:(ModifMedico):" & ex.Message)
            Return False
        End Try
    End Function

    'Obtener especialidades de medicos para comboBox
    Public Function Especialidades() As DataSet
        Dim sql As String = "SELECT * FROM especialidad"
        Return DevolverParaComboBox(sql)
    End Function


#End Region
#Region "Agenda"

    Public Function VerAgenda() As DataTable
        Dim sql As String = "SELECT concat (pNom,' ',sNom,' ',pApe,' ',sApe) as 'Nombre Completo',nombre Especialidad,
                                    lugarTrabajo 'Clinica',lun,mar,mie,jue,vie,sab,dom FROM persona
                            JOIN medico ON ci=ciM
                            JOIN especialidad ON idEspecialidad=id"
        Return DevolverTabla(sql)
    End Function

    Public Function VerAgendaFiltradoEsp(espe As String) As DataTable
        Dim sql As String = "SELECT concat (pNom,' ',sNom,' ',pApe,' ',sApe) as 'Nombre Completo',nombre Especialidad,
                                    lugarTrabajo 'Clinica',lun,mar,mie,jue,vie,sab,dom FROM persona
                             JOIN medico ON ci=ciM
                             JOIN especialidad as e ON idEspecialidad=id
                             where e.nombre='" & espe & "';"

        Return DevolverTabla(sql)
    End Function

    Public Function VerAgendaFiltradoNombre(nom As String) As DataTable
        Dim sql As String = "SELECT concat (pNom,' ',sNom,' ',pApe,' ',sApe) as 'Nombre Completo',nombre Especialidad,
                                    lugarTrabajo 'Clinica',lun,mar,mie,jue,vie,sab,dom FROM persona
                             JOIN medico as m ON ci=ciM
                             JOIN especialidad as e ON idEspecialidad=id
                             where pNom='" & nom & "';"

        Return DevolverTabla(sql)
    End Function

#End Region

    Public Function AceptarChat(ciM, ciP, diagnostico) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand()
                _command.Connection = _connection
                _command.CommandText = "INSERT INTO chat VALUES (null,@ciP,@ciM,CURDATE(),@diag,'Proceso');
                                        UPDATE solicita SET estado='Atendido' WHERE ci=@ciP"
                _command.Parameters.AddWithValue("@ciP", ciP)
                _command.Parameters.AddWithValue("@ciM", ciM)
                _command.Parameters.AddWithValue("@diag", diagnostico)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function VerChatsAntiguos(ci As String) As DataTable
        Dim consulta As String
        consulta = "SELECT ci, CONCAT(pNom,' ',pape) as 'Nombre',estado,fecha,idChat FROM persona
                    JOIN chat ON ci=ciPac
                    WHERE chat.idMed=" & ci & "
                    ORDER BY idChat DESC;"
        Return DevolverTabla(consulta)
    End Function

    Public Function EnviarMensaje(ci, msj) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SET @pac = (SELECT ciPac FROM chat WHERE idMed=@ci AND estado='Proceso');
                                        SET @chat = (SELECT idChat FROM chat WHERE ciPac=@pac AND estado='Proceso');
                                        INSERT INTO mensaje VALUES (null,curtime(),@chat,@ci,@pac,@msj);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.Parameters.AddWithValue("@msj", msj)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function ComprobarMsjMed(ci) As String
        Dim msj As String = ""
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SET @pac = (SELECT ciPac FROM chat WHERE idMed=@ci AND estado='Proceso');
                                        SELECT txt FROM mensaje WHERE emisor=@pac AND receptor=@ci AND
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
    Public Function ComprobarContraseña(contraseña) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT contrasena FROM medico WHERE contrasena=@pass);"
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
End Class

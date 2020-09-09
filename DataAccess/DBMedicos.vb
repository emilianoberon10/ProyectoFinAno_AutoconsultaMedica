Imports MySql.Data.MySqlClient

Public Class DBMedicos : Inherits ConexionBD

    Public Sub New()
    End Sub

#Region "ABM"

    'Guardar medicos
    Public Function SetMedico(ciMedico As String, especialidad As String, numMedico As Integer, LugarTrabajo As String,
                              contraseña As String, tel_cel As Object, domicilio As String, sexo As String, pNom As String,
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
                        _command.CommandText &= "INSERT INTO medico(ciM,numMed,idEspecialidad,lugarTrabajo,contraseña) VALUES(@ci,@num,@idEspec,@lugartrab,@contraseña)"
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
        _consultaSQL = "SELECT *,nombre FROM medico M, especialidad E WHERE M.idEspecialidad = E.id"
        Return DevolverTabla(_consultaSQL)
    End Function

    'Borrar un medico
    Public Function BorarMedico(ciMedico As String) As Boolean
        Try
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

                        _command.CommandText = "DELETE FROM chat WHERE idMEd=@ci;DELETE FROM medico WHERE ciM=@ci;DELETE FROM persona WHERE ci=@ci;"
                        _command.ExecuteNonQuery()
                        Return False
                    Else
                        Return True
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New SystemException("ERROR:(BorrarMedico):" & ex.Message)

            Return Nothing
        End Try
    End Function

    'modificar un medico
    Public Function ModifMedico(ciMedico As String, especialidad As String, numMedico As Integer) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _command.CommandText = "UPDATE medico SET numMed=@num,especialidad=@espec WHERE ciM=@ci"
                    _command.Parameters.AddWithValue("@ci", ciMedico)
                    _command.Parameters.AddWithValue("@numMed", numMedico)
                    _command.Parameters.AddWithValue("@especialidad", especialidad)
                    _command.CommandType = CommandType.Text
                    _command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New SystemException("ERROR:(ModifMedico):" & ex.Message)
            Return Nothing
        End Try
    End Function

    'Obtener especialidades de medicos para comboBox
    Public Function Especialidades() As DataSet
        Dim sql As String = "SELECT * FROM especialidad"
        Return DevolverParaComboBox(sql)
    End Function

#Region "Agenda"

    Public Function VerAgenda() As DataTable
        Dim sql As String = "SELECT pNom,sNom,pApe,sApe,nombre,lugarTrabajo,lun,mar,mie,jue,vie,sab,dom FROM Persona JOIN medico ON ci=ciM JOIN especialidad ON idEspecialidad=id"
        Return DevolverTabla(sql)
    End Function

    Public Function VerAgendaFiltradoEsp(espe As String) As DataTable
        Dim sql As String = "SELECT pNom,sNom,pApe,sApe,nombre,lugarTrabajo,lun,mar,mie,jue,vie,sab,dom FROM Persona
                             JOIN medico ON ci=ciM
                             JOIN especialidad as e ON idEspecialidad=id
                             where e.nombre='" & espe & "';"

        Return DevolverTabla(sql)
    End Function

    Public Function VerAgendaFiltradoCi(ci As String) As DataTable
        Dim sql As String = "SELECT pNom,sNom,pApe,sApe,nombre,lugarTrabajo,lun,mar,mie,jue,vie,sab,dom FROM Persona
                             JOIN medico as m ON ci=ciM
                             JOIN especialidad as e ON idEspecialidad=id
                             where m.ciM='" & ci & "';"

        Return DevolverTabla(sql)
    End Function

#End Region

#End Region

    Public Function AceptarChat(ciM, ciP, diagnostico) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand()
                _command.Connection = _connection
                _command.CommandText = "INSERT INTO chat VALUES (CURDATE(),@ciP,@Diag,null,@ciM,'Proceso');
                                        UPDATE solicita SET estado='Atendido' WHERE ci=@ciP"
                _command.Parameters.AddWithValue("@ciP", ciP)
                _command.Parameters.AddWithValue("@ciM", ciM)
                _command.Parameters.AddWithValue("@Diag", diagnostico)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

End Class
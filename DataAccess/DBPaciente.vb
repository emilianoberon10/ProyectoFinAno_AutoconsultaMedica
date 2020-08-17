Imports MySql.Data.MySqlClient

Public Class DBPaciente
    Inherits ConexionBD

    Public Function SetPaciente(ci As String, mail As String, contraseña As String,
                   tel_cel As Integer, edad As Integer, domicilio As String,
                   sexo As String, pNom As String, sNom As String,
                   pApe As String, sApe As String, fechaNac As Date) As Boolean
        Try
            Using _connection = GetConnection()
                Using _command = New MySqlCommand
                    _command.Connection = _connection

                    _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci"
                    _command.Parameters.AddWithValue("@ci", ci)
                    _command.CommandType = CommandType.Text
                    Dim reader As MySqlDataReader = _command.ExecuteReader
                    If reader.HasRows Then
                        reader.Dispose()
                        Return True
                    Else
                        reader.Dispose()

                        _command.CommandText = "INSERT INTO persona VALUES(@ci,@tel,@domi,@sexo,@pnom,@pape,@snom,@sape);"
                        _command.CommandText &= "INSERT INTO paciente VALUES(@ci,@mail,@fechaNac,@contraseña);"

                        _command.Parameters.AddWithValue("@tel", tel_cel)
                        _command.Parameters.AddWithValue("@domi", domicilio)
                        _command.Parameters.AddWithValue("@sexo", sexo)
                        _command.Parameters.AddWithValue("@pnom", pNom)
                        _command.Parameters.AddWithValue("@pape", pApe)
                        _command.Parameters.AddWithValue("@snom", sNom)
                        _command.Parameters.AddWithValue("@sape", sApe)
                        _command.Parameters.AddWithValue("@mail", mail)
                        _command.Parameters.AddWithValue("@fechaNac", fechaNac.ToString)
                        _command.Parameters.AddWithValue("@contraseña", contraseña)

                        _command.ExecuteNonQuery()
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBMedicos,SetMedico)" & ex.Message)
        End Try
    End Function

    Public Function BorrarPaciente(ci As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    reader.Dispose()

                    _command.CommandText = "DELETE FROM persona, paciente WHERE ci=@ci;"
                    _command.ExecuteNonQuery()
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

                _command.CommandText = "SELECT * FROM paciente WHERE EXISTS (SELECT ciP FROM paciente WHERE ciP=@ci"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    reader.Dispose()

                    _command.CommandText = "UPDATE paciente SET contraseña=@pass WHERE ci=@ci;"
                    _command.Parameters.AddWithValue("@pass", contraseña)

                    _command.ExecuteNonQuery()
                    Return False
                End If

            End Using
        End Using

    End Function

    Public Function ObtenerNombrePaciente(ci As String) As String

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT pNom FROM persona INNER JOIN paciente ON ci=ciP WHERE ci=@ci"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        Dim nombre As String = reader.GetString(0)
                        Return nombre
                    End While
                Else
                    MsgBox("No se pudo obtener en nombre")
                End If

            End Using
        End Using

    End Function

    Public Function SolicitaChat(ci As String, nombre As String) As Boolean
        Dim enfDiag As String
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT nomE FROM diagnostico WHERE idP=@ci AND fecha=CURDATE() order by idDiag desc;"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader
                If (reader.HasRows) Then
                    While (reader.Read())
                        enfDiag = reader.GetString(0)
                    End While
                Else
                    MsgBox("No se pudo obtener en nombre")
                End If

                reader.Dispose()

                _command.CommandText = "INSERT INTO solicita(id,ci,nombre,diagnostico,estado) VALUES(null,@ci,@nombre,@diagnostico,'Pendiente')"
                _command.Parameters.AddWithValue("@nombre", nombre)
                _command.Parameters.AddWithValue("diagnostico", enfDiag)
                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using

    End Function

    Public Function PreguntarSolicitudAceptada(ci As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT estado FROM solicita WHERE ci=@ci"
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

                _command.CommandText = "DELETE FROM solicita WHERE ci=@ci AND estado='Atendido'"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                _command.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
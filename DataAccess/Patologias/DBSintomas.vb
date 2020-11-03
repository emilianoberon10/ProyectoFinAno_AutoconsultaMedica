Imports MySql.Data.MySqlClient

Public Class DBSintomas
    Inherits ConexionBD

    Private _consultaSQL As String = ""

    Public Sub New()
    End Sub

    'Guardar sintomas seleccionados
    Public Function GuardarSeleccion(sintomas As ArrayList, ci As String) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    ' Realizo un bucle porque se puede guardar una enfermedad con muchos sintomas
                    For Each sintoma In sintomas
                        _consultaSQL = "SET @idSint=(SELECT id FROM sintoma WHERE nombre='" & sintoma & "');"

                        _consultaSQL &= "INSERT INTO selec(dia,hora,idSint,idPac)"
                        _consultaSQL &= " VALUES("
                        _consultaSQL &= "CURDATE(),"
                        _consultaSQL &= "CURTIME(),"
                        _consultaSQL &= "@idSint,"
                        _consultaSQL &= "'" & ci & "');"
                        _command.CommandText = _consultaSQL
                        _command.CommandType = CommandType.Text

                        Dim reader = _command.ExecuteReader()

                        If reader.HasRows Then
                            reader.Dispose()
                            Return True
                        Else
                            Return False
                        End If
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBSintoma,guardarSelec)::" & ex.Message)
            Return Nothing
        End Try
    End Function

    'Guardar sintomas
    Public Function SetSintoma(nombreSintoma As String) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _consultaSQL = "SELECT * FROM sintoma WHERE EXISTS (SELECT nombre FROM sintoma WHERE nombre=@nombre)"
                    _command.CommandText = _consultaSQL
                    _command.Parameters.AddWithValue("@nombre", nombreSintoma)
                    _command.CommandType = CommandType.Text
                    Dim reader = _command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Dispose()
                        Return True
                    Else
                        reader.Dispose()

                        _consultaSQL = "INSERT INTO sintoma(id,nombre) VALUES(null,@nombre);"
                        _command.CommandText = _consultaSQL
                        _command.ExecuteNonQuery()
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBSintoma,setSintoma):" & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Obtener sintomas
    Public Function ObtenerSintomas() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM sintoma"
        Return DevolverTabla(_consultaSQL)
        Return Nothing
    End Function

    Public Function DevolverSintomaComboBox() As DataSet
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM sintoma"
        Return DevolverParaComboBox(_consultaSQL)
    End Function

    'Modificar sintomas
    Public Function ModifSintomas(nombreSintoma, id) As Boolean
        Dim _consultaSQL As String
        Try
            _consultaSQL = "UPDATE sintoma SET nombre='" & nombreSintoma & "' WHERE id='" & id & "';"
            EjecutarConsulta(_consultaSQL)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Borrar sintomas
    Public Function BorrarSintoma(nombreSintoma As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand()
                _command.Connection = _connection
                _consultaSQL = "SELECT * FROM sintoma WHERE EXISTS (SELECT nombre FROM sintoma WHERE nombre=@nombre)"
                _command.CommandText = _consultaSQL
                _command.Parameters.AddWithValue("@nombre", nombreSintoma)
                _command.CommandType = CommandType.Text
                Dim reader = _command.ExecuteReader()

                If reader.HasRows Then
                    reader.Dispose()
                    _command.CommandText = "SET @idSint=(SELECT id FROM sintoma WHERE nombre=@nombre);"
                    _command.CommandText &= "DELETE FROM selec WHERE idSint=@idSint;
                                                DELETE FROM define WHERE idSint=@idSint;"
                    _command.ExecuteNonQuery()
                    _command.CommandText = "DELETE FROM sintoma WHERE nombre=@nombre OR id=@nombre;"
                    _command.ExecuteNonQuery()

                    Return True
                Else
                    Return False
                End If
            End Using
        End Using

    End Function

    Public Sub LimpiarSeleccion(ci)
        Dim _consultaSQL As String
        _consultaSQL = "DELETE FROM selec WHERE idPac='" & ci & "';"
        EjecutarConsulta(_consultaSQL)
    End Sub

End Class
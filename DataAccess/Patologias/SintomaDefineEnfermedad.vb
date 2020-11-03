Imports MySql.Data.MySqlClient

Public Class SintomaDefineEnfermedad
    Inherits ConexionBD

    Public Function SetDefine(nombreEnfermedad As String, nombreSintoma As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM define WHERE EXISTS (SELECT nomEnf FROM define WHERE nomEnf='" & nombreEnfermedad & "')"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
        Else
            _consultaSQL = "SET @idSint=(SELECT id FROM sintoma WHERE nombre='" & nombreSintoma & "');"
            _consultaSQL &= "INSERT INTO define(nomEnf,idSint)"
            _consultaSQL &= " VALUES ( "
            _consultaSQL &= "'" & nombreEnfermedad & "',"
            _consultaSQL &= "@idSint)"

            EjecutarConsulta(_consultaSQL)
            Return False
        End If
    End Function

    Public Function BorrarDefine(nombreEnfermedad As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM define WHERE EXISTS (SELECT nomEnf FROM define WHERE nomEnf='" & nombreEnfermedad & "')"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            _consultaSQL = "DELETE * FROM define WHERE nomEnf=" & nombreEnfermedad & ""
            EjecutarConsulta(_consultaSQL)
            Return True
        Else
            Return False
        End If
    End Function

    Dim i As Integer = 0
    Public Function ModifDefine(nombreEnfermedad As String, nombreSintoma As String, nomsSntViejo As Array) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                ' Primero agarro los id de los sintomas
                'Despues compruebo si existe el sintoma nuevo
                command.CommandText = "SET @idSint=(SELECT id FROM sintoma WHERE nombre=@sintoma);
                                       SET @sintViejo=(SELECT id FROM sintoma WHERE nombre=@sintomaViejo);
                                       SELECT * FROM define WHERE EXISTS (SELECT idSint FROM define WHERE idSint=@idSint AND nomEnf=@enfermedad);"
                command.Parameters.AddWithValue("@sintoma", nombreSintoma)
                command.Parameters.AddWithValue("@sintomaViejo", nomsSntViejo.GetValue(i))
                command.Parameters.AddWithValue("@enfermedad", nombreEnfermedad)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Dispose()
                Else
                    reader.Dispose()
                    'Actualizo el registro 
                    command.CommandText = "UPDATE define SET idSint=@idSint WHERE nomEnf=@enfermedad AND idSint=@sintViejo;"
                    If command.ExecuteNonQuery() = 0 Then
                        command.CommandText = "INSERT INTO define(nomEnf,idSint) VALUE(@enfermedad,@idSint);"
                        command.ExecuteNonQuery()
                    End If
                End If
            End Using
        End Using
        i += 1
        If i = nomsSntViejo.Length Then i = 0
        Return True

    End Function

End Class
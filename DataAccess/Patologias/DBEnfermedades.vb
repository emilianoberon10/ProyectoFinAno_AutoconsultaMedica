Imports MySql.Data.MySqlClient

Public Class DBEnfermedades
    Inherits ConexionBD

    Public Sub New()
    End Sub

    'Guardar una enfermedad
    Public Function SetEnfermedad(nombreEnfermedad As String, riesgo As Integer, descripcion As String) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _command.CommandText = "SELECT * FROM enfermedad WHERE EXISTS (SELECT nombre FROM enfermedad WHERE nombre=@nombre)"
                    _command.Parameters.AddWithValue("@nombre", nombreEnfermedad)
                    _command.CommandType = CommandType.Text
                    Dim reader = _command.ExecuteReader()

                    If reader.HasRows Then
                        reader.Dispose()
                        Return True
                    Else
                        reader.Dispose()

                        _command.CommandText = "INSERT INTO enfermedad(idEnf,nombre,riesgo,descripcion) VALUES(null,@nombre,@riesgo,@desc)"
                        _command.Parameters.AddWithValue("@riesgo", riesgo)
                        _command.Parameters.AddWithValue("@desc", descripcion)
                        _command.ExecuteNonQuery()
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBEnfermedad,SetEnfermedad)::" & ex.Message)
            Return Nothing
        End Try
    End Function

    'Obtener tabla enfermedades
    Public Function ObtenerEnfermedades() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT idEnf ID,e.nombre NOMBRE,r.riesgo RIESGO,descripcion DESCRIPCION FROM enfermedad e
                        JOIN define ON nombre=nomENf
                        JOIN riesgo r ON e.riesgo=idriesgo
                        Group by idEnf,nomEnf,e.nombre,r.riesgo,descripcion
						ORDER by idEnf ASC;"
        Return DevolverTabla(_consultaSQL)
    End Function

    Public Function ObtenerSintomasEnfermedad(nomEnf) As ArrayList
        Dim nomSint As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT nombre FROM sintoma
                                        JOIN define d ON id=idSint
                                        WHERE d.nomEnf=@nomE
                                        GROUP BY nombre;"
                _command.Parameters.AddWithValue("@nomE", nomEnf)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then

                    While reader.Read()

                        nomSint.Add(reader.GetString(0))

                    End While
                Else

                End If

            End Using
        End Using
        Return nomSint
    End Function

    'borrar una enfermedad
    Public Function BorrarEnfermedad(nombreEnfermedad As String) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _command.CommandText = "SELECT * FROM enfermedad WHERE EXISTS (SELECT nombre FROM enfermedad WHERE nombre=@nombre)"
                    _command.Parameters.AddWithValue("@nombre", nombreEnfermedad)
                    _command.CommandType = CommandType.Text
                    Dim reader = _command.ExecuteReader()

                    If reader.HasRows Then
                        reader.Dispose()
                        _command.CommandText = "DELETE FROM diagnostico WHERE nomE=@nombre;"
                        _command.ExecuteNonQuery()
                        _command.CommandText = "DELETE FROM define WHERE nomEnf=@nombre;"
                        _command.ExecuteNonQuery()
                        _command.CommandText = "DELETE FROM enfermedad WHERE nombre=@nombre;"
                        _command.ExecuteNonQuery()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBEnfermedad,BorrarEnfermedad)::" & ex.Message)
            Return Nothing
        End Try
    End Function

    'Modificar una enfermedad
    Public Function ModifEnfermedad(nombreEnfermedad As String, riesgo As String, descripcion As String) As Boolean
        Try
            Using _connection = GetConnection()
                _connection.Open()
                Using _command = New MySqlCommand()
                    _command.Connection = _connection
                    _command.CommandText = "UPDATE enfermedad SET riesgo=@riesgo,descripcion=@desc WHERE nombre=@nombre;"
                    _command.Parameters.AddWithValue("@nombre", nombreEnfermedad)
                    _command.Parameters.AddWithValue("@riesgo", riesgo)
                    _command.Parameters.AddWithValue("@desc", descripcion)
                    _command.CommandType = CommandType.Text
                    _command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBEnfermedad,ModifEnfermedad)::" & ex.Message)
            Return Nothing
        End Try
    End Function

End Class
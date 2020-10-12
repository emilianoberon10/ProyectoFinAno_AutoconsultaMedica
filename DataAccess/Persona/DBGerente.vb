Imports MySql.Data.MySqlClient

Public Class DBGerente : Inherits ConexionBD
    Public Function ModificarContraseña(ci As String, contraseña As String) As Boolean

        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT * FROM gerente WHERE EXISTS (SELECT ciG FROM gerente WHERE ciG=@ci);"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader

                If reader.HasRows Then
                    reader.Dispose()
                    _command.CommandText = "UPDATE gerente SET contrasena=@pass WHERE ciG=@ci;"
                    _command.Parameters.AddWithValue("@pass", contraseña)

                    _command.ExecuteNonQuery()
                    Return False
                Else
                    Return True
                End If

            End Using
        End Using

    End Function


    Public Function NomEnfMasDiag() As ArrayList
        Dim nomE As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "masDiagnosticados"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    nomE.Add(reader.GetString(0))

                End While

            End Using
        End Using
        Return nomE
    End Function
    Public Function CantEnfMasDiag() As ArrayList
        Dim cant As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "masDiagnosticados"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    cant.Add(reader.GetInt32(1))

                End While

            End Using
        End Using
        Return cant
    End Function
    Public Function NomSintMasSelec() As ArrayList
        Dim nomSInt As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "sintomaMasSeleccionado"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    nomSInt.Add(reader.GetString(0))

                End While

            End Using
        End Using
        Return nomSInt
    End Function
    Public Function CantSintMasSelec() As ArrayList
        Dim cant As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "sintomaMasSeleccionado"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    cant.Add(reader.GetInt32(1))

                End While

            End Using
        End Using
        Return cant
    End Function

    Public Function MesesChat() As ArrayList
        Dim meses As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "cantChatsMes"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    meses.Add(reader.GetString(0))

                End While

            End Using
        End Using
        Return meses
    End Function
    Public Function cantChatMeses() As ArrayList
        Dim cant As New ArrayList
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "cantChatsMes"
                _command.CommandType = CommandType.StoredProcedure
                Dim reader As MySqlDataReader = _command.ExecuteReader

                While reader.Read()

                    cant.Add(reader.GetInt32(1))

                End While

            End Using
        End Using
        Return cant
    End Function

End Class
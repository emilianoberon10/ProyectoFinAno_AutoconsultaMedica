Imports MySql.Data.MySqlClient

Public Class DBMedicos
    Inherits ConexionBD

    Public Sub New()
    End Sub

    'Guardar medicos
    Public Function SetMedico(ciMedico As String, especialidad As String, numMedico As Integer) As Boolean
        Try
            Using _connection = GetConnection()
                Using _command = New MySqlCommand
                    _command.CommandText = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=@ci"
                    _command.Parameters.AddWithValue("@ci", ciMedico)
                    _command.CommandType = CommandType.Text
                    Dim reader As MySqlDataReader = _command.ExecuteReader
                    If reader.HasRows Then
                        reader.Dispose()
                        Return True
                    Else
                        _command.CommandText = "INSERT INTO medico(ciM,numMed,especialidad) VALUES('@ci','@num','@espec')"
                        _command.Parameters.AddWithValue("@num", numMedico)
                        _command.Parameters.AddWithValue("@espec", especialidad)
                        _command.ExecuteNonQuery()
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBMedicos,SetMedico)" & ex.Message)
        End Try
    End Function

    ' Obtener tabla medicos
    Public Function ObtenerMedicos() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM medico"
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
                        Return True
                    Else
                        _command.CommandText = "DELETE FROM medico WHERE ciM=@ci;"
                        _command.ExecuteNonQuery()
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBMedicos,BorarMedico):" & ex.Message)
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
                    _command.CommandText = "UPDATE medico SET ciM=@ci,numMed=@num,especialidad=@espec"
                    _command.Parameters.AddWithValue("@ci", ciMedico)
                    _command.Parameters.AddWithValue("@numMed", numMedico)
                    _command.Parameters.AddWithValue("@especialidad", especialidad)
                    _command.CommandType = CommandType.Text
                    _command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox("ERROR(DBMedicos,ModifMedico):" & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function AceptarChat(ciM As String, ciP As String, diagnostico As String) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command = New MySqlCommand()
                _command.Connection = _connection
                _command.CommandText = "INSERT INTO chat VALUES (CURDATE(),@ciP,@Diag,null,@ciM,'Atendido');UPDATE solicita SET estado='Atendido' WHERE ci=@ciP"
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
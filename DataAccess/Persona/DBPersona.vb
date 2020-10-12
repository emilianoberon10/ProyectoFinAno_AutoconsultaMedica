Imports MySql.Data.MySqlClient

Public Class DBPersona : Inherits ConexionBD

    Public Function GetPersonas(ci) As DataTable
        Return DevolverTabla("SELECT pnom,snom,pape,sape,edad FROM persona WHERE ci='" & ci & "'")
    End Function
    Public Function UpdatePersona(ci As String, pnom As String, snom As String, pape As String, sape As String, edad As Integer) As Boolean
        Using _connection = GetConnection()
            _connection.Open()
            Using _command As New MySqlCommand

                _command.Connection = _connection
                _command.CommandText = "UPDATE persona SET pnom=@pnom, snom=@snom, pape=@pape, sape=@sape, edad=@edad WHERE ci=@ci;"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.Parameters.AddWithValue("@pnom", pnom)
                _command.Parameters.AddWithValue("@snom", snom)
                _command.Parameters.AddWithValue("@pape", pape)
                _command.Parameters.AddWithValue("@sape", sape)
                _command.Parameters.AddWithValue("@edad", edad)
                _command.CommandType = CommandType.Text

                _command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

End Class

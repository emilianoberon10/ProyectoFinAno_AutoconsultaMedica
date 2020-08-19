Imports MySql.Data.MySqlClient

Public Class DBDiagnostico
    Inherits ConexionBD

    Public Function Diagnostico(ci As String) As DataTable
        Dim _consultaSQL As String = "select nomEnf from define E, selec S where E.nomSint=S.nomSint and idPac='" & ci & "' and dia=CURDATE() and hora between curtime()-1 and curtime()+1 group by nomEnf;"
        Return DevolverTabla(_consultaSQL)
    End Function

    Public Function GuardarDiagnostico(ci As String, enfermedades As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "Insert into diagnostico(idDiag,idP,nomE,fecha) Values(null,@idP,@nomE,CURTIME());"
                command.Parameters.AddWithValue("@idP", ci)
                command.Parameters.AddWithValue("@nomE", enfermedades)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

End Class
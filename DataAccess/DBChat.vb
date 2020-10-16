Imports MySql.Data.MySqlClient

Public Class DBChat : Inherits ConexionBD

    Public Function ComprobarSolicitudes() As DataTable
        Return DevolverTabla("SELECT s.ci, s.nombre, s.diagnostico, r.riesgo  FROM solicita as s
                              INNER JOIN enfermedad AS e ON diagnostico=e.nombre
                              INNER JOIN riesgo AS r ON e.riesgo=idRiesgo
                              WHERE s.estado='pendiente'
                              ORDER BY e.riesgo ASC;")
    End Function
    Public Sub Finalizar(ci)
        EjecutarConsulta("UPDATE chat SET estado='Finalizado' WHERE ciPac=" & ci & " OR idMed=" & ci)
    End Sub

    Public Function DevolverChat(idchat) As DataTable
        Return DevolverTabla("SELECT txt FROM mensaje WHERE mensaje.idChat=" & idchat & ";")
    End Function
    Public Function DevolverDiag(idchat) As String
        Dim nombre As String = ""
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SELECT diagnostico FROM chat WHERE idchat=@id;"
                _command.Parameters.AddWithValue("@id", idchat)
                _command.CommandType = CommandType.Text

                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        nombre = reader.GetString(0)
                    End While
                Else
                End If

            End Using
        End Using

        Return nombre
    End Function

End Class
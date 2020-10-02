Imports MySql.Data.MySqlClient

Public Class DBImagen : Inherits ConexionBD

    Public Sub New()

    End Sub

    Public Function Guardar(ci, foto) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO fotoPerfil(ci,foto)
                                           VALUES (@ci,@foto)
                                           ON DUPLICATE KEY UPDATE foto=@foto"

                    command.Parameters.AddWithValue("@ci", ci)
                    command.Parameters.Add("@foto", MySqlDbType.VarBinary).Value = foto
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function TraerImagen(ci) As String

        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM fotoPerfil WHERE ci=@ci"
                command.Parameters.AddWithValue("@ci", ci)

                Dim adt As New MySqlDataAdapter(command)
                Dim ds As New DataSet
                adt.Fill(ds)

                If ds.Tables(0).Rows.Count Then
                    Return ds.Tables(0).Rows(0).Item("foto")
                Else
                    Return "No se encontro imagen"
                End If

            End Using
        End Using

    End Function

End Class
﻿Imports MySql.Data.MySqlClient

Public Class DBLogin
    Inherits ConexionBD

    Public Sub New()

    End Sub

    Public Function LoginPaciente(ci As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM paciente WHERE ciP=@user and contraseña=@pass;"
                command.Parameters.AddWithValue("@user", ci)
                command.Parameters.AddWithValue("@pass", pass)
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

    Public Function LoginGerente(ci As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText &= "SELECT * FROM gerente WHERE ciG=@user and contraseña=@pass;"
                command.Parameters.AddWithValue("@user", ci)
                command.Parameters.AddWithValue("@pass", pass)
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

    Public Function LoginMedico(ci As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText &= "SELECT * FROM medico WHERE ciM=@user and contraseña=@pass;"
                command.Parameters.AddWithValue("@user", ci)
                command.Parameters.AddWithValue("@pass", pass)
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
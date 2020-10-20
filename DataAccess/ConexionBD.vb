Imports MySql.Data.MySqlClient

Public MustInherit Class ConexionBD

    'declaro MustInherits para que no se pueda crear una instancia(objeto) de esta clase
    'cadena de conexion a la bd
    Private connString As String = "server=localhost;
                                    database=mateo_vargas;
                                    Uid=root;
                                    Pwd =;
                                    port=3306;
                                    AllowUserVariables=True;"

    Protected conn As New MySqlConnection(connString)

    Protected Function GetConnection() As MySqlConnection
        Try
            conn.Open()
            conn.Close()
        Catch ex As MySqlException
            MsgBox("Error al conectar a la bd, " & ex.Message)
        End Try
        Return New MySqlConnection(connString)
    End Function

    Public Function ObtenerNombre(ci) As String
        Dim nombre As String = ""
        Using _connection = GetConnection()
            _connection.Open()

            Using _command = New MySqlCommand
                _command.Connection = _connection

                _command.CommandText = "SET @ciM=(SELECT ciM FROM medico WHERE numMed=@ci);
                                        SELECT pNom FROM persona WHERE ci=@ci OR ci=@ciM"
                _command.Parameters.AddWithValue("@ci", ci)
                _command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = _command.ExecuteReader()
                If (reader.HasRows) Then
                    While (reader.Read())
                        nombre = reader.GetString(0)
                    End While
                Else
                    MsgBox("No se pudo obtener en nombre")
                End If

            End Using
        End Using
        Return nombre
    End Function

    ' Para ejecutar las consultas
    Public Sub EjecutarConsulta(consulta As String)
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            commandSQL.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al ejecutar una consulta:" & ex.Message)
            conn.Close()
        End Try
    End Sub

    'Para comprobar si el dato a ingresar existe
    Public Function ConsultaComprobarExistencia(consulta As String) As Boolean
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Dim resultado As Boolean = False

        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            Dim resultadoSQL As MySqlDataReader = commandSQL.ExecuteReader()

            If resultadoSQL.Read() Then 'Encontro dato return true sino false
                conn.Close()
                resultado = True 'La consulta SE ejecuto correctamente
            Else
                conn.Close()
                resultado = False 'La consulta NO se ejecuto correctamente
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            conn.Close()
        End Try

        Return resultado
    End Function

    'Para obtener los datos de las tablas y mostrarlos por dataGridView
    Public Function DevolverTabla(consulta As String) As DataTable
        Dim dataTable As New DataTable
        Dim dataSet As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            adapter = New MySqlDataAdapter(consulta, conn)
            conn.Open()
            adapter.Fill(dataSet)
            dataTable = dataSet.Tables(0)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error(ConexionDB,line61):: " & ex.Message)
            conn.Close()
        End Try
        Return dataTable
    End Function

    Public Function DevolverParaComboBox(consulta As String) As DataSet
        Dim dataSet As New DataSet
        Dim adapter As MySqlDataAdapter
        Dim commadnSQL As MySqlCommand

        Try
            conn.Open()
            commadnSQL = New MySqlCommand()
            commadnSQL.CommandText = consulta
            commadnSQL.CommandType = CommandType.Text
            commadnSQL.Connection = conn

            adapter = New MySqlDataAdapter(commadnSQL)
            adapter.Fill(dataSet)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error(ConexionDB,line78):: " & ex.Message)
            conn.Close()
        End Try
        Return dataSet
    End Function

End Class
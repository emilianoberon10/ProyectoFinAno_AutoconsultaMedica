Imports MySql.Data.MySqlClient
Public MustInherit Class ConexionBD
    'declaro MustInherits para que no se pueda crear una instancia(objeto) de esta clase
    'cadena de conexion a la bd
    Private connString As String = "server=localhost;database=medicaproyecto;user id=root;password=;port=3306;"
    Private conn As MySqlConnection

    Protected Sub New()
        conn = New MySqlConnection(connString)
    End Sub

    Protected Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function

    Public Sub OpenConnection() 'Metodo para abrir conexion
        conn.Open()
    End Sub

    Public Sub CloseConnection() 'Metodo para cerrar conexion
        conn.Open()
    End Sub

    ' Para ejecutar las consultas
    Public Sub consultaEjecutar(consulta As String)
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            conn.Close()
        End Try
    End Sub

    'Para comprobar si el dato a ingresar existe
    Public Function ConsultaComprobarExistencia(consulta As String) As Boolean
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            Dim resultadoSQL As MySqlDataReader = commandSQL.ExecuteReader()

            If resultadoSQL.Read() Then 'Encontro dato return true sino false
                conn.Close()
                Return True 'La consulta SE ejecuto correctamente
            Else
                conn.Close()
                Return False 'La consulta NO se ejecuto correctamente
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            conn.Close()
        End Try
        Return Nothing
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

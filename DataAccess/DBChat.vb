Imports MySql.Data.MySqlClient
Public Class DBChat : Inherits ConexionBD

    Public Function ComprobarSolicitudes() As DataTable
        Return DevolverTabla("SELECT * FROM solicita WHERE estado='Pendiente';")
    End Function

End Class

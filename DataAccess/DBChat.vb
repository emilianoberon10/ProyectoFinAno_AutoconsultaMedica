Imports MySql.Data.MySqlClient

Public Class DBChat : Inherits ConexionBD

    Public Function ComprobarSolicitudes() As DataTable
        Return DevolverTabla("SELECT s.ci, s.nombre, s.diagnostico, r.riesgo  FROM solicita as s
                              INNER JOIN enfermedad AS e ON diagnostico=e.nombre
                              INNER JOIN riesgo AS r ON e.riesgo=idRiesgo
                              ORDER BY e.riesgo ASC;")
    End Function

End Class
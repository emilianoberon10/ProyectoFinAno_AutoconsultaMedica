Imports MySql.Data.MySqlClient

Public Class DBDiagnostico
    Inherits ConexionBD

    Public Function Diagnostico(ci As String) As DataTable
        Dim _consultaSQL As String = "SELECT nomEnf DIAGNOSTICO FROM define e
                                      JOIN selec s ON s.idSint=e.idSint
                                      WHERE idPac='" & ci & "' and dia=CURDATE() AND
                                      hora BETWEEN CURTIME()-1 AND CURTIME()+1 
                                      GROUP BY nomEnf;"
        Return DevolverTabla(_consultaSQL)
    End Function

    Public Function GuardarDiagnostico(ci As String, enfermedades As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO diagnostico(idDiag,idP,nomE,fecha) VALUES(null,@idP,@nomE,CURDATE());"
                command.Parameters.AddWithValue("@idP", ci)
                command.Parameters.AddWithValue("@nomE", enfermedades)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function UpdateDiagnostico(ci As String, enfermedades As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SET @diagnosticoAnterior=(SELECT idDiag FROM diagnostico WHERE idP=@idP ORDER BY idDiag DESC LIMIT 1);
                                       UPDATE diagnostico SET nomE=@nomE WHERE idDiag=@diagnosticoAnterior;
                                       UPDATE chat SET diagnostico=@nomE WHERE ciPac=@idP AND estado='Proceso';"

                command.Parameters.AddWithValue("@idP", ci)
                command.Parameters.AddWithValue("@nomE", enfermedades)

                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function VerDiagnostico(ci As String) As DataTable
        Return DevolverTabla("SELECT CONCAT(pnom, ' ' ,snom,' ',pape,' ',sape) AS 'Medico que lo atendio',nomE                                                    Diagnostico,e.descripcion,d.fecha FROM diagnostico d
                              LEFT JOIN chat c ON d.idP=c.ciPac
                              LEFT JOIN persona ON idMed=ci
                              LEFT JOIN enfermedad e ON nomE=e.nombre
                              WHERE idP='" & ci & "'
                              GROUP BY idDiag,'Medico que lo atendio',Diag,descripcion,d.fecha;")
    End Function

    Public Function VerDiagnosticoFecha(ci As String, fecha As String) As DataTable
        Return DevolverTabla("SELECT CONCAT(pnom, ' ' ,snom,' ',pape,' ',sape) AS 'Medico que lo atendio',nomE                                                    Diagnostico,e.descripcion,d.fecha FROM diagnostico d
                              LEFT JOIN chat c ON d.idP=c.ciPac
                              LEFT JOIN persona ON idMed=ci
                              LEFT JOIN enfermedad e ON nomE=e.nombre 
                              WHERE idP='" & ci & "' AND d.fecha='" & fecha & "'
                              GROUP BY idDiag,'Medico que lo atendio',Diag,descripcion,d.fecha;")
    End Function

    Public Function VerDiagnosticoEntreFecha(ci As String, fecha As String, fecha2 As String) As DataTable
        Return DevolverTabla("SELECT CONCAT(pnom, ' ' ,snom,' ',pape,' ',sape) AS 'Medico que lo atendio',nomE                                                    Diagnostico,e.descripcion,d.fecha FROM diagnostico d
                              LEFT JOIN chat c ON d.idP=c.ciPac
                              LEFT JOIN persona ON idMed=ci
                              LEFT JOIN enfermedad e ON nomE=e.nombre
                              WHERE idP='" & ci & "' AND d.fecha between '" & fecha & "' AND '" & fecha2 & "'
                              GROUP BY idDiag,'Medico que lo atendio',Diag,descripcion,d.fecha;")
    End Function

End Class
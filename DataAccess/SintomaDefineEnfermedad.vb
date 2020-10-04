Public Class SintomaDefineEnfermedad
    Inherits ConexionBD

    Public Function SetDefine(nombreEnfermedad As String, nombreSintoma As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM Define WHERE EXISTS (SELECT nomEnf FROM define WHERE nomEnf='" & nombreEnfermedad & "')"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
        Else
            _consultaSQL = "INSERT INTO sintoma(nomEnf,nomSint)"
            _consultaSQL &= " VALUES ( "
            _consultaSQL &= "'" & nombreEnfermedad & "',"
            _consultaSQL &= "'" & nombreSintoma & "')"

            EjecutarConsulta(_consultaSQL)
            Return False
        End If
    End Function

    Public Function BorrarDefine(nombreEnfermedad As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM Define WHERE EXISTS (SELECT nomEnf FROM define WHERE nomEnf='" & nombreEnfermedad & "')"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            _consultaSQL = "Delete * FROM Define WHERE nomEnf=" & nombreEnfermedad & ""
            EjecutarConsulta(_consultaSQL)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ModifDefine(nombreEnfermedad As String, nombreSintoma As String) As Boolean
        Dim _consultaSQL As String
        Try
            _consultaSQL = "UPDATE enfermedad SET "
            _consultaSQL &= "nomEnf = '" & nombreEnfermedad & "',"
            _consultaSQL &= "nomSint = '" & nombreSintoma & "' "
            _consultaSQL &= "where nomEnf= '" & nombreEnfermedad & "';"
            EjecutarConsulta(_consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox("ERROR::modifDefine" & ex.Message)
            Return False
        End Try
    End Function

End Class
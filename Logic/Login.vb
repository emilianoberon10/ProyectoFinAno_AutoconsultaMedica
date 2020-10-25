Imports DataAccess

Public Class Login

    Private confirmarLogin As DBLogin

    Public Sub New()
        confirmarLogin = New DBLogin()
    End Sub

    Public Function confirmarLog(ci As String, pass As String) As String
        Dim res As String = ""
        Try
            If confirmarLogin.LoginPaciente(ci, pass) = True Then res = "Paciente"
            If confirmarLogin.LoginGerente(ci, pass) = True Then res = "Gerente"
            If confirmarLogin.LoginMedico(ci, pass) = True Then res = "Medico"
        Catch ex As Exception
            Throw New SystemException("Login: " + ex.Message)
        End Try
        Return res
    End Function

End Class
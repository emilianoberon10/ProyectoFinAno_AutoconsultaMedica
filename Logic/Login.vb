Imports DataAccess

Public Class Login

    Private confirmarLogin As DBLogin

    Public Sub New()
        confirmarLogin = New DBLogin()
    End Sub

    Public Function confirmarLog(ci As String, pass As String)
        If confirmarLogin.LoginPaciente(ci, pass) = True Then Return "Paciente" Else
        If confirmarLogin.LoginGerente(ci, pass) = True Then Return "Gerente" Else
        If confirmarLogin.LoginMedico(ci, pass) = True Then Return "Medico" Else
    End Function

End Class
Imports DataAccess
Imports System.Text
Imports System.Security.Cryptography
Public Class Gerente
    Inherits Persona

    Property _contraseña As String
    Private cons As New DBGerente

#Region "Constructores"

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, password As String)
        MyBase.New(ci)
        _contraseña = password
    End Sub

#End Region

#Region "metodos"

    Public Overrides Function ObtenerNombre() As String
        Try
            Return cons.ObtenerNombre(Me._ci)

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Overrides Function ListarPersona() As DataTable
        Try
            Return MyBase.ListarPersona()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Overrides Function ModificarContraseña() As Boolean
        Try
            Return cons.ModificarContraseña(Me._ci, Me._contraseña)

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Overrides Function ModificarP() As Boolean
        Try
            Return MyBase.ModificarP()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Overrides Sub EncriptarContraseña()
        Dim sha256 As SHA256 = sha256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Me._contraseña)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Me._contraseña = stringBuilder.ToString()
    End Sub
    Public Function NomEmasDiag() As ArrayList
        Try

            Return cons.NomEnfMasDiag()
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function CantEnfMasDiag() As ArrayList
        Try
            Return cons.CantEnfMasDiag()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function NomSintMasSelec() As ArrayList
        Try
            Return cons.NomSintMasSelec()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function CantSintMasSelec() As ArrayList
        Try

            Return cons.CantSintMasSelec()
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function MesesChats() As ArrayList
        Try
            Return cons.MesesChat()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function cantChatMes() As ArrayList
        Try
            Return cons.cantChatMeses()

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Overrides Function ComprobarContraseña() As Boolean
        Return cons.ComprobarContraseña(Me._contraseña)
    End Function
#End Region

End Class
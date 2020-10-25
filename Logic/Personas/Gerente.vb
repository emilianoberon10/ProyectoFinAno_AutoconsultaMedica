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
        Dim res As String = ""
        Try
            res = cons.ObtenerNombre(Me._ci)

        Catch ex As Exception
            Throw New SystemException("ObtenerNombre" + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function ListarPersona() As DataTable
        Dim res As DataTable
        Try
            res = MyBase.ListarPersona()

        Catch ex As Exception
            Throw New SystemException("ListarPersona" + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function ModificarContraseña() As Boolean
        Dim res As Boolean = False
        Try
            res = cons.ModificarContraseña(Me._ci, Me._contraseña)

        Catch ex As Exception
            Throw New SystemException("ModificarContraseña" + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function ModificarP() As Boolean
        Dim res As Boolean = False
        Try
            res = MyBase.ModificarP()

        Catch ex As Exception
            Throw New SystemException("ModificarP" + ex.Message)
        End Try
        Return res
    End Function
    Public Overrides Function ComprobarContraseña() As Boolean
        Dim res As Boolean = False
        Try
            res = cons.ComprobarContraseña(Me._contraseña)
        Catch ex As Exception
            Throw New SystemException("ComprobarContraseña" + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Sub EncriptarContraseña()
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Me._contraseña)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Me._contraseña = stringBuilder.ToString()
    End Sub
    Public Function NomEmasDiag() As ArrayList
        Dim res As ArrayList
        Try

            res = cons.NomEnfMasDiag()
        Catch ex As Exception
            Throw New SystemException("NomEmasDiag" + ex.Message)
        End Try
        Return res
    End Function
    Public Function CantEnfMasDiag() As ArrayList
        Dim res As ArrayList
        Try
            res = cons.CantEnfMasDiag()

        Catch ex As Exception
            Throw New SystemException("CantEnfMasDiag" + ex.Message)
        End Try
        Return res
    End Function

    Public Function NomSintMasSelec() As ArrayList
        Dim res As ArrayList
        Try
            res = cons.NomSintMasSelec()

        Catch ex As Exception
            Throw New SystemException("NomSintMasSelec" + ex.Message)
        End Try
        Return res
    End Function
    Public Function CantSintMasSelec() As ArrayList
        Dim res As ArrayList
        Try

            res = cons.CantSintMasSelec()
        Catch ex As Exception
            Throw New SystemException("CantSintMasSelec" + ex.Message)
        End Try
        Return res
    End Function
    Public Function MesesChats() As ArrayList
        Dim res As ArrayList
        Try
            res = cons.MesesChat()

        Catch ex As Exception
            Throw New SystemException("MesesChats" + ex.Message)
        End Try
        Return res
    End Function
    Public Function cantChatMes() As ArrayList
        Dim res As ArrayList
        Try
            res = cons.cantChatMeses()

        Catch ex As Exception
            Throw New SystemException("cantChatMes" + ex.Message)
        End Try
        Return res
    End Function

#End Region

End Class
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
        Return cons.ObtenerNombre(Me._ci)
    End Function

    Public Overrides Function ObtenerNombreEdad() As DataTable
        Return MyBase.ObtenerNombreEdad()
    End Function

    Public Overrides Function ModificarContraseña() As Boolean
        Return cons.ModificarContraseña(Me._ci, Me._contraseña)
    End Function

    Public Overrides Function ModificarP() As Boolean
        Return MyBase.ModificarP()
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
        Return cons.NomEnfMasDiag()
    End Function
    Public Function CantEnfMasDiag() As ArrayList
        Return cons.CantEnfMasDiag()
    End Function

    Public Function NomSintMasSelec() As ArrayList
        Return cons.NomSintMasSelec()
    End Function
    Public Function CantSintMasSelec() As ArrayList
        Return cons.CantSintMasSelec()
    End Function
    Public Function MesesChats() As ArrayList
        Return cons.MesesChat()
    End Function
    Public Function cantChatMes() As ArrayList
        Return cons.cantChatMeses()
    End Function
#End Region

End Class
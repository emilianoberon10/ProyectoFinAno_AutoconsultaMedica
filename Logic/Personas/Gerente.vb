Imports DataAccess

Public Class Gerente
    Inherits Persona

    Protected _password As String
    Private cons As New DBGerente

#Region "Constructores"

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, password As String)
        MyBase.New(ci)
        _password = password
    End Sub

#End Region

#Region "metodos"

    Public Overrides Function ObtenerNombre() As String
        Return cons.ObtenerNombre(Me._ci)
    End Function

#End Region

End Class
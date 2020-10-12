Imports DataAccess

Public MustInherit Class Persona

#Region "Atributos"

    Property _ci As String
    Property _tel_cel As Integer
    Property _edad As Integer
    Property _domicilio As String
    Property _sexo As String
    Property _pNom As String
    Property _sNom As String
    Property _pApe As String
    Property _sApe As String

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ci As String)
        _ci = ci
    End Sub

    Public Sub New(ci As String, tel_cel As Integer, edad As Integer,
                   domicilio As String, sexo As String, pNom As String,
                   sNom As String, pApe As String, sApe As String)
        _ci = ci
        _tel_cel = tel_cel
        _edad = edad
        _domicilio = domicilio
        _sexo = sexo
        _pNom = pNom
        _sNom = sNom
        _pApe = pApe
        _sApe = sApe
    End Sub

#End Region

#Region "Metodos"

    Public Overridable Function Guardar() As Boolean

    End Function

    Public Overridable Function Borrar() As Boolean

    End Function

    Public Overridable Function ModificarContraseña() As Boolean

    End Function
    Public Overridable Function ModificarP() As Boolean
        Dim c As New DBPersona
        With Me
            Return c.UpdatePersona(._ci, ._pNom, ._sNom, ._pApe, ._sApe, ._edad)
        End With
    End Function
    Public Overridable Function ObtenerNombreEdad() As DataTable
        Dim c As New DBPersona
        Return c.GetPersonas(Me._ci)
    End Function

    Public Overridable Function ObtenerNombre() As String

    End Function

    Public Overridable Sub EncriptarContraseña()

    End Sub

#End Region

End Class
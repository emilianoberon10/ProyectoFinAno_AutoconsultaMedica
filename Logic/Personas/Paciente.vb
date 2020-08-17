Imports DataAccess

Public Class Paciente

#Region "Atributos"

    Inherits Persona
    Property _mail As String
    Property _contraseña As String
    Property _fechaNac As Date

#End Region

#Region "construc"

    Public Sub New()

    End Sub

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, contraseña As String)
        MyBase.New(ci)
        _contraseña = contraseña
    End Sub

    Public Sub New(ci As String, mail As String, contraseña As String,
                   tel_cel As Object, edad As Object, domicilio As String,
                   sexo As String, pNom As String, sNom As String,
                   pApe As String, sApe As String, fechaNac As Date)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, sNom, pApe, sApe)
        _mail = mail
        _contraseña = contraseña
        _fechaNac = fechaNac
    End Sub

#End Region

#Region "Metodos"

    Public Sub Selcciona(sintomas As ArrayList, ci As String, dia As String, hora As String)
        Dim cons As New DBSintomas
        cons.GuardarSeleccion(sintomas, ci, dia, hora)
    End Sub

    Public Function Solicita() As Boolean
        Dim cons As New DBPaciente
        Return cons.SolicitaChat(Me._ci, Me._pNom)
    End Function

    Public Function ComprobarChatAceptado()
        Dim cons As New DBPaciente
        Return cons.PreguntarSolicitudAceptada(Me._ci)
    End Function

    Public Function EliminarSolicitudAceptada()
        Dim cons As New DBPaciente
        Return cons.EliminarSolicitudAceptada(Me._ci)
    End Function

    Public Overrides Function Guardar() As Boolean
        Dim cons As New DBPaciente
        Return cons.SetPaciente(Me._ci, Me._mail, Me._contraseña,
                   Me._tel_cel, Me._edad, Me._domicilio,
                   Me._sexo, Me._pNom, Me._sNom,
                   Me._pApe, Me._sApe, Me._fechaNac)
    End Function

    Public Overrides Function Borrar() As Boolean
        Dim cons As New DBPaciente

    End Function

    Public Overrides Function Modificar() As Boolean
        Dim cons As New DBPaciente

    End Function

    Public Overrides Function Listar() As Boolean
        Return MyBase.Listar()
    End Function

    Public Overrides Function ObtenerNombre() As String
        Dim cons As New DBPaciente
        Return cons.ObtenerNombrePaciente(Me._ci)
    End Function

#End Region

End Class
Imports DataAccess
Imports System.Text
Imports System.Security.Cryptography

Public Class Paciente

#Region "Atributos"

    Inherits Persona
    Property _mail As String
    Property _contraseña As String
    Property _edad As Integer
    Property _diagnostico As String
    Private cons As New DBPaciente
    Private consD As New DBDiagnostico

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
                   tel_cel As Object, edad As Integer, domicilio As String,
                   sexo As String, pNom As String, sNom As String,
                   pApe As String, sApe As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, sNom, pApe, sApe)
        _mail = mail
        _contraseña = contraseña
    End Sub

#End Region

#Region "Metodos"

#Region "AMB"

    Public Overrides Function Guardar() As Boolean
        Return cons.SetPaciente(Me._ci, Me._mail, Me._contraseña,
                   Me._tel_cel, Me._edad, Me._domicilio,
                   Me._sexo, Me._pNom, Me._sNom,
                   Me._pApe, Me._sApe)
    End Function

    Public Overrides Function Borrar() As Boolean
        cons.BorrarPaciente(Me._ci)
    End Function

    Public Overrides Function Modificar() As Boolean
        cons.ModificarContraseña(Me._ci, Me._contraseña)
    End Function

    Public Overrides Function Listar() As Boolean
        Return MyBase.Listar()
    End Function

#End Region

#Region "diagnostico"

    Public Sub Selcciona(sintomas As ArrayList)
        Dim cons As New DBSintomas
        cons.GuardarSeleccion(sintomas, Me._ci)
    End Sub

    Public Function Generar() As DataTable
        Return consD.Diagnostico(Me._ci)
    End Function

    Public Function GuardarDiagnostico() As Boolean
        Return consD.GuardarDiagnostico(Me._ci, Me._diagnostico)
    End Function

    Public Function VerDiagnosticos() As DataTable
        Return consD.VerDiagnostico(Me._ci)
    End Function

    Public Function VerDiagnosticosFecha(fecha As String) As DataTable
        Return consD.VerDiagnosticoFecha(Me._ci, fecha)

    End Function

    Public Function VerDiagnosticosEntreFecha(fecha As String, fecha2 As String) As DataTable
        Return consD.VerDiagnosticoEntreFecha(Me._ci, fecha, fecha2)

    End Function

#End Region

#Region "Chat"

    Public Function Solicita() As Boolean
        Return cons.SolicitaChat(Me._ci, Me._pNom)
    End Function

    Public Function ComprobarChatAceptado()
        Return cons.PreguntarSolicitudAceptada(Me._ci)
    End Function

    Public Function EliminarSolicitudAceptada()
        Return cons.EliminarSolicitudAceptada(Me._ci)
    End Function

    Public Function FinalizarChat() As String

    End Function

    Public Function EnviarMsj(msg As String) As Boolean
        Return cons.EnviarMensajePac(Me._ci, msg)
    End Function

    Public Function ComprobarMsj() As String
        Return cons.ComprobarMsjPac(Me._ci)
    End Function

#End Region

    Public Overrides Function ObtenerNombre() As String
        Return cons.ObtenerNombre(Me._ci)
    End Function

    Public Overridable Function GuardarFicha() As Boolean
    End Function

    Public Overridable Function GetFicha() As DataTable
    End Function

    Public Overrides Function EncriptarContraseña() As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Me._contraseña)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

#End Region

End Class
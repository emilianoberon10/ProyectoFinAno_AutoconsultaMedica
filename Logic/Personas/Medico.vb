Imports DataAccess

Public Class Medico
    Inherits Persona
    Property _numMed As Integer
    Property _especialidad As String
    Property _lugarTrabajo As String
    Property _contraseña As String
    Property _horario As String
    Private cons As New DBMedicos

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, contraseña As String)
        MyBase.New(ci)
        _contraseña = contraseña
    End Sub

    Public Sub New(ci As String, tel_cel As Integer, edad As Integer,
                   domicilio As String, sexo As String, sNom As String,
                   pNom As String, pApe As String, sApe As String, especialidad As String, lugarTrabajo As String, contraseña As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, pApe, sNom, sApe)
        _especialidad = especialidad
        _lugarTrabajo = lugarTrabajo
        _contraseña = contraseña
    End Sub

#End Region

#Region "Metodos"

#Region "ABM"

    Public Overloads Function Listar() As DataTable
        Return cons.ObtenerMedicos()
    End Function

    Public Overloads Function Guardar() As Boolean
        Return cons.SetMedico(Me._ci, Me._especialidad, Me._numMed, Me._lugarTrabajo, Me._contraseña,
                   Me._tel_cel, Me._domicilio, Me._sexo, Me._pNom, Me._sNom, Me._pApe, Me._sApe, Me._edad)
    End Function

    Public Function SetHorario(dia As String)
        Return cons.SetHorariosMedico(Me._ci, Me._horario, dia)
    End Function

    Public Overloads Function Modificar() As Boolean
        Return cons.ModifMedico(Me._ci, Me._especialidad, Me._numMed)
    End Function

    Public Overloads Function Borrar(ci As String) As Boolean
        Return cons.BorarMedico(ci)
    End Function

    Public Function comboEspec() As DataSet
        Return cons.Especialidades()
    End Function
    Public Function GetCiDb() As String
        Return cons.GetCi(Me._numMed)
    End Function

#End Region

#Region "chat"

    Public Function AceptarChat(ciP As String, idDIag As String)
        Return cons.AceptarChat(Me._ci, ciP, idDIag)
    End Function

    Public Sub FinalizarChat()
        Dim con As New DBChat
        con.Finalizar(Me._ci)
    End Sub

    Public Function ComprobarSoli() As DataTable
        Dim cons As New DBChat
        Return cons.ComprobarSolicitudes()
    End Function

    Public Function EnviarMsj(msg As String) As Boolean
        Return cons.EnviarMensaje(Me._ci, msg)
    End Function

    Public Function ComprobarMsj() As String
        Return cons.ComprobarMsjMed(Me._ci)
    End Function

#End Region

#Region "agenda"

    Public Function Agenda() As DataTable
        Return cons.VerAgenda
    End Function

    Public Function AgendaFiltroEsp(fil As String) As DataTable
        Return cons.VerAgendaFiltradoEsp(fil)
    End Function

    Public Function AgendaFiltroNom(fil As String) As DataTable
        Return cons.VerAgendaFiltradoNombre(fil)
    End Function

#End Region

    Public Function Especialidad() As DataSet
        'especialidades para llenar comboBox
        Return cons.Especialidades
    End Function

    Public Overrides Function ObtenerNombre() As String
        Return cons.ObtenerNombre(Me._numMed)
    End Function

#End Region

End Class
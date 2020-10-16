Imports DataAccess
Imports System.Text
Imports System.Security.Cryptography
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

#Region "ABML"

    Public Function Listar() As DataTable
        Return cons.ObtenerMedicos()
    End Function

    Public Overrides Function ListarPersona() As DataTable
        Return MyBase.ListarPersona()
    End Function

    Public Overloads Function Guardar() As Boolean
        Dim estado As Boolean
        With Me
            If ._ci.Length < 8 OrElse ._ci.Length > 8 Then
                MsgBox("La cedula debe contener 8 caracteres")
            Else
                If ._pNom.Length > 30 OrElse ._sNom.Length > 30 OrElse ._pApe.Length > 30 OrElse ._sApe.Length > 30 Then
                    MsgBox("Algun campo de nombre supera los 30 caracteres")
                Else
                    If ._tel_cel.ToString.Length > 9 OrElse ._tel_cel.ToString.Length < 8 Then
                        MsgBox("El telefono debe contener entre 8 y 9 digitos")
                    Else
                        If ._domicilio.Length > 255 Then
                            MsgBox("el domicilio no puede contener mas de 255 caracters")

                        Else
                            If ._lugarTrabajo.Length > 30 Then
                                Try
                                    estado = cons.SetMedico(Me._ci, Me._especialidad, Me._numMed, Me._lugarTrabajo, Me._contraseña,
                                                                Me._tel_cel, Me._domicilio, Me._sexo, Me._pNom, Me._sNom, Me._pApe, Me._sApe, Me._edad)

                                Catch ex As Exception
                                    Throw New SystemException(ex.Message)
                                End Try

                            End If
                        End If
                    End If
                End If
            End If
        End With
        Return estado
    End Function

    Public Function SetHorario(dia As String)
        Return cons.SetHorariosMedico(Me._ci, Me._horario, dia)
    End Function

    Public Overloads Function Modificar() As Boolean
        Dim estado As Boolean
        With Me
            If ._ci.Length < 8 OrElse ._ci.Length > 8 Then
                MsgBox("La cedula debe contener 8 caracteres")
            Else
                If ._pNom.Length > 30 OrElse ._sNom.Length > 30 OrElse ._pApe.Length > 30 OrElse ._sApe.Length > 30 Then
                    MsgBox("Algun campo de nombre supera los 30 caracteres")
                Else
                    If ._tel_cel.ToString.Length > 9 OrElse ._tel_cel.ToString.Length < 8 Then
                        MsgBox("El telefono debe contener entre 8 y 9 digitos")
                    Else
                        If ._domicilio.Length > 255 OrElse ._lugarTrabajo.Length > 255 Then
                            MsgBox("el domicilio no puede contener mas de 255 caracters")

                        Else
                            If ._lugarTrabajo.Length > 30 Then
                                Try
                                    cons.ModifMedico(._ci, ._especialidad, ._lugarTrabajo,
                                ._tel_cel, ._domicilio, ._sexo, ._pNom, ._sNom, ._pApe, ._sApe, ._edad)

                                Catch ex As Exception
                                    Throw New SystemException(ex.Message)
                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End With
        Return estado
    End Function

    Public Overloads Function Borrar() As Boolean
        Return cons.BorarMedico(Me._ci)
    End Function

    Public Function comboEspec() As DataSet
        Return cons.Especialidades()
    End Function
    Public Function GetCiDb() As String
        Return cons.GetCi(Me._numMed)
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


#End Region

#Region "chat"

    Public Function AceptarChat(ciP As String, idDIag As String)
        Return cons.AceptarChat(Me._ci, ciP, idDIag)
    End Function

    Public Sub FinalizarChat()
        Dim con As New DBChat
        con.Finalizar(Me._ci)
    End Sub
    Public Function CargarChat(idchat) As DataTable
        Dim con As New DBChat
        Return con.DevolverChat(idchat)
    End Function
    Public Function CargarDiagChat(idchat) As String
        Dim con As New DBChat
        Return con.DevolverDiag(idchat)
    End Function
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

    Public Function ModificarDiagnostico(ciPaciente, diag) As Boolean
        Dim c As New DBDiagnostico
        Return c.UpdateDiagnostico(ciPaciente, diag)
    End Function
    Public Function VerChatsAntiguos() As DataTable
        Dim result
        Try
            result = cons.VerChatsAntiguos(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try

        Return result
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
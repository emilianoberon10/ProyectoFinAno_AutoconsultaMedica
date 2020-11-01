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
        Dim res As DataTable
        Try
            res = cons.ObtenerMedicos()
        Catch ex As Exception
            Throw New SystemException("ListarMed: " + ex.Message)
        End Try
        Return res
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
                                MsgBox("El campo Lugar de trabajo supera los 30 caracteres")
                            Else
                                Try
                                    estado = cons.SetMedico(Me._ci, Me._especialidad, Me._numMed, Me._lugarTrabajo, Me._contraseña,
                                                                Me._tel_cel, Me._domicilio, Me._sexo, Me._pNom, Me._sNom, Me._pApe, Me._sApe, Me._edad)

                                Catch ex As Exception
                                    Throw New SystemException("GuardarMed: " + ex.Message)
                                End Try

                            End If
                        End If
                    End If
                End If
            End If
        End With
        Return estado
    End Function

    Public Function SetHorario(dia As String) As Boolean
        Dim res As Boolean
        Try
            res = cons.SetHorariosMedico(Me._ci, Me._horario, dia)
        Catch ex As Exception
            Throw New SystemException("SetHorario: " + ex.Message)
        End Try
        Return res
    End Function

    Public Overloads Function Modificar() As Boolean
        Dim estado As Boolean = False
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
                            If ._lugarTrabajo.Length <= 30 Then
                                Try
                                    estado = cons.ModifMedico(._ci, ._especialidad, ._lugarTrabajo,
                                ._tel_cel, ._domicilio, ._sexo, ._pNom, ._sNom, ._pApe, ._sApe, ._edad)

                                Catch ex As Exception
                                    Throw New SystemException("ModificarMed: " + ex.Message)
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
        Dim res As Boolean = False
        Try
            res = cons.BorarMedico(Me._ci)
        Catch ex As Exception
            Throw New SystemException("BorrarMedico: " & ex.Message)
        End Try
        Return res
    End Function

    Public Function comboEspec() As DataSet
        Dim res As DataSet
        Try
            res = cons.Especialidades()
        Catch ex As Exception
            Throw New SystemException("comboEspec: " + ex.Message)
        End Try
        Return res
    End Function
    Public Function GetCiDb() As String
        Dim res As String
        Try
            res = cons.GetCi(Me._numMed)
        Catch ex As Exception
            Throw New SystemException("GetCiMedico: " + ex.Message)
        End Try
        Return res
    End Function
    Public Overrides Function ModificarContraseña() As Boolean
        Dim res As Boolean
        Try
            res = cons.ModificarContraseña(Me._ci, Me._contraseña)
        Catch ex As Exception
            Throw New SystemException("ModificarContra: " + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function ModificarP() As Boolean
        Return MyBase.ModificarP()
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


#End Region

#Region "chat"

    Public Function AceptarChat(ciP As String, idDIag As String) As Boolean
        Dim result As Boolean
        Try
            result = cons.AceptarChat(Me._ci, ciP, idDIag)
        Catch ex As Exception
            Throw New SystemException("AceptarChat" + ex.Message)
        End Try

        Return result
    End Function

    Public Sub FinalizarChat()
        Dim con As New DBChat
        Try
            con.Finalizar(Me._ci)
        Catch ex As Exception
            Throw New SystemException("FinalizarChat" + ex.Message)
        End Try
    End Sub
    Public Function CargarChat(idchat) As DataTable
        Dim con As New DBChat
        Dim result As DataTable
        Try
            result = con.DevolverChat(idchat)
        Catch ex As Exception
            Throw New SystemException("CargarChat" + ex.Message)
        End Try
        Return result
    End Function
    Public Function CargarDiagChat(idchat) As String
        Dim con As New DBChat
        Dim result As String
        Try
            result = con.DevolverDiag(idchat)
        Catch ex As Exception
            Throw New SystemException("CargarDiagChat" + ex.Message)
        End Try

        Return result
    End Function
    Public Function ComprobarSoli() As DataTable
        Dim cons As New DBChat
        Dim result As DataTable
        Try
            result = cons.ComprobarSolicitudes()
        Catch ex As Exception
            Throw New SystemException("ComprobarSoli" + ex.Message)
        End Try
        Return result
    End Function
    Public Function EnviarMsj(msg As String) As Boolean
        Dim result As Boolean
        Try
            result = cons.EnviarMensaje(Me._ci, msg)
        Catch ex As Exception
            Throw New SystemException("EnviarMsj" + ex.Message)
        End Try

        Return result
    End Function
    Public Function ComprobarMsj() As String
        Return cons.ComprobarMsjMed(Me._ci)
        Dim result As String
        Try
            result = cons.ComprobarMsjMed(Me._ci)
        Catch ex As Exception
            Throw New SystemException("ComprobarMsj" + ex.Message)
        End Try
        Return result
    End Function
    Public Function ModificarDiagnostico(ciPaciente, diag) As Boolean
        Dim c As New DBDiagnostico
        Dim result As Boolean
        Try
            result = c.UpdateDiagnostico(ciPaciente, diag)
        Catch ex As Exception
            Throw New SystemException("ModificarDiagnostico" + ex.Message)
        End Try
        Return result
    End Function
    Public Function VerChatsAntiguos() As DataTable
        Dim result As DataTable
        Try
            result = cons.VerChatsAntiguos(Me._ci)
        Catch ex As Exception
            Throw New SystemException("VerChatsAntiguos" + ex.Message)
        End Try

        Return result
    End Function
#End Region

#Region "agenda"

    Public Function Agenda() As DataTable
        Dim res As DataTable
        Try
            res = cons.VerAgenda
        Catch ex As Exception
            Throw New SystemException("Agenda: " + ex.Message)
        End Try
        Return res
    End Function

    Public Function AgendaFiltroEsp(fil As String) As DataTable
        Dim res As DataTable
        Try
            res = cons.VerAgendaFiltradoEsp(fil)
        Catch ex As Exception
            Throw New SystemException("AgendaFiltroEsp: " + ex.Message)
        End Try
        Return res
    End Function

    Public Function AgendaFiltroNom(fil As String) As DataTable
        Dim res As DataTable
        Try
            res = cons.VerAgendaFiltradoNombre(fil)
        Catch ex As Exception
            Throw New SystemException("AgendaFiltroNom: " + ex.Message)
        End Try
        Return res
    End Function

#End Region

    Public Function Especialidad() As DataSet
        'especialidades para llenar comboBox
        Dim res As DataSet
        Try
            res = cons.Especialidades
        Catch ex As Exception
            Throw New SystemException("Especialidad" + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function ObtenerNombre() As String
        Dim res As String
        Try
            res = cons.ObtenerNombre(Me._numMed)
        Catch ex As Exception
            Throw New SystemException("GetNombre: " + ex.Message)
        End Try
        Return res
    End Function
    Public Overrides Function ComprobarContraseña() As Boolean
        Dim res As Boolean
        Try
            res = cons.ComprobarContraseña(Me._contraseña)
        Catch ex As Exception
            Throw New SystemException("GetNombre: " + ex.Message)
        End Try
        Return Res
    End Function
#End Region

End Class
Imports DataAccess
Imports System.Text
Imports System.Security.Cryptography

Public Class Paciente : Inherits Persona

#Region "Atributos"
    Property _mail As String
    Property _contraseña As String
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
                        If ._domicilio.Length > 255 OrElse ._mail.Length > 255 Then
                            MsgBox("el domicilio o mail no puede contener mas de 255 caracters")

                        Else
                            If ._mail.Contains("@gmail.com") OrElse ._mail.Contains("@hotmail.com") Then
                                Try
                                    estado = cons.SetPaciente(._ci, ._mail, ._contraseña,
                                                              ._tel_cel, ._edad, ._domicilio,
                                                              ._sexo, ._pNom, ._sNom, ._pApe, ._sApe)

                                Catch ex As Exception
                                    Throw New SystemException(ex.Message)
                                End Try
                            Else
                                MsgBox("Ingrese un formato de correo correcto")
                            End If
                        End If
                    End If
                End If
            End If
        End With
        Return estado
    End Function

    Public Overrides Function Borrar() As Boolean
        Try
            Return cons.BorrarPaciente(Me._ci)
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

    Public Overrides Function ListarPersona() As DataTable
        Try
            Return MyBase.ListarPersona()
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
    Public Overrides Function ObtenerNombre() As String
        Try
            Return cons.ObtenerNombre(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function ObtenerCorreo() As Boolean
        Return cons.ObtenerCorreo(Me._ci)
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

#Region "diagnostico"

    Public Sub Selcciona(sintomas As ArrayList)
        Try
            Dim cons As New DBSintomas
            cons.GuardarSeleccion(sintomas, Me._ci)

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Sub

    Public Function Generar() As DataTable
        Try
            Return consD.Diagnostico(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function GuardarDiagnostico() As Boolean
        Try
            Return consD.GuardarDiagnostico(Me._ci, Me._diagnostico)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function VerDiagnosticos() As DataTable
        Try
            Return consD.VerDiagnostico(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function VerDiagnosticosFecha(fecha As String) As DataTable
        Try
            Return consD.VerDiagnosticoFecha(Me._ci, fecha)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try

    End Function

    Public Function VerDiagnosticosEntreFecha(fecha As String, fecha2 As String) As DataTable
        Try
            Return consD.VerDiagnosticoEntreFecha(Me._ci, fecha, fecha2)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try

    End Function

#End Region

#Region "Chat"

    Public Function Solicita() As Boolean
        Try
            Return cons.SolicitaChat(Me._ci, Me._pNom)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function ComprobarChatAceptado()
        Try
            Return cons.PreguntarSolicitudAceptada(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function EliminarSolicitudAceptada()
        Try
            Return cons.EliminarSolicitudAceptada(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function CancelarSolicitud()
        Try
            Return cons.CancelarSolicitud(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Sub FinalizarChat()
        Try
            Dim con As New DBChat
            con.Finalizar(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Sub

    Public Function EnviarMsj(msg As String) As Boolean
        Try
            Return cons.EnviarMensajePac(Me._ci, msg)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function

    Public Function ComprobarMsj() As String
        Try
            Return cons.ComprobarMsjPac(Me._ci)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
    End Function
    Public Function EnviarChatPorCorreo() As Boolean
        Dim c As New DBEnvioCorreo
        Return c.EnviarCorreo(Me._ci, Me._mail)
    End Function
#End Region


    Public Overridable Function GuardarFicha() As Boolean
    End Function

    Public Overridable Function GetFicha() As DataTable
    End Function

    Public Overrides Function ComprobarContraseña() As Boolean
        Return cons.ComprobarContraseña(Me._contraseña)
    End Function

#End Region

End Class
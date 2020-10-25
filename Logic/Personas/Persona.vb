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
                        Try
                            estado = c.UpdatePersona(._ci, ._pNom, ._sNom, ._pApe, ._sApe, ._edad, ._tel_cel, ._domicilio)
                        Catch ex As Exception
                            Throw New SystemException("ModificarP: " + ex.Message)
                        End Try
                    End If
                End If
            End If
        End With
        Return estado
    End Function
    Public Overridable Function ListarPersona() As DataTable
        Dim c As New DBPersona
        Dim res As DataTable
        Try
            res = c.GetPersonas(Me._ci)
        Catch ex As Exception
            Throw New SystemException("ListarPersona: " + ex.Message)
        End Try
        Return res
    End Function

    Public Overridable Function ObtenerNombre() As String

    End Function

    Public Overridable Sub EncriptarContraseña()

    End Sub
    Public Overridable Function ComprobarContraseña() As Boolean
    End Function
#End Region

End Class
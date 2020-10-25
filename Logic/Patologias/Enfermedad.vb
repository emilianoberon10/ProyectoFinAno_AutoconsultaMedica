Imports DataAccess

Public Class Enfermedad
    Property _nombre As String
    Property _riesgo As String
    Property _descripcion As String
    Dim consu As New DBEnfermedades()

    Public Sub New()
    End Sub
    Public Sub New(nom As String)
        _nombre = nom
    End Sub
    Public Sub New(nombre As String, riesgo As String, descripcion As String)
        _nombre = nombre
        _riesgo = riesgo
        _descripcion = descripcion
    End Sub

    Public Function ObtenerEnfermedades() As DataTable
        Dim result As DataTable
        Try
            result = consu.ObtenerEnfermedades()
        Catch ex As Exception
            Throw New SystemException("GetEnfermedades: " + ex.Message)
        End Try
        Return result
    End Function
    Public Function ObtenerSintomasEnfermedades() As ArrayList
        Dim result As ArrayList
        Try
            result = consu.ObtenerSintomasEnfermedad(Me._nombre)
        Catch ex As Exception
            Throw New SystemException("GetSintomasEnfermedad: " + ex.Message)
        End Try
        Return result
    End Function

    Public Function GuardarEnfermedad() As Boolean
        Dim result As Boolean = False
        Try
            If Me._nombre.Length <= 30 Then
                If Me._descripcion.Length <= 255 Then
                    result = consu.SetEnfermedad(Me._nombre, Me._riesgo, Me._descripcion)
                Else
                    MsgBox("La descripcion debe contener menos de 255 caracteres")
                End If
            Else
                MsgBox("El nombre debe contener 30 caracteres o menos")
            End If
        Catch ex As Exception
            Throw New SystemException("GuardarEnf: " + ex.Message)
        End Try
        Return result
    End Function

    Public Function ModificarEnfermedad() As Boolean
        Dim result As Boolean = False
        Try
            If Me._nombre.Length <= 30 Then
                If Me._descripcion.Length <= 255 Then

                    result = consu.ModifEnfermedad(Me._nombre, Me._riesgo, Me._descripcion)
                Else
                    MsgBox("La descripcion debe contener menos de 255 caracteres")
                End If
            Else
                MsgBox("El nombre debe contener 30 caracteres o menos")
            End If
        Catch ex As Exception
            Throw New SystemException("ModificarEnfermedad: " + ex.Message)
        End Try
        Return result
    End Function

    Public Function BorrarEnfermedad() As Boolean
        Dim result As Boolean
        Try
            result = consu.BorrarEnfermedad(Me._nombre)

        Catch ex As Exception
            Throw New SystemException("BorrarEnf: " + ex.Message)
        End Try
        Return result
    End Function

    Public Sub ComprobarRiesgo()
        Select Case Me._riesgo
            Case "Azul"
                Me._riesgo = 5
            Case "Verde"
                Me._riesgo = 4
            Case "Amarillo"
                Me._riesgo = 3
            Case "Naranja"
                Me._riesgo = 2
            Case "Rojo"
                Me._riesgo = 1
        End Select
    End Sub

End Class
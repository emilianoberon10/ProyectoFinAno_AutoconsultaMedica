Imports DataAccess

Public Class Enfermedad
    Property _nombre As String
    Property _riesgo As String
    Property _descripcion As String

    Public Sub New()
    End Sub
    Public Sub New(nom)
        _nombre = nom
    End Sub
    Public Sub New(nombre As String, riesgo As String, descripcion As String)
        _nombre = nombre
        _riesgo = riesgo
        _descripcion = descripcion
    End Sub

    Public Function ObtenerEnfermedades() As DataTable
        Dim consu As New DBEnfermedades()
        Return consu.ObtenerEnfermedades()
    End Function
    Public Function ObtenerSintomasEnfermedades() As ArrayList
        Dim consu As New DBEnfermedades()
        Return consu.ObtenerSintomasEnfermedad(Me._nombre)
    End Function

    Public Function GuardarEnfermedad() As Boolean
        Dim result As Boolean = False
        Dim consu As New DBEnfermedades()
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
            Throw New SystemException(ex.Message)
        End Try
        Return result
    End Function

    Public Function ModificarEnfermedad() As Boolean
        Dim result As Boolean = False
        Dim consu As New DBEnfermedades()
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
            Throw New SystemException(ex.Message)
        End Try
        Return result
    End Function

    Public Function BorrarEnfermedad(dato As String) As Boolean
        Dim consu As New DBEnfermedades()
        Dim result As Boolean
        Try
            result = consu.BorrarEnfermedad(dato)

        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
        Return result
    End Function

    Public Sub ComprobarRiesgo()
        Select Case Me._riesgo
            Case "Azul"
                Me._riesgo = 5
            Case "verde"
                Me._riesgo = 4
            Case "amarillo"
                Me._riesgo = 3
            Case "naranja"
                Me._riesgo = 2
            Case "Rojo"
                Me._riesgo = 1
        End Select
    End Sub

End Class
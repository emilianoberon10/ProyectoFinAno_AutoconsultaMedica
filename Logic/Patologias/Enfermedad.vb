Imports DataAccess

Public Class Enfermedad
    Property _nombre As String
    Property _riesgo As String
    Property _descripcion As String

    Public Sub New()
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

    Public Function GuardarEnfermedad() As Boolean
        Dim consu As New DBEnfermedades()
        Return consu.SetEnfermedad(Me._nombre, Me._riesgo, Me._descripcion)

    End Function

    Public Function ModificarEnfermedad() As Boolean
        Dim consu As New DBEnfermedades()

        Return consu.ModifEnfermedad(Me._nombre, Me._riesgo, Me._descripcion)

    End Function

    Public Function BorrarEnfermedad(dato As String) As Boolean
        Dim consu As New DBEnfermedades()
        Return consu.BorrarEnfermedad(dato)
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
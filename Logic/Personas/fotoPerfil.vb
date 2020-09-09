Imports DataAccess

Public Class fotoPerfil : Inherits Persona

    Property foto As String

    Public Sub New(ci As String, foto As String)
        MyBase.New(ci)
        Me.foto = foto
    End Sub

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Overloads Function Guardar() As Boolean
        Dim db As New DBImagen
        Return db.Guardar(Me._ci, Me.foto)
    End Function

    Public Overloads Function Obtener() As String
        Dim db As New DBImagen
        Return db.TraerImagen(Me._ci)
    End Function

End Class
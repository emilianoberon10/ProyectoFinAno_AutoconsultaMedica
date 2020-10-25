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
        Dim res As Boolean = False
        Try
            res = db.Guardar(Me._ci, Me.foto)

        Catch ex As Exception
            Throw New SystemException("GuardarImagen: " + ex.Message)
        End Try
        Return res
    End Function

    Public Overloads Function Obtener() As String
        Dim db As New DBImagen
        Dim res As String = ""
        Try
            res = db.TraerImagen(Me._ci)
        Catch ex As Exception
            Throw New SystemException("GuardarImagen: " + ex.Message)
        End Try
        Return Res
    End Function

End Class
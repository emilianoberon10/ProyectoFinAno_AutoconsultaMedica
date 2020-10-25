Imports DataAccess

Public Class Define

    Property _enfermedad As String
    Property _sintomas As ArrayList
    Dim cons As New SintomaDefineEnfermedad

    Public Sub New()
    End Sub

    Public Sub New(enfermedad As String, sintomas As ArrayList)
        _enfermedad = enfermedad
        _sintomas = sintomas
    End Sub

    Public Function GuardarDefine() As Boolean
        Dim result As Boolean

        'Pasar los objetos a un arrayList para convertirlo en string

        'se va a guradar tantas veces como sitomas haya 1 enfermedad esta definida por 1..* sintomas
        Try
            For Each e As String In Me._sintomas
                result = cons.SetDefine(Me._enfermedad, e)
            Next
        Catch ex As Exception
            Throw New SystemException("GuardarDefine: " + ex.Message)
        End Try

        Return result
    End Function

    Public Function BorrarDefine(def As Define) As Boolean
        Dim result As Boolean
        Try
            result = cons.BorrarDefine(def._enfermedad)
        Catch ex As Exception
            Throw New SystemException("BorrarDefine: " + ex.Message)
        End Try

        Return result
    End Function

    Public Function ModifDefine() As Boolean
        Dim res As Boolean = False
        'Pasar los objetos a un arrayList para convertirlo en string
        Dim sintomas As New ArrayList
        sintomas.Add(Me._sintomas)
        Try
            For Each e As String In sintomas
                'se va a guradar tantas veces como sitomas haya
                res = cons.ModifDefine(Me._enfermedad, e)
            Next
        Catch ex As Exception
            Throw New SystemException("ModifDefine: " + ex.Message)

        End Try

        Return res
    End Function

End Class
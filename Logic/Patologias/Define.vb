Imports DataAccess

Public Class Define

    Property _enfermedad As String
    Property _sintomas As ArrayList

    Public Sub New()
    End Sub

    Public Sub New(enfermedad As String, sintomas As ArrayList)
        _enfermedad = enfermedad
        _sintomas = sintomas
    End Sub

    Public Function GuardarDefine() As Boolean
        Dim cons As New SintomaDefineEnfermedad
        Dim result As Boolean

        'Pasar los objetos a un arrayList para convertirlo en string

        'se va a guradar tantas veces como sitomas haya 1 enfermedad esta definida por 1..* sintomas

        For Each e As String In Me._sintomas
            result = cons.SetDefine(Me._enfermedad, e)
        Next

        Return result
    End Function

    Public Function BorrarDefine(def As Define) As Boolean
        Dim cons As New SintomaDefineEnfermedad
        cons.BorrarDefine(def._enfermedad)
    End Function

    Public Function ModifDefine(def As Define) As Boolean
        Dim cons As New SintomaDefineEnfermedad

        'Pasar los objetos a un arrayList para convertirlo en string
        Dim sintomas As New ArrayList
        sintomas.Add(def._sintomas)

        For Each e As String In sintomas
            'se va a guradar tantas veces como sitomas haya
            '1 enfermedad esta definida por 1..* sintomas
            Return cons.ModifDefine(def._enfermedad, e)
        Next
    End Function

End Class
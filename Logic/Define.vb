Imports DataAccess

Public Class Define

    Property _enfermedad As String
    Property _sintomas As List(Of Sintoma)

    Public Sub New()
    End Sub

    Public Sub New(enfermedad As String, sintomas As List(Of Sintoma))
        _enfermedad = enfermedad
        _sintomas = sintomas
    End Sub

    Public Function GuardarDefine(def As Define) As Boolean
        Dim cons As New SintomaDefineEnfermedad

        'Pasar los objetos a un arrayList para convertirlo en string
        Dim sintomas As New ArrayList
        sintomas.Add(def._sintomas)

        For Each e As String In sintomas
            'se va a guradar tantas veces como sitomas haya
            '1 enfermedad esta definida por 1..* sintomas
            Return cons.SetDefine(def._enfermedad, e)
        Next
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
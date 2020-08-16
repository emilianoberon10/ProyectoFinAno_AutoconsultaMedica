Public Class Selecciona
    Property _sintomas As ArrayList
    Property _ci As String

    Public Sub New(sintomas As ArrayList, ci As String)
        For Each element As String In sintomas
            If element IsNot "SINTOMA" Then
                _sintomas.Add(element)
            End If
        Next
        _ci = ci
    End Sub

End Class
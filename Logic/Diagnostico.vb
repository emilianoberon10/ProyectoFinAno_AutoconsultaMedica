Imports DataAccess

Public Class Diagnostico
    Property _idDiag As Integer
    Property _idP As Paciente
    Property _fecha As Date

    Public Sub New()

    End Sub

    Public Sub New(idDiag As Integer, idP As Paciente, fecha As Date)
        _idDiag = idDiag
        _idP = idP
        _fecha = fecha
    End Sub

    Public Function Generar(ci As String) As DataTable
        Dim cons As New DBDiagnostico
        Return cons.Diagnostico(ci)
    End Function

    Public Sub GuardarDiagnostico(ci As String, enfermedad As String)
        Dim cons As New DBDiagnostico
        cons.GuardarDiagnostico(ci, enfermedad)
    End Sub

End Class
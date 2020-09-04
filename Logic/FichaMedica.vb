Imports DataAccess

Public Class FichaMedica : Inherits Paciente
    Property _procedencia As String
    Property _ocupacion As String
    Property _medicacion As String
    Property _motivoConsulta As String
    Property _antecedentes As String

    Public Sub New(ci As String, procedencia As String, ocupacion As String, medicacion As String,
                   motivoConsulta As String, antecedentes As String)
        MyBase.New(ci)
        _procedencia = procedencia
        _ocupacion = ocupacion
        _medicacion = medicacion
        _motivoConsulta = motivoConsulta
        _antecedentes = antecedentes
    End Sub

    Public Overrides Function GuardarFicha() As Boolean
        Dim cons As New DBPaciente
        Return cons.SetFichaMedica(Me._ci, Me._procedencia, Me._ocupacion,
                                   Me._medicacion, Me._motivoConsulta, Me._antecedentes)
    End Function

End Class
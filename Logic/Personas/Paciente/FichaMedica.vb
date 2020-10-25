Imports DataAccess

Public Class FichaMedica : Inherits Paciente
    Property _procedencia As String
    Property _ocupacion As String
    Property _medicacion As String
    Property _motivoConsulta As String
    Property _antecedentes As String

    Public Sub New(ci)
        MyBase.New(ci)
    End Sub

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
        Dim res As Boolean = False
        Try
            res = cons.SetFichaMedica(Me._ci, Me._procedencia, Me._ocupacion, Me._medicacion, Me._motivoConsulta, Me._antecedentes)
        Catch ex As Exception
            Throw New SystemException("GuardarFicha: " + ex.Message)
        End Try
        Return res
    End Function

    Public Overrides Function GetFicha() As DataTable
        Dim cons As New DBPaciente
        Dim res As DataTable
        Try
            res = cons.GetFichaMedica(Me._ci)
        Catch ex As Exception
            Throw New SystemException("GetFicha: " + ex.Message)
        End Try
        Return Res
    End Function

End Class
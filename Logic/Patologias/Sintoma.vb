Imports DataAccess

Public Class Sintoma
    Property _nombre As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String)
        _nombre = nombre
    End Sub

    Public Function ObtenerSintomas() As DataTable
        Dim consu As New DBSintomas()
        Return consu.ObtenerSintomas()
    End Function

    Public Function DevolverSintomaComboBox() As DataSet
        Dim consu As New DBSintomas()
        Return consu.DevolverSintomaComboBox()
    End Function

    Public Function GuardarSintomas() As Boolean
        Dim consu As New DBSintomas()
        Dim result As Boolean
        Try
            result = consu.SetSintoma(Me._nombre)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
        Return result
    End Function

    Public Function ModificarSintoma() As Boolean
        Dim consu As New DBSintomas()
        Return consu.ModifSintomas(Me._nombre)
    End Function

    Public Function BorrarSintoma() As Boolean
        Dim consu As New DBSintomas()
        Dim result As Boolean
        Try
            result = consu.BorrarSintoma(Me._nombre)
        Catch ex As Exception
            Throw New SystemException(ex.Message)
        End Try
        Return result
    End Function

    Public Sub Limpiar(ci)
        Dim cons As New DBSintomas
        cons.LimpiarSeleccion(ci)
    End Sub

End Class
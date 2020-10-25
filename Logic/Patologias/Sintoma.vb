Imports DataAccess

Public Class Sintoma
    Property _nombre As String
    Property _id As Integer
    Dim consu As New DBSintomas()

    Public Sub New()
    End Sub
    Public Sub New(nombre As String)
        _nombre = nombre
    End Sub
    Public Sub New(nombre, id)
        _nombre = nombre
        _id = id
    End Sub


    Public Function ObtenerSintomas() As DataTable
        Dim result As DataTable
        Try
            result = consu.ObtenerSintomas()
        Catch ex As Exception
            Throw New SystemException("ObtenerSintomas: " + ex.Message)
        End Try

        Return result
    End Function

    Public Function DevolverSintomaComboBox() As DataSet
        Dim result As DataSet
        Try
            result = consu.DevolverSintomaComboBox()
        Catch ex As Exception
            Throw New SystemException("ObtenerSintomasCombo: " + ex.Message)
        End Try

        Return result
    End Function

    Public Function GuardarSintomas() As Boolean
        Dim result As Boolean
        Try
            result = consu.SetSintoma(Me._nombre)
        Catch ex As Exception
            Throw New SystemException("GuardarSintomas: " + ex.Message)
        End Try
        Return result
    End Function

    Public Function ModificarSintoma() As Boolean
        Dim result As Boolean
        Try
            result = consu.ModifSintomas(Me._nombre, Me._id)
        Catch ex As Exception
            Throw New SystemException("ModificarSint: " + ex.Message)
        End Try
        Return result
    End Function

    Public Function BorrarSintoma() As Boolean
        Dim result As Boolean
        Try
            result = consu.BorrarSintoma(Me._nombre)
        Catch ex As Exception
            Throw New SystemException("BorrarSintomas: " + ex.Message)
        End Try
        Return result
    End Function

    Public Sub Limpiar(ci)
        consu.LimpiarSeleccion(ci)
    End Sub

End Class
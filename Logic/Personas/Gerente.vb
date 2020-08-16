Public Class Gerente
    Inherits Persona

    Protected _password As String

    Public Sub New(ci As String)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As String, password As String)
        MyBase.New(ci)
        _password = password
    End Sub

End Class
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestPaciente

    <TestMethod()> Public Sub TestGuradarPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "53498403"
            ._contraseña = "pacientecontraseña"
            ._domicilio = "Emilio Ranha 2351"
            ._edad = 19
            ._mail = "beron10@gmail.com"
            ._pNom = "Emiliano"
            ._sNom = ""
            ._pApe = "Berón"
            ._sApe = "Martinel"
            ._sexo = "Hombre"
            ._tel_cel = "25223455"
            .EncriptarContraseña()
        End With

        actual = paciente.Guardar

        Assert.AreEqual(actual, esperado)

    End Sub
    <TestMethod()> Public Sub TestBorrarPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "88888888"
        End With

        actual = paciente.Borrar

        Assert.AreEqual(actual, esperado)

    End Sub
    <TestMethod()> Public Sub TestModificarPersona()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "22222222"
            ._domicilio = "Emilio Ranha 2351"
            ._edad = 28
            ._pNom = "Mateoasdddddd"
            ._sNom = ""
            ._pApe = "Vargas"
            ._sApe = "Girino"
            ._tel_cel = 25072542
        End With

        actual = paciente.ModificarP

        Assert.AreEqual(actual, esperado)

    End Sub
    <TestMethod()> Public Sub TestCambiarContraseña()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "22222222"
            ._contraseña = "micontraseña"
        End With

        actual = paciente.ModificarContraseña

        Assert.AreEqual(actual, esperado)

    End Sub
    <TestMethod()> Public Sub TestComprobarPassPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "22222222"
            ._contraseña = "micontraseña"
            .EncriptarContraseña()
        End With

        actual = paciente.ComprobarContraseña

        Assert.AreEqual(actual, esperado)

    End Sub
End Class
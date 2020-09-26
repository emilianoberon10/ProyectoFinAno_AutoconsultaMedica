Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestPaciente

    <TestMethod()> Public Sub TestGuradarPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "53498903"
            ._contraseña = "micontraseña"
            ._domicilio = "Cno.Carrasco 2671"
            ._edad = "19"
            ._edad = "2001-02-10"
            ._mail = "miemail@gmail.com"
            ._pNom = "Emiliano"
            ._sNom = ""
            ._pApe = "Beron"
            ._sApe = "Martinel"
            ._sexo = "Hombre"
            ._tel_cel = "25220455"
        End With

        actual = paciente.Guardar

        Assert.AreEqual(actual, esperado)

    End Sub

    <TestMethod()> Public Sub TestCambiarContraseña()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "22222222"
            ._contraseña = "micontraseña"
        End With

        actual = paciente.Modificar

        Assert.AreEqual(actual, esperado)

    End Sub

    <TestMethod()> Public Sub TestConsulta()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        Dim _sintomas As New ArrayList
        _sintomas.Add("tos")
        _sintomas.Add("fiebre")

        With paciente
            ._ci = "55555555"
            ._pNom = .ObtenerNombre
            .Selcciona(_sintomas)
        End With

        Dim enfermedad As String
        enfermedad = "Gripe"
        paciente._diagnostico = enfermedad
        paciente.GuardarDiagnostico()

        enfermedad = "Covid"
        paciente._diagnostico = enfermedad
        actual = paciente.GuardarDiagnostico()

        Assert.AreEqual(actual, esperado)

    End Sub

    <TestMethod()> Public Sub TestSolicita()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "55555555"
            ._pNom = .ObtenerNombre
        End With

        actual = paciente.Solicita

        Assert.AreEqual(actual, esperado)

    End Sub

End Class
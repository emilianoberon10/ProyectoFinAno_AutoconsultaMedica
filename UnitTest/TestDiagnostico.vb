Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic
<TestClass()> Public Class TestDiagnostico

    <TestMethod()> Public Sub TestConsulta()
        Dim paciente As New Logic.Paciente
        Dim sint As New Sintoma
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

        sint.Limpiar(paciente._ci)

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
    <TestMethod()> Public Sub TestCancelarSolicita()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "55555555"
        End With

        actual = paciente.CancelarSolicitud

        Assert.AreEqual(actual, esperado)
    End Sub
    <TestMethod()> Public Sub TestEliminarSolicita()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With paciente
            ._ci = "55555555"
        End With

        actual = paciente.EliminarSolicitudAceptada

        Assert.AreEqual(actual, esperado)
    End Sub
End Class
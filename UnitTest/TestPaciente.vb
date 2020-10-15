Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestPaciente

    <TestMethod()> Public Sub TestGuradarPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "53498906"
            ._contraseña = "micontraseña"
            ._domicilio = "Emilio Ranha 2351"
            ._edad = 13
            ._mail = "mat.vargas2002@gmail.com"
            ._pNom = "Mateoasdddddddddddddddddddddddddddddddddklnaslngkksdfngknaksdfngnadfgnnsangpnsadgpsndgpnaspgnpasdngpnsdfpgnapdfngpangpngnoijnhóihngoihjaogiionhoidfhngnandfgkndaflgnkfdognsdngpna´{dpfgnpafdgmn"
            ._sNom = ""
            ._pApe = "Vargas"
            ._sApe = "Girino"
            ._sexo = "Mujer"
            ._tel_cel = "25072542"
            .EncriptarContraseña()
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

        actual = paciente.ModificarContraseña

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
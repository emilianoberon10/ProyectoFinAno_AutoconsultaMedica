Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestEnfermedadSintoma

    <TestMethod()> Public Sub TestGuardarSintoma()
        Dim sintoma As New Logic.Sintoma
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With sintoma
            ._nombre = "Diarrea"
        End With

        actual = sintoma.GuardarSintomas

        Assert.AreEqual(actual, esperado)

    End Sub

    <TestMethod()> Public Sub TestGuardarEnfermedad()
        Dim enfermedad As New Logic.Enfermedad
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With enfermedad
            ._nombre = "Sifilis"
            ._riesgo = "Verde"
            ._descripcion = "Enfermedad"
        End With
        actual = enfermedad.GuardarEnfermedad
        Assert.AreEqual(actual, esperado)

    End Sub

End Class
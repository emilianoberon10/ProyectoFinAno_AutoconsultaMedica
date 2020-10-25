Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestEnfermedadSintoma

#Region "Sints"
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
    <TestMethod()> Public Sub TestBorrarSintoma()
        Dim sintoma As New Logic.Sintoma
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With sintoma
            ._nombre = "sudores nocturnos"
        End With

        actual = sintoma.BorrarSintoma

        Assert.AreEqual(actual, esperado)

    End Sub
    <TestMethod()> Public Sub TestModifSintoma()
        Dim sintoma As New Logic.Sintoma
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With sintoma
            ._id = 12
            ._nombre = "agotamiento"
        End With

        actual = sintoma.ModificarSintoma

        Assert.AreEqual(actual, esperado)

    End Sub
#End Region
#Region "enfe"
    <TestMethod()> Public Sub TestGuardarEnfermedad()
        Dim enfermedad As New Logic.Enfermedad
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With enfermedad
            ._nombre = "Sifilis"
            ._riesgo = "Verde"
            ._descripcion = "Enfermedad"
            .ComprobarRiesgo()
        End With
        actual = enfermedad.GuardarEnfermedad
        Assert.AreEqual(actual, esperado)
    End Sub
    <TestMethod()> Public Sub TestBorrarEnfermedad()
        Dim enfermedad As New Logic.Enfermedad
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With enfermedad
            ._nombre = "leucemia"
        End With
        actual = enfermedad.BorrarEnfermedad
        Assert.AreEqual(actual, esperado)
    End Sub
    <TestMethod()> Public Sub TestModificarEnfermedad()
        Dim enfermedad As New Logic.Enfermedad
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With enfermedad
            ._nombre = "Sifilis"
            ._riesgo = "Amarillo"
            ._descripcion = "Enfermedad"
            .ComprobarRiesgo()
        End With
        actual = enfermedad.ModificarEnfermedad
        Assert.AreEqual(actual, esperado)
    End Sub

#End Region

End Class
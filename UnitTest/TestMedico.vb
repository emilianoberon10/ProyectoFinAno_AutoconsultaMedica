Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestMedico

    <TestMethod()> Public Sub TestGuardarMedico()
        Dim medico As New Logic.Medico
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With medico
            ._ci = "53499903"
            ._contraseña = "contraseñayo"
            ._domicilio = "Cno.Carrasco 2671"
            ._edad = "46"
            ._pNom = "Sandra"
            ._sNom = ""
            ._pApe = "Buloc"
            ._sApe = "Martinez"
            ._sexo = "Mujer"
            ._tel_cel = "26224587"
            ._especialidad = "Medico General"
            ._lugarTrabajo = "Medica Uruguaya"
            ._numMed = "956"
            .EncriptarContraseña()
        End With
        actual = medico.Guardar
        Assert.AreEqual(actual, esperado)
    End Sub

    <TestMethod()> Public Sub TestGuardarHorarios()
        Dim medico As New Logic.Medico
        Dim esperado As Boolean = False
        Dim actual As Boolean

        medico._ci = "66666666"

        medico._horario = "7:00 a 20:00"
        medico.SetHorario("lun")
        medico._horario = "7:00 a 20:00"
        medico.SetHorario("mar")
        medico._horario = "7:00 a 20:00"
        medico.SetHorario("mie")
        medico._horario = "7:00 a 20:00"
        medico.SetHorario("jue")
        medico._horario = "7:00 a 20:00"
        medico.SetHorario("vie")
        medico._horario = "7:00 a 20:00"
        medico.SetHorario("sab")
        medico._horario = "7:00 a 20:00"
        actual = medico.SetHorario("dom")

        Assert.AreEqual(actual, esperado)
    End Sub
    <TestMethod()> Public Sub TestBorrarMedico()
        Dim medico As New Logic.Medico
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With medico
            ._ci = "53393343"
        End With
        actual = medico.Borrar
        Assert.AreEqual(actual, esperado)
    End Sub
    <TestMethod()> Public Sub TestModificarMedico()
        Dim medico As New Logic.Medico
        Dim esperado As Boolean = True
        Dim actual As Boolean

        With medico
            ._ci = "53499903"
            ._especialidad = "Cardiologo"
            ._lugarTrabajo = "Medica Española"
            ._tel_cel = "26224587"
            ._domicilio = "Cno.Carrasco 2671"
            ._sexo = "Mujer"
            ._pNom = "Sandra"
            ._sNom = ""
            ._pApe = "Buloc"
            ._sApe = "Martinez"
            ._edad = "30"
        End With
        actual = medico.Modificar
        Assert.AreEqual(actual, esperado)
    End Sub

End Class
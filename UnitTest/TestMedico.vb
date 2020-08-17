Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestMedico

    <TestMethod()> Public Sub TestGuardarMedico()
        Dim medico As New Logic.Medico
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With medico
            ._ci = "44499978"
            ._contraseña = "micontraseña"
            ._domicilio = "Cno.Carrasco 2671"
            ._edad = "36"
            ._pNom = "Sandra"
            ._sNom = ""
            ._pApe = "Buloc"
            ._sApe = "Martinez"
            ._sexo = "Mujer"
            ._tel_cel = "26589854"
            ._especialidad = "Medico General"
            ._lugarTrabajo = "Medica Uruguaya"
            ._numMed = "523"
        End With

        actual = medico.Guardar

        Assert.AreEqual(actual, esperado)
    End Sub

End Class